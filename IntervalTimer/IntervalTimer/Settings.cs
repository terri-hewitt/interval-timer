using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IntervalTimer
{
    public sealed class Settings
    {
        private List<ExerciseRepModel> exercises;

        private int TRANSITION_TIME;
        private int SET_REST;
        private int NUM_SETS;
        private Settings() {

            TRANSITION_TIME = 5;
            SET_REST = 45;
            NUM_SETS = 3;

            exercises = new List<ExerciseRepModel>();
            /*[] { 
                "Reverse crunches", 
                "Hand to knee crunches",
                "Hollow crunches",
                "Bicycle crunches",
                "Russian twists",
                "Reach through crunches",
                "Legs to ceiling reaching crunches",
                "Toe taps leg lifts",
                "Flutter kicks",
                "Scissor kicks",
                "Leg lifts",
                "Leg up alternating toe crunch",
                "Crunch kicks",
                "Mountain climbers",
                "Table plank",
                "Right side plank",
                "Left side plank",
                "Right side plank hip raises",
                "Left side plank hip raises",
                "Spider climbers"
            };*/
        }

        private static readonly Lazy<Settings> lazyDb = new Lazy<Settings>(() => new Settings());

        public static Settings Instance
        {
            get
            {
                return lazyDb.Value;
            }
        }

        public ExerciseRepModel getExercise(int index)
        {
            ExerciseRepModel exercise = null;
            if ( (index >= 0) && (index < exercises.Count()) )
            {
                exercise = exercises.ElementAt(index);
            }
            return exercise;
        }

        public void setExercises(List<ExerciseRepModel> exercisesList)
        {
            // Clear list before copying in new list
            exercises.Clear();
            foreach (ExerciseRepModel e in exercisesList)
            {
                exercises.Add(e);
            }
        }

        public int getNumExercises()
        {
            return exercises.Count();
        }

        public void setTransitionTime(int transitionTime)
        {
            TRANSITION_TIME = transitionTime;
        }

        public void setSetRest(int setRestTime)
        {
            SET_REST = setRestTime;
        }

        public void setNumSets(int numSets)
        {
            NUM_SETS = numSets;
        }

        public int getTransitionTime()
        {
            return TRANSITION_TIME;
        }

        public int getSetRestTime()
        {
            return SET_REST;
        }

        public int getNumSets()
        {
            return NUM_SETS;
        }

    }
}
