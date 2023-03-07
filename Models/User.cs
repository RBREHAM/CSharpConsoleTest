namespace CSharpConsoleTest.Models
{
    public class User
    {
        public User(int id, string firstName, string lastName, int old, int salary, int tax)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Old = old;
            this.Salary = salary;
            this.Tax = tax;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Old { get; set; }
        public int Salary { get; set; }
        public int Tax { get; set; }
    }
}
