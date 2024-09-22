/******************************************************
* FreeCodeCamp - Master Design Principles & Solid Principles
    in C# 

* - Encapsulation
* - Abstraction
* - Inheritance
* - Polymorphism
* - Coupling
* - Composition

* - Composition vs Inheritance
* - Fragile Base Class Problem

* - SOLID Principles
* - Single Responsibility Principle (SRP)
* - Open/Closed Principle (OCP)
* - Liskov Substitution Principle (LSP)
* - Interface Segregation Principle (ISP)
* - Dependency Inversion Principle (DIP)
******************************************************/
/*******************
Encapsulation
*******************/

using CodingReview.src.OopPrinciples;
using CodingReview.src.OopPrinciples.Abstraction;
using CodingReview.src.OopPrinciples.Inheritance;
using CodingReview.src.OopPrinciples.Polymorphism;
using CodingReview.src.OopPrinciples.Coupling;
using CodingReview.src.OopPrinciples.Composition;
using CodingReview.src.SOLID.S;
using CodingReview.src.SOLID.O;
using CodingReview.src.SOLID.L;
using CodingReview.src.SOLID.I;
using CodingReview.src.SOLID.D;


BankAccount account = new BankAccount(1000);
System.Console.WriteLine($"This is what is in the bank account initially: {account.GetBalance()}");

account.SetBalance(300);

System.Console.WriteLine($"This is what is in the bank account: {account.GetBalance()}");

account.Deposit(500);

System.Console.WriteLine($"This is what is in the bank account after deposit: {account.GetBalance()}");
System.Console.WriteLine("***********************************************************");

/******************
Abstracttion 
    - Hides the complex implementation details and shows only the necessary features of an object.
    - It helps to reduce programming complexity and effort by making methods private,
        and hiding the unnecessary details from the user. 
    - In this example, the user doesn't need to see the connection, authentication, and disconnection details.
******************/

EmailService emailService = new EmailService();

emailService.SendEmail();
System.Console.WriteLine("***********************************************************");

/******************
Inheritance
    - It is a mechanism in which one class acquires the property of another class.
    - It is useful for code reusability: the methods and fields of the base class can be reused in the derived class.
    - This is an example of a "is-A" relationship.
******************/
var car = new Car();
// This is an example of inheritance as the derived class can be assigned to the base class
car.Brand = "Toyota";
car.Model = "Camry";
car.Year = 2020;

// This is an unique properties of the derived class can be accessed
car.NumberOfDoors = 4;
car.NumberOfWheels = 4;

var bike = new Bike();
bike.Brand = "Honda";
bike.Model = "CBR";
bike.Year = 2021;
bike.NumberOfWheels = 2;
System.Console.WriteLine("***********************************************************");

/******************
Polymorphism
    - It is a mechanism that allows one interface to be used for a general class of actions.
    - It allows methods to do different things based on the object that it is acting upon.
    - This is an example of a "is-A" relationship.
******************/

// This is an example of polymorphism as the Start and Stop methods are called on the objects
// manually and calling the methods do the overriden instructions
var secondCar = new Car2();
secondCar.Start();
secondCar.Stop();

var secondBike = new Motorcycle();
secondBike.Start();
secondBike.Stop();

var plane = new Plane();
plane.Start();
plane.Stop();

