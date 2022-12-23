namespace interface_enhancements
{
    public interface IEmployee
    {
        public string Name { get; set; }

        //private default interface methods
        private string GetNameTitle()
        {
            return "Mr./Ms.";
        }

        //default interface methods [or] virtual extension method
        internal string GetNameInUpperCase()
        {
            return GetNameTitle() + " " + Name.ToUpper();
        }

        internal string GetNameInLowerCase();

        internal int GetNameLength();
    }

    public class Manager: IEmployee
    {
        private string _name = "Unknown";
        public string Name { get => _name; set => _name = value; }

        //Option 1: You can explicitly implement non-public abstract interface methods
        string IEmployee.GetNameInLowerCase()
        {
            return Name.ToLower();
        }

        //Option 2: You can convert the non-public abstract interface method as 'public'
        public int GetNameLength()
        {
            return Name.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            Manager manager = new Manager();
            manager.Name = "William";
            IEmployee iemp = manager;
            Console.WriteLine(iemp.GetNameInUpperCase());
            Console.WriteLine(iemp.GetNameInLowerCase());
            Console.WriteLine(manager.GetNameLength());
            Console.ReadKey();
        }
    }
}
