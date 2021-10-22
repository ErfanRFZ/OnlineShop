
namespace OnlineShop
{
    partial class Loading
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
            this.shopIcon = new System.Windows.Forms.PictureBox();
            this.versioLabel = new System.Windows.Forms.Label();
            this.onlineshopLabel = new System.Windows.Forms.Label();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradientPanel1 = new OnlineShop.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.shopIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // shopIcon
            // 
            this.shopIcon.BackColor = System.Drawing.Color.Transparent;
            this.shopIcon.Image = global::OnlineShop.Properties.Resources.ShopIcon;
            this.shopIcon.Location = new System.Drawing.Point(63, 42);
            this.shopIcon.Name = "shopIcon";
            this.shopIcon.Size = new System.Drawing.Size(203, 203);
            this.shopIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shopIcon.TabIndex = 14;
            this.shopIcon.TabStop = false;
            this.shopIcon.Click += new System.EventHandler(this.shopIcon_Click);
            // 
            // versioLabel
            // 
            this.versioLabel.AutoSize = true;
            this.versioLabel.BackColor = System.Drawing.Color.Transparent;
            this.versioLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versioLabel.ForeColor = System.Drawing.Color.Black;
            this.versioLabel.Location = new System.Drawing.Point(272, 150);
            this.versioLabel.Name = "versioLabel";
            this.versioLabel.Size = new System.Drawing.Size(106, 28);
            this.versioLabel.TabIndex = 13;
            this.versioLabel.Text = "version 1.0";
            this.versioLabel.Click += new System.EventHandler(this.versioLabel_Click);
            // 
            // onlineshopLabel
            // 
            this.onlineshopLabel.AutoSize = true;
            this.onlineshopLabel.BackColor = System.Drawing.Color.Transparent;
            this.onlineshopLabel.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineshopLabel.ForeColor = System.Drawing.Color.Black;
            this.onlineshopLabel.Location = new System.Drawing.Point(254, 88);
            this.onlineshopLabel.Name = "onlineshopLabel";
            this.onlineshopLabel.Size = new System.Drawing.Size(295, 62);
            this.onlineshopLabel.TabIndex = 12;
            this.onlineshopLabel.Text = "Online Shop";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-1, 445);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(114)))), ((int)(((byte)(255)))));
            this.progressBar.ShadowDecoration.Parent = this.progressBar;
            this.progressBar.Size = new System.Drawing.Size(800, 5);
            this.progressBar.TabIndex = 15;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.ButtomColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(114)))), ((int)(((byte)(248)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.gradientPanel1.TabIndex = 16;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(132)))), ((int)(((byte)(249)))));
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.shopIcon);
            this.Controls.Add(this.versioLabel);
            this.Controls.Add(this.onlineshopLabel);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox shopIcon;
        private System.Windows.Forms.Label versioLabel;
        private System.Windows.Forms.Label onlineshopLabel;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private GradientPanel gradientPanel1;
    }
}