using Assignment_IceCreamProgram;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Serialization;

Dictionary<string, Customer> Customers = new Dictionary<string, Customer>();

string[] customerObjectCreation = File.ReadAllLines("customers.csv");
for (int i = 1;  i < customerObjectCreation.Length; i++)
{
    if (i != 0)
    {
        string customerObject = customerObjectCreation[i];
        string[] c = customerObject.Split(',');
        Customer customer = new Customer(c[0], Convert.ToInt32(c[1]), DateTime.ParseExact(c[2], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));
        customer.Rewards = new PointCard(Convert.ToInt32(c[4]), Convert.ToInt32(c[5]));
        customer.Rewards.Tier = c[3];
        Customers.Add(c[1], customer);
    }
}

int option = 0;
while (true)
{
    while (true)
    {
        Console.Write("----------Ice Cream Shop :D----------\n" +
                "[1] Display all customer information\n" +
                "[2] Display all current orders\n" +
                "[3] Register a new customer\n" +
                "[4] Create a customer's order\n" +
                "[5] Display order details of a customer\n" +
                "[6] Modify order details\n" +
                "[7] Process an order and checkout\n" +
                "[8] Display monthly charged amounts breakdown & total charged amounts for the year\n" +
                "[0] Exit\n" +
                "Enter an option: ");
        try
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0 && a <= 8)
            {
                option = Convert.ToInt32(a);
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid option entered!\n");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nInvalid option entered!\n");
        }
    }
    if (option == 0)
    {
        break;
    }
    else if (option == 1)
    {
        Console.WriteLine();
        DisplayCustomerInfo();
        Console.WriteLine();
    }
    else if (option == 2)
    {
        Console.WriteLine();
        DisplayCurrentOrder();
        Console.WriteLine();
    }
    else if (option == 3)
    {
        Console.WriteLine();
        RegisterNewCustomer();
        Console.WriteLine();
    }
    else if (option == 4)
    {
        Console.WriteLine();
        CreateOrder();
        Console.WriteLine();
    }
}

void DisplayCustomerInfo()
{
    string[] CustomerData = File.ReadAllLines("customers.csv");
    foreach (string CustomerDataItem in CustomerData)
    {
        string[] CustomerDataSplit = CustomerDataItem.Split(',');
        Console.WriteLine($"{CustomerDataSplit[0],-12}{CustomerDataSplit[1],-15}{CustomerDataSplit[2],-15}{CustomerDataSplit[3],-20}{CustomerDataSplit[4],-20}{CustomerDataSplit[5]}");
    }
}

void DisplayCurrentOrder()
{
    List<string> OrderData = new List<string>(File.ReadAllLines("orders.csv"));
    if (OrderData.Count == 12)
    {
        Console.WriteLine("No current orders.");
    }
    else
    {
        foreach(string OrderDataItem in OrderData)
        {
            if (OrderData.IndexOf(OrderDataItem) == 0 || OrderData.IndexOf(OrderDataItem) >= 12)
            {
                string[] a = OrderDataItem.Split(",");
                Console.WriteLine($"{a[0],-4}{a[1],-11}{a[2],-20}{a[3],-20}{a[4],-9}{a[5],-9}{a[6],-9}{a[7],-16}{a[8],-12}{a[9],-12}{a[10],-12}{a[11],-12}{a[12],-12}{a[13],-12}{a[14]}");
            }
        }
    }
}

void RegisterNewCustomer()
{
    Console.Write("Enter Customer Name: ");
    string name = Console.ReadLine();
    Random a = new Random();
    int MemberId = 0;
    string[] CustomerData = File.ReadAllLines("customers.csv");
    MemberId = a.Next(100000,1000000);
    for (int i = 1; i < CustomerData.Length; i++)
    {
        if (MemberId != Convert.ToInt32(CustomerData[i].Split(',')[1]))
        {
            break;
        }
        else
        {
            while (true)
            {
                MemberId = a.Next(1,1000000);
                if (MemberId != Convert.ToInt32(CustomerData[i].Split(',')[1]))
                {
                    break;
                }
            }
            break;
        }
    }
    Console.WriteLine($"Your Member ID is: {MemberId}");
    DateTime DOB = DateTime.Now;
    while (true)
    {
        try
        {
            Console.Write("Enter your date of birth: ");
            string b = Console.ReadLine();
            DOB = DateTime.Parse(b);
            break;
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid date format entered!");
        }
    }
    Customer NewCustomer = new Customer(name, MemberId, DOB);
    NewCustomer.Rewards = new PointCard();
    NewCustomer.Rewards.Points = 0;
    NewCustomer.Rewards.PunchCard = 0;
    using (StreamWriter writer = new StreamWriter("customers.csv", append: true))
    {
        writer.WriteLine($"{name},{MemberId},{DOB.ToString("dd/MM/yyyy")},Ordinary,{NewCustomer.Rewards.Points},{NewCustomer.Rewards.PunchCard}");
    }
    Console.WriteLine("Customer successfully registered!");
    Customers.Add(MemberId.ToString(), NewCustomer);
}

void CreateOrder()
{
    DisplayCustomerInfo();
    Console.WriteLine();
    string SelectedId = "";
    while (true)
    {
        Console.Write("Select a customer by their Member ID: ");
        string b = Console.ReadLine();
        if (Customers.ContainsKey(b))
        {
            SelectedId = b;
            break;
        }
        else
        {
            Console.WriteLine("Customer does not exist.");
        }
    }
    Console.WriteLine();
    int ID2order = Convert.ToInt32(SelectedId);
    Customers[SelectedId].MakeOrder();
}