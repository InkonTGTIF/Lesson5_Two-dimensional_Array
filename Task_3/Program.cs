int [,] CreateArray(int row, int col, int minNum, int maxNum){
    int [,] array = new int [row,col];
    for (int i=0; i<row; i++){
        for(int j=0; j<col;j++){
            array[i,j] = new Random().Next(minNum, maxNum+1);
        }
    }
    return array;
}

void ShowArray(int [,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}


int minNum = 1;
int maxNum = 9;
int row = 3;
int col = 5;


int [,] array = CreateArray(row,col,minNum,maxNum);
ShowArray(array);
Console.WriteLine();

int MinSumRow(int[,] array, int i){
    int sum = array[i,0];
    for(int j=1; j<array.GetLength(1); j++){
        sum += array[i,j];
    }
    return sum;
}

int minSum = 1;
int sum = MinSumRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++){
    if (sum > MinSumRow(array, i)){
        sum = MinSumRow(array, i);
        minSum = i+1;
    }
}

Console.WriteLine($"Строка с индексом {minSum}");