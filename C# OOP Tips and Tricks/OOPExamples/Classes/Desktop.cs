namespace OOPExamples
{
    class Desktop : Computer, ISleep
    {
        private ISleep sleepController;
        public enum CaseType
        {
            Tower, 
            MiniTower
        }

        public bool isSleeping 
        { 
            get {
                return sleepController.isSleeping;
            }
        }
        
        public CaseType caseType {get; private set;}

        public override string name { get => base.name + " " + caseType; } // use base to get parent value after override
        public Desktop(string name, CaseType caseType) : base(name)
        {
            this.caseType = caseType;
            sleepController = new SleepController();
        }

        public void ToggleSleep()
        {
            if (!isOn)
            {
                return;
            }
            sleepController.ToggleSleep();
        } 

        public override void TogglePower()
        {
            if (isSleeping)
            {
                return;
            }
            base.TogglePower();
        }
    }
}