namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    partial class frmMostrarMapa
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
            lblMapa = new Label();
            dgvMapa = new DataGridView();
            btnCerrar = new Button();
            Origen = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Tiempo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMapa).BeginInit();
            SuspendLayout();
            // 
            // lblMapa
            // 
            lblMapa.AutoSize = true;
            lblMapa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMapa.Location = new Point(332, 18);
            lblMapa.Name = "lblMapa";
            lblMapa.Size = new Size(137, 25);
            lblMapa.TabIndex = 0;
            lblMapa.Text = "Mapa de Rutas";
            // 
            // dgvMapa
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMapa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMapa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMapa.Columns.AddRange(new DataGridViewColumn[] { Origen, Destino, Tiempo });
            dgvMapa.Location = new Point(51, 70);
            dgvMapa.Name = "dgvMapa";
            dgvMapa.Size = new Size(693, 299);
            dgvMapa.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(355, 389);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 48);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            Origen.Width = 250;
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.Name = "Destino";
            Destino.Width = 250;
            // 
            // Tiempo
            // 
            Tiempo.HeaderText = "Tiempo Tráfico (min)";
            Tiempo.Name = "Tiempo";
            Tiempo.Width = 150;
            // 
            // frmMostrarMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(btnCerrar);
            Controls.Add(dgvMapa);
            Controls.Add(lblMapa);
            Name = "frmMostrarMapa";
            Text = "Mostrar Mapa de Rutas";
            ((System.ComponentModel.ISupportInitialize)dgvMapa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMapa;
        private DataGridView dgvMapa;
        private Button btnCerrar;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Tiempo;
    }
}