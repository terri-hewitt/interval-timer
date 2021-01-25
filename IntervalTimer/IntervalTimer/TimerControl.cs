using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;
using System.Speech.Synthesis;

namespace IntervalTimer
{
    public partial class TimerControl : UserControl
    {
        private bool isRest;
        private int timeLeft;
        private int setsRemaining;
        private int exerciseNum;
        private int transitionTime;
        private ExerciseRepModel nextExercise;
        private SpeechSynthesizer textReader;

        private const int COUNTDOWN = 3;
        private System.Windows.Forms.Timer timer;

        public TimerControl()
        {
            InitializeComponent();
            InitializeTimer();
            groupBoxStart.BringToFront();
            groupBoxDuring.SendToBack();

            btnResume.Enabled = false;
            btnPause.Enabled = false;
            textReader = new SpeechSynthesizer();
        }

        private void InitializeTimer()
        {
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
        }

        private void StartWorkout()
        {
            if (Settings.Instance.getNumExercises() <= 0)
            {
                activity.Text = "Error: No exercises in queue!";

                startButton.Enabled = true;    // Re-enable start button
            }
            else
            {
                transitionTime = Settings.Instance.getTransitionTime();
                isRest = false;
                setsRemaining = Settings.Instance.getNumSets();
                timeLeft = COUNTDOWN;   // Initial countdown
                activity.Text = "Get Ready!";
                this.timer.Enabled = true;
                timer.Start();  // Start the interval timer
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;    // Disable start button
            btnResume.Enabled = false;
            btnPause.Enabled = true;

            groupBoxDuring.Visible = true;
            groupBoxStart.Visible = false;

            StartWorkout();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLabel.Text = timeLeft + " seconds";
                timeLeft--;
                /*if (timeLeft <= 2 && !isRest)
                {
                    timer.Stop();  
                    Console.Beep(1000, 80);
                    timer.Start();
                }*/
            }
            else  // Timer ran out
            {
                timeLabel.Text = "";
                timer.Stop();
                //SystemSounds.Beep.Play();
                Console.Beep(1000, 80);


                // If ending transition phase or set rest
               /* if (isRest)
                {
                    exerciseNum++;      // Go to next exercise
                }*/
                if (exerciseNum >= Settings.Instance.getNumExercises()) // Finished a set of exercises
                {
                    activity.Text = "Rest";
                    textReader.SpeakAsync(activity.Text);
                    isRest = false;

                    timeLeft = Settings.Instance.getSetRestTime();
                    exerciseNum = 0;    // Reset exercises to beginning
                    setsRemaining--;    // Decrement number of sets left
                    if (setsRemaining == 0)     // If finished sets, done. Stop the workout
                    {
                        timeLabel.Text = "Finished!";
                        activity.Text = "";
                        timer.Stop();
                        startButton.Enabled = true;    // Disable start button
                        return;
                    }
                }
                // Else
                else
                {
                    // If transition time is set and we are transitioning between reps
                    if (isRest && transitionTime > 0)
                    {
                        // set transition rest
                        nextExercise = Settings.Instance.getExercise(exerciseNum);
                        activity.Text = "Up Next: " + nextExercise.ExerciseName;
                        textReader.SpeakAsync(activity.Text);
                        isRest = false;

                        timeLeft = transitionTime;
                    }
                    // Else start next exercise
                    else
                    {
                        nextExercise = Settings.Instance.getExercise(exerciseNum);
                        activity.Text = nextExercise.ExerciseName;
                        textReader.SpeakAsync(activity.Text);
                        exerciseNum++;      // Go to next exercise

                        if (transitionTime > 0)
                        {
                            isRest = true;
                        }

                        timeLeft = nextExercise.Duration;
                    }
                }

                timer.Start();

            }
           // Console.WriteLine("Remaining: " + setsRemaining.ToString());
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnPause.Enabled = false;
            btnResume.Enabled = true;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            timer.Start();
            btnResume.Enabled = false;
            btnPause.Enabled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnResume.Enabled = false;
            btnPause.Enabled = true;

            // groupBoxStart.Hide();
            // groupBoxDuring.Show();
          //  groupBoxDuring.Visible = false;
          //  groupBoxStart.Visible = true;
            StartWorkout();
        }
    }
}
