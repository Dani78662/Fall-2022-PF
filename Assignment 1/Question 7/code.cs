int A;
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
           
           A = dob + dom + doy * cd + cm + cy;

Console.WriteLine("Age is: ", A);
            Console.ReadKey();
