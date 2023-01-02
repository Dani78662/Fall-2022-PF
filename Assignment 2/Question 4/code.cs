 for (int i = 3; i < 3000; i++)
            {
                if (Prime(i) && Prime(i + 2))
                {
                    Console.WriteLine($"({i}  {i + 2})");
                }
            }
            Console.ReadKey();
        }
        static bool Prime(int n)
        {
           
            if (n == 2) return true;
           
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
