// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите номер дня недели: > ");
int week_day = Convert.ToInt32(Console.ReadLine());

if (week_day == 6 | week_day == 7 ){
    Console.WriteLine("Выходной день");
}
else if (week_day > 7 | week_day <= 0){
    Console.WriteLine("Такого дня недели не существует!");
}
else{
    Console.WriteLine("Будний день");
}

