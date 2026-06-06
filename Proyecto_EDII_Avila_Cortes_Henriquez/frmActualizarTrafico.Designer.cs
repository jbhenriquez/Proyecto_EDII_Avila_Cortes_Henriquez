namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    partial class frmActualizarTrafico
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
            gbxRuta = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblDestino = new Label();
            lblOrigen = new Label();
            gbxActua = new GroupBox();
            txbActual = new TextBox();
            txbUltimo = new TextBox();
            lblActual = new Label();
            lblUltimo = new Label();
            lblTitulo = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            gbxRuta.SuspendLayout();
            gbxActua.SuspendLayout();
            SuspendLayout();
            // 
            // gbxRuta
            // 
            gbxRuta.Controls.Add(comboBox2);
            gbxRuta.Controls.Add(comboBox1);
            gbxRuta.Controls.Add(lblDestino);
            gbxRuta.Controls.Add(lblOrigen);
            gbxRuta.Location = new Point(30, 64);
            gbxRuta.Name = "gbxRuta";
            gbxRuta.Size = new Size(515, 132);
            gbxRuta.TabIndex = 0;
            gbxRuta.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(322, 66);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 12F);
            lblDestino.Location = new Point(321, 23);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(63, 21);
            lblDestino.TabIndex = 1;
            lblDestino.Text = "Destino";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI", 12F);
            lblOrigen.Location = new Point(28, 29);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(58, 21);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "Origen";
            // 
            // gbxActua
            // 
            gbxActua.Controls.Add(txbActual);
            gbxActua.Controls.Add(txbUltimo);
            gbxActua.Controls.Add(lblActual);
            gbxActua.Controls.Add(lblUltimo);
            gbxActua.Location = new Point(30, 211);
            gbxActua.Name = "gbxActua";
            gbxActua.Size = new Size(515, 132);
            gbxActua.TabIndex = 1;
            gbxActua.TabStop = false;
            // 
            // txbActual
            // 
            txbActual.Location = new Point(322, 61);
            txbActual.Name = "txbActual";
            txbActual.Size = new Size(100, 23);
            txbActual.TabIndex = 3;
            // 
            // txbUltimo
            // 
            txbUltimo.Location = new Point(72, 61);
            txbUltimo.Name = "txbUltimo";
            txbUltimo.ReadOnly = true;
            txbUltimo.Size = new Size(100, 23);
            txbUltimo.TabIndex = 2;
            // 
            // lblActual
            // 
            lblActual.AutoSize = true;
            lblActual.Font = new Font("Segoe UI", 12F);
            lblActual.Location = new Point(319, 27);
            lblActual.Name = "lblActual";
            lblActual.Size = new Size(107, 21);
            lblActual.TabIndex = 1;
            lblActual.Text = "Tiempo actual";
            // 
            // lblUltimo
            // 
            lblUltimo.AutoSize = true;
            lblUltimo.Font = new Font("Segoe UI", 12F);
            lblUltimo.Location = new Point(28, 27);
            lblUltimo.Name = "lblUltimo";
            lblUltimo.Size = new Size(185, 21);
            lblUltimo.TabIndex = 0;
            lblUltimo.Text = "Último tiempo registrado";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(137, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(291, 25);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Seleccione la ruta para actualizar";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(44, 374);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 40);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(222, 374);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 40);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.Location = new Point(406, 374);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 40);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmActualizarTrafico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(gbxActua);
            Controls.Add(gbxRuta);
            Name = "frmActualizarTrafico";
            Text = "Actualizar Tráfico";
            gbxRuta.ResumeLayout(false);
            gbxRuta.PerformLayout();
            gbxActua.ResumeLayout(false);
            gbxActua.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxRuta;
        private GroupBox gbxActua;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label lblDestino;
        private Label lblOrigen;
        private TextBox txbActual;
        private TextBox txbUltimo;
        private Label lblActual;
        private Label lblUltimo;
        private Label lblTitulo;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}