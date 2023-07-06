double[] numbers = new double[5];
double max = -99999999999;
double min = 9999999999999;
for (int i = 0; i < 5; i++)
{
    numbers[i] = Double.Parse(Console.ReadLine());
    if (numbers[i] > max) {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine(max - min);

