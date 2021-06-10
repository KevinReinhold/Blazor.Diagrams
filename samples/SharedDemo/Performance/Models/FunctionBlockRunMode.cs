namespace SharedDemo.Performance.Models
{
    public class FunctionBlockRunMode
    {
        public int CycleFrequency { get; set; }
        public int CycleOffset { get; set; }
        public int CyclePriority { get; set; }
        public FunctionBlockRunModeType Mode { get; set; }
    }
}
