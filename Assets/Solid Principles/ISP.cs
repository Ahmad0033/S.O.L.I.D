// Example of Interface Segregation Principle (ISP)
// This interface represents a worker.

public interface IWorker
{
    void Work();
}

public class Robot : IWorker
{
    public void Work()
    {
        // Code for robot work functionality
    }
}


public class Human : IWorker
{
    public void Work()
    {
        // Code for human work functionality
    }
}
