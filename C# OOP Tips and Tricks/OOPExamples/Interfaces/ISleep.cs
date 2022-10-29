namespace OOPExamples
{
    interface ISleep
    {
        // no business logic in interfaces, only api calls themselves
        bool isSleeping { get; }
        void ToggleSleep();
    }
}