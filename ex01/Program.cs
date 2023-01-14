 // Задача 37: Найдите произведение пар чисел в одномерном массиве.
 // Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
 //Результат запишите в новом массиве.
 //[1 2 3 4 5] -> 5 8 3
 //[6 7 3 6] -> 36 21

//1.Ввести кол-во элементов массива
//2.Создать массив
//3.Наполнить массив случайным образом
//4.Найти произведение
//5.Напечатать результат в новом массиве
//6.Найти и вывести центральный элемент нечетного массива

//1.Ввести кол-во элементов массива
int GetArraySize()
{
  Console.WriteLine("Введите количество элементов массива: ");
  int size = Convert.ToInt32(Console.ReadLine());
  return size;
}

//2.Создать массив
int[] FirstArray(int size)
{
  return new int[size];
}

//3.Наполнить массив случайным образом
int[] FillArray(int[] arr)
{
  int index = 0;
  int lenght = arr.Length;
  while (index < lenght)
  {
    arr[index] = Random.Shared.Next(1, 10);
    Console.Write($"{arr[index]} ");
    index++;
  }
  Console.WriteLine();
  return arr;
}

//4.Найти произведение
int[] GetProd(int[] array)
{
  int[] arrRez = new int[array.Length / 2];
  int count = array.Length;
  for (int i = 0; i < count / 2; i++)
  {
    arrRez[i] = array[i] * array[count - 1 - i];
    //Console.WriteLine($"{i} {count} {arrRez[i]}  iiiii");
  }
  return arrRez;
}

//5.Напечатать результат в новом массиве
void PrintArray(int[] array)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
}

//6.Найти и вывести центральный элемент нечетного массива
void GetMid(int[]arr)
{
   if (arr.Length % 2 != 0) 
  {
    int arrMid = arr[arr.Length / 2];
    Console.Write(arrMid);
  }
}

int size = GetArraySize();
int[] arr = FirstArray(size);
FillArray(arr);
int[] arrRez = GetProd(arr);
PrintArray(arrRez);
GetMid(arr);





