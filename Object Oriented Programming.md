# Untitled

## **Introduction to Object-Oriented Programming**

Object-oriented programming (OOP) is a programming paradigm that uses objects to represent and manipulate data. It is a popular approach to software development as it enables code reusability, maintainability, and extensibility. OOP is widely used in many programming languages, including Java, Python, C++, and Ruby.

The basic principle of OOP is that it models real-world entities as objects that have properties and behaviours. An object is an instance of a class, which is a blueprint that defines the properties and methods (behaviours) that an object of that class can have.

### **Key Concepts of OOP**

### Classes and Objects

A class is a blueprint for creating objects. It defines the properties and methods that an object of that class can have. An object is an instance of a class, and it can have its own set of values for the properties defined in the class.

For example, let's say we are building a program to model a car dealership. We could define a "Car" class that has properties like make, model, and color, and behaviour's like "start engine" and "drive".

```csharp
class Car {
    // Properties
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    
    // Behaviors
    public void StartEngine() {
        // Code to start the engine
    }
    
    public void Drive() {
        // Code to drive the car
    }
}
```

In this example, we have defined a Car class with properties for make, model, and color, and behaviors for starting the engine and driving the car. We can create new Car objects by instantiating the Car class:

```csharp

Car myCar = new Car();
myCar.Make = "Honda";
myCar.Model = "Civic";
myCar.Color = "Red";
myCar.StartEngine();
myCar.Drive();
```

By creating objects with specific properties and behaviours, we can write code that is more organised, reusable, and maintainable.

### Encapsulation

Encapsulation is the practice of hiding the internal workings of an object from the outside world. It is achieved by making the data and methods of the object private, so that they can only be accessed by methods within the object itself.The concept of "encapsulation", which means that we hide the internal details of an object and only expose a public interface that other code can interact with.

 For example, in our Car class, we could make the properties private and use public methods to get and set their values:

```csharp
class Car {
    // Private properties
    private string make;
    private string model;
    private string color;
    
    // Public methods to get and set properties
    public string GetMake() {
        return make;
    }
    
    public void SetMake(string make) {
        this.make = make;
    }
    
    // More code...
}
```

### Inheritance

Inheritance is the ability to create a new class from an existing class. The new class, called the subclass, inherits the properties and methods of the existing class, called the superclass. This enables code reuse and makes it easier to create new classes that have similar functionality to existing classes.Inheritance  allows us to create new classes that inherit properties and behaviours from existing classes.

 For example, let's say we want to model different types of cars, like sports cars and SUVs. We could create a new class for each type of car that inherits from the Car class:

```csharp
class SportsCar : Car {
    // Additional properties and behaviors for sports cars
    public bool IsConvertible { get; set; }
    
    public void Accelerate() {
        // Code to accelerate a sports car
    }
}

class SUV : Car {
    // Additional properties and behaviors for SUVs
    public int CargoCapacity { get; set; }
    
    public void LoadCargo() {
        // Code to load cargo into an SUV
    }
}
```

In this example, we have created two new classes, SportsCar and SUV, that inherit from the Car class. The SportsCar class has an additional property for whether the car is a convertible and a behavior for accelerating, while the SUV class has an additional property for cargo capacity and a behavior for loading cargo.

We can create new objects of these classes and use their specific properties and behaviours:

```csharp
SportsCar mySportsCar = new SportsCar();
mySportsCar.Make = "Porsche";
mySportsCar.Model = "911";
mySportsCar.Color = "Yellow";
mySportsCar.IsConvertible = true;
mySportsCar.StartEngine();
mySportsCar.Accelerate();

SUV mySUV = new SUV();
mySUV.Make = "Ford";
mySUV.Model = "Explorer";
mySUV.Color = "Blue";
mySUV.CargoCapacity = 500;
mySUV.StartEngine();
mySUV.LoadCargo();
```

By using inheritance, we can create new classes that are similar to existing classes but have additional properties and behaviours, allowing us to reuse code and make our programs more efficient.

### Polymorphism

Polymorphism is the ability of objects of different classes to be treated as if they are of the same class. This is achieved through inheritance and interfaces, which enable objects to have the same methods with different implementations.Polymorphism comes in two forms: "compile-time polymorphism" and "run-time polymorphism".

Compile-time polymorphism, also known as "method overloading", allows us to define multiple methods with the same name but different parameters. The compiler determines which method to call based on the number and types of the arguments passed in. For example:

```csharp
class Math {
    public int Add(int a, int b) {
        return a + b;
    }
    
    public double Add(double a, double b) {
        return a + b;
    }
}
```

In this example, we have defined two Add methods that take different types of parameters (integers and doubles). When we call the Add method, the compiler chooses the appropriate method based on the types of the arguments passed in:

```csharp
Math math = new Math();
int result1 = math.Add(2, 3);        // Calls the int Add method
double result2 = math.Add(2.5, 3.7); // Calls the double Add method
```

Run-time polymorphism, also known as "method overriding", allows us to define a method in a subclass that has the same name and parameters as a method in its superclass. The subclass method "overrides" the superclass method, providing a new implementation for that method. For example:

```csharp
class Animal {
    public virtual void MakeSound() {
        Console.WriteLine("The animal makes a sound");
    }
}

class Dog : Animal {
    public override void MakeSound() {
        Console.WriteLine("The dog barks");
    }
}
```

In this example, we have defined an Animal class with a virtual MakeSound method and a Dog class that overrides the MakeSound method. When we call the MakeSound method on a Dog object, the implementation in the Dog class is used:

```csharp
Animal myAnimal = new Animal();
myAnimal.MakeSound(); // Outputs "The animal makes a sound"

Dog myDog = new Dog();
myDog.MakeSound();    //
```

By using polymorphism, we can write code that is more flexible and adaptable, allowing us to work with objects of different types and provide different implementations for the same method.

### Interface

In object-oriented programming, an interface is a collection of abstract methods that define a contract for a class. An interface is like a blueprint for a class, specifying the methods that must be implemented by any class that implements the interface.

Interfaces are used to define a common set of methods that can be used by multiple classes, without specifying the implementation of those methods. This allows for greater flexibility and modularity in the code, as different classes can implement the same interface in different ways.

```csharp
interface IAnimal {
    void Eat();
    void Sleep();
}

class Dog : IAnimal {
    public void Eat() {
        Console.WriteLine("Dog is eating");
    }
    
    public void Sleep() {
        Console.WriteLine("Dog is sleeping");
    }
}

class Cat : IAnimal {
    public void Eat() {
        Console.WriteLine("Cat is eating");
    }
    
    public void Sleep() {
        Console.WriteLine("Cat is sleeping");
    }
}
```

In this example, we have defined an IAnimal interface with two methods: Eat and Sleep. We have also defined two classes that implement this interface: Dog and Cat. Each class implements the Eat and Sleep methods in their own way.

By using interfaces, we can write code that is more modular and flexible. We can write code that works with any class that implements the IAnimal interface, without having to know the details of the implementation. This allows us to write more generic code that can be reused in different contexts.

### **Advantages of OOP**

- Reusability: OOP enables code reuse, as objects can be easily reused in different parts of the program.
- Maintainability: OOP makes it easier to maintain code as changes can be made to individual objects without affecting the rest of the program.
- Extensibility: OOP makes it easier to add new features to a program by creating new objects or modifying existing ones.
- Modularity: OOP enables code to be divided into smaller, more manageable parts, making it easier to understand and maintain.
-