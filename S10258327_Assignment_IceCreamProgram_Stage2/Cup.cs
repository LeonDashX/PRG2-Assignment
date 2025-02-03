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

class Cup : IceCream
{
    public Cup() { }
    public Cup(string o, int s, List<Flavour> f, List<Topping> t) : base(o, s, f, t) { }
    public override double CalculatePrice()
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
    public override string ToString()
    {
        return "Type: " + base.Option + "\nNo. Scoops: " + base.Scoops;
    }
}
