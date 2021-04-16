using System;

namespace dotaPlayer
{
	class SteamUser
	{
		protected string profileName;
		protected string realName;
		protected string customUrl;
		protected string country;
		protected string summary;
		protected string emailAddress;
		protected string phone;
		protected bool emailAddressStatus = false;
		protected bool steamGuardStatus = false;
		protected string password;
		protected int steamID = 0;
		protected static int countUsers = 0;
		protected string[] friends = new string[100];
		protected int countFriends = 0;
		protected int wallet = 0;

		public void ChangeProfileName()
		{
			Console.Write("Enter new profile name: ");
			profileName = Console.ReadLine();
		}

		public string ProfileName
		{
			get
			{
				return profileName;
			}
		}

		public void ChangeRealName()
		{
			Console.Write("Enter new real name: ");
			realName = Console.ReadLine();
		}

		public string RealName
		{
			get
			{
				return realName;
			}
		}

		public void ChangeCustomUrl()
		{
			Console.Write("Enter new custom url: ");
			customUrl = Console.ReadLine();
		}

		public string CustomUrl
		{
			get
			{
				return customUrl;
			}
		}

		public void ChangeCountry()
		{
			Console.Write("Enter new country: ");
			country = Console.ReadLine();
		}

		public string Country
		{
			get
			{
				return country;
			}
		}

		public void ChangeSummary()
		{
			Console.Write("Enter new summary: ");
			summary = Console.ReadLine();
		}

		public string Summary
		{
			get
			{
				return summary;
			}
		}

		public void ChangeEmailAddress()
		{
			Console.Write("Enter new email address: ");
			emailAddress = Console.ReadLine();
		}

		public string EmailAddress
		{
			get
			{
				return emailAddress;
			}
		}

		public void ChangePhone()
		{
			Console.Write("Enter new phone: ");
			phone = Console.ReadLine();
		}

		public string Phone
		{
			get
			{
				return phone;
			}
		}

		public void ChangePassword()
		{
			Console.Write("Enter new password: ");
			password = Console.ReadLine();
		}

		public string Password
		{
			get
			{
				return password;
			}
		}

		private void Registration()
		{
			countUsers++;
			steamID = countUsers;
			ChangeProfileName();
			ChangeRealName();
			ChangeCustomUrl();
			ChangeCountry();
			ChangeSummary();
			ChangeEmailAddress();
			ChangePhone();
			ChangePassword();
		}

		public void VerifyEmailAddress()
		{
			Console.Write("Enter verify code: ");
			string verifyCode = Console.ReadLine();
			if (verifyCode == "C#")
			{
				Console.WriteLine("Your email has been successfully verified");
				emailAddressStatus = true;
			}
			else
			{
				Console.WriteLine("Incorrect verify code");
			}
		}

		public bool EmailAddressStatus
		{
			get
			{
				return emailAddressStatus;
			}
		}

		public void VerifySteamGuard()
		{
			Console.Write("Enter verify code: ");
			string verifyCode = Console.ReadLine();
			if (verifyCode == "C#")
			{
				Console.WriteLine("Steam guard was activated");
				steamGuardStatus = true;
			}
			else
			{
				Console.WriteLine("Incorrect verify code");
			}
		}

		public bool SteamGuardStatus
		{
			get
			{
				return steamGuardStatus;
			}
		}

		public void AddFriend()
		{
			Console.Write("Enter friend's name: ");
			friends[countFriends++] = Console.ReadLine();
		}

		public string this[int index]
		{
			get
			{
				return friends[index];
			}
		}

		public void Deposit(int amount)
		{
			wallet += amount;
		}

		public int Wallet
		{
			get
			{
				return wallet;
			}
		}

		public void Deposit(string expression)
		{
			Console.WriteLine("Incorrect expression");
		}

		public SteamUser()
		{
			Registration();
		}
	}
}