namespace CPC_Hardware_Management_System
{
    partial class SearchRecord
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label9 = new Label();
            dateandtime2 = new DateTimePicker();
            label8 = new Label();
            cmbresolvingstatus = new ComboBox();
            cmbassetno = new ComboBox();
            cmbserialno = new ComboBox();
            cmbrefno = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            cmberror = new ComboBox();
            cmblocation = new ComboBox();
            dateandtime1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 537);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(3, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 493);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(948, 324);
            dataGridView1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(dateandtime2);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cmbresolvingstatus);
            panel3.Controls.Add(cmbassetno);
            panel3.Controls.Add(cmbserialno);
            panel3.Controls.Add(cmbrefno);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(cmberror);
            panel3.Controls.Add(cmblocation);
            panel3.Controls.Add(dateandtime1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(948, 157);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(813, 36);
            label9.Name = "label9";
            label9.Size = new Size(24, 21);
            label9.TabIndex = 21;
            label9.Text = "to";
            // 
            // dateandtime2
            // 
            dateandtime2.Location = new Point(738, 62);
            dateandtime2.Name = "dateandtime2";
            dateandtime2.Size = new Size(183, 23);
            dateandtime2.TabIndex = 20;
            dateandtime2.ValueChanged += dateandtime2_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.Location = new Point(300, 22);
            label8.Name = "label8";
            label8.Size = new Size(147, 25);
            label8.TabIndex = 6;
            label8.Text = "Resolving Status";
            // 
            // cmbresolvingstatus
            // 
            cmbresolvingstatus.FormattingEnabled = true;
            cmbresolvingstatus.Location = new Point(460, 22);
            cmbresolvingstatus.Name = "cmbresolvingstatus";
            cmbresolvingstatus.Size = new Size(121, 23);
            cmbresolvingstatus.TabIndex = 13;
            cmbresolvingstatus.SelectedIndexChanged += cmbresolvingstatus_SelectedIndexChanged;
            // 
            // cmbassetno
            // 
            cmbassetno.FormattingEnabled = true;
            cmbassetno.Location = new Point(460, 63);
            cmbassetno.Name = "cmbassetno";
            cmbassetno.Size = new Size(121, 23);
            cmbassetno.TabIndex = 19;
            // 
            // cmbserialno
            // 
            cmbserialno.FormattingEnabled = true;
            cmbserialno.Location = new Point(124, 61);
            cmbserialno.Name = "cmbserialno";
            cmbserialno.Size = new Size(121, 23);
            cmbserialno.TabIndex = 18;
            // 
            // cmbrefno
            // 
            cmbrefno.FormattingEnabled = true;
            cmbrefno.Location = new Point(124, 22);
            cmbrefno.Name = "cmbrefno";
            cmbrefno.Size = new Size(121, 23);
            cmbrefno.TabIndex = 17;
            // 
            // button3
            // 
            button3.Location = new Point(836, 107);
            button3.Name = "button3";
            button3.Size = new Size(85, 38);
            button3.TabIndex = 16;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(738, 107);
            button2.Name = "button2";
            button2.Size = new Size(85, 38);
            button2.TabIndex = 15;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(640, 107);
            button1.Name = "button1";
            button1.Size = new Size(85, 38);
            button1.TabIndex = 14;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmberror
            // 
            cmberror.FormattingEnabled = true;
            cmberror.Location = new Point(460, 105);
            cmberror.Name = "cmberror";
            cmberror.Size = new Size(121, 23);
            cmberror.TabIndex = 12;
            // 
            // cmblocation
            // 
            cmblocation.FormattingEnabled = true;
            cmblocation.Items.AddRange(new object[] { "Colombo", "Katunayaka" });
            cmblocation.Location = new Point(124, 106);
            cmblocation.Name = "cmblocation";
            cmblocation.Size = new Size(121, 23);
            cmblocation.TabIndex = 9;
            // 
            // dateandtime1
            // 
            dateandtime1.Location = new Point(738, 10);
            dateandtime1.Name = "dateandtime1";
            dateandtime1.Size = new Size(183, 23);
            dateandtime1.TabIndex = 8;
            dateandtime1.ValueChanged += dateandtime1_ValueChanged;
            dateandtime1.KeyDown += dateandtime1_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(300, 106);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 5;
            label7.Text = "Error";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(300, 63);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 4;
            label6.Text = "Asset No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(3, 60);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 3;
            label5.Text = "Serial No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(3, 106);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 2;
            label4.Text = "Location";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(641, 36);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 1;
            label3.Text = "Date";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 0;
            label2.Text = "Ref No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 1);
            label1.Name = "label1";
            label1.Size = new Size(199, 37);
            label1.TabIndex = 1;
            label1.Text = "Search Record";
            // 
            // SearchRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Name = "SearchRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchRecord";
            Load += SearchRecord_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private ComboBox cmbresolvingstatus;
        private ComboBox cmberror;
        private ComboBox cmblocation;
        private DateTimePicker dateandtime1;
        private DataGridView dataGridView1;
        private Button button3;
        private ComboBox cmbassetno;
        private ComboBox cmbserialno;
        private ComboBox cmbrefno;
        private DateTimePicker dateandtime2;
        private Label label9;
    }
}