namespace interface_enhancements
{
    public interface IEmployee
    {
        public string Name { get; set; }

        //default interface methods [or] virtual extension method
        public string GetNameInUpperCase()
        {
            return Name.ToUpper();
        }
    }

    public class Manager: IEmployee
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
    }

    public class Clerk: IEmployee
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
    }

    class Program
    {
        static void Main()
        {
            Manager manager = new Manager();
            manager.Name = "William";
            IEmployee iemp = manager;
            Console.WriteLine(iemp.GetNameInUpperCase());
            Console.ReadKey();
        }
    }
}
