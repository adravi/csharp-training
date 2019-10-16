namespace Session4
{
    public class Person
    {
        // Basic Constructor
        public Person() {}

        // Custom Constructor
        public Person(string name)
        {
            Name = name;
        }

        // Properties
        public string Name { get; set; }
        
        public int Age { get; set; }
        
        public string Address { get; set; }

        // Fields
        private int PhoneNumber;

        // Methods
        public void Eat() {}

        public int GetRetirementYear()
        {
            return CalculateRetirementYear();
        }

        private int CalculateRetirementYear()
        {
            return -1;
        }
    }
}
