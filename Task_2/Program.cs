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

void ChangeRowArray(int [,] array, int rowFirst, int rowSecond, int row, int col){
    int [] tempArray = new int [row];
    for(int i=rowFirst, j=0, t=0; j<array.GetLength(1); j++, t++){
        tempArray[t] = array[i,j];
    }
    for (int j=0; j<array.GetLength(1); j++){
        array[rowFirst,j] = array[rowSecond,j];
    }
    Console.WriteLine();
    for (int j=0; j<array.GetLength(1); j++){
        array[rowSecond,j] = tempArray[j];
    }
    for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int minNum = 1;
int maxNum = 9;
int row = 5;
int col = 5;
int rowFirst = 0;
int rowSecond = 4;


int [,] array = CreateArray(row,col,minNum,maxNum);
ShowArray(array);
ChangeRowArray(array,rowFirst,rowSecond,row,col);