namespace Runner_Exercise
{
    class Runner
    {

        //CONSTRUCTORS
        public Runner(string name, int time, int age)
        {
            Name = name;
            Time = time;
            Age = age;
            RunnerCount++;
        }

        //PROPERTIES
        public static int RunnerCount
        { get; private set; }
        public string Name
        { get; }
        public int Time
        { get; }
        public int Age
        { get; }
        public int Ranking
        { get; set; }

        public override string ToString()
        {
            return $"{Name,-12}{Time}\t{Age}\t{Ranking}";
        }

    }

}
