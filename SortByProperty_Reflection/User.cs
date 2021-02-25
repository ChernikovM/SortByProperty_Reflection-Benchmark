namespace SortByProperty_Reflection
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public User()
        {
            FirstName = Program.RandomStringGenerate(10);
            LastName = Program.RandomStringGenerate(10);
            Email = Program.RandomStringGenerate(10);
        }
    }
}
