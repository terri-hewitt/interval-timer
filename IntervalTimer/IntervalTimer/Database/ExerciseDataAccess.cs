using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace IntervalTimer.Database
{
    public class ExerciseDataAccess
    {
        public static List<ExerciseModel> LoadExercises()
        {
            // Open connection
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Exercises")))
            {
                var output = cnn.Query<ExerciseModel>("select * from Exercises", new DynamicParameters());
                return output.ToList();
            }
            // Connection will automagically close after exiting using statement
        }

        public static void SaveExercise(ExerciseModel exercise)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Exercises")))
            {
                cnn.Execute("insert into Exercises (ExerciseName, MuscleGroup) values (@ExerciseName, @MuscleGroup)", exercise);
            }
        }

        private static string LoadConnectionString(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
