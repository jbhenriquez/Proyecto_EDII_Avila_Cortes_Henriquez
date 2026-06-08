namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    partial class frmAgregarCalle
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
            lblTitulo = new Label();
            gbxDatos = new GroupBox();
            lblMinutos = new Label();
            tbxTiempo = new TextBox();
            tbxDestino = new TextBox();
            tbxOrigen = new TextBox();
            lblTiempo = new Label();
            lblDestino = new Label();
            lblOrigen = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            gbxDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(96, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(248, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingrese los datos necesarios";
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(lblMinutos);
            gbxDatos.Controls.Add(tbxTiempo);
            gbxDatos.Controls.Add(tbxDestino);
            gbxDatos.Controls.Add(tbxOrigen);
            gbxDatos.Controls.Add(lblTiempo);
            gbxDatos.Controls.Add(lblDestino);
            gbxDatos.Controls.Add(lblOrigen);
            gbxDatos.Location = new Point(22, 37);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(401, 186);
            gbxDatos.TabIndex = 1;
            gbxDatos.TabStop = false;
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinutos.Location = new Point(230, 141);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(67, 21);
            lblMinutos.TabIndex = 6;
            lblMinutos.Text = "Minutos";
            // 
            // tbxTiempo
            // 
            tbxTiempo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxTiempo.Location = new Point(153, 138);
            tbxTiempo.Name = "tbxTiempo";
            tbxTiempo.Size = new Size(71, 29);
            tbxTiempo.TabIndex = 5;
            // 
            // tbxDestino
            // 
            tbxDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxDestino.Location = new Point(153, 89);
            tbxDestino.Name = "tbxDestino";
            tbxDestino.Size = new Size(165, 29);
            tbxDestino.TabIndex = 4;
            // 
            // tbxOrigen
            // 
            tbxOrigen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxOrigen.Location = new Point(153, 37);
            tbxOrigen.Name = "tbxOrigen";
            tbxOrigen.Size = new Size(165, 29);
            tbxOrigen.TabIndex = 3;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempo.Location = new Point(16, 141);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(134, 21);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo de tráfico:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(84, 91);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(66, 21);
            lblDestino.TabIndex = 1;
            lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigen.Location = new Point(89, 39);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(61, 21);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "Origen:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(51, 229);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 40);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(175, 229);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 40);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(302, 229);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 40);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnSalir_Click;
            // 
            // frmAgregarCalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 298);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(gbxDatos);
            Controls.Add(lblTitulo);
            Name = "frmAgregarCalle";
            Text = "Agregar Calle";
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gbxDatos;
        private Label lblTiempo;
        private Label lblDestino;
        private Label lblOrigen;
        private Label lblMinutos;
        private TextBox tbxTiempo;
        private TextBox tbxDestino;
        private TextBox tbxOrigen;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}