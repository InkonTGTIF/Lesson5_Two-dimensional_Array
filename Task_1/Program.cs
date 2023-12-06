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
        Console.WriteLine($"({rowIndex},{colIndex}) => " + array[rowIndex,colIndex]);
    }
}

int minNum = 1;
int maxNum = 9;
int row = 5;
int col = 5;
int rowIndex = 1;
int colIndex = 2;

int [,] array = CreateArray(row,col,minNum,maxNum);
ShowArray(array,rowIndex,colIndex);