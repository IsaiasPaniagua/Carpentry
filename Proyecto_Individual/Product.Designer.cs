namespace Proyecto_Individual
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update = new ns1.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAddImagen = new ns1.BunifuImageButton();
            this.pbfoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new ns1.BunifuFlatButton();
            this.BtnEliminar = new ns1.BunifuFlatButton();
            this.BtnAgregar = new ns1.BunifuFlatButton();
            this.DTGVProducto = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbidempleado = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnReporte = new ns1.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 38);
            this.panel1.TabIndex = 4;
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
            this.Update.Location = new System.Drawing.Point(483, 209);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update.Name = "Update";
            this.Update.Normalcolor = System.Drawing.Color.SandyBrown;
            this.Update.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.Update.OnHoverTextColor = System.Drawing.Color.White;
            this.Update.selected = false;
            this.Update.Size = new System.Drawing.Size(194, 59);
            this.Update.TabIndex = 94;
            this.Update.Text = "              Modificar";
            this.Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Textcolor = System.Drawing.Color.Black;
            this.Update.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 77;
            this.label6.Text = "Imagen:";
            // 
            // BtnAddImagen
            // 
            this.BtnAddImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddImagen.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnAddImagen.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddImagen.Image")));
            this.BtnAddImagen.ImageActive = null;
            this.BtnAddImagen.Location = new System.Drawing.Point(809, 145);
            this.BtnAddImagen.Name = "BtnAddImagen";
            this.BtnAddImagen.Size = new System.Drawing.Size(45, 39);
            this.BtnAddImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnAddImagen.TabIndex = 92;
            this.BtnAddImagen.TabStop = false;
            this.BtnAddImagen.Zoom = 10;
            this.BtnAddImagen.Click += new System.EventHandler(this.BtnAddImagen_Click);
            // 
            // pbfoto
            // 
            this.pbfoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbfoto.Location = new System.Drawing.Point(670, 47);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(184, 92);
            this.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfoto.TabIndex = 91;
            this.pbfoto.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 90;
            this.label7.Text = "IdProducto:";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(140, 117);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(100, 22);
            this.txtidproducto.TabIndex = 89;
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
            this.BtnBuscar.Location = new System.Drawing.Point(255, 209);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnBuscar.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnBuscar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBuscar.selected = false;
            this.BtnBuscar.Size = new System.Drawing.Size(194, 59);
            this.BtnBuscar.TabIndex = 88;
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
            this.BtnEliminar.Location = new System.Drawing.Point(716, 209);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnEliminar.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminar.selected = false;
            this.BtnEliminar.Size = new System.Drawing.Size(194, 59);
            this.BtnEliminar.TabIndex = 87;
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
            this.BtnAgregar.Location = new System.Drawing.Point(19, 209);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnAgregar.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAgregar.selected = false;
            this.BtnAgregar.Size = new System.Drawing.Size(194, 59);
            this.BtnAgregar.TabIndex = 86;
            this.BtnAgregar.Text = "              Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Textcolor = System.Drawing.Color.Black;
            this.BtnAgregar.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DTGVProducto
            // 
            this.DTGVProducto.AllowUserToOrderColumns = true;
            this.DTGVProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVProducto.Location = new System.Drawing.Point(42, 344);
            this.DTGVProducto.Name = "DTGVProducto";
            this.DTGVProducto.RowTemplate.Height = 24;
            this.DTGVProducto.Size = new System.Drawing.Size(837, 134);
            this.DTGVProducto.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 31);
            this.label8.TabIndex = 84;
            this.label8.Text = "Registros";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(406, 160);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(121, 22);
            this.txtdescripcion.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 82;
            this.label5.Text = "Existencia:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(140, 158);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 80;
            this.label4.Text = "Descripción:";
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(685, 160);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(105, 22);
            this.txtexistencia.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "IdEmpleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 75;
            this.label1.Text = "Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Individual.Properties.Resources.icons8_armario_con_puerta_corredera_48;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // cbidempleado
            // 
            this.cbidempleado.FormattingEnabled = true;
            this.cbidempleado.Location = new System.Drawing.Point(406, 117);
            this.cbidempleado.Name = "cbidempleado";
            this.cbidempleado.Size = new System.Drawing.Size(121, 24);
            this.cbidempleado.TabIndex = 95;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.BtnReporte.Location = new System.Drawing.Point(716, 278);
            this.BtnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnReporte.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnReporte.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnReporte.selected = false;
            this.BtnReporte.Size = new System.Drawing.Size(194, 59);
            this.BtnReporte.TabIndex = 124;
            this.BtnReporte.Text = "              Reporte";
            this.BtnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReporte.Textcolor = System.Drawing.Color.Black;
            this.BtnReporte.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(950, 509);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.cbidempleado);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnAddImagen);
            this.Controls.Add(this.pbfoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DTGVProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuFlatButton Update;
        private System.Windows.Forms.Label label6;
        private ns1.BunifuImageButton BtnAddImagen;
        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidproducto;
        private ns1.BunifuFlatButton BtnBuscar;
        private ns1.BunifuFlatButton BtnEliminar;
        private ns1.BunifuFlatButton BtnAgregar;
        private System.Windows.Forms.DataGridView DTGVProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbidempleado;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ns1.BunifuFlatButton BtnReporte;
    }
}