using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserDTO player = new UserDTO();
            PictureDTO pictureSelected = new PictureDTO();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        GoSignIn:
            SignIn signIn = new SignIn();
            Application.Run(signIn);

            if (signIn.checkSignIn)
            {
                player = signIn.userDTO;
            GoSelectPicture:
                SelectPicture selectPicture = new SelectPicture();
                Application.Run(selectPicture);

                if (selectPicture.checkSelectPicture)
                {
                    pictureSelected = selectPicture.pictureDTO;
                    int level = selectPicture.level;
                GoToPlay:
                    Play play = new Play(player, pictureSelected, level);
                    Application.Run(play);
                    if (play.isWin)
                    {
                        int score = play.score;
                        int time = play.playedTimeSecond;
                        Win win = new Win(player, pictureSelected, level, score, time);
                        Application.Run(win);
                        if (win.checkBackLogIn)
                        {
                            goto GoSignIn;
                        }
                        if (win.checkBackSelectPicture)
                        {
                            goto GoSelectPicture;
                        }

                    }
                    if (play.isRestart)
                    {
                        goto GoToPlay;
                    }
                    if (play.checkBackSelectPicture)
                    {
                        goto GoSelectPicture;
                    }
                }
                if (selectPicture.checkBackLogin)
                {
                    goto GoSignIn;
                }
            }

        }
    }
}
