 Console.WriteLine(CalculatePersistence());
            int CalculatePersistence()
            {
                Console.WriteLine("Enter a number: ");
                int n = int.Parse(Console.ReadLine());
                int persistence = 0;
                while (n > 9)
                {
                    int result = 1;
                    foreach (char c in n.ToString())
                    {
                        result = int.Parse(c.ToString());
                    }
                    n = result;
                    persistence++;
                }
                return persistence;
            }