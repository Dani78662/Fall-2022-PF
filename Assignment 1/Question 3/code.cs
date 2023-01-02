 char gender;
            Console.WriteLine("Choose between male of female");
            gender = Convert.ToChar(Console.ReadLine());

            switch (gender)
            {
                case 'MALE':
                    Console.WriteLine("Enter Age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age >= 18)
                    {
                        Console.WriteLine(" The male is adult ");
                    }
                    else
                    {
                        Console.WriteLine(" The male is a minor ");
                    }
                    break;
                case 'FEMALE':
                    Console.WriteLine("Enter Age:");
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
