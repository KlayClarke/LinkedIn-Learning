namespace CastingInterfaces
{
    interface IStorable
    // doesn't contain logic, but defines the properties
    // cant be instantiated by self
    {
        void Save();
        
        void Load();
        
        bool NeedsSave { get; set; }
        
    }
}