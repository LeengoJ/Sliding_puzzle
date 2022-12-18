using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SlidingPuzzle
{
    public partial class Win : Form
    {
        UserDTO userDTO = new UserDTO();
        PictureDTO pictureDTO = new PictureDTO();
        List<WinnerDTO> winnerList = new List<WinnerDTO>(5) { new WinnerDTO(), new WinnerDTO(), new WinnerDTO(), new WinnerDTO(), new WinnerDTO() };
        WinnerControler winnerControler = new WinnerControler();
        UserControler userControler = new UserControler();
        int level;
        int point;
        int time;

        public bool checkBackLogIn = false;
        public bool checkBackSelectPicture = false;
        string filePath;
        public Win(UserDTO user, PictureDTO picture, int level, int point, int time)
        {
            InitializeComponent();
            this.userDTO = user;
            this.pictureDTO = picture;
            this.level = level;
            this.point = point;
            this.time = time;
        }



        private void Win_Load(object sender, EventArgs e)
        {
            ShowUserWinner();
            AddWinner();
            GetFiveWinner();
            filePath = Application.StartupPath + "\\FolderPicture\\" + pictureDTO.PictureName + ".jpg";
            pictureBoxPicturePlayed.Image = new Bitmap(filePath);
            labelWinner1st.Text = labelWinner2nd.Text = labelWinner3rd.Text = labelWinner4th.Text = labelWinner5th.Text = "";
            labelUserName1st.Text = labelUserName2nd.Text = labelUserName3rd.Text = labelUserName4th.Text = labelUserName5th.Text = "";
            labelPoint1st.Text = labelPoint2nd.Text = labelPoint3rd.Text = labelPoint4th.Text = labelPoint5th.Text = "";
            labelTime1st.Text = labelTime2nd.Text = labelTime3rd.Text = labelTime4th.Text = labelTime5th.Text = "";
            ShowWinner();
        }

        private void AddWinner()
        {
            if (winnerControler.CheckWinner(userDTO.UserID, pictureDTO.PictureID, level))
            {
                WinnerDTO temp = new WinnerDTO();
                temp = winnerControler.GetDetailWinner(userDTO.UserID, pictureDTO.PictureID, level);

                if (temp.Point > point)
                {
                    winnerControler.UpdateWinnerPoint(userDTO.UserID, pictureDTO.PictureID, level, point, time);
                    winnerControler.UpdateWinnerTime(userDTO.UserID, pictureDTO.PictureID, level, point, time);
                }
                if (temp.Point == point && temp.TimeSecond > time)
                {
                    winnerControler.UpdateWinnerTime(userDTO.UserID, pictureDTO.PictureID, level,point, time);
                }
            }
            else winnerControler.CreateWinner(userDTO.UserID, pictureDTO.PictureID, level, point, time);
        }


        public void ShowUserWinner()
        {
            labelUserName.Text = userDTO.UserName;
            labelPictureName.Text = pictureDTO.PictureName;
            labelLevel.Text = level.ToString();
            labelPoint.Text = point.ToString();
            labelTime.Text = time.ToString();
        }

        private void GetFiveWinner()
        {
            winnerList = winnerControler.GetDetail5Winner(pictureDTO.PictureID, level);
        }

        private void ShowWinner()
        {
            labelTitle.Text = $"{"Thứ Tự Hạng",-24}" + $"{"Tên người chơi",-50}" + $"{"Số lần di chuyển",14}" + $"{"Thời Gian",15}";
            int count = 1;
            if (count <= winnerList.Count)
            {
                labelWinner1st.Text = "Hạng 1";
                labelUserName1st.Text = userControler.GetDetailAccountByID(winnerList[0].UserID).UserName;
                labelPoint1st.Text = winnerList[0].Point.ToString();
                labelTime1st.Text = winnerList[0].TimeSecond.ToString();
                
                count++;

            }
            if (count <= winnerList.Count)
            {

                labelWinner2nd.Text = "Hạng 2";
                labelUserName2nd.Text = userControler.GetDetailAccountByID(winnerList[1].UserID).UserName;
                labelPoint2nd.Text = winnerList[1].Point.ToString();
                labelTime2nd.Text = winnerList[1].TimeSecond.ToString();
                count++;
            }
            if (count <= winnerList.Count)
            {

                labelWinner3rd.Text = "Hạng 3";
                labelUserName3rd.Text = userControler.GetDetailAccountByID(winnerList[2].UserID).UserName;
                labelPoint3rd.Text = winnerList[2].Point.ToString();
                labelTime3rd.Text = winnerList[2].TimeSecond.ToString();
                count++;
            }
            if (count <= winnerList.Count)
            {

                labelWinner4th.Text = "Hạng 4";
                labelUserName4th.Text = userControler.GetDetailAccountByID(winnerList[3].UserID).UserName;
                labelPoint4th.Text = winnerList[3].Point.ToString();
                labelTime4th.Text = winnerList[3].TimeSecond.ToString();
                count++;
            }
            if (count <= winnerList.Count)
            {

                labelWinner5th.Text = "Hạng 5";
                labelUserName5th.Text = userControler.GetDetailAccountByID(winnerList[4].UserID).UserName;
                labelPoint5th.Text = winnerList[4].Point.ToString();
                labelTime5th.Text = winnerList[4].TimeSecond.ToString();
                count++;
            }
        }

        private void buttonBackSelectPicture_Click(object sender, EventArgs e)
        {
            this.Close();
            checkBackSelectPicture = true;
        }

        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            checkBackLogIn = true;
        }
    }
}
