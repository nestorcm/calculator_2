namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnCuatro = new Button();
            btnNueve = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            btneliminaruno = new Button();
            btneliminartodo = new Button();
            btnCero = new Button();
            btnSuma = new Button();
            btnResta = new Button();
            btnMulti = new Button();
            btnDivicion = new Button();
            btnPorcentaje = new Button();
            btnPotencia = new Button();
            btnRaiz = new Button();
            btnValorAbsoluto = new Button();
            btnPunto = new Button();
            masmenosbtn = new Button();
            btnigual = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(3, 1);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(432, 33);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btnUno
            // 
            btnUno.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnUno.Location = new Point(7, 268);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(70, 70);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += btnUno_Click_1;
            // 
            // btnDos
            // 
            btnDos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDos.Location = new Point(83, 268);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(70, 70);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += btnDos_Click_1;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnTres.Location = new Point(159, 268);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(70, 70);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click_1;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeis.Location = new Point(159, 192);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(70, 70);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click_1;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCinco.Location = new Point(83, 192);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(70, 70);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click_1;
            // 
            // btnCuatro
            // 
            btnCuatro.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuatro.Location = new Point(7, 192);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(70, 70);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += btnCuatro_Click_1;
            // 
            // btnNueve
            // 
            btnNueve.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNueve.Location = new Point(159, 116);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(70, 70);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += btnNueve_Click_1;
            // 
            // btnOcho
            // 
            btnOcho.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnOcho.Location = new Point(83, 116);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(70, 70);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += btnOcho_Click_1;
            // 
            // btnSiete
            // 
            btnSiete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiete.Location = new Point(7, 116);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(70, 70);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += btnSiete_Click_1;
            // 
            // btneliminaruno
            // 
            btneliminaruno.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btneliminaruno.Location = new Point(83, 40);
            btneliminaruno.Name = "btneliminaruno";
            btneliminaruno.Size = new Size(70, 70);
            btneliminaruno.TabIndex = 11;
            btneliminaruno.Text = "C";
            btneliminaruno.UseVisualStyleBackColor = true;
            btneliminaruno.Click += button10_Click;
            // 
            // btneliminartodo
            // 
            btneliminartodo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btneliminartodo.Location = new Point(7, 40);
            btneliminartodo.Name = "btneliminartodo";
            btneliminartodo.Size = new Size(70, 70);
            btneliminartodo.TabIndex = 10;
            btneliminartodo.Text = "CE";
            btneliminartodo.UseVisualStyleBackColor = true;
            btneliminartodo.Click += button11_Click;
            // 
            // btnCero
            // 
            btnCero.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCero.Location = new Point(83, 344);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(70, 70);
            btnCero.TabIndex = 12;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += btnCero_Click;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuma.Location = new Point(265, 116);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(70, 70);
            btnSuma.TabIndex = 13;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += button12_Click;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnResta.Location = new Point(341, 116);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(70, 70);
            btnResta.TabIndex = 14;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click_1;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMulti.Location = new Point(265, 192);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(70, 70);
            btnMulti.TabIndex = 15;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnDivicion
            // 
            btnDivicion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivicion.Location = new Point(341, 192);
            btnDivicion.Name = "btnDivicion";
            btnDivicion.Size = new Size(70, 70);
            btnDivicion.TabIndex = 16;
            btnDivicion.Text = "/";
            btnDivicion.UseVisualStyleBackColor = true;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPorcentaje.Location = new Point(265, 268);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(70, 70);
            btnPorcentaje.TabIndex = 17;
            btnPorcentaje.Text = "%";
            btnPorcentaje.UseVisualStyleBackColor = true;
            // 
            // btnPotencia
            // 
            btnPotencia.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPotencia.Location = new Point(341, 268);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(70, 70);
            btnPotencia.TabIndex = 18;
            btnPotencia.Text = "^";
            btnPotencia.UseVisualStyleBackColor = true;
            // 
            // btnRaiz
            // 
            btnRaiz.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaiz.Location = new Point(265, 346);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(70, 70);
            btnRaiz.TabIndex = 19;
            btnRaiz.Text = "√ ";
            btnRaiz.UseVisualStyleBackColor = true;
            // 
            // btnValorAbsoluto
            // 
            btnValorAbsoluto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnValorAbsoluto.Location = new Point(341, 346);
            btnValorAbsoluto.Name = "btnValorAbsoluto";
            btnValorAbsoluto.Size = new Size(70, 70);
            btnValorAbsoluto.TabIndex = 20;
            btnValorAbsoluto.Text = "|x|";
            btnValorAbsoluto.UseVisualStyleBackColor = true;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPunto.Location = new Point(7, 344);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(70, 70);
            btnPunto.TabIndex = 21;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click_1;
            // 
            // masmenosbtn
            // 
            masmenosbtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            masmenosbtn.Location = new Point(159, 40);
            masmenosbtn.Name = "masmenosbtn";
            masmenosbtn.Size = new Size(70, 70);
            masmenosbtn.TabIndex = 22;
            masmenosbtn.Text = "+/-";
            masmenosbtn.UseVisualStyleBackColor = true;
            masmenosbtn.Click += masmenosbtn_Click;
            // 
            // btnigual
            // 
            btnigual.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnigual.Location = new Point(159, 344);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(70, 70);
            btnigual.TabIndex = 23;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = true;
            btnigual.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 428);
            Controls.Add(btnigual);
            Controls.Add(masmenosbtn);
            Controls.Add(btnPunto);
            Controls.Add(btnValorAbsoluto);
            Controls.Add(btnRaiz);
            Controls.Add(btnPotencia);
            Controls.Add(btnPorcentaje);
            Controls.Add(btnDivicion);
            Controls.Add(btnMulti);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(btnCero);
            Controls.Add(btneliminaruno);
            Controls.Add(btneliminartodo);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnCuatro;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnSiete;
        private Button btneliminaruno;
        private Button btneliminartodo;
        private Button btnCero;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMulti;
        private Button btnDivicion;
        private Button btnPorcentaje;
        private Button btnPotencia;
        private Button btnRaiz;
        private Button btnValorAbsoluto;
        private Button btnPunto;
        private Button masmenosbtn;
        private Button btnigual;
    }
}