//Задание 1
string psw1 = Console.ReadLine();
string psw2 = Console.ReadLine();

if (psw1 == psw2) {
    Console.WriteLine("Пароль принят");
}
else {
    Console.WriteLine("Пароль не принят");
}

Console.WriteLine();
//Задание 2
Console.Write("Введите возраст: ");
int age = int.Parse(Console.ReadLine());

if (age >= 18) {
    Console.WriteLine("Доступ разрешён");
}
else {
    Console.WriteLine("Доступ запрещён");
}
Console.WriteLine();
//Задание 3
Console.Write("Введите 1 число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите 2 число: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Введите операцию: ");
string op = Console.ReadLine();

switch(op) {
    case "+":
        Console.WriteLine($"{num1} + {num2} = {num1+num2}");
        break;
    case "-":
        Console.WriteLine($"{num1} - {num2} = {num1-num2}");
        break;
    case "*":
        Console.WriteLine($"{num1} * {num2} = {num1*num2}");
        break;
    case "/":
        Console.WriteLine($"{num1} / {num2} = {num1/num2}");
        break;
    default:
        Console.WriteLine("Такой операции не существует");
        break;
}
Console.WriteLine();
//Задание 4

Console.Write("Введите 1 число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите 2 число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите 3 число: ");
int c = int.Parse(Console.ReadLine());

int sum = 0;

if (a > 0) {
    sum += a;
}
if (b > 0) {
    sum += b;
}
if (c > 0) {
    sum += c;
}

Console.WriteLine(sum);

Console.WriteLine();
//Задание 5

Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути:");
Console.WriteLine("Путь A: Войти в комнату с огромным драконом.");
Console.WriteLine("Путь B: Пойти по тёмному коридору.");
Console.Write("Выберите путь (A/B): ");
string way = Console.ReadLine();

if (way == "A") {
    Console.WriteLine("Дракон говорит: **Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.**");
    Console.Write("Ваш ответ: ");
    string answer = Console.ReadLine();

    if (answer == "рыба") {
        Console.WriteLine("Правильно! Дракон открывает дверь в следующую комнату.");
    }
    else {
        Console.WriteLine("Неверно! Дракон вас съел.");
    }
}
else if (way == "B") {
    Console.WriteLine("Вас ждёт тёмная комната с двумя дверями:");
    Console.WriteLine("Дверь 1: За ней скрыты сокровища Dungeon Master’а.");
    Console.WriteLine("Дверь 2: За ней — ловушка с ядовитыми шипами.");
    Console.Write("Выберите дверь (1/2): ");
    string door = Console.ReadLine();

    switch(door) {
        case "1":
            Console.WriteLine("Вы нашли сокровища Dungeon Master’а!");
            break;
        case "2":
            Console.WriteLine("Вы попали в ловушку с ядовитыми шипами.");
            break;
        default:
            Console.WriteLine("Такой двери не существует");
            break;
    }
}
else {
    Console.WriteLine("Такого пути не существует");
}