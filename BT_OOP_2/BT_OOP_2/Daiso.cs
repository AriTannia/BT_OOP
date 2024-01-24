using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP_2
{
    public abstract class Daiso
    {
        public abstract void Tinh();
    }

    public class SoPhuc : Daiso
    {
        private double phanthuc { get; set; }
        private double phanao { get; set; }
        public SoPhuc(double phanthuc, double phanao)
        {
            this.phanthuc = phanthuc;
            this.phanao = phanao;
        }

        public override void Tinh()
        {
            double t1 = Math.Pow(phanthuc, 2) + Math.Pow(phanao, 2);
            string dau = (phanao > 0) ? "+" : "";
            Console.WriteLine($"Số phức: {phanthuc}{dau}{phanao}i");
            Console.WriteLine("Module: " + Math.Round(Math.Sqrt(t1), 2));
        }
    }

    public class Vector_2D : Daiso
    {
        public double x { get; set; }
        public double y { get; set; }

        public Vector_2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Tinh()
        {
            double x1 = -y;
            double x2 = x;
            Console.WriteLine($"Vector: ({x};{y})\nVector Vuông Góc: ({x1};{x2})");
            double t1 = Math.Pow(x1, 2) + Math.Pow(x2, 2);
            Console.WriteLine("Module: " + Math.Round(Math.Sqrt(t1), 2));
        }
    }
}
