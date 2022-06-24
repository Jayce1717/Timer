using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Timer
{
    public partial class Form1 : Form
    {
        DateTime dtIn, dtOut, dtCurrent, dtSec = new DateTime(2022, 1, 1, 12, 00, 00);
        bool go = false;
        bool view = false;
        bool specialView = false;
        bool cleared = false;
        int colorState = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (go)
            {
                cleared = true;
            }
                tbInHour.Text = "";
            tbInMin.Text = "";
            tbCurrentHour.Text = "";
            tbCurrentMin.Text = "";
            tbOutHour.Text = "";
            tbOutMin.Text = "";
            pbOne.Value = 0;
            rbInAM.Checked = true;
            rbCurrentAM.Checked = true;
            rbOutPM.Checked = true;
            go = false;
            dtIn = new DateTime(2022, 1, 1, 12, 00, 00);
            dtOut= new DateTime(2022, 1, 1, 12, 00, 00);
            dtCurrent = new DateTime(2022, 1, 1, 12, 00, 00);
            lblOne.Text = "Cleared";
            lblTime.Text = "";
            lblPercent.Text = "";
            pbOne.Style = ProgressBarStyle.Marquee;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
            System.Windows.Forms.Application.Exit();  
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!theChecker()) {
                lblOne.Text = "Invalid";
                return;
            }
            assignDateTimes();
            initLB();
            go = true;
            running();
        }

        private void running()
        {
            pbOne.Style = ProgressBarStyle.Continuous;
            dtSec = DateTime.Now.AddSeconds(1);
            while (go) {
                lblOne.Text = "Running";
                Application.DoEvents();
                updateLbls();
                if (hasBeenSecond() == true)
                {
                    dtCurrent = dtCurrent.AddSeconds(1);
                    dtSec = DateTime.Now.AddSeconds(1);
                    incrementLB();
                }
                if (!cleared)
                {
                    go = doneCheck();
                    cleared = false;
                }

            }
            return;
        }

        private bool hasBeenSecond()
        {
            DateTime comparor = DateTime.Now;
            if (comparor >= dtSec)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void finished()
        {
            pbOne.Value = 100;
            lblOne.Text = "Complete";
            lblTime.Text = "";
            lblPercent.Text = "";
            go = false;
        }

        private void updateLbls()
        {
            if (!go)
            {
                return;
            }


            string hour;
            string min;
            string sec;
            DateTime dtTest = new DateTime();

            double countOne;
            double countTwo;
            //int countThree;
            //string remHour;
            //string remMin;
            //string remSec;
            double dblRatio;
            int percent;

            countOne = 0;
            dtTest = dtIn;
            while (dtTest < dtCurrent)
            {
                countOne++;
                dtTest = dtTest.AddSeconds(1);
            }
            countTwo = 0;
            dtTest = dtIn;
            while (dtTest < dtOut)
            {
                countTwo++;
                dtTest = dtTest.AddSeconds(1);
            }

            dblRatio = (countOne / countTwo) * 100;
            percent = ((int)dblRatio);
            lblPercent.Text = percent.ToString() + "%";

            if (dtCurrent.Hour > 12)
            {
                hour = (dtCurrent.Hour - 12).ToString();
            }
            else
            {
                hour = dtCurrent.Hour.ToString();
            }

            if (dtCurrent.Minute < 10)
            {
                min = "0" + dtCurrent.Minute.ToString();
            }
            else
            {
                min = dtCurrent.Minute.ToString();
            }

            if (dtCurrent.Second < 10)
            {
                sec = "0" + dtCurrent.Second.ToString();
            }
            else
            {
                sec = dtCurrent.Second.ToString();
            }

            lblTime.Text = hour + ":" + min + ":" + sec;


        }

        private bool theChecker()
        {
            if (!int.TryParse(tbInMin.Text, out int a))
            {
                return false;
            }
           if (!int.TryParse(tbInHour.Text, out int b))
            {
                return false;
            }
            if (!int.TryParse(tbCurrentMin.Text, out int c))
            {
                return false;
            }
            if(!int.TryParse(tbCurrentHour.Text, out int d))
            {
                return false;
            }
            if(!int.TryParse(tbOutMin.Text, out int e))
            {
                return false;
            }
            if(!int.TryParse(tbOutHour.Text, out int f))
            {
                return false;
            }

            if ((a > 59) || (c > 59) || (e > 59)) 
            {
                return false;
            }
            if ((b > 12)||(d > 12) ||(f > 12))
            {
                return false;
            }

            if ((a < 0)||(b < 0) ||(c < 0) ||(d < 0) ||(e < 0) ||(f < 0))
            {
                return false;
            }

            int intime = 0, currenttime = 0, outtime = 0;

            intime = intime + (int.Parse(tbInHour.Text) * 60);
            intime = intime + int.Parse(tbInMin.Text);
            if (rbInPM.Checked)
            {
                intime = intime + 720;
            }

            currenttime = currenttime + (int.Parse(tbCurrentHour.Text) * 60);
            currenttime = currenttime + int.Parse(tbCurrentMin.Text);
            if (rbCurrentPM.Checked)
            {
                currenttime = currenttime + 720;
            }

            outtime = outtime + (int.Parse(tbOutHour.Text) * 60);
            outtime = outtime + int.Parse(tbOutMin.Text);
            if (rbOutPM.Checked)
            {
                outtime = outtime + 720;
            }

            if ((intime >= outtime)||(intime > currenttime)||(currenttime >= outtime))
            {
                return false;
            }

            if ((tbInHour.Text == "") || (tbInMin.Text == ""))
            {
                return false;
            }
            if ((tbCurrentHour.Text == "") || (tbCurrentMin.Text == ""))
            {
                return false;
            }
            if ((tbOutHour.Text == "") || (tbOutMin.Text == ""))
            {
                return false;
            }

            return true;    
        }

        private bool doneCheck()
        {
            if (dtCurrent >= dtOut)
            {
                finished();
                return false; //This means it is done. I know its backwards
            }
            else
            {
                return true; //Means not yet done
            }
        }
        
        private void initLB()
        {
            DateTime dtCountOne = dtIn;
            DateTime dtCountTwo = dtOut;
            int count = 0; //Overall time
            while(dtCountOne < dtCountTwo)
            {
                dtCountOne = dtCountOne.AddSeconds(1);
                count++;
            }

            DateTime dtCountThree = dtCurrent;
            DateTime dtCountFour = dtOut;
            int count2 = 0; //Remaining time
            while (dtCountThree < dtCountFour)
            {
                dtCountThree = dtCountThree.AddSeconds(1);
                count2++;
            }

            pbOne.Maximum = count;
            pbOne.Value = count-count2;
            pbOne.Step = 1;
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbOne.MarqueeAnimationSpeed = 10;
            pbOne.Style = ProgressBarStyle.Marquee;
            lblPercent.Text = "";
            lblTime.Text = "";
            lblOne.Text = "Welcome";
            DateTime init = DateTime.Now;
            if (init.Hour > 12)
            {
                tbCurrentHour.Text = (init.Hour - 12).ToString();
                rbCurrentPM.Checked = true;
            }
            else
            {
                tbCurrentHour.Text = init.Hour.ToString();
                rbCurrentAM.Checked = true;
            }
            if (init.Minute < 10)
            {
                tbCurrentMin.Text = "0" + init.Minute.ToString();
            }
            else
            {
                tbCurrentMin.Text = init.Minute.ToString();
            }
            //give tbInHour focus
            this.ActiveControl = tbInHour;
            initColors();
        }

        private void lblOne_Click(object sender, EventArgs e)
        {
            lblOne.Visible = !lblOne.Visible;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            view = !view;
            if (view)
            {
                this.Size = new Size(850, 109);
            }
            else
            {
                this.Size = new Size(850, 242);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            lblStatPercent.Visible = !lblStatPercent.Visible;
            lblPercent.Visible = !lblPercent.Visible;
            lblStatTime.Visible = !lblStatTime.Visible;
            lblTime.Visible = !lblTime.Visible;
            lblOne.Visible = !lblOne.Visible;
            lblStatusLabel.Visible = !lblStatusLabel.Visible;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DateTime init = DateTime.Now;
            if (init.Hour > 12)
            {
                tbCurrentHour.Text = (init.Hour - 12).ToString();
                rbCurrentPM.Checked = true;
            }
            else
            {
                tbCurrentHour.Text = init.Hour.ToString();
                rbCurrentAM.Checked = true;
            }
            if (init.Minute < 10)
            {
                tbCurrentMin.Text = "0" + init.Minute.ToString();
            }
            else
            {
                tbCurrentMin.Text = init.Minute.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tbInHour.Text = "9";
            tbInMin.Text = "00";
            rbInAM.Checked = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tbOutHour.Text = "5";
            tbOutMin.Text = "00";
            rbOutPM.Checked = true;
        }

        private void initColors()
        {
            pbOne.ForeColor = Color.Yellow;
            lblAndBtnColorChanger(255, 255, 192);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            const int numOfColors = 5;
            colorState++;
            if (colorState >= numOfColors)
            {
                colorState = 0;
            }
            switch (colorState)
            {
                case 0:
                    pbOne.ForeColor = Color.Yellow;
                    lblAndBtnColorChanger(255, 255, 192);
                    break;
                case 1:
                    pbOne.ForeColor = Color.MediumPurple;
                    lblAndBtnColorChanger(255, 192, 255);
                    break;
                case 2:
                    pbOne.ForeColor = Color.CornflowerBlue;
                    lblAndBtnColorChanger(192, 255, 255);
                    break;
                case 3:
                    pbOne.ForeColor = Color.Red;
                    lblAndBtnColorChanger(255, 100, 100);
                    break;
                case 4:
                default:
                    pbOne.ForeColor = Color.LawnGreen;
                    lblAndBtnColorChanger(128, 255, 128);
                    break;
            }
        }

        private void lblAndBtnColorChanger (int one, int two, int three)
        {
            btnExit.ForeColor = Color.FromArgb(one, two, three);
            btnStart.ForeColor = Color.FromArgb(one, two, three);
            btnClear.ForeColor = Color.FromArgb(one, two, three);
            tbInMin.ForeColor = Color.FromArgb(one, two, three);
            tbInHour.ForeColor = Color.FromArgb(one, two, three);
            tbCurrentMin.ForeColor = Color.FromArgb(one, two, three);
            tbCurrentHour.ForeColor = Color.FromArgb(one, two, three);
            tbOutMin.ForeColor = Color.FromArgb(one, two, three);
            tbOutHour.ForeColor = Color.FromArgb(one, two, three);
            rbInAM.ForeColor = Color.FromArgb(one, two, three);
            rbInPM.ForeColor = Color.FromArgb(one, two, three);
            rbCurrentAM.ForeColor = Color.FromArgb(one, two, three);
            rbCurrentPM.ForeColor = Color.FromArgb(one, two, three);
            rbOutAM.ForeColor = Color.FromArgb(one, two, three);
            rbOutPM.ForeColor = Color.FromArgb(one, two, three);
            lblTime.ForeColor = Color.FromArgb(one, two, three);
            lblPercent.ForeColor = Color.FromArgb(one, two, three);
            lblOne.ForeColor = Color.FromArgb(one, two, three);
            btnColor.ForeColor = Color.FromArgb(one, two, three);
            btnStats.ForeColor = Color.FromArgb(one, two, three);
            btnView.ForeColor = Color.FromArgb(one, two, three);

        }

        private void pbOne_Click(object sender, EventArgs e)
        {
            if (view)
            {
                if (specialView)
                {
                    this.Size = new Size(850, 109);
                    specialView = false;
                    return;
                }

                this.Size = new Size(850, 79);
                specialView = true;
                return;
            }

        }

        private void rbInAM_CheckedChanged(object sender, EventArgs e)
        {
            if(rbInPM.Checked == true)
            {
                rbInPM.Font = new Font(rbInPM.Font, FontStyle.Bold);
                rbInAM.Font = new Font(rbInAM.Font, FontStyle.Regular);
            }
            else
            {
                rbInAM.Font = new Font(rbInAM.Font, FontStyle.Bold);
                rbInPM.Font = new Font(rbInPM.Font, FontStyle.Regular);
            }
        }

        private void rbCurrentAM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCurrentPM.Checked == true)
            {
                rbCurrentPM.Font = new Font(rbCurrentPM.Font, FontStyle.Bold);
                rbCurrentAM.Font = new Font(rbCurrentAM.Font, FontStyle.Regular);
            }
            else
            {
                rbCurrentAM.Font = new Font(rbCurrentAM.Font, FontStyle.Bold);
                rbCurrentPM.Font = new Font(rbCurrentPM.Font, FontStyle.Regular);
            }
        }

        private void rbOutAM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOutPM.Checked == true)
            {
                rbOutPM.Font = new Font(rbOutPM.Font, FontStyle.Bold);
                rbOutAM.Font = new Font(rbOutAM.Font, FontStyle.Regular);
            }
            else
            {
                rbOutAM.Font = new Font(rbOutAM.Font, FontStyle.Bold);
                rbOutPM.Font = new Font(rbOutPM.Font, FontStyle.Regular);
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void incrementLB()
        {
            pbOne.PerformStep();
        }



        private void assignDateTimes()
        {
            if (rbInPM.Checked == true)
            {
                int hour = int.Parse(tbInHour.Text)+12;
                int min = int.Parse(tbInMin.Text);
                dtIn = new DateTime(2022, 1, 1, hour, min, 00);
            }
            else
            {
                int hour = int.Parse(tbInHour.Text);
                int min = int.Parse(tbInMin.Text);
                dtIn = new DateTime(2022, 1, 1, hour, min, 00);
            }
            if (rbCurrentPM.Checked == true)
            {
                int hour = int.Parse(tbCurrentHour.Text) + 12;
                int min = int.Parse(tbCurrentMin.Text);
                dtCurrent = new DateTime(2022, 1, 1, hour, min, 00);
            }
            else
            {
                int hour = int.Parse(tbCurrentHour.Text);
                int min = int.Parse(tbCurrentMin.Text);
                dtCurrent = new DateTime(2022, 1, 1, hour, min, 00);
            }
            if (rbOutPM.Checked == true)
            {
                int hour = int.Parse(tbOutHour.Text) + 12;
                int min = int.Parse(tbOutMin.Text);
                dtOut = new DateTime(2022, 1, 1, hour, min, 00);
            }
            else
            {
                int hour = int.Parse(tbOutHour.Text);
                int min = int.Parse(tbOutMin.Text);
                dtOut = new DateTime(2022, 1, 1, hour, min, 00);
            }
        }
    }
}
