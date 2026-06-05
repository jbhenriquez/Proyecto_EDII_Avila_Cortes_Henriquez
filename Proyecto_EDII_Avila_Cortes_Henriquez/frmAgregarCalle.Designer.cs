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
            groupBox1 = new GroupBox();
            lblMinutos = new Label();
            txttiempo = new TextBox();
            txtDestino = new TextBox();
            txtOrigen = new TextBox();
            lblTiempo = new Label();
            lblDestino = new Label();
            lblOrigen = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMinutos);
            groupBox1.Controls.Add(txttiempo);
            groupBox1.Controls.Add(txtDestino);
            groupBox1.Controls.Add(txtOrigen);
            groupBox1.Controls.Add(lblTiempo);
            groupBox1.Controls.Add(lblDestino);
            groupBox1.Controls.Add(lblOrigen);
            groupBox1.Location = new Point(22, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 186);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
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
            // txttiempo
            // 
            txttiempo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttiempo.Location = new Point(153, 138);
            txttiempo.Name = "txttiempo";
            txttiempo.Size = new Size(71, 29);
            txttiempo.TabIndex = 5;
            // 
            // txtDestino
            // 
            txtDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDestino.Location = new Point(153, 89);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(165, 29);
            txtDestino.TabIndex = 4;
            // 
            // txtOrigen
            // 
            txtOrigen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrigen.Location = new Point(153, 37);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(165, 29);
            txtOrigen.TabIndex = 3;
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
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(302, 229);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 40);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmAgregarCalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 298);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Name = "frmAgregarCalle";
            Text = "Agregar Calle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox groupBox1;
        private Label lblTiempo;
        private Label lblDestino;
        private Label lblOrigen;
        private Label lblMinutos;
        private TextBox txttiempo;
        private TextBox txtDestino;
        private TextBox txtOrigen;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}