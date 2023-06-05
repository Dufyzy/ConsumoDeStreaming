namespace ConsumoDeStreaming
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnUsuarios = new Button();
            btnTermina = new Button();
            btnConsumo = new Button();
            btnGenero = new Button();
            btnPais = new Button();
            btnEstreno = new Button();
            btnTopPeliculas = new Button();
            btnTopSeries = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 385);
            panel1.TabIndex = 1;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(12, 12);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(130, 48);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "TIPOS DE USUARIOS";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnTermina
            // 
            btnTermina.Location = new Point(12, 66);
            btnTermina.Name = "btnTermina";
            btnTermina.Size = new Size(130, 48);
            btnTermina.TabIndex = 3;
            btnTermina.Text = "PORCENTAJE DE QUIEN TERMINA";
            btnTermina.UseVisualStyleBackColor = true;
            btnTermina.Click += btnTermina_Click;
            // 
            // btnConsumo
            // 
            btnConsumo.Location = new Point(239, 12);
            btnConsumo.Name = "btnConsumo";
            btnConsumo.Size = new Size(130, 48);
            btnConsumo.TabIndex = 4;
            btnConsumo.Text = "CONSUMO POR PORCENTAJE";
            btnConsumo.UseVisualStyleBackColor = true;
            btnConsumo.Click += btnConsumo_Click;
            // 
            // btnGenero
            // 
            btnGenero.Location = new Point(239, 66);
            btnGenero.Name = "btnGenero";
            btnGenero.Size = new Size(130, 48);
            btnGenero.TabIndex = 5;
            btnGenero.Text = "CONSUMO POR GENERO";
            btnGenero.UseVisualStyleBackColor = true;
            btnGenero.Click += btnGenero_Click;
            // 
            // btnPais
            // 
            btnPais.Location = new Point(488, 66);
            btnPais.Name = "btnPais";
            btnPais.Size = new Size(130, 48);
            btnPais.TabIndex = 7;
            btnPais.Text = "CONSUMO POR PAIS";
            btnPais.UseVisualStyleBackColor = true;
            btnPais.Click += btnPais_Click;
            // 
            // btnEstreno
            // 
            btnEstreno.Location = new Point(488, 12);
            btnEstreno.Name = "btnEstreno";
            btnEstreno.Size = new Size(130, 48);
            btnEstreno.TabIndex = 8;
            btnEstreno.Text = "ESTRENOS POR AÑO";
            btnEstreno.UseVisualStyleBackColor = true;
            btnEstreno.Click += btnEstreno_Click;
            // 
            // btnTopPeliculas
            // 
            btnTopPeliculas.Location = new Point(727, 12);
            btnTopPeliculas.Name = "btnTopPeliculas";
            btnTopPeliculas.Size = new Size(130, 48);
            btnTopPeliculas.TabIndex = 10;
            btnTopPeliculas.Text = "TOP PELICULAS";
            btnTopPeliculas.UseVisualStyleBackColor = true;
            btnTopPeliculas.Click += btnTopPeliculas_Click;
            // 
            // btnTopSeries
            // 
            btnTopSeries.Location = new Point(727, 66);
            btnTopSeries.Name = "btnTopSeries";
            btnTopSeries.Size = new Size(130, 48);
            btnTopSeries.TabIndex = 9;
            btnTopSeries.Text = "TOP SERIES";
            btnTopSeries.UseVisualStyleBackColor = true;
            btnTopSeries.Click += btnTopSeries_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 544);
            Controls.Add(btnTopPeliculas);
            Controls.Add(btnTopSeries);
            Controls.Add(btnEstreno);
            Controls.Add(btnPais);
            Controls.Add(btnGenero);
            Controls.Add(btnTermina);
            Controls.Add(btnConsumo);
            Controls.Add(btnUsuarios);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ESTADISTICAS DE STREAMING";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUsuarios;
        private Button btnTermina;
        private Button btnConsumo;
        private Button btnGenero;
        private Button btnPais;
        private Button btnEstreno;
        private Button btnTopPeliculas;
        private Button btnTopSeries;
    }
}