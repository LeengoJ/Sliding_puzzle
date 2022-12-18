using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace SlidingPuzzle
{
    public class WinnerControler
    {

        public WinnerDTO winner = new WinnerDTO();
        public bool CheckWinner(int userID, int pictureID, int level)
        {


            bool kq = false;
            try
            {
                WebClient webClient = new WebClient();
                string checkWinner = webClient.DownloadString("https://tame-pumps-ant.cyclic.app/users/DAL/getWinnersByUid_Pid_lv/:" + userID + "/:" + pictureID + "/:" + level);

                if (checkWinner != "[]")
                {
                    kq = true;
                }
            }
            finally
            {

            }
            return kq;
        }

        public WinnerDTO GetDetailWinner(int userID, int pictureID, int level)
        {

            try
            {
                WebClient webClient = new WebClient();
                string getWinner = webClient.DownloadString("https://tame-pumps-ant.cyclic.app/users/DAL/getWinnersByUid_Pid_lv/:" + userID + "/:" + pictureID + "/:" + level);

                if (getWinner != "[]")
                {
                    List<WinnerDTO> listUser = JsonConvert.DeserializeObject<List<WinnerDTO>>(getWinner);

                    winner = listUser[0];
                }
            }
            finally
            {

            }
            return winner;
        }




        public bool CreateWinner(int userID, int pictureID, int level, int point, int time)
        {
            bool kq = false;
            try
            {
                WebClient webClient = new WebClient();
                string createWinner = webClient.UploadString("https://tame-pumps-ant.cyclic.app/users/DAL/InsertWinner/:" + userID + ":" + pictureID + ":" + level + ":" + point + ":" + time, "POST", "");

                if (createWinner != "[]")
                {
                    kq = true;
                }
            }
            finally
            {

            }
            return kq;
        }


        public List<WinnerDTO> GetDetail5Winner(int pictureID, int level)
        {
            List<WinnerDTO> winners = new List<WinnerDTO>();
            try
            {
                WebClient webClient = new WebClient();
                string GetDetailFiveWinner = webClient.DownloadString("https://tame-pumps-ant.cyclic.app/users/DAL/GetDeTailFiveWinner/:" + pictureID + "/:" + level);
                winners = JsonConvert.DeserializeObject<List<WinnerDTO>>(GetDetailFiveWinner);
            }
            finally
            {

            }
            return winners;
        }




        public bool UpdateWinnerPoint(int userID, int pictureID, int level, int point, int time)
        {
            bool kq = false;
            try
            {
                WebClient webClient = new WebClient();
                string createWinner = webClient.UploadString("https://tame-pumps-ant.cyclic.app/users/DAL/UpdateWinner/point/:" + userID + ":" + pictureID + ":" + level + ":" + point + ":" + time, "POST", "");

                if (createWinner != "[]")
                {
                    kq = true;
                }
            }
            finally
            {

            }
            return kq;
        }

        public bool UpdateWinnerTime(int userID, int pictureID, int level, int point, int time)
        {
            bool kq = false;
            try
            {
                WebClient webClient = new WebClient();
                string createWinner = webClient.UploadString("https://tame-pumps-ant.cyclic.app/users/DAL/UpdateWinner/time/:" + userID + ":" + pictureID + ":" + level + ":" + point + ":" + time, "POST", "");

                if (createWinner != "[]")
                {
                    kq = true;
                }
            }
            finally
            {

            }
            return kq;
        }

    }

}
