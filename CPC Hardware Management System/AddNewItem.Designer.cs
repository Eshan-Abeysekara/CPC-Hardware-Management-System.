namespace CPC_Hardware_Management_System
{
    partial class AddNewItem
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
            txtitemmodel = new TextBox();
            txtitembrand = new TextBox();
            txtitemname = new TextBox();
            itemmodel = new Label();
            itembrand = new Label();
            itemname = new Label();
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
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(txtitemmodel);
            panel1.Controls.Add(txtitembrand);
            panel1.Controls.Add(txtitemname);
            panel1.Controls.Add(itemmodel);
            panel1.Controls.Add(itembrand);
            panel1.Controls.Add(itemname);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 537);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button7
            // 
            button7.Location = new Point(735, 402);
            button7.Name = "button7";
            button7.Size = new Size(81, 34);
            button7.TabIndex = 10;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(608, 402);
            button6.Name = "button6";
            button6.Size = new Size(83, 34);
            button6.TabIndex = 9;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // txtitemmodel
            // 
            txtitemmodel.Location = new Point(526, 296);
            txtitemmodel.Name = "txtitemmodel";
            txtitemmodel.Size = new Size(290, 23);
            txtitemmodel.TabIndex = 8;
            // 
            // txtitembrand
            // 
            txtitembrand.Location = new Point(526, 229);
            txtitembrand.Name = "txtitembrand";
            txtitembrand.Size = new Size(290, 23);
            txtitembrand.TabIndex = 7;
            // 
            // txtitemname
            // 
            txtitemname.Location = new Point(526, 166);
            txtitemname.Name = "txtitemname";
            txtitemname.Size = new Size(290, 23);
            txtitemname.TabIndex = 6;
            // 
            // itemmodel
            // 
            itemmodel.AutoSize = true;
            itemmodel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemmodel.Location = new Point(363, 295);
            itemmodel.Name = "itemmodel";
            itemmodel.Size = new Size(108, 25);
            itemmodel.TabIndex = 5;
            itemmodel.Text = "Item Model";
            // 
            // itembrand
            // 
            itembrand.AutoSize = true;
            itembrand.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itembrand.Location = new Point(363, 229);
            itembrand.Name = "itembrand";
            itembrand.Size = new Size(104, 25);
            itembrand.TabIndex = 4;
            itembrand.Text = "Item Brand";
            // 
            // itemname
            // 
            itemname.AutoSize = true;
            itemname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemname.Location = new Point(363, 164);
            itemname.Name = "itemname";
            itemname.Size = new Size(104, 25);
            itemname.TabIndex = 3;
            itemname.Text = "Item Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(502, 52);
            label1.Name = "label1";
            label1.Size = new Size(202, 37);
            label1.TabIndex = 2;
            label1.Text = "Add New Item";
            // 
            // button5
            // 
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
            button3.Location = new Point(23, 270);
            button3.Name = "button3";
            button3.Size = new Size(204, 59);
            button3.TabIndex = 2;
            button3.Text = "Add New Resolving Status";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
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
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(23, 85);
            button1.Name = "button1";
            button1.Size = new Size(204, 59);
            button1.TabIndex = 0;
            button1.Text = "Add New Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddNewItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Name = "AddNewItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewItem";
            Load += AddNewItem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label itemname;
        private TextBox txtitemmodel;
        private TextBox txtitembrand;
        private TextBox txtitemname;
        private Label itemmodel;
        private Label itembrand;
        private Button button7;
        private Button button6;
    }
}