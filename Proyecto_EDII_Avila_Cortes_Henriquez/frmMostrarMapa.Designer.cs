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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblMapa = new Label();
            dgvMapa = new DataGridView();
            Origen = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Tiempo = new DataGridViewTextBoxColumn();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMapa).BeginInit();
            SuspendLayout();
            // 
            // lblMapa
            // 
            lblMapa.AutoSize = true;
            lblMapa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMapa.Location = new Point(474, 30);
            lblMapa.Margin = new Padding(4, 0, 4, 0);
            lblMapa.Name = "lblMapa";
            lblMapa.Size = new Size(208, 40);
            lblMapa.TabIndex = 0;
            lblMapa.Text = "Mapa de Rutas";
            // 
            // dgvMapa
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMapa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMapa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMapa.Columns.AddRange(new DataGridViewColumn[] { Origen, Destino, Tiempo });
            dgvMapa.Location = new Point(73, 117);
            dgvMapa.Margin = new Padding(4, 5, 4, 5);
            dgvMapa.Name = "dgvMapa";
            dgvMapa.RowHeadersWidth = 62;
            dgvMapa.Size = new Size(990, 498);
            dgvMapa.TabIndex = 1;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.MinimumWidth = 8;
            Origen.Name = "Origen";
            Origen.Width = 250;
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.MinimumWidth = 8;
            Destino.Name = "Destino";
            Destino.Width = 250;
            // 
            // Tiempo
            // 
            Tiempo.HeaderText = "Tiempo Tráfico (min)";
            Tiempo.MinimumWidth = 8;
            Tiempo.Name = "Tiempo";
            Tiempo.Width = 150;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(507, 648);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(143, 80);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmMostrarMapa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 748);
            Controls.Add(btnCerrar);
            Controls.Add(dgvMapa);
            Controls.Add(lblMapa);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMostrarMapa";
            Text = "Mostrar Mapa de Rutas";
            Load += frmMostrarMapa_Load;
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