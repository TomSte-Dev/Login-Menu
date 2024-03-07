namespace Login_Menu
{
    class Login
    {
        // this is a dictionary of usernames and passwords
        private Dictionary<string, string> UserInformation = new Dictionary<string, string>()
        { 
            //usernames must be in lower case due to non case sensitivity checking
            {"admin", "Password123"},
            {"tom", "password"},
            {"joe", "P@ssw0rd"},
            {"john", "Secret123"},
            {"jane", "qwerty"},

        };

        public void AttemptLogin()
        {
            // input strings are initialized here to be outside of the scope of the loop
            string? inputUsername;
            string? inputPassword;

            do
            {
                // asks for username and password
                Console.Write("Username: ");
                inputUsername = Console.ReadLine();

                Console.Write("Password: ");
                inputPassword = Console.ReadLine();

            } while (!ValidateLogin(inputUsername.ToLower(), inputPassword));
            /* while the username/password is not valid ask again
             * ToLower is used to ensure usernames are not case sensitive
             */
        }

        private bool ValidateLogin(string username, string password)
        {
            // determines if the username is
            if (UserInformation.ContainsKey(username) && UserInformation[username] == password)
                return true;

            // provide a prompt for an invalid input
            Console.Clear();
            Console.WriteLine("-- ! Incorrect Username or Password ! --");
            return false;
        }
    }
}
