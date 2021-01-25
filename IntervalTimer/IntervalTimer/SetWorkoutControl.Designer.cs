
using System.Drawing;

namespace IntervalTimer
{
    partial class SetWorkoutControl
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
            this.nudExerciseTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.btnSaveWorkout = new System.Windows.Forms.Button();
            this.lvWorkout = new System.Windows.Forms.ListView();
            this.colExercise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.nud_restBetweenSets = new System.Windows.Forms.NumericUpDown();
            this.nud_transitionBetweenReps = new System.Windows.Forms.NumericUpDown();
            this.nud_numSets = new System.Windows.Forms.NumericUpDown();
            this.label_restBetweenSets = new System.Windows.Forms.Label();
            this.label_restBetweenReps = new System.Windows.Forms.Label();
            this.label_numSets = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.textBox_exerciseDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudExerciseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_restBetweenSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_transitionBetweenReps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numSets)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudExerciseTime
            // 
            this.nudExerciseTime.Location = new System.Drawing.Point(414, 154);
            this.nudExerciseTime.Name = "nudExerciseTime";
            this.nudExerciseTime.Size = new System.Drawing.Size(120, 20);
            this.nudExerciseTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time (sec)";
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Location = new System.Drawing.Point(557, 151);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(79, 23);
            this.btnAddExercise.TabIndex = 4;
            this.btnAddExercise.Text = "Add";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // btnSaveWorkout
            // 
            this.btnSaveWorkout.Location = new System.Drawing.Point(536, 405);
            this.btnSaveWorkout.Name = "btnSaveWorkout";
            this.btnSaveWorkout.Size = new System.Drawing.Size(96, 23);
            this.btnSaveWorkout.TabIndex = 6;
            this.btnSaveWorkout.Text = "Load Workout";
            this.btnSaveWorkout.UseVisualStyleBackColor = true;
            this.btnSaveWorkout.Click += new System.EventHandler(this.btnSaveWorkout_Click);
            // 
            // lvWorkout
            // 
            this.lvWorkout.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colExercise,
            this.colDuration});
            this.lvWorkout.FullRowSelect = true;
            this.lvWorkout.HideSelection = false;
            this.lvWorkout.Location = new System.Drawing.Point(51, 198);
            this.lvWorkout.Name = "lvWorkout";
            this.lvWorkout.Size = new System.Drawing.Size(585, 190);
            this.lvWorkout.TabIndex = 7;
            this.lvWorkout.UseCompatibleStateImageBehavior = false;
            this.lvWorkout.View = System.Windows.Forms.View.Details;
            this.lvWorkout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvWorkout_MouseDown);
            this.lvWorkout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvWorkout_MouseMove);
            this.lvWorkout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvWorkout_MouseUp);
            // 
            // colExercise
            // 
            this.colExercise.Text = "Exercise";
            this.colExercise.Width = 417;
            // 
            // colDuration
            // 
            this.colDuration.Text = "Duration";
            this.colDuration.Width = 161;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Exercise name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_restBetweenSets
            // 
            this.nud_restBetweenSets.Location = new System.Drawing.Point(24, 50);
            this.nud_restBetweenSets.Name = "nud_restBetweenSets";
            this.nud_restBetweenSets.Size = new System.Drawing.Size(120, 20);
            this.nud_restBetweenSets.TabIndex = 12;
            this.nud_restBetweenSets.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nud_transitionBetweenReps
            // 
            this.nud_transitionBetweenReps.Location = new System.Drawing.Point(208, 49);
            this.nud_transitionBetweenReps.Name = "nud_transitionBetweenReps";
            this.nud_transitionBetweenReps.Size = new System.Drawing.Size(120, 20);
            this.nud_transitionBetweenReps.TabIndex = 13;
            this.nud_transitionBetweenReps.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nud_numSets
            // 
            this.nud_numSets.Location = new System.Drawing.Point(455, 50);
            this.nud_numSets.Name = "nud_numSets";
            this.nud_numSets.Size = new System.Drawing.Size(120, 20);
            this.nud_numSets.TabIndex = 14;
            this.nud_numSets.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label_restBetweenSets
            // 
            this.label_restBetweenSets.AutoSize = true;
            this.label_restBetweenSets.BackColor = System.Drawing.SystemColors.Control;
            this.label_restBetweenSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_restBetweenSets.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_restBetweenSets.Location = new System.Drawing.Point(21, 30);
            this.label_restBetweenSets.Name = "label_restBetweenSets";
            this.label_restBetweenSets.Size = new System.Drawing.Size(136, 16);
            this.label_restBetweenSets.TabIndex = 15;
            this.label_restBetweenSets.Text = "Rest between sets (s)";
            // 
            // label_restBetweenReps
            // 
            this.label_restBetweenReps.AutoSize = true;
            this.label_restBetweenReps.BackColor = System.Drawing.SystemColors.Control;
            this.label_restBetweenReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_restBetweenReps.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_restBetweenReps.Location = new System.Drawing.Point(205, 29);
            this.label_restBetweenReps.Name = "label_restBetweenReps";
            this.label_restBetweenReps.Size = new System.Drawing.Size(211, 17);
            this.label_restBetweenReps.TabIndex = 16;
            this.label_restBetweenReps.Text = "Transition time between reps (s)";
            // 
            // label_numSets
            // 
            this.label_numSets.AutoSize = true;
            this.label_numSets.BackColor = System.Drawing.SystemColors.Control;
            this.label_numSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_numSets.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_numSets.Location = new System.Drawing.Point(452, 30);
            this.label_numSets.Name = "label_numSets";
            this.label_numSets.Size = new System.Drawing.Size(36, 17);
            this.label_numSets.TabIndex = 17;
            this.label_numSets.Text = "Sets";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_numSets);
            this.groupBox1.Controls.Add(this.nud_numSets);
            this.groupBox1.Controls.Add(this.label_restBetweenReps);
            this.groupBox1.Controls.Add(this.nud_restBetweenSets);
            this.groupBox1.Controls.Add(this.label_restBetweenSets);
            this.groupBox1.Controls.Add(this.nud_transitionBetweenReps);
            this.groupBox1.Location = new System.Drawing.Point(51, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 83);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Workout Settings";
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.BackColor = System.Drawing.SystemColors.Control;
            this.btn_clearAll.Location = new System.Drawing.Point(438, 404);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(75, 23);
            this.btn_clearAll.TabIndex = 19;
            this.btn_clearAll.Text = "Clear";
            this.btn_clearAll.UseVisualStyleBackColor = false;
            this.btn_clearAll.Click += new System.EventHandler(this.btn_clearAll_Click);
            // 
            // textBox_exerciseDescription
            // 
            this.textBox_exerciseDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_exerciseDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_exerciseDescription.Location = new System.Drawing.Point(51, 154);
            this.textBox_exerciseDescription.Name = "textBox_exerciseDescription";
            this.textBox_exerciseDescription.Size = new System.Drawing.Size(328, 20);
            this.textBox_exerciseDescription.TabIndex = 20;
            // 
            // SetWorkoutControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_exerciseDescription);
            this.Controls.Add(this.btn_clearAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvWorkout);
            this.Controls.Add(this.btnSaveWorkout);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudExerciseTime);
            this.Name = "SetWorkoutControl";
            this.Size = new System.Drawing.Size(677, 454);
            ((System.ComponentModel.ISupportInitialize)(this.nudExerciseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_restBetweenSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_transitionBetweenReps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numSets)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudExerciseTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.Button btnSaveWorkout;
        private System.Windows.Forms.ListView lvWorkout;
        private System.Windows.Forms.ColumnHeader colExercise;
        private System.Windows.Forms.ColumnHeader colDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_restBetweenSets;
        private System.Windows.Forms.NumericUpDown nud_transitionBetweenReps;
        private System.Windows.Forms.NumericUpDown nud_numSets;
        private System.Windows.Forms.Label label_restBetweenSets;
        private System.Windows.Forms.Label label_restBetweenReps;
        private System.Windows.Forms.Label label_numSets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clearAll;
        private System.Windows.Forms.TextBox textBox_exerciseDescription;
    }
}
