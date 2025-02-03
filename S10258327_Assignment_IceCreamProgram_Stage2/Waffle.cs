// Student Number: S10258327
// Student Name: Joshua Leong Shao En
// Partner Name: Dion Yeo

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using Assignment_IceCreamProgram;

class Waffle : IceCream
{
    private string waffleFlavour;
    public string WaffleFlavour { get; set; }

    public Waffle() { }
    public Waffle(string o, int s, List<Flavour> f, List<Topping> t, string d) : base(o, s, f, t)
    {
        WaffleFlavour = d;
    }
    public override double CalculatePrice()
    {
        double price = 0;
        if (WaffleFlavour.ToLower() == "original")
        {
            if (base.Scoops == 1)
            {
                if (base.Toppings.Count == 0)
                {
                    return 7.0;
                }
                else
                {
                    return 7.0 + 1 * base.Toppings.Count;
                }
            }
            else if (base.Scoops == 2)
            {
                if (base.Toppings.Count == 0)
                {
                    return 8.5;
                }
                else
                {
                    return 8.5 + 1 * base.Toppings.Count;
                }
            }
            else
            {
                if (base.Toppings.Count == 0)
                {
                    return 9.5;
                }
                else
                {
                    return 9.5 + 1 * base.Toppings.Count;
                }
            }
        }
        else
        {
            if (base.Scoops == 1)
            {
                if (base.Toppings.Count == 0)
                {
                    return 10.0;
                }
                else
                {
                    return 10.0 + 1 * base.Toppings.Count;
                }
            }
            else if (base.Scoops == 2)
            {
                if (base.Toppings.Count == 0)
                {
                    return 11.5;
                }
                else
                {
                    return 11.5 + 1 * base.Toppings.Count;
                }
            }
            else
            {
                if (base.Toppings.Count == 0)
                {
                    return 12.5;
                }
                else
                {
                    return 12.5 + 1 * base.Toppings.Count;
                }
            }
        }
    }
    public override string ToString()
    {
        return "Type: " + base.Option + "\nFlavour: " + WaffleFlavour + "\nNo. Scoops: " + base.Scoops;
    }

}