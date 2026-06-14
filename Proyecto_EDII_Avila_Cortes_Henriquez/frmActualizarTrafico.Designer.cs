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
            cbxDestino = new ComboBox();
            cbxOrigen = new ComboBox();
            lblDestino = new Label();
            lblOrigen = new Label();
            gbxActua = new GroupBox();
            tbxActual = new TextBox();
            tbxUltimo = new TextBox();
            lblActual = new Label();
            lblUltimo = new Label();
            lblTitulo = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            gbxRuta.SuspendLayout();
            gbxActua.SuspendLayout();
            SuspendLayout();
            // 
            // gbxRuta
            // 
            gbxRuta.Controls.Add(cbxDestino);
            gbxRuta.Controls.Add(cbxOrigen);
            gbxRuta.Controls.Add(lblDestino);
            gbxRuta.Controls.Add(lblOrigen);
            gbxRuta.Location = new Point(30, 64);
            gbxRuta.Name = "gbxRuta";
            gbxRuta.Size = new Size(515, 132);
            gbxRuta.TabIndex = 0;
            gbxRuta.TabStop = false;
            // 
            // cbxDestino
            // 
            cbxDestino.FormattingEnabled = true;
            cbxDestino.Location = new Point(322, 66);
            cbxDestino.Name = "cbxDestino";
            cbxDestino.Size = new Size(121, 23);
            cbxDestino.TabIndex = 3;
            cbxDestino.SelectedIndexChanged += cbxDestino_SelectedIndexChanged;
            // 
            // cbxOrigen
            // 
            cbxOrigen.FormattingEnabled = true;
            cbxOrigen.Location = new Point(28, 68);
            cbxOrigen.Name = "cbxOrigen";
            cbxOrigen.Size = new Size(121, 23);
            cbxOrigen.TabIndex = 2;
            cbxOrigen.SelectedIndexChanged += cbxOrigen_SelectedIndexChanged;
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
            gbxActua.Controls.Add(tbxActual);
            gbxActua.Controls.Add(tbxUltimo);
            gbxActua.Controls.Add(lblActual);
            gbxActua.Controls.Add(lblUltimo);
            gbxActua.Location = new Point(30, 211);
            gbxActua.Name = "gbxActua";
            gbxActua.Size = new Size(515, 132);
            gbxActua.TabIndex = 1;
            gbxActua.TabStop = false;
            // 
            // tbxActual
            // 
            tbxActual.Location = new Point(322, 61);
            tbxActual.Name = "tbxActual";
            tbxActual.Size = new Size(100, 23);
            tbxActual.TabIndex = 3;
            // 
            // tbxUltimo
            // 
            tbxUltimo.Location = new Point(72, 61);
            tbxUltimo.Name = "tbxUltimo";
            tbxUltimo.ReadOnly = true;
            tbxUltimo.Size = new Size(100, 23);
            tbxUltimo.TabIndex = 2;
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
            btnGuardar.Click += btnGuardar_Click;
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
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F);
            btnCerrar.Location = new Point(406, 374);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 40);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmActualizarTrafico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 450);
            Controls.Add(btnCerrar);
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
        private ComboBox cbxDestino;
        private ComboBox cbxOrigen;
        private Label lblDestino;
        private Label lblOrigen;
        private TextBox tbxActual;
        private TextBox tbxUltimo;
        private Label lblActual;
        private Label lblUltimo;
        private Label lblTitulo;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}