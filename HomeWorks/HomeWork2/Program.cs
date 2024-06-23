
using System;
class Program
{
    static void Main()
    {
        FirstTask();
        SecondTask();
        ThirdTask();
        FourthTask();

    }


    //Реверс строки/масиву. Без додаткового масиву. Складність О(n).
static void FirstTask()
    {
        //int[] array1 = {4, 5, 6, 7, 8, 9 }; 

        //Array.Reverse(array1);
        //foreach(var item  in array1)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine(" ");

        //int[] array2 = { 1, 2, 3, 4, 5, 6 };

        //for (int i = 0; i < array2.Length/2; i++)
        //{
        //    int temp = array2[i];

        //    array2[i] = array2[array2.Length-1-i];
        //    array2[array2.Length - 1 - i] = temp;
        //}

        //foreach (var item in array2)
        //{
        //    Console.WriteLine(item);
        //}
    }
    //Фільтрування неприпустимих слів у строці. Має бути саме слова, а не частини слів.

    static void SecondTask()
    {
        //try
        //{
        //    Console.WriteLine("Введіть текст:");
        //    string textToFilterStr = Console.ReadLine();

        //    Console.WriteLine("Введіть недопустимі слова:");
        //    string wordsToFilterStr = Console.ReadLine();

        //    string[] wordsToFilter = wordsToFilterStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //    string[] wordsInText = textToFilterStr.Split(new char[] { ' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);

        //    foreach (string word in wordsInText)
        //    {
        //        bool isAllowed = true;
        //        foreach (string forbiddenWord in wordsToFilter)
        //        {
        //            if (string.Equals(word, forbiddenWord, StringComparison.CurrentCultureIgnoreCase))
        //            {
        //                isAllowed = false;
        //                break;
        //            }
        //        }

        //        if (isAllowed)
        //        {
        //            Console.WriteLine(word);
        //        }
        //    }


        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

    }

    //Генератор випадкових символів. На вхід кількість символів, на виході рядок з випадковими символами.
    static void ThirdTask()
    {
        //try
        //{

        //    Console.WriteLine("Введіть кількість символів: ");
        //    int numOfSymbols = Convert.ToInt32(Console.ReadLine());

        //    string allowedSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        //    string result = "";
        //    Random random = new Random();

        //    for (int i = 0; i < numOfSymbols; i++)
        //    {
        //        int index = random.Next(allowedSymbols.Length);
        //        result += allowedSymbols[index];  
        //    }

        //    Console.WriteLine("Згенерований рядок: " + result); 

        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }

    //"Дірка" (пропущене число) у масиві. Масив довжини N у випадковому порядку заповнений цілими числами з діапазону від 0 до N.
    //Кожне число зустрічається в масиві не більше одного разу. Знайти відсутнє число (дірку).
    //Є дуже простий та оригінальний спосіб вирішення. Складність алгоритму O(N).
    //Використання додаткової пам'яті, пропорційної довжині масиву не допускається.

    static void FourthTask()
    {
        //try
        //{
        //    Console.WriteLine("Введіть кількість чисел (N): ");
        //    int lengthNum = Convert.ToInt32(Console.ReadLine());

        //    if (lengthNum <= 0)
        //    {
        //        Console.WriteLine("Кількість чисел має бути більше 0.");
        //        return;
        //    }

        //    int expectedSum = (lengthNum * (lengthNum + 1)) / 2;
        //    int actualSum = 0;

        //    Console.WriteLine("Введіть масив чисел від 0 до N (одне число відсутнє): ");
        //    for (int i = 0; i < lengthNum; i++)
        //    {
        //        int num = Convert.ToInt32(Console.ReadLine());
        //        if (num < 0 || num > lengthNum)
        //        {
        //            Console.WriteLine("Числа мають бути в діапазоні від 0 до N.");
        //            return;
        //        }
        //        actualSum += num;
        //    }

        //    int missingNum = expectedSum - actualSum;
        //    Console.WriteLine("Пропущене число в масиві: " + missingNum);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Сталася помилка: " + ex.Message);
        //}
    }



    }
