using System.Dynamic;

namespace Runner_Exercise
{
    class Runner
    {

        //CONSTRUCTORS
        public Runner(string name, int time, int age)
        {
            this.Name = name;
            this.Time = time;
            this.Age = age;
            RunnerCount++;
        }

        //PROPERTIES
        public static int RunnerCount
        { get; set; }
        public string Name
        { get;  set; }
        public int Time
        { get; set; }
        public int Age
        { get; set; }
        public int Ranking
        { get; set; }

    }

}
