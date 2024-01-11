using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Coupon
    {
        private string macoupon;
        private int _tilegiamgia;

        public string Macoupon
        {
            get { return macoupon; }
            set { macoupon = value; }   
        }

        public int Tilegiamgia
        {
            get { return _tilegiamgia; }
            set { _tilegiamgia = value; }
        }

        public Coupon(string macoupon, int tilegiamgia)
        {
            this.macoupon = macoupon;
            Tilegiamgia = tilegiamgia;
        }

        public override string ToString()
        {
            return $"{Macoupon} - {Tilegiamgia} %";
        }
    }
}
