using System;

namespace OOPExamples
{
    abstract class Computer : IPowerOn
    {
        protected IPowerOn powerController;
        protected string _name = "Unknown";

        public bool isOn {get { return powerController.isOn; } }
        public virtual string name {get => _name; private set => _name = value ;}

        public Computer(string name)
        {
            this.name = name;
            powerController = new PowerController();
        }

        public virtual void TogglePower()
        {
            powerController.TogglePower();
        }
    }
}