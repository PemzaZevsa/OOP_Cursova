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
        public uint AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }        
        public string PicturePath { get; set; }
        private double rating;
        public double Rating 
        { 
            get => rating; 
            set 
            {
                if (value > 10 || value < 0)
                {
                    throw new ArgumentException("Wrong rating value");
                }

                if (rating == 0)
                {
                    rating = value;
                    RatingsAmount++;
                }
                else
                {
                    rating = ((rating * RatingsAmount) + value)/(RatingsAmount + 1);
                    RatingsAmount++;
                }
            } 
        }
        public int RatingsAmount {  get; set; }
        private decimal cost;
        public decimal Cost 
        {
            get => cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Wrong cost value");
                }
                else
                {
                    cost = value;
                }
            }
        }
        public uint BoughtCourseAmount { get; set; }
        private List<Teg> tegs;

        public List<Teg> Tegs { get => tegs; set => tegs = value; }

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
            RatingsAmount = 0;
            rating = 0;
            BoughtCourseAmount = 0;
            ModulePath = $"Data\\Courses\\{Id}\\Modules.json";
            PicturePath = $"Data\\Courses\\{Id}\\Icon.bmp";
        }
        public Course(string name, string description)
        {
            Id = counter++;
            Name = name;
            Description = description;
            tegs = new List<Teg>();
            modules = new List<Module>();
            RatingsAmount = 0;
            rating = 0;
            BoughtCourseAmount = 0;
            ModulePath = $"Data\\Courses\\{Id}\\Modules.json";
            PicturePath = $"Data\\Courses\\{Id}\\Icon.bmp";
        }
        public Course(string name, string description, uint author, string authorName, string authorSurname, double rating, int ratingsAmount, decimal cost, List<Teg> tegs, List<Module> modules)
        {
            Id = counter++;
            Name = name;
            Description = description;
            AuthorId = author;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            ModulePath = $"Data\\Courses\\{Id}\\Modules.json";
            PicturePath = $"Data\\Courses\\{Id}\\Icon.bmp";
            Cost = cost;
            Tegs = tegs;
            this.modules = modules;
            this.rating = rating;
            RatingsAmount = ratingsAmount;
        }
        public Course(uint id, string name, string description, uint author, string authorName, string authorSurname, double rating, int ratingsAmount, decimal cost,uint boughtCourseAmount, List<Teg> tegs, List<Module> modules)
        {
            Id = id;
            Name = name;
            Description = description;
            AuthorId = author;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            ModulePath = $"Data\\Courses\\{Id}\\Modules.json";
            PicturePath = $"Data\\Courses\\{Id}\\Icon.bmp";
            Cost = cost;
            BoughtCourseAmount = boughtCourseAmount;
            this.tegs = tegs;
            this.modules = modules;
            Rating = rating;
            RatingsAmount = ratingsAmount;

        }
        public bool Save()
        {
            return Save(ModulePath);
        }
        public bool Save(string path)
        {
            try
            {
                string jsonstring = "";
                jsonstring += JsonSerializer.Serialize<List<Module>>(modules);

                //foreach (var item in modules)
                //{
                //    item.Save(ModulePath);
                //    jsonstring += JsonSerializer.Serialize<Module>(item);
                //    jsonstring += "\n";
                //}
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
            return Load(ModulePath);
        }
        public bool Load(string path)
        {
            //TODO
            try
            {
                string lines = File.ReadAllText(path);
                modules = JsonSerializer.Deserialize<List<Module>>(lines);

                //List<string> lines = File.ReadAllLines(path).ToList();

                //foreach (var item in lines)
                //{
                //    Module? module = JsonSerializer.Deserialize<Module>(item);
                //    if (module != null) 
                //    { 
                //        modules.Add(module);
                //        module.Load(ModulePath);
                //    }
                //}
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
