 int userInput;
            int n, i = 1;
            float mean, sum = 0;
            Console.WriteLine("Enter the value of n");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                Console.WriteLine("Enter the " + i + " number");
                userInput = Convert.ToInt32(Console.ReadLine());
                sum += userInput;
                ++i;
            }
            mean = (float)sum / (n);
            Console.WriteLine("The Mean is ");
            Console.Write(mean);


            Console.ReadKey();
