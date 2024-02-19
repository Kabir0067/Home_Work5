
int Power(int baseValue, int exponent)
{
    if (exponent == 0)
    {
        return 1;
    }
    else
    {
        return baseValue * Power(baseValue, exponent - 1);
    }
}


{

    int baseValue = Convert.ToInt32(Console.ReadLine());


    int exponent = Convert.ToInt32(Console.ReadLine());

    int result = Power(baseValue, exponent);

    Console.WriteLine($"The result of {baseValue} raised to the power of {exponent} is: {result}");
}

