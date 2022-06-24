
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStatTime = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblStatPercent = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCurrentHour
            // 
            this.tbCurrentHour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbCurrentHour.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbCurrentHour.Location = new System.Drawing.Point(385, 124);
            this.tbCurrentHour.Name = "tbCurrentHour";
            this.tbCurrentHour.Size = new System.Drawing.Size(25, 20);
            this.tbCurrentHour.TabIndex = 0;
            this.tbCurrentHour.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbCurrentMin
            // 
            this.tbCurrentMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbCurrentMin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbCurrentMin.Location = new System.Drawing.Point(416, 124);
            this.tbCurrentMin.Name = "tbCurrentMin";
            this.tbCurrentMin.Size = new System.Drawing.Size(25, 20);
            this.tbCurrentMin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(186, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(211, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Out time:";
            // 
            // tbOutMin
            // 
            this.tbOutMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbOutMin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbOutMin.Location = new System.Drawing.Point(416, 166);
            this.tbOutMin.Name = "tbOutMin";
            this.tbOutMin.Size = new System.Drawing.Size(25, 20);
            this.tbOutMin.TabIndex = 4;
            // 
            // tbOutHour
            // 
            this.tbOutHour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbOutHour.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbOutHour.Location = new System.Drawing.Point(385, 166);
            this.tbOutHour.Name = "tbOutHour";
            this.tbOutHour.Size = new System.Drawing.Size(25, 20);
            this.tbOutHour.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(462, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(462, 164);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(224, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "In time:";
            // 
            // tbInMin
            // 
            this.tbInMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbInMin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbInMin.Location = new System.Drawing.Point(416, 84);
            this.tbInMin.Name = "tbInMin";
            this.tbInMin.Size = new System.Drawing.Size(25, 20);
            this.tbInMin.TabIndex = 9;
            // 
            // tbInHour
            // 
            this.tbInHour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbInHour.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbInHour.Location = new System.Drawing.Point(385, 84);
            this.tbInHour.Name = "tbInHour";
            this.tbInHour.Size = new System.Drawing.Size(25, 20);
            this.tbInHour.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(462, 123);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbOne
            // 
            this.pbOne.Location = new System.Drawing.Point(17, 8);
            this.pbOne.Name = "pbOne";
            this.pbOne.Size = new System.Drawing.Size(800, 23);
            this.pbOne.TabIndex = 12;
            // 
            // rbCurrentAM
            // 
            this.rbCurrentAM.AutoSize = true;
            this.rbCurrentAM.Checked = true;
            this.rbCurrentAM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.rbCurrentPM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.groupBox1.Location = new System.Drawing.Point(285, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 36);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbInAM);
            this.groupBox2.Controls.Add(this.rbInPM);
            this.groupBox2.Location = new System.Drawing.Point(285, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 36);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // rbInAM
            // 
            this.rbInAM.AutoSize = true;
            this.rbInAM.Checked = true;
            this.rbInAM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.rbInPM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.groupBox3.Location = new System.Drawing.Point(285, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(97, 36);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // rbOutAM
            // 
            this.rbOutAM.AutoSize = true;
            this.rbOutAM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.rbOutPM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.lblOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOne.Location = new System.Drawing.Point(325, 44);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(37, 13);
            this.lblOne.TabIndex = 21;
            this.lblOne.Text = "Status";
            this.lblOne.Click += new System.EventHandler(this.lblOne_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnView.Location = new System.Drawing.Point(11, 39);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(70, 23);
            this.btnView.TabIndex = 22;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnStats.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStats.Location = new System.Drawing.Point(91, 39);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(70, 23);
            this.btnStats.TabIndex = 23;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.Location = new System.Drawing.Point(741, 39);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 20);
            this.lblTime.TabIndex = 24;
            this.lblTime.Text = "12:12:12";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblStatTime
            // 
            this.lblStatTime.AutoSize = true;
            this.lblStatTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatTime.Location = new System.Drawing.Point(654, 40);
            this.lblStatTime.Name = "lblStatTime";
            this.lblStatTime.Size = new System.Drawing.Size(93, 18);
            this.lblStatTime.TabIndex = 26;
            this.lblStatTime.Text = "Current time:";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPercent.Location = new System.Drawing.Point(598, 39);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(54, 20);
            this.lblPercent.TabIndex = 28;
            this.lblPercent.Text = "100%";
            // 
            // lblStatPercent
            // 
            this.lblStatPercent.AutoSize = true;
            this.lblStatPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatPercent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatPercent.Location = new System.Drawing.Point(471, 40);
            this.lblStatPercent.Name = "lblStatPercent";
            this.lblStatPercent.Size = new System.Drawing.Size(128, 18);
            this.lblStatPercent.TabIndex = 29;
            this.lblStatPercent.Text = "Percent complete:";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatusLabel.Location = new System.Drawing.Point(288, 44);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.lblStatusLabel.TabIndex = 30;
            this.lblStatusLabel.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(834, 202);
            this.Controls.Add(this.lblStatusLabel);
            this.Controls.Add(this.lblStatPercent);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblStatTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnView);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Jayces Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStatTime;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblStatPercent;
        private System.Windows.Forms.Label lblStatusLabel;
    }
}

