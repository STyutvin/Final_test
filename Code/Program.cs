internal class Program
{
    private static void Main(string[] args)
    {
        //Написать программу, которая из имеющегося массива строк формирует массив из строк,
        //длина которых меньше либо равна 3 символа.
        string[] existingArray = new string[] { "hello", "2", "Moscow", "one", "))", "madness", "off" };

        void PrintArray(string[] prntArray) //задание метода для вывода элементов любого массива на консоль
        {
            for (int position = 0; position < prntArray.Length; position++)
            {
                Console.Write(prntArray[position] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Существующий строковый массив:");
        PrintArray(existingArray);
        Console.WriteLine();
        Console.WriteLine("Новый строковый массив:");
        for (int i = 0; i < existingArray.Length; i++)
            {
                if (existingArray[i].Length<=3) Console.Write(existingArray[i] + " ");
            }
    }
}
