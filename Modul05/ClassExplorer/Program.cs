﻿using System;

namespace ClassExplorer
{
	public class person
	{
		private string simpleString = "тестова променлива за клас";
		private string user = "";

		private string hiddenString = "";

		public person ( string _ini)
		{
			getUser (_ini);
			setWelcomeTExt ();

		

//			simpleString = "Промяна на променлива при инициализиране";
		}

		private void getUser (string _ini )
		{
			if (_ini == "password1")
				hiddenString = "Потребител 1";
			if (_ini == "password2")
				hiddenString = "Потребител 2";

			user = hiddenString;
		}

		private void setWelcomeTExt ()
		{
			if (hiddenString.Length > 0)
				simpleString = "Добре дошли отново, " + user + "!";
			else
				simpleString = "Вие нямата достъп до тази програма";
		}

		public string getWelcomeMessage ()
		{
			return simpleString;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Парола: "); string _user = Console.ReadLine ();
			//Дефиниране на клас
			person _person = new person( _user );

			//Достъпване на клас
			Console.WriteLine (_person.getWelcomeMessage ());
		}
	}
}
