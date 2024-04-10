using CourseworkOOP.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Courses
{
    public class Module : ISaveble
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LessonsPath { get; set; }
        private List<Lesson> lessons;
        [JsonIgnore]
        public List<Lesson> Lessons { get => lessons; }
        public static uint counter;

        public event Action LoadError;
        public event Action SaveError;
        public event Action LoadComplete;
        public event Action SaveComplete;

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
        public Module(uint id, string name, string description, List<Lesson> lessons)
        {
            Id = id;
            Name = name;
            Description = description;
            //IsCompleted = isCompleted;
            //LessonsComplete = lessonsComplete;
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
                SaveError?.Invoke();
                return false;
            }
            catch (Exception e)
            {
                SaveError?.Invoke();
                return false;
            }

            SaveComplete?.Invoke();
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
                LoadError?.Invoke();
                return false;
            }
            catch (Exception e)
            {
                LoadError?.Invoke();
                return false;
            }

            LoadComplete?.Invoke();
            return true;
        }
    }
}
