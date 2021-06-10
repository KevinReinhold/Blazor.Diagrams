using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SharedDemo.Performance.Models;
using SharedDemo.Performance.Services;

namespace SharedDemo.Performance.Components
{
    public partial class FunctionBlockOutputConnectorComponent : ComponentBase
    {
        [Parameter]
        public FunctionBlockNodeConnector NodeConnector { get; set; }

        private void OnPortClick(MouseEventArgs e)
        {
            if (e.CtrlKey)
                UIState.ToggleSelectedConnector(NodeConnector);
            else
                UIState.SetSelectedConnector(NodeConnector);
        }
    }
}
