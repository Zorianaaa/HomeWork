using System;

class Program
{
    static void Main()
    {
        FirstTask();

        ThirdTask();
        FourthTask();
    }

    //Знайти позицію літери в алфавіті та перевести її в інший регістр

    static void FirstTask()
    {
        //try
        //{
        //    Console.WriteLine("Введіть номер літери (1-26): ");
        //    int number = int.Parse(Console.ReadLine());

        //    if (number < 1 && number > 26)
        //    {
        //        Console.WriteLine("Введіть номер літери (1-26)");
        //    }

        //    else
        //    {
        //        char upperLetter = (char)('A' + number - 1);
        //        char lowerLetter = (char)('a' + number - 1);
        //        Console.WriteLine($"Введений номер {number} відповідає великий літері {upperLetter} та малій літері {lowerLetter}");
        //    }
        //}

        //catch (Exception ex)
        //{
        //    Console.WriteLine("Не є числом");
        //}
       
    }

    //Розділювач рядка. Дана строка та символ, потрібно розділити строку на кілька строк (масив строк) виходячи із заданого символу.
    //Наприклад: строка = "Лондон, Париж, Рим", а символ = ','. Результат = string[] { "Лондон", "Париж", "Рим" }.


    //Пошук підстроки у строці.
    
    static void ThirdTask()
    {
        //try
        //{
        //    Console.WriteLine("Введіть текст: ");
        //    string text = Console.ReadLine();

        //    Console.WriteLine("Введіть слово або рядок, який потрібно знайти: ");
        //    string search = Console.ReadLine();

        //    bool found = false;

        //    for (int i = 0; i <= text.Length - search.Length; i++)
        //    {
        //        bool match = true;
        //        for (int j = 0; j < search.Length; j++)
        //        {
        //            if (text[i + j] != search[j])
        //            {
        //                match = false;
        //                break;
        //            }
        //        }

        //        if (match)
        //        {
        //            found = true;
        //            break;
        //        }
        //    }

        //    if (found)
        //    {
        //        Console.WriteLine($"Знайдено '{search}' в тексті.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Не знайдено '{search}' в тексті.");
        //    }
            
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message );
        //}
    }


    //Написати програму, яка виводить число літерами. Приклад: 117 - сто сімнадцять
    static void FourthTask()
    {
        //try
        //{
        //    console.writeline("введіть число ");
        //    int num = int.parse(console.readline());

        //    string[] ones = { "", "один", "два", "три", "чотири", "п'ять", "шість", "сім", "вісім", "дев'ять" };
        //    string[] teens = { "десять", "одинадцять", "дванадцять", "тринадцять", "чотирнадцять", "п'ятнадцять", "шістнадцять", "сімнадцять", "вісімнадцять", "дев'ятнадцять" };
        //    string[] tens = { "", "десять", "двадцять", "тридцять", "сорок", "п'ятдесят", "шістдесят", "сімдесят", "вісімдесят", "дев'яносто" };
        //    string[] hundreds = { "", "сто", "двісті", "триста", "чотириста", "п'ятсот", "шістсот", "сімсот", "вісімсот", "дев'ятсот" };

        //    if (num == 0)
        //    {
        //        console.writeline("нуль");
        //        return;
        //    }

        //    int hundredsdigit = num / 100;
        //    int tensdigit = (num % 100) / 10;
        //    int onesdigit = num % 10;


        //    string result = "";

        //    if (hundredsdigit > 0)
        //    {
        //        result += hundreds[hundredsdigit] + " ";
        //    }

        //    if (tensdigit == 1)
        //    {
        //        result += teens[onesdigit] + " ";
        //    }
        //    else
        //    {
        //        result += tens[tensdigit] + " ";
        //        result += ones[onesdigit] + " ";
        //    }

        //    console.writeline(result);
        //}
        //catch (exception e)
        //{
        //    console.writeline(e.message);
        //}
    }
}


