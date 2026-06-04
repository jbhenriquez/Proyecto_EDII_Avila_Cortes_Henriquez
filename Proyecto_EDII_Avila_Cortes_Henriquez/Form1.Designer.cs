namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAgregarCalle = new Button();
            btnMostrarMapa = new Button();
            btnRutaRapida = new Button();
            btnActualizarTrafico = new Button();
            btnTraficoMax = new Button();
            btnRegistrarIncidente = new Button();
            btnAtenderIncidente = new Button();
            btnSalir = new Button();
            gbxOpciones = new GroupBox();
            gbxOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 9);
            label1.Name = "label1";
            label1.Size = new Size(507, 25);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE MONITOREO DE TRÁFICO EN TIEMPO REAL";
            // 
            // btnAgregarCalle
            // 
            btnAgregarCalle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarCalle.Location = new Point(25, 22);
            btnAgregarCalle.Name = "btnAgregarCalle";
            btnAgregarCalle.Size = new Size(188, 63);
            btnAgregarCalle.TabIndex = 1;
            btnAgregarCalle.Text = "Agregar Calle";
            btnAgregarCalle.UseVisualStyleBackColor = true;
            btnAgregarCalle.Click += btnAgregarCalle_Click;
            // 
            // btnMostrarMapa
            // 
            btnMostrarMapa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarMapa.Location = new Point(278, 22);
            btnMostrarMapa.Name = "btnMostrarMapa";
            btnMostrarMapa.Size = new Size(183, 63);
            btnMostrarMapa.TabIndex = 2;
            btnMostrarMapa.Text = "Mostrar Mapa";
            btnMostrarMapa.UseVisualStyleBackColor = true;
            // 
            // btnRutaRapida
            // 
            btnRutaRapida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRutaRapida.Location = new Point(25, 104);
            btnRutaRapida.Name = "btnRutaRapida";
            btnRutaRapida.Size = new Size(188, 59);
            btnRutaRapida.TabIndex = 3;
            btnRutaRapida.Text = "Ruta Más Rápida";
            btnRutaRapida.UseVisualStyleBackColor = true;
            // 
            // btnActualizarTrafico
            // 
            btnActualizarTrafico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizarTrafico.Location = new Point(278, 104);
            btnActualizarTrafico.Name = "btnActualizarTrafico";
            btnActualizarTrafico.Size = new Size(183, 59);
            btnActualizarTrafico.TabIndex = 4;
            btnActualizarTrafico.Text = "Actualizar Tráfico";
            btnActualizarTrafico.UseVisualStyleBackColor = true;
            // 
            // btnTraficoMax
            // 
            btnTraficoMax.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTraficoMax.Location = new Point(25, 181);
            btnTraficoMax.Name = "btnTraficoMax";
            btnTraficoMax.Size = new Size(188, 58);
            btnTraficoMax.TabIndex = 5;
            btnTraficoMax.Text = "Consultar Tráfico Máximo";
            btnTraficoMax.UseVisualStyleBackColor = true;
            btnTraficoMax.Click += button1_Click;
            // 
            // btnRegistrarIncidente
            // 
            btnRegistrarIncidente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarIncidente.Location = new Point(278, 181);
            btnRegistrarIncidente.Name = "btnRegistrarIncidente";
            btnRegistrarIncidente.Size = new Size(183, 58);
            btnRegistrarIncidente.TabIndex = 6;
            btnRegistrarIncidente.Text = "Registrar Incidente";
            btnRegistrarIncidente.UseVisualStyleBackColor = true;
            // 
            // btnAtenderIncidente
            // 
            btnAtenderIncidente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtenderIncidente.Location = new Point(25, 263);
            btnAtenderIncidente.Name = "btnAtenderIncidente";
            btnAtenderIncidente.Size = new Size(188, 58);
            btnAtenderIncidente.TabIndex = 7;
            btnAtenderIncidente.Text = "Atender Incidente Prioritario";
            btnAtenderIncidente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(364, 380);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(183, 58);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // gbxOpciones
            // 
            gbxOpciones.Controls.Add(btnAgregarCalle);
            gbxOpciones.Controls.Add(btnMostrarMapa);
            gbxOpciones.Controls.Add(btnAtenderIncidente);
            gbxOpciones.Controls.Add(btnRutaRapida);
            gbxOpciones.Controls.Add(btnTraficoMax);
            gbxOpciones.Controls.Add(btnRegistrarIncidente);
            gbxOpciones.Controls.Add(btnActualizarTrafico);
            gbxOpciones.Location = new Point(86, 43);
            gbxOpciones.Name = "gbxOpciones";
            gbxOpciones.Size = new Size(481, 331);
            gbxOpciones.TabIndex = 9;
            gbxOpciones.TabStop = false;
            gbxOpciones.Text = "Opciones";
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 450);
            Controls.Add(gbxOpciones);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Name = "frmMenuPrincipal";
            Text = "Sistema de monitoreo de trafico";
            gbxOpciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregarCalle;
        private Button btnMostrarMapa;
        private Button btnRutaRapida;
        private Button btnActualizarTrafico;
        private Button btnTraficoMax;
        private Button btnRegistrarIncidente;
        private Button btnAtenderIncidente;
        private Button btnSalir;
        private GroupBox gbxOpciones;
    }
}
