/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

//Принимаем число
int GetNumber(string message) {
    bool isNumber = false;
    int Number = 0;
    while(!isNumber) {
        Console.Write(message);
        string input = Console.ReadLine();
        if(Int32.TryParse(input, out Number)) {
            isNumber = true;
        }
        else {
            Console.WriteLine("Вы ошиблись при вводе. Введите число.");
        }
    }
    return Number;
}

//Складываем цифры в числе
int SumChars(int number) {
    string NumString = number.ToString();
    int index = 0;
    int result = 0;
    while (index < NumString.Length) {
        Int32.TryParse(NumString[index].ToString(), out int increment);
        result += increment;
        index++;
    }
    return result;
}

//Вызываем методы
int number = GetNumber("Введите число: ");
Console.WriteLine($"Сумма цифр числа {number}: {SumChars(number)}");