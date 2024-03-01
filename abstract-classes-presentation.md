---
marp: true
theme: wctc
style: |
  @import 'wctc-theme.css';
---
![WCTC Logo](https://www.wctc.edu/_resources/images/waukesha_logo.svg)

# Abstract Classes in C#
*Instructor: Mark McArthey*

---

## What is an Abstract Class?

- An abstract class is a special type of class in C# that cannot be instantiated directly.
- It is used as a base class for other classes.
- Abstract classes are designed to provide common functionality to derived classes.

---

## Defining an Abstract Class

```csharp
public abstract class Animal
{
    public abstract void MakeSound();

    public void Move()
    {
        Console.WriteLine("Moving...");
    }
}
```
- The abstract keyword is used to define an abstract class and abstract method.
- Abstract methods do not have a body and must be implemented by derived classes.

---

## Implementing an Abstract Class

```csharp
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark!");
    }
}
```
- Derived classes must implement all abstract methods from the base class.
- Use the override keyword to provide the implementation of the abstract method.

---
## Abstract Properties
```csharp
public abstract class Shape
{
    public abstract double Area { get; }
}
```
- Derived classes must provide an implementation for these properties.
---
## Interfaces vs Abstract Classes
- Both interfaces and abstract classes are used to achieve abstraction in C#.
- An interface defines a contract for what a class can do, without providing any implementation.
- An abstract class can provide both abstract methods (without implementation) and concrete methods (with implementation).
---

## Why Use Abstract Classes?

- To provide a common definition of a base class that multiple derived classes can share.
- To define a template for derived classes.
- To enforce certain methods to be implemented by derived classes.

---

## When to Use?

- Use an interface when you want to define a contract for a class without any implementation.
- Use an abstract class when you want to provide common functionality that derived classes can inherit and customize.
---

## State Management

- Abstract classes can have fields and properties to maintain state.
- Interfaces cannot have fields.

---

## Access Modifiers

- Abstract classes allow for `protected` and `private` access modifiers.
- Interface members are always `public` by default.

---

## Inheritance Structure

- Abstract classes provide a clear inheritance hierarchy.
- Interfaces are better for defining contracts without implying a hierarchy.

---

## Richer Behavior

- Abstract classes can offer constructors, destructors, and static methods.
- Interfaces with default implementations provide limited behavior.

---

## Versioning

- Adding new members to an abstract class is less likely to break existing derived classes.
- Adding new members to an interface can break existing implementations.

---

## Key Points to Remember
- Abstract classes cannot be instantiated.
- They are used to provide a common definition for derived classes.
- Derived classes must implement all abstract methods and properties.
- Abstract classes can contain both abstract and non-abstract members.
---

## Final Thoughts
## If a Class Contains an Abstract Method

- If a class contains at least one abstract method, then the class must also be declared abstract. 

```csharp
public abstract class AbstractClass
{
    public abstract void AbstractMethod();
}
```
---

## Final Thoughts
## Polymorphism and Abstract Classes
- Polymorphism is a key feature of abstract classes. It allows us to treat objects of a subclass as objects of its superclass, leading to simplified code and flexibility.
```csharp
List<Animal> animals = new List<Animal> { new Dog(), new Cat() };

foreach (var animal in animals)
{
    animal.MakeSound();
}
```
---

## Final Thoughts
## Sealed Classes in C#
- Sealed classes are the opposite of abstract classes. A sealed class cannot be inherited. It is a way of preventing further derivation.
```csharp
public sealed class SealedClass
{
    // class members here
}
```
---

## Summary

- Abstract classes are a powerful tool in C# for creating reusable and flexible code structures.
- They serve as a blueprint for other classes and enforce a certain level of contract.
- Abstract classes can contain both abstract (without implementation) and concrete (with implementation) methods.
- If a class has at least one abstract method, the class must be declared abstract.
- Polymorphism, a key feature of abstract classes, allows objects of a subclass to be treated as objects of its superclass.
- Sealed classes, the opposite of abstract classes, cannot be inherited.
- Choosing between interfaces, abstract classes, and regular classes depends on the specific needs of your design.




