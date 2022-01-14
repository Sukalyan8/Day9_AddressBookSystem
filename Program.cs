using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");

            UC2_AddTheDetails addTheDetails = new UC2_AddTheDetails();
            addTheDetails.EnterInput();
            addTheDetails.ViewTheDetails();
            //addTheDetails.PrintTheDetails();

            UC3_EditDetails editDetails = new UC3_EditDetails();
            editDetails.EditUsingName();

            UC4_DeleteDetails deleteDetails = new UC4_DeleteDetails();
            deleteDetails.DeletetheName();

        }
    }
}