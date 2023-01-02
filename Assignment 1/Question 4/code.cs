 char G;
            Console.WriteLine("Enter gender");
            G = Convert.ToChar(Console.ReadLine());

            switch (G)
            {
                case 'M':
                    Console.WriteLine("Enter Age:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Enter distance");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter fair for adult: 10 ");
                    int fa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter fair for minor: 5 ");
                    int fm = Convert.ToInt32(Console.ReadLine());

                    if (a >= 18)
                    {
                        int tf = fa + (3 * d);
                        Console.WriteLine("The fare is " + tf);
                    }
                    else
                    {
                        int tf = fm + (3 * d);
                        Console.WriteLine("The fare is " + tf);
                    }
                    break;
                case 'F':
                    Console.WriteLine("Enter Age:");
                    int a2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Enter distance");
                    int d2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter fair for adult: 10 ");
                    int fa2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter fair for minor: 5 ");
                    int fm2 = Convert.ToInt32(Console.ReadLine());


                    if (a2 >= 16)
                    {
                        int tf = fa2 + (3 * d2);
                        Console.WriteLine("The fare is " + tf);
                    }
                    else
                    {
                        int tf = fm2 + (3 * d2);
                        Console.WriteLine("The fare is " + tf);
                    }
                    break;
            }
            Console.ReadKey();
