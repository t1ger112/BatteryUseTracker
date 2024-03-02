namespace bet1
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
            dataviewer = new DataGridView();
            SignBTN = new Button();
            label1 = new Label();
            addBatteryBTN = new Button();
            panel1 = new Panel();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            batteryTBPro = new TextBox();
            label4 = new Label();
            lifetimeTBPro = new TextBox();
            label3 = new Label();
            nameTBPro = new TextBox();
            label2 = new Label();
            label6 = new Label();
            refreshData = new Button();
            textBox1 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataviewer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataviewer
            // 
            dataviewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataviewer.Location = new Point(48, 66);
            dataviewer.Name = "dataviewer";
            dataviewer.RowHeadersWidth = 51;
            dataviewer.RowTemplate.Height = 29;
            dataviewer.Size = new Size(534, 340);
            dataviewer.TabIndex = 0;
            dataviewer.CellClick += dataviewer_CellClick;
            dataviewer.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SignBTN
            // 
            SignBTN.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            SignBTN.Location = new Point(48, 428);
            SignBTN.Name = "SignBTN";
            SignBTN.Size = new Size(534, 79);
            SignBTN.TabIndex = 1;
            SignBTN.Text = "Sign device out";
            SignBTN.UseVisualStyleBackColor = true;
            SignBTN.Click += SignBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 8);
            label1.Name = "label1";
            label1.Size = new Size(295, 46);
            label1.TabIndex = 2;
            label1.Text = "Batteries / Devices";
            // 
            // addBatteryBTN
            // 
            addBatteryBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addBatteryBTN.Location = new Point(344, 11);
            addBatteryBTN.Name = "addBatteryBTN";
            addBatteryBTN.Size = new Size(125, 43);
            addBatteryBTN.TabIndex = 3;
            addBatteryBTN.Text = "Add battery";
            addBatteryBTN.UseVisualStyleBackColor = true;
            addBatteryBTN.Click += addBatteryBTN_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(batteryTBPro);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lifetimeTBPro);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nameTBPro);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(609, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 449);
            panel1.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(22, 385);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(197, 51);
            textBox6.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(21, 344);
            label8.Name = "label8";
            label8.Size = new Size(84, 38);
            label8.TabIndex = 10;
            label8.Text = "Temp";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(22, 216);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(197, 27);
            textBox4.TabIndex = 7;
            textBox4.Text = "21'C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 193);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Temp";
            // 
            // batteryTBPro
            // 
            batteryTBPro.Location = new Point(24, 160);
            batteryTBPro.Name = "batteryTBPro";
            batteryTBPro.Size = new Size(197, 27);
            batteryTBPro.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 135);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 4;
            label4.Text = "Battery Size";
            // 
            // lifetimeTBPro
            // 
            lifetimeTBPro.Location = new Point(21, 99);
            lifetimeTBPro.Name = "lifetimeTBPro";
            lifetimeTBPro.Size = new Size(200, 27);
            lifetimeTBPro.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 73);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Lifetime";
            // 
            // nameTBPro
            // 
            nameTBPro.Location = new Point(24, 39);
            nameTBPro.Name = "nameTBPro";
            nameTBPro.Size = new Size(197, 27);
            nameTBPro.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 10);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(631, 8);
            label6.Name = "label6";
            label6.Size = new Size(173, 46);
            label6.TabIndex = 5;
            label6.Text = "Properties";
            // 
            // refreshData
            // 
            refreshData.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            refreshData.Location = new Point(472, 8);
            refreshData.Name = "refreshData";
            refreshData.Size = new Size(110, 46);
            refreshData.TabIndex = 6;
            refreshData.Text = "Refresh";
            refreshData.UseVisualStyleBackColor = true;
            refreshData.Click += refreshData_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 253);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 12;
            label7.Text = "Lifetime use";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 518);
            Controls.Add(refreshData);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(addBatteryBTN);
            Controls.Add(label1);
            Controls.Add(SignBTN);
            Controls.Add(dataviewer);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataviewer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataviewer;
        private Button SignBTN;
        private Label label1;
        private Button addBatteryBTN;
        private Panel panel1;
        private TextBox textBox4;
        private Label label5;
        private TextBox batteryTBPro;
        private Label label4;
        private TextBox lifetimeTBPro;
        private Label label3;
        private TextBox nameTBPro;
        private Label label2;
        private Label label6;
        private TextBox textBox6;
        private Label label8;
        private Button refreshData;
        private TextBox textBox1;
        private Label label7;
    }
}
