using Microsoft.AspNetCore.Components;

namespace SharedDemo.Performance.Components
{
    public partial class FunctionBlockSelection : ComponentBase
    {
        [Parameter]
        public bool IsSelected { get; set; }
    }
}
