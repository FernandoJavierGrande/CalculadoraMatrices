using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMatrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reinicio();
        }
        

        #region matricesXDef
        int f1 = 2;
        int c1 = 2;
        int f2 = 0;
        int c2 = 0;
        float[,] matriz1;
        float[,] matriz2;
        string matrizA = "", matrizB = "", matrizRes = "";
        float[,] matrizR;

        Random random = new Random();
        Matrices calcular;
        #endregion

        #region Eventos
        private void btn_sum_Click(object sender, EventArgs e)
        {
            
            error.Clear();
            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                calcular = new Matrices();
                matrizR = new float[c1, f1];
                matrizR = calcular.Operar(matriz1, matriz2, 1);
                MostrarRes();
            }
            else
            {
                error.SetError(btn_sum, "Tamaño de matrices incorrecto");
            }
        }
        private void btn_restar_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                calcular = new Matrices();
                matrizR = new float[c1, f1];
                matrizR = calcular.Operar(matriz1, matriz2,-1);
                MostrarRes();
            }
            else
            {
                error.SetError(btn_restar, "Tamaño de matrices incorrecto");
            }

        }
        private void btn_crear_Click(object sender, EventArgs e)
        {
            LlenarMat();
            btn_escalar.Enabled = true;
            btn_matrices.Enabled = true;
            btn_restar.Enabled = true;
            btn_sum.Enabled = true;
            btn_transpuesta.Enabled = true;
        }
        private void btn_matrices_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (matriz1.GetLength(1)==matriz2.GetLength(0))
            {
                calcular = new Matrices();
                matrizR = new float[c1, f1];
                matrizR = calcular.Multiplicacion(matriz1, matriz2);

                MostrarRes();
            }
            else
            {
                error.SetError(btn_matrices,"Tamaño de matrices incorrecto");
            }

            
        }
        private void btn_escalar_Click(object sender, EventArgs e)
        {
            error.Clear();
            if (txt_escalar.Text != string.Empty)
            {
                try
                {
                    int escalar = int.Parse(txt_escalar.Text);
                    calcular = new Matrices();
                    matrizR = new float[c1, f1];
                    matrizR = calcular.PorEscalar(matriz1, escalar);
                    MostrarRes(); 

                }
                catch (Exception)
                {

                    error.SetError(txt_escalar, "Debe ser un numero");
                }
            }
            else
            {
                error.SetError(txt_escalar, "Campo incompleto");
            }
            
        }
        private void ctr_filas_ValueChanged(object sender, EventArgs e)
        {
            f1 = Convert.ToInt32(ctr_filas.Value);
        }
        private void ctr_columnas_ValueChanged(object sender, EventArgs e)
        {
            c1 = Convert.ToInt32(ctr_columnas.Value);
        }
        private void ctr_filasM2_ValueChanged(object sender, EventArgs e)
        {
            f2 = Convert.ToInt32(ctr_filasM2.Value);
        }
        private void ctr_colM2_ValueChanged(object sender, EventArgs e)
        {
            c2 = Convert.ToInt32(ctr_colM2.Value);
        }
        private void btn_transpuesta_Click(object sender, EventArgs e)
        {
            calcular = new Matrices();
            matrizR = new float[c1, f1];
            matrizR = calcular.Transpuesta(matriz1);
            MostrarRes();
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            reinicio();
        }
        #endregion

        #region Metodos
        public void LlenarMat()
        {
            matrizA = "";
            matrizB = "";

            matriz1 = new float[f1,c1];
            matriz2 = new float[f2,c2];

            for (int i = 0; i < f1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    matriz1[i,j]=(random.Next(-10, 10));
                }
            }
            for (int i = 0; i < f2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    matriz2[i,j] = (random.Next(-10, 10));
                }
            }
            for (int i = 0; i < f1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    matrizA += $"{matriz1[i, j]}  ";
                }
                matrizA += "\n";
            }
            for (int i = 0; i < f2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    matrizB += $"{matriz2[i, j]}  ";
                }
                matrizB += "\n";
            }
            label_matrizRes.Text = matrizRes;
            label_matriz1.Text = matrizA;
            label_matriz2.Text = matrizB;
        }
        public void MostrarRes()
        {
            label_matrizRes.Text = "";
            matrizRes = "";
            int filas = matrizR.GetLength(0);
            int col = matrizR.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrizRes += $" {matrizR[i, j]} ";
                }
                matrizRes += "\n";
            }
            label_matrizRes.Text = matrizRes;
        }
        private void reinicio()
        {
            this.Refresh();            
            btn_escalar.Enabled = false;
            btn_matrices.Enabled = false;
            btn_restar.Enabled = false;
            btn_sum.Enabled = false;
            btn_transpuesta.Enabled = false;

            f1 = 2;
            c1 = 2;
            f2 = 0;
            c2 = 0;
            matrizA = "";
            matrizB = "";
            matrizRes = "";
            label_matriz1.Text ="";
            label_matriz2.Text = "";
            label_matrizRes.Text = "";

            txt_escalar.Text = "";

            ctr_colM2.Value = 0;
            ctr_columnas.Value = 0;
            ctr_filas.Value = 0;
            ctr_filasM2.Value = 0;

        }

        #endregion
    }
}
