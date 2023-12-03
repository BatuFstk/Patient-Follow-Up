namespace Patient_Follow_Up
{
    partial class LoginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tckimliktextbox = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sifretextbox = new Guna.UI.WinForms.GunaTextBox();
            this.LoginButton = new Guna.UI.WinForms.GunaButton();
            this.BacktoregisterButton = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(949, 125);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Patient_Follow_Up.Properties.Resources.Adsız;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 125);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // Tckimliktextbox
            // 
            this.Tckimliktextbox.BackColor = System.Drawing.Color.Transparent;
            this.Tckimliktextbox.BaseColor = System.Drawing.Color.White;
            this.Tckimliktextbox.BorderColor = System.Drawing.Color.CadetBlue;
            this.Tckimliktextbox.BorderSize = 3;
            this.Tckimliktextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tckimliktextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.Tckimliktextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Tckimliktextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Tckimliktextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tckimliktextbox.Location = new System.Drawing.Point(338, 227);
            this.Tckimliktextbox.Name = "Tckimliktextbox";
            this.Tckimliktextbox.PasswordChar = '\0';
            this.Tckimliktextbox.Radius = 10;
            this.Tckimliktextbox.SelectedText = "";
            this.Tckimliktextbox.Size = new System.Drawing.Size(358, 47);
            this.Tckimliktextbox.TabIndex = 1;
            this.Tckimliktextbox.TextChanged += new System.EventHandler(this.Tckimliktextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(173, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC KİMLİK NO : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(262, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ŞİFRE :";
            // 
            // Sifretextbox
            // 
            this.Sifretextbox.BackColor = System.Drawing.Color.Transparent;
            this.Sifretextbox.BaseColor = System.Drawing.Color.White;
            this.Sifretextbox.BorderColor = System.Drawing.Color.CadetBlue;
            this.Sifretextbox.BorderSize = 3;
            this.Sifretextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sifretextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.Sifretextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Sifretextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Sifretextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Sifretextbox.Location = new System.Drawing.Point(338, 292);
            this.Sifretextbox.Name = "Sifretextbox";
            this.Sifretextbox.PasswordChar = '●';
            this.Sifretextbox.Radius = 10;
            this.Sifretextbox.SelectedText = "";
            this.Sifretextbox.Size = new System.Drawing.Size(358, 47);
            this.Sifretextbox.TabIndex = 4;
            this.Sifretextbox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.AnimationHoverSpeed = 0.07F;
            this.LoginButton.AnimationSpeed = 0.03F;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BaseColor = System.Drawing.Color.CadetBlue;
            this.LoginButton.BorderColor = System.Drawing.Color.Black;
            this.LoginButton.BorderSize = 2;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginButton.FocusedColor = System.Drawing.Color.Empty;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Image = null;
            this.LoginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginButton.Location = new System.Drawing.Point(452, 376);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginButton.OnHoverImage = null;
            this.LoginButton.OnPressedColor = System.Drawing.Color.Black;
            this.LoginButton.Radius = 10;
            this.LoginButton.Size = new System.Drawing.Size(160, 42);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "GİRİŞ";
            this.LoginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // BacktoregisterButton
            // 
            this.BacktoregisterButton.AnimationHoverSpeed = 0.07F;
            this.BacktoregisterButton.AnimationSpeed = 0.03F;
            this.BacktoregisterButton.BackColor = System.Drawing.Color.Transparent;
            this.BacktoregisterButton.BaseColor = System.Drawing.Color.CadetBlue;
            this.BacktoregisterButton.BorderColor = System.Drawing.Color.Black;
            this.BacktoregisterButton.BorderSize = 2;
            this.BacktoregisterButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BacktoregisterButton.FocusedColor = System.Drawing.Color.Empty;
            this.BacktoregisterButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BacktoregisterButton.ForeColor = System.Drawing.Color.Black;
            this.BacktoregisterButton.Image = null;
            this.BacktoregisterButton.ImageSize = new System.Drawing.Size(20, 20);
            this.BacktoregisterButton.Location = new System.Drawing.Point(389, 441);
            this.BacktoregisterButton.Name = "BacktoregisterButton";
            this.BacktoregisterButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BacktoregisterButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BacktoregisterButton.OnHoverForeColor = System.Drawing.Color.White;
            this.BacktoregisterButton.OnHoverImage = null;
            this.BacktoregisterButton.OnPressedColor = System.Drawing.Color.Black;
            this.BacktoregisterButton.Radius = 10;
            this.BacktoregisterButton.Size = new System.Drawing.Size(278, 42);
            this.BacktoregisterButton.TabIndex = 6;
            this.BacktoregisterButton.Text = "HESAP OLUŞTURUN";
            this.BacktoregisterButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BacktoregisterButton.Click += new System.EventHandler(this.BacktoregisterButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(423, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "GİRİŞ EKRANI";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BacktoregisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Sifretextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tckimliktextbox);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private Guna.UI.WinForms.GunaTextBox Tckimliktextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox Sifretextbox;
        private Guna.UI.WinForms.GunaButton LoginButton;
        private Guna.UI.WinForms.GunaButton BacktoregisterButton;
        private System.Windows.Forms.Label label4;
    }
}

