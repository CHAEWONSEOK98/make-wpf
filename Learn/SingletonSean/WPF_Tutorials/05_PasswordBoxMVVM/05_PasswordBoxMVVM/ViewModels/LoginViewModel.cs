﻿using _05_PasswordBoxMVVM.Commands;
using System.Windows.Input;

namespace _05_PasswordBoxMVVM.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
		private string _username;

		public string Username
		{
			get { return _username; }
			set 
			{
				_username = value;
                OnPropertyChanged(nameof(Username));
            }
		}

		private string _password;

		public string Password
		{
			get { return _password; }
			set 
			{
				_password = value;
                OnPropertyChanged(nameof(Password));
            }
		}

		public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
			LoginCommand = new LoginCommand(this);
        }

    }
}
