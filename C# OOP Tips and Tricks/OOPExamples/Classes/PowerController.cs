namespace OOPExamples
{
    class PowerController : IPowerOn
    {
        public bool isOn { get; private set; }
        
        public virtual void TogglePower()
        {
            isOn = !isOn;
        }
    }
}