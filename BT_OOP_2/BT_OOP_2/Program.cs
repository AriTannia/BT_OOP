using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP_2
{
    internal class Program
    {
        static List<Daiso> ds_spvt = new List<Daiso>();
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Random rd1 = new Random();
            for(int i = 0; i < 20; i++)
            {
                if(rd1.Next(0, 2) == 0)
                {
                    TaoSP(rd1.Next(-20, 21), rd1.Next(-20, 21));
                }  
                else
                {
                    TaoVector2D(rd1.Next(-20, 21), rd1.Next(-20, 21));
                }    
            }

            int j = 1;
            ds_spvt.ToList().ForEach(x =>
            {
                Console.WriteLine(new string('-', 70));
                x.Tinh();
                Console.WriteLine(new string('-', 70));
            });
        }

        static void TaoSP(double num1, double num2)
        {
            Random rd = new Random();
            ds_spvt.Add(new SoPhuc(num1, num2));
        }

        static void TaoVector2D(double num1, double num2)
        {
            Random rd = new Random();
            ds_spvt.Add(new Vector_2D(num1, num2));
        }
    }
}
