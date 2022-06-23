
namespace Timer
{
    partial class Form1
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
            this.tbCurrentHour = new System.Windows.Forms.TextBox();
            this.tbCurrentMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOutMin = new System.Windows.Forms.TextBox();
            this.tbOutHour = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInMin = new System.Windows.Forms.TextBox();
            this.tbInHour = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbOne = new System.Windows.Forms.ProgressBar();
            this.rbCurrentAM = new System.Windows.Forms.RadioButton();
            this.rbCurrentPM = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbInAM = new System.Windows.Forms.RadioButton();
            this.rbInPM = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbOutAM = new System.Windows.Forms.RadioButton();
            this.rbOutPM = new System.Windows.Forms.RadioButton();
            this.lblOne = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCurrentHour
            // 
            this.tbCurrentHour.Location = new System.Drawing.Point(204, 60);
            this.tbCurrentHour.Name = "tbCurrentHour";
            this.tbCurrentHour.Size = new System.Drawing.Size(25, 20);
            this.tbCurrentHour.TabIndex = 0;
            this.tbCurrentHour.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbCurrentMin
            // 
            this.tbCurrentMin.Location = new System.Drawing.Point(235, 60);
            this.tbCurrentMin.Name = "tbCurrentMin";
            this.tbCurrentMin.Size = new System.Drawing.Size(25, 20);
            this.tbCurrentMin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Out time:";
            // 
            // tbOutMin
            // 
            this.tbOutMin.Location = new System.Drawing.Point(235, 102);
            this.tbOutMin.Name = "tbOutMin";
            this.tbOutMin.Size = new System.Drawing.Size(25, 20);
            this.tbOutMin.TabIndex = 4;
            // 
            // tbOutHour
            // 
            this.tbOutHour.Location = new System.Drawing.Point(204, 102);
            this.tbOutHour.Name = "tbOutHour";
            this.tbOutHour.Size = new System.Drawing.Size(25, 20);
            this.tbOutHour.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(281, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "In time:";
            // 
            // tbInMin
            // 
            this.tbInMin.Location = new System.Drawing.Point(235, 20);
            this.tbInMin.Name = "tbInMin";
            this.tbInMin.Size = new System.Drawing.Size(25, 20);
            this.tbInMin.TabIndex = 9;
            // 
            // tbInHour
            // 
            this.tbInHour.Location = new System.Drawing.Point(204, 20);
            this.tbInHour.Name = "tbInHour";
            this.tbInHour.Size = new System.Drawing.Size(25, 20);
            this.tbInHour.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(281, 59);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbOne
            // 
            this.pbOne.Location = new System.Drawing.Point(12, 145);
            this.pbOne.Name = "pbOne";
            this.pbOne.Size = new System.Drawing.Size(783, 23);
            this.pbOne.TabIndex = 12;
            // 
            // rbCurrentAM
            // 
            this.rbCurrentAM.AutoSize = true;
            this.rbCurrentAM.Checked = true;
            this.rbCurrentAM.Location = new System.Drawing.Point(6, 9);
            this.rbCurrentAM.Name = "rbCurrentAM";
            this.rbCurrentAM.Size = new System.Drawing.Size(41, 17);
            this.rbCurrentAM.TabIndex = 13;
            this.rbCurrentAM.TabStop = true;
            this.rbCurrentAM.Text = "AM";
            this.rbCurrentAM.UseVisualStyleBackColor = true;
            // 
            // rbCurrentPM
            // 
            this.rbCurrentPM.AutoSize = true;
            this.rbCurrentPM.Location = new System.Drawing.Point(53, 9);
            this.rbCurrentPM.Name = "rbCurrentPM";
            this.rbCurrentPM.Size = new System.Drawing.Size(41, 17);
            this.rbCurrentPM.TabIndex = 14;
            this.rbCurrentPM.Text = "PM";
            this.rbCurrentPM.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCurrentAM);
            this.groupBox1.Controls.Add(this.rbCurrentPM);
            this.groupBox1.Location = new System.Drawing.Point(104, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 36);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbInAM);
            this.groupBox2.Controls.Add(this.rbInPM);
            this.groupBox2.Location = new System.Drawing.Point(104, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 36);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // rbInAM
            // 
            this.rbInAM.AutoSize = true;
            this.rbInAM.Checked = true;
            this.rbInAM.Location = new System.Drawing.Point(6, 9);
            this.rbInAM.Name = "rbInAM";
            this.rbInAM.Size = new System.Drawing.Size(41, 17);
            this.rbInAM.TabIndex = 13;
            this.rbInAM.TabStop = true;
            this.rbInAM.Text = "AM";
            this.rbInAM.UseVisualStyleBackColor = true;
            // 
            // rbInPM
            // 
            this.rbInPM.AutoSize = true;
            this.rbInPM.Location = new System.Drawing.Point(53, 9);
            this.rbInPM.Name = "rbInPM";
            this.rbInPM.Size = new System.Drawing.Size(41, 17);
            this.rbInPM.TabIndex = 14;
            this.rbInPM.Text = "PM";
            this.rbInPM.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbOutAM);
            this.groupBox3.Controls.Add(this.rbOutPM);
            this.groupBox3.Location = new System.Drawing.Point(104, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(97, 36);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // rbOutAM
            // 
            this.rbOutAM.AutoSize = true;
            this.rbOutAM.Location = new System.Drawing.Point(6, 9);
            this.rbOutAM.Name = "rbOutAM";
            this.rbOutAM.Size = new System.Drawing.Size(41, 17);
            this.rbOutAM.TabIndex = 13;
            this.rbOutAM.Text = "AM";
            this.rbOutAM.UseVisualStyleBackColor = true;
            // 
            // rbOutPM
            // 
            this.rbOutPM.AutoSize = true;
            this.rbOutPM.Checked = true;
            this.rbOutPM.Location = new System.Drawing.Point(53, 9);
            this.rbOutPM.Name = "rbOutPM";
            this.rbOutPM.Size = new System.Drawing.Size(41, 17);
            this.rbOutPM.TabIndex = 14;
            this.rbOutPM.TabStop = true;
            this.rbOutPM.Text = "PM";
            this.rbOutPM.UseVisualStyleBackColor = true;
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(416, 25);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(37, 13);
            this.lblOne.TabIndex = 21;
            this.lblOne.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 186);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbOne);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInMin);
            this.Controls.Add(this.tbInHour);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOutMin);
            this.Controls.Add(this.tbOutHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCurrentMin);
            this.Controls.Add(this.tbCurrentHour);
            this.Name = "Form1";
            this.Text = "Jayces Timer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCurrentHour;
        private System.Windows.Forms.TextBox tbCurrentMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOutMin;
        private System.Windows.Forms.TextBox tbOutHour;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInMin;
        private System.Windows.Forms.TextBox tbInHour;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar pbOne;
        private System.Windows.Forms.RadioButton rbCurrentAM;
        private System.Windows.Forms.RadioButton rbCurrentPM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbInAM;
        private System.Windows.Forms.RadioButton rbInPM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbOutAM;
        private System.Windows.Forms.RadioButton rbOutPM;
        private System.Windows.Forms.Label lblOne;
    }
}

