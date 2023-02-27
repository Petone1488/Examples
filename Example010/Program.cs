int[] array = { 1, 2, 3, 7, 9, 87, 90, 99 };

int n = array.Length;
int find = 90;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}