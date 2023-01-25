BankAccount account_01 = new BankAccount(2000, "James Simpson");
account_01.Deposit(account_01.AccountNumber, 1000);
account_01.PrintAccountInfo(account_01.AccountNumber);

Person person = new Person("Robert", 18);
Console.WriteLine(person.Adress);




class BankAccount
{
    public int AccountNumber { get; private set; }
    public double Balance { get; private set; }
    public string HolderName { get; private set; }
    public static int Accounts;
    private static BankAccount[] bankAccounts = new BankAccount[1];

    public BankAccount(double balance, string holderName)
    {
        if (AccountNumber > 0)
        {
            Array.Resize(ref bankAccounts, AccountNumber);
        }
        bankAccounts[Accounts] = this;
        AccountNumber = Accounts;
        Balance = balance;
        HolderName = holderName;
        Accounts++;
    }

    public void Deposit(int accountNumber, double amount)
    {
        bankAccounts[accountNumber].Balance += amount;
    }

    public void Draw(int accountNumber, double amount)
    {
        if (bankAccounts[accountNumber].Balance < amount)
        {
            throw new ArgumentOutOfRangeException();
        }
        bankAccounts[accountNumber].Balance -= amount;
    }

    public void PrintAccountInfo(int accountNumber)
    {
        Console.WriteLine($"Account index:{accountNumber} Balance:{bankAccounts[accountNumber].Balance}" +
            $" HolderName:{bankAccounts[accountNumber].HolderName}");
    }
}

static class MathHelper
{
    static double PI;

    static MathHelper()
    {
        PI = Math.PI;
    }

    static double Sin(double x)
    {
        return Math.Sin(x);
    }

    static double Cos(double x)
    {
        return Math.Cos(x);
    }

    static double Tan(double x)
    {
        return Math.Tan(x);
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Adress { get; set; }

    public Person()
    {
        Adress = "Address not defined";
    }


    public Person(string name, int age) : this()
    {
        Name = name;
        Age = age;
    }

    public Person(string name, int age, string adress)
    {
        Name = name;
        Age = age;
        Adress = adress;
    }
}

struct Rectangle
{
    double Height;
    double Width;

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double Area(Rectangle rectangle)
    {
        return rectangle.Height * rectangle.Width;
    }

    public double Perimeter(Rectangle rectangle)
    {
        return 2 * (rectangle.Height + rectangle.Width);
    }
}
