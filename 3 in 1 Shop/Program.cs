using System;
using System.Collections.Generic;

namespace ThreeInOneShop
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();
        static List<Customer> customers = new List<Customer>();
        static List<decimal> income = new List<decimal>();
        static List<decimal> outcome = new List<decimal>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The3/1Shop");
            Console.WriteLine("************************");
            Console.WriteLine("1. Shops");
            Console.WriteLine("2. Employees");
            Console.WriteLine("3. Customers");
            Console.WriteLine("4. Income");
            Console.WriteLine("5. Outcome");
            Console.WriteLine("6. Exit");

            while (true)
            {
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        DisplayShopsMenu();
                        break;
                    case 2:
                        DisplayEmployeesMenu();
                        break;
                    case 3:
                        DisplayCustomersMenu();
                        break;
                    case 4:
                        DisplayIncomeMenu();
                        break;
                    case 5:
                        DisplayOutcomeMenu();
                        break;
                    case 6:
                        Console.WriteLine("Are you sure you want to exit? (Y/N)");
                        string exitChoice = Console.ReadLine().ToLower();
                        if (exitChoice == "y")
                        {
                            Console.WriteLine("Thank you for using The3/1Shop. Goodbye!");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void DisplayShopsMenu()
        {
            Console.WriteLine("Shops");
            Console.WriteLine("*****");
            Console.WriteLine("1. Tattoo Shop");
            Console.WriteLine("2. Bar");
            Console.WriteLine("3. Barber Shop");
        }

        static void DisplayEmployeesMenu()
        {
            Console.WriteLine("Employees");
            Console.WriteLine("*********");
            Console.WriteLine("1. Add Employees");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Edit Employees");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the department: ");
                    string department = Console.ReadLine();
                    AddEmployee(department);
                    break;
                case 2:
                    ViewEmployees();
                    break;
                case 3:
                    EditEmployees();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void DisplayCustomersMenu()
        {
            Console.WriteLine("Customers");
            Console.WriteLine("*********");
            Console.WriteLine("1. Add Customers");
            Console.WriteLine("2. View Customers");
            Console.WriteLine("3. Edit Customers");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    ViewCustomers();
                    break;
                case 3:
                    EditCustomers();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void DisplayIncomeMenu()
        {
            Console.WriteLine("Income");
            Console.WriteLine("******");
            Console.WriteLine("1. Add Income");
            Console.WriteLine("2. View Income");
            Console.WriteLine("3. Edit Income");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    AddIncome();
                    break;
                case 2:
                    ViewIncome();
                    break;
                case 3:
                    EditIncome();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void DisplayOutcomeMenu()
        {
            Console.WriteLine("Outcome");
            Console.WriteLine("*******");
            Console.WriteLine("1. Add Outcome");
            Console.WriteLine("2. View Outcome");
            Console.WriteLine("3. Edit Outcome");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    AddOutcome();
                    break;
                case 2:
                    ViewOutcome();
                    break;
                case 3:
                    EditOutcome();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void AddEmployee(string department)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter years of experience: ");
            int experience = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter email address: ");
            string email = Console.ReadLine();

            Employee employee = new Employee(name, age, experience, email, department);
            employees.Add(employee);

            Console.WriteLine("Employee added successfully.");
        }

        static void ViewEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
            }
            else
            {
                Console.WriteLine("Employees:");
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Experience: {employee.Experience} years, Email: {employee.Email}, Department: {employee.Department}");
                }
            }
        }

        static void EditEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
            }
            else
            {
                ViewEmployees();

                Console.Write("Enter the index of the employee to edit: ");
                int index = Convert.ToInt32(Console.ReadLine());

                if (index < 0 || index >= employees.Count)
                {
                    Console.WriteLine("Invalid index. Please try again.");
                }
                else
                {
                    Console.WriteLine("Enter new details for the employee:");

                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter years of experience: ");
                    int experience = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter email address: ");
                    string email = Console.ReadLine();

                    employees[index].Name = name;
                    employees[index].Age = age;
                    employees[index].Experience = experience;
                    employees[index].Email = email;

                    Console.WriteLine("Employee details updated successfully.");
                }
            }
        }

        static void AddCustomer()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter date of birth (YYYY-MM-DD): ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter discount percentage: ");
            decimal discount = Convert.ToDecimal(Console.ReadLine());

            Customer customer = new Customer(name, dob, discount);
            customers.Add(customer);

            Console.WriteLine("Customer added successfully.");
        }

        static void ViewCustomers()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
            }
            else
            {
                Console.WriteLine("Customers:");
                foreach (var customer in customers)
                {
                    Console.WriteLine($"Name: {customer.Name}, Date of Birth: {customer.DateOfBirth.ToShortDateString()}, Discount: {customer.DiscountPercentage}%");
                }
            }
        }

        static void EditCustomers()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
            }
            else
            {
                ViewCustomers();

                Console.Write("Enter the index of the customer to edit: ");
                int index = Convert.ToInt32(Console.ReadLine());

                if (index < 0 || index >= customers.Count)
                {
                    Console.WriteLine("Invalid index. Please try again.");
                }
                else
                {
                    Console.WriteLine("Enter new details for the customer:");

                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter date of birth (YYYY-MM-DD): ");
                    DateTime dob = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Enter discount percentage: ");
                    decimal discount = Convert.ToDecimal(Console.ReadLine());

                    customers[index].Name = name;
                    customers[index].DateOfBirth = dob;
                    customers[index].DiscountPercentage = discount;

                    Console.WriteLine("Customer details updated successfully.");
                }
            }
        }

        static void AddIncome()
        {
            Console.Write("Enter item sold: ");
            string item = Console.ReadLine();
            Console.Write("Enter amount received: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            income.Add(amount);

            Console.WriteLine("Income added successfully.");
        }

        static void ViewIncome()
        {
            if (income.Count == 0)
            {
                Console.WriteLine("No income records found.");
            }
            else
            {
                Console.WriteLine("Income:");
                foreach (var amount in income)
                {
                    Console.WriteLine($"Amount: {amount}");
                }
            }
        }

        static void EditIncome()
        {
            if (income.Count == 0)
            {
                Console.WriteLine("No income records found.");
            }
            else
            {
                ViewIncome();

                Console.Write("Enter the index of the income record to edit: ");
                int index = Convert.ToInt32(Console.ReadLine());

                if (index < 0 || index >= income.Count)
                {
                    Console.WriteLine("Invalid index. Please try again.");
                }
                else
                {
                    Console.Write("Enter new amount: ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());

                    income[index] = amount;

                    Console.WriteLine("Income record updated successfully.");
                }
            }
        }

        static void AddOutcome()
        {
            Console.Write("Enter item bought: ");
            string item = Console.ReadLine();
            Console.Write("Enter amount spent: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            outcome.Add(amount);

            Console.WriteLine("Outcome added successfully.");
        }

        static void ViewOutcome()
        {
            if (outcome.Count == 0)
            {
                Console.WriteLine("No outcome records found.");
            }
            else
            {
                Console.WriteLine("Outcome:");
                foreach (var amount in outcome)
                {
                    Console.WriteLine($"Amount: {amount}");
                }
            }
        }

        static void EditOutcome()
        {
            if (outcome.Count == 0)
            {
                Console.WriteLine("No outcome records found.");
            }
            else
            {
                ViewOutcome();

                Console.Write("Enter the index of the outcome record to edit: ");
                int index = Convert.ToInt32(Console.ReadLine());

                if (index < 0 || index >= outcome.Count)
                {
                    Console.WriteLine("Invalid index. Please try again.");
                }
                else
                {
                    Console.Write("Enter new amount: ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());

                    outcome[index] = amount;

                    Console.WriteLine("Outcome record updated successfully.");
                }
            }
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

        public Employee(string name, int age, int experience, string email, string department)
        {
            Name = name;
            Age = age;
            Experience = experience;
            Email = email;
            Department = department;
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal DiscountPercentage { get; set; }

        public Customer(string name, DateTime dob, decimal discount)
        {
            Name = name;
            DateOfBirth = dob;
            DiscountPercentage = discount;
        }
    }
}