
namespace IntervalTimer
{
    partial class TimerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.activity = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.groupBoxDuring = new System.Windows.Forms.GroupBox();
            this.groupBoxStart = new System.Windows.Forms.GroupBox();
            this.groupBoxDuring.SuspendLayout();
            this.groupBoxStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(64, 29);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 50);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Let\'s go!!!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // activity
            // 
            this.activity.BackColor = System.Drawing.Color.Transparent;
            this.activity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.activity.Location = new System.Drawing.Point(168, 167);
            this.activity.Name = "activity";
            this.activity.Size = new System.Drawing.Size(400, 50);
            this.activity.TabIndex = 3;
            this.activity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeLabel.Location = new System.Drawing.Point(168, 92);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(400, 60);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "  ";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(21, 19);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(124, 19);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 23);
            this.btnResume.TabIndex = 6;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(224, 19);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // groupBoxDuring
            // 
            this.groupBoxDuring.BackColor = System.Drawing.Color.White;
            this.groupBoxDuring.Controls.Add(this.groupBoxStart);
            this.groupBoxDuring.Controls.Add(this.btnRestart);
            this.groupBoxDuring.Controls.Add(this.btnPause);
            this.groupBoxDuring.Controls.Add(this.btnResume);
            this.groupBoxDuring.Location = new System.Drawing.Point(201, 252);
            this.groupBoxDuring.Name = "groupBoxDuring";
            this.groupBoxDuring.Size = new System.Drawing.Size(318, 100);
            this.groupBoxDuring.TabIndex = 8;
            this.groupBoxDuring.TabStop = false;
            // 
            // groupBoxStart
            // 
            this.groupBoxStart.BackColor = System.Drawing.Color.White;
            this.groupBoxStart.Controls.Add(this.startButton);
            this.groupBoxStart.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStart.Name = "groupBoxStart";
            this.groupBoxStart.Size = new System.Drawing.Size(318, 100);
            this.groupBoxStart.TabIndex = 0;
            this.groupBoxStart.TabStop = false;
            // 
            // TimerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBoxDuring);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.activity);
            this.Name = "TimerControl";
            this.Size = new System.Drawing.Size(917, 612);
            this.groupBoxDuring.ResumeLayout(false);
            this.groupBoxStart.ResumeLayout(false);
            this.groupBoxStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label activity;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.GroupBox groupBoxDuring;
        private System.Windows.Forms.GroupBox groupBoxStart;
    }
}
