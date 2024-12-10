using FirstDemo1;
using System;
using System.Collections;
namespace FirstDemo1
{
    public class Player : IComparable
    {
        private int runs;
        private string name;
        public Player(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }
        public int Runs
        {
            get { return runs; }
        }
        public int CompareTo(object obj) // obj = virat
        {
            // runs of virat is in the obj object, need typecasting to get data
            Player p1 = (Player)obj; // virat's object assign to p1
            // this points to current object ie. object of rohit
            if (this.runs > p1.runs)
            {
                return 1;
            }
            else if (this.runs < p1.runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $" Name={name} , Runs= {runs}";
        }
    }

    public class Team : IEnumerable
    {
        Player[] player;
        public Team()
        {
            player = new Player[3];
            player[0] = new Player(70, "Rohit");
            player[1] = new Player(50, "Virat");
            player[2] = new Player(35, "Dhoni");
        }

        public IEnumerator GetEnumerator()
        {
            return player.GetEnumerator();
        }
    }

    public class CheckRuns : IComparer
    {
        public int Compare(object x, object y)
        {
            Player p1 = (Player)x;
            Player p2 = (Player)y;
            if (p1.Runs > p2.Runs)
            {
                return 1;
            }
            else if (p1.Runs < p2.Runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}


