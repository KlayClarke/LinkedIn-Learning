namespace OOPExamples 
{
    class Laptop : Computer
    {
        public Display display { get; private set; }

        public Laptop(string name, int width, int height) : base(name)
        {
            display = new Display(width, height);
        }
    }
}