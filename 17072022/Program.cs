// Метод, который будет заполнять массив значениями пользователя, введенными с клавиатуры, после чего выведет массив на экран.

int[] UserArrayMethod()
{
    Console.WriteLine();
    Console.Write("Введите размер массива (желаемое количество элементов): ");
    int userq = Convert.ToInt32(Console.ReadLine());
    
    int[] array = new int[userq];

    for (int count = 0; count < userq; count++)
    {
        Console.Write($"Введите {count+1}й элемент массива: ");
        array[count] = Convert.ToInt32(Console.ReadLine());
    }
    string arraystr = string.Join(" ", array);
    Console.WriteLine();
    Console.WriteLine($"Массив из {userq} чисел: {arraystr}");

    return array;
}

void MinMaxSortMethod(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int position = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array [position]) position = j;
        }
        int temp = array[i];
        array[i] = array[position];
        array[position] = temp;
    }    
    string sortedarray = string.Join(" ", array);
    Console.WriteLine();
    Console.WriteLine($"Отсортированный массив (метод MinMax): {sortedarray}");
    Console.WriteLine();
}

int[] userarray = UserArrayMethod();
MinMaxSortMethod(userarray);