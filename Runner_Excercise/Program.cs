namespace Runner_Exercise
{
    class Program
    {
        //Swap function declaration
        /*static void Swap<T>(T[] array, int index1, int index2)
        {
            T temporary = array[index1];
            array[index1] = array[index2];
            array[index2] = temporary;
        }*/

        //MAIN
        static void Main()
        {
            //instantiating Runner objects in array
            Runner[] runners = new Runner[]
            {
                new Runner("Steve", 12, 33),
                new Runner("Tim", 34, 28),
                new Runner("Mark", 22, 37),
                new Runner("Tom", 21, 30),
                new Runner("Cliff", 13, 33),
                new Runner("Vini", 17, 28),
                new Runner("Matt", 10, 28),
                new Runner("Ben", 9, 29),
                new Runner("Brandon", 15, 14)
            };

            //reorder based on time
            List<Runner> sortedRunners = runners.OrderBy(r => r.Time).ToList();

            /*int q = 0;
            while (q < runners.Length)
            {
                int i = 0;
                foreach (Runner r in runners)
                {
                    if (i == 0) { }
                    else if (r.Time < runners[i - 1].Time)
                    {
                        Swap(runners, i, i - 1);
                    }

                    i++;
                }

                q++;
            }*/

            //sorts into age group lists
            List<List<Runner>> runnerLists = new()
            {
                sortedRunners.Where(r => r.Age <= 15).ToList(),
                sortedRunners.Where(r => r.Age > 15 && r.Age < 30).ToList(),
                sortedRunners.Where(r => r.Age >= 30).ToList()
            };

            //sets rankings within each age group
            for (int i = 0; i < runnerLists.Count; i++)
            {
                for (int j = 0; j < runnerLists[i].Count; j++)
                {
                    runnerLists[i][j].Ranking = j + 1;
                }
            }

            //display results
            int n = 1;
            Console.WriteLine($"{"Name",16}\tTime\tAge\tRanking");
            foreach (Runner r in sortedRunners)
            {
                Console.WriteLine($"Runner #{n++,-4}{r}");
            }




            /* 
            Runner Steve = new Runner("Steve", 12, 33);
            Runner Tim = new Runner("Tim", 34, 28);
            Runner Mark = new Runner("Mark", 22, 37);
            Runner Tom = new Runner("Tom", 21, 30);
            Runner Cliff = new Runner("Cliff", 13, 33);
            Runner Vini = new Runner("Vini", 17, 28);
            Runner Matt = new Runner("Matt", 10, 28);
            Runner Ben = new Runner("Ben", 9, 29);
            Runner Brandon = new Runner("Brandon", 15, 14);
            */

            /* 
            List<Runner> runners = new List<Runner>();
            runners.Add(new Runner { Name = "Steve", Time = 12, Age = 33 });
            runners.Add(new Runner { Name = "Tim", Time = 34, Age = 28 });
            runners.Add(new Runner { Name = "Mark", Time = 22, Age = 37 });
            runners.Add(new Runner { Name = "Tom", Time = 21, Age = 30 });
            runners.Add(new Runner { Name = "Cliff", Time = 13, Age = 33 });
            runners.Add(new Runner { Name = "Vini", Time = 17, Age = 28 });
            runners.Add(new Runner { Name = "Matt", Time = 10, Age = 28 });
            runners.Add(new Runner { Name = "Ben", Time = 9, Age = 29 });
            runners.Add(new Runner { Name = "Brandon", Time = 15, Age = 14 });
            */


        }
    }
}