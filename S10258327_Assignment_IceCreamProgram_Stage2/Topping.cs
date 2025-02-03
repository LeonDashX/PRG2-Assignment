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
class Topping
{
    private string type;
    public string Type { get; set; }
    public Topping() { }
    public Topping(string t)
    {
        Type = t;
    }
    public override string ToString()
    {
        return "Type: " + Type;
    }
}