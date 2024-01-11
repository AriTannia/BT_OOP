using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MatHang
    {
        private string _mahang;
        private string _tenhang;
        private int _dongia;

        public string Mahang
        {
            get { return _mahang; }
            set { _mahang = value; }
        }

        public string Tenhang
        {
            get { return _tenhang; }
            set { _tenhang = value; }
        }

        public int Dongia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }

        public MatHang(string mahang, string tenhang, int dongia)
        {
            Mahang = mahang;
            Tenhang = tenhang;
            Dongia = dongia;
        }

        public override string ToString()
        {
            return $"{Mahang} - {Tenhang} - {Dongia}";
        }

    }
}
