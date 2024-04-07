using CourseworkOOP.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Courses
{
    public class Course : ISaveble
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ModulePath { get; set; }
        public ITeacheble Author { get; set; }
        //public string AuthorId { get; set; } = Guid.NewGuid().ToString();
        public double Rating { get; set; }
        public decimal Cost { get; set; }
        [JsonConverter(typeof(Teg))]
        private List<Teg> tegs;

        public List<Teg> Tegs { get => tegs; }

        private List<Module> modules;
        [JsonIgnore]
        public List<Module> Modules { get => modules; }
        public static uint counter;

        public event Action LoadError;
        public event Action SaveError;
        public event Action LoadComplete;
        public event Action SaveComplete;

        public Course()
        {
            tegs = new List<Teg>();
            modules = new List<Module>();
        }
        public Course(string name, string description)
        {
            Id = counter++;
            Name = name;
            Description = description;
            tegs = new List<Teg>();
            modules = new List<Module>();

            ModulePath = @$"Data\Courses\{Id}";
        }
        public Course(uint id, string name, string description, string modulePath, ITeacheble author, double rating, decimal cost, List<Teg> tegs)
        {
            Id = id;
            Name = name;
            Description = description;
            Author = author;
            ModulePath = modulePath;
            Cost = cost;
            this.tegs = tegs;
            this.modules = new List<Module>();
            Rating = rating;
        }
        public void StartNModule()
        {
            throw new NotImplementedException();
        }
        public bool Save()
        {
            return Save(ModulePath + @"\Modules.txt");
        }
        public bool Save(string path)
        {
            //if (path is null) path = ModulePath + @"\Modules.txt";
            try
            {
                string jsonstring = "";
                foreach (var item in modules)
                {
                    item.Save(ModulePath);
                    jsonstring += JsonSerializer.Serialize<Module>(item);
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
        public bool Load()
        {
            return Load(ModulePath + @"\Modules.txt");
        }
        public bool Load(string path)
        {
            //if (path is null) path = ModulePath + @"\Modules.txt";
            try
            {
                List<string> lines = File.ReadAllLines(path).ToList();

                foreach (var item in lines)
                {
                    Module? module = JsonSerializer.Deserialize<Module>(item);
                    if (module != null) 
                    { 
                        modules.Add(module);
                        module.Load(ModulePath);
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
