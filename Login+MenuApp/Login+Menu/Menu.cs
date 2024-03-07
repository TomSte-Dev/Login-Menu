namespace Login_Menu
{
    class Menu
    {
        public void MenuLoop()
        {
            string? input;
            int option = 1; // set to 1 initially as 0 indicates an invalid input

            do 
            {
                // displays the menu to the console
                DisplayMenu();

                // asks the user to provide an option. also provides a prompt for invalid inputs
                Console.Write(option != 0 ? "Please enter an option: " : "--! Invalid Input !--\nPlease enter an option: ");
                input = Console.ReadLine();

                // checks if the input is a number or an x 
                if (int.TryParse(input, out option))
                {
                    // display the menu options to the console
                    Console.Clear();
                    switch (input.ToLower())
                    {
                        case "1":
                            CreateNewMember();
                            break;
                        case "2":
                            EditMember();
                            break;
                        case "3":
                            ViewMember();
                            break;
                        case "4":
                            DeleteMember();
                            break;
                        default:
                            //if an invalid number is provided setting option to 0 will signify this on the next loop
                            option = 0;
                            continue; // jumping to the start prevents the pause below
                    }

                    // provides a pause for the user to read the displayed optiom
                    Console.ReadLine();
                }
            } while (input != "x");
            //do while used as we would always need to enter the loop initially
        }

        // displays the menu
        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine(""" 
                -- Main Menu --
                1. Create new member
                2. Edit member
                3. View member
                4. Delete member
                x. Exit

                """);
        }

        /* options are broken down into methods seperating them from 
         * the switch statement allowing for ease of future additions */
        #region Option Methods
        private void CreateNewMember()
        {
            Console.WriteLine("Create new member");
        }

        private void EditMember()
        {
            Console.WriteLine("Edit member");
        }

        private void ViewMember()
        {
            Console.WriteLine("View member");
        }

        private void DeleteMember()
        {
            Console.WriteLine("Delete member");
        }
        #endregion
    }
}

