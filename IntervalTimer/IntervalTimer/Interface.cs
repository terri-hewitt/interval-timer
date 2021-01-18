using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Timers;
//using System.Media;

namespace IntervalTimer
{
    public class Interface: Form
    {
        private Panel panel1;
        private TimerControl timerControl;
        private Button btnSelectWorkout;
        private SetWorkoutControl setWorkoutControl;
        private Button btn_createExercises;
        private CreateExercises createExercises;
        private Button btnHome;

        public Interface()
        {
            this.Text = "Interval Timer";
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectWorkout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btn_createExercises = new System.Windows.Forms.Button();
            this.setWorkoutControl = new IntervalTimer.SetWorkoutControl();
            this.timerControl = new IntervalTimer.TimerControl();
            this.createExercises = new IntervalTimer.CreateExercises();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btn_createExercises);
            this.panel1.Controls.Add(this.btnSelectWorkout);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(100, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 458);
            this.panel1.TabIndex = 3;
            // 
            // btnSelectWorkout
            // 
            this.btnSelectWorkout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectWorkout.Location = new System.Drawing.Point(26, 112);
            this.btnSelectWorkout.Name = "btnSelectWorkout";
            this.btnSelectWorkout.Size = new System.Drawing.Size(102, 23);
            this.btnSelectWorkout.TabIndex = 2;
            this.btnSelectWorkout.Text = "Select Workout";
            this.btnSelectWorkout.UseVisualStyleBackColor = false;
            this.btnSelectWorkout.Click += new System.EventHandler(this.btnSelectWorkout_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(26, 141);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(102, 23);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Start Workout";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btn_createExercises
            // 
            this.btn_createExercises.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_createExercises.Location = new System.Drawing.Point(26, 83);
            this.btn_createExercises.Name = "btn_createExercises";
            this.btn_createExercises.Size = new System.Drawing.Size(102, 23);
            this.btn_createExercises.TabIndex = 0;
            this.btn_createExercises.Text = "Create Exercises";
            this.btn_createExercises.UseVisualStyleBackColor = false;
            this.btn_createExercises.Click += new System.EventHandler(this.btn_createExercises_Click);
            // 
            // setWorkoutControl
            // 
            this.setWorkoutControl.AllowDrop = true;
            this.setWorkoutControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setWorkoutControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.setWorkoutControl.Location = new System.Drawing.Point(134, 0);
            this.setWorkoutControl.Name = "setWorkoutControl";
            this.setWorkoutControl.Size = new System.Drawing.Size(712, 458);
            this.setWorkoutControl.TabIndex = 6;
            // 
            // timerControl
            // 
            this.timerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timerControl.BackColor = System.Drawing.Color.White;
            this.timerControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timerControl.Location = new System.Drawing.Point(134, 0);
            this.timerControl.Name = "timerControl";
            this.timerControl.Size = new System.Drawing.Size(712, 458);
            this.timerControl.TabIndex = 5;
            // 
            // createExercises
            // 
            this.createExercises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createExercises.Location = new System.Drawing.Point(134, 0);
            this.createExercises.Name = "createExercises";
            this.createExercises.Size = new System.Drawing.Size(712, 458);
            this.createExercises.TabIndex = 7;
            // 
            // Interface
            // 
            this.ClientSize = new System.Drawing.Size(844, 458);
            this.Controls.Add(this.createExercises);
            this.Controls.Add(this.setWorkoutControl);
            this.Controls.Add(this.timerControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Interface";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setWorkoutControl.Hide();
            createExercises.Hide();

            timerControl.Show();
            timerControl.BringToFront();
        }

        private void btnSelectWorkout_Click(object sender, EventArgs e)
        {
            timerControl.Hide();
            createExercises.Hide();

            setWorkoutControl.Show();
            setWorkoutControl.BringToFront();
        }

        private void btn_createExercises_Click(object sender, EventArgs e)
        {
            timerControl.Hide();
            setWorkoutControl.Hide();

            createExercises.Show();
            createExercises.BringToFront();
        }
    }
}
