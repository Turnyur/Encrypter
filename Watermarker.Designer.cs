namespace Encrypter
{
    partial class Watermarker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Watermarker));
            this.manualRadioBtn = new System.Windows.Forms.RadioButton();
            this.autoGenRadioBtn = new System.Windows.Forms.RadioButton();
            this.btBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.tbPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.watermarkBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.autoGenTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.busyLoader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busyLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // manualRadioBtn
            // 
            this.manualRadioBtn.AutoSize = true;
            this.manualRadioBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualRadioBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.manualRadioBtn.Location = new System.Drawing.Point(99, 200);
            this.manualRadioBtn.Name = "manualRadioBtn";
            this.manualRadioBtn.Size = new System.Drawing.Size(102, 21);
            this.manualRadioBtn.TabIndex = 9;
            this.manualRadioBtn.TabStop = true;
            this.manualRadioBtn.Text = "Manual Text";
            this.manualRadioBtn.UseVisualStyleBackColor = true;
            this.manualRadioBtn.CheckedChanged += new System.EventHandler(this.manualRadioBtn_CheckedChanged);
            // 
            // autoGenRadioBtn
            // 
            this.autoGenRadioBtn.AutoSize = true;
            this.autoGenRadioBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoGenRadioBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.autoGenRadioBtn.Location = new System.Drawing.Point(99, 164);
            this.autoGenRadioBtn.Name = "autoGenRadioBtn";
            this.autoGenRadioBtn.Size = new System.Drawing.Size(150, 21);
            this.autoGenRadioBtn.TabIndex = 10;
            this.autoGenRadioBtn.TabStop = true;
            this.autoGenRadioBtn.Text = "Auto Generate Text";
            this.autoGenRadioBtn.UseVisualStyleBackColor = true;
            this.autoGenRadioBtn.CheckedChanged += new System.EventHandler(this.autoGenRadioBtn_CheckedChanged);
            // 
            // btBrowse
            // 
            this.btBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBrowse.FillColor = System.Drawing.Color.Silver;
            this.btBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btBrowse.ForeColor = System.Drawing.Color.White;
            this.btBrowse.Location = new System.Drawing.Point(545, 98);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(102, 36);
            this.btBrowse.TabIndex = 8;
            this.btBrowse.Text = "Browse";
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // tbPath
            // 
            this.tbPath.BorderColor = System.Drawing.Color.Silver;
            this.tbPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPath.DefaultText = "";
            this.tbPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPath.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPath.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPath.Location = new System.Drawing.Point(99, 95);
            this.tbPath.Name = "tbPath";
            this.tbPath.PasswordChar = '\0';
            this.tbPath.PlaceholderText = "";
            this.tbPath.SelectedText = "";
            this.tbPath.Size = new System.Drawing.Size(445, 41);
            this.tbPath.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(96, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Document";
            // 
            // watermarkBtn
            // 
            this.watermarkBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.watermarkBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.watermarkBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.watermarkBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.watermarkBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watermarkBtn.ForeColor = System.Drawing.Color.White;
            this.watermarkBtn.Location = new System.Drawing.Point(297, 304);
            this.watermarkBtn.Name = "watermarkBtn";
            this.watermarkBtn.Size = new System.Drawing.Size(180, 45);
            this.watermarkBtn.TabIndex = 11;
            this.watermarkBtn.Text = "Watermark";
            this.watermarkBtn.Click += new System.EventHandler(this.watermarkBtn_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Encrypter.Properties.Resources.signal;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(24, 374);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 13;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Encrypter.Properties.Resources.left;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(677, 393);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(111, 45);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Back";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // autoGenTextBox
            // 
            this.autoGenTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.autoGenTextBox.DefaultText = "";
            this.autoGenTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.autoGenTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.autoGenTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.autoGenTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.autoGenTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.autoGenTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.autoGenTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.autoGenTextBox.Location = new System.Drawing.Point(271, 176);
            this.autoGenTextBox.Name = "autoGenTextBox";
            this.autoGenTextBox.PasswordChar = '\0';
            this.autoGenTextBox.PlaceholderText = "";
            this.autoGenTextBox.SelectedText = "";
            this.autoGenTextBox.Size = new System.Drawing.Size(376, 36);
            this.autoGenTextBox.TabIndex = 14;
            // 
            // busyLoader
            // 
            this.busyLoader.Image = global::Encrypter.Properties.Resources.loading_icon_transparent_background_12;
            this.busyLoader.Location = new System.Drawing.Point(338, 239);
            this.busyLoader.Name = "busyLoader";
            this.busyLoader.Size = new System.Drawing.Size(100, 50);
            this.busyLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.busyLoader.TabIndex = 15;
            this.busyLoader.TabStop = false;
            // 
            // Watermarker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.busyLoader);
            this.Controls.Add(this.autoGenTextBox);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.watermarkBtn);
            this.Controls.Add(this.manualRadioBtn);
            this.Controls.Add(this.autoGenRadioBtn);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Watermarker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watermark File";
            this.Load += new System.EventHandler(this.Watermarker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busyLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton manualRadioBtn;
        private System.Windows.Forms.RadioButton autoGenRadioBtn;
        private Guna.UI2.WinForms.Guna2Button btBrowse;
        private Guna.UI2.WinForms.Guna2TextBox tbPath;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button watermarkBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox autoGenTextBox;
        private System.Windows.Forms.PictureBox busyLoader;
    }
}