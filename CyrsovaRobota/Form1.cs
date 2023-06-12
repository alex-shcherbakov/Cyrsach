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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            TextBox[] BothMatrix = { MatrixA1, MatrixA2, MatrixA3, MatrixA4, MatrixA5, MatrixA6,
                MatrixA7, MatrixA8, MatrixA9,MatrixB1, MatrixB2, MatrixB3, MatrixB4, MatrixB5,
                MatrixB6, MatrixB7, MatrixB8, MatrixB9 };
            foreach (var item in BothMatrix)
            {
                item.Text = "0";
            }
            TextBox[] K = { K1, K2 };
            foreach (var item in K)
            {
                item.Text = "1";
            }
        }
        public class MultMatrix
        {
            public TextBox[,] Multiply(TextBox[,] matrix1, TextBox[,] matrix2)
            {
                TextBox[,] result = new TextBox[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        result[i, j] = new TextBox();

                        int sum = 0;
                        for (int k = 0; k < 3; k++)
                        {
                            sum += int.Parse(matrix1[i, k].Text) * int.Parse(matrix2[k, j].Text);
                        }

                        result[i, j].Text = sum.ToString();
                    }
                }

                return result;
            }
        }


        private void MultiplyMatrixButton_Click(object sender, EventArgs e)
        {
           
                TextBox[,] matrixA = new TextBox[,]
                {
                    {MatrixA1, MatrixA2, MatrixA3},
                    {MatrixA4, MatrixA5, MatrixA6},
                    {MatrixA7, MatrixA8, MatrixA9}
                };
                TextBox[,] matrixB = new TextBox[,]
                {
                    {MatrixB1, MatrixB2, MatrixB3},
                    {MatrixB4, MatrixB5, MatrixB6},
                    {MatrixB7, MatrixB8, MatrixB9}
                };
                TextBox[,] matrixC = new TextBox[,]
                {
                    {MatrixC1, MatrixC2, MatrixC3},
                    {MatrixC4, MatrixC5, MatrixC6},
                    {MatrixC7, MatrixC8, MatrixC9}
                };
                label3.Text = $"Результат: ({MultiplyMatrixButton.Text}):";
            try
            {
                MultMatrix Matr = new MultMatrix();
                TextBox[,] result = Matr.Multiply(matrixA,matrixB);
                for(int i = 0; i < 3; i++)
                {
                    for(int j=0;j < 3; j++)
                    {
                        matrixC[i, j].Text = result[i, j].Text;
                    }
                }

            }
            catch (FormatException) { }
        }

        private void SumMatrixButton_Click(object sender, EventArgs e)
        {
            TextBox[] MatrA = { MatrixA1, MatrixA2, MatrixA3, MatrixA4, MatrixA5, MatrixA6, MatrixA7, MatrixA8, MatrixA9 };
            TextBox[] MatrB = { MatrixB1, MatrixB2, MatrixB3, MatrixB4, MatrixB5, MatrixB6, MatrixB7, MatrixB8, MatrixB9 };
            TextBox[] MatrC = { MatrixC1, MatrixC2, MatrixC3, MatrixC4, MatrixC5, MatrixC6, MatrixC7, MatrixC8, MatrixC9 };
            label3.Text = $"Результат: ({SumMatrixButton.Text}):";
            try
            {
                for (int i = 0; i < 9; i++)
                {
                    MatrC[i].Text = (int.Parse(MatrA[i].Text) + int.Parse(MatrB[i].Text)).ToString();
                }
            }
            catch (FormatException){}
        }

        private void MinusMatrixButton_Click(object sender, EventArgs e)
        {
            TextBox[] MatrA = { MatrixA1, MatrixA2, MatrixA3, MatrixA4, MatrixA5, MatrixA6, MatrixA7, MatrixA8, MatrixA9 };
            TextBox[] MatrB = { MatrixB1, MatrixB2, MatrixB3, MatrixB4, MatrixB5, MatrixB6, MatrixB7, MatrixB8, MatrixB9 };
            TextBox[] MatrC = { MatrixC1, MatrixC2, MatrixC3, MatrixC4, MatrixC5, MatrixC6, MatrixC7, MatrixC8, MatrixC9 };
            label3.Text = $"Результат: ({MinusMatrixButton.Text}):";
            try
            {
                for (int i = 0; i < 9; i++)
                {
                    MatrC[i].Text = (int.Parse(MatrA[i].Text) - int.Parse(MatrB[i].Text)).ToString();

                }
            }
            catch (FormatException) { }

        }

        private void TranspozeA_Click(object sender, EventArgs e)
        {
            string stackTransposeA = String.Empty;
            stackTransposeA = MatrixA1.Text;
            MatrixA1.Text = MatrixA1.Text;
            MatrixA1.Text = stackTransposeA;
            stackTransposeA = MatrixA2.Text;
            MatrixA2.Text = MatrixA4.Text;
            MatrixA4.Text = stackTransposeA;
            stackTransposeA = MatrixA3.Text;
            MatrixA3.Text = MatrixA7.Text;
            MatrixA7.Text = stackTransposeA;
            stackTransposeA = MatrixA5.Text;
            MatrixA5.Text = MatrixA5.Text;
            MatrixA5.Text = stackTransposeA;
            stackTransposeA = MatrixA6.Text;
            MatrixA6.Text = MatrixA8.Text;
            MatrixA8.Text = stackTransposeA;
            stackTransposeA = MatrixA9.Text;
            MatrixA9.Text = MatrixA9.Text;
            MatrixA9.Text = stackTransposeA;
        }

        private void TranspozeB_Click(object sender, EventArgs e)
        {
            string stackTransposeA = String.Empty;
            stackTransposeA = MatrixB1.Text;
            MatrixB1.Text = MatrixB1.Text;
            MatrixB1.Text = stackTransposeA;
            stackTransposeA = MatrixB2.Text;
            MatrixB2.Text = MatrixB4.Text;
            MatrixB4.Text = stackTransposeA;
            stackTransposeA = MatrixB3.Text;
            MatrixB3.Text = MatrixB7.Text;
            MatrixB7.Text = stackTransposeA;
            stackTransposeA = MatrixB5.Text;
            MatrixB5.Text = MatrixB5.Text;
            MatrixB5.Text = stackTransposeA;
            stackTransposeA = MatrixB6.Text;
            MatrixB6.Text = MatrixB8.Text;
            MatrixB8.Text = stackTransposeA;
            stackTransposeA = MatrixB9.Text;
            MatrixB9.Text = MatrixB9.Text;
            MatrixB9.Text = stackTransposeA;
        }

        private void MultK1_Click(object sender, EventArgs e)
        {
            TextBox[] MatrA = { MatrixA1, MatrixA2, MatrixA3, MatrixA4, MatrixA5, MatrixA6, MatrixA7, MatrixA8, MatrixA9 };
            try
            {
                for (int i = 0; i < 9; i++)
                {
                    MatrA[i].Text = (int.Parse(MatrA[i].Text) * int.Parse(K1.Text)).ToString();
                }
            }
            catch (FormatException) { }
        }

        private void MultK2_Click(object sender, EventArgs e)
        {
            TextBox[] MatrB = {MatrixB1, MatrixB2, MatrixB3, MatrixB4, MatrixB5, MatrixB6, MatrixB7, MatrixB8, MatrixB9};
            try
            {
                for (int i = 0; i < 9; i++)
                {
                    MatrB[i].Text = (int.Parse(MatrB[i].Text) * int.Parse(K2.Text)).ToString();
                }
            }
            catch (FormatException) { }
        }

        private void ItemsExchangeButton_Click(object sender, EventArgs e)
        {
            string stack = String.Empty;
            stack = MatrixA1.Text;
            MatrixA1.Text = MatrixB1.Text;
            MatrixB1.Text = stack;
            stack = MatrixA2.Text;
            MatrixA2.Text = MatrixB2.Text;
            MatrixB2.Text = stack;
            stack = MatrixA3.Text;
            MatrixA3.Text = MatrixB3.Text;
            MatrixB3.Text = stack;
            stack = MatrixA4.Text;
            MatrixA4.Text = MatrixB4.Text;
            MatrixB4.Text = stack;
            stack = MatrixA5.Text;
            MatrixA5.Text = MatrixB5.Text;
            MatrixB5.Text = stack;
            stack = MatrixA6.Text;
            MatrixA6.Text = MatrixB6.Text;
            MatrixB6.Text = stack;
            stack = MatrixA7.Text;
            MatrixA7.Text = MatrixB7.Text;
            MatrixB7.Text = stack;
            stack = MatrixA8.Text;
            MatrixA8.Text = MatrixB8.Text;
            MatrixB8.Text = stack;
            stack = MatrixA9.Text;
            MatrixA9.Text = MatrixB9.Text;
            MatrixB9.Text = stack;
        }

        private void очиститиМатрицюАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox[] MatrixA = { MatrixA1, MatrixA2, MatrixA3, MatrixA4, MatrixA5, MatrixA6, MatrixA7, MatrixA8, MatrixA9 };
            foreach (var Item in MatrixA)
                Item.Text = "";
        }

        private void очиститиМатрицюБToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox[] MatrixB = { MatrixB1, MatrixB2, MatrixB3, MatrixB4, MatrixB5, MatrixB6, MatrixB7, MatrixB8, MatrixB9 };
            foreach (var Item in MatrixB)
                Item.Text = "";
        }

        private void очиститиОбидвіМатриціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox[] BothMatrix = { MatrixA1, MatrixA2, MatrixA3, MatrixA4, MatrixA5, MatrixA6,
                MatrixA7, MatrixA8, MatrixA9,MatrixB1, MatrixB2, MatrixB3, MatrixB4, MatrixB5,
                MatrixB6, MatrixB7, MatrixB8, MatrixB9 };
            foreach (var Item in BothMatrix)
                Item.Text = "";
        }

        private void очиститиРезультатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Результат ";
            TextBox[] Result = {MatrixC1, MatrixC2, MatrixC3, MatrixC4, MatrixC5, MatrixC6,
                MatrixC7, MatrixC8, MatrixC9 };
            foreach (var Item in Result)
                Item.Text = "";
        }        

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseLabel_MouseEnter(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Red;
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Black;
        }

        Point LastPoint;
        private void Calculator_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Calculator_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X , e.Y) ;
        }

        private void ToOtherOptionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OtherOptions OtherOption = new OtherOptions();
            OtherOption.Show();
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
            if (Matr.Text =="0")
            {
                Matr.Text = "";
            }
        }

        private void MatrixA1_Leave(object sender, EventArgs e)
        {
            TextBox Matr = (TextBox)sender;
            if (Matr.Text == "")
            {
                Matr.Text = "0";
            }
        }

        private void K1_Enter(object sender, EventArgs e)
        {
            TextBox Matr = (TextBox)sender;
            if (Matr.Text == "1")
            {
                Matr.Text = "";
            }
        }

        private void K1_Leave(object sender, EventArgs e)
        {
            TextBox Matr = (TextBox)sender;
            if (Matr.Text == "")
            {
                Matr.Text = "1";
            }
        }
    }
    }

