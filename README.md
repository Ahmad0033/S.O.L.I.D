# S.O.L.I.D
 Examples Codes For SOLID Principles

 Each principle is presented in different scripts,script are named after principle name, each script is commented to explain whats happening in code, but i will explain them here as well

 1)Single Responsibility Principle (SRP) Example:

    FileManager class has a single responsibility, which is handling file operations. It adheres to the SRP by focusing on a specific functionality without having unrelated concerns.

2)Open-Closed Principle (OCP) Example:

    The Shape class is the abstract base class representing different shapes. It follows the OCP by being closed for modification and open for extension. We can easily introduce new shapes by creating derived classes that inherit from Shape without modifying the existing code.
    We create a design that is flexible and allows for easy extension with new shapes, without requiring modifications to the existing code

3)Liskov Substitution Principle (LSP) Example:

    The Dog and Bird classes inherit from the Animal base class. They adhere to the LSP by being substitutable for the Animal base class, meaning they can be used interchangeably without affecting the correctness of the program.

4)Interface Segregation Principle (ISP) Example:

    ISP, each class (such as Robot and Human) depends only on the methods they actually need, promoting a clear and focused interface design. This allows for easy maintenance, extensibility, and flexibility in the system

5)Dependency Inversion Principle (DIP) Example:

    The high-level module (MessageService) depends on an abstraction (IMessageSender), while the low-level modules (EmailSender, SmsSender) implement that abstraction. This promotes loose coupling, modularity, and flexibility, allowing for easy maintenance, testing, and future changes in the system.


