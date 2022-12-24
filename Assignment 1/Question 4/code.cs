char g;
            Console.WriteLine("Choose between male of female");
            g = Convert.ToChar(Console.ReadLine());

            switch (g)
            {
                case 'M':
                    Console.WriteLine("Age is:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Distance is:");
                    int s = Convert.ToInt32(Console.ReadLine());
                    if (n > 0)
                    {
                        Console.WriteLine(" Valid Number ");
                    }
                    else
                    {
                        Console.WriteLine(" Invalid Number ");
                    }
                    if (n >= 18)
                    {
                        int fare = 10 + (3 * s);
                        Console.WriteLine("The fare is " + fare);
                    }
                    else
                    {
                        int fare = 5 + (3 * s);
                        Console.WriteLine("The fare is " + fare);
                    }
                    break;
                case 'F':
                    Console.WriteLine("Age is:");
                    int f = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Distance is:");
                    int s1 = Convert.ToInt32(Console.ReadLine());
                    if (f >= 16)
                    {
                        int fare = 5 + (3 * s1);
                        Console.WriteLine("The fare is " + fare);
                    }
                    else
                    {
                        int fare = 10 + (3 * s1);
                        Console.WriteLine("The fare is " + fare);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
