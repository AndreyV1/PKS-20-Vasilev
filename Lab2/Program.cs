// Задание 1
Console.WriteLine("Введите число");
int number = 0;
while (true)
{
    string str = Console.ReadLine();
    bool res = int.TryParse(str, out number);
    if (res == true)
    {
        if ((number >= 1) && (number <= 7))

        {

            switch (number)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
            if (number == 1)
            {
                Console.WriteLine("Понедельник");
            }
            if (number == 2)
            {
                Console.WriteLine("Вторник");
            }
            if (number == 3)
            {
                Console.WriteLine("Среда");
            }
            if (number == 4)
            {
                Console.WriteLine("Четверг");
            }
            if (number == 5)
            {
                Console.WriteLine("Пятница");
            }
            if (number == 6)
            {
                Console.WriteLine("Суббота");
            }
            if (number == 7)
            {
                Console.WriteLine("Воскресенье");
            }
        }
        else Console.WriteLine("Ошибка");

    }
    else Console.WriteLine("Ошибка");
}


// Задание 2
Console.WriteLine("Введите число");
int num = 10;
if ((num % 3 == 0) && (num % 5 == 0))
{
    Console.WriteLine("BuzzFizz");
}
else if (num % 3 == 0)
{
    Console.WriteLine("Buzz");
}
else if (num % 5 == 0)
{
    Console.WriteLine("Fizz");
}


// Задание 3
double firstValue, secondValue;
string action;

Console.WriteLine("Введите число 1");
firstValue = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
secondValue = double.Parse(Console.ReadLine());

Console.WriteLine("Выберите операцию: '+' '-' '*' '/' ");
action = Console.ReadLine();

switch (action)
{
    case "+":
        Console.WriteLine(firstValue + secondValue);
        break;
    case "-":
        Console.WriteLine(firstValue - secondValue);
        break;
    case "*":
        Console.WriteLine(firstValue * secondValue);
        break;
    case "/":
        if (secondValue == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(firstValue / secondValue);
        }
        break;
    default:
        Console.WriteLine("Ошибка!");
        break;
}
Console.ReadLine();