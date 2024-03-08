using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Print
    {
        public static void Print_Write(string filepath, StudentList studentList)
        {
            try
            {
                using (FileStream stream = new FileStream(filepath, FileMode.Create))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(StudentList));
                    xmlSerializer.Serialize(stream, studentList);
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
                StudentList new_stList;
                using (FileStream stream = File.OpenRead(filepath))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(StudentList));
                    new_stList = xmlSerializer.Deserialize(stream) as StudentList;
                }
                
                return new_stList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Message: {ex.ToString()}");
            }
            return null;
        }
    }
}
