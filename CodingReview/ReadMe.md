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
******************************************************/

/*******************
* Encapsulation
*******************/

/******************
* Abstracttion 
    - Hides the complex implementation details and shows only the necessary features of an object.
    - It helps to reduce programming complexity and effort by making methods private,
        and hiding the unnecessary details from the user. 
    - In this example, the user doesn't need to see the connection, authentication, and disconnection details.
******************/

/******************
* Inheritance
    - It is a mechanism in which one class acquires the property of another class.
    - It is useful for code reusability: the methods and fields of the base class can be reused in the derived class.
    - This is an example of a "is-A" relationship.
******************/

/******************
* Polymorphism
    - It is a mechanism that allows one interface to be used for a general class of actions.
    - It allows methods to do different things based on the object that it is acting upon.
    - This is an example of a "is-A" relationship.
******************/

/******************
* Coupling
    - The degree of dependency between two classes.
    - It is a measure of how closely connected two classes or modules are.
    - Use of interfaces to decouple classes
******************/

/******************
* Composition
    - It is a design technique in object-oriented programming to implement "has-A" relationship between objects.
    - In composition, objects are assembled together to form a more complex object. This helps each component
        object maintain its own state and behavior.
******************/

/******************
* Composition vs Inheritance

* * When to Use Composition:
    - When you want more flexibility in constructing objects by assempling smaller, reusable components
    - When ther is no clear "is-A" relationship between the classes, thus a "has-A"
         relationship is more appropriate
    - Avoid Inheritance limitations like tight coupling, fragile base class problem, and 
        the inability to change the implementation of a class at runtime

* * When to Use Inheritance:
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

* * // Migration Strategies: To mitigate the FBC Problem, software developers can use design principles such as 
the Open/Closed Principle (OCP) & Dependency Inversion Principle (DIP), as well as Composition over Inheritance.
These approaches can promote loose coupling, encapsulation, and modular design, reducing the impact of changes
in the base classes.
******************/