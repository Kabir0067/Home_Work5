Console.WriteLine("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите операцию (+, -, *, /): ");
char operation = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());

switch (operation)
{
    case '+':
        Console.WriteLine($"Result: {number1} + {number2} = {number1 + number2}");
        break;
    case '-':
        Console.WriteLine($"Result: {number1} - {number2} = {number1 - number2}");
        break;
    case '*':
        Console.WriteLine($"Result: {number1} * {number2} = {number1 * number2}");
        break;
    case '/':
        Console.WriteLine($"Result: {number1} / {number2} = {number1 / number2}");
        break;
    default:
        Console.WriteLine("Неверная операция!");
        break;
}


double Sum(double a, double b)
{
    return a + b;
}

double Subtract(double a, double b)
{
    return a - b;
}

double Multiplication(double a, double b)
{
    return a * b;
}

double Division(double a, double b)
{
    if (b == 0)
    {
        Console.WriteLine("Ошибка: Деление на 0!");
        return 0;
    }
    return a / b;
}
