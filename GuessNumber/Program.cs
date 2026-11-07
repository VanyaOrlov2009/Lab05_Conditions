Console.Write("Введите количество посещений (из 19): ");
int attendance = int.Parse(Console.ReadLine());
Console.Write("Введите средний балл по практике: ");
double practiceGpa = double.Parse(Console.ReadLine());
bool goodAttendance = attendance >= 14; // посещаемость >= 75%
bool goodGrades = practiceGpa >= 3.0;  // оценка не ниже 3
if (goodAttendance && goodGrades) {
    Console.WriteLine("+ Допуск к экзамену разрешён.");
}
else if (!goodAttendance && goodGrades) {
    Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
}
else if (goodAttendance && !goodGrades) {
    Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
}
else {
    Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
}