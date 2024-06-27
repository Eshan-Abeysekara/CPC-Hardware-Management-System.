namespace CPC_Hardware_Management_System
{
    partial class AddNewError
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
            button7 = new Button();
            button6 = new Button();
            txterror = new TextBox();
            label3 = new Label();
            label1 = new Label();
            button5 = new Button();
            panel2 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(txterror);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 537);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(735, 402);
            button7.Name = "button7";
            button7.Size = new Size(81, 34);
            button7.TabIndex = 10;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(608, 402);
            button6.Name = "button6";
            button6.Size = new Size(83, 34);
            button6.TabIndex = 9;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // txterror
            // 
            txterror.Location = new Point(480, 229);
            txterror.Name = "txterror";
            txterror.Size = new Size(336, 23);
            txterror.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(372, 229);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 4;
            label3.Text = "Error";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(502, 52);
            label1.Name = "label1";
            label1.Size = new Size(206, 37);
            label1.TabIndex = 2;
            label1.Text = "Add New Error";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(882, 3);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 1;
            button5.Text = "Close";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 531);
            panel2.TabIndex = 0;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(22, 189);
            button9.Name = "button9";
            button9.Size = new Size(204, 59);
            button9.TabIndex = 5;
            button9.Text = "Add New Item Model ";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(22, 104);
            button8.Name = "button8";
            button8.Size = new Size(204, 59);
            button8.TabIndex = 4;
            button8.Text = "Add New Item Brand\r\n";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button4
            // 
            button4.Location = new Point(22, 452);
            button4.Name = "button4";
            button4.Size = new Size(204, 59);
            button4.TabIndex = 3;
            button4.Text = "Add New Technicians";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(22, 364);
            button3.Name = "button3";
            button3.Size = new Size(204, 59);
            button3.TabIndex = 2;
            button3.Text = "Add New Resolving Status";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(23, 276);
            button2.Name = "button2";
            button2.Size = new Size(204, 59);
            button2.TabIndex = 1;
            button2.Text = "Add New Error";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(22, 17);
            button1.Name = "button1";
            button1.Size = new Size(204, 59);
            button1.TabIndex = 0;
            button1.Text = "Add New Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddNewError
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Ceylon_Petroleum_Corporation_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Name = "AddNewError";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewError";
            Load += AddNewError_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button button6;
        private TextBox txterror;
        private Label label3;
        private Label label1;
        private Button button5;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button8;
        private Button button9;
    }
}