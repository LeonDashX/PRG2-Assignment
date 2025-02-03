// Student Number : S10262477B
// Student Name : Dion Yeo
// Partner Name : Joshua Leong

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using Assignment_IceCreamProgram;
class Customer
{
    int orderNumber = 1;
    private string name;
    private int memberId;
    private DateTime dob;
    private Order currentOrder;
    private List<Order> orderHistory;
    private PointCard rewards;
    public string Name { get; set; }
    public int MemberId { get; set; }
    public DateTime Dob { get; set; }
    public Order CurrentOrder { get; set; }
    public List<Order> OrderHistory { get; set; }
    public PointCard Rewards { get; set; }
    public Customer() { }
    public Customer(string n, int m, DateTime birth)
    {
        Name = n;
        MemberId = m;
        Dob = birth;
    }
    public Order MakeOrder()
    {
        Order newOrder = new Order(MemberId, DateTime.Now.Date);
        while (true)
        {
            Console.Write("[1] Cup\n[2] Cone\n[3] Waffle\nSelect ice cream option: ");
            string option = Console.ReadLine();
            if (option == "1" || option == "2" || option == "3")
            {
                if (option == "2")
                {
                    Cone MakeIceCream = new Cone();
                    MakeIceCream.Option = "Cone";
                    while (true)
                    {
                        Console.Write("Would you like a dipped cone? (Y/N): ");
                        string dipchoice = Console.ReadLine();
                        if (dipchoice.All(Char.IsLetter))
                        {
                            if (dipchoice.ToLower() == "y")
                            {
                                MakeIceCream.Dipped = true;
                                break;
                            }
                            else if (dipchoice.ToLower() == "n")
                            {
                                MakeIceCream.Dipped = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid choice entered.\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid choice entered.\n");
                        }
                    }
                }
                else if (option == "3")
                {
                    Waffle MakeIceCream = new Waffle();
                    MakeIceCream.Option = "Waffle";
                    while (true)
                    {
                        Console.Write("Would you like a different waffle flavour? (Y/N): ");
                        string WaffleFlavourChoice = Console.ReadLine();
                        if (WaffleFlavourChoice.All(Char.IsLetter))
                        {
                            if (WaffleFlavourChoice.ToLower() == "y")
                            {
                                Console.Write("[1] Red Velvet\n[2] Charcoal\n[3] Pandan\nSelect waffle flavour: ");
                                string waffleFlavourOption = Console.ReadLine();
                                if (waffleFlavourOption == "1" || waffleFlavourOption == "2" || waffleFlavourOption == "3")
                                {
                                    if (waffleFlavourOption == "1")
                                    {
                                        MakeIceCream.WaffleFlavour = "Red Velvet";
                                    }
                                    else if (waffleFlavourOption == "2")
                                    {
                                        MakeIceCream.WaffleFlavour = "Charcoal";
                                    }
                                    else
                                    {
                                        MakeIceCream.WaffleFlavour = "Pandan";
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nInvalid option entered.\n");
                                }
                            }
                            else
                            {
                                MakeIceCream.WaffleFlavour = "Original";
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid choice entered.\n");
                        }
                    }
                    IceCream makeIceCream = new Cone();
                }
                else
                {
                    Cup MakIceCream = new Cup();
                }
                int NumOfScoops = 0;
                while (true)
                {
                    Console.Write("How many scoops would you like? (1 to 3 scoops only): ");
                    string s = Console.ReadLine();
                    if (s.All(Char.IsDigit))
                    {
                        NumOfScoops = Convert.ToInt32(s);
                        if (NumOfScoops >= 1 && NumOfScoops <= 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid number of scoops entered.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid number of scoops entered.\n");
                    }
                }
                
                
            }
            else
            {
                Console.WriteLine("\nInvalid option entered.\n");
            }
        }
        OrderHistory.Add(newOrder);
        return newOrder;

    }
    public bool IsBirthday()
    {
        if (DateTime.Now == Dob)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string ToString()
    {
        return "Name: " + Name + "\nMember ID: " + MemberId + "\nBirthday: " + Dob.ToString("dd/MM/yyyy");
    }

}