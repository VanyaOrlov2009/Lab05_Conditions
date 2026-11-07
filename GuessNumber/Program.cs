// Console.Write("\nВведите номер дня недели (1-7): ");
// int dayNumber = int.Parse(Console.ReadLine());

// switch (dayNumber) {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Рабочий день — пора учиться!");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("Выходной — заслуженный отдых.");
//         break;
//     default:
//         Console.WriteLine("Такого дня не существует.");
//         break;
// }

Console.Write("\nВведите номер месяца (1-12): ");
int monthNumber = int.Parse(Console.ReadLine());

switch (monthNumber) {
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Зима");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Весна");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Лето");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Осень");
        break;
    default:
        Console.WriteLine("Такого месяца не существует.");
        break;     
}   