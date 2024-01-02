using Microsoft.VisualBasic;
using System;

namespace ConsoleApp2
{
    //public class Porson
    //{
    //    public string name;
    //    int age;
    //    public int Age
    //    {

    //        get { return age; }
    //        set
    //        {
    //            if (value > 0 && value < 100)
    //            {
    //                age = value;
    //            }
    //            else
    //            {
    //                throw new Exception("Age must be between 1 and 99");
    //            }
    //        }

    //    }



    //    public void Displayperson()
    //    {
    //        Console.WriteLine($"name={name},age={age}");
    //    }



    //}
    public class MyClass
{
    public int Value { get; set; }

    public MyClass(int value)
    {
        Value = value;
    }

    public static MyClass operator +(MyClass obj1, MyClass obj2)
    {
        return new MyClass(obj1.Value + obj2.Value);
    }
}

    public class Programe
    {
        static void Main(string[] args)
        {
            //Porson porson = new Porson();
            //Console.WriteLine("name plade:");
            //porson.name = Console.ReadLine();
            //Console.WriteLine("age:");
            //porson.Age = Convert.ToInt32(Console.ReadLine());
            //porson.Displayperson();
            MyClass obj1 = new MyClass(5);
            MyClass obj2 = new MyClass(10);

            MyClass sum = obj1 + obj2; // Calls the overloaded + operator
            Console.WriteLine(sum.Value); // Output: 15

        }
    }
}


