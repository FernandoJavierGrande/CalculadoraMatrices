namespace CalculadoraMatrices
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ctr_filas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ctr_columnas = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.txt_escalar = new System.Windows.Forms.TextBox();
            this.label_matrizRes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctr_filasM2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ctr_colM2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_matriz1 = new System.Windows.Forms.Label();
            this.label_matriz2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_restar = new System.Windows.Forms.Button();
            this.btn_matrices = new System.Windows.Forms.Button();
            this.btn_escalar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_transpuesta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_filas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_columnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_filasM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_colM2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filas";
            // 
            // ctr_filas
            // 
            this.ctr_filas.Location = new System.Drawing.Point(62, 21);
            this.ctr_filas.Name = "ctr_filas";
            this.ctr_filas.Size = new System.Drawing.Size(58, 22);
            this.ctr_filas.TabIndex = 1;
            this.ctr_filas.ValueChanged += new System.EventHandler(this.ctr_filas_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columnas";
            // 
            // ctr_columnas
            // 
            this.ctr_columnas.Location = new System.Drawing.Point(250, 23);
            this.ctr_columnas.Name = "ctr_columnas";
            this.ctr_columnas.Size = new System.Drawing.Size(62, 22);
            this.ctr_columnas.TabIndex = 3;
            this.ctr_columnas.ValueChanged += new System.EventHandler(this.ctr_columnas_ValueChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(378, 35);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 16);
            this.label.TabIndex = 4;
            this.label.Text = "Escalar";
            // 
            // txt_escalar
            // 
            this.txt_escalar.Location = new System.Drawing.Point(451, 32);
            this.txt_escalar.Name = "txt_escalar";
            this.txt_escalar.Size = new System.Drawing.Size(69, 22);
            this.txt_escalar.TabIndex = 5;
            // 
            // label_matrizRes
            // 
            this.label_matrizRes.AutoSize = true;
            this.label_matrizRes.Location = new System.Drawing.Point(540, 273);
            this.label_matrizRes.Name = "label_matrizRes";
            this.label_matrizRes.Size = new System.Drawing.Size(0, 16);
            this.label_matrizRes.TabIndex = 6;
            this.label_matrizRes.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filas ";
            // 
            // ctr_filasM2
            // 
            this.ctr_filasM2.Location = new System.Drawing.Point(62, 25);
            this.ctr_filasM2.Name = "ctr_filasM2";
            this.ctr_filasM2.Size = new System.Drawing.Size(58, 22);
            this.ctr_filasM2.TabIndex = 8;
            this.ctr_filasM2.ValueChanged += new System.EventHandler(this.ctr_filasM2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Columnas";
            // 
            // ctr_colM2
            // 
            this.ctr_colM2.Location = new System.Drawing.Point(250, 23);
            this.ctr_colM2.Name = "ctr_colM2";
            this.ctr_colM2.Size = new System.Drawing.Size(62, 22);
            this.ctr_colM2.TabIndex = 10;
            this.ctr_colM2.ValueChanged += new System.EventHandler(this.ctr_colM2_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctr_columnas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ctr_filas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 70);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primera matriz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctr_colM2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ctr_filasM2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 69);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Segunda matriz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Primera matriz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Segunda matriz";
            // 
            // label_matriz1
            // 
            this.label_matriz1.AutoSize = true;
            this.label_matriz1.Location = new System.Drawing.Point(78, 273);
            this.label_matriz1.Name = "label_matriz1";
            this.label_matriz1.Size = new System.Drawing.Size(0, 16);
            this.label_matriz1.TabIndex = 15;
            // 
            // label_matriz2
            // 
            this.label_matriz2.AutoSize = true;
            this.label_matriz2.Location = new System.Drawing.Point(301, 273);
            this.label_matriz2.Name = "label_matriz2";
            this.label_matriz2.Size = new System.Drawing.Size(0, 16);
            this.label_matriz2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Matriz resultante";
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(381, 115);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(66, 27);
            this.btn_sum.TabIndex = 18;
            this.btn_sum.Text = "Sumar";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_restar
            // 
            this.btn_restar.Location = new System.Drawing.Point(381, 155);
            this.btn_restar.Name = "btn_restar";
            this.btn_restar.Size = new System.Drawing.Size(66, 27);
            this.btn_restar.TabIndex = 19;
            this.btn_restar.Text = "Restar";
            this.btn_restar.UseVisualStyleBackColor = true;
            this.btn_restar.Click += new System.EventHandler(this.btn_restar_Click);
            // 
            // btn_matrices
            // 
            this.btn_matrices.Location = new System.Drawing.Point(620, 155);
            this.btn_matrices.Name = "btn_matrices";
            this.btn_matrices.Size = new System.Drawing.Size(120, 27);
            this.btn_matrices.TabIndex = 20;
            this.btn_matrices.Text = "Mult. matrices";
            this.btn_matrices.UseVisualStyleBackColor = true;
            this.btn_matrices.Click += new System.EventHandler(this.btn_matrices_Click);
            // 
            // btn_escalar
            // 
            this.btn_escalar.Location = new System.Drawing.Point(479, 155);
            this.btn_escalar.Name = "btn_escalar";
            this.btn_escalar.Size = new System.Drawing.Size(109, 27);
            this.btn_escalar.TabIndex = 21;
            this.btn_escalar.Text = "Mult. escalar";
            this.btn_escalar.UseVisualStyleBackColor = true;
            this.btn_escalar.Click += new System.EventHandler(this.btn_escalar_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(598, 24);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(83, 63);
            this.btn_crear.TabIndex = 22;
            this.btn_crear.Text = "Generar";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(702, 47);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(74, 23);
            this.btn_refresh.TabIndex = 23;
            this.btn_refresh.Text = "Limpiar";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_transpuesta
            // 
            this.btn_transpuesta.Location = new System.Drawing.Point(479, 119);
            this.btn_transpuesta.Name = "btn_transpuesta";
            this.btn_transpuesta.Size = new System.Drawing.Size(96, 23);
            this.btn_transpuesta.TabIndex = 24;
            this.btn_transpuesta.Text = "Transponer";
            this.btn_transpuesta.UseVisualStyleBackColor = true;
            this.btn_transpuesta.Click += new System.EventHandler(this.btn_transpuesta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_transpuesta);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_escalar);
            this.Controls.Add(this.btn_matrices);
            this.Controls.Add(this.btn_restar);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_matriz2);
            this.Controls.Add(this.label_matriz1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_matrizRes);
            this.Controls.Add(this.txt_escalar);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Calculadora de matrices";
            ((System.ComponentModel.ISupportInitialize)(this.ctr_filas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_columnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_filasM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctr_colM2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ctr_filas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ctr_columnas;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt_escalar;
        private System.Windows.Forms.Label label_matrizRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ctr_filasM2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ctr_colM2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_matriz1;
        private System.Windows.Forms.Label label_matriz2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.Button btn_matrices;
        private System.Windows.Forms.Button btn_escalar;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_transpuesta;
    }
}

