using DTO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace SlidingPuzzle
{
    public partial class SelectPicture : Form
    {
        public SelectPicture()
        {
            InitializeComponent();
            
        }

        private void SelectPicture_Load(object sender, EventArgs e)
        {
            GetAllPicture();
            LoadImageList();
            LoadImageName();
            LoadListView();
            LoadImage();
            LoadComboBoxLevel();
            comboBoxNamePicture.SelectedIndex = 0;
            comboBoxLevel.SelectedIndex = 0;
        }

        public bool checkSelectPicture = false;
        public bool checkBackLogin = false;

        List<string> levelString = new List<string>() { "2 * 2", "3 * 3", "4 * 4", "5 * 5", "6 * 6"};
        List<int> levelInt = new List<int>() { 2, 3, 4, 5, 6};
        
        
        public PictureDTO pictureDTO = new PictureDTO();
        PictureControler  pictureControler = new PictureControler();
      //  PictureBAL pictureBAL = new PictureBAL();

        List<PictureDTO> pictureDTOs = new List<PictureDTO>();
        public int level = 2;

        List<string> pictureName = new List<string>();
        ImageList imageList;

        void LoadComboBoxLevel()
        {
            comboBoxLevel.DataSource = levelString;
        }
        void GetAllPicture()
        {
            pictureDTOs = pictureControler.GetDetailAllPicture();
            pictureName = pictureDTOs.Select(x => x.PictureName).ToList();
        }

        void LoadImageList()
        {
            imageList = new ImageList() { ImageSize = new Size(130, 130) };
            foreach (string image in pictureName)
            {
                imageList.Images.Add(new Bitmap(Application.StartupPath + "\\FolderPicture\\" + image + ".jpg"));
            }
        }

       void LoadListView()
        {
            listView.View = View.LargeIcon;
            listView.LargeImageList = imageList;

            List<ListViewItem> item = new List<ListViewItem>();
            for (int i = 0; i < pictureName.Count; i++)
            {
                ListViewItem temp = new ListViewItem();
                temp.Text = pictureName[i];
                temp.ImageIndex = i;
                item.Add(temp);
                listView.Items.Add(item[i]);
            }
        }

        void LoadImageName()
        {
            comboBoxNamePicture.DataSource = pictureName;
        }

        void LoadImage()
        {
            pictureBox.Image = (new Bitmap(Application.StartupPath + "\\FolderPicture\\" + pictureName[0] + ".jpg"));
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;

            if (listView.SelectedItems.Count > 0)
            {
                comboBoxNamePicture.SelectedIndex = listView.SelectedItems[0].Index;
                comboBoxLevel.SelectedIndex = 0;
            }
        }

        private void comboBoxNamePicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\FolderPicture\\" + comboBoxNamePicture.SelectedValue.ToString() + ".jpg");
                pictureBox.Image = bitmap;
                
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            pictureDTO = pictureControler.GetDetailPicture(comboBoxNamePicture.Text);
            level = levelInt[comboBoxLevel.SelectedIndex];
            checkSelectPicture = true;
            this.Close();
        }

        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            checkBackLogin = true;
            this.Close();
        }
    }
}
