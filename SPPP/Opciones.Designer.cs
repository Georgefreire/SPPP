namespace SPPP
{
    partial class Opciones
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscarRes = new System.Windows.Forms.Button();
            this.btnCancelarCuen = new System.Windows.Forms.Button();
            this.btnGuardarCuen = new System.Windows.Forms.Button();
            this.txtConfContraseña = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelarPer = new System.Windows.Forms.Button();
            this.btnGuardarPer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerHoras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEditarCarr = new System.Windows.Forms.Button();
            this.btnCancelarCarr = new System.Windows.Forms.Button();
            this.btnGuardarCarr = new System.Windows.Forms.Button();
            this.dgvCarreras = new System.Windows.Forms.DataGridView();
            this.cmbElgFacultad = new System.Windows.Forms.ComboBox();
            this.Facultad = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEditarPerf = new System.Windows.Forms.Button();
            this.btnCancelarPerf = new System.Windows.Forms.Button();
            this.btnGuardarPerf = new System.Windows.Forms.Button();
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFacultad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPerInicio = new System.Windows.Forms.DateTimePicker();
            this.txtPerFin = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(25, 150);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 270);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.btnBuscarRes);
            this.tabPage2.Controls.Add(this.btnCancelarCuen);
            this.tabPage2.Controls.Add(this.btnGuardarCuen);
            this.tabPage2.Controls.Add(this.txtConfContraseña);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtContraseña);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtUsuario);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtPropietario);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cuenta";
            // 
            // btnBuscarRes
            // 
            this.btnBuscarRes.Image = global::SPPP.Properties.Resources.Zoom_icon;
            this.btnBuscarRes.Location = new System.Drawing.Point(312, 32);
            this.btnBuscarRes.Name = "btnBuscarRes";
            this.btnBuscarRes.Size = new System.Drawing.Size(38, 23);
            this.btnBuscarRes.TabIndex = 11;
            this.btnBuscarRes.UseVisualStyleBackColor = true;
            this.btnBuscarRes.Click += new System.EventHandler(this.btnBuscarRes_Click);
            // 
            // btnCancelarCuen
            // 
            this.btnCancelarCuen.Image = global::SPPP.Properties.Resources.Actions_button_cancel_icon;
            this.btnCancelarCuen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCuen.Location = new System.Drawing.Point(271, 205);
            this.btnCancelarCuen.Name = "btnCancelarCuen";
            this.btnCancelarCuen.Size = new System.Drawing.Size(79, 31);
            this.btnCancelarCuen.TabIndex = 10;
            this.btnCancelarCuen.Text = "Cancelar";
            this.btnCancelarCuen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCuen.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCuen
            // 
            this.btnGuardarCuen.Image = global::SPPP.Properties.Resources.Actions_dialog_ok_icon;
            this.btnGuardarCuen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCuen.Location = new System.Drawing.Point(186, 205);
            this.btnGuardarCuen.Name = "btnGuardarCuen";
            this.btnGuardarCuen.Size = new System.Drawing.Size(79, 31);
            this.btnGuardarCuen.TabIndex = 9;
            this.btnGuardarCuen.Text = "Guardar";
            this.btnGuardarCuen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCuen.UseVisualStyleBackColor = true;
            // 
            // txtConfContraseña
            // 
            this.txtConfContraseña.Location = new System.Drawing.Point(186, 149);
            this.txtConfContraseña.Name = "txtConfContraseña";
            this.txtConfContraseña.Size = new System.Drawing.Size(120, 20);
            this.txtConfContraseña.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Confirmar Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(186, 109);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(120, 20);
            this.txtContraseña.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(186, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(120, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Usuario";
            // 
            // txtPropietario
            // 
            this.txtPropietario.Location = new System.Drawing.Point(186, 34);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(120, 20);
            this.txtPropietario.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Propietario";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.txtPerFin);
            this.tabPage1.Controls.Add(this.txtPerInicio);
            this.tabPage1.Controls.Add(this.btnCancelarPer);
            this.tabPage1.Controls.Add(this.btnGuardarPer);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPerHoras);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Periodo";
            // 
            // btnCancelarPer
            // 
            this.btnCancelarPer.Image = global::SPPP.Properties.Resources.Actions_button_cancel_icon;
            this.btnCancelarPer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPer.Location = new System.Drawing.Point(277, 203);
            this.btnCancelarPer.Name = "btnCancelarPer";
            this.btnCancelarPer.Size = new System.Drawing.Size(79, 31);
            this.btnCancelarPer.TabIndex = 8;
            this.btnCancelarPer.Text = "Cancelar";
            this.btnCancelarPer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarPer.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPer
            // 
            this.btnGuardarPer.Image = global::SPPP.Properties.Resources.Actions_dialog_ok_icon;
            this.btnGuardarPer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPer.Location = new System.Drawing.Point(192, 203);
            this.btnGuardarPer.Name = "btnGuardarPer";
            this.btnGuardarPer.Size = new System.Drawing.Size(79, 31);
            this.btnGuardarPer.TabIndex = 7;
            this.btnGuardarPer.Text = "Guardar";
            this.btnGuardarPer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "El numero de horas seran las necesarias para concluir con\r\nlas practicas en ese p" +
    "eriodo.\r\n";
            // 
            // txtPerHoras
            // 
            this.txtPerHoras.Location = new System.Drawing.Point(89, 166);
            this.txtPerHoras.Name = "txtPerHoras";
            this.txtPerHoras.Size = new System.Drawing.Size(100, 20);
            this.txtPerHoras.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.btnEditarCarr);
            this.tabPage4.Controls.Add(this.btnCancelarCarr);
            this.tabPage4.Controls.Add(this.btnGuardarCarr);
            this.tabPage4.Controls.Add(this.dgvCarreras);
            this.tabPage4.Controls.Add(this.cmbElgFacultad);
            this.tabPage4.Controls.Add(this.Facultad);
            this.tabPage4.Location = new System.Drawing.Point(154, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(364, 262);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Carreras";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Carreras:";
            // 
            // btnEditarCarr
            // 
            this.btnEditarCarr.Image = global::SPPP.Properties.Resources.Pencil_icon;
            this.btnEditarCarr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCarr.Location = new System.Drawing.Point(93, 223);
            this.btnEditarCarr.Name = "btnEditarCarr";
            this.btnEditarCarr.Size = new System.Drawing.Size(75, 31);
            this.btnEditarCarr.TabIndex = 16;
            this.btnEditarCarr.Text = "Editar";
            this.btnEditarCarr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCarr.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCarr
            // 
            this.btnCancelarCarr.Image = global::SPPP.Properties.Resources.Actions_button_cancel_icon;
            this.btnCancelarCarr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCarr.Location = new System.Drawing.Point(259, 223);
            this.btnCancelarCarr.Name = "btnCancelarCarr";
            this.btnCancelarCarr.Size = new System.Drawing.Size(79, 31);
            this.btnCancelarCarr.TabIndex = 15;
            this.btnCancelarCarr.Text = "Cancelar";
            this.btnCancelarCarr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCarr.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCarr
            // 
            this.btnGuardarCarr.Image = global::SPPP.Properties.Resources.Actions_dialog_ok_icon;
            this.btnGuardarCarr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCarr.Location = new System.Drawing.Point(174, 223);
            this.btnGuardarCarr.Name = "btnGuardarCarr";
            this.btnGuardarCarr.Size = new System.Drawing.Size(79, 31);
            this.btnGuardarCarr.TabIndex = 14;
            this.btnGuardarCarr.Text = "Guardar";
            this.btnGuardarCarr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCarr.UseVisualStyleBackColor = true;
            // 
            // dgvCarreras
            // 
            this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreras.Location = new System.Drawing.Point(32, 77);
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.Size = new System.Drawing.Size(306, 135);
            this.dgvCarreras.TabIndex = 2;
            // 
            // cmbElgFacultad
            // 
            this.cmbElgFacultad.FormattingEnabled = true;
            this.cmbElgFacultad.Location = new System.Drawing.Point(112, 24);
            this.cmbElgFacultad.Name = "cmbElgFacultad";
            this.cmbElgFacultad.Size = new System.Drawing.Size(121, 21);
            this.cmbElgFacultad.TabIndex = 1;
            this.cmbElgFacultad.SelectedIndexChanged += new System.EventHandler(this.cmbElgFacultad_SelectedIndexChanged);
            // 
            // Facultad
            // 
            this.Facultad.AutoSize = true;
            this.Facultad.Location = new System.Drawing.Point(29, 32);
            this.Facultad.Name = "Facultad";
            this.Facultad.Size = new System.Drawing.Size(48, 13);
            this.Facultad.TabIndex = 0;
            this.Facultad.Text = "Facultad";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btnEditarPerf);
            this.tabPage3.Controls.Add(this.btnCancelarPerf);
            this.tabPage3.Controls.Add(this.btnGuardarPerf);
            this.tabPage3.Controls.Add(this.dgvPerfiles);
            this.tabPage3.Controls.Add(this.cmbCarrera);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.cmbFacultad);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(364, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Perfiles";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Perfiles:";
            // 
            // btnEditarPerf
            // 
            this.btnEditarPerf.Image = global::SPPP.Properties.Resources.Pencil_icon;
            this.btnEditarPerf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPerf.Location = new System.Drawing.Point(90, 225);
            this.btnEditarPerf.Name = "btnEditarPerf";
            this.btnEditarPerf.Size = new System.Drawing.Size(75, 31);
            this.btnEditarPerf.TabIndex = 13;
            this.btnEditarPerf.Text = "Editar";
            this.btnEditarPerf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPerf.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPerf
            // 
            this.btnCancelarPerf.Image = global::SPPP.Properties.Resources.Actions_button_cancel_icon;
            this.btnCancelarPerf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPerf.Location = new System.Drawing.Point(256, 225);
            this.btnCancelarPerf.Name = "btnCancelarPerf";
            this.btnCancelarPerf.Size = new System.Drawing.Size(79, 31);
            this.btnCancelarPerf.TabIndex = 12;
            this.btnCancelarPerf.Text = "Cancelar";
            this.btnCancelarPerf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarPerf.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPerf
            // 
            this.btnGuardarPerf.Image = global::SPPP.Properties.Resources.Actions_dialog_ok_icon;
            this.btnGuardarPerf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPerf.Location = new System.Drawing.Point(171, 225);
            this.btnGuardarPerf.Name = "btnGuardarPerf";
            this.btnGuardarPerf.Size = new System.Drawing.Size(79, 31);
            this.btnGuardarPerf.TabIndex = 11;
            this.btnGuardarPerf.Text = "Guardar";
            this.btnGuardarPerf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPerf.UseVisualStyleBackColor = true;
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.Location = new System.Drawing.Point(29, 95);
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.Size = new System.Drawing.Size(306, 124);
            this.dgvPerfiles.TabIndex = 4;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(109, 42);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(121, 21);
            this.cmbCarrera.TabIndex = 3;
            this.cmbCarrera.SelectedIndexChanged += new System.EventHandler(this.cmbCarrera_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Carrera";
            // 
            // cmbFacultad
            // 
            this.cmbFacultad.FormattingEnabled = true;
            this.cmbFacultad.Location = new System.Drawing.Point(109, 8);
            this.cmbFacultad.Name = "cmbFacultad";
            this.cmbFacultad.Size = new System.Drawing.Size(121, 21);
            this.cmbFacultad.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Facultad";
            // 
            // txtPerInicio
            // 
            this.txtPerInicio.Location = new System.Drawing.Point(89, 62);
            this.txtPerInicio.Name = "txtPerInicio";
            this.txtPerInicio.Size = new System.Drawing.Size(199, 20);
            this.txtPerInicio.TabIndex = 9;
            // 
            // txtPerFin
            // 
            this.txtPerFin.Location = new System.Drawing.Point(89, 110);
            this.txtPerFin.Name = "txtPerFin";
            this.txtPerFin.Size = new System.Drawing.Size(199, 20);
            this.txtPerFin.TabIndex = 10;
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 270);
            this.Controls.Add(this.tabControl1);
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.Opciones_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerHoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarPer;
        private System.Windows.Forms.Button btnGuardarPer;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelarCuen;
        private System.Windows.Forms.Button btnGuardarCuen;
        private System.Windows.Forms.TextBox txtConfContraseña;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPerfiles;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFacultad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditarPerf;
        private System.Windows.Forms.Button btnCancelarPerf;
        private System.Windows.Forms.Button btnGuardarPerf;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnEditarCarr;
        private System.Windows.Forms.Button btnCancelarCarr;
        private System.Windows.Forms.Button btnGuardarCarr;
        private System.Windows.Forms.DataGridView dgvCarreras;
        private System.Windows.Forms.ComboBox cmbElgFacultad;
        private System.Windows.Forms.Label Facultad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscarRes;
        private System.Windows.Forms.DateTimePicker txtPerInicio;
        private System.Windows.Forms.DateTimePicker txtPerFin;
    }
}