namespace NETInterfaces
{
    interface IStorable
    // doesn't contain logic, but defines the properties
    // cant be instantiated by self
    {
        void Save();
        
        void Load();
        
        Boolean NeedsSave { get; set; }
        
    }
}