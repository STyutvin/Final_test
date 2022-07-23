﻿//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа.
string[] existingArray= new string[] {"London", "Tokyo", "Moscow", "Washington", "Berlin", "Madrid", "Paris"};
void FillArray(string[] rndArray) //задание метода для заполнения какого-то массива с заданным количеством случайных элементов
{
    for (int index = 0; index < rndArray.Length; index++)
    {
        rndArray[index] = existingArray [new Random().Next(0, existingArray.Length)];
    }
}