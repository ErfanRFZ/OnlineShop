
namespace OnlineShop
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            this.Header = new OnlineShop.GradientPanel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.gradientPanel1 = new OnlineShop.GradientPanel();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.proButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.product = new System.Windows.Forms.PictureBox();
            this.dashButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gradientPanel2 = new OnlineShop.GradientPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboardButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shopIcon = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Header.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.DashboardPanel.SuspendLayout();
            this.productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Angle = 180F;
            this.Header.ButtomColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.Header.Controls.Add(this.exitLabel);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1400, 25);
            this.Header.TabIndex = 0;
            this.Header.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(1376, 0);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(24, 25);
            this.exitLabel.TabIndex = 2;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.ButtomColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.gradientPanel1.Controls.Add(this.DashboardPanel);
            this.gradientPanel1.Controls.Add(this.gradientPanel2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1400, 800);
            this.gradientPanel1.TabIndex = 1;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.DashboardPanel.Controls.Add(this.productsPanel);
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPanel.Location = new System.Drawing.Point(221, 0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1179, 800);
            this.DashboardPanel.TabIndex = 1;
            // 
            // productsPanel
            // 
            this.productsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.productsPanel.Controls.Add(this.proButton);
            this.productsPanel.Controls.Add(this.product);
            this.productsPanel.Controls.Add(this.dashButton);
            this.productsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsPanel.Location = new System.Drawing.Point(0, 0);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(1179, 800);
            this.productsPanel.TabIndex = 2;
            // 
            // proButton
            // 
            this.proButton.CheckedState.Parent = this.proButton;
            this.proButton.CustomImages.Parent = this.proButton;
            this.proButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.proButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.proButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.proButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.proButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.proButton.DisabledState.Parent = this.proButton;
            this.proButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.proButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.proButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.proButton.ForeColor = System.Drawing.Color.White;
            this.proButton.HoverState.Parent = this.proButton;
            this.proButton.Location = new System.Drawing.Point(133, 257);
            this.proButton.Name = "proButton";
            this.proButton.ShadowDecoration.Parent = this.proButton;
            this.proButton.Size = new System.Drawing.Size(210, 45);
            this.proButton.TabIndex = 17;
            this.proButton.Text = "Products";
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(63)))));
            this.product.Image = global::OnlineShop.Properties.Resources.ShopIcon;
            this.product.Location = new System.Drawing.Point(416, 292);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(112, 116);
            this.product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product.TabIndex = 13;
            this.product.TabStop = false;
            // 
            // dashButton
            // 
            this.dashButton.CheckedState.Parent = this.dashButton;
            this.dashButton.CustomImages.Parent = this.dashButton;
            this.dashButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashButton.DisabledState.Parent = this.dashButton;
            this.dashButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.dashButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.dashButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dashButton.ForeColor = System.Drawing.Color.White;
            this.dashButton.HoverState.Parent = this.dashButton;
            this.dashButton.Location = new System.Drawing.Point(287, 169);
            this.dashButton.Name = "dashButton";
            this.dashButton.ShadowDecoration.Parent = this.dashButton;
            this.dashButton.Size = new System.Drawing.Size(210, 45);
            this.dashButton.TabIndex = 15;
            this.dashButton.Text = "Dashboard";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.ButtomColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(63)))));
            this.gradientPanel2.Controls.Add(this.panel3);
            this.gradientPanel2.Controls.Add(this.productButton);
            this.gradientPanel2.Controls.Add(this.panel1);
            this.gradientPanel2.Controls.Add(this.dashboardButton);
            this.gradientPanel2.Controls.Add(this.panel2);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(221, 800);
            this.gradientPanel2.TabIndex = 0;
            this.gradientPanel2.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(63)))));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.panel3.Location = new System.Drawing.Point(0, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 45);
            this.panel3.TabIndex = 15;
            // 
            // productButton
            // 
            this.productButton.CheckedState.Parent = this.productButton;
            this.productButton.CustomImages.Parent = this.productButton;
            this.productButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productButton.DisabledState.Parent = this.productButton;
            this.productButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.productButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.productButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.productButton.ForeColor = System.Drawing.Color.White;
            this.productButton.HoverState.Parent = this.productButton;
            this.productButton.Location = new System.Drawing.Point(8, 280);
            this.productButton.Name = "productButton";
            this.productButton.ShadowDecoration.Parent = this.productButton;
            this.productButton.Size = new System.Drawing.Size(210, 45);
            this.productButton.TabIndex = 16;
            this.productButton.Text = "Products";
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(0, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 45);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dashboardButton
            // 
            this.dashboardButton.CheckedState.Parent = this.dashboardButton;
            this.dashboardButton.CustomImages.Parent = this.dashboardButton;
            this.dashboardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardButton.DisabledState.Parent = this.dashboardButton;
            this.dashboardButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.dashboardButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.dashboardButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.HoverState.Parent = this.dashboardButton;
            this.dashboardButton.Location = new System.Drawing.Point(8, 220);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.ShadowDecoration.Parent = this.dashboardButton;
            this.dashboardButton.Size = new System.Drawing.Size(210, 45);
            this.dashboardButton.TabIndex = 14;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.usernameLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.shopIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 214);
            this.panel2.TabIndex = 13;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(69, 175);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(74, 18);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Online Shop";
            // 
            // shopIcon
            // 
            this.shopIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(63)))));
            this.shopIcon.Image = global::OnlineShop.Properties.Resources.ShopIcon;
            this.shopIcon.Location = new System.Drawing.Point(52, 31);
            this.shopIcon.Name = "shopIcon";
            this.shopIcon.Size = new System.Drawing.Size(112, 116);
            this.shopIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shopIcon.TabIndex = 12;
            this.shopIcon.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.Header;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.DashboardPanel.ResumeLayout(false);
            this.productsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel Header;
        private System.Windows.Forms.Label exitLabel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox shopIcon;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientButton dashboardButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2GradientButton productButton;
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.PictureBox product;
        private Guna.UI2.WinForms.Guna2GradientButton dashButton;
        private Guna.UI2.WinForms.Guna2GradientButton proButton;
    }
}