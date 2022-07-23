internal class Program
{
    private static void Main(string[] args)
    {
        //Написать программу, которая из имеющегося массива строк формирует массив из строк,
        //длина которых меньше либо равна 3 символа.
        string[] existingArray = new string[] { "London", "Tokyo", "Moscow", "Washington", "Berlin", "Madrid", "Paris" };
        void FillArray(string[] rndArray) //задание метода для заполнения какого-то массива с заданным количеством случайных элементов
        {
            for (int index = 0; index < rndArray.Length; index++)
            {
                rndArray[index] = existingArray[new Random().Next(0, existingArray.Length)];
            }
        }
        void PrintArray(string[] prntArray) //задание метода для вывода элементов любого массива на консоль
        {
            for (int position = 0; position < prntArray.Length; position++)
            {
                Console.Write(prntArray[position] + " ");
            }
            Console.WriteLine();
        }
        string[] newArray = new string[new Random().Next(0, 4)];

        FillArray(newArray);
        Console.WriteLine("Существующий строковый массив:");
        PrintArray(existingArray);
        Console.WriteLine();
        Console.WriteLine("Новый строковый массив:");
        PrintArray(newArray);
    }
}
