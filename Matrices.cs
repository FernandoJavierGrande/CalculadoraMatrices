using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMatrices
{
    public class Matrices
    {

        public float[,] Operar(float[,] matriz1, float[,] matriz2, int operacion)
        {
            int filas = matriz1.GetLength(0);
            int col = matriz1.GetLength(1);

            float[,] resultado = new float[filas,col];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (operacion==1)
                    {
                        resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                    }
                    else if (operacion == -1)
                    {
                        resultado[i, j] = matriz1[i, j] - (matriz2[i, j]);
                    }
                }
            }

            return resultado;

        }
        public float[,] Transpuesta(float[,] matriz)
        {
            int filas = matriz.GetLength(0); 
            int columnas = matriz.GetLength(1);

            float[,] resultado = new float[columnas, filas];

            for (int i = 0;i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado[j,i] = matriz[i,j];
                }
            }
            return resultado;
        }
        public float[,] Multiplicacion(float[,] matriz1, float[,] matriz2)
        {
            int filasM1 = matriz1.GetLength(0);
            int colM1 = matriz1.GetLength (1);

            int filasM2 = matriz2.GetLength(0);
            int colM2 = matriz2.GetLength (1);


            float[,] resultado = new float[filasM1, colM2];

            for (int i = 0; i < colM2; i++)
            {
                for (int k = 0; k < filasM1; k++)
                {
                    for (int j = 0; j < colM1; j++)
                    {
                        resultado[k, i] += matriz1[k,j] * matriz2[j, i];
                    }
                }
            }
            return resultado;
        }
        public float[,] PorEscalar(float[,] matriz1,int escalar)
        {
           
            int filas = matriz1.GetLength(0);
            int col = matriz1.GetLength (1);

            float[,] resultado = new float[filas, col];


            for (int i = 0;i < filas; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    resultado[i, j] = matriz1[i, j] * escalar;
                }
            }
            return resultado;
        }

    }
}
