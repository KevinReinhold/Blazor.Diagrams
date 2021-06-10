using Microsoft.AspNetCore.Components;

namespace SharedDemo.Performance.Components
{
    public partial class FunctionBlockRunModeComponent : ComponentBase
    {
        [Parameter]
        public string CycleFrequency { get; set; }

        [Parameter]
        public string CycleOffset { get; set; }

        [Parameter]
        public string CyclePriority { get; set; }

        [Parameter]
        public string NodeId { get; set; }

        [Parameter]
        public string RunMode { get; set; }

        private bool IsRunModeCycle() => RunMode == "Y";
    }
}
