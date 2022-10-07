Console.Clear();
int num;

{
while (true) 
    {
    Console.Write("Введите целое число: ");
    if (int.TryParse(Console.ReadLine(), out num))
        break;
    Console.WriteLine($"Ошибка ввода");   
    }  

Console.Write(num +" -> ");

if (num >= 6 && num <= 7)
    Console.WriteLine("Да");
else if (num >= 1 && num <= 5)
    Console.WriteLine("нет");
else Console.WriteLine("Ошибка ввода");
}