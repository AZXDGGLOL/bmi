namespace bmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            bmi = new Label();
            fullresult = new Label();
            label5 = new Label();
            btncal = new Button();
            tbweight = new TextBox();
            tbheight = new TextBox();
            tbbmi = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(177, 177);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 0;
            label1.Text = "น้ำหนัก (KG)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(177, 222);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 1;
            label2.Text = "ส่วนสูง (CM)";
            // 
            // bmi
            // 
            bmi.AutoSize = true;
            bmi.BackColor = SystemColors.HighlightText;
            bmi.Location = new Point(200, 382);
            bmi.Name = "bmi";
            bmi.Size = new Size(72, 23);
            bmi.TabIndex = 2;
            bmi.Text = "ค่า BMI :";
            // 
            // fullresult
            // 
            fullresult.BackColor = SystemColors.Control;
            fullresult.Location = new Point(290, 430);
            fullresult.Name = "fullresult";
            fullresult.Size = new Size(300, 140);
            fullresult.TabIndex = 3;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ButtonShadow;
            label5.Location = new Point(177, 22);
            label5.Name = "label5";
            label5.Size = new Size(489, 107);
            label5.TabIndex = 4;
            label5.Text = resources.GetString("label5.Text");
            // 
            // btncal
            // 
            btncal.Location = new Point(323, 268);
            btncal.Name = "btncal";
            btncal.Size = new Size(153, 71);
            btncal.TabIndex = 5;
            btncal.Text = "คำนวณค่า BMI";
            btncal.UseVisualStyleBackColor = true;
            btncal.Click += btnCal_Click;
            // 
            // tbweight
            // 
            tbweight.Location = new Point(290, 174);
            tbweight.Name = "tbweight";
            tbweight.Size = new Size(300, 30);
            tbweight.TabIndex = 6;
            // 
            // tbheight
            // 
            tbheight.Location = new Point(290, 218);
            tbheight.Name = "tbheight";
            tbheight.Size = new Size(300, 30);
            tbheight.TabIndex = 7;
            // 
            // tbbmi
            // 
            tbbmi.Location = new Point(290, 378);
            tbbmi.Name = "tbbmi";
            tbbmi.ReadOnly = true;
            tbbmi.Size = new Size(300, 30);
            tbbmi.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(868, 781);
            Controls.Add(tbbmi);
            Controls.Add(tbheight);
            Controls.Add(tbweight);
            Controls.Add(btncal);
            Controls.Add(label5);
            Controls.Add(fullresult);
            Controls.Add(bmi);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "โปรแกรมคำนวณค่า BMI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label bmi;
        private Label fullresult;
        private Label label5;
        private Button btncal;
        private TextBox tbweight;
        private TextBox tbheight;
        private TextBox tbbmi;
    }
}
