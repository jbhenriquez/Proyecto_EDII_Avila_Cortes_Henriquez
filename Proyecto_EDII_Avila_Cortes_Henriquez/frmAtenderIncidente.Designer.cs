namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    partial class frmAtenderIncidente
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
            gbxIncidente = new GroupBox();
            tbxIncidente = new TextBox();
            btnAtender = new Button();
            btnCancelar = new Button();
            gbxIncidente.SuspendLayout();
            SuspendLayout();
            // 
            // gbxIncidente
            // 
            gbxIncidente.Controls.Add(tbxIncidente);
            gbxIncidente.Location = new Point(47, 30);
            gbxIncidente.Name = "gbxIncidente";
            gbxIncidente.Size = new Size(438, 132);
            gbxIncidente.TabIndex = 0;
            gbxIncidente.TabStop = false;
            gbxIncidente.Text = "Incidente";
            // 
            // tbxIncidente
            // 
            tbxIncidente.Location = new Point(39, 22);
            tbxIncidente.Multiline = true;
            tbxIncidente.Name = "tbxIncidente";
            tbxIncidente.ReadOnly = true;
            tbxIncidente.Size = new Size(357, 96);
            tbxIncidente.TabIndex = 0;
            // 
            // btnAtender
            // 
            btnAtender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtender.Location = new Point(86, 181);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(100, 40);
            btnAtender.TabIndex = 1;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(318, 181);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // frmAtenderIncidente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 239);
            Controls.Add(btnCancelar);
            Controls.Add(btnAtender);
            Controls.Add(gbxIncidente);
            Name = "frmAtenderIncidente";
            Text = "Atender Incidente Prioritario";
            gbxIncidente.ResumeLayout(false);
            gbxIncidente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxIncidente;
        private TextBox tbxIncidente;
        private Button btnAtender;
        private Button btnCancelar;
    }
}