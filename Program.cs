using System;
using System.IO;

class Program {
    public static void Main(string[] args) {

        string[] ReadInData = File.ReadAllLines("students.csv");

        int rows = ReadInData.Length;
        int columns = 2;

        string[,] Data = new string[rows, columns];
        
        string[] temp = new string[columns];

        for(int i = 0; i < rows; i++) {

            for(int j = 0; j < columns; j++) {
                Data[i,j] = ReadInData[i].Split(',')[j];
            }
        }

    }
}
