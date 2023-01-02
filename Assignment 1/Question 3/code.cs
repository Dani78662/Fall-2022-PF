 char G;
            Console.WriteLine("Enter gender");
            G = Convert.ToChar(Console.ReadLine());

            switch (gender)
            {
                case 'M':
             
              
                    Console.WriteLine("Enter Age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (G==M || age >= 18)
                    {
                        Console.WriteLine(" The male is adult ");
                    }
                    else
                    {
                        Console.WriteLine(" The male is a minor ");
                    }
                    break;
                case 'F':
              
                    Console.WriteLine("Enter Age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (G==F || age >= 16)
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
