using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SlidingPuzzle
{
    public class PictureControler
    {

        PictureDTO picture = new PictureDTO();

        /// <summary>
        /// hàm kiểm tra tồn tại bức hình có tên pictureName
        /// </summary>
        /// <param name = "pictureName"> tên bức hình cần kiểm tra </param> 
        public bool CheckPicture(string pictureName)
        {
            bool kq = false;
            try
            {
                WebClient webClient = new WebClient();
                string CheckPicture = webClient.DownloadString("https://tame-pumps-ant.cyclic.app/users/DAL/getUsersByNamePicture/:" + pictureName);

                if (CheckPicture != "[]")
                {
                    kq = true;
                }
            }
            finally
            {
                
            }
            return kq;
        }

        /// <summary>
        /// hàm lấy thông tin bức hình có tên pictureName
        /// </summary>
        /// <param name = "pictureName"> tên bức hình cần lấy thông tin </param> 
        public PictureDTO GetDetailPicture(string pictureName)
        {

            try
            {
                WebClient webClient = new WebClient();
                string GetDetailAccount = webClient.DownloadString("https://tame-pumps-ant.cyclic.app/users//DAL/getPicByNamePicDT/:" + pictureName);
                if (GetDetailAccount != "[]")
                {
                    List<PictureDTO> pictureDTOs = JsonConvert.DeserializeObject<List<PictureDTO>>(GetDetailAccount);
                    picture = pictureDTOs[0];
                }
            }
            finally
            {
                
            }
            return picture;
        }


        /// <summary>
        /// hàm lấy thông tin tất cả bức hình
        /// </summary>
        public List<PictureDTO> GetDetailAllPicture()
        {
            List<PictureDTO> pictures = new List<PictureDTO>();
            try
            {
                WebClient webClient = new WebClient();
                string GetDetailAllPicture = webClient.DownloadString("https://tame-pumps-ant.cyclic.app/users/getPicDTAll");
                pictures = JsonConvert.DeserializeObject<List<PictureDTO>>(GetDetailAllPicture);
            }
            finally
            {
               
            }
            return pictures;
        }
    }
}
