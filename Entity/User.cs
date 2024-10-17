namespace Entity
{
    public class User
    {
        // Attributes
        private int userId;
        private string username;
        private string password;
        private string role;


        // Getters And Setters
        public int UserID { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public string Role { get; set; }

        // Default Constructor
        public User()
        {
        }

        // Parameterized Constructor
        public User(int userId, string username, string password, string role)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        // Method to print all variables
        public void PrintUserDetails()
        {
            Console.WriteLine($"User ID: {userId}, Username: {username}, Role: {role}");
        }
    }
}
