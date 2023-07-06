int count = 0;
int[] numbers = new int[4];
for(int i=0; i<4; i++) {
    Random r = new Random();
    numbers[i] = r.Next(100, 999);
    Console.WriteLine(numbers[i]);
    if (numbers[i] % 2 == 0) {
        count++;
    }
}
Console.WriteLine(count);
