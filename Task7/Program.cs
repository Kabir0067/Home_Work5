
  Console.Write("Enter the starting number: ");
        int x = int.Adad(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int y = int.Adad(Console.ReadLine());

        
        Console.WriteLine("----------------------------------------");

        for (int i = x; i <= y; i++)
        {
            Console.WriteLine("----------------------------------------");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
            }
            Console.WriteLine();
        }
    