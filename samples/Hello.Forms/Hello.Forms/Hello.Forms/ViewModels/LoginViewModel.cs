﻿using System;
using System.Diagnostics;
using Caliburn.Micro;

namespace Hello.Forms.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string username;
        private string password;
        private string feedback;

        public LoginViewModel()
        {
            Debug.WriteLine("Test");
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                NotifyOfPropertyChange(() => Username);
                NotifyOfPropertyChange(() => CanLogin);
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogin);
            }
        }

        public string Feedback
        {
            get { return feedback; }
            set
            {
                feedback = value;
                NotifyOfPropertyChange(() => Feedback);
            }
        }

        public bool CanLogin
        {
            get { return !String.IsNullOrEmpty(Username) && !String.IsNullOrEmpty(Password); }
        }

        public void Login()
        {
            if (Username == "fail")
            {
                Feedback = "Your details were incorrect";
            }
        }
    }
}
