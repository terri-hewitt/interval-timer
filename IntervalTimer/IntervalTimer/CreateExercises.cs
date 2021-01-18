using IntervalTimer.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IntervalTimer
{
    public partial class CreateExercises : UserControl
    {
        List<ExerciseModel> exercises = new List<ExerciseModel>();
        public CreateExercises()
        {
            InitializeComponent();
            InitializeComboBox();
            RefreshExerciseList();
        }

        private void InitializeComboBox()
        {
            comboBox_muscleGroup.DataSource = new ComboItem[]
            {
                new ComboItem{ Id = 1, Text = "Core" },
                new ComboItem{ Id = 2, Text = "Arms" },
                new ComboItem{ Id = 3, Text = "Legs" },
                new ComboItem{ Id = 4, Text = "Hips/Glutes"}
            };

            // Clear combo box
            comboBox_muscleGroup.SelectedIndex = -1;
        }

        private void RefreshExerciseList()
        {
            // Get data from database
            exercises = ExerciseDataAccess.LoadExercises();

            WireUpExerciseList();
        }

        private void WireUpExerciseList()
        {
            listBox_myExercises.DataSource = null;
            listBox_myExercises.DataSource = exercises;
            listBox_myExercises.DisplayMember = "ExerciseName";
        }

        private void btn_createExercise_Click(object sender, EventArgs e)
        {
            ExerciseModel exercise = new ExerciseModel();

            exercise.ExerciseName = textBox_exerciseName.Text;

            ComboItem comboItem = (ComboItem)comboBox_muscleGroup.SelectedItem;
            exercise.MuscleGroup = comboItem.Text;

            if (exercise.ExerciseName != "" && exercise.MuscleGroup != "")
            {
                ExerciseDataAccess.SaveExercise(exercise);
            }

            // Clear form fields
            textBox_exerciseName.Text = "";
            comboBox_muscleGroup.SelectedIndex = -1;

            // Reload items in list box
            RefreshExerciseList();
        }
    }
}
