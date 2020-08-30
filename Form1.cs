using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionare
{
    public partial class MainForm : Form
    {
        private int _answer = -1;

        public int GetAnswer()
        {
            while (_answer == -1) {  }

            var i = _answer;

            _answer = -1;

            return i;

        }
        public MainForm()
        {
            InitializeComponent();

            answer0.Click += (sender, args) =>
            {
                _answer = 0;
            };
            answer1.Click += (sender, args) =>
            {
                _answer = 1;
            };
            answer2.Click += (sender, args) =>
            {
                _answer = 2;
            };
            answer3.Click += (sender, args) =>
            {
                _answer = 3;
            };

            answer0.MouseEnter += ChangeColor;
            answer0.MouseLeave += SetStandartColor;

            answer1.MouseEnter += ChangeColor;
            answer1.MouseLeave += SetStandartColor;

            answer2.MouseEnter += ChangeColor;
            answer2.MouseLeave += SetStandartColor;

            answer3.MouseEnter += ChangeColor;
            answer3.MouseLeave += SetStandartColor;

            OnSizeChanged(EventArgs.Empty);

            SizeChanged += ChangeSize;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ChangeColor(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.SteelBlue;
        }

        private void SetStandartColor(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Navy;
        }

        private void ChangeSize(object sender, EventArgs e)
        {
            answer0.Size = new Size(this.Size.Width / 2 - 10, 70);
            answer1.Size = new Size(this.Size.Width / 2 - 15, 70);
            answer2.Size = new Size(this.Size.Width / 2 - 10, 70);
            answer3.Size = new Size(this.Size.Width / 2 - 15, 70);

            

            answer1.Location = new Point(answer0.Location.X + answer0.Size.Width + 5, answer0.Location.Y);
            answer3.Location = new Point(answer2.Location.X + answer2.Size.Width + 5, answer2.Location.Y);
        }
    }
}
