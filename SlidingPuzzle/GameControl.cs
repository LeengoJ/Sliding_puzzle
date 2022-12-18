using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingPuzzle
{
    public  class GameControl
    {
        public Tile[,] Matrix { get; set; }
        public int VoidI { get; set; }
        public int VoidJ { get; set; }
        public int Score { get; set; }


        /// <summary>
        /// hàm chia hình ảnh đã chọn thành một ma trận các ô
        /// </summary>
        /// <param name = "imagePath"> đường dẫn của hình ảnh đã chọn </param> 
        /// <param name = "level"> độ khó để chia hình ảnh thành </param> 
        public void SplitImage(String imagePath, int level)
        {
            //tải hình ảnh và cắt nó theo tỷ lệ 1: 1
            var image = Image.FromFile(imagePath);
            int size = 0;
            if (image.Width < image.Height)
            {
                size = image.Width / level;
            }
            else
            {
                size = image.Height / level;
            };

            //chia hình ảnh thành nhiều phần
            var imageArray = new Image[level * level];
            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level; j++)
                {
                    var index = i * level + j;
                    imageArray[index] = new Bitmap(size, size);
                    var graphics = Graphics.FromImage(imageArray[index]);
                    graphics.DrawImage(image, new Rectangle(0, 0, size, size),
                                        new Rectangle(i * size, j * size, size, size), GraphicsUnit.Pixel);
                    graphics.Flush();
                }
            }

            //tạo một ô cho mỗi hình ảnh và gán nó vào Ma trận
            Matrix = new Tile[level, level];
            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level; j++)
                {
                    Matrix[i, j] = new Tile(imageArray[i * level + j], i, j);
                }
            }

            //loại bỏ một ô dưới cùng bên phải
            VoidI = level - 1;
            VoidJ = level - 1;
            Matrix[VoidI, VoidJ] = null;
        }


        /// <summary>
        /// hàm trộn các ô nhỏ
        /// </summary>
        public void ShuffleTiles()
        {
            Random rand = new Random();
            int i = 0;
            double gridsize = Math.Sqrt(Matrix.Length);
            //shuffle at least 100 times, until the empty tile is at bottom right corner
            while (i < 100 || VoidI != gridsize - 1 || VoidJ != gridsize - 1)
            {
                int randomHShift = rand.Next(-1, 2);
                int randomVShift = rand.Next(-1, 2);
                if (Math.Abs(randomHShift + randomVShift) == 1)
                {
                    Move(randomHShift, randomVShift);
                    i++;
                }
            }
            Score = 0;
        }


        /// <summary>
        /// hàm di chuyển các ô vào ô trống
        /// </summary>
        /// <param name="horizontalShift"> chỉ định hướng chuyển động ngang </param> 
        /// <param name="verticatShift">  chỉ định hướng chuyển động dọc</param>
        public void Move(int horizontalShift, int verticatShift)
        {
            //lấy các chỉ số của ô để di chuyển
            int movedTileI = VoidI + horizontalShift;
            int movedTileJ = VoidJ + verticatShift;

            //đảm bảo rằng các chỉ số ô không nằm ngoài giới hạn của Ma trận
            if ((movedTileI >= 0 && movedTileI < Math.Sqrt(Matrix.Length)) && (movedTileJ >= 0 && movedTileJ < Math.Sqrt(Matrix.Length)))
            {
                Matrix[VoidI, VoidJ] = Matrix[movedTileI, movedTileJ];
                Matrix[movedTileI, movedTileJ] = null;
                VoidI = movedTileI;
                VoidJ = movedTileJ;
                Score++;
            }
        }


        /// <summary>
        /// hàm kiểm tra xem vị trí của tất cả các ô trong Ma trận có khớp với vị trí ban đầu của chúng hay không
        /// </summary>
        /// <returns> true khi điều kiện được đáp ứng cho tất cả các ô, có nghĩa là trò chơi đã kết thúc,
        ///           false otherwise   </returns>
        public bool GameOver()
        {
            for (int i = 0; i < Math.Sqrt(Matrix.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(Matrix.Length); j++)
                {
                    if (Matrix[i, j] != null && (Matrix[i, j].I != i || Matrix[i, j].J != j))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

