Random random = new Random();
int secret = random.Next(1, 101);

int attempts = 0;
bool guessed = false;   

Console.WriteLine("Угадай число (1–100)");
Console.WriteLine("Я загадал число. Попробуй угадать!");

while (!guessed) {
    Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out int guess)) {
        Console.WriteLine("!!! Введи целое число, а не текст!");
        continue; // начинаем следующую итерацию цикла
    }

    if (guess < 1 || guess > 100) {
        Console.WriteLine("!!! Число должно быть от 1 до 100!");
        continue;
    }

    attempts++;

    if (guess < secret) {
        // Подсказка «горячо/тепло/холодно» через switch
        int diff = secret - guess;
        string hint = GetHint(diff);
        Console.WriteLine($"↑ Больше! {hint}\n");
    }
    else if (guess > secret) {
        int diff = guess - secret;
        string hint = GetHint(diff);
        Console.WriteLine($"↓ Меньше! {hint}\n");
    }
    else {
        guessed = true; // угадал!
    }
}

string result = attempts <= 7
    ? $"Отличный результат! Всего {attempts} попыток."
    : $"Число найдено за {attempts} попыток. Можно лучше!";

Console.WriteLine($"🎉 Правильно! Загаданное число: {secret}");
Console.WriteLine($"{result}");

string GetHint(int difference) {
    switch (difference) {
        case <= 3:
            return "🔥 Горячо!";
        case <= 10:
            return "🌡️ Тепло.";
        case <= 25:
            return "🌀 Прохладно.";
        default:
            return "❄️ Холодно!";
    }
}