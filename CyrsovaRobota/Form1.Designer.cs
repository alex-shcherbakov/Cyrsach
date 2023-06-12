
namespace CyrsovaRobota
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MatrixA1 = new System.Windows.Forms.TextBox();
            this.MatrixA2 = new System.Windows.Forms.TextBox();
            this.MatrixA3 = new System.Windows.Forms.TextBox();
            this.MatrixA4 = new System.Windows.Forms.TextBox();
            this.MatrixA5 = new System.Windows.Forms.TextBox();
            this.MatrixA6 = new System.Windows.Forms.TextBox();
            this.MatrixA7 = new System.Windows.Forms.TextBox();
            this.MatrixA8 = new System.Windows.Forms.TextBox();
            this.MatrixA9 = new System.Windows.Forms.TextBox();
            this.MatrixB1 = new System.Windows.Forms.TextBox();
            this.MatrixB2 = new System.Windows.Forms.TextBox();
            this.MatrixB3 = new System.Windows.Forms.TextBox();
            this.MatrixB4 = new System.Windows.Forms.TextBox();
            this.MatrixB5 = new System.Windows.Forms.TextBox();
            this.MatrixB6 = new System.Windows.Forms.TextBox();
            this.MatrixB7 = new System.Windows.Forms.TextBox();
            this.MatrixB8 = new System.Windows.Forms.TextBox();
            this.MatrixB9 = new System.Windows.Forms.TextBox();
            this.MatrixC1 = new System.Windows.Forms.TextBox();
            this.MatrixC2 = new System.Windows.Forms.TextBox();
            this.MatrixC3 = new System.Windows.Forms.TextBox();
            this.MatrixC4 = new System.Windows.Forms.TextBox();
            this.MatrixC5 = new System.Windows.Forms.TextBox();
            this.MatrixC6 = new System.Windows.Forms.TextBox();
            this.MatrixC7 = new System.Windows.Forms.TextBox();
            this.MatrixC8 = new System.Windows.Forms.TextBox();
            this.MatrixC9 = new System.Windows.Forms.TextBox();
            this.MultiplyMatrixButton = new System.Windows.Forms.Button();
            this.SumMatrixButton = new System.Windows.Forms.Button();
            this.MinusMatrixButton = new System.Windows.Forms.Button();
            this.TranspozeA = new System.Windows.Forms.Button();
            this.TranspozeB = new System.Windows.Forms.Button();
            this.MultK1 = new System.Windows.Forms.Button();
            this.MultK2 = new System.Windows.Forms.Button();
            this.K1 = new System.Windows.Forms.TextBox();
            this.K2 = new System.Windows.Forms.TextBox();
            this.ItemsExchangeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.очиститиМатрицюАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиМатрицюБToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиОбидвіМатриціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиРезультатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.ToOtherOptionsButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Матриця А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Матриця Б";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат";
            // 
            // MatrixA1
            // 
            this.MatrixA1.Location = new System.Drawing.Point(32, 90);
            this.MatrixA1.Name = "MatrixA1";
            this.MatrixA1.Size = new System.Drawing.Size(45, 22);
            this.MatrixA1.TabIndex = 3;
            this.MatrixA1.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixA1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixA1.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixA2
            // 
            this.MatrixA2.Location = new System.Drawing.Point(93, 90);
            this.MatrixA2.Name = "MatrixA2";
            this.MatrixA2.Size = new System.Drawing.Size(45, 22);
            this.MatrixA2.TabIndex = 4;
            this.MatrixA2.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixA2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixA2.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixA3
            // 
            this.MatrixA3.Location = new System.Drawing.Point(156, 90);
            this.MatrixA3.Name = "MatrixA3";
            this.MatrixA3.Size = new System.Drawing.Size(45, 22);
            this.MatrixA3.TabIndex = 5;
            this.MatrixA3.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixA3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixA3.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixA4
            // 
            this.MatrixA4.Location = new System.Drawing.Point(32, 127);
            this.MatrixA4.Name = "MatrixA4";
            this.MatrixA4.Size = new System.Drawing.Size(45, 22);
            this.MatrixA4.TabIndex = 6;
            this.MatrixA4.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixA4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixA4.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixA5
            // 
            this.MatrixA5.Location = new System.Drawing.Point(93, 127);
            this.MatrixA5.Name = "MatrixA5";
            this.MatrixA5.Size = new System.Drawing.Size(45, 22);
            this.MatrixA5.TabIndex = 7;
            this.MatrixA5.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixA5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixA5.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixA6
            // 
            this.MatrixA6.Location = new System.Drawing.Point(156, 127);
            this.MatrixA6.Name = "MatrixA6";
            this.MatrixA6.Size = new System.Drawing.Size(45, 22);
            this.MatrixA6.TabIndex = 8;
            this.MatrixA6.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixA6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixA6.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixA7
            // 
            this.MatrixA7.Location = new System.Drawing.Point(32, 164);
            this.MatrixA7.Name = "MatrixA7";
            this.MatrixA7.Size = new System.Drawing.Size(45, 22);
            this.MatrixA7.TabIndex = 9;
            this.MatrixA7.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixA7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixA7.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixA8
            // 
            this.MatrixA8.Location = new System.Drawing.Point(93, 164);
            this.MatrixA8.Name = "MatrixA8";
            this.MatrixA8.Size = new System.Drawing.Size(45, 22);
            this.MatrixA8.TabIndex = 10;
            this.MatrixA8.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixA8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixA8.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixA9
            // 
            this.MatrixA9.Location = new System.Drawing.Point(156, 164);
            this.MatrixA9.Name = "MatrixA9";
            this.MatrixA9.Size = new System.Drawing.Size(45, 22);
            this.MatrixA9.TabIndex = 11;
            this.MatrixA9.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixA9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixA9.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixB1
            // 
            this.MatrixB1.Location = new System.Drawing.Point(329, 90);
            this.MatrixB1.Name = "MatrixB1";
            this.MatrixB1.Size = new System.Drawing.Size(45, 22);
            this.MatrixB1.TabIndex = 12;
            this.MatrixB1.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixB1.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixB2
            // 
            this.MatrixB2.Location = new System.Drawing.Point(392, 90);
            this.MatrixB2.Name = "MatrixB2";
            this.MatrixB2.Size = new System.Drawing.Size(45, 22);
            this.MatrixB2.TabIndex = 13;
            this.MatrixB2.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixB2.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixB3
            // 
            this.MatrixB3.Location = new System.Drawing.Point(452, 90);
            this.MatrixB3.Name = "MatrixB3";
            this.MatrixB3.Size = new System.Drawing.Size(45, 22);
            this.MatrixB3.TabIndex = 14;
            this.MatrixB3.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixB3.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixB4
            // 
            this.MatrixB4.Location = new System.Drawing.Point(329, 126);
            this.MatrixB4.Name = "MatrixB4";
            this.MatrixB4.Size = new System.Drawing.Size(45, 22);
            this.MatrixB4.TabIndex = 15;
            this.MatrixB4.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixB4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixB4.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixB5
            // 
            this.MatrixB5.Location = new System.Drawing.Point(392, 126);
            this.MatrixB5.Name = "MatrixB5";
            this.MatrixB5.Size = new System.Drawing.Size(45, 22);
            this.MatrixB5.TabIndex = 16;
            this.MatrixB5.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixB5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixB5.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixB6
            // 
            this.MatrixB6.Location = new System.Drawing.Point(452, 126);
            this.MatrixB6.Name = "MatrixB6";
            this.MatrixB6.Size = new System.Drawing.Size(45, 22);
            this.MatrixB6.TabIndex = 17;
            this.MatrixB6.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixB6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixB6.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixB7
            // 
            this.MatrixB7.Location = new System.Drawing.Point(329, 164);
            this.MatrixB7.Name = "MatrixB7";
            this.MatrixB7.Size = new System.Drawing.Size(45, 22);
            this.MatrixB7.TabIndex = 18;
            this.MatrixB7.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixB7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixB7.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixB8
            // 
            this.MatrixB8.Location = new System.Drawing.Point(392, 164);
            this.MatrixB8.Name = "MatrixB8";
            this.MatrixB8.Size = new System.Drawing.Size(45, 22);
            this.MatrixB8.TabIndex = 19;
            this.MatrixB8.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixB8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixB8.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixB9
            // 
            this.MatrixB9.Location = new System.Drawing.Point(452, 164);
            this.MatrixB9.Name = "MatrixB9";
            this.MatrixB9.Size = new System.Drawing.Size(45, 22);
            this.MatrixB9.TabIndex = 20;
            this.MatrixB9.Enter += new System.EventHandler(this.MatrixA1_Enter);
            this.MatrixB9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.MatrixB9.Leave += new System.EventHandler(this.MatrixA1_Leave);
            // 
            // MatrixC1
            // 
            this.MatrixC1.Location = new System.Drawing.Point(577, 90);
            this.MatrixC1.Name = "MatrixC1";
            this.MatrixC1.Size = new System.Drawing.Size(45, 22);
            this.MatrixC1.TabIndex = 21;
            // 
            // MatrixC2
            // 
            this.MatrixC2.Location = new System.Drawing.Point(642, 90);
            this.MatrixC2.Name = "MatrixC2";
            this.MatrixC2.Size = new System.Drawing.Size(45, 22);
            this.MatrixC2.TabIndex = 22;
            // 
            // MatrixC3
            // 
            this.MatrixC3.Location = new System.Drawing.Point(704, 90);
            this.MatrixC3.Name = "MatrixC3";
            this.MatrixC3.Size = new System.Drawing.Size(45, 22);
            this.MatrixC3.TabIndex = 23;
            // 
            // MatrixC4
            // 
            this.MatrixC4.Location = new System.Drawing.Point(577, 127);
            this.MatrixC4.Name = "MatrixC4";
            this.MatrixC4.Size = new System.Drawing.Size(45, 22);
            this.MatrixC4.TabIndex = 24;
            // 
            // MatrixC5
            // 
            this.MatrixC5.Location = new System.Drawing.Point(642, 127);
            this.MatrixC5.Name = "MatrixC5";
            this.MatrixC5.Size = new System.Drawing.Size(45, 22);
            this.MatrixC5.TabIndex = 25;
            // 
            // MatrixC6
            // 
            this.MatrixC6.Location = new System.Drawing.Point(704, 127);
            this.MatrixC6.Name = "MatrixC6";
            this.MatrixC6.Size = new System.Drawing.Size(45, 22);
            this.MatrixC6.TabIndex = 26;
            // 
            // MatrixC7
            // 
            this.MatrixC7.Location = new System.Drawing.Point(577, 164);
            this.MatrixC7.Name = "MatrixC7";
            this.MatrixC7.Size = new System.Drawing.Size(45, 22);
            this.MatrixC7.TabIndex = 27;
            // 
            // MatrixC8
            // 
            this.MatrixC8.Location = new System.Drawing.Point(642, 164);
            this.MatrixC8.Name = "MatrixC8";
            this.MatrixC8.Size = new System.Drawing.Size(45, 22);
            this.MatrixC8.TabIndex = 28;
            // 
            // MatrixC9
            // 
            this.MatrixC9.Location = new System.Drawing.Point(704, 164);
            this.MatrixC9.Name = "MatrixC9";
            this.MatrixC9.Size = new System.Drawing.Size(45, 22);
            this.MatrixC9.TabIndex = 29;
            // 
            // MultiplyMatrixButton
            // 
            this.MultiplyMatrixButton.Location = new System.Drawing.Point(226, 90);
            this.MultiplyMatrixButton.Name = "MultiplyMatrixButton";
            this.MultiplyMatrixButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplyMatrixButton.TabIndex = 30;
            this.MultiplyMatrixButton.Text = "A * B";
            this.MultiplyMatrixButton.UseVisualStyleBackColor = true;
            this.MultiplyMatrixButton.Click += new System.EventHandler(this.MultiplyMatrixButton_Click);
            // 
            // SumMatrixButton
            // 
            this.SumMatrixButton.Location = new System.Drawing.Point(226, 127);
            this.SumMatrixButton.Name = "SumMatrixButton";
            this.SumMatrixButton.Size = new System.Drawing.Size(75, 23);
            this.SumMatrixButton.TabIndex = 31;
            this.SumMatrixButton.Text = "A + B";
            this.SumMatrixButton.UseVisualStyleBackColor = true;
            this.SumMatrixButton.Click += new System.EventHandler(this.SumMatrixButton_Click);
            // 
            // MinusMatrixButton
            // 
            this.MinusMatrixButton.Location = new System.Drawing.Point(226, 162);
            this.MinusMatrixButton.Name = "MinusMatrixButton";
            this.MinusMatrixButton.Size = new System.Drawing.Size(75, 23);
            this.MinusMatrixButton.TabIndex = 32;
            this.MinusMatrixButton.Text = "A - B";
            this.MinusMatrixButton.UseVisualStyleBackColor = true;
            this.MinusMatrixButton.Click += new System.EventHandler(this.MinusMatrixButton_Click);
            // 
            // TranspozeA
            // 
            this.TranspozeA.Location = new System.Drawing.Point(32, 203);
            this.TranspozeA.Name = "TranspozeA";
            this.TranspozeA.Size = new System.Drawing.Size(140, 35);
            this.TranspozeA.TabIndex = 33;
            this.TranspozeA.Text = "Транспонувати ";
            this.TranspozeA.UseVisualStyleBackColor = true;
            this.TranspozeA.Click += new System.EventHandler(this.TranspozeA_Click);
            // 
            // TranspozeB
            // 
            this.TranspozeB.Location = new System.Drawing.Point(329, 203);
            this.TranspozeB.Name = "TranspozeB";
            this.TranspozeB.Size = new System.Drawing.Size(140, 35);
            this.TranspozeB.TabIndex = 34;
            this.TranspozeB.Text = "Транспонувати";
            this.TranspozeB.UseVisualStyleBackColor = true;
            this.TranspozeB.Click += new System.EventHandler(this.TranspozeB_Click);
            // 
            // MultK1
            // 
            this.MultK1.Location = new System.Drawing.Point(32, 259);
            this.MultK1.Name = "MultK1";
            this.MultK1.Size = new System.Drawing.Size(128, 35);
            this.MultK1.TabIndex = 35;
            this.MultK1.Text = "Помножити на :";
            this.MultK1.UseVisualStyleBackColor = true;
            this.MultK1.Click += new System.EventHandler(this.MultK1_Click);
            // 
            // MultK2
            // 
            this.MultK2.Location = new System.Drawing.Point(329, 259);
            this.MultK2.Name = "MultK2";
            this.MultK2.Size = new System.Drawing.Size(128, 35);
            this.MultK2.TabIndex = 36;
            this.MultK2.Text = "Помножити на :";
            this.MultK2.UseVisualStyleBackColor = true;
            this.MultK2.Click += new System.EventHandler(this.MultK2_Click);
            // 
            // K1
            // 
            this.K1.Location = new System.Drawing.Point(166, 259);
            this.K1.Multiline = true;
            this.K1.Name = "K1";
            this.K1.Size = new System.Drawing.Size(45, 35);
            this.K1.TabIndex = 37;
            this.K1.Enter += new System.EventHandler(this.K1_Enter);
            this.K1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.K1.Leave += new System.EventHandler(this.K1_Leave);
            // 
            // K2
            // 
            this.K2.Location = new System.Drawing.Point(463, 259);
            this.K2.Multiline = true;
            this.K2.Name = "K2";
            this.K2.Size = new System.Drawing.Size(45, 35);
            this.K2.TabIndex = 38;
            this.K2.Enter += new System.EventHandler(this.K1_Enter);
            this.K2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatrixA1_KeyPress);
            this.K2.Leave += new System.EventHandler(this.K1_Leave);
            // 
            // ItemsExchangeButton
            // 
            this.ItemsExchangeButton.Location = new System.Drawing.Point(226, 203);
            this.ItemsExchangeButton.Name = "ItemsExchangeButton";
            this.ItemsExchangeButton.Size = new System.Drawing.Size(75, 58);
            this.ItemsExchangeButton.TabIndex = 39;
            this.ItemsExchangeButton.Text = "<=>";
            this.ItemsExchangeButton.UseVisualStyleBackColor = true;
            this.ItemsExchangeButton.Click += new System.EventHandler(this.ItemsExchangeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститиМатрицюАToolStripMenuItem,
            this.очиститиМатрицюБToolStripMenuItem,
            this.очиститиОбидвіМатриціToolStripMenuItem,
            this.очиститиРезультатиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // очиститиМатрицюАToolStripMenuItem
            // 
            this.очиститиМатрицюАToolStripMenuItem.Name = "очиститиМатрицюАToolStripMenuItem";
            this.очиститиМатрицюАToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.очиститиМатрицюАToolStripMenuItem.Text = "Очистити матрицю А";
            this.очиститиМатрицюАToolStripMenuItem.Click += new System.EventHandler(this.очиститиМатрицюАToolStripMenuItem_Click);
            // 
            // очиститиМатрицюБToolStripMenuItem
            // 
            this.очиститиМатрицюБToolStripMenuItem.Name = "очиститиМатрицюБToolStripMenuItem";
            this.очиститиМатрицюБToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.очиститиМатрицюБToolStripMenuItem.Text = "Очистити матрицю Б";
            this.очиститиМатрицюБToolStripMenuItem.Click += new System.EventHandler(this.очиститиМатрицюБToolStripMenuItem_Click);
            // 
            // очиститиОбидвіМатриціToolStripMenuItem
            // 
            this.очиститиОбидвіМатриціToolStripMenuItem.Name = "очиститиОбидвіМатриціToolStripMenuItem";
            this.очиститиОбидвіМатриціToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.очиститиОбидвіМатриціToolStripMenuItem.Text = "Очистити обидві матриці";
            this.очиститиОбидвіМатриціToolStripMenuItem.Click += new System.EventHandler(this.очиститиОбидвіМатриціToolStripMenuItem_Click);
            // 
            // очиститиРезультатиToolStripMenuItem
            // 
            this.очиститиРезультатиToolStripMenuItem.Name = "очиститиРезультатиToolStripMenuItem";
            this.очиститиРезультатиToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.очиститиРезультатиToolStripMenuItem.Text = "Очистити Результати";
            this.очиститиРезультатиToolStripMenuItem.Click += new System.EventHandler(this.очиститиРезультатиToolStripMenuItem_Click);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLabel.Location = new System.Drawing.Point(918, 5);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(26, 25);
            this.CloseLabel.TabIndex = 45;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // ToOtherOptionsButton
            // 
            this.ToOtherOptionsButton.Location = new System.Drawing.Point(807, 259);
            this.ToOtherOptionsButton.Name = "ToOtherOptionsButton";
            this.ToOtherOptionsButton.Size = new System.Drawing.Size(149, 62);
            this.ToOtherOptionsButton.TabIndex = 46;
            this.ToOtherOptionsButton.Text = "Перейти до додаткових можливостей";
            this.ToOtherOptionsButton.UseVisualStyleBackColor = true;
            this.ToOtherOptionsButton.Click += new System.EventHandler(this.ToOtherOptionsButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 500);
            this.Controls.Add(this.ToOtherOptionsButton);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.ItemsExchangeButton);
            this.Controls.Add(this.K2);
            this.Controls.Add(this.K1);
            this.Controls.Add(this.MultK2);
            this.Controls.Add(this.MultK1);
            this.Controls.Add(this.TranspozeB);
            this.Controls.Add(this.TranspozeA);
            this.Controls.Add(this.MinusMatrixButton);
            this.Controls.Add(this.SumMatrixButton);
            this.Controls.Add(this.MultiplyMatrixButton);
            this.Controls.Add(this.MatrixC9);
            this.Controls.Add(this.MatrixC8);
            this.Controls.Add(this.MatrixC7);
            this.Controls.Add(this.MatrixC6);
            this.Controls.Add(this.MatrixC5);
            this.Controls.Add(this.MatrixC4);
            this.Controls.Add(this.MatrixC3);
            this.Controls.Add(this.MatrixC2);
            this.Controls.Add(this.MatrixC1);
            this.Controls.Add(this.MatrixB9);
            this.Controls.Add(this.MatrixB8);
            this.Controls.Add(this.MatrixB7);
            this.Controls.Add(this.MatrixB6);
            this.Controls.Add(this.MatrixB5);
            this.Controls.Add(this.MatrixB4);
            this.Controls.Add(this.MatrixB3);
            this.Controls.Add(this.MatrixB2);
            this.Controls.Add(this.MatrixB1);
            this.Controls.Add(this.MatrixA9);
            this.Controls.Add(this.MatrixA8);
            this.Controls.Add(this.MatrixA7);
            this.Controls.Add(this.MatrixA6);
            this.Controls.Add(this.MatrixA5);
            this.Controls.Add(this.MatrixA4);
            this.Controls.Add(this.MatrixA3);
            this.Controls.Add(this.MatrixA2);
            this.Controls.Add(this.MatrixA1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calculator_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Calculator_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MatrixA1;
        private System.Windows.Forms.TextBox MatrixA2;
        private System.Windows.Forms.TextBox MatrixA3;
        private System.Windows.Forms.TextBox MatrixA4;
        private System.Windows.Forms.TextBox MatrixA5;
        private System.Windows.Forms.TextBox MatrixA6;
        private System.Windows.Forms.TextBox MatrixA7;
        private System.Windows.Forms.TextBox MatrixA8;
        private System.Windows.Forms.TextBox MatrixA9;
        private System.Windows.Forms.TextBox MatrixB1;
        private System.Windows.Forms.TextBox MatrixB2;
        private System.Windows.Forms.TextBox MatrixB3;
        private System.Windows.Forms.TextBox MatrixB4;
        private System.Windows.Forms.TextBox MatrixB5;
        private System.Windows.Forms.TextBox MatrixB6;
        private System.Windows.Forms.TextBox MatrixB7;
        private System.Windows.Forms.TextBox MatrixB8;
        private System.Windows.Forms.TextBox MatrixB9;
        private System.Windows.Forms.TextBox MatrixC1;
        private System.Windows.Forms.TextBox MatrixC2;
        private System.Windows.Forms.TextBox MatrixC3;
        private System.Windows.Forms.TextBox MatrixC4;
        private System.Windows.Forms.TextBox MatrixC5;
        private System.Windows.Forms.TextBox MatrixC6;
        private System.Windows.Forms.TextBox MatrixC7;
        private System.Windows.Forms.TextBox MatrixC8;
        private System.Windows.Forms.TextBox MatrixC9;
        private System.Windows.Forms.Button MultiplyMatrixButton;
        private System.Windows.Forms.Button SumMatrixButton;
        private System.Windows.Forms.Button MinusMatrixButton;
        private System.Windows.Forms.Button TranspozeA;
        private System.Windows.Forms.Button TranspozeB;
        private System.Windows.Forms.Button MultK1;
        private System.Windows.Forms.Button MultK2;
        private System.Windows.Forms.TextBox K1;
        private System.Windows.Forms.TextBox K2;
        private System.Windows.Forms.Button ItemsExchangeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem очиститиМатрицюАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиМатрицюБToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиОбидвіМатриціToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиРезультатиToolStripMenuItem;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Button ToOtherOptionsButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

