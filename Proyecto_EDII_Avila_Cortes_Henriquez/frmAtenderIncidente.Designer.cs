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
            gbxIncidente.Location = new Point(67, 50);
            gbxIncidente.Margin = new Padding(4, 5, 4, 5);
            gbxIncidente.Name = "gbxIncidente";
            gbxIncidente.Padding = new Padding(4, 5, 4, 5);
            gbxIncidente.Size = new Size(626, 220);
            gbxIncidente.TabIndex = 0;
            gbxIncidente.TabStop = false;
            gbxIncidente.Text = "Incidente";
            // 
            // tbxIncidente
            // 
            tbxIncidente.Location = new Point(56, 37);
            tbxIncidente.Margin = new Padding(4, 5, 4, 5);
            tbxIncidente.Multiline = true;
            tbxIncidente.Name = "tbxIncidente";
            tbxIncidente.ReadOnly = true;
            tbxIncidente.Size = new Size(508, 157);
            tbxIncidente.TabIndex = 0;
            tbxIncidente.TextChanged += tbxIncidente_TextChanged;
            // 
            // btnAtender
            // 
            btnAtender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtender.Location = new Point(123, 302);
            btnAtender.Margin = new Padding(4, 5, 4, 5);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(143, 67);
            btnAtender.TabIndex = 1;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(454, 302);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 67);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // frmAtenderIncidente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 398);
            Controls.Add(btnCancelar);
            Controls.Add(btnAtender);
            Controls.Add(gbxIncidente);
            Margin = new Padding(4, 5, 4, 5);
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