namespace Practice_ConstructorMethodOverloading_Hafsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Information");
            Car defaultCar = new Car(); // Default constructor
            Car makeModelCar = new Car("Toyota", "Rav4"); // Constructor with make and model
            Car fullCar = new Car("Hyundai", "Sonata", 2010, 100000); // Constructor with make, model, year, and mileage

            // Display information using ToString()
            Console.WriteLine(defaultCar);
            Console.WriteLine(makeModelCar);
            Console.WriteLine(fullCar);

            Console.WriteLine();

            Console.WriteLine("Bank Information");

            BankAccount account = new BankAccount("12345", "Will Cram", 20);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $20.00
            account.Deposit(500);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $520.00
            account.Deposit(-15000);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $520.00
            account.Withdraw(300);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $220.00
            account.Withdraw(-500);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $220.00


        }//main


    }//class


}//namespace