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

class Cone : IceCream
{
    private bool dipped;
    public bool Dipped { get; set; }

    public Cone() { }
    public Cone(string o, int s, List<Flavour> f, List<Topping> t, bool d) : base(o, s, f, t)
    {
        Dipped = d;
    }
    public override double CalculatePrice()
    {
        double price = 0;
        if (dipped == false)
        {
            if (base.Scoops == 1)
            {
                if (base.Toppings.Count == 0)
                {
                    return 4.0;
                }
                else
                {
                    return 4.0 + 1 * base.Toppings.Count;
                }
            }
            else if (base.Scoops == 2)
            {
                if (base.Toppings.Count == 0)
                {
                    return 5.5;
                }
                else
                {
                    return 5.5 + 1 * base.Toppings.Count;
                }
            }
            else
            {
                if (base.Toppings.Count == 0)
                {
                    return 6.5;
                }
                else
                {
                    return 6.5 + 1 * base.Toppings.Count;
                }
            }
        }
        else
        {
            if (base.Scoops == 1)
            {
                if (base.Toppings.Count == 0)
                {
                    return 6.0;
                }
                else
                {
                    return 6.0 + 1 * base.Toppings.Count;
                }
            }
            else if (base.Scoops == 2)
            {
                if (base.Toppings.Count == 0)
                {
                    return 7.5;
                }
                else
                {
                    return 7.5 + 1 * base.Toppings.Count;
                }
            }
            else
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
        }
    }

    public override string ToString()
    {
        return "Type: " + base.Option + "\nDipped?: " + Dipped + "\nNo. Scoops: " + base.Scoops;
    }

}
