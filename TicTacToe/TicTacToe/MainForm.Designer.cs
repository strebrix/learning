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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            startstopStripMenuItem1 = new ToolStripMenuItem();
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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button10 = new Button();
            button11 = new Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpStripMenuItem1, startstopStripMenuItem1 });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartToolStripMenuItem, quitToolStripMenuItem, toolStripSeparator1, saveGameToolStripMenuItem, loadGameToolStripMenuItem, toolStripSeparator2, aIToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            resources.ApplyResources(menuToolStripMenuItem, "menuToolStripMenuItem");
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            resources.ApplyResources(restartToolStripMenuItem, "restartToolStripMenuItem");
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(quitToolStripMenuItem, "quitToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // saveGameToolStripMenuItem
            // 
            saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            resources.ApplyResources(saveGameToolStripMenuItem, "saveGameToolStripMenuItem");
            // 
            // loadGameToolStripMenuItem
            // 
            loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            resources.ApplyResources(loadGameToolStripMenuItem, "loadGameToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // aIToolStripMenuItem
            // 
            aIToolStripMenuItem.Checked = true;
            aIToolStripMenuItem.CheckState = CheckState.Checked;
            aIToolStripMenuItem.Name = "aIToolStripMenuItem";
            resources.ApplyResources(aIToolStripMenuItem, "aIToolStripMenuItem");
            aIToolStripMenuItem.Click += aIToolStripMenuItem_Click;
            // 
            // helpStripMenuItem1
            // 
            helpStripMenuItem1.Name = "helpStripMenuItem1";
            resources.ApplyResources(helpStripMenuItem1, "helpStripMenuItem1");
            helpStripMenuItem1.Click += helpStripMenuItem1_Click;
            // 
            // startstopStripMenuItem1
            // 
            startstopStripMenuItem1.Name = "startstopStripMenuItem1";
            resources.ApplyResources(startstopStripMenuItem1, "startstopStripMenuItem1");
            startstopStripMenuItem1.Click += startstopStripMenuItem1_Click;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(button9, 2, 2);
            tableLayoutPanel1.Controls.Add(button8, 1, 2);
            tableLayoutPanel1.Controls.Add(button7, 0, 2);
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // button9
            // 
            resources.ApplyResources(button9, "button9");
            button9.FlatAppearance.BorderColor = Color.Black;
            button9.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button9.FlatAppearance.MouseOverBackColor = Color.White;
            button9.Name = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += board_Click;
            // 
            // button8
            // 
            resources.ApplyResources(button8, "button8");
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button8.FlatAppearance.MouseOverBackColor = Color.White;
            button8.Name = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += board_Click;
            // 
            // button7
            // 
            resources.ApplyResources(button7, "button7");
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button7.FlatAppearance.MouseOverBackColor = Color.White;
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += board_Click;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button6.FlatAppearance.MouseOverBackColor = Color.White;
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += board_Click;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button5.FlatAppearance.MouseOverBackColor = Color.White;
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += board_Click;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button4.FlatAppearance.MouseOverBackColor = Color.White;
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += board_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += board_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += board_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += board_Click;
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(textBox9, 2, 2);
            tableLayoutPanel2.Controls.Add(textBox8, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox7, 0, 2);
            tableLayoutPanel2.Controls.Add(textBox4, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox3, 2, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(button10, 1, 1);
            tableLayoutPanel2.Controls.Add(button11, 2, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // textBox9
            // 
            resources.ApplyResources(textBox9, "textBox9");
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            // 
            // textBox8
            // 
            resources.ApplyResources(textBox8, "textBox8");
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textBox7, "textBox7");
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textBox4, "textBox4");
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            // 
            // button10
            // 
            resources.ApplyResources(button10, "button10");
            button10.Name = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            resources.ApplyResources(button11, "button11");
            button11.Name = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private ToolStripMenuItem startstopStripMenuItem1;
        private Button button10;
        private Button button11;
    }
}