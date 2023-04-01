using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Person
    {
        public string firstName = "";
        public string lastName = "";
        byte age = 0;
        float heigth = 0;

        readonly float salary = 10f;

        public float Salary
        {
            get { 
                return salary;
            }
        }
        public float _heigth
        {
            set { heigth = value; }
            get { return heigth; }
        }

        float weigth;
        public float _weigth
        {
            set { if (value>0 && value < 600) weigth = value; }
            get { return weigth; }
        }

        static int Number = 0;

        public Person(string name, string surename, byte a)
        {
            firstName = name;
            lastName = surename;
            age = a;
        }

        public Person()
        {
            Number++;
        }

        public void showData()
        {
            Console.WriteLine("Imie: " + firstName + " " + lastName + " wiek: " + age);
        }
        public void getNumer()
        {
            Console.WriteLine(Number);
        }

        ~Person()
        {
            Number--;
        }

        public byte getAge()
        {
            return age;
        }

        public void setAge(byte a)
        {
            age = a;
        }

        
    }
}
