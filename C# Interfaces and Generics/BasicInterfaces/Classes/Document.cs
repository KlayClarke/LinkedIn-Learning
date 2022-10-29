namespace BasicInterfaces
{
    // TODO: Define an IStorable interface that provides the ability to load and save info for an object
    
    // TODO: Implement IStorable on the Document class
    class Document : IStorable
    {
        private string name;
        
        public Document(string s)
        {
            name = s;
            Console.WriteLine($"Created a document with name {name}");
            
        }
        
        // TODO: Implement the IStorable interface methods and properties
        public void Save()
        {
            Console.WriteLine("Saving the document!");
        }
        
        public void Load()
        {
            Console.WriteLine("Loading the document!");
        }
        
        public bool NeedsSave 
        {
            get; set;
        }
    }
}