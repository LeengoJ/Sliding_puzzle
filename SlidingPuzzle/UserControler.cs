using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace SlidingPuzzle
{
    public class UserControler
    {
        public UserDTO user = new UserDTO();


        /// <summary>
        /// hàm kiểm tra sự tồn tại của tài khoản
        /// </summary>
        /// <param name = "userName"> tên người dùng cần kiểm tra </param> 
        /// <param name = "password"> mật khẩu người dùng cần kiểm tra </param>  
        public bool CheckAccount(string userName, string password)
        {
            bool kq = false;
            try
            {
                WebClient webClient = new WebClient();
                string check_account = webClient.DownloadString("https://tame-pumps-ant.cyclic.app/users/DAL/getUsersByNameAndPass:" + userName + "/:" + password);

                if (check_account != "[]")
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
        /// hàm kiểm tra sự tồn tại của tên tài khoản
        /// </summary>
        /// <param name = "userName"> tên người dùng cần kiểm tra </param> 
        public bool CheckUser(string userName)
        {
            bool kq = false;
            try
            {
                WebClient webClient = new WebClient();
                string check_user = webClient.DownloadString("https://tame-pumps-ant.cyclic.app/users/DAL/getUsersByName/:" + userName);
                if (check_user != "[]")
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
        /// hàm tạo của tài khoản mới
        /// </summary>
        /// <param name = "userName"> tên người dùng cần tạo </param> 
        /// <param name = "password"> mật khẩu người dùng cần tạo </param>  
        public bool CreateAccount(string userName, string password)
        {
            bool kq = false;
            try
            {
                WebClient webClient = new WebClient();
                string check_account = webClient.UploadString("https://tame-pumps-ant.cyclic.app/users/DAL/CreateAccount:" + userName + ":" + password, "POST", "");
                if (check_account != "[]")
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
        /// hàm lấy thông tin của tài khoản
        /// </summary>
        /// <param name = "userName"> tên người dùng cần lấy thông tin </param> 
        /// <param name = "password"> mật khẩu người dùng cần lấy thông tin </param> 
        public UserDTO GetDetailAccount(string userName, string password)
        {
            try
            {
                WebClient webClient = new WebClient();
                string GetDetailAccount = webClient.DownloadString("https://tame-pumps-ant.cyclic.app/users/DAL/getUsersByNameAndPassAll/:" + userName + ":/" + password);
                if (GetDetailAccount != "[]")
                {
                    List<UserDTO> listUser = JsonConvert.DeserializeObject<List<UserDTO>>(GetDetailAccount);
                    
                    user = listUser[0];
                }
            }
            finally { }

            return user;
        }

        public UserDTO GetDetailAccountByID(int userID)
        {
           
            try
            {
                WebClient webClient = new WebClient();
                string GetDetailAccount = webClient.DownloadString("https://tame-pumps-ant.cyclic.app/users/DAL/getUsersByUserID/:" + userID );
                if (GetDetailAccount != "[]")
                {
                    List<UserDTO> listUser = JsonConvert.DeserializeObject<List<UserDTO>>(GetDetailAccount);

                    user = listUser[0];
                }
            }
            finally { }

            return user;
        }

    }



}

