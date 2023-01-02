
            Console.Write("Input the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int ans = num;
            for (int i = num - 1; i > 0; i--)
            {
                int sum = 0;

                
                for (int j = 0; j < i; j++)
                    sum += ans;

                ans = sum;
                
            }
            Console.WriteLine("The Factorial is", ans);

            Console.ReadKey();
