Console.WriteLine("Enter Date Of Birth:");
            int dob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month Of Birth:");
            int dom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year Of Birth:");
            int doy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Current Date:");
            int cd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Current Month:");
            int cm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Current Year:");
            int cy = Convert.ToInt32(Console.ReadLine());
            if (doy > cy)
            {
                Console.WriteLine("Invlaid Input");
            }
            else
            {
                int d = cd - dob;
                int m = cm - dom;
                int y = cy - doy;
                Console.Write("Age = ");
                Console.Write(+d);
                Console.Write("Days");
                Console.Write("" + m);
                Console.Write("Month and");
                Console.Write("" + y);
                Console.Write("Years");
            }
            Console.ReadKey();
