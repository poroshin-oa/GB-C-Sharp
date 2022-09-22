// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ToDegree(int basis, int degree){
    int result = 1;

    for (int i = 1; i <= degree; i++){
        result = result * basis;
    }

    return result;
}

Console.WriteLine(ToDegree(3, 5));
