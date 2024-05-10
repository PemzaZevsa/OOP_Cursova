namespace CourseworkOOP.Iterfaces
{
    public interface ISaveble
    {
        bool Save(string path);
        bool Load(string path);
    }
}
