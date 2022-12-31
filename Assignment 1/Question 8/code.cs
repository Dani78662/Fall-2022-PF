int main()
            {
                float mean;
                int sum, i;
                Console.WriteLine("Enter number");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];

                sum = 0;

                for (i = 0; i < n; i++)
                {
                    sum += arr[i];
                }

                Console.WriteLine("Mean = %d ", sum / (float)n);

                return 0;

            }
            Console.ReadKey();
