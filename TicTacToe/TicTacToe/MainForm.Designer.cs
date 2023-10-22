namespace TicTacToe
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveGameToolStripMenuItem = new ToolStripMenuItem();
            loadGameToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            aIToolStripMenuItem = new ToolStripMenuItem();
            helpStripMenuItem1 = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpStripMenuItem1, toolStripTextBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(198, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartToolStripMenuItem, quitToolStripMenuItem, toolStripSeparator1, saveGameToolStripMenuItem, loadGameToolStripMenuItem, toolStripSeparator2, aIToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 23);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(133, 22);
            restartToolStripMenuItem.Text = "Restart";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(133, 22);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(130, 6);
            // 
            // saveGameToolStripMenuItem
            // 
            saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            saveGameToolStripMenuItem.Size = new Size(133, 22);
            saveGameToolStripMenuItem.Text = "Save game";
            // 
            // loadGameToolStripMenuItem
            // 
            loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            loadGameToolStripMenuItem.Size = new Size(133, 22);
            loadGameToolStripMenuItem.Text = "Load game";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(130, 6);
            // 
            // aIToolStripMenuItem
            // 
            aIToolStripMenuItem.Checked = true;
            aIToolStripMenuItem.CheckState = CheckState.Checked;
            aIToolStripMenuItem.Name = "aIToolStripMenuItem";
            aIToolStripMenuItem.Size = new Size(133, 22);
            aIToolStripMenuItem.Text = "AI";
            aIToolStripMenuItem.Click += aIToolStripMenuItem_Click;
            // 
            // helpStripMenuItem1
            // 
            helpStripMenuItem1.Name = "helpStripMenuItem1";
            helpStripMenuItem1.Size = new Size(47, 23);
            helpStripMenuItem1.Text = "Help!";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BackColor = SystemColors.Info;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(90, 23);
            toolStripTextBox1.Text = "Hello!";
            toolStripTextBox1.ToolTipText = "Status Box";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(button9, 2, 2);
            tableLayoutPanel1.Controls.Add(button8, 1, 2);
            tableLayoutPanel1.Controls.Add(button7, 0, 2);
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(198, 197);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button9.FlatAppearance.MouseOverBackColor = Color.White;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Copperplate Gothic Light", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Image = Properties.Resources.X;
            button9.Location = new Point(131, 130);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(67, 67);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button8.FlatAppearance.MouseOverBackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Copperplate Gothic Light", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Image = Properties.Resources.X;
            button8.Location = new Point(65, 130);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(66, 67);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button7.FlatAppearance.MouseOverBackColor = Color.White;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Copperplate Gothic Light", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Image = Properties.Resources.X;
            button7.Location = new Point(0, 130);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(65, 67);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button6.FlatAppearance.MouseOverBackColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Copperplate Gothic Light", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Image = Properties.Resources.X;
            button6.Location = new Point(131, 65);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(67, 65);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button5.FlatAppearance.MouseOverBackColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Copperplate Gothic Light", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Image = Properties.Resources.X;
            button5.Location = new Point(65, 65);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(66, 65);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button4.FlatAppearance.MouseOverBackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Copperplate Gothic Light", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = Properties.Resources.X;
            button4.Location = new Point(0, 65);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(65, 65);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Copperplate Gothic Light", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = Properties.Resources.X;
            button3.Location = new Point(131, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(67, 65);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Copperplate Gothic Light", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = Properties.Resources.X;
            button2.Location = new Point(65, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(66, 65);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Copperplate Gothic Light", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.X;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(65, 65);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 224);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(218, 267);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem saveGameToolStripMenuItem;
        private ToolStripMenuItem loadGameToolStripMenuItem;
        private ToolStripMenuItem aIToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem helpStripMenuItem1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private ToolStripTextBox toolStripTextBox1;
    }
}