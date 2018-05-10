using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace CreditCardValidator.Droid.UITests
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			app = ConfigureApp.Android.StartApp();
		}

		[Test]
		public void CreditCardNumber_TooShort_DisplayErrorMessage()
		{
			app.WaitForElement(c => c.Marked("action_bar_title").Text("Enter Credit Card Number"));
			app.Tap(c => c.Marked("validateButton"));
			app.WaitForElement(c => c.Marked("errorMessagesText").Text("This is not a credit card number."));
		}
	}
}

