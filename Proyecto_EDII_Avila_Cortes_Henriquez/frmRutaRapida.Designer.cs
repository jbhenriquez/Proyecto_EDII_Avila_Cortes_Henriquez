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
            listBox1 = new ListBox();
            lblTiempoEst = new Label();
            gbxResultado = new GroupBox();
            lblMinutos = new Label();
            lblComplMinutos = new Label();
            btnSalir = new Button();
            btnLimpiar = new Button();
            gbxRuta.SuspendLayout();
            gbxResultado.SuspendLayout();
            SuspendLayout();
            // 
            // cbxOrigen
            // 
            cbxOrigen.FormattingEnabled = true;
            cbxOrigen.Location = new Point(27, 68);
            cbxOrigen.Name = "cbxOrigen";
            cbxOrigen.Size = new Size(200, 23);
            cbxOrigen.TabIndex = 0;
            // 
            // cbxDestino
            // 
            cbxDestino.FormattingEnabled = true;
            cbxDestino.Location = new Point(420, 68);
            cbxDestino.Name = "cbxDestino";
            cbxDestino.Size = new Size(200, 23);
            cbxDestino.TabIndex = 1;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI", 12F);
            lblOrigen.Location = new Point(27, 33);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(148, 21);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Seleccione el origen";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 12F);
            lblDestino.Location = new Point(420, 33);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(154, 21);
            lblDestino.TabIndex = 3;
            lblDestino.Text = "Seleccione el destino";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(287, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(215, 25);
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
            gbxRuta.Location = new Point(64, 62);
            gbxRuta.Name = "gbxRuta";
            gbxRuta.Size = new Size(681, 170);
            gbxRuta.TabIndex = 6;
            gbxRuta.TabStop = false;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(282, 110);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(100, 40);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblRecorridos
            // 
            lblRecorridos.AutoSize = true;
            lblRecorridos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecorridos.Location = new Point(396, 19);
            lblRecorridos.Name = "lblRecorridos";
            lblRecorridos.Size = new Size(178, 25);
            lblRecorridos.TabIndex = 7;
            lblRecorridos.Text = "Recorrido de la ruta";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(310, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(351, 94);
            listBox1.TabIndex = 8;
            // 
            // lblTiempoEst
            // 
            lblTiempoEst.AutoSize = true;
            lblTiempoEst.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempoEst.Location = new Point(9, 19);
            lblTiempoEst.Name = "lblTiempoEst";
            lblTiempoEst.Size = new Size(166, 25);
            lblTiempoEst.TabIndex = 9;
            lblTiempoEst.Text = "Tiempo Estimado: ";
            // 
            // gbxResultado
            // 
            gbxResultado.Controls.Add(lblComplMinutos);
            gbxResultado.Controls.Add(lblMinutos);
            gbxResultado.Controls.Add(lblTiempoEst);
            gbxResultado.Controls.Add(listBox1);
            gbxResultado.Controls.Add(lblRecorridos);
            gbxResultado.Location = new Point(64, 250);
            gbxResultado.Name = "gbxResultado";
            gbxResultado.Size = new Size(681, 158);
            gbxResultado.TabIndex = 10;
            gbxResultado.TabStop = false;
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinutos.Location = new Point(36, 67);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(39, 25);
            lblMinutos.TabIndex = 10;
            lblMinutos.Text = "***";
            // 
            // lblComplMinutos
            // 
            lblComplMinutos.AutoSize = true;
            lblComplMinutos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplMinutos.Location = new Point(117, 67);
            lblComplMinutos.Name = "lblComplMinutos";
            lblComplMinutos.Size = new Size(91, 25);
            lblComplMinutos.TabIndex = 11;
            lblComplMinutos.Text = "Minutos ";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(610, 421);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 40);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(161, 421);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 40);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmRutaRapida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(gbxResultado);
            Controls.Add(gbxRuta);
            Controls.Add(lblTitulo);
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
        private ListBox listBox1;
        private Label lblTiempoEst;
        private GroupBox gbxResultado;
        private Label lblComplMinutos;
        private Label lblMinutos;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}