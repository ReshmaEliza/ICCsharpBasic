// See https://aka.ms/new-console-template for more information
using Csharp;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
namespace Csharpfun;



class Program
{
    public void getdata()
    {
        Console.WriteLine("Thank You for using our services!");
    }
    static void Main(String[] args)
    {
        Program p = new Program();
        p.getdata();
        Calculator a = new Calculator();
        a.Adddata(1, 2);
        a.Division(300, 5);
        a.Subtract(30, 5);
        a.Multiply(30, 5);

    }
}


