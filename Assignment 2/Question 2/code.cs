  int  sum = 0;
            Console.WriteLine("enter the Number");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n  perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n  not a perfect number");
                Console.ReadLine();
            }
            Console.ReadKey();
