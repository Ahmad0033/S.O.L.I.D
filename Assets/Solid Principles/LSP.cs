// Example of  Liskov Substitution Principle (LSP) 
// Animal is Abstract Class

public abstract class Animal
{
    public abstract void MakeSound();
}


public class Dog : Animal
{
    public override void MakeSound()
    {
        // Code for dog sound
    }
}


public class Bird : Animal
{
    public override void MakeSound()
    {
        // Code for bird sound
    }
}