using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP_2
{
    public abstract class Daiso
    {
        public abstract double Tinh();
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

        public override double Tinh()
        {
            double t1 = Math.Pow(phanthuc, 2) + Math.Pow(phanao, 2);
            return Math.Round(Math.Sqrt(t1), 2);
        }

        public override string ToString()
        {
            string dau = (phanao > 0) ? "+" : "";
            return $"Số phức: {phanthuc}{dau}{phanao}i";
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

        public override double Tinh()
        {
            double t1 = Math.Pow(-y, 2) + Math.Pow(x, 2);
            return Math.Round(Math.Sqrt(t1), 2);
        }

        public override string ToString()
        {
            return $"Vector: ({x};{y})\nVector Vuông Góc: ({-y};{x})";
        }
    }
}
