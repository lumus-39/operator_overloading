using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace operator_overloading
{ 
    public class Shop
{
    private int area;

    public int Area
    {
        get { return area; }
        set { area = value; }
    }

    public Shop(int area)
    {
        this.area = area;
    }

    public static Shop operator +(Shop shop, int increase)
    {
        return new Shop(shop.Area + increase);
    }

    public static Shop operator -(Shop shop, int decrease)
    {
        return new Shop(shop.Area - decrease);
    }

    public static bool operator ==(Shop shop1, Shop shop2)
    {
        return shop1.Area == shop2.Area;
    }

    public static bool operator !=(Shop shop1, Shop shop2)
    {
        return shop1.Area != shop2.Area;
    }

    public static bool operator <(Shop shop1, Shop shop2)
    {
        return shop1.Area < shop2.Area;
    }

    public static bool operator >(Shop shop1, Shop shop2)
    {
        return shop1.Area > shop2.Area;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Shop other = (Shop)obj;
        return this.Area == other.Area;
    }

    public override int GetHashCode()
    {
        return Area.GetHashCode();
    }

    public override string ToString()
    {
        return $"Shop with area {area}";
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            // экземпляры магазина
            Shop shop1 = new Shop(50);
            Shop shop2 = new Shop(40);

            // используем перегруженные операторы
            Shop shop3 = shop1 + 10;
            Shop shop4 = shop2 - 5;

            Console.WriteLine($"shop1: {shop1}");
            Console.WriteLine($"shop2: {shop2}");
            Console.WriteLine($"shop3: {shop3}");
            Console.WriteLine($"shop4: {shop4}");
            Console.WriteLine();

            Console.WriteLine($"shop1 == shop2: {shop1 == shop2}");
            Console.WriteLine($"shop1 != shop2: {shop1 != shop2}");
            Console.WriteLine($"shop1 < shop2: {shop1 < shop2}");
            Console.WriteLine($"shop1 > shop2: {shop1 > shop2}");
            Console.WriteLine();

            Console.WriteLine($"shop1.Equals(shop2): {shop1.Equals(shop2)}");
            Console.WriteLine($"shop1.Equals(shop3): {shop1.Equals(shop3)}");
        }
    }
}