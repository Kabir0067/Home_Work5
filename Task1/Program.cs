{
        int number;
        Console.Write("Enter an integer: ");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Number of even numbers: " + EvenCount(number));
            Console.WriteLine("Number of odd numbers: " + OddCount(number));
            Console.WriteLine("Number of zeros: " + ZeroCount(number));
            Console.WriteLine("Number of digits: " + DigitCount(number));
            Console.WriteLine("Min digit: " + MinDigit(number));
            Console.WriteLine("Max digit: " + MaxDigit(number));
            Console.WriteLine("Sum of digits: " + SumDigit(number));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

     int EvenCount(int n)
    {
        int count = 0;
        while (n != 0)
        {
            if ((n % 10) % 2 == 0)
            {
                count++;
            }
            n = n / 10;
        }
        return count;
    }

     int OddCount(int n)
    {
        int count = 0;
        while (n != 0)
        {
            if ((n % 10) % 2 != 0)
            {
                count++;
            }
            n = n / 10;
        }
        return count;
    }

     int ZeroCount(int n)
    {
        int count = 0;
        while (n != 0)
        {
            if (n % 10 == 0)
            {
                count++;
            }
            n = n / 10;
        }
        return count;
    }

     int DigitCount(int n)
    {
        int count = 0;
        while (n != 0)
        {
            count++;
            n = n / 10;
        }
        return count;
    }

     int MinDigit(int n)
    {
        int min = 9;
        while (n != 0)
        {
            min = Math.Min(min, n % 10);
            n = n / 10;
        }
        return min;
    }

     int MaxDigit(int n)
    {
        int max = 0;
        while (n != 0)
        {
            max = Math.Max(max, n % 10);
            n = n / 10;
        }
        return max;
    }

     int SumDigit(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n = n / 10;
        }
        return sum;
    }
