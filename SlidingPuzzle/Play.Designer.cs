namespace SlidingPuzzle
{
    partial class Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.grid = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.labelPlayedTime = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.labelViewPicture = new System.Windows.Forms.Label();
            this.labelSoLuotNhan = new System.Windows.Forms.Label();
            this.labelThoiGianChoi = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonBackSelectPicture = new System.Windows.Forms.Button();
            this.pictureBoxViewPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Location = new System.Drawing.Point(84, 136);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(413, 380);
            this.grid.TabIndex = 0;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(663, 207);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(18, 20);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            // 
            // labelPlayedTime
            // 
            this.labelPlayedTime.AutoSize = true;
            this.labelPlayedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayedTime.Location = new System.Drawing.Point(663, 289);
            this.labelPlayedTime.Name = "labelPlayedTime";
            this.labelPlayedTime.Size = new System.Drawing.Size(50, 20);
            this.labelPlayedTime.TabIndex = 8;
            this.labelPlayedTime.Text = "0m0s";
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.BackColor = System.Drawing.Color.Transparent;
            this.labelPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPause.Location = new System.Drawing.Point(551, 451);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(130, 29);
            this.labelPause.TabIndex = 9;
            this.labelPause.Text = "Tạm dừng";
            this.labelPause.Click += new System.EventHandler(this.labelPause_Click);
            // 
            // labelViewPicture
            // 
            this.labelViewPicture.AutoSize = true;
            this.labelViewPicture.BackColor = System.Drawing.Color.Transparent;
            this.labelViewPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewPicture.Location = new System.Drawing.Point(530, 386);
            this.labelViewPicture.Name = "labelViewPicture";
            this.labelViewPicture.Size = new System.Drawing.Size(172, 29);
            this.labelViewPicture.TabIndex = 10;
            this.labelViewPicture.Text = "Xem hình ảnh";
            this.labelViewPicture.MouseLeave += new System.EventHandler(this.labelViewPicture_MouseLeave);
            this.labelViewPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelViewPicture_MouseMove);
            // 
            // labelSoLuotNhan
            // 
            this.labelSoLuotNhan.AutoSize = true;
            this.labelSoLuotNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuotNhan.Location = new System.Drawing.Point(531, 207);
            this.labelSoLuotNhan.Name = "labelSoLuotNhan";
            this.labelSoLuotNhan.Size = new System.Drawing.Size(107, 20);
            this.labelSoLuotNhan.TabIndex = 12;
            this.labelSoLuotNhan.Text = "Số lượt nhấn:";
            // 
            // labelThoiGianChoi
            // 
            this.labelThoiGianChoi.AutoSize = true;
            this.labelThoiGianChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThoiGianChoi.Location = new System.Drawing.Point(531, 289);
            this.labelThoiGianChoi.Name = "labelThoiGianChoi";
            this.labelThoiGianChoi.Size = new System.Drawing.Size(113, 20);
            this.labelThoiGianChoi.TabIndex = 13;
            this.labelThoiGianChoi.Text = "Thời gian chơi";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Image = global::SlidingPuzzle.Properties.Resources.restart;
            this.buttonRestart.Location = new System.Drawing.Point(615, 36);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(60, 60);
            this.buttonRestart.TabIndex = 11;
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonBackSelectPicture
            // 
            this.buttonBackSelectPicture.Image = global::SlidingPuzzle.Properties.Resources.pngtree_vector_gallery_icon_png_image_5152231;
            this.buttonBackSelectPicture.Location = new System.Drawing.Point(681, 36);
            this.buttonBackSelectPicture.Name = "buttonBackSelectPicture";
            this.buttonBackSelectPicture.Size = new System.Drawing.Size(60, 60);
            this.buttonBackSelectPicture.TabIndex = 0;
            this.buttonBackSelectPicture.TabStop = false;
            this.buttonBackSelectPicture.UseVisualStyleBackColor = true;
            this.buttonBackSelectPicture.Click += new System.EventHandler(this.buttonBackSelectPicture_Click);
            // 
            // pictureBoxViewPicture
            // 
            this.pictureBoxViewPicture.Location = new System.Drawing.Point(84, 129);
            this.pictureBoxViewPicture.Name = "pictureBoxViewPicture";
            this.pictureBoxViewPicture.Size = new System.Drawing.Size(408, 387);
            this.pictureBoxViewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxViewPicture.TabIndex = 7;
            this.pictureBoxViewPicture.TabStop = false;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(756, 633);
            this.Controls.Add(this.labelThoiGianChoi);
            this.Controls.Add(this.labelSoLuotNhan);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonBackSelectPicture);
            this.Controls.Add(this.labelViewPicture);
            this.Controls.Add(this.labelPause);
            this.Controls.Add(this.labelPlayedTime);
            this.Controls.Add(this.pictureBoxViewPicture);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.grid);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.Load += new System.EventHandler(this.Play_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Play_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel grid;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox pictureBoxViewPicture;
        private System.Windows.Forms.Label labelPlayedTime;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Label labelViewPicture;
        private System.Windows.Forms.Button buttonBackSelectPicture;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelSoLuotNhan;
        private System.Windows.Forms.Label labelThoiGianChoi;
    }
}