namespace Assignment6
{
    //
    enum WeekDays
    {
        Monday , Tuseday , Wednesday , Thursday , Friday , Saturday , Sunday
    }
    internal struct Person 
    {
        private int age;
        private string name;

        public Person () {
            age = 0;
            name = "";
        } 
        public Person(int _age , string _name)
        {
            age = _age;
            name = _name;
        }

        internal int GetAge()
        {
            return age;
        }
        internal string getName()
        {
            return name;
        }
        internal void SetAge(int _age)
        {
            age = _age;
        }
        internal void setName(string _name)
        {
            name = _name;
        }

    }

    enum Season
    {
        Spring , Summer , Autumn , Winter
    }

    [Flags]
    enum Permissions
    {
        Read = 1 , Write = 2 , Delete = 4 , Execute = 8
    }

    enum Colors
    {
        Red, Green, Blue
    }

    internal struct Point
    {
        private double x;
        private double y;

        public Point()
        {
            x = 0;  
            y = 0;  
        }

        internal void SetX(int _x) {
        x = _x;
        }
        internal void SetY(int _y)
        {
            y = _y;
        }
        internal double GetDistance(Point p1 , Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x , 2)+ Math.Pow(p2.y- p1.y, 2));
        }
    }

    class Program
    {
        static void Main()
        {
            #region 1
            foreach (WeekDays weekDays in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(weekDays);
            }
            #endregion

            #region 2
            Person[] person = new Person[3];
            person[0].setName("Abdo");
            person[0].SetAge(22);
            person[1].setName("Mohamed");
            person[1].SetAge(20);
            person[2].setName("Aly");
            person[2].SetAge(18);

            for (int i = 0; i < person?.Length; i++)
            {
                Console.WriteLine($"{person[i].GetAge()} , {person[i].getName()} ");
            }
            #endregion

            #region 3

            string season = Console.ReadLine();
            Enum.TryParse(season, true, out Season ii);
            if (ii == Season.Spring)
                Console.WriteLine("March To May");
            else if (ii == Season.Summer)
                Console.WriteLine("June To August");
            else if (ii == Season.Autumn)
                Console.WriteLine("September To November");
            else if (ii == Season.Winter)
                Console.WriteLine("December To February");

            #endregion

            #region 4


            Permissions permissions = Permissions.Read;

            permissions = permissions | Permissions.Write;

            Console.WriteLine(permissions);

            permissions = permissions ^ Permissions.Write;

            Console.WriteLine(permissions);

            if ((permissions & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine($"{Permissions.Read} fOUND");
            }
            else
                Console.WriteLine("Not Found");

            #endregion

            #region 5
            string color = Console.ReadLine();
            if (Enum.TryParse(color, true, out Colors t))
            {
                Console.WriteLine("Primary Color");
            }
            else
                Console.WriteLine("Not Primary");
            #endregion

            #region 6
            Point p1 = new Point();
            int.TryParse(Console.ReadLine(), out int x);
            p1.SetX(x);
            int.TryParse(Console.ReadLine(), out int y);
            p1.SetY(y);

            Point p2 = new Point();
            int.TryParse(Console.ReadLine(), out int x2);
            p2.SetX(x2);
            int.TryParse(Console.ReadLine(), out int y2);
            p2.SetY(y2);

            Console.WriteLine(p1.GetDistance(p1, p2));
            #endregion

            #region 7
            Person[] personTwo = new Person[3];
            for (int i = 0; i < personTwo?.Length; i++) {
                int.TryParse(Console.ReadLine(), out int z);
                personTwo[i].SetAge(z);
                personTwo[i].setName(Console.ReadLine());
            }
            Person OldPerson = new Person();
            for (int i = 0;i < personTwo?.Length; i++)
            {
                if (personTwo[i].GetAge() > OldPerson.GetAge())
                {
                    OldPerson = personTwo[i];
                }
            }
            Console.WriteLine($"{OldPerson.GetAge()} , {OldPerson.getName()} ");
            #endregion
        }
    }
}
