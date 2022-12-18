using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;


namespace SlidingPuzzle
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();

        }

        private void SignIn_Load(object sender, EventArgs e)
        {
           
            linkLabelSignInAndSignUp.Text = linkLabelTextSignUp;
            linkLabelHiđePassword.Text = linkLabelTextPassWordUnhide;
            textBoxPassWord.PasswordChar = '*';
            labelWarning.Text = signInFailed;
            labelWarning.Visible = false;
            labelWarning.ForeColor = Color.Red;

        }

        public bool checkSignIn = false;
        public UserDTO userDTO = new UserDTO();
        public UserControler userControler = new UserControler();   

        private string linkLabelTextSignUp = "Chưa có tài khoản? Đăng Ký.";
        private string linkLabelTextSignIn = "Đã có tài khoản? Đăng nhập.";
        private string groupBoxTextSingIn = "Đăng nhập";
        private string groupBoxTextSingUp = "Đăng ký";
        private string linkLabelTextPassWordHide = "Ẩn mật khẩu";
        private string linkLabelTextPassWordUnhide = "Hiện mật khẩu";
        private string signInFailed = "Sai tên đăng nhập hoặc mật khẩu";
        private string signUpFailed = "Tên đăng nhập hoặc mật khấu không để trống";
        private string userNameExist = "Tên đăng nhập đã tồn tại";
        private string signUpSuccessful = "Tạo tài khoản thành công!";
        private string textUserNameFailed = "Tên đăng nhập không có chữ có dấu, ký tự đặc biệt, khoảng trắng";
        private string textPasswordFailed = "Mật khẩu không có chữ có dấu, khoảng trắng";

        /// <summary>
        /// hàm kiểm tra chuỗi ký tự có chứa kí tự Unicode
        /// </summary>
        /// <param name = "input"> chuỗi cần kiểm tra </param> 
        private bool IsUnicode(string input)
        {
            return Encoding.ASCII.GetByteCount(input) != Encoding.UTF8.GetByteCount(input);
        }

        /// <summary>
        /// hàm kiểm tra tên người dùng khi nhập
        /// </summary>
        /// <param name = "s" > chuỗi cần kiểm tra </param> 
        private bool CheckTextUserName(string s)
        {

            if (IsUnicode(s))
            {
                return false;
            }
            bool check = true;
            // kiểm tra ký tự chỉ là số hoặc chữ và không có khoảng trắng
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                {
                    check = false;
                }
            }
            return check;
        }
        /// <summary>
        /// hàm kiểm tra mật khẩu người dùng khi nhập
        /// </summary>
        /// <param name = "s" > chuỗi cần kiểm tra </param> 
        private bool CheckTextPassWord(string s)
        {
            if (IsUnicode(s))
            {
                return false;
            }
            bool check = true;
            // kiểm tra mật khẩu không có khoảng trắng
            foreach (char c in s)
            {
                if (Char.IsWhiteSpace(c))
                {
                    check = false;
                }
            }
            return check;
        }

 
        
        // Hàm nhấn đăng nhập hoặc đăng ký
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            // kiểm tra userName và Password không trống
            if (textBoxUserName.Text == "" || textBoxPassWord.Text == "")
            {
                labelWarning.Text = signUpFailed;
                labelWarning.Visible = true;

            }
            // kiểm tra định dạng UserName
            else if (!CheckTextUserName(textBoxUserName.Text))
            {
                labelWarning.Text = textUserNameFailed;
                labelWarning.Visible = true;
            }
            // kiểm tra định dạng Password
            else if (!CheckTextPassWord(textBoxPassWord.Text))
            {
                labelWarning.Text = textPasswordFailed;
                labelWarning.Visible = true;
            }
            else
            {
                // Đăng nhập
                if (buttonSignIn.Text == groupBoxTextSingIn)
                {
                    if (!userControler.CheckAccount(textBoxUserName.Text, textBoxPassWord.Text))
                    {
                        labelWarning.Text = signInFailed;
                        labelWarning.Visible = true;
                    }
                    else
                    {
                        userDTO = userControler.GetDetailAccount(textBoxUserName.Text, textBoxPassWord.Text);
                        checkSignIn = true;
                        this.Close();
                    }

                }
                // Đăng ký
                else
                {

                    if (userControler.CheckUser(textBoxUserName.Text))
                    {
                        labelWarning.Text = userNameExist;
                        labelWarning.Visible = true;

                    }
                    else
                    {
                        if (userControler.CreateAccount(textBoxUserName.Text, textBoxPassWord.Text))
                        {
                            labelWarning.Text = signUpSuccessful;
                            labelWarning.Visible = true;
                        }
                    }

                }
            }




        }
        /// <summary>
        /// hàm ẩn hoặc hiển thị mật khẩu
        /// </summary>
        private void linkLabelHiđePassword_LinkClicked(object sender, EventArgs e)
        {

            if (linkLabelHiđePassword.Text == linkLabelTextPassWordHide)
            {
                linkLabelHiđePassword.Text = linkLabelTextPassWordUnhide;
                textBoxPassWord.PasswordChar = '*';
            }
            else
            {
                linkLabelHiđePassword.Text = linkLabelTextPassWordHide;
                textBoxPassWord.PasswordChar = '\0';
            }
        }
        // tắt cảnh cáo 
        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
        }

        private void textBoxPassWord_TextChanged(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
        }



        /// <summary>
        /// hàm chuyển giữa đăng nhập và đăng ký
        /// </summary>
        private void linkLabelSignInAndSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelWarning.Visible = false;
            textBoxUserName.Text = null;
            textBoxPassWord.Text = null;
            // Đăng nhập
            if (linkLabelSignInAndSignUp.Text == linkLabelTextSignUp)
            {
                groupBoxSignIn.Text = groupBoxTextSingUp;
                buttonSignIn.Text = groupBoxTextSingUp;
                linkLabelSignInAndSignUp.Text = linkLabelTextSignIn;
            }
            // Đăng ký
            else
            {
                groupBoxSignIn.Text = groupBoxTextSingIn;
                buttonSignIn.Text = groupBoxTextSingIn;
                linkLabelSignInAndSignUp.Text = linkLabelTextSignUp;
            }
        }
    }
}