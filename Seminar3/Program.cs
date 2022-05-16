int[] CreateRandomArray(int size)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9,10);
    }

    return array;
} 
// Задаем сами массив
/*
int[] CreateArray(int size)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + "element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
} 
*/
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void FindSunOfElements(int[] array) // 1 -4 3 -2 6 -1 5 3 8 -5
{
    int plusSum = 0;
    int minusSum = 0;

    for(int i = 0; i <array.Length; i++)
    {
        if(array[i] > 0)
            plusSum += array[i];
        else
            minusSum += array[i];
    }
    Console.WriteLine("Sum of positive elements is " + plusSum);
    Console.WriteLine("Sum of negative elements is " + minusSum);
}


int[] myArray = CreateRandomArray(12);
ShowArray(myArray);
FindSunOfElements(myArray);



int [] CreateArray(int size)
{
    int [] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
    return array;
}

void FindPosElements(int[]array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        sum++;
    }
    Console.Write(sum);
}
Console.Write("Input amount of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
int[]array = CreateArray(size);
FindPosElements(array);
