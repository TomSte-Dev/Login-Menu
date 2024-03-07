namespace Login_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login userLogin = new Login();
            userLogin.AttemptLogin();

            Menu optionMenu = new Menu();
            optionMenu.MenuLoop();
        }
    }
}
