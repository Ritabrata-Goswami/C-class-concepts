// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace ClassConcept
{
    class Item
    {
        public string Name;
        public double Weight;
        public string WeightUnit;
        public double Price;
        public string MaterialMade;

        public Item(string Name, double Weight, string WeightUnit, double price, string material)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.WeightUnit = WeightUnit;
            this.Price = price;
            this.MaterialMade = material;
        }

        public string GetAboutItem()
        {
            string msg = $"The name of the material is {this.Name}. It's Weight is {this.Weight} {this.WeightUnit}.\nMade of {this.MaterialMade}.The price of this is {this.Price} rupee.";
            return msg;
        }
    }


    class Person
    {
        private string? FName;
        private string? LName;
        private byte Age;

        private bool CheckNullOrEmpty(string Val)
        {
            return !string.IsNullOrEmpty(Val);
        }

        public Person InputFirstName(string? fname)
        {
            if (CheckNullOrEmpty(fname))
            {
                this.FName = fname;
            }
            return this;
        }
        public Person InputLastName(string? lname)
        {
            if (CheckNullOrEmpty(lname))
            {
                this.LName = lname;
            }
            return this;
        }
        public Person InputAge(byte age)
        {
            this.Age = age;
            return this;
        }

        public string GetFullName()
        {
            string msg = $"Hello my name is {this.FName} {this.LName}. I'm {this.Age} years old.";
            return msg;
        }

    }


    class Train
    {
        private string trainName;
        private double speed;
        private string typeLoco;
        private int numOfCoaches;


                            //Public properties accessing private data members.
        public string TrainName
        {
            get { return trainName; }
            set { trainName = value; }
        }
        public double TrainSpeed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string TypeOfLoco
        {
            get { return typeLoco; }
            set { typeLoco = value; }
        }
        public int NumCoaches
        {
            get { return numOfCoaches; }
            set { numOfCoaches = value; }
        }


        public string AllAboutTrain()
        {
            string msg = $"The name of the train is {TrainName}. It has maximun speed of {TrainSpeed} km/h.\nIt is an {TypeOfLoco} type train. And it has {NumCoaches} number of coaches.";
            return msg;
        }
    }


    class Fruit
    {
        private string name;
        private double weight;
        private string color;


        public string Name { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }

        public string AllAboutFruit() 
        {
            return $"The name of the fruit is {Name}. It's color is {Color}.\nIt has weight of {Weight} gram.";
        }
    }


    class Matrix
    {
        private double[,] data;
        public Matrix(int row, int column)
        {
            data = new double[row, column];
        }

        public double this[int row, int column]
        {
            get { return data[row, column]; }
            set { data[row, column] = value; }
        }
    }


    class UnitConverter
    {                                   //expression-bodied members.
        public static double KgToLbs(double weight) => weight * 2.20462262185;
        public static double LbsToKg(double weight) => weight * 0.45359237;
        public static double MeterToCm(double meter) => meter * 100;

    }


    static class LengthConverter
    {
        public static double FeetToMeters(double ft) => ft / 3.28084;
        public static double MetersToFeet(double m) => m * 3.28084;

    }




    class Output
    {
        public static void Main()
        {
            Console.WriteLine("===============Item class===============");
            Item item = new Item("fuse", 3.75, "gram", 13.00, "copper");
            Console.WriteLine(item.GetAboutItem());
            Console.WriteLine(" ");

            Console.WriteLine("===============Method Chaining With Private Members===============");
            Person person = new Person();
            Console.WriteLine("Enter First Name:- ");
            string? fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name:- ");
            string? lname = Console.ReadLine();
            Console.WriteLine("Enter Age:- ");
            byte age = Convert.ToByte(Console.ReadLine());
            string getFullName = person.InputFirstName(fname).InputLastName(lname).InputAge(age).GetFullName();
            Console.WriteLine(getFullName);
            Console.WriteLine(" ");

            Console.WriteLine("=================Train=================");
            var train = new Train();
            train.TrainSpeed = 150;
            train.TrainName = "Alstom TGV";
            train.TypeOfLoco = "Electric";
            train.NumCoaches = 7;

            Console.WriteLine(train.AllAboutTrain());
            Console.WriteLine(" ");

            Console.WriteLine("======================Fruit=======================");
            Fruit fruit = new Fruit();
            fruit.Weight = 120;
            fruit.Name = "mango";
            fruit.Color = "red";
            Console.WriteLine(fruit.AllAboutFruit());
            Console.WriteLine(" ");


            Console.WriteLine("======================Matrix=======================");
            Matrix matrix = new Matrix(3, 3);

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    matrix[row, column] = row + column;
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine(" ");

            Console.WriteLine("=========Accessing Static Methods=========");
            double KgToPound = UnitConverter.KgToLbs(100);
            double PoundToKg = UnitConverter.LbsToKg(380);
            double MeterToCm = UnitConverter.MeterToCm(1.7);
                                //Formating decimal values upto 3 decimal digits.
            Console.WriteLine($"{ KgToPound:#.000}");
            Console.WriteLine($"{PoundToKg:#.000}");
            Console.WriteLine($"{MeterToCm:#.000}");
            Console.WriteLine(" ");

            Console.WriteLine("=======Accessing Static Methods In Static Class======");
            double meter = LengthConverter.FeetToMeters(112.72);
            double feet = LengthConverter.MetersToFeet(100);
            Console.WriteLine($"Meter:- {meter:#.000}");
            Console.WriteLine($"Feet:- {feet:#.000}");
            Console.WriteLine(" ");
        }
    }

}
