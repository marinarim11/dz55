int s = 0;
int[] numbers = new int[4];
for (int i = 0; i < 4; i++)
{
    Random r = new Random();
    numbers[i] = r.Next(-99, 99);
    Console.WriteLine(numbers[i]);
    if (i % 2 != 0)
    {
        s += numbers[i];
    }
}
Console.WriteLine(s);
