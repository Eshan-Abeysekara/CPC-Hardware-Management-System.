namespace CPC_Hardware_Management_System
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 537);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            button5.Location = new Point(754, 486);
            button5.Name = "button5";
            button5.Size = new Size(68, 30);
            button5.TabIndex = 4;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button4.Location = new Point(599, 323);
            button4.Name = "button4";
            button4.Size = new Size(223, 89);
            button4.TabIndex = 3;
            button4.Text = "Delete Record";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button3.Location = new Point(130, 323);
            button3.Name = "button3";
            button3.Size = new Size(232, 89);
            button3.TabIndex = 2;
            button3.Text = "Search Record";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button2.Location = new Point(599, 97);
            button2.Name = "button2";
            button2.Size = new Size(223, 98);
            button2.TabIndex = 1;
            button2.Text = "Update Record";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(130, 97);
            button1.Name = "button1";
            button1.Size = new Size(232, 98);
            button1.TabIndex = 0;
            button1.Text = "New Record";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Ceylon_Petroleum_Corporation_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
    }
}