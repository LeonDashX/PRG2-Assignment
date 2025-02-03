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
class Flavour
{
    private string type;
    private bool premium;
    private int quantity;
    public string Type { get; set; }
    public bool Premium { get; set; }
    public int Quantity { get; set; }
    public Flavour() { }
    public Flavour(string t, bool p, int q)
    {
        Type = t;
        Premium = p;
        quantity = q;
    }
    public override string ToString()
    {
        return "Type: " + Type + "\nPremium?: " + Premium + "\nQuantity: " + Quantity;
    }
}