﻿using Event_Project.Attendees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Event_Project
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new Event_Project.Login.LoginEmailPage());

            //MainPage = new NavigationPage(new AttendeesCarouselPage());

            //MainPage = new NavigationPage(new AttandeesHomePage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
