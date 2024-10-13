namespace DashBoard
{
    partial class Form1
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
            btnClose = new Button();
            panelMenu = new Panel();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            panelLogo = new Panel();
            btnMaximize = new Button();
            btnMinimize = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(901, 13);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(38, 38);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(46, 51, 73);
            panelMenu.Controls.Add(btn6);
            panelMenu.Controls.Add(btn5);
            panelMenu.Controls.Add(btn4);
            panelMenu.Controls.Add(btn3);
            panelMenu.Controls.Add(btn2);
            panelMenu.Controls.Add(btn1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 577);
            panelMenu.TabIndex = 1;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Bottom;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(0, 522);
            btn6.Name = "btn6";
            btn6.Size = new Size(250, 55);
            btn6.TabIndex = 1;
            btn6.Text = "button1";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Top;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(0, 308);
            btn5.Name = "btn5";
            btn5.Size = new Size(250, 55);
            btn5.TabIndex = 1;
            btn5.Text = "button1";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Top;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(0, 253);
            btn4.Name = "btn4";
            btn4.Size = new Size(250, 55);
            btn4.TabIndex = 1;
            btn4.Text = "button1";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Top;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(0, 198);
            btn3.Name = "btn3";
            btn3.Size = new Size(250, 55);
            btn3.TabIndex = 1;
            btn3.Text = "button1";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Top;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(0, 143);
            btn2.Name = "btn2";
            btn2.Size = new Size(250, 55);
            btn2.TabIndex = 1;
            btn2.Text = "button1";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Top;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(0, 88);
            btn1.Name = "btn1";
            btn1.Size = new Size(250, 55);
            btn1.TabIndex = 1;
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 88);
            panelLogo.TabIndex = 0;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(873, 17);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.TabIndex = 0;
            btnMaximize.Text = "■";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(837, 16);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "―";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(panelMenu);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
    }
}