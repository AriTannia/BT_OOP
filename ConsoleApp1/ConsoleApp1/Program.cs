using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            List<MatHang> item_list = new List<MatHang>();
            List<Coupon> coupons = new List<Coupon>();
            Quantity_Mechandise(item_list, coupons);

            MuaHang giohang = new MuaHang(item_list, coupons);
            giohang.MuaHang_Master();
        }
        static void Quantity_Mechandise(List<MatHang> item_list, List<Coupon> coupons)
        {
            while(true)
            {
                int n;
                Console.Write("Nhập số lượng hàng hóa: ");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    NhapHang(n, item_list);
                    NhapCoupon(coupons);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                }
            }    
        }
        static void NhapHang(int n, List<MatHang> item_list)
        {
            for(int i = 0; i < n; i++)
            {
                string a, b;
                int c, d;
                Console.Write($"Mã hàng No.{i + 1}: ");
                a = Console.ReadLine();
                Console.Write("Tên hàng: ");
                b = Console.ReadLine();
                Console.Write("Số lượng: ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Đơn giá: ");
                d = Convert.ToInt32(Console.ReadLine());
                item_list.Add(new MatHang(a, b, c, d));
            }    
        }
        static void NhapCoupon(List<Coupon> coupons)
        {
            Console.Write("Nhập số lượng Coupon: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n1; i++)
            {
                string a;
                int b;
                Console.Write("Mã Coupon: ");
                a = Console.ReadLine();
                Console.Write("-- Tỉ lệ giảm giá --");
                b = ChoosePercent();
                coupons.Add(new Coupon(a, b));
            }    
        }

        static int ChoosePercent()
        {
            bool flag = false;
            int a = 0;
            while(!flag)
            {
                Console.WriteLine("\n1. 10%\n2. 20%\n3. 25%");
                Console.Write("Hãy chọn 1 trong các tỉ lệ giảm giá trên: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        a = 10;
                        flag = true;
                        break;
                    case 2:
                        a = 20;
                        flag = true;
                        break;
                    case 3:
                        a = 25;
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Vui lòng chỉ chọn từ 1 đến 3.");
                        break;
                }
            }

            return a;
        }

        // Hàm nhập --> tham số List.Count (giới hạn nhập)
        public static int Input_I(int num)
        {
            int a = 0;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out a) && a <= num)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                } 
                    
            }
            return a;
        }
    }
}
