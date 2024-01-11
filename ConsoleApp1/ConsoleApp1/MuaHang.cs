using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MuaHang
    {
        private List<MatHang> _item_list;
        private List<Coupon> _coupons;

        public List<MatHang> Item_list
        {
            get { return _item_list; }
            set { _item_list = value; }
        }

        public List<Coupon> Coupons
        {
            get { return _coupons; }
            set { _coupons = value; }
        }

        public MuaHang(List<MatHang> item_list, List<Coupon> coupons)
        {
            _item_list = item_list;
            _coupons = coupons;
        }

        List<MatHang> cart = new List<MatHang>();
        Dictionary<string, int> Ite_Cou = new Dictionary<string, int>();

        public void MuaHang_Master()
        {
            bool master_flag = false;
            while(!master_flag)
            {
                Console.Clear();
                Console.WriteLine("F. Tìm Hàng\nB. Mua Hàng\nẤn bất kỳ để thoát");
                string a = Console.ReadLine();
                int b = 0;
                switch (a.ToUpper())
                {
                    case "F":
                        if(Search(ref b))
                        {
                            Console.Write("Mua mặt hàng này (Y/Quay lại bằng bất kỳ nút nào)");
                            string c = Console.ReadLine();
                            if (c.Equals("Y", StringComparison.OrdinalIgnoreCase))
                            {
                                Choosen_Thing(ref master_flag, b);
                            }    
                        }   
                        else
                        {
                            Console.WriteLine("Mặt hàng bạn vừa nhập không tồn tại. Vui lòng nhập lại.");
                            Console.WriteLine("-- Ấn nút bất kỳ để tiếp tục. --");
                            Console.ReadKey();
                        }    
                        break;
                    case "B":
                        Console.Clear();
                        Hienthi(Item_list);

                        Console.Write("Chọn 1 trong số các mặt hàng trên: ");
                        b = Program.Input_I(Item_list.Count);
                        Choosen_Thing(ref master_flag, b - 1);
                        break;
                    default:
                        master_flag = true;
                        break;
                }
            }    
        }
        private bool Search(ref int num)
        {
            Console.Write("Nhập tên sản phẩm mà bạn muốn tìm kiếm: ");
            string a = Console.ReadLine();
            foreach (var item1 in Item_list)
            {
                if (a.Equals(item1.Tenhang, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(item1);
                    num = Item_list.IndexOf(item1);
                    return true;
                }
            }
            return false;
        }
        private void Choosen_Thing(ref bool flag, int a)
        {
            Console.WriteLine($"--- Đã chọn {Item_list[a].Tenhang} ---");
            cart.Add(Item_list[a]);
            Item_list.Remove(Item_list[a]);
            Check_Continue(ref flag);
        }
        private void Check_Continue(ref bool flag)
        {
            bool conti_flag = false;
            while (!conti_flag && !flag)
            {
                string alpha = (Item_list.Count > 0) ? "\nNhấn bất kỳ để tiếp tục mua hàng\n" : "\n";
                Console.WriteLine($"Y.Thanh Toán\nN.Thoát{alpha}");
                string b = Console.ReadLine();
                switch (b.ToUpper())
                {
                    case "Y":
                        Thanhtoan();
                        flag = true;
                        break;
                    case "N":
                        flag = true;
                        break;
                    default:
                        if (Item_list.Count > 0) conti_flag = true;
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Hàng trong kho đã hết. Bạn nên tiến hành thanh toán.");
                        }
                        break;
                }
            }
        }
        private void Thanhtoan()
        {
            int a = 0;
            bool tt_flag = false;
            while (!tt_flag)
            {
                Console.Clear();
                Console.Write("1. Áp dụng Coupon cho từng sản phẩm\n2. Thành Tiền\n");
                a = Program.Input_I(2);
                switch (a)
                {
                    case 1:
                        Coupon_Time();
                        break;
                    case 2:
                        double total = 0;
                        Console.Clear();
                        Hienthi(cart);
                        for (int i = 0; i < cart.Count; i++)
                        {
                            int pc1 = 100 - Thanhtoan_CheckCoupon(cart[i].Tenhang);
                            total += (cart[i].Dongia * ((double)pc1 / 100));
                        }
                        Console.WriteLine("\n" + new string ('-', 35) + "\n");
                        Console.WriteLine($"Thành tiền: {total}");
                        tt_flag = true;
                        break;
                }
            }
        }
        private void Coupon_Time()
        {
            while (true)
            {
                if (Coupons.Count > 0)
                {
                    Hienthi(cart);
                    Console.Write("0. Quay lại\nChọn 1 trong số các mặt hàng trên.\n");
                    int a = Program.Input_I(cart.Count);

                    if (a == 0) break;
                    else if (!Check_Cou_Ite_Dic(cart[a - 1].Tenhang))
                    {
                        Console.Clear();
                        Console.WriteLine($"--- Đã chọn {cart[a - 1].Tenhang} ---");
                        Hienthi(null, Coupons);
                        Console.Write("Chọn 1 trong số các coupon trên: ");
                        int b = Program.Input_I(Coupons.Count);
                        Console.Clear();
                        Console.WriteLine($"--- Đã chọn {Coupons[b - 1].Macoupon} ---");

                        Ite_Cou.Add(cart[a - 1].Tenhang, Coupons[b - 1].Tilegiamgia);
                        Coupons.Remove(Coupons[b - 1]);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Mặt hàng {cart[a - 1].Tenhang} đã được áp mã coupon." +
                            $"\nVui lòng chọn mặt hàng khác");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Không có coupon nào tồn tại.\n -- Ấn một nút bất kỳ để tiếp tục --");
                    Console.ReadKey();
                    break;
                }
            }
        }
        private int Thanhtoan_CheckCoupon(string name)
        {
            int result = 0;
            bool turn = false;
            foreach (var label in Ite_Cou)
            {
                if (label.Key == name)
                {
                    turn = true;
                    result = label.Value;
                    break;
                }
            }
            return (turn) ? result : 0;
        }
        private void Hienthi(List<MatHang> tonkho, List<Coupon> giamgia = null)
        {
            int num = (giamgia == null) ? tonkho.Count : giamgia.Count;
            for (int i = 0; i < num; i++)
            {
                string text = (giamgia == null) ? $"{tonkho[i]}" : $"{giamgia[i]}";
                Console.WriteLine($"{i + 1}|\t{text}");
            }
        }
        private bool Check_Cou_Ite_Dic(string name)
        {
            foreach (var label in Ite_Cou)
            {
                if (label.Key == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
