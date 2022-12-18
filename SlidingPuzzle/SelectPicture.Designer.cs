namespace SlidingPuzzle
{
    partial class SelectPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPicture));
            this.listView = new System.Windows.Forms.ListView();
            this.LargeIconImageList = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.comboBoxNamePicture = new System.Windows.Forms.ComboBox();
            this.labelSelectNamePicture = new System.Windows.Forms.Label();
            this.labelSelectLevel = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonBackLogin = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.LargeIconImageList;
            this.listView.Location = new System.Drawing.Point(73, 461);
            this.listView.Margin = new System.Windows.Forms.Padding(10);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(853, 234);
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // LargeIconImageList
            // 
            this.LargeIconImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.LargeIconImageList.ImageSize = new System.Drawing.Size(140, 140);
            this.LargeIconImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.Location = new System.Drawing.Point(554, 753);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(104, 24);
            this.comboBoxLevel.TabIndex = 2;
            // 
            // comboBoxNamePicture
            // 
            this.comboBoxNamePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNamePicture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNamePicture.Location = new System.Drawing.Point(129, 753);
            this.comboBoxNamePicture.Name = "comboBoxNamePicture";
            this.comboBoxNamePicture.Size = new System.Drawing.Size(361, 24);
            this.comboBoxNamePicture.TabIndex = 1;
            this.comboBoxNamePicture.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamePicture_SelectedIndexChanged);
            // 
            // labelSelectNamePicture
            // 
            this.labelSelectNamePicture.AutoSize = true;
            this.labelSelectNamePicture.Location = new System.Drawing.Point(126, 728);
            this.labelSelectNamePicture.Name = "labelSelectNamePicture";
            this.labelSelectNamePicture.Size = new System.Drawing.Size(93, 16);
            this.labelSelectNamePicture.TabIndex = 9;
            this.labelSelectNamePicture.Text = "Chọn hình ảnh:";
            // 
            // labelSelectLevel
            // 
            this.labelSelectLevel.AutoSize = true;
            this.labelSelectLevel.Location = new System.Drawing.Point(551, 728);
            this.labelSelectLevel.Name = "labelSelectLevel";
            this.labelSelectLevel.Size = new System.Drawing.Size(82, 16);
            this.labelSelectLevel.TabIndex = 10;
            this.labelSelectLevel.Text = "Chọn độ khó";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("#9Slide01 Tieu de ngan", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(750, 736);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(154, 56);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Bắt đầu chơi";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonBackLogin
            // 
            this.buttonBackLogin.Image = global::SlidingPuzzle.Properties.Resources.pngtree_logout_line_icon_vectors_png_image_17378672;
            this.buttonBackLogin.Location = new System.Drawing.Point(952, 24);
            this.buttonBackLogin.Name = "buttonBackLogin";
            this.buttonBackLogin.Size = new System.Drawing.Size(50, 50);
            this.buttonBackLogin.TabIndex = 11;
            this.buttonBackLogin.UseVisualStyleBackColor = true;
            this.buttonBackLogin.Click += new System.EventHandler(this.buttonBackLogin_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(73, 62);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(853, 386);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // SelectPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1027, 821);
            this.Controls.Add(this.buttonBackLogin);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelSelectLevel);
            this.Controls.Add(this.labelSelectNamePicture);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.comboBoxNamePicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sliding Puzzle - Select picture";
            this.Load += new System.EventHandler(this.SelectPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList LargeIconImageList;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.ComboBox comboBoxNamePicture;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelSelectNamePicture;
        private System.Windows.Forms.Label labelSelectLevel;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonBackLogin;
    }
}