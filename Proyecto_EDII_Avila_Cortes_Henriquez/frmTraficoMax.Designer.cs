namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    partial class frmTraficoMax
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvTrafMax = new DataGridView();
            btnCerrar = new Button();
            Origen = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Tiempo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTrafMax).BeginInit();
            SuspendLayout();
            // 
            // dgvTrafMax
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTrafMax.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTrafMax.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrafMax.Columns.AddRange(new DataGridViewColumn[] { Origen, Destino, Tiempo });
            dgvTrafMax.Location = new Point(29, 71);
            dgvTrafMax.Name = "dgvTrafMax";
            dgvTrafMax.Size = new Size(520, 174);
            dgvTrafMax.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(243, 270);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 40);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            Origen.Width = 200;
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.Name = "Destino";
            Destino.Width = 200;
            // 
            // Tiempo
            // 
            Tiempo.HeaderText = "Tiempo";
            Tiempo.Name = "Tiempo";
            Tiempo.Width = 75;
            // 
            // frmTraficoMax
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 322);
            Controls.Add(btnCerrar);
            Controls.Add(dgvTrafMax);
            Name = "frmTraficoMax";
            Text = "Tráfico máximo";
            ((System.ComponentModel.ISupportInitialize)dgvTrafMax).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTrafMax;
        private Button btnCerrar;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Tiempo;
    }
}