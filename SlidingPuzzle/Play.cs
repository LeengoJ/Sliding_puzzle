using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using DTO;
namespace SlidingPuzzle
{
    public partial class Play : Form
    {
        UserDTO player;
        PictureDTO pictureSelected;

        public int score;
        public int playedTimeSecond = 0;
        public bool isWin = false;
        public bool checkBackSelectPicture = false;
        public bool isRestart = false;

        int level;
        string filePath;
        GameControl ctrl = new GameControl();
        Thread thread;
        private FlowLayoutPanel scorePanel;
        bool isPlaying = true;

        

        private string buttonTextPause = "Tạm dừng";
        private string buttonTextResume = "Tiếp tục";

        public Play(UserDTO player, PictureDTO pictureSelected, int level)
        {
            InitializeComponent();
            this.player = player;
            this.pictureSelected = pictureSelected;
            this.level = level;
            Control.CheckForIllegalCrossThreadCalls = false;
            filePath = Application.StartupPath + "\\FolderPicture\\" + pictureSelected.PictureName + ".jpg";
            pictureBoxViewPicture.Image = new Bitmap(filePath);
            pictureBoxViewPicture.Visible = false;
        }

        private void Play_Load(object sender, EventArgs e)
        {

            ctrl.SplitImage(filePath, level);
            ctrl.ShuffleTiles();
            SetGameView();
            KeyPreview = true;
            labelPlayedTime.Text = "0";
            labelPause.Text = buttonTextPause;

            thread = new Thread(PlayingTime);
            thread.IsBackground = true;
            thread.Start();
        }

        private void SetGameView()
        {

            scorePanel = new FlowLayoutPanel
            {
                Width = 200,
                Height = 500
            };

            var image = Image.FromFile(filePath);
            int size = image.Width < image.Height ? image.Width : image.Height;
            var imageCropped = new Bitmap(150, 150);
            var graphics = Graphics.FromImage(imageCropped);
            graphics.DrawImage(image, new Rectangle(0, 0, 150, 150), new Rectangle(0, 0, size, size), GraphicsUnit.Pixel);
            graphics.Flush();
            var imagePreview = new PictureBox
            {
                Image = imageCropped,
                Size = new Size(150, 150),
                Margin = new Padding(25, 60, 25, 0),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            DrawGrid();

            scorePanel.Controls.AddRange(new Control[] { imagePreview });
            grid.Controls.Add(scorePanel);
        }

        public void DrawGrid()
        {
            int size = 300 / level;

            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level; j++)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Width = size,
                        Height = size,
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(j * size, i * size),
                    };
                    if (i != ctrl.VoidJ || j != ctrl.VoidI)
                    {
                        pictureBox.Image = ctrl.Matrix[j, i].TileImage;
                    }
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    grid.Controls.Add(pictureBox);
                }
            }
        }

        /// <summary>
        /// method that visually shifts tiles which changed location in the Move method from the controller
        /// </summary>
        private void ChangeMovedTileLocation()
        {
            int index = 0;
            foreach (Control pb in grid.Controls)
            {
                if (!(pb is PictureBox)) continue;
                double fraction = index / level;
                int i = Convert.ToInt32(Math.Floor(fraction));
                int j = index % level;

                if (i != ctrl.VoidJ || j != ctrl.VoidI)
                {
                    ((PictureBox)pb).Image = ctrl.Matrix[j, i].TileImage;

                }
                else
                {
                    ((PictureBox)pb).Image = null;
                }
                index++;
            }
        }

        /// <summary>
        /// method that executes on game over
        /// </summary>
        private void EndGame()
        {
            var image = Image.FromFile(filePath);
            int size = image.Width < image.Height ? image.Width : image.Height;
            var imageCropped = new Bitmap(300, 300);
            var graphics = Graphics.FromImage(imageCropped);
            graphics.DrawImage(image, new Rectangle(0, 0, 300, 300), new Rectangle(0, 0, size, size), GraphicsUnit.Pixel);
            graphics.Flush();
            var completedPicture = new PictureBox
            {
                Width = 300,
                Height = 300,
                Image = imageCropped,
            };
            grid.Controls.Clear();
            grid.Controls.Add(completedPicture);

            score = ctrl.Score;
            isWin = true;
            this.Close();

        }
        private void RestartButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Play_Load(sender, e);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            this.Close();
        }

        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            if (isPlaying)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        {
                            ctrl.Move(0, -1);
                            ChangeMovedTileLocation();
                            scoreLabel.Text = ctrl.Score.ToString();
                            if (ctrl.GameOver())
                            {
                                EndGame();
                            }
                            break;
                        }
                    case Keys.Up:
                        {
                            ctrl.Move(0, 1);
                            ChangeMovedTileLocation();
                            scoreLabel.Text = ctrl.Score.ToString();
                            if (ctrl.GameOver())
                            {
                                EndGame();
                            }
                            break;
                        }
                    case Keys.Left:
                        {
                            ctrl.Move(1, 0);
                            ChangeMovedTileLocation();
                            scoreLabel.Text = ctrl.Score.ToString();
                            if (ctrl.GameOver())
                            {
                                EndGame();
                            }
                            break;
                        }
                    case Keys.Right:
                        {
                            ctrl.Move(-1, 0);
                            ChangeMovedTileLocation();
                            scoreLabel.Text = ctrl.Score.ToString();
                            if (ctrl.GameOver())
                            {
                                EndGame();
                            }
                            break;
                        }
                }
            }
        }

/*        private void Play_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
            }
        }*/


        void PlayingTime()
        {
            try
            {
                for (int i = 0; ; i++)
                {
                    playedTimeSecond++;
                    labelPlayedTime.Text = ConvertTime(playedTimeSecond);
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }
            finally
            {

            }
        }

        private void buttonViewPicture_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxViewPicture.Visible = false;
        }

        private void buttonViewPicture_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxViewPicture.Visible = true;
        }

        private string ConvertTime(int seconds)
        {
            string second = Convert.ToString(seconds % 60);
            string minute = Convert.ToString(seconds / 60 % 60);
            string hour = Convert.ToString(seconds / 3600);
            if(hour != "0")
            {
               return hour + "h " + minute + "m " + second + "s";
            }
            return minute + "m " + second + "s";
        }



        private void labelPause_Click(object sender, EventArgs e)
        {
            if (labelPause.Text == buttonTextPause)
            {
                labelPause.Text = buttonTextResume;
                thread.Suspend();
               
                pictureBoxViewPicture.Visible = true;
                labelViewPicture.Visible = false;
                isPlaying = false;
            }
            else
            {
                labelPause.Text = buttonTextPause;
                thread.Resume();
                pictureBoxViewPicture.Visible = false;
                labelViewPicture.Visible = true;
                isPlaying = true;

            }
        }

        private void labelViewPicture_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxViewPicture.Visible = false;
        }

        private void labelViewPicture_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxViewPicture.Visible = true;
        }

        private void buttonBackSelectPicture_Click(object sender, EventArgs e)
        {
            checkBackSelectPicture = true;
            this.Close();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            this.Close();
            isRestart = true;
        }
    }

}

