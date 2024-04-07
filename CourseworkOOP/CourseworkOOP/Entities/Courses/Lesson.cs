using CourseworkOOP.Iterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CourseworkOOP.Entities.Courses
{
    public class Lesson : ISaveble
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Materials { get; set; }
        //public bool IsCompleted { get; set; }
        public static uint counter;

        public event Action LoadError;
        public event Action SaveError;
        public event Action LoadComplete;
        public event Action SaveComplete;

        public Lesson()
        {
        }
        public Lesson(string name, string description, string materials)
        {
            Id = counter++;
            Name = name;
            Materials = materials;
        }

        public Lesson(uint id, string name, string materials, bool isCompleted)
        {
            Id = id;
            Name = name;
            Materials = materials;
            //IsCompleted = isCompleted; 
        }
        public void DoLesson()
        {
            throw new NotImplementedException();    
        }

        public void CompleteLesson()
        {
            throw new NotImplementedException();
        }
        public bool Save(string text)
        {
            string path = Materials;

            path += @$"\{Id}\Materials.txt";
            try
            {
                File.WriteAllText(path, text);
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
        public bool Load(string path )
        {
            if (path is null) path = Materials;
            throw new NotImplementedException();
        }
    }
}
