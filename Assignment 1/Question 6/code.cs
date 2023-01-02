Console.Write("Input  a number(integer): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, mod=0;
            while (n > 0)
            {
                mod = n % 10;
                sum = mod + sum;
               n = n / 10;
            }
            Console.WriteLine("Sum is: " + sum);

            Console.ReadKey();
