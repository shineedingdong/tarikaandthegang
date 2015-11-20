using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class FormView : Form
    {
       enum Position
       {
           Left,Right,Up,Down
        }
        private int _x,_a,_b;
        private int _y;
       // bool right;
      //  bool left;
        //bool up;
       // bool down;

        //private Position _objPosition;

        public FormView()
        { 
            //ตำแน่งก่อนเคลื่อนที่
            InitializeComponent();
       //
            KeyDown += new KeyEventHandler(FormView_KeyDown);
            _x = 50;
            _y = 50;
            _a = 100;
            _b = 100;
           // _objPosition = Position.Down;
        }



        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            // 100,100 คือขนาดของรูป
            e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 30, 30);
            e.Graphics.FillRectangle(Brushes.Red, _a, _b, 30, 30);
        }
        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            _y += 2;
            _b += 2;
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*  if(right == true)
              {
                  pictureBox1.Left += 5;
              }
              if(left == true)
              {
                  pictureBox1.Left -= 5;
              }
              if (up == true)
              {
                  pictureBox1 = Position.Up;
              }
              if (down == true)
              {
                  pictureBox1 = Position.Down;
              }
              */
        }

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right) x += 3;
            else if (e.KeyCode == Keys.Left) x -= 3;
            else if (e.KeyCode == Keys.Up) y -= 3;
            else if (e.KeyCode == Keys.Down) y += 3;

            pictureBox1.Location = new Point(x, y);


            /*  if (e.KeyCode == Keys.Right)
              {
                  right = true;
              }
              if(e.KeyCode == Keys.Left)
              {
                  left = true;
              }
              if (e.KeyCode == Keys.Up)
              {
                  up = true;
              }
              if (e.KeyCode == Keys.Down)
              {
                  down = true;
               } */
        }

        private void FormView_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }

        /*    private void FormView_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Left)
                {
                    _objPosition = Position.Left;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    _objPosition = Position.Right;
               }
                else if (e.KeyCode == Keys.Up)
                {
                   _objPosition = Position.Up;
                }
               else if (e.KeyCode == Keys.Down)
                {
                    _objPosition = Position.Down;
                }

            }
      */
    }
}
