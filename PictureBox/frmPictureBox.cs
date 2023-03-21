using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x, y;

            x = pboxPicture.Location.X; // imagein ekrandaki X koordinatı

            y = pboxPicture.Location.Y; // Y koordinatı

            //MessageBox.Show("Koordinatlar : x " + x.ToString() + "y " + y.ToString());


            // klavyeden hangi tuşa basıldığını KeyEventArgs dan gelen e parametresine göre anlıyorum.
            switch (e.KeyCode)
            {
                case Keys.Left: // Sol ok tuşu

                    x = x - 10; // 10 piksel 

                    break;

                case Keys.Right: // Sağ ok tuşu

                    x = x + 10;
                    break;

                case Keys.Up:

                    y=y - 10;

                    break;

                case Keys.Down:

                    y = y + 10;

                    break;

            }

            pboxPicture.Location = new Point(x, y); 
        }
    }
}
