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
            lblMapa = new Label();
            dgvMapa = new DataGridView();
            Origen = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Tiempo = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
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
            dgvMapa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMapa.Columns.AddRange(new DataGridViewColumn[] { Origen, Destino, Tiempo });
            dgvMapa.Location = new Point(60, 70);
            dgvMapa.Name = "dgvMapa";
            dgvMapa.Size = new Size(680, 299);
            dgvMapa.TabIndex = 1;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.Name = "Destino";
            // 
            // Tiempo
            // 
            Tiempo.HeaderText = "Tiempo Tráfico (min)";
            Tiempo.Name = "Tiempo";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(355, 389);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 48);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmMostrarMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(btnSalir);
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
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Tiempo;
        private Button btnSalir;
    }
}