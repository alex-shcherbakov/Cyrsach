using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyrsovaRobota
{
    
    public partial class OtherOptions : Form
    {
        public OtherOptions()
        {
            InitializeComponent();
            TextBox[] MatrixA = { MatrixA1, MatrixA2, MatrixA3, MatrixA4, MatrixA5, MatrixA6, MatrixA7, MatrixA8, MatrixA9 };
            foreach (var Item in MatrixA)
                Item.Text = "1";
        }
        public class MatrixC
        {
            public string text = "";
        }
        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void OtherOptions_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void OtherOptions_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void CloseLabel_MouseEnter(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Red;
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Black;
        }

        private void Deter_Click(object sender, EventArgs e)
        {
            try
            {
                DeterA.Text = "Визначник матриці :" + ((int.Parse(MatrixA1.Text) * int.Parse(MatrixA5.Text) * int.Parse(MatrixA9.Text))
                    + (int.Parse(MatrixA2.Text) * int.Parse(MatrixA6.Text) * int.Parse(MatrixA7.Text))
                    + (int.Parse(MatrixA3.Text) * int.Parse(MatrixA4.Text) * int.Parse(MatrixA8.Text))
                    - (int.Parse(MatrixA3.Text) * int.Parse(MatrixA5.Text) * int.Parse(MatrixA7.Text))
                    - (int.Parse(MatrixA2.Text) * int.Parse(MatrixA4.Text) * int.Parse(MatrixA9.Text))
                    - (int.Parse(MatrixA1.Text) * int.Parse(MatrixA6.Text) * int.Parse(MatrixA8.Text))
                    ).ToString();
            }
            catch (FormatException) { }
        }

        private void очиститиМатрицюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox[] Matrix = { MatrixA1, MatrixA2, MatrixA3, MatrixA4, MatrixA5, MatrixA6, MatrixA7, MatrixA8, MatrixA9 };
            foreach (var Item in Matrix)
                Item.Text = "";
        }

        private void синійToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void білийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void сірийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            MatrixC C1 = new MatrixC();
            MatrixC C2 = new MatrixC();
            MatrixC C3 = new MatrixC();
            MatrixC C4 = new MatrixC();
            MatrixC C5 = new MatrixC();
            MatrixC C6 = new MatrixC();
            MatrixC C7 = new MatrixC();
            MatrixC C8 = new MatrixC();
            MatrixC C9 = new MatrixC();
            try
            {
                C1.text = ((int.Parse(MatrixA1.Text) * int.Parse(MatrixA1.Text)) + (int.Parse(MatrixA4.Text) * int.Parse(MatrixA2.Text)) + (int.Parse(MatrixA7.Text) * int.Parse(MatrixA3.Text))).ToString();
                C4.text = ((int.Parse(MatrixA1.Text) * int.Parse(MatrixA4.Text)) + (int.Parse(MatrixA4.Text) * int.Parse(MatrixA5.Text)) + (int.Parse(MatrixA7.Text) * int.Parse(MatrixA6.Text))).ToString();
                C7.text = ((int.Parse(MatrixA1.Text) * int.Parse(MatrixA7.Text)) + (int.Parse(MatrixA4.Text) * int.Parse(MatrixA8.Text)) + (int.Parse(MatrixA7.Text) * int.Parse(MatrixA9.Text))).ToString();
                C2.text = ((int.Parse(MatrixA2.Text) * int.Parse(MatrixA1.Text)) + (int.Parse(MatrixA5.Text) * int.Parse(MatrixA2.Text)) + (int.Parse(MatrixA8.Text) * int.Parse(MatrixA3.Text))).ToString();
                C5.text = ((int.Parse(MatrixA2.Text) * int.Parse(MatrixA4.Text)) + (int.Parse(MatrixA5.Text) * int.Parse(MatrixA5.Text)) + (int.Parse(MatrixA8.Text) * int.Parse(MatrixA6.Text))).ToString();
                C8.text = ((int.Parse(MatrixA2.Text) * int.Parse(MatrixA7.Text)) + (int.Parse(MatrixA5.Text) * int.Parse(MatrixA8.Text)) + (int.Parse(MatrixA8.Text) * int.Parse(MatrixA9.Text))).ToString();
                C3.text = ((int.Parse(MatrixA3.Text) * int.Parse(MatrixA1.Text)) + (int.Parse(MatrixA6.Text) * int.Parse(MatrixA2.Text)) + (int.Parse(MatrixA9.Text) * int.Parse(MatrixA3.Text))).ToString();
                C6.text = ((int.Parse(MatrixA3.Text) * int.Parse(MatrixA4.Text)) + (int.Parse(MatrixA6.Text) * int.Parse(MatrixA5.Text)) + (int.Parse(MatrixA9.Text) * int.Parse(MatrixA6.Text))).ToString();
                C9.text = ((int.Parse(MatrixA3.Text) * int.Parse(MatrixA7.Text)) + (int.Parse(MatrixA6.Text) * int.Parse(MatrixA8.Text)) + (int.Parse(MatrixA9.Text) * int.Parse(MatrixA9.Text))).ToString();
                TextBox[] MatrA = { MatrixA1, MatrixA2, MatrixA3, MatrixA4, MatrixA5, MatrixA6, MatrixA7, MatrixA8, MatrixA9 };
                MatrixC[] array = { C1, C2, C3, C4, C5, C6, C7, C8, C9 };
                for (int i = 0; i < 9; i++)
                {
                    MatrA[i].Text = array[i].text;
                }
            }
            catch (FormatException) { }
        }

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculator Main = new Calculator();
            Main.Show();
        }

        private void MatrixA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void MatrixA1_Enter(object sender, EventArgs e)
        {
            TextBox Matr = (TextBox)sender;
            if (Matr.Text == "1")
            {
                Matr.Text = "";
            }
        }

        private void MatrixA1_Leave(object sender, EventArgs e)
        {
            TextBox Matr = (TextBox)sender;
            if (Matr.Text == "")
            {
                Matr.Text = "1";
            }
        }
    }
}
