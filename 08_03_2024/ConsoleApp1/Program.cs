using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList studentList = new StudentList();
            studentList.Add(new Student { Id = 1, Name = "Nam", Age = 34 });
            studentList.Add(new Student { Id = 2, Name = "Binh", Age = 35 });
            studentList.Add(new Student { Id = 3, Name = "Minh", Age = 36 });

            string filepath = "data.dat";
            // Request 2
            Print.Print_Write(filepath, studentList);
            // Request 3
            StudentList new_stList = Print.Print_Read(filepath);

            //Read File Turn 1
            foreach (Student student in new_stList.Students)
            {
                Console.WriteLine(student);
            }
            Console.Clear();

            // Request 4
            new_stList.Add(new Student { Id = 4, Name = "Hawk", Age = 31 });
            new_stList.Add(new Student { Id = 5, Name = "Tom", Age = 25 });

            // Request 5
            Print.Print_Write(filepath, new_stList);
            // Request 6
            StudentList new_stList_2 = Print.Print_Read(filepath);

            //Read File Turn 2 - Request 7
            foreach(Student student in new_stList_2.Students)
            {
                Console.WriteLine(student);
            }

        }
    }
}
