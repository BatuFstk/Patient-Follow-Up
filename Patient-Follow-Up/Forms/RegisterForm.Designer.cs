namespace Patient_Follow_Up.Forms
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Registerbutton = new Guna.UI.WinForms.GunaButton();
            this.Kayıtsifretext = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kayıttckimliktext = new Guna.UI.WinForms.GunaTextBox();
            this.backtologinbutton = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 123);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(196, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA BASINÇ TAKİP OTOMASYONU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(396, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "KAYIT EKRANI";
            // 
            // Registerbutton
            // 
            this.Registerbutton.AnimationHoverSpeed = 0.07F;
            this.Registerbutton.AnimationSpeed = 0.03F;
            this.Registerbutton.BaseColor = System.Drawing.Color.CadetBlue;
            this.Registerbutton.BorderColor = System.Drawing.Color.Black;
            this.Registerbutton.BorderSize = 2;
            this.Registerbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Registerbutton.FocusedColor = System.Drawing.Color.Empty;
            this.Registerbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Registerbutton.ForeColor = System.Drawing.Color.Black;
            this.Registerbutton.Image = null;
            this.Registerbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.Registerbutton.Location = new System.Drawing.Point(510, 357);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Registerbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Registerbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.Registerbutton.OnHoverImage = null;
            this.Registerbutton.OnPressedColor = System.Drawing.Color.Black;
            this.Registerbutton.Size = new System.Drawing.Size(160, 42);
            this.Registerbutton.TabIndex = 13;
            this.Registerbutton.Text = "KAYIT";
            this.Registerbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // Kayıtsifretext
            // 
            this.Kayıtsifretext.BaseColor = System.Drawing.Color.White;
            this.Kayıtsifretext.BorderColor = System.Drawing.Color.CadetBlue;
            this.Kayıtsifretext.BorderSize = 3;
            this.Kayıtsifretext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Kayıtsifretext.FocusedBaseColor = System.Drawing.Color.White;
            this.Kayıtsifretext.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Kayıtsifretext.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Kayıtsifretext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Kayıtsifretext.Location = new System.Drawing.Point(312, 268);
            this.Kayıtsifretext.Name = "Kayıtsifretext";
            this.Kayıtsifretext.PasswordChar = '●';
            this.Kayıtsifretext.SelectedText = "";
            this.Kayıtsifretext.Size = new System.Drawing.Size(358, 47);
            this.Kayıtsifretext.TabIndex = 12;
            this.Kayıtsifretext.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(236, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "ŞİFRE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(147, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "TC KİMLİK NO : ";
            // 
            // Kayıttckimliktext
            // 
            this.Kayıttckimliktext.BaseColor = System.Drawing.Color.White;
            this.Kayıttckimliktext.BorderColor = System.Drawing.Color.CadetBlue;
            this.Kayıttckimliktext.BorderSize = 3;
            this.Kayıttckimliktext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Kayıttckimliktext.FocusedBaseColor = System.Drawing.Color.White;
            this.Kayıttckimliktext.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Kayıttckimliktext.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Kayıttckimliktext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Kayıttckimliktext.Location = new System.Drawing.Point(312, 203);
            this.Kayıttckimliktext.Name = "Kayıttckimliktext";
            this.Kayıttckimliktext.PasswordChar = '\0';
            this.Kayıttckimliktext.SelectedText = "";
            this.Kayıttckimliktext.Size = new System.Drawing.Size(358, 47);
            this.Kayıttckimliktext.TabIndex = 9;
            this.Kayıttckimliktext.TextChanged += new System.EventHandler(this.Kayıttckimliktext_TextChanged);
            // 
            // backtologinbutton
            // 
            this.backtologinbutton.AnimationHoverSpeed = 0.07F;
            this.backtologinbutton.AnimationSpeed = 0.03F;
            this.backtologinbutton.BaseColor = System.Drawing.Color.CadetBlue;
            this.backtologinbutton.BorderColor = System.Drawing.Color.Black;
            this.backtologinbutton.BorderSize = 2;
            this.backtologinbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backtologinbutton.FocusedColor = System.Drawing.Color.Empty;
            this.backtologinbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backtologinbutton.ForeColor = System.Drawing.Color.Black;
            this.backtologinbutton.Image = null;
            this.backtologinbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.backtologinbutton.Location = new System.Drawing.Point(182, 357);
            this.backtologinbutton.Name = "backtologinbutton";
            this.backtologinbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.backtologinbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backtologinbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.backtologinbutton.OnHoverImage = null;
            this.backtologinbutton.OnPressedColor = System.Drawing.Color.Black;
            this.backtologinbutton.Size = new System.Drawing.Size(277, 42);
            this.backtologinbutton.TabIndex = 14;
            this.backtologinbutton.Text = "GİRİŞ EKRANINA DÖN";
            this.backtologinbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.backtologinbutton.Click += new System.EventHandler(this.backtologinbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Patient_Follow_Up.Properties.Resources.Adsız;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 123);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 577);
            this.Controls.Add(this.backtologinbutton);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.Kayıtsifretext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kayıttckimliktext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton Registerbutton;
        private Guna.UI.WinForms.GunaTextBox Kayıtsifretext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox Kayıttckimliktext;
        private Guna.UI.WinForms.GunaButton backtologinbutton;
    }
}