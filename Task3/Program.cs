Console.Write("Elementhoro doxil kuned: ");
if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{
    int positiveCount = 0, negativeCount = 0, zeroCount = 0, evenCount = 0, oddCount = 0;
    int max = int.MinValue, min = int.MaxValue, sumDigits = 0;

    for (int i = 0; i < n; i++)
    {
        Console.Write("Enter number " + (i + 1) + ": ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            if (num > 0)
            {
                positiveCount++;               
            }
            else if (num < 0)
            {
                negativeCount++;
            }
            else
            {
                zeroCount++;
            }


            if (num % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }


            max = Math.Max(max, num);
            min = Math.Min(min, num);


            int temp = Math.Abs(num);
            while (temp > 0)
            {
                sumDigits += temp % 10;
                temp /= 10;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }
    }

    Console.WriteLine("Negative = " + negativeCount);
    Console.WriteLine("Positive = " + positiveCount);
    Console.WriteLine("Zeros = " + zeroCount);
    Console.WriteLine("Even = " + evenCount);
    Console.WriteLine("Odd = " + oddCount);
    Console.WriteLine("Max = " + max);
    Console.WriteLine("Min = " + min);
    Console.WriteLine("Sum of Digits = " + sumDigits);
}
else
{
    Console.WriteLine("Invalid input for the total number of elements. Please enter a valid positive integer.");
}


