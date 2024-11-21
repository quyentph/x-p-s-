using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Linq;
using System.Collections;
using System.Diagnostics;
namespace LapTrinhGame
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e) 
        { 
            lblTime.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss"); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            points = CheckPoint();
        }
        private List<Point> CheckPoint()
        {
            List<Button> buttons = Khung.Controls.OfType<Button>().ToList();
            List<Point> positions = buttons.Select(b => b.Location).ToList();
            return positions;
        }
        private List<Point> points;
        private void swapbutton(Button a, Button b)
        {
            Point temp = a.Location;
            a.Location = b.Location;
            b.Location = temp;
        }

        private bool CalculateDistance(Button a, Button b)
        {
            Point temp1 = a.Location;
            Point temp2 = b.Location;
            int distanceX = Math.Abs(temp1.X - temp2.X);
            int distanceY = Math.Abs(temp1.Y - temp2.Y);
            double kc = Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
            return kc <= 118;
        }

        private void ShuffleButtons()
        {
            List<Button> buttons = Khung.Controls.OfType<Button>().ToList();
            List<Point> positions = buttons.Select(b => b.Location).ToList();
            Random rand = new Random();
            positions = positions.OrderBy(p => rand.Next()).ToList();
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Location = positions[i];
            }
        }
        private bool checkStatus()
        {
            List<Button> buttons = Khung.Controls.OfType<Button>().ToList();
            List<Point> positions = buttons.Select(b => b.Location).ToList();
            stopwatch.Stop();
            timer.Stop();
            return points.SequenceEqual(positions);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CalculateDistance(button1, button9))
            {
                swapbutton(button1, button9);
            }
            if (checkStatus())
            {
                MessageBox.Show("Bạn đã thắng");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CalculateDistance(button2, button9))
            {
                swapbutton(button2, button9);
            }
            if (checkStatus())
            {
                MessageBox.Show("Bạn đã thắng");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CalculateDistance(button3, button9))
            {
                swapbutton(button3, button9);
            }
            if (checkStatus())
            {
                MessageBox.Show("Bạn đã thắng");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CalculateDistance(button4, button9))
            {
                swapbutton(button4, button9);
            }
            if (checkStatus())
            {
                MessageBox.Show("Bạn đã thắng");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CalculateDistance(button5, button9))
            {
                swapbutton(button5, button9);
            }
            if (checkStatus())
            {
                MessageBox.Show("Bạn đã thắng");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CalculateDistance(button6, button9))
            {
                swapbutton(button6, button9);
            }
            if (checkStatus())
            {
                MessageBox.Show("Bạn đã thắng");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (CalculateDistance(button7, button9))
            {
                swapbutton(button7, button9);
            }
            if (checkStatus())
            {
                MessageBox.Show("Bạn đã thắng");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (CalculateDistance(button8, button9))
            {
                swapbutton(button8, button9);
            }
            if (checkStatus())
            {
                MessageBox.Show("Bạn đã thắng");
            }
        }
        private void buttonChooseImage_Click()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\AD\\Downloads\\"; 
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"; 
                openFileDialog.FilterIndex = 2; 
                openFileDialog.RestoreDirectory = true; 
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { // Lấy đường dẫn file được chọn
                    string filePath = openFileDialog.FileName;
                    // Gán hình ảnh vào
                    pictureBox1.Image = Image.FromFile(filePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer.Start();
            ShuffleButtons();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShuffleButtons();
            stopwatch.Start();
            timer.Start();
            List<Button> buttons = Khung.Controls.OfType<Button>().ToList();
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Enabled = true;
            }
            button10.Enabled = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
