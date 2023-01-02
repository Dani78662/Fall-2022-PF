 char gender;
            Console.WriteLine("Choose between male of female");
            gender = Convert.ToChar(Console.ReadLine());

            switch (gender)
            {
                case 'male':
              Console.WriteLine("Enter Gender:");
                    string gender = Convert.ToInt32(Console.ReadLine());
              
                    Console.WriteLine("Enter Age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (gender==male || age >= 18)
                    {
                        Console.WriteLine(" The male is adult ");
                    }
                    else
                    {
                        Console.WriteLine(" The male is a minor ");
                    }
                    break;
                case 'female':
              Console.WriteLine("Enter Gender:");
                   string gender = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (gender==female || age >= 16)
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
