using System;


7x7
class Program
{
    static void Main(string[] args)
    {
       
        char[,] matriz = new char[7, 7];

        cargarLetraEnMatriz('L', matriz);
        pintarLetraDeMatriz(matriz);
        matriz = new char[7, 7];
        cargarLetraEnMatriz('T', matriz);
        pintarLetraDeMatriz(matriz);
    }
    public static void pintarLetraDeMatriz(char[,] matriz)
    {
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write(matriz[i, j]);
            }
            Console.WriteLine("");
        }
    }
    public static void cargarLetraEnMatriz(char letra, char[,] matriz)
    {

        if (letra == 'T')
        {
            for (int i = 0; i < 7; i++)
            {
                matriz[0, i] = '*';
                matriz[i, 3] = '*';
            }
        }
        else if (letra == 'L')
        {
            for (int i = 0; i < 7; i++)
            {
                matriz[i, 0] = '*';
                matriz[6, i] = '*';
            }
        }

    }



}

