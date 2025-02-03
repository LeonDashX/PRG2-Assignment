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
class PointCard
{
    private int points;
    private int punchcard;
    private string tier;
    public int Points { get; set; }
    public int PunchCard { get; set; }
    public string Tier { get; set; }
    public PointCard() { }
    public PointCard(int points, int punchcard)
    {
        Points = points;
        PunchCard = punchcard;
    }
    public void AddPoints(int points)
    {
        Points += points;
    }
    public void RedeemPoints(int points)
    {
        if (Tier == "Silver" || Tier == "Gold")
        {
            Points -= points;
        }
    }
    public void Punch()
    {
        PunchCard++;
    }
    public override string ToString()
    {
        return "Points: " + Points + "\nPunch card: " + PunchCard + "\nTier: " + Tier;
    }
}