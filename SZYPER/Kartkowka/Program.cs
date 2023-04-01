using Kartkowka.Xiega;
namespace Kartkowka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wybor = "";
            while (wybor!="3" )
            {
                
                Console.WriteLine("1) Tablice, 2) Listy, 3) Wyjście");
                Console.Write("Wybor: ");
                wybor = Console.ReadLine();
                if (wybor == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Rozmiar tablicy (wymiary 1-5): ");
                    int w1 = int.Parse(Console.ReadLine());

                    if (w1 == 1)
                    {
                        int licznik = 0;
                        Console.WriteLine("Ilość elementów(t[tutaj]): ");
                        int r1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        int[] ints = new int[r1];
                        for (int i = 0; i < ints.GetLength(0); i++)
                        {
                            licznik++;
                            ints[i] = licznik;
                            Console.Write($"\ttab[{i}] = {ints[i]}\n");
                        }
                    }
                    if (w1 == 2)
                    {
                        int licznik = 0;
                        Console.WriteLine("Ilość elementów(t[tutaj]): ");
                        int r1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ilość elementów(t[][tutaj]): ");
                        int r2 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        int[,] ints = new int[r1, r2];

                        for (int i = 0; i < ints.GetLength(0); i++)
                        {
                            Console.WriteLine($"tab[{i}]\n");
                            for (int j = 0; j < ints.GetLength(1); j++)
                            {
                                licznik++;
                                ints[i, j] = licznik;
                                Console.WriteLine($"\ttab[{i}][{j}] = {ints[i, j]}\n");
                            }
                        }
                    }
                    else if (w1 == 3)
                    {
                        int licznik = 0;
                        Console.WriteLine("Ilość elementów(t[tutaj]): ");
                        int r1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ilość elementów(t[][tutaj]): ");
                        int r2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ilość elementów(t[][][tutaj]): ");
                        int r3 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        int[,,] ints = new int[r1, r2, r3];

                        for (int i = 0; i < ints.GetLength(0); i++)
                        {
                            Console.WriteLine($"tab[{i}]\n");
                            for (int j = 0; j < ints.GetLength(1); j++)
                            {
                                Console.WriteLine($"\ttab[{i}][{j}]\n");
                                for (int k = 0; k < ints.GetLength(2); k++)
                                {
                                    licznik++;
                                    ints[i, j, k] = licznik;
                                    Console.WriteLine($"\t\ttab[{i}][{j}][{k}] = {ints[i, j, k]}\n");
                                }
                            }
                        }
                    }
                    else if (w1 == 4)
                    {
                        int licznik = 0;
                        Console.WriteLine("Ilość elementów(t[tutaj]): ");
                        int r1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ilość elementów(t[][tutaj]): ");
                        int r2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ilość elementów(t[][][tutaj]): ");
                        int r3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ilość elementów(t[][][][tutaj]): ");
                        int r4 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        int[,,,] ints = new int[r1, r2, r3, r4];

                        for (int i = 0; i < ints.GetLength(0); i++)
                        {
                            Console.WriteLine($"tab[{i}]\n");
                            for (int j = 0; j < ints.GetLength(1); j++)
                            {
                                Console.WriteLine($"\ttab[{i}][{j}]\n");
                                for (int k = 0; k < ints.GetLength(2); k++)
                                {
                                    Console.WriteLine($"\t\ttab[{i}][{j}][{k}]\n");
                                    for (int l = 0; l < ints.GetLength(3); l++)
                                    {
                                        licznik++;
                                        ints[i, j, k, l] = licznik;
                                        Console.WriteLine($"\t\t\ttab[{i}][{j}][{k}][{l}] = {ints[i, j, k, l]}\n");
                                    }
                                }
                            }
                        }
                    }
                    else if (w1 == 5)
                    {
                        int licznik = 0;
                        Console.WriteLine("Ilość elementów(t[tutaj]): ");
                        int r1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ilość elementów(t[][tutaj]): ");
                        int r2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ilość elementów(t[][][tutaj]): ");
                        int r3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ilość elementów(t[][][][tutaj]): ");
                        int r4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ilość elementów(t[][][][][tutaj]): ");
                        int r5 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        int[,,,,] ints = new int[r1, r2, r3, r4, r5];

                        for (int i = 0; i < ints.GetLength(0); i++)
                        {
                            Console.WriteLine($"tab[{i}]\n");
                            for (int j = 0; j < ints.GetLength(1); j++)
                            {
                                Console.WriteLine($"\ttab[{i}][{j}]\n");
                                for (int k = 0; k < ints.GetLength(2); k++)
                                {
                                    Console.WriteLine($"\t\ttab[{i}][{j}][{k}]\n");
                                    for (int l = 0; l < ints.GetLength(3); l++)
                                    {
                                        Console.WriteLine($"\t\t\ttab[{i}][{j}][{k}][{l}]\n");
                                        for (int m = 0; m < ints.GetLength(4); m++)
                                        {
                                            licznik++;
                                            ints[i, j, k, l, m] = licznik;
                                            Console.WriteLine($"\t\t\t\ttab[{i}][{j}][{k}][{l}][{m}] = {ints[i, j, k, l, m]}\n");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine("\n\n");
                }
                else if(wybor == "2")
                {
  
                        List<int> int_s = new List<int>();
                        Console.Clear();
                        int_s.Add(3);
                        int_s.Add(1);
                        int_s.Add(6);
                        int_s.Add(8);
                        int_s.Add(3);


                    Console.WriteLine("1.Wyswietl elementy listy: ");
                    Console.WriteLine("2.Wyswietl posorotowane elementy listy: ");
                    Console.WriteLine("3.Dodaj nowy element listy: ");
                    Console.WriteLine("4.Dodaj nowy element w indeksie: ");
                    Console.WriteLine("5.Dodaj tablice na koncu listy: ");
                    Console.WriteLine("6.Usun wartość z listy: ");
                    Console.WriteLine("7.Usuń wszystkie elementy: ");
                    Console.Write("Wybor: ");


                    int wybor2 = int.Parse(Console.ReadLine());


                    if(wybor2 == 1) //wyświetla normalnie
                    {
                        Console.WriteLine("\n\nPrzed: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }



                        Console.WriteLine("Po: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("\n\n");
                    }


                    if (wybor2 == 2) //posortowane
                    {
                        Console.WriteLine("\n\nPrzed: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }

                        int_s.Sort();

                        Console.WriteLine("Po: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("\n\n");
                    }


                    if (wybor2 == 3) //dodaje na koncu element
                    {
                        Console.WriteLine("\n\nPrzed: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine("Podaj wartość: ");
                        int_s.Add(int.Parse(Console.ReadLine()));

                        Console.WriteLine("Po: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("\n\n");
                    }


                    if (wybor2 == 4) //dodaje wartosc w indeksie uzytkowanika
                    {
                        Console.WriteLine("\n\nPrzed: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine("Podaj index: ");
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj wartość: ");
                        int value = int.Parse(Console.ReadLine());
                        int_s.Insert(index, value);

                        Console.WriteLine("Po: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("\n\n");
                    }


                    if (wybor2 == 5) //dodaje tablice na koncu
                    {
                        Console.WriteLine("\n\nPrzed: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }
                        
                        int[] range = { 3, 4, 1, 5};
                        int_s.AddRange(range);

                        Console.WriteLine("Po: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("\n\n");
                    }


                    if (wybor2 == 6) //kasuje wystapienie wpisanej liczby
                    {
                        Console.WriteLine("\n\nPrzed: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine("Podaj wartosc: ");
                        int_s.Remove(int.Parse(Console.ReadLine()));

                        Console.WriteLine("Po: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("\n\n");
                    }


                    if (wybor2 == 7) //usuwa wszystko
                    {
                        Console.WriteLine("\n\nPrzed: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }
                        int_s.Clear();

                        Console.WriteLine("Po: ");
                        foreach (var i in int_s)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("\n\n");
                    }
                }

            }

            Console.Clear();

            List<Worker> workers= new List<Worker>();
            workers.Add(new Worker("Thomas", "Mierny w Valo", 23.5f));
            workers.Add(new Worker("Schafie", "Mierny w CS", 232.5f));

            foreach (var i in workers)
            {
                Console.WriteLine($"obiekt) {i.imie}");
            }
        }
    }
}