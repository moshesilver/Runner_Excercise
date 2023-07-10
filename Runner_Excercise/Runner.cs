using System.Dynamic;

namespace Runner_Exercise
{
    class Runner
    {

        //FIELDS
        private static int runnerCount;
        private string name;
        private int time;
        private int age;
        private int ranking;

        //CONSTRUCTORS
        public Runner(string name, int time, int age)
        {
            this.Name = name;
            this.Time = time;
            this.Age = age;
            runnerCount++;
        }

        static Runner()
        {
            runnerCount = 0;
        }

        //PROPERTIES
        public static int RunnerCount
        {
            get { return runnerCount; }
            set { runnerCount = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Time
        {
            get { return time; }
            set { time = value; }   
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Ranking
        {
            get { return ranking; }
            set { ranking = value; } 
        }

    }

}
