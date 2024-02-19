

Console.Write("Enter the elements of the array separated by spaces: ");
string input = Console.ReadLine();
string[] elements = input.Split(' ');

Console.WriteLine("Array elements with even indexes:");

for (int i = 0; i < elements.Length; i += 2)
{
    Console.WriteLine("A[" + i + "] = " + elements[i]);
}

