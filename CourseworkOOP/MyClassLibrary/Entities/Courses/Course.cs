using CourseworkOOP.Iterfaces;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Courses
{
    public class Course : ISaveble
    {
        public uint Id { get; set; }
        private string name;
        public string Name {
            get => name;
            set
            {
                if (value.Length < 4) 
                { 
                    throw new ArgumentException("Занадто коротка назва курсу",nameof(value));
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
                    throw new ArgumentException("Занадто короткий опис курсу", nameof(value));
                }
                description = value;
            }
        }
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
        public List<Module> Modules { 
            get => modules; 
            set 
            { 
                if (!value.Any())
                {
                    throw new ArgumentNullException(nameof(value),"Null значення для списку модулів");
                }

                modules = value;
            } 
        }
        public List<uint> RaitedUsersId { get; set; }
        public static uint counter;

        public Course()
        {
            tegs = new List<Teg>();
            modules = new List<Module>();
            RaitedUsersId = new List<uint>();
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
            RaitedUsersId = new List<uint>();
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
            RaitedUsersId = new List<uint>();
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

                File.WriteAllText(path, jsonstring);
            }
            catch (IOException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool Load()
        {
            return Load(ModulePath);
        }
        public bool Load(string path)
        {            
            try
            {
                string lines = File.ReadAllText(path);
                modules = JsonSerializer.Deserialize<List<Module>>(lines);
            }
            catch (IOException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
