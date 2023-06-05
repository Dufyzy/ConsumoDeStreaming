namespace ConsumoDeStreaming
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblAcceso = new Label();
            lblModificacion = new Label();
            lblCreacion = new Label();
            lblRuta = new Label();
            label1 = new Label();
            btnArchivo = new Button();
            openFileD = new OpenFileDialog();
            dgv1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            btnForm2 = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // lblAcceso
            // 
            lblAcceso.AutoSize = true;
            lblAcceso.Location = new Point(12, 129);
            lblAcceso.Name = "lblAcceso";
            lblAcceso.Size = new Size(0, 15);
            lblAcceso.TabIndex = 11;
            // 
            // lblModificacion
            // 
            lblModificacion.AutoSize = true;
            lblModificacion.Location = new Point(12, 100);
            lblModificacion.Name = "lblModificacion";
            lblModificacion.Size = new Size(0, 15);
            lblModificacion.TabIndex = 10;
            // 
            // lblCreacion
            // 
            lblCreacion.AutoSize = true;
            lblCreacion.Location = new Point(12, 74);
            lblCreacion.Name = "lblCreacion";
            lblCreacion.Size = new Size(0, 15);
            lblCreacion.TabIndex = 9;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(55, 48);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(0, 15);
            lblRuta.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 7;
            label1.Text = "Ruta: ";
            // 
            // btnArchivo
            // 
            btnArchivo.Location = new Point(12, 12);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(150, 23);
            btnArchivo.TabIndex = 6;
            btnArchivo.Text = "ABRIR";
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // openFileD
            // 
            openFileD.FileName = "Busca tu archivo";
            openFileD.Filter = "Archivos TXT(*.txt)|*.txt";
            // 
            // dgv1
            // 
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AllowUserToResizeColumns = false;
            dgv1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            dgv1.Location = new Point(12, 167);
            dgv1.MultiSelect = false;
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.RowHeadersVisible = false;
            dgv1.RowTemplate.Height = 25;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.Size = new Size(1081, 492);
            dgv1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column1.HeaderText = "CUENTA";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 76;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column2.HeaderText = "EDAD";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 62;
            // 
            // Column3
            // 
            Column3.HeaderText = "PAIS";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "PRODUCTO VISTO";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column5.HeaderText = "TIPO";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 57;
            // 
            // Column6
            // 
            Column6.HeaderText = "AÑO DE ESTRENO";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 60;
            // 
            // Column7
            // 
            Column7.HeaderText = "GENERO";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 80;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column8.HeaderText = "DIRECTOR";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 85;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column9.HeaderText = "CLASIFICACION";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 117;
            // 
            // Column10
            // 
            Column10.HeaderText = "DURACION (minutos)";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 80;
            // 
            // Column11
            // 
            Column11.HeaderText = "MINUTOS VISTOS";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 80;
            // 
            // Column12
            // 
            Column12.HeaderText = "PORCENTAJE VISTO";
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 80;
            // 
            // btnForm2
            // 
            btnForm2.Enabled = false;
            btnForm2.Location = new Point(943, 129);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(150, 23);
            btnForm2.TabIndex = 13;
            btnForm2.Text = "VER RESULTADOS";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(998, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(98, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 706);
            Controls.Add(btnSalir);
            Controls.Add(btnForm2);
            Controls.Add(dgv1);
            Controls.Add(lblAcceso);
            Controls.Add(lblModificacion);
            Controls.Add(lblCreacion);
            Controls.Add(lblRuta);
            Controls.Add(label1);
            Controls.Add(btnArchivo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "STREAMING";
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAcceso;
        private Label lblModificacion;
        private Label lblCreacion;
        private Label lblRuta;
        private Label label1;
        private Button btnArchivo;
        private OpenFileDialog openFileD;
        private DataGridView dgv1;
        private Button btnForm2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Button btnSalir;
    }
}