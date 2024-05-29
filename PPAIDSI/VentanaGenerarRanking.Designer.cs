namespace PPAIDSI
{
    partial class VentanaGenerarRanking
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
            lblFechaDesde = new Label();
            lblHasta = new Label();
            grbFechas = new GroupBox();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            btnSeleccionarFechas = new Button();
            grbTipoRes = new GroupBox();
            rbtnAmigos = new RadioButton();
            rbtnNormales = new RadioButton();
            rbtnSommelier = new RadioButton();
            btnSeleccionarTipo = new Button();
            grbVisualizacion = new GroupBox();
            rbtnExcel = new RadioButton();
            rbtnPDF = new RadioButton();
            rbtnPantalla = new RadioButton();
            button1 = new Button();
            btnSalir = new Button();
            grbFechas.SuspendLayout();
            grbTipoRes.SuspendLayout();
            grbVisualizacion.SuspendLayout();
            SuspendLayout();
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Location = new Point(16, 28);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(42, 15);
            lblFechaDesde.TabIndex = 0;
            lblFechaDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(18, 97);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 1;
            lblHasta.Text = "Hasta:";
            // 
            // grbFechas
            // 
            grbFechas.Controls.Add(dtpDesde);
            grbFechas.Controls.Add(dtpHasta);
            grbFechas.Controls.Add(btnSeleccionarFechas);
            grbFechas.Controls.Add(lblFechaDesde);
            grbFechas.Controls.Add(lblHasta);
            grbFechas.Enabled = false;
            grbFechas.Location = new Point(14, 12);
            grbFechas.Name = "grbFechas";
            grbFechas.Size = new Size(365, 175);
            grbFechas.TabIndex = 4;
            grbFechas.TabStop = false;
            grbFechas.Text = "Considerar reseñas";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(16, 57);
            dtpDesde.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDesde.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(218, 23);
            dtpDesde.TabIndex = 2;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(16, 128);
            dtpHasta.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpHasta.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(218, 23);
            dtpHasta.TabIndex = 3;
            // 
            // btnSeleccionarFechas
            // 
            btnSeleccionarFechas.Location = new Point(273, 138);
            btnSeleccionarFechas.Name = "btnSeleccionarFechas";
            btnSeleccionarFechas.Size = new Size(86, 31);
            btnSeleccionarFechas.TabIndex = 7;
            btnSeleccionarFechas.Text = "Seleccionar";
            btnSeleccionarFechas.UseVisualStyleBackColor = true;
            btnSeleccionarFechas.Click += SeleccionarFechaDesdeHasta;
            // 
            // grbTipoRes
            // 
            grbTipoRes.Controls.Add(rbtnAmigos);
            grbTipoRes.Controls.Add(rbtnNormales);
            grbTipoRes.Controls.Add(rbtnSommelier);
            grbTipoRes.Controls.Add(btnSeleccionarTipo);
            grbTipoRes.Enabled = false;
            grbTipoRes.Location = new Point(14, 193);
            grbTipoRes.Name = "grbTipoRes";
            grbTipoRes.Size = new Size(365, 98);
            grbTipoRes.TabIndex = 8;
            grbTipoRes.TabStop = false;
            grbTipoRes.Text = "Tipo de Reseña";
            // 
            // rbtnAmigos
            // 
            rbtnAmigos.AutoSize = true;
            rbtnAmigos.Location = new Point(228, 22);
            rbtnAmigos.Name = "rbtnAmigos";
            rbtnAmigos.Size = new Size(82, 19);
            rbtnAmigos.TabIndex = 11;
            rbtnAmigos.TabStop = true;
            rbtnAmigos.Text = "de Amigos";
            rbtnAmigos.UseVisualStyleBackColor = true;
            // 
            // rbtnNormales
            // 
            rbtnNormales.AutoSize = true;
            rbtnNormales.Location = new Point(6, 22);
            rbtnNormales.Name = "rbtnNormales";
            rbtnNormales.Size = new Size(76, 19);
            rbtnNormales.TabIndex = 10;
            rbtnNormales.TabStop = true;
            rbtnNormales.Text = "Normales";
            rbtnNormales.UseVisualStyleBackColor = true;
            // 
            // rbtnSommelier
            // 
            rbtnSommelier.AutoSize = true;
            rbtnSommelier.Location = new Point(106, 22);
            rbtnSommelier.Name = "rbtnSommelier";
            rbtnSommelier.Size = new Size(98, 19);
            rbtnSommelier.TabIndex = 9;
            rbtnSommelier.TabStop = true;
            rbtnSommelier.Text = "de Sommelier";
            rbtnSommelier.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarTipo
            // 
            btnSeleccionarTipo.Location = new Point(273, 61);
            btnSeleccionarTipo.Name = "btnSeleccionarTipo";
            btnSeleccionarTipo.Size = new Size(86, 31);
            btnSeleccionarTipo.TabIndex = 9;
            btnSeleccionarTipo.Text = "Seleccionar";
            btnSeleccionarTipo.UseVisualStyleBackColor = true;
            btnSeleccionarTipo.Click += SeleccionarTipoResena;
            // 
            // grbVisualizacion
            // 
            grbVisualizacion.Controls.Add(rbtnExcel);
            grbVisualizacion.Controls.Add(rbtnPDF);
            grbVisualizacion.Controls.Add(rbtnPantalla);
            grbVisualizacion.Controls.Add(button1);
            grbVisualizacion.Enabled = false;
            grbVisualizacion.Location = new Point(14, 297);
            grbVisualizacion.Name = "grbVisualizacion";
            grbVisualizacion.Size = new Size(365, 100);
            grbVisualizacion.TabIndex = 9;
            grbVisualizacion.TabStop = false;
            grbVisualizacion.Text = "Forma de Visualizacion";
            // 
            // rbtnExcel
            // 
            rbtnExcel.AutoSize = true;
            rbtnExcel.Location = new Point(228, 22);
            rbtnExcel.Name = "rbtnExcel";
            rbtnExcel.Size = new Size(52, 19);
            rbtnExcel.TabIndex = 15;
            rbtnExcel.TabStop = true;
            rbtnExcel.Text = "Excel";
            rbtnExcel.UseVisualStyleBackColor = true;
            // 
            // rbtnPDF
            // 
            rbtnPDF.AutoSize = true;
            rbtnPDF.Location = new Point(106, 22);
            rbtnPDF.Name = "rbtnPDF";
            rbtnPDF.Size = new Size(46, 19);
            rbtnPDF.TabIndex = 12;
            rbtnPDF.TabStop = true;
            rbtnPDF.Text = "PDF";
            rbtnPDF.UseVisualStyleBackColor = true;
            // 
            // rbtnPantalla
            // 
            rbtnPantalla.AutoSize = true;
            rbtnPantalla.Location = new Point(6, 22);
            rbtnPantalla.Name = "rbtnPantalla";
            rbtnPantalla.Size = new Size(67, 19);
            rbtnPantalla.TabIndex = 14;
            rbtnPantalla.TabStop = true;
            rbtnPantalla.Text = "Pantalla";
            rbtnPantalla.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(273, 61);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 13;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += seleccionarFormaVisualizacion;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(294, 445);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // VentanaGenerarRanking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 488);
            Controls.Add(btnSalir);
            Controls.Add(grbVisualizacion);
            Controls.Add(grbTipoRes);
            Controls.Add(grbFechas);
            Name = "VentanaGenerarRanking";
            Text = "Generar Ranking";
            Load += VentanaGenerarRanking_Load;
            grbFechas.ResumeLayout(false);
            grbFechas.PerformLayout();
            grbTipoRes.ResumeLayout(false);
            grbTipoRes.PerformLayout();
            grbVisualizacion.ResumeLayout(false);
            grbVisualizacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFechaDesde;
        private Label lblHasta;
        private GroupBox grbFechas;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnSeleccionarFechas;
        private GroupBox grbTipoRes;
        private Button btnSeleccionarTipo;
        private CheckBox chkSommelier;
        private CheckBox chkAmigos;
        private CheckBox chkNormales;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton rbtnSommelier;
        private RadioButton rbtnAmigos;
        private RadioButton rbtnNormales;
        private GroupBox grbVisualizacion;
        private RadioButton rbtnExcel;
        private RadioButton rbtnPDF;
        private RadioButton rbtnPantalla;
        private Button button1;
        private Button btnSalir;
    }
}