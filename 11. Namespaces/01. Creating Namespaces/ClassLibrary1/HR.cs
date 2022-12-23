namespace HR
{
    //interface that represents an employee in the organization
    public interface IEmployee
    {
    }

    //interface that represents a manager, which inherits from IEmployee
    public interface IManager : IEmployee
    {
    }

    //interface that represents an executive, which inherits from IEmployee
    public interface IExecutive : IEmployee
    {
    }

    //class that represents a manager, which inherits from IManager
    public class Manager : IManager
    {
    }

    //class that represents an assistant manager, which inherits from IManager
    public class AsstManager : IManager
    {
    }

    //class that represents an executive, which inherits from IExecutive
    public class Executive : IExecutive
    {
    }
}

