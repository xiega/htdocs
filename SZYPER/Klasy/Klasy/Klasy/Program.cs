namespace Klasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal= new Animal();
            animal.name = "Jacuś";
            animal.getVoice();
            Console.WriteLine(animal.name);
            float x = 4.5f; double z = 24.7;
            Console.WriteLine(Calculations.add(x, z)); 
        }
    }
}