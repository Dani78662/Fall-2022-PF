Console.WriteLine("Enter Number");
            int n= Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
