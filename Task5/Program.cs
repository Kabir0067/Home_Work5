int[] elements = { 1, 2, 3, 4, 5 };
int count = 0;

for (int i = 1; i < elements.Length; i++)
{
    if (elements[i] > elements[i - 1])
    {
        count++;
    }
}

Console.WriteLine(count);
