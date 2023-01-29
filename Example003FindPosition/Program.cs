// Поиск позиции (индекса) нужного нам элемента массива

int[] array = { 12, 62, 13, 994, 55, 712, 6345, 712, 8 };

int n = array.Length;
int find = 712;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

