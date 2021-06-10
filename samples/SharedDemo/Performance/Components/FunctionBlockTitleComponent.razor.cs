using Microsoft.AspNetCore.Components;

namespace SharedDemo.Performance.Components
{
    public partial class FunctionBlockTitleComponent : ComponentBase
    {
        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public string NameBackgroundColor { get; set; }

        [Parameter]
        public string NameForeColor { get; set; }
    }
}