// Creating a list of objects that can be of any type that inherits from the Vehicle2(aka root/base) class
List<Vehicle2> vehicles = new List<Vehicle2>();
vehicles.Add(new Car2 { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
vehicles.Add(new Motorcycle { Brand = "Honda", Model = "CBR", Year = 2021, NumberOfWheels = 2 });
vehicles.Add(new Plane { Brand = "Boeing", Model = "747", Year = 2021 });

//Vehicle Inspection
foreach (var vehicle in vehicles)
{
    // This is an example of polymorphism as the Start and Stop methods are called on the objects
    // and using  a foreach loop to call each object's overriden methods
    vehicle.Start();
    vehicle.Stop();
}

System.Console.WriteLine("***********************************************************");

/******************
Coupling
    - The degree of dependency between two classes.
    - It is a measure of how closely connected two classes or modules are.
    - Use of interfaces to decouple classes
******************/

// This is an example of coupling as the Order class is dependent on the INotificationService interface
var order = new Order(new SmsSender());
order.PlaceOrder();
System.Console.WriteLine("***********************************************************");

/******************
Composition
    - It is a design technique in object-oriented programming to implement "has-A" relationship between objects.
    - In composition, objects are assembled together to form a more complex object. This helps each component
        object maintain its own state and behavior.
******************/

var car3 = new CompCar();
car3.StartCar();
System.Console.WriteLine("***********************************************************");

/******************
Composition vs Inheritance

* When to Use Composition:
    - When you want more flexibility in constructing objects by assempling smaller, reusable components
    - When ther is no clear "is-A" relationship between the classes, thus a "has-A"
         relationship is more appropriate
    - Avoid Inheritance limitations like tight coupling, fragile base class problem, and 
        the inability to change the implementation of a class at runtime

* When to Use Inheritance:
    - When you want to reuse the code of the base class
    - When you want to create a "is-A" relationship between the classes
    - When you want to leverage the polymorphism feature of OOP

******************/

/******************
Example of Fragile Base Class Problem
    - The Fragile Base Class Problem is a problem that occurs when a class is changed in a way that
        causes the classes that inherit from it to break.
    - This is a common problem in inheritance-based systems and where we would want to use composition
        instead of inheritance.
        1. Inheritance Coupling: Inheritance creates a tight coupling between 
            the base class (Superclass) and the derived class (Subclasses).
            Any changes in the base class can affect the derived class.
        2. Limited Extensibility: The FBC Problem limits extensibility of software systems, as modfications
            to base class can become increasingly risky & costly over time. Developers may 
            avoid making necessary changes to the fear of breaking existing functionality -- Brittle software

// Mitigation Strategies: To mitigate the FBC Problem, software developers can use design principles such as 
the Open/Closed Principle (OCP) & Dependency Inversion Principle (DIP), as well as Composition over Inheritance.
These approaches can promote loose coupling, encapsulation, and modular design, reducing the impact of changes
in the base classes.
******************/

/******************
Single Responsibility Principle (SRP)
    - A class should have only one reason to change, meaning that a class should have only
        one job or responsibility.
    - This allows for a global change to a single class, rather than multiple classes meaning the class 
        is public and global so that it can be accessed by other classes.
    - Only one instance of the class is created and shared by all other classes.
******************/
User user1 = new User { Username = "JohnDoe", Email = "joe@joe.com" };
UserService userService = new UserService();
userService.Register(user1);
System.Console.WriteLine("***********************************************************");

/******************
Open/Closed Principle (OCP)
    - A class should be open for extension but closed for modification.
    - This means that a class should be easily extensible without modifying the class itself.
    - Use of polymorphism and abstraction to achieve this principle and allows code to easily be extended
        through inheritance and composition.
******************/

Shape circle = (new Circle { Radius = 5 });

System.Console.WriteLine($"The area of the circle is: {circle.CalculateArea()}");
Shape rectangle = (new Rectangle { Width = 5, Length = 10 });
System.Console.WriteLine($"The area of the rectangle is: {rectangle.CalculateArea()}");
System.Console.WriteLine("***********************************************************");

/******************
Liskov Substitution Principle (LSP)
    - Objects of a superclass should be replaceable with objects of its subclasses without affecting the
        functionality of the program.
    - This means that a class should be able to be replaced by any of its subclasses without any issues.
    - This is achieved through inheritance and polymorphism.
******************/

var rect = new LSPRectangle();
rect.Height = 10;
rect.Width = 5;
System.Console.WriteLine($"The area of the rectangle is: {rect.Area}");

LSPShape rect2 = new LSPRectangle { Height = 4, Width = 5 };
System.Console.WriteLine($"The area of the rectangle is: {rect2.Area}");


var square = new LSPSquare();
square.Side = 5;
System.Console.WriteLine($"The area of the square is: {square.Area}");

LSPShape square2 = new LSPSquare { Side = 4 };
System.Console.WriteLine($"The area of the square is: {square2.Area}");


var circle2 = new LSPCircle();
circle2.Radius = 5;
System.Console.WriteLine($"The area of the circle is: {circle2.Area}");

LSPShape circle3 = new LSPCircle { Radius = 4 };
System.Console.WriteLine($"The area of the circle is: {circle3.Area}");

System.Console.WriteLine("***********************************************************");

/******************
Interface Segregation Principle (ISP)
    - A client should never be forced to implement an interface that it doesn't use.
    - This means that a class should not be forced to implement interfaces that it does not use.
    - This is achieved by breaking up interfaces into smaller, more specific interfaces.
******************/
var circle4 = new ISPCircle();
circle4.Radius = 6;
System.Console.WriteLine($"The area of the circle is: {circle4.Area()}");

var sphere = new ISPSphere();
sphere.Radius = 6;
System.Console.WriteLine($"The area of the sphere is: {sphere.Area()}");
System.Console.WriteLine($"The volume of the sphere is: {sphere.Volume()}");

ISPCircle circle5 = new ISPCircle { Radius = 7 };  
System.Console.WriteLine($"The area of the circle is: {circle5.Area()}");

ISPSphere sphere2 = new ISPSphere { Radius = 7 };
System.Console.WriteLine($"The area of the sphere is: {sphere2.Area()}");
System.Console.WriteLine($"The volume of the sphere is: {sphere2.Volume()}");
System.Console.WriteLine("***********************************************************");

/******************
Dependency Inversion Principle (DIP)
    - High-level modules should not depend on low-level modules. Both should depend on abstractions.
    - Abstractions should not depend on details. Details should depend on abstractions.
    - This means that classes should depend on abstractions, not on concrete implementations.
    - This is achieved through the use of interfaces and dependency injection.
    - Focus on decoupling high-level modules from low-level modules to reduce the impact of changes.
******************/

var car4 = new DIPCar(new DIPEngine());
car4.StartCar();
var electricCar = new DIPCar(new DIPElectricEngine());
electricCar.StartCar();
System.Console.WriteLine("***********************************************************");





