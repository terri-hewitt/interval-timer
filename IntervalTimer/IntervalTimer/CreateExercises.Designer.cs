
namespace IntervalTimer
{
    partial class CreateExercises
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
            this.label_exerciseName = new System.Windows.Forms.Label();
            this.textBox_exerciseName = new System.Windows.Forms.TextBox();
            this.listBox_myExercises = new System.Windows.Forms.ListBox();
            this.label_myExercises = new System.Windows.Forms.Label();
            this.comboBox_muscleGroup = new System.Windows.Forms.ComboBox();
            this.label_muscleGroup = new System.Windows.Forms.Label();
            this.btn_createExercise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_exerciseName
            // 
            this.label_exerciseName.AutoSize = true;
            this.label_exerciseName.Location = new System.Drawing.Point(48, 36);
            this.label_exerciseName.Name = "label_exerciseName";
            this.label_exerciseName.Size = new System.Drawing.Size(78, 13);
            this.label_exerciseName.TabIndex = 0;
            this.label_exerciseName.Text = "Exercise Name";
            // 
            // textBox_exerciseName
            // 
            this.textBox_exerciseName.Location = new System.Drawing.Point(51, 68);
            this.textBox_exerciseName.Name = "textBox_exerciseName";
            this.textBox_exerciseName.Size = new System.Drawing.Size(258, 20);
            this.textBox_exerciseName.TabIndex = 1;
            // 
            // listBox_myExercises
            // 
            this.listBox_myExercises.FormattingEnabled = true;
            this.listBox_myExercises.Location = new System.Drawing.Point(347, 68);
            this.listBox_myExercises.Name = "listBox_myExercises";
            this.listBox_myExercises.Size = new System.Drawing.Size(299, 394);
            this.listBox_myExercises.TabIndex = 2;
            // 
            // label_myExercises
            // 
            this.label_myExercises.AutoSize = true;
            this.label_myExercises.Location = new System.Drawing.Point(347, 36);
            this.label_myExercises.Name = "label_myExercises";
            this.label_myExercises.Size = new System.Drawing.Size(69, 13);
            this.label_myExercises.TabIndex = 3;
            this.label_myExercises.Text = "My Exercises";
            // 
            // comboBox_muscleGroup
            // 
            this.comboBox_muscleGroup.AllowDrop = true;
            this.comboBox_muscleGroup.DisplayMember = "Text";
            this.comboBox_muscleGroup.FormattingEnabled = true;
            this.comboBox_muscleGroup.Location = new System.Drawing.Point(51, 139);
            this.comboBox_muscleGroup.Name = "comboBox_muscleGroup";
            this.comboBox_muscleGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBox_muscleGroup.TabIndex = 4;
            this.comboBox_muscleGroup.ValueMember = "Id";
            // 
            // label_muscleGroup
            // 
            this.label_muscleGroup.AutoSize = true;
            this.label_muscleGroup.Location = new System.Drawing.Point(51, 120);
            this.label_muscleGroup.Name = "label_muscleGroup";
            this.label_muscleGroup.Size = new System.Drawing.Size(73, 13);
            this.label_muscleGroup.TabIndex = 5;
            this.label_muscleGroup.Text = "Muscle Group";
            // 
            // btn_createExercise
            // 
            this.btn_createExercise.Location = new System.Drawing.Point(54, 194);
            this.btn_createExercise.Name = "btn_createExercise";
            this.btn_createExercise.Size = new System.Drawing.Size(75, 23);
            this.btn_createExercise.TabIndex = 6;
            this.btn_createExercise.Text = "Create";
            this.btn_createExercise.UseVisualStyleBackColor = true;
            this.btn_createExercise.Click += new System.EventHandler(this.btn_createExercise_Click);
            // 
            // CreateExercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_createExercise);
            this.Controls.Add(this.label_muscleGroup);
            this.Controls.Add(this.comboBox_muscleGroup);
            this.Controls.Add(this.label_myExercises);
            this.Controls.Add(this.listBox_myExercises);
            this.Controls.Add(this.textBox_exerciseName);
            this.Controls.Add(this.label_exerciseName);
            this.Name = "CreateExercises";
            this.Size = new System.Drawing.Size(679, 497);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exerciseName;
        private System.Windows.Forms.TextBox textBox_exerciseName;
        private System.Windows.Forms.ListBox listBox_myExercises;
        private System.Windows.Forms.Label label_myExercises;
        private System.Windows.Forms.ComboBox comboBox_muscleGroup;
        private System.Windows.Forms.Label label_muscleGroup;
        private System.Windows.Forms.Button btn_createExercise;
    }
}
