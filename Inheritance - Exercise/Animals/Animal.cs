namespace Animals
{
    using System;
    using System.Text;

    public  class Animal
    {
        private string name;

        private int age;

        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace (value) || string.IsNullOrEmpty (value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;

            private set
            {
                if (value < 0  )
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        public virtual string Gender
        {
            get => this.gender;

            private set
            {
                if (string.IsNullOrWhiteSpace (value) || string.IsNullOrEmpty (value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return null;
        }
        public static Animal Create(string name, int age, string gender, string type)
        {
            switch (type)
            {
                case "Dog": return new Dog(name, age, gender);
                case "Cat": return new Cat(name, age, gender);
                case "Frog": return new Frog(name, age, gender);
                case "Kitten": return new Kitten(name, age, gender);
                case "Tomcat": return new Tomcat(name, age, gender);
                default: throw new ArgumentException("Invalid input!");
            }
        }

        public override string ToString()
        {
            StringBuilder printFormat = new StringBuilder();
            printFormat.AppendLine(this.GetType().Name);
            printFormat.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            printFormat.Append($"{this.ProduceSound()}");

            return printFormat.ToString().TrimEnd();
        }
    }
}