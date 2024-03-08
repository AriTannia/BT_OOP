using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Print
    {
        public static void Print_Write(string filepath, StudentList studentList)
        {
            try
            {
                string json = JsonSerializer.Serialize(studentList,
    new JsonSerializerOptions { WriteIndented = true });
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    writer.Write(json);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error Message: {ex.ToString()}");
            }
        }

        public static StudentList Print_Read(string filepath)
        {
            try
            {
                string json = String.Empty;
                using (StreamReader reader = new StreamReader(filepath))
                {
                    json = reader.ReadToEnd();
                }
                StudentList new_stList = JsonSerializer.Deserialize<StudentList>(json);
                return new_stList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Message: {ex.ToString()}");
            }
            throw new ArgumentException("Error Write.");
        }
    }
}
