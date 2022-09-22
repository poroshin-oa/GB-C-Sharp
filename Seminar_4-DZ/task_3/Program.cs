// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int int1, int int2, int int3, int int4, int int5, int int6, int int7, int int8){
    
    int[] new_array = new int[8];
    new_array[0] = int1;
    new_array[1] = int2;
    new_array[2] = int3;
    new_array[3] = int4;
    new_array[4] = int5;
    new_array[5] = int6;
    new_array[6] = int7;
    new_array[7] = int8;
    
    return new_array;
}

void PrintArray(int[] input_array){
    
    for(int i = 0; i < input_array.Length; i++){
        Console.WriteLine(input_array[i]);
    }
}

PrintArray(CreateArray(1,2,4,6,7,8,5,6));