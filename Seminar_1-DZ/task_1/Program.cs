Console.Write("Введите число 1 > ");
string str_A = Console.ReadLine();

Console.Write("Введите число 2 > ");
string str_B = Console.ReadLine();

int int_A = Convert.ToInt32(str_A);
int int_B = Convert.ToInt32(str_B);

if (int_A > int_B){
    Console.WriteLine("Максимальное число: " + Convert.ToString(int_A));
}
else{
    Console.WriteLine("Максимальное число: " + Convert.ToString(int_B));
}