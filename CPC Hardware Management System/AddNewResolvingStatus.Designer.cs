﻿namespace CPC_Hardware_Management_System
{
    partial class AddNewResolvingStatus
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
            txtresolvingstatus = new TextBox();
            label3 = new Label();
            label1 = new Label();
            button5 = new Button();
            panel2 = new Panel();
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
            panel1.Controls.Add(txtresolvingstatus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 537);
            panel1.TabIndex = 3;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.Location = new Point(768, 402);
            button7.Name = "button7";
            button7.Size = new Size(81, 34);
            button7.TabIndex = 10;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.Location = new Point(626, 402);
            button6.Name = "button6";
            button6.Size = new Size(83, 34);
            button6.TabIndex = 9;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // txtresolvingstatus
            // 
            txtresolvingstatus.Location = new Point(513, 235);
            txtresolvingstatus.Name = "txtresolvingstatus";
            txtresolvingstatus.Size = new Size(336, 23);
            txtresolvingstatus.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(327, 233);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 4;
            label3.Text = "Resolving Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(439, 55);
            label1.Name = "label1";
            label1.Size = new Size(353, 37);
            label1.TabIndex = 2;
            label1.Text = "Add New Resolving Status";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
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
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 531);
            panel2.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(23, 369);
            button4.Name = "button4";
            button4.Size = new Size(204, 59);
            button4.TabIndex = 3;
            button4.Text = "Add New Technicians";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(23, 270);
            button3.Name = "button3";
            button3.Size = new Size(204, 59);
            button3.TabIndex = 2;
            button3.Text = "Add New Resolving Status";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(23, 174);
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
            button1.Location = new Point(23, 85);
            button1.Name = "button1";
            button1.Size = new Size(204, 59);
            button1.TabIndex = 0;
            button1.Text = "Add New Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddNewResolvingStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Ceylon_Petroleum_Corporation_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Name = "AddNewResolvingStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewResolvingStatus";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button button6;
        private TextBox txtresolvingstatus;
        private Label label3;
        private Label label1;
        private Button button5;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}