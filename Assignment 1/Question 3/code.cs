 char gender;
            Console.WriteLine("Choose between male of female");
            gender = Convert.ToChar(Console.ReadLine());

            switch (gender)
            {
                case 'M':
                    Console.WriteLine("Age is:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n >= 18)
                    {
                        Console.WriteLine(" The male is adult ");
                    }
                    else
                    {
                        Console.WriteLine(" The male is a minor ");
                    }
                    break;
                case 'F':
                    Console.WriteLine("Age is:");
                    int f = Convert.ToInt32(Console.ReadLine());
                    if (f >= 16)
                    {
                        Console.WriteLine(" The female is adult ");
                    }
                    else
                    {
                        Console.WriteLine(" The female is a minor ");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
