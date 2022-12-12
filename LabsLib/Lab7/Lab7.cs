using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace AllLabsProject
{
    internal class Lab7 : AllLabsProject.ILabs
    {
        public void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                Group.AddStudent();
            }
            string[] students = new string[Group.StudentCount()];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Group.StudentsInfo();

                Console.WriteLine(students[i]);

            }



            var jsoneFormater = new DataContractJsonSerializer(typeof(string[]));
            using (var file = new FileStream("students.jsone", FileMode.OpenOrCreate))
            {
                jsoneFormater.WriteObject(file, students);
            }
        }

        public string Description()
        {
            return "Задания лабораторной №7";
        }

        public int Id()
        {
            return 7;
        }

        public string Name()
        {
            return "Сериализация";
        }
    }
}
