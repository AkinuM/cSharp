using System;

namespace dotaPlayer
{
	interface ISteamUser
	{
		void ChangeProfileName();

		string ProfileName { get; }

		void ChangeRealName();

		string RealName { get; }

		void ChangeCustomUrl();

		string CustomUrl { get; }

		void ChangeCountry();

		string Country { get; }

		void ChangeSummary();

		string Summary { get; }

		void ChangeEmailAddress();

		string EmailAddress { get; }

		void ChangePhone();

		string Phone { get; }

		void ChangePassword();

		string Password { get; }

		void VerifyEmailAddress();

		bool EmailAddressStatus { get; }

		void VerifySteamGuard();

		bool SteamGuardStatus { get; }

		void AddFriend();

		string this[int index] { get; }

		void Deposit(int amount);

		int Wallet { get; }

		void Deposit(string expression);
	}
}
