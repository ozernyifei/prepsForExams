namespace ExamHumansLibrary
{
    
    public class JewelryBuyer
    {
        private string firstName;
        private string lastName;
        private string address;
        private string contactNumber;

        public JewelryBuyer(string firstName, string lastName, string address, string contactNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.contactNumber = contactNumber;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Buyer Information:");
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Contact Number: {0}", contactNumber);
        }
    }
    public class SportsApparelBuyer
    {
        private string firstName;
        private string lastName;
        private int age;
        private string email;

        public SportsApparelBuyer(string firstName, string lastName, int age, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Buyer Information:");
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Email: {0}", email);
        }
    }

    public class BuildingStoreProduct
    {
        private string productName;
        private string category;
        private decimal price;

        public BuildingStoreProduct(string productName, string category, decimal price)
        {
            this.productName = productName;
            this.category = category;
            this.price = price;
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Product Information:");
            Console.WriteLine("Name: {0}", productName);
            Console.WriteLine("Category: {0}", category);
            Console.WriteLine("Price: {0}", price);
        }
    }
    public class HomelessPet
    {
        private string name;
        private string species;
        private int age;

        public HomelessPet(string name, string species, int age)
        {
            this.name = name;
            this.species = species;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Pet Information:");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Species: {0}", species);
            Console.WriteLine("Age: {0}", age);
        }
    }
    public class CollegeStudent
    {
        private string firstName;
        private string lastName;
        private string major;
        private int year;

        public CollegeStudent(string firstName, string lastName, string major, int year)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.major = major;
            this.year = year;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Student Information:");
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Major: {0}", major);
            Console.WriteLine("Year: {0}", year);
        }
    }
    public class FlowerGreenhousePlant
    {
        private string name;
        private string species;
        private string color;

        public FlowerGreenhousePlant(string name, string species, string color)
        {
            this.name = name;
            this.species = species;
            this.color = color;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Plant Information:");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Species: {0}", species);
            Console.WriteLine("Color: {0}", color);
        }
    }
    public class TaxiParkCar
    {
        private string make;
        private string model;
        private int year;
        private string licensePlate;

        public TaxiParkCar(string make, string model, int year, string licensePlate)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.licensePlate = licensePlate;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Car Information:");
            Console.WriteLine("Make: {0}", make);
            Console.WriteLine("Model: {0}", model);
            Console.WriteLine("Year: {0}", year);
            Console.WriteLine("License Plate: {0}", licensePlate);
        }
    }
    public class Tourist
    {
        // Поля класса
        private string firstName;
        private string lastName;
        private int age;
        private string email;

        // Конструктор класса
        public Tourist(string firstName, string lastName, int age, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
        }

        // Свойства для доступа к полям класса
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Метод для вывода информации о пользователе
        public void DisplayInfo()
        {
            Console.WriteLine("User Information:");
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Email: {0}", email);
        }
    }
}