namespace bet1
{
    partial class AddDevice
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
            label3 = new Label();
            lifetimeTB = new TextBox();
            batterySizeCB = new ComboBox();
            label2 = new Label();
            submitBTN = new Button();
            deviceNameTB = new TextBox();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 229);
            label3.Name = "label3";
            label3.Size = new Size(137, 30);
            label3.TabIndex = 13;
            label3.Text = "Lifetime hours";
            // 
            // lifetimeTB
            // 
            lifetimeTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lifetimeTB.Location = new Point(48, 262);
            lifetimeTB.Name = "lifetimeTB";
            lifetimeTB.Size = new Size(384, 43);
            lifetimeTB.TabIndex = 12;
            // 
            // batterySizeCB
            // 
            batterySizeCB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            batterySizeCB.FormattingEnabled = true;
            batterySizeCB.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            batterySizeCB.Location = new Point(47, 173);
            batterySizeCB.Name = "batterySizeCB";
            batterySizeCB.Size = new Size(385, 45);
            batterySizeCB.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 142);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 10;
            label2.Text = "Battery Size";
            // 
            // submitBTN
            // 
            submitBTN.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            submitBTN.Location = new Point(47, 320);
            submitBTN.Name = "submitBTN";
            submitBTN.Size = new Size(385, 93);
            submitBTN.TabIndex = 9;
            submitBTN.Text = "submit";
            submitBTN.UseVisualStyleBackColor = true;
            submitBTN.Click += submitBTN_Click;
            // 
            // deviceNameTB
            // 
            deviceNameTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deviceNameTB.Location = new Point(47, 96);
            deviceNameTB.Name = "deviceNameTB";
            deviceNameTB.Size = new Size(385, 43);
            deviceNameTB.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 68);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 7;
            label1.Text = "Device Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(129, 9);
            label4.Name = "label4";
            label4.Size = new Size(204, 50);
            label4.TabIndex = 14;
            label4.Text = "Add device";
            // 
            // AddDevice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lifetimeTB);
            Controls.Add(batterySizeCB);
            Controls.Add(label2);
            Controls.Add(submitBTN);
            Controls.Add(deviceNameTB);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AddDevice";
            Text = "AddDevice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox lifetimeTB;
        private ComboBox batterySizeCB;
        private Label label2;
        private Button submitBTN;
        private TextBox deviceNameTB;
        private Label label1;
        private Label label4;
    }
}