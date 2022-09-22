Console.Write("Введите число > ");
string N = Console.ReadLine();

for (int i = 1; i <= Convert.ToInt32(N); i++){
    if (i % 2 == 0){
        Console.WriteLine(i);        
    }
}