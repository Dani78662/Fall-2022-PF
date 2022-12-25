
            Console.WriteLine("Enter a number to calculate its factorial:");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial + (factorial * (i - 1));
            }
            Console.WriteLine("The factorial of " + num + " is " + factorial);
            Console.ReadKey();
