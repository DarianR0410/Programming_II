namespace PracticaAula;

class Program
{
	static void Main(string[] args)
	{
		bool isRunning = true;
		Bank bank = new Bank();

		while (isRunning)
		{
			Console.WriteLine("Welcome to the bank management system!");
			Console.WriteLine("1. Create customer");
			Console.WriteLine("2. Delete customer");
			Console.WriteLine("3. Look for a customer");
			Console.WriteLine("4. Get all  customers");
			Console.WriteLine("5. Create  current account");
			Console.WriteLine("6. Delete current account");
			Console.WriteLine("7. Look for a current account");
			Console.WriteLine("8. Get all current accounts");
			Console.WriteLine("9. Create saving account");
			Console.WriteLine("10. Delete saving account");
			Console.WriteLine("11. Look for a saving account");
			Console.WriteLine("12. Get all saving accounts");
			Console.WriteLine("13. Deposit in current account");
			Console.WriteLine("14. Withdraw from current account");
			Console.WriteLine("15. Deposit in saving account");
			Console.WriteLine("16. Withdraw from saving account");
			Console.WriteLine("17. Exit");

			int option = Convert.ToInt32(Console.ReadLine());

			switch (option)
			{
				case 1:
				{
					Console.WriteLine("To register with us, please provide the following information:");
					Console.Write("Name: ");
					string name = Console.ReadLine();
					Console.Write("Last Name: ");
					string lastName = Console.ReadLine();
					Console.Write("ID: ");
					long id = long.Parse(Console.ReadLine());
					Customer customer = bank.AddCustomer(name, lastName, id);

					if (customer != null)
					{
						Console.WriteLine("You've registered successfully!");
						Console.WriteLine("Welcome to our bank, " + customer.name + " " + customer.lastName);
					}
					else
					{
						Console.WriteLine("Failed to register customer. Please check your information and try again.");
					}
				}
					break;
				case 2:
				{
					Console.WriteLine("It seems you would like to leave our family, we are sorry to see you go.");
					Console.WriteLine("To proceed with your request, please provide us with your ID:");
					long id = long.Parse(Console.ReadLine());
					Customer customer = bank.DeleteCustomer(id);

					if (customer != null)
					{
						Console.WriteLine("Your account has been successfully deleted.");
					}
					else
					{
						Console.WriteLine("We couldn't find your account. Please check your ID and try again.");
					}
				}
					break;
				case 3:
				{
					Console.WriteLine("To look for a customer, please provide their ID:");
					long id = long.Parse(Console.ReadLine());
					Customer customer = bank.GetCustomer(id);

					if (customer != null)
					{
						Console.WriteLine("Customer found under the id: " + customer.Id);
						Console.WriteLine("Name: " + customer.name + " " + customer.lastName);
					}
					else
					{
						Console.WriteLine("No customer found with that ID.");
					}
				}
					break;
				case 4:
				{
					Console.WriteLine("Here is a list of all our current customers:");
					List<Customer> customers = bank.GetAllCustomers();

					if (customers != null && customers.Count > 0)
					{
						foreach (var customer in customers)
						{
							Console.WriteLine($"ID: {customer.Id}, Name: {customer.name} {customer.lastName}");
						}
					}
					else
					{
						Console.WriteLine("No customers found.");
					}
				}
					break;
				case 5:
				{
					Console.WriteLine(
						"Welcome! To open a current account with us, please allow us the following information:");
					Console.Write("Enter an account number you would like to use: ");
					long accountNumber = long.Parse(Console.ReadLine());
					Console.WriteLine("The account number is available.");
					Console.Write("Enter your ID: ");
					long id = long.Parse(Console.ReadLine());
					Customer customer = bank.GetCustomer(id);

					if (customer != null)
					{
						Console.WriteLine(
							"To complete the process of opening a current account, please provide the following information:");
						Console.WriteLine("Please enter the initial deposit amount (minimum 1000): ");
						decimal initialDeposit = decimal.Parse(Console.ReadLine());
						CurrentAccount currentAccount = bank.AddCurrentAccount(initialDeposit, accountNumber, customer);

						if (currentAccount != null)
						{
							Console.WriteLine("Congratulations! " + customer.name +
							                  " Your current account has been successfully opened under the account number: " +
							                  accountNumber);
						}
						else
						{
							Console.WriteLine(
								"Failed to create current account. Please check your information and try again.");
						}
					}
					else
					{
						Console.WriteLine("Customer not found. Please register first.");
					}
				}
					break;
				case 6:
				{
					Console.WriteLine("To delete a current account, please provide the account number:");
					long accountNumber = long.Parse(Console.ReadLine());
					CurrentAccount currentAccount = bank.DeleteCurrentAccount(accountNumber);

					if (currentAccount != null)
					{
						Console.WriteLine("Your current account has been successfully deleted.");
					}
					else
					{
						Console.WriteLine("No current account found with that account number.");
					}
				}
					break;
				case 7:
				{
					Console.WriteLine(
						"Welcome! To look for your current account, please provide the following information.");
					Console.Write("Enter your account number: ");
					long accountNumber = long.Parse(Console.ReadLine());
					CurrentAccount currentAccount = bank.GetCurrentAccount(accountNumber);

					if (currentAccount != null)
					{
						Console.WriteLine("Your current account has been found!");
						Console.WriteLine(
							$"Account Number: {currentAccount.accountNumber}, Balance: {currentAccount.balance}, Customer: {currentAccount.customer.name} {currentAccount.customer.lastName}");
					}
					else
					{
						Console.WriteLine("No current account found with that account number.");
					}
				}
					break;
				case 8:
				{
					Console.WriteLine("Here is a list of all current accounts:");
					List<CurrentAccount> currentAccounts = bank.GetAllCurrentAccounts();

					if (currentAccounts != null && currentAccounts.Count > 0)
					{
						foreach (var account in currentAccounts)
						{
							Console.WriteLine(
								$"Account Number: {account.accountNumber}, Balance: {account.balance}, Customer: {account.customer.name} {account.customer.lastName}");
						}
					}
					else
					{
						Console.WriteLine("No current accounts found.");
					}
				}
					break;
				case 9:
				{
					Console.WriteLine(
						"Welcome! To open a saving account with us, please allow us the following information:");
					Console.Write("Enter an account number you would like to use: ");
					long accountNumber = long.Parse(Console.ReadLine());
					Console.WriteLine("The account number is available.");
					Console.Write("Enter your ID: ");
					long id = long.Parse(Console.ReadLine());
					Customer customer = bank.GetCustomer(id);

					if (customer != null)
					{
						Console.WriteLine(
							"To complete the process of opening a saving account, please provide the following information:");
						Console.WriteLine("Please enter the initial deposit amount: ");
						decimal initialDeposit = decimal.Parse(Console.ReadLine());
						SavingAccount savingAccount = bank.AddSavingAccount(initialDeposit, accountNumber, customer);

						if (savingAccount != null)
						{
							Console.WriteLine("Congratulations! " + customer.name +
							                  " Your saving account has been successfully opened under the account number: " +
							                  accountNumber);
						}
						else
						{
							Console.WriteLine(
								"Failed to create saving account. Please check your information and try again.");
						}
					}
					else
					{
						Console.WriteLine("Customer not found. Please register first.");
					}
				}
					break;
				case 10:
				{
					Console.WriteLine(
						"It seems you would like to delete a saving account, we are sorry to see you go.");
					Console.WriteLine("To proceed with your request, please provide us with your account number:");
					long accountNumber = long.Parse(Console.ReadLine());
					SavingAccount savingAccount = bank.DeleteSavingAccount(accountNumber);
					if (savingAccount != null)
					{
						Console.WriteLine("Your saving account has been successfully deleted.");
					}
					else
					{
						Console.WriteLine(
							"We couldn't find your account. Please check your account number and try again.");
					}
				}
					break;
				case 11:
				{
					Console.WriteLine(
						"Welcome! To look for your saving account, please provide the following information.");
					Console.Write("Enter your account number: ");
					long accountNumber = long.Parse(Console.ReadLine());
					SavingAccount savingAccount = bank.GetSavingAccount(accountNumber);
					if (savingAccount != null)
					{
						Console.WriteLine("Your saving account has been successfully found under the account number: " +
						                  accountNumber);
						Console.WriteLine(
							$"Balance: {savingAccount.balance}, Customer: {savingAccount.customer.name} {savingAccount.customer.lastName}");
					}
					else
					{
						Console.WriteLine("No saving account found with that account number.");
					}
				}
					break;
				case 12:
				{
					Console.WriteLine("Here is a list of all saving accounts:");
					List<SavingAccount> savingAccounts = bank.GetAllSavingAccounts();

					if (savingAccounts != null && savingAccounts.Count > 0)
					{
						foreach (var account in savingAccounts)
						{
							Console.WriteLine(
								$"Account Number: {account.accountNumber}, Balance: {account.balance}, Customer: {account.customer.name} {account.customer.lastName}");
						}
					}
					else
					{
						Console.WriteLine("No saving accounts found.");
					}
				}
					break;
				case 13:
				{
					Console.WriteLine(
						"Welcome! To deposit money into your current account, please provide the following information:");
					Console.Write("Enter your account number: ");
					long accountNumber = long.Parse(Console.ReadLine());
					CurrentAccount currentAccount = bank.GetCurrentAccount(accountNumber);
					if (currentAccount != null)
					{
						Console.WriteLine("Your current account has been found!");
						Console.WriteLine("Account number: " + currentAccount.accountNumber);
						Console.WriteLine(
							"To make a deposit, please enter the amount you would like to deposit (minimum 1000): ");
						decimal depositAmount = decimal.Parse(Console.ReadLine());

						if (depositAmount < 1000)
						{
							Console.WriteLine("Your deposit must be greater than 1000.");
						}
						else
						{
							currentAccount.Deposit(depositAmount);
							Console.WriteLine("Deposit of " + depositAmount + " made. Your new balance is " +
							                  currentAccount.balance);
						}
					}
					else
					{
						Console.WriteLine("No current account found with that account number.");
					}
				}
					break;
				case 14:
				{
					Console.WriteLine(
						"Welcome! To make a withdraw from your current account, please allow us the following information.");
					Console.Write("Enter your account number: ");
					long accountNumber = long.Parse(Console.ReadLine());
					CurrentAccount currentAccount = bank.GetCurrentAccount(accountNumber);

					if (currentAccount != null)
					{
						Console.WriteLine("Your current account has been found!");
						Console.WriteLine("Account number: " + currentAccount.accountNumber);
						Console.WriteLine("To make a withdraw, please enter the amount you would like to withdraw: ");
						decimal withdrawAmount = decimal.Parse(Console.ReadLine());

						try
						{
							currentAccount.Withdraw(withdrawAmount);
							Console.WriteLine("Withdrawal of " + withdrawAmount + " made. Your new balance is " +
							                  currentAccount.balance);
						}
						catch (ArgumentException ex)
						{
							Console.WriteLine(ex.Message);
						}
					}
					else
					{
						Console.WriteLine("No current account found with that account number.");
					}
				}
					break;
				case 15:
				{
					Console.WriteLine(
						"Welcome! To deposit money into your saving account, please provide the following information:");
					Console.Write("Enter your account number: ");
					long accountNumber = long.Parse(Console.ReadLine());
					SavingAccount savingAccount = bank.GetSavingAccount(accountNumber);

					if (savingAccount != null)
					{
						Console.WriteLine("Your saving account has been found under the account number: " +
						                  savingAccount.accountNumber);
						Console.WriteLine("To make a deposit, please enter the amount you would like to deposit: ");
						decimal depositAmount = decimal.Parse(Console.ReadLine());
						savingAccount.Deposit(depositAmount);

						Console.WriteLine("Deposit of " + depositAmount + " made. Your new balance is " +
						                  savingAccount.balance);
					}
					else
					{
						Console.WriteLine("No saving account found with that account number.");
					}
				}
					break;
				case 16:
				{
					Console.WriteLine(
						"Welcome! To make a withdraw from your saving account, please allow us the following information.");
					Console.Write("Enter your account number: ");
					long accountNumber = long.Parse(Console.ReadLine());
					SavingAccount savingAccount = bank.GetSavingAccount(accountNumber);

					if (savingAccount != null)
					{
						Console.WriteLine("Your saving account has been found!");
						Console.WriteLine("Account number: " + savingAccount.accountNumber);
						Console.WriteLine("To make a withdraw, please enter the amount you would like to withdraw: ");
						decimal withdrawAmount = decimal.Parse(Console.ReadLine());

						try
						{
							savingAccount.Withdraw(withdrawAmount);
							Console.WriteLine("Withdrawal of " + withdrawAmount + " made. Your new balance is " +
							                  savingAccount.balance);
						}
						catch (ArgumentException ex)
						{
							Console.WriteLine(ex.Message);
						}
					}
					else
					{
						Console.WriteLine("No saving account found with that account number.");
					}
				}
					break;
				case 17:
					Console.WriteLine("Thank you for using our bank management system. Goodbye!");
					isRunning = false;
					break;

				default:
					Console.WriteLine("Invalid option");
					break;
			}
		}
	}
}