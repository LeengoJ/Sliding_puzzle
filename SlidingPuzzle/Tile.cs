using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SlidingPuzzle
{
    public class Tile
    {
        // class lưu thông tin các ô nhỏ trong trò chơi: hình ảnh sau khi chia, vị trí trong ma trâjn
        public Image TileImage { get; set; }
        public int I { get; set; }
        public int J { get; set; }

        public Tile()
        {
           
        }

        public Tile(Image tileImage, int i, int j)
        {
            TileImage = tileImage;
            I = i;
            J = j;
        }
    }
}
