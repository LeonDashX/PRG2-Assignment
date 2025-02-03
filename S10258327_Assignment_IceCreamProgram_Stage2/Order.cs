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

class Order
{
    private int id;
    private DateTime timeReceived;
    private DateTime? timeFulfilled;
    private List<IceCream> iceCreamList;
    public int Id { get; set; }
    public DateTime TimeReceived { get; set; }
    public DateTime? TimeFulfilled { get; set; }
    public List<IceCream> IceCreamList { get; set; } = new List<IceCream>();
    public Order() { }
    public Order(int i, DateTime tR)
    {
        Id = i;
        TimeReceived = tR;
    }
    public void ModifyIceCream(int i)
    {
        List<Flavour> flavours = IceCreamList[i - 1].Flavours;
        List<Topping> toppings = IceCreamList[i - 1].Toppings;
    }
    public void AddIceCream(IceCream iceCream)
    {
        IceCreamList.Add(iceCream);
    }
    public void DeleteIceCream(int i)
    {
        if (IceCreamList.Count > 0)
        {
            IceCreamList.RemoveAt(i);
        }
        else
        {
            Console.WriteLine("Order is empty.");
        }
    }
    public double CalculateTotal()
    {
        if (IceCreamList.Count > 0)
        {
            double total = 0;
            foreach (IceCream iceCream in IceCreamList)
            {
                if (iceCream is Cup)
                {
                    Cup cup = (Cup)iceCream;
                    total += cup.CalculatePrice();
                }
                else if (iceCream is Cone)
                {
                    Cone cone = (Cone)iceCream;
                    total += cone.CalculatePrice();
                }
                else
                {
                    Waffle waffle = (Waffle)iceCream;
                    total += waffle.CalculatePrice();
                }
            }
            return total;
        }
        else
        {
            Console.WriteLine("Order is empty.");
            return 0;
        }
    }
    public override string ToString()
    {
        return "Id: " + Id + "\nTime received: " + TimeReceived + "\nTime finished: " + TimeFulfilled;
    }

}