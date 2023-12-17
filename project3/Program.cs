using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace project3
{
    public class PrintBill
    {
        public string item { get; set; }
        public double cost { get; set; }
        public int qty { get; set; }
        public double Bill { get; set; }
    }
    class Program
    {
        List<string> list = new List<string>();
        char c;
        void getmenu()
        {
            do
            {
                Console.WriteLine("1. Idly");
                Console.WriteLine("2. Dosa");
                Console.WriteLine("3. Vada");
                Console.WriteLine("4. Puri");
                Console.Write("Enter you Choice:: ");
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            list.Add("Idly");
                            break;
                        case 2:
                            list.Add("Dosa");
                            break;
                        case 3:
                            list.Add("Vada");
                            break;
                        case 4:
                            list.Add("Puri");
                            break;
                        default:
                            Console.WriteLine("Invalid Choose");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("select menu numbers");
                }
                Console.WriteLine("Do you want to Choose more: Y/N");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'Y' || c == 'y');
        }
        void modifymenu()
        {
            do
            {
                Console.WriteLine("\n1. Add Items");
                Console.WriteLine("2. Modify Item");
                Console.WriteLine("3. Remove item");
                Console.WriteLine("4. Confirm Order");
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            getmenu();
                            Console.WriteLine("Your New Order is:");
                            foreach (string s in list)
                            {
                                Console.Write(s + " ");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter Modify item");
                            string ch = Console.ReadLine();
                            Console.WriteLine("Enter New Item");
                            string ch1 = Console.ReadLine();
                            int index = list.IndexOf(ch);
                            list[index] = ch1;
                            Console.WriteLine("Your New Order is:");
                            foreach (string s in list)
                            {
                                Console.Write(s + " ");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter item To remove");
                            string rm = Console.ReadLine();
                            list.Remove(rm);
                            Console.WriteLine("Your New Order is:");
                            foreach (string s in list)
                            {
                                Console.Write(s + " ");
                            }
                            break;
                        case 4:

                            continue;
                        default:
                            Console.WriteLine("Invalid Choose");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("enter numbers ");
                }
                Console.WriteLine("Do you want to choose again y=yes & n= no");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'Y' || c == 'y');

        }
        void TotalBill()
        {
            Dictionary<string, double> d1 = new Dictionary<string, double>();
            d1["Idly"] = 60;
            d1["Dosa"] = 80;
            d1["Vada"] = 85;
            d1["Puri"] = 40;
            int qt = 0; double BillAmt = 0;
            Dictionary<int, PrintBill> d2 = new Dictionary<int, PrintBill>();
            int i = 1;
            foreach (string s in list)
            {
                PrintBill pb1 = new PrintBill();
                list.Contains(s);
                Console.WriteLine(s + " cost is " + d1[s]);
                Console.WriteLine("enter quantity");
                qt = Convert.ToInt32(Console.ReadLine());
                double Bill = d1[s] * qt;
                BillAmt = BillAmt + Bill;
                d2.Add(i, pb1);
                pb1.item = s;
                pb1.cost = d1[s];
                pb1.qty = qt;
                pb1.Bill = Bill;
                i++;
            }
            Console.WriteLine("Sno  ItemName  Cost  Qty  Bill");
            Console.WriteLine("----------------------------------");
            foreach (int t in d2.Keys)
            {
                Console.WriteLine(t + "     " + d2[t].item + "     " + d2[t].cost + "     " + d2[t].qty + "     " + d2[t].Bill);
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Total Bill                  " + BillAmt);
            Console.WriteLine("----------------------------------");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome:::");
            Program p = new Program();
            p.getmenu();
            Console.WriteLine("Your Order is:");
            foreach(string s in p.list)
            {
                Console.Write(s + " ");
            }
            p.modifymenu();
            p.TotalBill();
            
            Console.Read();
        }
    }
}
