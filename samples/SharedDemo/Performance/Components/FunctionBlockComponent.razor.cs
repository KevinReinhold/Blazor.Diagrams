using System;
using System.Linq;
using Microsoft.AspNetCore.Components;
using SharedDemo.Performance.Models.Nodes;
using SharedDemo.Performance.Services;

namespace SharedDemo.Performance.Components
{
    public partial class FunctionBlockComponent : ComponentBase, IDisposable
    {
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
            Node.ConnectorSelectionChanged += OnNodeConnectorSelectionChanged;
        }

        private void OnNodeConnectorSelectionChanged() => StateHasChanged();
    }
}
