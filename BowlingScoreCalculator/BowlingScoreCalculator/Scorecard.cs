using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowlingScoreCalculator
{
    public partial class Scorecard : Form
    {
        #region Form Components
        public Game game;
        public Scorecard()
        {
            InitializeComponent();
        }

        private TextBox frame1_Ball1;
        private TextBox frame1_Ball2;
        private TextBox frame2_Ball1;
        private TextBox frame2_Ball2;

        private TextBox frame3_Ball1;
        private TextBox frame3_Ball2;

        private TextBox frame4_Ball1;
        private TextBox frame4_Ball2;

        private TextBox frame5_Ball1;
        private TextBox frame5_Ball2;

        private TextBox frame6_Ball1;
        private TextBox frame6_Ball2;

        private TextBox frame7_Ball1;
        private TextBox frame7_Ball2;

        private TextBox frame8_Ball1;
        private TextBox frame8_Ball2;

        private TextBox frame9_Ball1;
        private TextBox frame9_Ball2;

        private TextBox frame10_Ball1;
        private TextBox frame10_Ball2;
        private TextBox frame10_Ball3;

        private TextBox frame1Score;
        private TextBox frame2Score;
        private TextBox frame3Score;
        private TextBox frame4Score;
        private TextBox frame5Score;
        private TextBox frame6Score;
        private TextBox frame7Score;
        private TextBox frame8Score;
        private TextBox frame9Score;
        private TextBox frame10Score;

        private Label lblFrame1;
        private Label lblFrame2;
        private Label lblFrame3;
        private Label lblFrame4;
        private Label lblFrame5;
        private Label lblFrame6;
        private Label lblFrame7;
        private Label lblFrame8;
        private Label lblFrame9;
        private Label lblFrame10;

        private Label errorMessage;

        private bool eventInProgress = false;

        private void InitializeComponent()
        {
            game = new Game();
            ScoringLogic.game = game;

            this.frame1_Ball1 = new System.Windows.Forms.TextBox();
            this.frame1_Ball2 = new System.Windows.Forms.TextBox();
            this.frame2_Ball1 = new System.Windows.Forms.TextBox();
            this.frame2_Ball2 = new System.Windows.Forms.TextBox();
            this.frame3_Ball1 = new System.Windows.Forms.TextBox();
            this.frame3_Ball2 = new System.Windows.Forms.TextBox();
            this.frame4_Ball1 = new System.Windows.Forms.TextBox();
            this.frame4_Ball2 = new System.Windows.Forms.TextBox();
            this.frame5_Ball1 = new System.Windows.Forms.TextBox();
            this.frame5_Ball2 = new System.Windows.Forms.TextBox();
            this.frame6_Ball1 = new System.Windows.Forms.TextBox();
            this.frame6_Ball2 = new System.Windows.Forms.TextBox();
            this.frame7_Ball1 = new System.Windows.Forms.TextBox();
            this.frame7_Ball2 = new System.Windows.Forms.TextBox();
            this.frame8_Ball1 = new System.Windows.Forms.TextBox();
            this.frame8_Ball2 = new System.Windows.Forms.TextBox();
            this.frame9_Ball1 = new System.Windows.Forms.TextBox();
            this.frame9_Ball2 = new System.Windows.Forms.TextBox();
            this.frame10_Ball1 = new System.Windows.Forms.TextBox();
            this.frame10_Ball2 = new System.Windows.Forms.TextBox();
            this.frame10_Ball3 = new System.Windows.Forms.TextBox();
            this.frame1Score = new System.Windows.Forms.TextBox();
            this.frame2Score = new System.Windows.Forms.TextBox();
            this.frame3Score = new System.Windows.Forms.TextBox();
            this.frame4Score = new System.Windows.Forms.TextBox();
            this.frame5Score = new System.Windows.Forms.TextBox();
            this.frame6Score = new System.Windows.Forms.TextBox();
            this.frame7Score = new System.Windows.Forms.TextBox();
            this.frame8Score = new System.Windows.Forms.TextBox();
            this.frame9Score = new System.Windows.Forms.TextBox();
            this.frame10Score = new System.Windows.Forms.TextBox();
            this.lblFrame1 = new System.Windows.Forms.Label();
            this.lblFrame2 = new System.Windows.Forms.Label();
            this.lblFrame3 = new System.Windows.Forms.Label();
            this.lblFrame4 = new System.Windows.Forms.Label();
            this.lblFrame5 = new System.Windows.Forms.Label();
            this.lblFrame6 = new System.Windows.Forms.Label();
            this.lblFrame7 = new System.Windows.Forms.Label();
            this.lblFrame8 = new System.Windows.Forms.Label();
            this.lblFrame9 = new System.Windows.Forms.Label();
            this.lblFrame10 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frame1_Ball1
            // 
            this.frame1_Ball1.Location = new System.Drawing.Point(40, 40);
            this.frame1_Ball1.Name = "frame1_Ball1";
            this.frame1_Ball1.Size = new System.Drawing.Size(20, 20);
            this.frame1_Ball1.TabIndex = 0;
            this.frame1_Ball1.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame1_Ball2
            // 
            this.frame1_Ball2.Enabled = false;
            this.frame1_Ball2.Location = new System.Drawing.Point(60, 40);
            this.frame1_Ball2.Name = "frame1_Ball2";
            this.frame1_Ball2.Size = new System.Drawing.Size(20, 20);
            this.frame1_Ball2.TabIndex = 0;
            this.frame1_Ball2.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame2_Ball1
            // 
            this.frame2_Ball1.Enabled = false;
            this.frame2_Ball1.Location = new System.Drawing.Point(80, 40);
            this.frame2_Ball1.Name = "frame2_Ball1";
            this.frame2_Ball1.Size = new System.Drawing.Size(20, 20);
            this.frame2_Ball1.TabIndex = 1;
            this.frame2_Ball1.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame2_Ball2
            // 
            this.frame2_Ball2.Enabled = false;
            this.frame2_Ball2.Location = new System.Drawing.Point(100, 40);
            this.frame2_Ball2.Name = "frame2_Ball2";
            this.frame2_Ball2.Size = new System.Drawing.Size(20, 20);
            this.frame2_Ball2.TabIndex = 2;
            this.frame2_Ball2.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame3_Ball1
            // 
            this.frame3_Ball1.Enabled = false;
            this.frame3_Ball1.Location = new System.Drawing.Point(120, 40);
            this.frame3_Ball1.Name = "frame3_Ball1";
            this.frame3_Ball1.Size = new System.Drawing.Size(20, 20);
            this.frame3_Ball1.TabIndex = 3;
            this.frame3_Ball1.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame3_Ball2
            // 
            this.frame3_Ball2.Enabled = false;
            this.frame3_Ball2.Location = new System.Drawing.Point(140, 40);
            this.frame3_Ball2.Name = "frame3_Ball2";
            this.frame3_Ball2.Size = new System.Drawing.Size(20, 20);
            this.frame3_Ball2.TabIndex = 4;
            this.frame3_Ball2.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame4_Ball1
            // 
            this.frame4_Ball1.Enabled = false;
            this.frame4_Ball1.Location = new System.Drawing.Point(160, 40);
            this.frame4_Ball1.Name = "frame4_Ball1";
            this.frame4_Ball1.Size = new System.Drawing.Size(20, 20);
            this.frame4_Ball1.TabIndex = 5;
            this.frame4_Ball1.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame4_Ball2
            // 
            this.frame4_Ball2.Enabled = false;
            this.frame4_Ball2.Location = new System.Drawing.Point(180, 40);
            this.frame4_Ball2.Name = "frame4_Ball2";
            this.frame4_Ball2.Size = new System.Drawing.Size(20, 20);
            this.frame4_Ball2.TabIndex = 6;
            this.frame4_Ball2.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame5_Ball1
            // 
            this.frame5_Ball1.Enabled = false;
            this.frame5_Ball1.Location = new System.Drawing.Point(200, 40);
            this.frame5_Ball1.Name = "frame5_Ball1";
            this.frame5_Ball1.Size = new System.Drawing.Size(20, 20);
            this.frame5_Ball1.TabIndex = 7;
            this.frame5_Ball1.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame5_Ball2
            // 
            this.frame5_Ball2.Enabled = false;
            this.frame5_Ball2.Location = new System.Drawing.Point(220, 40);
            this.frame5_Ball2.Name = "frame5_Ball2";
            this.frame5_Ball2.Size = new System.Drawing.Size(20, 20);
            this.frame5_Ball2.TabIndex = 8;
            this.frame5_Ball2.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame6_Ball1
            // 
            this.frame6_Ball1.Enabled = false;
            this.frame6_Ball1.Location = new System.Drawing.Point(240, 40);
            this.frame6_Ball1.Name = "frame6_Ball1";
            this.frame6_Ball1.Size = new System.Drawing.Size(20, 20);
            this.frame6_Ball1.TabIndex = 9;
            this.frame6_Ball1.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame6_Ball2
            // 
            this.frame6_Ball2.Enabled = false;
            this.frame6_Ball2.Location = new System.Drawing.Point(260, 40);
            this.frame6_Ball2.Name = "frame6_Ball2";
            this.frame6_Ball2.Size = new System.Drawing.Size(20, 20);
            this.frame6_Ball2.TabIndex = 10;
            this.frame6_Ball2.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame7_Ball1
            // 
            this.frame7_Ball1.Enabled = false;
            this.frame7_Ball1.Location = new System.Drawing.Point(280, 40);
            this.frame7_Ball1.Name = "frame7_Ball1";
            this.frame7_Ball1.Size = new System.Drawing.Size(20, 20);
            this.frame7_Ball1.TabIndex = 11;
            this.frame7_Ball1.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame7_Ball2
            // 
            this.frame7_Ball2.Enabled = false;
            this.frame7_Ball2.Location = new System.Drawing.Point(300, 40);
            this.frame7_Ball2.Name = "frame7_Ball2";
            this.frame7_Ball2.Size = new System.Drawing.Size(20, 20);
            this.frame7_Ball2.TabIndex = 12;
            this.frame7_Ball2.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame8_Ball1
            // 
            this.frame8_Ball1.Enabled = false;
            this.frame8_Ball1.Location = new System.Drawing.Point(320, 40);
            this.frame8_Ball1.Name = "frame8_Ball1";
            this.frame8_Ball1.Size = new System.Drawing.Size(20, 20);
            this.frame8_Ball1.TabIndex = 13;
            this.frame8_Ball1.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame8_Ball2
            // 
            this.frame8_Ball2.Enabled = false;
            this.frame8_Ball2.Location = new System.Drawing.Point(340, 40);
            this.frame8_Ball2.Name = "frame8_Ball2";
            this.frame8_Ball2.Size = new System.Drawing.Size(20, 20);
            this.frame8_Ball2.TabIndex = 14;
            this.frame8_Ball2.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame9_Ball1
            // 
            this.frame9_Ball1.Enabled = false;
            this.frame9_Ball1.Location = new System.Drawing.Point(360, 40);
            this.frame9_Ball1.Name = "frame9_Ball1";
            this.frame9_Ball1.Size = new System.Drawing.Size(20, 20);
            this.frame9_Ball1.TabIndex = 15;
            this.frame9_Ball1.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame9_Ball2
            // 
            this.frame9_Ball2.Enabled = false;
            this.frame9_Ball2.Location = new System.Drawing.Point(380, 40);
            this.frame9_Ball2.Name = "frame9_Ball2";
            this.frame9_Ball2.Size = new System.Drawing.Size(20, 20);
            this.frame9_Ball2.TabIndex = 16;
            this.frame9_Ball2.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame10_Ball1
            // 
            this.frame10_Ball1.Enabled = false;
            this.frame10_Ball1.Location = new System.Drawing.Point(400, 40);
            this.frame10_Ball1.Name = "frame10_Ball1";
            this.frame10_Ball1.Size = new System.Drawing.Size(20, 20);
            this.frame10_Ball1.TabIndex = 17;
            this.frame10_Ball1.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame10_Ball2
            // 
            this.frame10_Ball2.Enabled = false;
            this.frame10_Ball2.Location = new System.Drawing.Point(420, 40);
            this.frame10_Ball2.Name = "frame10_Ball2";
            this.frame10_Ball2.Size = new System.Drawing.Size(20, 20);
            this.frame10_Ball2.TabIndex = 18;
            this.frame10_Ball2.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame10_Ball3
            // 
            this.frame10_Ball3.Enabled = false;
            this.frame10_Ball3.Location = new System.Drawing.Point(440, 40);
            this.frame10_Ball3.Name = "frame10_Ball3";
            this.frame10_Ball3.Size = new System.Drawing.Size(20, 20);
            this.frame10_Ball3.TabIndex = 19;
            this.frame10_Ball3.TextChanged += new System.EventHandler(this.frameBall_TextChanged);
            // 
            // frame1Score
            // 
            this.frame1Score.Location = new System.Drawing.Point(40, 60);
            this.frame1Score.Name = "frame1Score";
            this.frame1Score.ReadOnly = true;
            this.frame1Score.Size = new System.Drawing.Size(40, 20);
            this.frame1Score.TabIndex = 20;
            // 
            // frame2Score
            // 
            this.frame2Score.Location = new System.Drawing.Point(80, 60);
            this.frame2Score.Name = "frame2Score";
            this.frame2Score.ReadOnly = true;
            this.frame2Score.Size = new System.Drawing.Size(40, 20);
            this.frame2Score.TabIndex = 20;
            // 
            // frame3Score
            // 
            this.frame3Score.Location = new System.Drawing.Point(120, 60);
            this.frame3Score.Name = "frame3Score";
            this.frame3Score.ReadOnly = true;
            this.frame3Score.Size = new System.Drawing.Size(40, 20);
            this.frame3Score.TabIndex = 20;
            // 
            // frame4Score
            // 
            this.frame4Score.Location = new System.Drawing.Point(160, 60);
            this.frame4Score.Name = "frame4Score";
            this.frame4Score.ReadOnly = true;
            this.frame4Score.Size = new System.Drawing.Size(40, 20);
            this.frame4Score.TabIndex = 20;
            // 
            // frame5Score
            // 
            this.frame5Score.Location = new System.Drawing.Point(200, 60);
            this.frame5Score.Name = "frame5Score";
            this.frame5Score.ReadOnly = true;
            this.frame5Score.Size = new System.Drawing.Size(40, 20);
            this.frame5Score.TabIndex = 20;
            // 
            // frame6Score
            // 
            this.frame6Score.Location = new System.Drawing.Point(240, 60);
            this.frame6Score.Name = "frame6Score";
            this.frame6Score.ReadOnly = true;
            this.frame6Score.Size = new System.Drawing.Size(40, 20);
            this.frame6Score.TabIndex = 20;
            // 
            // frame7Score
            // 
            this.frame7Score.Location = new System.Drawing.Point(280, 60);
            this.frame7Score.Name = "frame7Score";
            this.frame7Score.ReadOnly = true;
            this.frame7Score.Size = new System.Drawing.Size(40, 20);
            this.frame7Score.TabIndex = 20;
            // 
            // frame8Score
            // 
            this.frame8Score.Location = new System.Drawing.Point(320, 60);
            this.frame8Score.Name = "frame8Score";
            this.frame8Score.ReadOnly = true;
            this.frame8Score.Size = new System.Drawing.Size(40, 20);
            this.frame8Score.TabIndex = 20;
            // 
            // frame9Score
            // 
            this.frame9Score.Location = new System.Drawing.Point(360, 60);
            this.frame9Score.Name = "frame9Score";
            this.frame9Score.ReadOnly = true;
            this.frame9Score.Size = new System.Drawing.Size(40, 20);
            this.frame9Score.TabIndex = 20;
            // 
            // frame10Score
            // 
            this.frame10Score.Location = new System.Drawing.Point(400, 60);
            this.frame10Score.Name = "frame10Score";
            this.frame10Score.ReadOnly = true;
            this.frame10Score.Size = new System.Drawing.Size(60, 20);
            this.frame10Score.TabIndex = 20;
            // 
            // lblFrame1
            // 
            this.lblFrame1.AutoSize = true;
            this.lblFrame1.Location = new System.Drawing.Point(54, 26);
            this.lblFrame1.Name = "lblFrame1";
            this.lblFrame1.Size = new System.Drawing.Size(13, 13);
            this.lblFrame1.TabIndex = 21;
            this.lblFrame1.Text = "1";
            // 
            // lblFrame2
            // 
            this.lblFrame2.AutoSize = true;
            this.lblFrame2.Location = new System.Drawing.Point(94, 26);
            this.lblFrame2.Name = "lblFrame2";
            this.lblFrame2.Size = new System.Drawing.Size(13, 13);
            this.lblFrame2.TabIndex = 21;
            this.lblFrame2.Text = "2";
            // 
            // lblFrame3
            // 
            this.lblFrame3.AutoSize = true;
            this.lblFrame3.Location = new System.Drawing.Point(133, 26);
            this.lblFrame3.Name = "lblFrame3";
            this.lblFrame3.Size = new System.Drawing.Size(13, 13);
            this.lblFrame3.TabIndex = 21;
            this.lblFrame3.Text = "3";
            // 
            // lblFrame4
            // 
            this.lblFrame4.AutoSize = true;
            this.lblFrame4.Location = new System.Drawing.Point(173, 26);
            this.lblFrame4.Name = "lblFrame4";
            this.lblFrame4.Size = new System.Drawing.Size(13, 13);
            this.lblFrame4.TabIndex = 21;
            this.lblFrame4.Text = "4";
            // 
            // lblFrame5
            // 
            this.lblFrame5.AutoSize = true;
            this.lblFrame5.Location = new System.Drawing.Point(214, 26);
            this.lblFrame5.Name = "lblFrame5";
            this.lblFrame5.Size = new System.Drawing.Size(13, 13);
            this.lblFrame5.TabIndex = 21;
            this.lblFrame5.Text = "5";
            // 
            // lblFrame6
            // 
            this.lblFrame6.AutoSize = true;
            this.lblFrame6.Location = new System.Drawing.Point(254, 26);
            this.lblFrame6.Name = "lblFrame6";
            this.lblFrame6.Size = new System.Drawing.Size(13, 13);
            this.lblFrame6.TabIndex = 21;
            this.lblFrame6.Text = "6";
            // 
            // lblFrame7
            // 
            this.lblFrame7.AutoSize = true;
            this.lblFrame7.Location = new System.Drawing.Point(293, 26);
            this.lblFrame7.Name = "lblFrame7";
            this.lblFrame7.Size = new System.Drawing.Size(13, 13);
            this.lblFrame7.TabIndex = 21;
            this.lblFrame7.Text = "7";
            // 
            // lblFrame8
            // 
            this.lblFrame8.AutoSize = true;
            this.lblFrame8.Location = new System.Drawing.Point(333, 26);
            this.lblFrame8.Name = "lblFrame8";
            this.lblFrame8.Size = new System.Drawing.Size(13, 13);
            this.lblFrame8.TabIndex = 21;
            this.lblFrame8.Text = "8";
            // 
            // lblFrame9
            // 
            this.lblFrame9.AutoSize = true;
            this.lblFrame9.Location = new System.Drawing.Point(374, 26);
            this.lblFrame9.Name = "lblFrame9";
            this.lblFrame9.Size = new System.Drawing.Size(13, 13);
            this.lblFrame9.TabIndex = 21;
            this.lblFrame9.Text = "9";
            // 
            // lblFrame10
            // 
            this.lblFrame10.AutoSize = true;
            this.lblFrame10.Location = new System.Drawing.Point(420, 26);
            this.lblFrame10.Name = "lblFrame10";
            this.lblFrame10.Size = new System.Drawing.Size(19, 13);
            this.lblFrame10.TabIndex = 21;
            this.lblFrame10.Text = "10";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(40, 100);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(71, 13);
            this.errorMessage.TabIndex = 22;
            this.errorMessage.Text = "";
            // 
            // Scorecard
            // 
            this.ClientSize = new System.Drawing.Size(556, 312);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.lblFrame1);
            this.Controls.Add(this.lblFrame2);
            this.Controls.Add(this.lblFrame3);
            this.Controls.Add(this.lblFrame4);
            this.Controls.Add(this.lblFrame5);
            this.Controls.Add(this.lblFrame6);
            this.Controls.Add(this.lblFrame7);
            this.Controls.Add(this.lblFrame8);
            this.Controls.Add(this.lblFrame9);
            this.Controls.Add(this.lblFrame10);
            this.Controls.Add(this.frame1_Ball1);
            this.Controls.Add(this.frame1_Ball2);
            this.Controls.Add(this.frame2_Ball1);
            this.Controls.Add(this.frame2_Ball2);
            this.Controls.Add(this.frame3_Ball1);
            this.Controls.Add(this.frame3_Ball2);
            this.Controls.Add(this.frame4_Ball1);
            this.Controls.Add(this.frame4_Ball2);
            this.Controls.Add(this.frame5_Ball1);
            this.Controls.Add(this.frame5_Ball2);
            this.Controls.Add(this.frame6_Ball1);
            this.Controls.Add(this.frame6_Ball2);
            this.Controls.Add(this.frame7_Ball1);
            this.Controls.Add(this.frame7_Ball2);
            this.Controls.Add(this.frame8_Ball1);
            this.Controls.Add(this.frame8_Ball2);
            this.Controls.Add(this.frame9_Ball1);
            this.Controls.Add(this.frame9_Ball2);
            this.Controls.Add(this.frame10_Ball1);
            this.Controls.Add(this.frame10_Ball2);
            this.Controls.Add(this.frame10_Ball3);
            this.Controls.Add(this.frame1Score);
            this.Controls.Add(this.frame2Score);
            this.Controls.Add(this.frame3Score);
            this.Controls.Add(this.frame4Score);
            this.Controls.Add(this.frame5Score);
            this.Controls.Add(this.frame6Score);
            this.Controls.Add(this.frame7Score);
            this.Controls.Add(this.frame8Score);
            this.Controls.Add(this.frame9Score);
            this.Controls.Add(this.frame10Score);
            this.Name = "Scorecard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private void frameBall_TextChanged(object sender, EventArgs e)
        {
            this.errorMessage.Text = "";
            if (eventInProgress) return;
            eventInProgress = true;

            TextBox textBox = (TextBox)sender;

            int ballNumber;
            int frameNumber;
            string[] frameBall = textBox.Name.Split('_');

            frameNumber = int.Parse(frameBall[0].Replace("frame", ""));
            ballNumber = int.Parse(frameBall[1].Replace("Ball", ""));

            Frame currFrame = game.GetFrame(frameNumber);
            MarkFutureFramesAsDirty(currFrame);

            try
            {
                textBox.Text = ValidateText(textBox.Text, currFrame, ballNumber);
                if (ballNumber == 1)
                {
                    TextBox textBox2 = Controls.Find("frame" + currFrame.Number.ToString() + "_Ball" + (ballNumber + 1).ToString(), true)[0] as TextBox;
                    if (textBox2.Enabled) textBox2.Text = "";
                }
                if (ballNumber == 2 && currFrame.Number == 10)
                {
                    TextBox textBox3 = Controls.Find("frame" + currFrame.Number.ToString() + "_Ball" + (ballNumber + 1).ToString(), true)[0] as TextBox;
                    if (textBox3.Enabled) textBox3.Text = "";
                }
            }
            catch (Exception ex)
            {
                textBox.Text = "";
                this.errorMessage.Text = ex.Message;
                eventInProgress = false;
                return;
            }

            try
            {
                ScoringLogic.ShotLogic(textBox.Text, currFrame, ballNumber);
                if (game.GetFrame(1).MarkType != eMarkType.NotThrown) this.frame1Score.Text = game.GetFrame(1).Score.ToString();
                if (game.GetFrame(2).MarkType != eMarkType.NotThrown) this.frame2Score.Text = game.GetFrame(2).Score.ToString();
                if (game.GetFrame(3).MarkType != eMarkType.NotThrown) this.frame3Score.Text = game.GetFrame(3).Score.ToString();
                if (game.GetFrame(4).MarkType != eMarkType.NotThrown) this.frame4Score.Text = game.GetFrame(4).Score.ToString();
                if (game.GetFrame(5).MarkType != eMarkType.NotThrown) this.frame5Score.Text = game.GetFrame(5).Score.ToString();
                if (game.GetFrame(6).MarkType != eMarkType.NotThrown) this.frame6Score.Text = game.GetFrame(6).Score.ToString();
                if (game.GetFrame(7).MarkType != eMarkType.NotThrown) this.frame7Score.Text = game.GetFrame(7).Score.ToString();
                if (game.GetFrame(8).MarkType != eMarkType.NotThrown) this.frame8Score.Text = game.GetFrame(8).Score.ToString();
                if (game.GetFrame(9).MarkType != eMarkType.NotThrown) this.frame9Score.Text = game.GetFrame(9).Score.ToString();
                if (game.GetFrame(10).MarkType != eMarkType.NotThrown) this.frame10Score.Text = game.GetFrame(10).Score.ToString();

                TextBox frameScore = Controls.Find("frame" + currFrame.Number.ToString() + "Score", true)[0] as TextBox;
                frameScore.ForeColor = (currFrame.IsScoringComplete) ? Color.Black : Color.Gray;
                TextBox nextBall;
                if (currFrame.Number == 10)
                {
                    if (game.GetFrame(10).FirstBall.MarkType != eMarkType.NotThrown && game.GetFrame(10).SecondBall.MarkType == eMarkType.NotThrown)
                    {
                        nextBall = this.frame10_Ball2;
                    }
                    else
                    {
                        if (game.GetFrame(10).FirstBall.MarkType == eMarkType.Strike || game.GetFrame(10).SecondBall.MarkType == eMarkType.Spare)
                        { // check to ensure we are supposed to be on the third ball
                            nextBall = this.frame10_Ball3;
                        }
                        else
                            throw new Exception("The game is over! Your final Score is " + game.TotalScore.ToString());
                    }
                }
                else
                {
                    if (currFrame.FirstBall.MarkType == eMarkType.Strike || currFrame.SecondBall.MarkType != eMarkType.NotThrown)
                        nextBall = Controls.Find("frame" + (currFrame.Number + 1).ToString() + "_Ball1", true)[0] as TextBox;
                    else
                        nextBall = Controls.Find("frame" + currFrame.Number.ToString() + "_Ball2", true)[0] as TextBox;
                }

                nextBall.Enabled = true;
                nextBall.Select();
            }
            catch (Exception ex)
            {
                this.errorMessage.Text = ex.Message;
            }
            eventInProgress = false;
        }
        private string ValidateText(string ballText, Frame currFrame, int ballNumber)
        {
            int ballValue;
            if (ballText.ToLower() == "x")
            {
                if (ballNumber != 1 && currFrame.Number != 10)
                    throw new Exception("Please enter a valid score");
                else if (ballNumber == 2 && currFrame.Number == 10 && currFrame.FirstBall.MarkType != eMarkType.Strike)
                    throw new Exception("Please enter a valid score");
                else if (ballNumber == 3 && currFrame.Number == 10 && currFrame.SecondBall.MarkType != eMarkType.Strike)
                    throw new Exception("Please enter a valid score");
                ballText = "X";
            }
            else if (ballText == "0" || ballText == "-")
                ballText = "-";
            else if (ballText == "f")
                ballText = "F";
            else if (ballText == "/")
            {
                if (ballNumber == 1)
                    throw new Exception("Please enter a valid score");
                else if (ballNumber == 2 && currFrame.Number == 10 && currFrame.FirstBall.MarkType == eMarkType.Strike)
                    throw new Exception("Please enter a valid score");
                else if (ballNumber == 3 && currFrame.Number == 10 && currFrame.SecondBall.MarkType == eMarkType.Strike)
                    throw new Exception("Please enter a valid score");
            }
            else
            {
                bool isInt = int.TryParse(ballText, out ballValue);
                if (!isInt || (ballValue < 0 || ballValue > 9))
                    throw new Exception("Please enter a valid score");
                if (ballNumber != 1 && ballText != "/")
                {
                    if (ballNumber == 2 && currFrame.FirstBall.Value + ballValue == 10)
                        ballText = "/";
                    else if (ballNumber == 2 && currFrame.FirstBall.Value + ballValue > 10 && currFrame.FirstBall.MarkType != eMarkType.Strike)
                        throw new Exception("You have entered a number higher than the remaining number of pins. Please enter a valid score");
                    if (ballNumber == 3 && currFrame.Number == 10 && currFrame.SecondBall.MarkType != eMarkType.Spare && currFrame.SecondBall.Value + ballValue == 10)
                        ballText = "/";
                    else if (ballNumber == 3 && currFrame.Number == 10 && currFrame.SecondBall.Value + ballValue > 10)
                        throw new Exception("You have entered a number higher than the remaining number of pins. Please enter a valid score");
                }
            }
            return ballText;
        }
        private void MarkFutureFramesAsDirty(Frame frame)
        {
            for (int i = frame.Number; i <= 10; i++)
            {
                game.GetFrame(i).IsScoringComplete = false;
            }
        }
    }
}
