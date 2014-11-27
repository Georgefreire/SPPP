namespace SPPP
{
    partial class IngresoPractica
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPracticas = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtResolucion = new System.Windows.Forms.TextBox();
            this.dtpAprobacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHorasTotales = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpFechaFinPr = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpFechaInicioPr = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarEs = new System.Windows.Forms.Button();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnCancelarP = new System.Windows.Forms.Button();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDetalleDoc = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.btnCancelarD = new System.Windows.Forms.Button();
            this.btnGuardarD = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticas)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(25, 150);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 542);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.btnCancelarP);
            this.tabPage3.Controls.Add(this.btnGuardarP);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(871, 534);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proceso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.dgvPracticas);
            this.groupBox1.Location = new System.Drawing.Point(38, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 281);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Practicas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 31;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 36);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // dgvPracticas
            // 
            this.dgvPracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracticas.Location = new System.Drawing.Point(21, 61);
            this.dgvPracticas.Name = "dgvPracticas";
            this.dgvPracticas.Size = new System.Drawing.Size(759, 149);
            this.dgvPracticas.TabIndex = 29;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtResolucion);
            this.groupBox7.Controls.Add(this.dtpAprobacion);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.txtHorasTotales);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.dtpFechaFinPr);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.dtpFechaInicioPr);
            this.groupBox7.Controls.Add(this.btnBuscarEs);
            this.groupBox7.Controls.Add(this.txtEstudiante);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Location = new System.Drawing.Point(38, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(805, 168);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pasantia";
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(174, 58);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Size = new System.Drawing.Size(72, 20);
            this.txtResolucion.TabIndex = 42;
            // 
            // dtpAprobacion
            // 
            this.dtpAprobacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAprobacion.Location = new System.Drawing.Point(174, 102);
            this.dtpAprobacion.Name = "dtpAprobacion";
            this.dtpAprobacion.Size = new System.Drawing.Size(153, 20);
            this.dtpAprobacion.TabIndex = 41;
            this.dtpAprobacion.ValueChanged += new System.EventHandler(this.dtpAprobacion_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Fecha de Aprobacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "N Resolucion ";
            // 
            // txtHorasTotales
            // 
            this.txtHorasTotales.Location = new System.Drawing.Point(564, 101);
            this.txtHorasTotales.Name = "txtHorasTotales";
            this.txtHorasTotales.Size = new System.Drawing.Size(72, 20);
            this.txtHorasTotales.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(440, 108);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Horas Totales";
            // 
            // dtpFechaFinPr
            // 
            this.dtpFechaFinPr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinPr.Location = new System.Drawing.Point(564, 65);
            this.dtpFechaFinPr.Name = "dtpFechaFinPr";
            this.dtpFechaFinPr.Size = new System.Drawing.Size(153, 20);
            this.dtpFechaFinPr.TabIndex = 36;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(440, 26);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 13);
            this.label24.TabIndex = 33;
            this.label24.Text = "Fecha Inicio";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(440, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "Fecha Fin";
            // 
            // dtpFechaInicioPr
            // 
            this.dtpFechaInicioPr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioPr.Location = new System.Drawing.Point(564, 19);
            this.dtpFechaInicioPr.Name = "dtpFechaInicioPr";
            this.dtpFechaInicioPr.Size = new System.Drawing.Size(153, 20);
            this.dtpFechaInicioPr.TabIndex = 35;
            // 
            // btnBuscarEs
            // 
            this.btnBuscarEs.Image = global::SPPP.Properties.Resources.Zoom_icon;
            this.btnBuscarEs.Location = new System.Drawing.Point(333, 11);
            this.btnBuscarEs.Name = "btnBuscarEs";
            this.btnBuscarEs.Size = new System.Drawing.Size(30, 22);
            this.btnBuscarEs.TabIndex = 32;
            this.btnBuscarEs.UseVisualStyleBackColor = true;
            this.btnBuscarEs.Click += new System.EventHandler(this.btnBuscarEs_Click);
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(174, 13);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(153, 20);
            this.txtEstudiante.TabIndex = 30;
            this.txtEstudiante.TextChanged += new System.EventHandler(this.txtEstudiante_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(62, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "Estudiate";
            // 
            // btnCancelarP
            // 
            this.btnCancelarP.Image = global::SPPP.Properties.Resources.Actions_button_cancel_icon;
            this.btnCancelarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarP.Location = new System.Drawing.Point(701, 482);
            this.btnCancelarP.Name = "btnCancelarP";
            this.btnCancelarP.Size = new System.Drawing.Size(79, 31);
            this.btnCancelarP.TabIndex = 19;
            this.btnCancelarP.Text = "Cancelar";
            this.btnCancelarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarP.UseVisualStyleBackColor = true;
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Image = global::SPPP.Properties.Resources.Actions_dialog_ok_icon;
            this.btnGuardarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarP.Location = new System.Drawing.Point(616, 482);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(79, 31);
            this.btnGuardarP.TabIndex = 18;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage6.Controls.Add(this.dateTimePicker1);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.dgvDetalleDoc);
            this.tabPage6.Controls.Add(this.Tipo);
            this.tabPage6.Controls.Add(this.cmbTipoDoc);
            this.tabPage6.Controls.Add(this.btnCancelarD);
            this.tabPage6.Controls.Add(this.btnGuardarD);
            this.tabPage6.Location = new System.Drawing.Point(154, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(871, 534);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Documento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha";
            // 
            // dgvDetalleDoc
            // 
            this.dgvDetalleDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleDoc.Location = new System.Drawing.Point(40, 127);
            this.dgvDetalleDoc.Name = "dgvDetalleDoc";
            this.dgvDetalleDoc.Size = new System.Drawing.Size(391, 227);
            this.dgvDetalleDoc.TabIndex = 2;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(37, 62);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(28, 13);
            this.Tipo.TabIndex = 1;
            this.Tipo.Text = "Tipo";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(94, 54);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDoc.TabIndex = 0;
            // 
            // btnCancelarD
            // 
            this.btnCancelarD.Image = global::SPPP.Properties.Resources.Actions_button_cancel_icon;
            this.btnCancelarD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarD.Location = new System.Drawing.Point(354, 360);
            this.btnCancelarD.Name = "btnCancelarD";
            this.btnCancelarD.Size = new System.Drawing.Size(79, 31);
            this.btnCancelarD.TabIndex = 19;
            this.btnCancelarD.Text = "Cancelar";
            this.btnCancelarD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarD.UseVisualStyleBackColor = true;
            // 
            // btnGuardarD
            // 
            this.btnGuardarD.Image = global::SPPP.Properties.Resources.Actions_dialog_ok_icon;
            this.btnGuardarD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarD.Location = new System.Drawing.Point(269, 360);
            this.btnGuardarD.Name = "btnGuardarD";
            this.btnGuardarD.Size = new System.Drawing.Size(79, 31);
            this.btnGuardarD.TabIndex = 18;
            this.btnGuardarD.Text = "Guardar";
            this.btnGuardarD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarD.UseVisualStyleBackColor = true;
            // 
            // IngresoPractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 542);
            this.Controls.Add(this.tabControl1);
            this.Name = "IngresoPractica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Practica";
            this.Load += new System.EventHandler(this.IngresoPractica_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticas)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgvDetalleDoc;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Button btnCancelarP;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.Button btnCancelarD;
        private System.Windows.Forms.Button btnGuardarD;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnBuscarEs;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtHorasTotales;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpFechaFinPr;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioPr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPracticas;
        private System.Windows.Forms.TextBox txtResolucion;
        private System.Windows.Forms.DateTimePicker dtpAprobacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}