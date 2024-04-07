namespace CourseworkOOP.Iterfaces
{
    public interface ISaveble
    {
        bool Save(string path);
        bool Load(string path);
        event Action LoadError;
        event Action SaveError; 
        event Action LoadComplete;
        event Action SaveComplete;
    }
}
