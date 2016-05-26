using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    public  enum WorkoutType {SQUAT, BENCH, DEADLIFT }
    public class Workout
    {
        private WorkoutType type;
        private int numberOfReps;
        private int numberOfSets;
        private int weight;
        private int totalTime;
        private int rating;
        private string notes;
        public int Maximum { get; set; }
        public int TotalWeight { get; set; }
        public int TotalTime { get; set; }
        public int Rating  {get; set; }
        public string Notes { get; set; }
        public Workout(WorkoutType type,int numberOfReps,int numberOfSets,int weight, int totalTime, int rating, string notes)
        {
            //error checking
            this.type = type;
            this.numberOfReps = numberOfReps;
            this.numberOfSets = numberOfSets;
            this.weight = weight;
            this.totalTime = totalTime;
            this.rating = rating;
            this.notes = notes;
           
            setTheoreticalMaximum();
            setTotalWeight();
        }

        private void setTotalWeight()
        {
            TotalWeight = 100;
        }

        private void setTheoreticalMaximum()
        {
            Maximum = 100;
        }
        public void Save()
        {

        }
        public override string ToString()
        {
            return type.ToString();
        }

    }
}
