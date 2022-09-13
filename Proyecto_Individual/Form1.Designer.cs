namespace Proyecto_Individual
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.f1 = new System.Windows.Forms.Panel();
            this.BtnArea = new ns1.BunifuFlatButton();
            this.BtnProductoc = new ns1.BunifuFlatButton();
            this.BtnClientec = new ns1.BunifuFlatButton();
            this.BtnEmpleadoc = new ns1.BunifuFlatButton();
            this.BtnCarpinteria = new ns1.BunifuFlatButton();
            this.BtnMenu = new ns1.BunifuImageButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.f1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Chocolate;
            this.Header.Controls.Add(this.lblName);
            this.Header.Controls.Add(this.bunifuImageButton1);
            this.LogoTransition.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.Color.Transparent;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1226, 60);
            this.Header.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblName, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblName, BunifuAnimatorNS.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(323, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Create your carpentry";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Chocolate;
            this.LogoTransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1138, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(85, 59);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // f1
            // 
            this.f1.BackColor = System.Drawing.Color.SandyBrown;
            this.f1.Controls.Add(this.BtnArea);
            this.f1.Controls.Add(this.BtnProductoc);
            this.f1.Controls.Add(this.BtnClientec);
            this.f1.Controls.Add(this.BtnEmpleadoc);
            this.f1.Controls.Add(this.BtnCarpinteria);
            this.f1.Controls.Add(this.BtnMenu);
            this.f1.Controls.Add(this.Logo);
            this.LogoTransition.SetDecoration(this.f1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.f1, BunifuAnimatorNS.DecorationType.None);
            this.f1.Dock = System.Windows.Forms.DockStyle.Left;
            this.f1.Location = new System.Drawing.Point(0, 60);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(273, 551);
            this.f1.TabIndex = 1;
            // 
            // BtnArea
            // 
            this.BtnArea.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnArea.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnArea.BorderRadius = 0;
            this.BtnArea.ButtonText = "               Area";
            this.BtnArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.BtnArea, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnArea, BunifuAnimatorNS.DecorationType.None);
            this.BtnArea.DisabledColor = System.Drawing.Color.Gray;
            this.BtnArea.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnArea.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnArea.Iconimage")));
            this.BtnArea.Iconimage_right = null;
            this.BtnArea.Iconimage_right_Selected = null;
            this.BtnArea.Iconimage_Selected = null;
            this.BtnArea.IconMarginLeft = 0;
            this.BtnArea.IconMarginRight = 0;
            this.BtnArea.IconRightVisible = true;
            this.BtnArea.IconRightZoom = 0D;
            this.BtnArea.IconVisible = true;
            this.BtnArea.IconZoom = 90D;
            this.BtnArea.IsTab = false;
            this.BtnArea.Location = new System.Drawing.Point(4, 209);
            this.BtnArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnArea.Name = "BtnArea";
            this.BtnArea.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnArea.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnArea.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnArea.selected = false;
            this.BtnArea.Size = new System.Drawing.Size(242, 45);
            this.BtnArea.TabIndex = 12;
            this.BtnArea.Text = "               Area";
            this.BtnArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnArea.Textcolor = System.Drawing.Color.White;
            this.BtnArea.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // BtnProductoc
            // 
            this.BtnProductoc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnProductoc.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnProductoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProductoc.BorderRadius = 0;
            this.BtnProductoc.ButtonText = "               Producto";
            this.BtnProductoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.BtnProductoc, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnProductoc, BunifuAnimatorNS.DecorationType.None);
            this.BtnProductoc.DisabledColor = System.Drawing.Color.Gray;
            this.BtnProductoc.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnProductoc.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnProductoc.Iconimage")));
            this.BtnProductoc.Iconimage_right = null;
            this.BtnProductoc.Iconimage_right_Selected = null;
            this.BtnProductoc.Iconimage_Selected = null;
            this.BtnProductoc.IconMarginLeft = 0;
            this.BtnProductoc.IconMarginRight = 0;
            this.BtnProductoc.IconRightVisible = true;
            this.BtnProductoc.IconRightZoom = 0D;
            this.BtnProductoc.IconVisible = true;
            this.BtnProductoc.IconZoom = 90D;
            this.BtnProductoc.IsTab = false;
            this.BtnProductoc.Location = new System.Drawing.Point(4, 315);
            this.BtnProductoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnProductoc.Name = "BtnProductoc";
            this.BtnProductoc.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnProductoc.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnProductoc.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnProductoc.selected = false;
            this.BtnProductoc.Size = new System.Drawing.Size(242, 45);
            this.BtnProductoc.TabIndex = 11;
            this.BtnProductoc.Text = "               Producto";
            this.BtnProductoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductoc.Textcolor = System.Drawing.Color.White;
            this.BtnProductoc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductoc.Click += new System.EventHandler(this.BtnProductoc_Click);
            // 
            // BtnClientec
            // 
            this.BtnClientec.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnClientec.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnClientec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClientec.BorderRadius = 0;
            this.BtnClientec.ButtonText = "               Cliente";
            this.BtnClientec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.BtnClientec, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnClientec, BunifuAnimatorNS.DecorationType.None);
            this.BtnClientec.DisabledColor = System.Drawing.Color.Gray;
            this.BtnClientec.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnClientec.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnClientec.Iconimage")));
            this.BtnClientec.Iconimage_right = null;
            this.BtnClientec.Iconimage_right_Selected = null;
            this.BtnClientec.Iconimage_Selected = null;
            this.BtnClientec.IconMarginLeft = 0;
            this.BtnClientec.IconMarginRight = 0;
            this.BtnClientec.IconRightVisible = true;
            this.BtnClientec.IconRightZoom = 0D;
            this.BtnClientec.IconVisible = true;
            this.BtnClientec.IconZoom = 90D;
            this.BtnClientec.IsTab = false;
            this.BtnClientec.Location = new System.Drawing.Point(4, 368);
            this.BtnClientec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClientec.Name = "BtnClientec";
            this.BtnClientec.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnClientec.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnClientec.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnClientec.selected = false;
            this.BtnClientec.Size = new System.Drawing.Size(242, 42);
            this.BtnClientec.TabIndex = 10;
            this.BtnClientec.Text = "               Cliente";
            this.BtnClientec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientec.Textcolor = System.Drawing.Color.White;
            this.BtnClientec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientec.Click += new System.EventHandler(this.BtnClientec_Click);
            // 
            // BtnEmpleadoc
            // 
            this.BtnEmpleadoc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnEmpleadoc.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnEmpleadoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEmpleadoc.BorderRadius = 0;
            this.BtnEmpleadoc.ButtonText = "               Empleado";
            this.BtnEmpleadoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.BtnEmpleadoc, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnEmpleadoc, BunifuAnimatorNS.DecorationType.None);
            this.BtnEmpleadoc.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEmpleadoc.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEmpleadoc.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEmpleadoc.Iconimage")));
            this.BtnEmpleadoc.Iconimage_right = null;
            this.BtnEmpleadoc.Iconimage_right_Selected = null;
            this.BtnEmpleadoc.Iconimage_Selected = null;
            this.BtnEmpleadoc.IconMarginLeft = 0;
            this.BtnEmpleadoc.IconMarginRight = 0;
            this.BtnEmpleadoc.IconRightVisible = true;
            this.BtnEmpleadoc.IconRightZoom = 0D;
            this.BtnEmpleadoc.IconVisible = true;
            this.BtnEmpleadoc.IconZoom = 90D;
            this.BtnEmpleadoc.IsTab = false;
            this.BtnEmpleadoc.Location = new System.Drawing.Point(4, 262);
            this.BtnEmpleadoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEmpleadoc.Name = "BtnEmpleadoc";
            this.BtnEmpleadoc.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnEmpleadoc.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnEmpleadoc.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEmpleadoc.selected = false;
            this.BtnEmpleadoc.Size = new System.Drawing.Size(242, 45);
            this.BtnEmpleadoc.TabIndex = 9;
            this.BtnEmpleadoc.Text = "               Empleado";
            this.BtnEmpleadoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleadoc.Textcolor = System.Drawing.Color.White;
            this.BtnEmpleadoc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleadoc.Click += new System.EventHandler(this.BtnEmpleadoc_Click);
            // 
            // BtnCarpinteria
            // 
            this.BtnCarpinteria.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCarpinteria.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnCarpinteria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCarpinteria.BorderRadius = 0;
            this.BtnCarpinteria.ButtonText = "               Carpinteria";
            this.BtnCarpinteria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransition.SetDecoration(this.BtnCarpinteria, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnCarpinteria, BunifuAnimatorNS.DecorationType.None);
            this.BtnCarpinteria.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCarpinteria.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCarpinteria.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnCarpinteria.Iconimage")));
            this.BtnCarpinteria.Iconimage_right = null;
            this.BtnCarpinteria.Iconimage_right_Selected = null;
            this.BtnCarpinteria.Iconimage_Selected = null;
            this.BtnCarpinteria.IconMarginLeft = 0;
            this.BtnCarpinteria.IconMarginRight = 0;
            this.BtnCarpinteria.IconRightVisible = true;
            this.BtnCarpinteria.IconRightZoom = 0D;
            this.BtnCarpinteria.IconVisible = true;
            this.BtnCarpinteria.IconZoom = 90D;
            this.BtnCarpinteria.IsTab = false;
            this.BtnCarpinteria.Location = new System.Drawing.Point(4, 155);
            this.BtnCarpinteria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCarpinteria.Name = "BtnCarpinteria";
            this.BtnCarpinteria.Normalcolor = System.Drawing.Color.SandyBrown;
            this.BtnCarpinteria.OnHovercolor = System.Drawing.Color.SandyBrown;
            this.BtnCarpinteria.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCarpinteria.selected = false;
            this.BtnCarpinteria.Size = new System.Drawing.Size(242, 46);
            this.BtnCarpinteria.TabIndex = 8;
            this.BtnCarpinteria.Text = "               Carpinteria";
            this.BtnCarpinteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCarpinteria.Textcolor = System.Drawing.Color.White;
            this.BtnCarpinteria.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarpinteria.Click += new System.EventHandler(this.BtnCarpinteria_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.LogoTransition.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageActive = null;
            this.BtnMenu.Location = new System.Drawing.Point(222, 89);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(45, 39);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenu.TabIndex = 3;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Zoom = 10;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // Logo
            // 
            this.PanelTransition.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = global::Proyecto_Individual.Properties.Resources.Carp;
            this.Logo.Location = new System.Drawing.Point(19, 17);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(203, 111);
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.NavajoWhite;
            this.LogoTransition.SetDecoration(this.Contenedor, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Contenedor, BunifuAnimatorNS.DecorationType.None);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(273, 60);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(953, 551);
            this.Contenedor.TabIndex = 2;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation2;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 611);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.Header);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.f1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Panel f1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label lblName;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuImageButton BtnMenu;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private ns1.BunifuFlatButton BtnArea;
        private ns1.BunifuFlatButton BtnProductoc;
        private ns1.BunifuFlatButton BtnClientec;
        private ns1.BunifuFlatButton BtnEmpleadoc;
        private ns1.BunifuFlatButton BtnCarpinteria;
    }
}

