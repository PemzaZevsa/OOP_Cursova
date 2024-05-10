using CourseworkOOP.Iterfaces;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Courses
{
    public class Module : ISaveble
    {
        public uint Id { get; set; }
        private string name;
        public string Name { 
            get => name;
            set 
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Занадто коротка назва модуля", nameof(value));
                }
                name = value;
            }
        }
        private string description;
        public string Description { 
            get => description;
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Занадто короткий опис модуля", nameof(value));
                }
                description = value;
            }
        }
        private List<Lesson> lessons;
        public List<Lesson> Lessons { get => lessons; set => lessons = value; }
        public static uint counter;

        public Module()
        {
            lessons = new List<Lesson>();
        }
        public Module(string name, string description)
        {
            Id = counter++;
            Name = name;
            Description = description;
            lessons = new List<Lesson>();
        }
        public Module( string name, string description, List<Lesson> lessons)
        {
            Id = counter++;
            Name = name;
            Description = description;
            this.lessons = lessons;
        }
        public Module(uint id, string name, string description, List<Lesson> lessons)
        {
            Id = id;
            Name = name;
            Description = description;
            this.lessons = lessons;
        }
        public bool Save(string path)
        {
            path +=@$"\{Id}\Lessons.txt";
            try
            {
                string jsonstring = "";
                foreach (var item in lessons)
                {
                    jsonstring += JsonSerializer.Serialize<Lesson>(item);
                    jsonstring += "\n";
                }
                File.WriteAllText(path, jsonstring);
            }
            catch (IOException e)
            {
                return false;
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        public bool Load(string path)
        {
            path += @$"\{Id}\Lessons.txt";
            try
            {
                List<string> lines = File.ReadAllLines(path).ToList();

                foreach (var item in lines)
                {
                    Lesson? lesson = JsonSerializer.Deserialize<Lesson>(item);
                    if (lesson != null)
                    {
                        lessons.Add(lesson);
                    }
                }
            }
            catch (IOException e)
            {
                return false;
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
