namespace SlidingPuzzle
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.labelSlidingPuzzle = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelSignInAndSignUp = new System.Windows.Forms.LinkLabel();
            this.groupBoxSignIn = new System.Windows.Forms.GroupBox();
            this.labelWarning = new System.Windows.Forms.Label();
            this.linkLabelHiđePassword = new System.Windows.Forms.LinkLabel();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.groupBoxSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSlidingPuzzle
            // 
            this.labelSlidingPuzzle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSlidingPuzzle.AutoSize = true;
            this.labelSlidingPuzzle.BackColor = System.Drawing.Color.Transparent;
            this.labelSlidingPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlidingPuzzle.ForeColor = System.Drawing.Color.Black;
            this.labelSlidingPuzzle.Location = new System.Drawing.Point(278, 47);
            this.labelSlidingPuzzle.Name = "labelSlidingPuzzle";
            this.labelSlidingPuzzle.Size = new System.Drawing.Size(285, 46);
            this.labelSlidingPuzzle.TabIndex = 0;
            this.labelSlidingPuzzle.Text = "Sliding Puzzle";
            this.labelSlidingPuzzle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(233, 63);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(235, 26);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(233, 127);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.Size = new System.Drawing.Size(235, 26);
            this.textBoxPassWord.TabIndex = 2;
            this.textBoxPassWord.TextChanged += new System.EventHandler(this.textBoxPassWord_TextChanged);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.ForeColor = System.Drawing.Color.Black;
            this.labelUserName.Location = new System.Drawing.Point(73, 63);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(130, 20);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu:";
            // 
            // linkLabelSignInAndSignUp
            // 
            this.linkLabelSignInAndSignUp.AutoSize = true;
            this.linkLabelSignInAndSignUp.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelSignInAndSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSignInAndSignUp.Location = new System.Drawing.Point(494, 419);
            this.linkLabelSignInAndSignUp.Name = "linkLabelSignInAndSignUp";
            this.linkLabelSignInAndSignUp.Size = new System.Drawing.Size(69, 20);
            this.linkLabelSignInAndSignUp.TabIndex = 4;
            this.linkLabelSignInAndSignUp.TabStop = true;
            this.linkLabelSignInAndSignUp.Text = "Đăng ký";
            this.linkLabelSignInAndSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignInAndSignUp_LinkClicked);
            // 
            // groupBoxSignIn
            // 
            this.groupBoxSignIn.BackColor = System.Drawing.Color.White;
            this.groupBoxSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxSignIn.Controls.Add(this.labelWarning);
            this.groupBoxSignIn.Controls.Add(this.linkLabelHiđePassword);
            this.groupBoxSignIn.Controls.Add(this.buttonSignIn);
            this.groupBoxSignIn.Controls.Add(this.label2);
            this.groupBoxSignIn.Controls.Add(this.labelUserName);
            this.groupBoxSignIn.Controls.Add(this.textBoxPassWord);
            this.groupBoxSignIn.Controls.Add(this.textBoxUserName);
            this.groupBoxSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSignIn.Location = new System.Drawing.Point(85, 135);
            this.groupBoxSignIn.Name = "groupBoxSignIn";
            this.groupBoxSignIn.Size = new System.Drawing.Size(660, 260);
            this.groupBoxSignIn.TabIndex = 2;
            this.groupBoxSignIn.TabStop = false;
            this.groupBoxSignIn.Text = "Đăng Nhập";
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Location = new System.Drawing.Point(25, 231);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(71, 20);
            this.labelWarning.TabIndex = 11;
            this.labelWarning.Text = "Warning";
            // 
            // linkLabelHiđePassword
            // 
            this.linkLabelHiđePassword.AutoSize = true;
            this.linkLabelHiđePassword.Location = new System.Drawing.Point(501, 133);
            this.linkLabelHiđePassword.Name = "linkLabelHiđePassword";
            this.linkLabelHiđePassword.Size = new System.Drawing.Size(117, 20);
            this.linkLabelHiđePassword.TabIndex = 10;
            this.linkLabelHiđePassword.TabStop = true;
            this.linkLabelHiđePassword.Text = "Hiện mật khẩu";
            this.linkLabelHiđePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHiđePassword_LinkClicked);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(473, 176);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(145, 40);
            this.buttonSignIn.TabIndex = 3;
            this.buttonSignIn.Text = "Đăng nhập";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SlidingPuzzle.Properties.Resources.gradienta_LeG68PrXA6Y_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(814, 512);
            this.Controls.Add(this.groupBoxSignIn);
            this.Controls.Add(this.linkLabelSignInAndSignUp);
            this.Controls.Add(this.labelSlidingPuzzle);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sliding Puzzle - Sign In";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.groupBoxSignIn.ResumeLayout(false);
            this.groupBoxSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSlidingPuzzle;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelSignInAndSignUp;
        private System.Windows.Forms.GroupBox groupBoxSignIn;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.LinkLabel linkLabelHiđePassword;
        private System.Windows.Forms.Label labelWarning;
    }
}

