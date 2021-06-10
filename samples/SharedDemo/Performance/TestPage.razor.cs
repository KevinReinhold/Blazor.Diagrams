using System;
using System.Linq;
using Blazor.Diagrams.Core;
using Blazor.Diagrams.Core.Behaviors;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using Blazor.Diagrams.Core.Models.Base;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SharedDemo.Performance.Components;
using SharedDemo.Performance.Models.Nodes;
using SharedDemo.Performance.Models.Ports;
using SharedDemo.Performance.Services;

namespace SharedDemo.Performance
{
    public sealed partial class TestPage : ComponentBase
    {
        private const int DefaultGridSize = 10;

        private int _blockSpawnAmount = 50;
        private Diagram _diagram;
        private int _spawnPointX = 20 - 200;
        private int _spawnPointY = 30;

        public void Dispose()
        {
            _diagram.Links.Added -= OnDiagramLinksAdded;
            _diagram.MouseClick -= OnDiagramMouseClick;
            _diagram.SelectionChanged -= OnDiagramSelectionChanged;
            GC.SuppressFinalize(this);
        }

        private Point GetSpawnPoint()
        {
            if ((_spawnPointX += 200) > 2000)
            {
                _spawnPointX = 20 + _spawnPointY;
                if ((_spawnPointY += 80) > 800)
                    _spawnPointY = 30;
            }
            return new Point(_spawnPointX, _spawnPointY);
        }

        private void InitializeDiagram()
        {
            _diagram = new Diagram(new DiagramOptions()
            {
                AllowMultiSelection = true,
                EnableVirtualization = false,
                GridSize = DefaultGridSize,
                Links = new DiagramLinkOptions()
                {
                    DefaultPathGenerator = PathGenerators.Smooth,
                    DefaultSelectedColor = "rgb(0, 120, 215)"
                },
                Zoom = new DiagramZoomOptions()
                {
                    Inverse = true,
                    Maximum = 8
                }
            });

            _diagram.RegisterModelComponent<FunctionBlockNode, FunctionBlockComponent>();

            _diagram.Links.Added += OnDiagramLinksAdded;
            _diagram.MouseClick += OnDiagramMouseClick;
            _diagram.SelectionChanged += OnDiagramSelectionChanged;
        }

        private void OnDiagramLinksAdded(BaseLinkModel link)
        {
            link.SourceMarker = LinkMarker.NewSquare(6);
            link.TargetMarker = LinkMarker.Arrow;
        }

        private void OnDiagramMouseClick(Model model, MouseEventArgs e)
        {
            if (model is FunctionBlockPort)
                _diagram.UnselectAll();
            else if (model == null)
                UIState.DeselectConnectors();
        }

        private void OnDiagramSelectionChanged(SelectableModel model)
        {
            if (model != null)
                UIState.DeselectConnectors();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            InitializeDiagram();
        }

        private void PerfTestAddLargeBlock()
        {
            for (var i = 0; i < _blockSpawnAmount; i++)
            {
                var fb = FunctionBlockGenerator.CreateLargeBlock(GetSpawnPoint());
                var node = FunctionBlockNodeModelGenerator.Run(fb);
                _diagram.Nodes.Add(node);
            }
        }

        private void PerfTestAddSmallBlock()
        {
            for (var i = 0; i < _blockSpawnAmount; i++)
            {
                var fb = FunctionBlockGenerator.CreateSmallBlock(GetSpawnPoint());
                var node = FunctionBlockNodeModelGenerator.Run(fb);
                _diagram.Nodes.Add(node);
            }
        }

        private void PerfTestAddSmallAndLargeBlocks()
        {
            for (var i = 0; i < _blockSpawnAmount; i++)
            {
                // create small blocks

                var fb = FunctionBlockGenerator.CreateSmallBlock(GetSpawnPoint());
                var node = FunctionBlockNodeModelGenerator.Run(fb);
                _diagram.Nodes.Add(node);

                // create large blocks

                fb = FunctionBlockGenerator.CreateLargeBlock(GetSpawnPoint());
                node = FunctionBlockNodeModelGenerator.Run(fb);
                _diagram.Nodes.Add(node);
            }
        }
    }
}
