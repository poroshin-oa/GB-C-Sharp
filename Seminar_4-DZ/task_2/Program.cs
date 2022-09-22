// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int int_num){
    int result = 0;

    string str_num = Convert.ToString(int_num);

    for (int i = 0; i < str_num.Length; i++){
        result = result + Convert.ToInt32(Convert.ToString(str_num[i]));
    }

    return result;
}

Console.WriteLine(GetSum(9012));