﻿namespace HorarioXML
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgHorario = new System.Windows.Forms.DataGridView();
            this.gpbHorario = new System.Windows.Forms.GroupBox();
            this.cmbbDia = new System.Windows.Forms.ComboBox();
            this.cmbbHora = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.lblModulos = new System.Windows.Forms.Label();
            this.lstModulo = new System.Windows.Forms.ListBox();
            this.lstCiclo = new System.Windows.Forms.ListBox();
            this.cmbbCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dsDatos = new System.Data.DataSet();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).BeginInit();
            this.gpbHorario.SuspendLayout();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHorario
            // 
            this.dgHorario.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHorario.Location = new System.Drawing.Point(12, 12);
            this.dgHorario.Name = "dgHorario";
            this.dgHorario.Size = new System.Drawing.Size(728, 256);
            this.dgHorario.TabIndex = 0;
            // 
            // gpbHorario
            // 
            this.gpbHorario.Controls.Add(this.cmbbDia);
            this.gpbHorario.Controls.Add(this.cmbbHora);
            this.gpbHorario.Controls.Add(this.lblDia);
            this.gpbHorario.Controls.Add(this.lblHora);
            this.gpbHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbHorario.Location = new System.Drawing.Point(12, 291);
            this.gpbHorario.Name = "gpbHorario";
            this.gpbHorario.Size = new System.Drawing.Size(231, 117);
            this.gpbHorario.TabIndex = 1;
            this.gpbHorario.TabStop = false;
            this.gpbHorario.Text = "Horario";
            // 
            // cmbbDia
            // 
            this.cmbbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbDia.FormattingEnabled = true;
            this.cmbbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.cmbbDia.Location = new System.Drawing.Point(73, 76);
            this.cmbbDia.Name = "cmbbDia";
            this.cmbbDia.Size = new System.Drawing.Size(140, 23);
            this.cmbbDia.TabIndex = 3;
            this.cmbbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
            // 
            // cmbbHora
            // 
            this.cmbbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbHora.FormattingEnabled = true;
            this.cmbbHora.Items.AddRange(new object[] {
            "Primera",
            "Segunda",
            "Tercera",
            "Cuarta",
            "Quinta",
            "Sexta"});
            this.cmbbHora.Location = new System.Drawing.Point(73, 38);
            this.cmbbHora.Name = "cmbbHora";
            this.cmbbHora.Size = new System.Drawing.Size(140, 23);
            this.cmbbHora.TabIndex = 2;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(12, 77);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(38, 18);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Día:";
            this.lblDia.Click += new System.EventHandler(this.lblDia_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(12, 38);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(50, 18);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(35, 430);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 39);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR HORARIO";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(35, 486);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(200, 39);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "CARGAR HORARIO";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.lblModulos);
            this.gpbDatos.Controls.Add(this.lstModulo);
            this.gpbDatos.Controls.Add(this.lstCiclo);
            this.gpbDatos.Controls.Add(this.cmbbCurso);
            this.gpbDatos.Controls.Add(this.lblCurso);
            this.gpbDatos.Controls.Add(this.lblCiclo);
            this.gpbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatos.Location = new System.Drawing.Point(294, 291);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(446, 230);
            this.gpbDatos.TabIndex = 4;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos del curso";
            // 
            // lblModulos
            // 
            this.lblModulos.AutoSize = true;
            this.lblModulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulos.Location = new System.Drawing.Point(200, 66);
            this.lblModulos.Name = "lblModulos";
            this.lblModulos.Size = new System.Drawing.Size(78, 18);
            this.lblModulos.TabIndex = 6;
            this.lblModulos.Text = "Módulos:";
            // 
            // lstModulo
            // 
            this.lstModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstModulo.FormattingEnabled = true;
            this.lstModulo.ItemHeight = 15;
            this.lstModulo.Items.AddRange(new object[] {
            "ACCESO A DATOS",
            "DESARROLLO INTERFACES",
            "GESTION EMPRESARIAL",
            "INICIATIVA EMPRENDEDORA",
            "PROCESOS",
            "PROGRAMACION MULTIMEDIA"});
            this.lstModulo.Location = new System.Drawing.Point(203, 97);
            this.lstModulo.Name = "lstModulo";
            this.lstModulo.Size = new System.Drawing.Size(225, 109);
            this.lstModulo.TabIndex = 5;
            // 
            // lstCiclo
            // 
            this.lstCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCiclo.FormattingEnabled = true;
            this.lstCiclo.ItemHeight = 15;
            this.lstCiclo.Items.AddRange(new object[] {
            "DAM"});
            this.lstCiclo.Location = new System.Drawing.Point(65, 52);
            this.lstCiclo.Name = "lstCiclo";
            this.lstCiclo.Size = new System.Drawing.Size(112, 154);
            this.lstCiclo.TabIndex = 4;
            // 
            // cmbbCurso
            // 
            this.cmbbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbCurso.FormattingEnabled = true;
            this.cmbbCurso.Items.AddRange(new object[] {
            "Primero",
            "Segundo"});
            this.cmbbCurso.Location = new System.Drawing.Point(307, 20);
            this.cmbbCurso.Name = "cmbbCurso";
            this.cmbbCurso.Size = new System.Drawing.Size(121, 23);
            this.cmbbCurso.TabIndex = 3;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(242, 21);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(59, 18);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso:";
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclo.Location = new System.Drawing.Point(62, 28);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(52, 18);
            this.lblCiclo.TabIndex = 0;
            this.lblCiclo.Text = "Ciclo:";
            // 
            // btnAniadir
            // 
            this.btnAniadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAniadir.BackgroundImage = global::HorarioXML.Properties.Resources.Button_Add_01_25115;
            this.btnAniadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAniadir.FlatAppearance.BorderSize = 0;
            this.btnAniadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAniadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadir.Location = new System.Drawing.Point(688, 527);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(40, 40);
            this.btnAniadir.TabIndex = 7;
            this.btnAniadir.UseVisualStyleBackColor = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.BackgroundImage = global::HorarioXML.Properties.Resources.Button_Delete_01_25095;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Location = new System.Drawing.Point(629, 527);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(40, 40);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // dsDatos
            // 
            this.dsDatos.DataSetName = "NewDataSet";
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(759, 574);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpbHorario);
            this.Controls.Add(this.dgHorario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HORARIO";
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).EndInit();
            this.gpbHorario.ResumeLayout(false);
            this.gpbHorario.PerformLayout();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHorario;
        private System.Windows.Forms.GroupBox gpbHorario;
        private System.Windows.Forms.ComboBox cmbbDia;
        private System.Windows.Forms.ComboBox cmbbHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Label lblModulos;
        private System.Windows.Forms.ListBox lstModulo;
        private System.Windows.Forms.ListBox lstCiclo;
        private System.Windows.Forms.ComboBox cmbbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAniadir;
        private System.Data.DataSet dsDatos;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
    }
}

