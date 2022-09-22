int A = 3;
int B = -4;
int C = 13;

if(A > B){
    if(A > C){
        Console.WriteLine("Максимальное число " + Convert.ToString(A));
    }
    else{
        Console.WriteLine("Максимальное число " + Convert.ToString(C));
    }
}
else{
    if(B > C){
        Console.WriteLine("Максимальное число " + Convert.ToString(B));
    }
    else{
        Console.WriteLine("Максимальное число " + Convert.ToString(C));
    }
}