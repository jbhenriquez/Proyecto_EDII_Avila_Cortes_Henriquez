namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    partial class frmRegistrarIncidente
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
            tbxDescripcion = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            rbtAlto = new RadioButton();
            rbtMedio = new RadioButton();
            rbtBajo = new RadioButton();
            label2 = new Label();
            btnLimpiar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbxDescripcion
            // 
            tbxDescripcion.Location = new Point(31, 43);
            tbxDescripcion.Multiline = true;
            tbxDescripcion.Name = "tbxDescripcion";
            tbxDescripcion.Size = new Size(426, 62);
            tbxDescripcion.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(183, 21);
            label1.TabIndex = 1;
            label1.Text = "Descripción del incidente";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(43, 241);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F);
            btnCerrar.Location = new Point(397, 241);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 30);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtAlto);
            groupBox1.Controls.Add(rbtMedio);
            groupBox1.Controls.Add(rbtBajo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbxDescripcion);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 177);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // rbtAlto
            // 
            rbtAlto.AutoSize = true;
            rbtAlto.Font = new Font("Segoe UI", 12F);
            rbtAlto.Location = new Point(401, 139);
            rbtAlto.Name = "rbtAlto";
            rbtAlto.Size = new Size(56, 25);
            rbtAlto.TabIndex = 5;
            rbtAlto.TabStop = true;
            rbtAlto.Text = "Alto";
            rbtAlto.UseVisualStyleBackColor = true;
            // 
            // rbtMedio
            // 
            rbtMedio.AutoSize = true;
            rbtMedio.Font = new Font("Segoe UI", 12F);
            rbtMedio.Location = new Point(297, 139);
            rbtMedio.Name = "rbtMedio";
            rbtMedio.Size = new Size(72, 25);
            rbtMedio.TabIndex = 4;
            rbtMedio.TabStop = true;
            rbtMedio.Text = "Medio";
            rbtMedio.UseVisualStyleBackColor = true;
            // 
            // rbtBajo
            // 
            rbtBajo.AutoSize = true;
            rbtBajo.Font = new Font("Segoe UI", 12F);
            rbtBajo.Location = new Point(212, 139);
            rbtBajo.Name = "rbtBajo";
            rbtBajo.Size = new Size(58, 25);
            rbtBajo.TabIndex = 3;
            rbtBajo.TabStop = true;
            rbtBajo.Text = "Bajo";
            rbtBajo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(57, 137);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 2;
            label2.Text = "Nivel de prioridad";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(214, 241);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmRegistrarIncidente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 301);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Name = "frmRegistrarIncidente";
            Text = "Registrar Incidente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbxDescripcion;
        private Label label1;
        private Button btnGuardar;
        private Button btnCerrar;
        private GroupBox groupBox1;
        private Label label2;
        private RadioButton rbtAlto;
        private RadioButton rbtMedio;
        private RadioButton rbtBajo;
        private Button btnLimpiar;
    }
}