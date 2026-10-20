// Обратный отсчёт
Console.WriteLine("Обратный отсчёт");
int countdown = 5;
while (countdown >= 1) {
    Console.WriteLine(countdown);
    countdown--;
}
Console.WriteLine("Пуск!");

Console.WriteLine();
Console.WriteLine("Сумма чисел от 1 до 10");
int number = 1;
int sum = 0;
while (number <= 10) {
    sum += number;
    number++;
}
Console.WriteLine($"Сумма: {sum}");
//Часть 2. Опасность бесконечного цикла и валидация ввода
Console.WriteLine();
Console.WriteLine("Бесконечный цикл");

int i = 1;
while (i <= 5 )
{
    Console.WriteLine($"Значение i: {i++}");
}
//Шаг 5. Валидация ввода через while
Console.WriteLine();
Console.WriteLine("Валидация ввода через while");
bool isValid = false;
int enteredAge = 0;

while (!isValid)
{
    Console.WriteLine("Введите ваш возвраст (целое число): ");
    string input = Console.ReadLine();
    isValid = int.TryParse(input, out enteredAge);

    if (!isValid)
    {
        Console.WriteLine("Это не похоже на целое число.Попробуйте езе раз.");
    }
}
Console.WriteLine($"Принято!Ваш возвраст: {enteredAge}");