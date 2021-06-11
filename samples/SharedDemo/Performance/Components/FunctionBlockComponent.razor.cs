using System;
using System.Linq;
using Blazor.Diagrams.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SharedDemo.Performance.Models.Nodes;
using SharedDemo.Performance.Services;

namespace SharedDemo.Performance.Components
{
    public partial class FunctionBlockComponent : ComponentBase, IDisposable
    {
        private PortCollection _portCollection;

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        [Parameter]
        public FunctionBlockNode Node { get; set; }

        public void Dispose()
        {
            Node.ConnectorSelectionChanged -= OnNodeConnectorSelectionChanged;
            GC.SuppressFinalize(this);
        }

        private bool IsImageVisible() => !UIState.SelectedConnectors.Any(c => c.Node.Id == Node.Id && c.Connector.RowIndex <= 3);

        protected override void OnInitialized()
        {
            base.OnInitialized();
            _portCollection = new(JSRuntime);
            Node.ConnectorSelectionChanged += OnNodeConnectorSelectionChanged;
        }

        private void OnNodeConnectorSelectionChanged() => StateHasChanged();
    }
}
