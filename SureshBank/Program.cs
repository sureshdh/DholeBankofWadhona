// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("***********Dhole Bank oF Wadhona*************");
Console.WriteLine("::Login Page::");

//Decalring the varible to store user name and Password 

string userName = null, password = null;

//read username from the keyboard
Console.WriteLine("UserName");
userName = Console.ReadLine();




if (userName != "")
{
	Console.WriteLine("Password");
	password = Console.ReadLine();
}
//check username and the password
if (userName == "Sureshdhole" && password == "Suresh11@1994")
{
	int mainMenuChoice = -1;
	do
	{
		//Declare avarible to store menu choice 

		//Show main menu	
		
		Console.WriteLine("TO DO : Main menu Here");
		Console.WriteLine("1.Customers");
		Console.WriteLine("2.Accounts");
		Console.WriteLine("3.Fund transfer");
		Console.WriteLine("4.Account statement ");
		Console.WriteLine("5.Exit");


		//Accept the menu choice from the Keybaord
		Console.WriteLine("Enter Choice :");
		mainMenuChoice = int.Parse(Console.ReadLine());

		switch (mainMenuChoice)
		{
			//To Dispaly customers menu
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
				break;
			case 5:
				break;
		}
	} while (mainMenuChoice !=0);


}
else
{
	Console.WriteLine("Invlaid username or Password ");
}
Console.WriteLine("Thank you ! Visit again");
Console.ReadKey();