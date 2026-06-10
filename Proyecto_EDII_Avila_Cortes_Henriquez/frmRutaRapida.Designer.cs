namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    partial class frmRutaRapida
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
            cbxOrigen = new ComboBox();
            cbxDestino = new ComboBox();
            lblOrigen = new Label();
            lblDestino = new Label();
            lblTitulo = new Label();
            gbxRuta = new GroupBox();
            btnConsultar = new Button();
            lblRecorridos = new Label();
            lbxRuta = new ListBox();
            lblTiempoEst = new Label();
            gbxResultado = new GroupBox();
            lblComplMinutos = new Label();
            lblMinutos = new Label();
            btnCerrar = new Button();
            btnLimpiar = new Button();
            gbxRuta.SuspendLayout();
            gbxResultado.SuspendLayout();
            SuspendLayout();
            // 
            // cbxOrigen
            // 
            cbxOrigen.FormattingEnabled = true;
            cbxOrigen.Location = new Point(39, 113);
            cbxOrigen.Margin = new Padding(4, 5, 4, 5);
            cbxOrigen.Name = "cbxOrigen";
            cbxOrigen.Size = new Size(284, 33);
            cbxOrigen.TabIndex = 0;
            // 
            // cbxDestino
            // 
            cbxDestino.FormattingEnabled = true;
            cbxDestino.Location = new Point(600, 113);
            cbxDestino.Margin = new Padding(4, 5, 4, 5);
            cbxDestino.Name = "cbxDestino";
            cbxDestino.Size = new Size(284, 33);
            cbxDestino.TabIndex = 1;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI", 12F);
            lblOrigen.Location = new Point(39, 55);
            lblOrigen.Margin = new Padding(4, 0, 4, 0);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(230, 32);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Seleccione el origen";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 12F);
            lblDestino.Location = new Point(600, 55);
            lblDestino.Margin = new Padding(4, 0, 4, 0);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(240, 32);
            lblDestino.TabIndex = 3;
            lblDestino.Text = "Seleccione el destino";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(410, 32);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(325, 40);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Mostrar ruta mas rápida";
            // 
            // gbxRuta
            // 
            gbxRuta.Controls.Add(btnConsultar);
            gbxRuta.Controls.Add(lblDestino);
            gbxRuta.Controls.Add(cbxOrigen);
            gbxRuta.Controls.Add(cbxDestino);
            gbxRuta.Controls.Add(lblOrigen);
            gbxRuta.Location = new Point(91, 103);
            gbxRuta.Margin = new Padding(4, 5, 4, 5);
            gbxRuta.Name = "gbxRuta";
            gbxRuta.Padding = new Padding(4, 5, 4, 5);
            gbxRuta.Size = new Size(973, 283);
            gbxRuta.TabIndex = 6;
            gbxRuta.TabStop = false;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(403, 183);
            btnConsultar.Margin = new Padding(4, 5, 4, 5);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(143, 67);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblRecorridos
            // 
            lblRecorridos.AutoSize = true;
            lblRecorridos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecorridos.Location = new Point(566, 32);
            lblRecorridos.Margin = new Padding(4, 0, 4, 0);
            lblRecorridos.Name = "lblRecorridos";
            lblRecorridos.Size = new Size(268, 40);
            lblRecorridos.TabIndex = 7;
            lblRecorridos.Text = "Recorrido de la ruta";
            // 
            // lbxRuta
            // 
            lbxRuta.FormattingEnabled = true;
            lbxRuta.Location = new Point(443, 78);
            lbxRuta.Margin = new Padding(4, 5, 4, 5);
            lbxRuta.Name = "lbxRuta";
            lbxRuta.Size = new Size(500, 154);
            lbxRuta.TabIndex = 8;
            // 
            // lblTiempoEst
            // 
            lblTiempoEst.AutoSize = true;
            lblTiempoEst.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempoEst.Location = new Point(13, 32);
            lblTiempoEst.Margin = new Padding(4, 0, 4, 0);
            lblTiempoEst.Name = "lblTiempoEst";
            lblTiempoEst.Size = new Size(253, 40);
            lblTiempoEst.TabIndex = 9;
            lblTiempoEst.Text = "Tiempo Estimado: ";
            // 
            // gbxResultado
            // 
            gbxResultado.Controls.Add(lblComplMinutos);
            gbxResultado.Controls.Add(lblMinutos);
            gbxResultado.Controls.Add(lblTiempoEst);
            gbxResultado.Controls.Add(lbxRuta);
            gbxResultado.Controls.Add(lblRecorridos);
            gbxResultado.Location = new Point(91, 417);
            gbxResultado.Margin = new Padding(4, 5, 4, 5);
            gbxResultado.Name = "gbxResultado";
            gbxResultado.Padding = new Padding(4, 5, 4, 5);
            gbxResultado.Size = new Size(973, 263);
            gbxResultado.TabIndex = 10;
            gbxResultado.TabStop = false;
            // 
            // lblComplMinutos
            // 
            lblComplMinutos.AutoSize = true;
            lblComplMinutos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplMinutos.Location = new Point(167, 112);
            lblComplMinutos.Margin = new Padding(4, 0, 4, 0);
            lblComplMinutos.Name = "lblComplMinutos";
            lblComplMinutos.Size = new Size(139, 40);
            lblComplMinutos.TabIndex = 11;
            lblComplMinutos.Text = "Minutos ";
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinutos.Location = new Point(51, 112);
            lblMinutos.Margin = new Padding(4, 0, 4, 0);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(56, 40);
            lblMinutos.TabIndex = 10;
            lblMinutos.Text = "***";
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(871, 702);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(143, 67);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(230, 702);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(143, 67);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmRutaRapida
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 788);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            Controls.Add(gbxResultado);
            Controls.Add(gbxRuta);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRutaRapida";
            Text = "Ruta mas Rápida";
            gbxRuta.ResumeLayout(false);
            gbxRuta.PerformLayout();
            gbxResultado.ResumeLayout(false);
            gbxResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxOrigen;
        private ComboBox cbxDestino;
        private Label lblOrigen;
        private Label lblDestino;
        private Label lblTitulo;
        private GroupBox gbxRuta;
        private Button btnConsultar;
        private Label lblRecorridos;
        private ListBox lbxRuta;
        private Label lblTiempoEst;
        private GroupBox gbxResultado;
        private Label lblComplMinutos;
        private Label lblMinutos;
        private Button btnCerrar;
        private Button btnLimpiar;
    }
}