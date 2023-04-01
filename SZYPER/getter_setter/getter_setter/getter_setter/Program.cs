using Program;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("janusz", "kowalski", 3);
            p.showData();

            Person kowal = new Person("janusz", "kowalski", 3);
            kowal.getNumer();

            kowal.setAge((byte)(kowal.getAge() + 1));
            kowal.showData();
            kowal._heigth = 30;
            Console.WriteLine(kowal._heigth);
            kowal._weigth = 300;
            Console.WriteLine(kowal._weigth);
            kowal._weigth += 220;
            Console.WriteLine(kowal._weigth);
            Console.WriteLine(kowal.Salary);
        }
    }
}