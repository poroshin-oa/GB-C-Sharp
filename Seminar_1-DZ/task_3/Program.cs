Console.Write("Введите число > ");
string A = Console.ReadLine();

if (Convert.ToInt32(A) % 2 == 0){
    Console.WriteLine("Четное");
}
else{
    Console.WriteLine("Нечетное");
}