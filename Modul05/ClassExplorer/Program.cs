using System;

namespace ClassExplorer
{
	public class person
	{
		public string simpleString = "тестова променлива за клас";
		public string user = "";

		private string hiddenString = "";

		public person ( string ini)
		{
			if (ini == "password1") hiddenString = "Потребител 1";
			if (ini == "password2") hiddenString = "Потребител 2";

			user = hiddenString;

			if (hiddenString.Length > 0)
				simpleString = "Добре дошли отново, " + user + "!";
			else
				simpleString = "Вие нямата достъп до тази програма";

//			simpleString = "Промяна на променлива при инициализиране";
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
			Console.WriteLine (_person.simpleString);
		}
	}
}
