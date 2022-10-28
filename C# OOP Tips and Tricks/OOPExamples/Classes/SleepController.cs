using System;

namespace OOPExamples
{
    class SleepController : ISleep
    {
        public bool isSleeping { get; private set; }
        
        public void ToggleSleep()
        {
            isSleeping = !isSleeping;
        }
    }
}