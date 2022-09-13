namespace Proyecto_Individual
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.cbidcarpinteria = new System.Windows.Forms.ComboBox();
            this.cbidarea = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.DTGVEmpleado = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.Update = new ns1.BunifuFlatButton();
            this.BtnBuscar = new ns1.BunifuFlatButton();
            this.BtnEliminar = new ns1.BunifuFlatButton();
            this.BtnAgregar = new ns1.BunifuFlatButton();
            this.BtnReporte = new ns1.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 38);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 102;
            this.label1.Text = "Empleado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Individual.Properties.Resources.icons8_director_de_escuela_48;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 103;
            this.label7.Text = "IdEmpleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 104;
            this.label2.Text = "IdCarpinteria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 105;
            this.label3.Text = "IdArea:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 106;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 107;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 108;
            this.label6.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(755, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 24);
            this.label8.TabIndex = 109;
            this.label8.Text = "RFC:";
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(149, 130);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(100, 22);
            this.txtidempleado.TabIndex = 110;
            // 
            // cbidcarpinteria
            // 
            this.cbidcarpinteria.FormattingEnabled = true;
            this.cbidcarpinteria.Location = new System.Drawing.Point(422, 126);
            this.cbidcarpinteria.Name = "cbidcarpinteria";
            this.cbidcarpinteria.Size = new System.Drawing.Size(121, 24);
            this.cbidcarpinteria.TabIndex = 111;
            // 
            // cbidarea
            // 
            this.cbidarea.FormattingEnabled = true;
            this.cbidarea.Location = new System.Drawing.Point(668, 126);
            this.cbidarea.Name = "cbidarea";
            this.cbidarea.Size = new System.Drawing.Size(121, 24);
            this.cbidarea.TabIndex = 112;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(128, 176);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 113;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(373, 176);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 22);
            this.txtdireccion.TabIndex = 114;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(616, 176);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 22);
            this.txttelefono.TabIndex = 115;
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(819, 176);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(100, 22);
            this.txtrfc.TabIndex = 116;
            // 
            // DTGVEmpleado
            // 
            this.DTGVEmpleado.AllowUserToOrderColumns = true;
            this.DTGVEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVEmpleado.Location = new System.Drawing.Point(29, 338);
            this.DTGVEmpleado.Name = "DTGVEmpleado";
            this.DTGVEmpleado.RowTemplate.Height = 24;
            this.DTGVEmpleado.Size = new System.Drawing.Size(658, 134);
            this.DTGVEmpleado.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 31);
            this.label9.TabIndex = 120;
            this.label9.Text = "Registros";
            // 
            // Update
            // 
            this.Update.Activecolor = System.Drawing.Color.Chocolate;
            this.Update.BackColor = System.Drawing.Color.SandyBrown;
            this.Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Update.BorderRadius = 0;
            this.Update.ButtonText = "              Modificar";
            this.Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update.DisabledColor = System.Drawing.Color.Gray;
            this.Update.Iconcolor = System.Drawing.Color.Transparent;
            this.Update.Iconimage = ((System.Drawing.Image)(resources.GetObject("Update.Iconimage")));
            this.Update.Iconimage_right = null;
            this.Update.Iconimage_right_Selected = null;
            this.Update.Iconimage_Selected = null;
            this.Update.IconMarginLeft = 0;
            this.Update.IconMarginRight = 0;
            this.Update.IconRightVisible = true;
            this.Update.IconRightZoom = 0D;
            this.Update.IconVisible = true;
            this.Update.IconZoom = 90D;
            this.Update.IsTab = false;
            this.Update.Location = new System.Drawing.Point(493, 225);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update.Name = "Update";
            this.Update.Normalcolor = System.Drawing.Color.SandyBrown;
            this.Update.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.Update.OnHoverTextColor = System.Drawing.Color.White;
            this.Update.selected = false;
            this.Update.Size = new System.Drawing.Size(194, 59);
            this.Update.TabIndex = 119;
            this.Update.Text = "              Modificar";
            this.Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Textcolor = System.Drawing.Color.Black;
            this.Update.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Activecolor = System.Drawing.Color.Chocolate;
            this.BtnBuscar.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.BorderRadius = 0;
            this.BtnBuscar.ButtonText = "              Buscar";
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnBuscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Iconimage")));
            this.BtnBuscar.Iconimage_right = null;
            this.BtnBuscar.Iconimage_right_Selected = null;
            this.BtnBuscar.Iconimage_Selected = null;
            this.BtnBuscar.IconMarginLeft = 0;
            this.BtnBuscar.IconMarginRight = 0;
            this.BtnBuscar.IconRightVisible = true;
            this.BtnBuscar.IconRightZoom = 0D;
            this.BtnBuscar.IconVisible = true;
            this.BtnBuscar.IconZoom = 90D;
            this.BtnBuscar.IsTab = false;
            this.BtnBuscar.Location = new System.Drawing.Point(265, 225);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnBuscar.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnBuscar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBuscar.selected = false;
            this.BtnBuscar.Size = new System.Drawing.Size(194, 59);
            this.BtnBuscar.TabIndex = 118;
            this.BtnBuscar.Text = "              Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Textcolor = System.Drawing.Color.Black;
            this.BtnBuscar.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Activecolor = System.Drawing.Color.Chocolate;
            this.BtnEliminar.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.BorderRadius = 0;
            this.BtnEliminar.ButtonText = "              Eliminar";
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Iconimage")));
            this.BtnEliminar.Iconimage_right = null;
            this.BtnEliminar.Iconimage_right_Selected = null;
            this.BtnEliminar.Iconimage_Selected = null;
            this.BtnEliminar.IconMarginLeft = 0;
            this.BtnEliminar.IconMarginRight = 0;
            this.BtnEliminar.IconRightVisible = true;
            this.BtnEliminar.IconRightZoom = 0D;
            this.BtnEliminar.IconVisible = true;
            this.BtnEliminar.IconZoom = 90D;
            this.BtnEliminar.IsTab = false;
            this.BtnEliminar.Location = new System.Drawing.Point(726, 225);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnEliminar.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminar.selected = false;
            this.BtnEliminar.Size = new System.Drawing.Size(194, 59);
            this.BtnEliminar.TabIndex = 117;
            this.BtnEliminar.Text = "              Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Textcolor = System.Drawing.Color.Black;
            this.BtnEliminar.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Activecolor = System.Drawing.Color.Chocolate;
            this.BtnAgregar.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.BorderRadius = 0;
            this.BtnAgregar.ButtonText = "              Agregar";
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAgregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Iconimage")));
            this.BtnAgregar.Iconimage_right = null;
            this.BtnAgregar.Iconimage_right_Selected = null;
            this.BtnAgregar.Iconimage_Selected = null;
            this.BtnAgregar.IconMarginLeft = 0;
            this.BtnAgregar.IconMarginRight = 0;
            this.BtnAgregar.IconRightVisible = true;
            this.BtnAgregar.IconRightZoom = 0D;
            this.BtnAgregar.IconVisible = true;
            this.BtnAgregar.IconZoom = 90D;
            this.BtnAgregar.IsTab = false;
            this.BtnAgregar.Location = new System.Drawing.Point(29, 225);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnAgregar.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAgregar.selected = false;
            this.BtnAgregar.Size = new System.Drawing.Size(194, 59);
            this.BtnAgregar.TabIndex = 122;
            this.BtnAgregar.Text = "              Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Textcolor = System.Drawing.Color.Black;
            this.BtnAgregar.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.Activecolor = System.Drawing.Color.Chocolate;
            this.BtnReporte.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReporte.BorderRadius = 0;
            this.BtnReporte.ButtonText = "              Reporte";
            this.BtnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReporte.DisabledColor = System.Drawing.Color.Gray;
            this.BtnReporte.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnReporte.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnReporte.Iconimage")));
            this.BtnReporte.Iconimage_right = null;
            this.BtnReporte.Iconimage_right_Selected = null;
            this.BtnReporte.Iconimage_Selected = null;
            this.BtnReporte.IconMarginLeft = 0;
            this.BtnReporte.IconMarginRight = 0;
            this.BtnReporte.IconRightVisible = true;
            this.BtnReporte.IconRightZoom = 0D;
            this.BtnReporte.IconVisible = true;
            this.BtnReporte.IconZoom = 90D;
            this.BtnReporte.IsTab = false;
            this.BtnReporte.Location = new System.Drawing.Point(725, 317);
            this.BtnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnReporte.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnReporte.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnReporte.selected = false;
            this.BtnReporte.Size = new System.Drawing.Size(194, 59);
            this.BtnReporte.TabIndex = 123;
            this.BtnReporte.Text = "              Reporte";
            this.BtnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReporte.Textcolor = System.Drawing.Color.Black;
            this.BtnReporte.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(950, 509);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.DTGVEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.cbidarea);
            this.Controls.Add(this.cbidcarpinteria);
            this.Controls.Add(this.txtidempleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.ComboBox cbidcarpinteria;
        private System.Windows.Forms.ComboBox cbidarea;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.DataGridView DTGVEmpleado;
        private System.Windows.Forms.Label label9;
        private ns1.BunifuFlatButton Update;
        private ns1.BunifuFlatButton BtnBuscar;
        private ns1.BunifuFlatButton BtnEliminar;
        private ns1.BunifuFlatButton BtnAgregar;
        private ns1.BunifuFlatButton BtnReporte;
    }
}