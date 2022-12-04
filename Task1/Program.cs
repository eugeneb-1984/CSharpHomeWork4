/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
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

//Возводим число в натуральную степень. Циклом.
//Непонятно, конечно, зачем циклом, когда есть Math.Pow, но... 
//раз надо поупарываться с циклом, что нам, жалко что ли :))

int MathPow(int number, int pow) {
    int result = 1;
    int index = 1;
    while (index <= pow) {
        result = result * number;
        index++;
    }
    return result;
}

//Вызываем методы
int number = GetNumber("Какое число возводим в степень? ");
int pow = GetNumber("В какую степень возводим? ");
Console.WriteLine($"{number} в степени {pow} = {MathPow(number, pow)}");