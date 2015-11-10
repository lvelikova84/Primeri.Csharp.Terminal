using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Console.WriteLine ("Hello World!");
			// Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Modul02 - Примери";
			string program_version = "1.0";

			// Събиране на числа
			a = 10;
			b = 5;

			sum = a + b;

			//за Програмата
			Console.WriteLine (program_name);
			Console.WriteLine ("Версия: " + program_version + "\n\n");



			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write (" = ");
			Console.WriteLine (sum);

			//Допълнителни оператори
			Console.WriteLine ("\n Използване на += ");
			a += b; 
			Console.Write ( a );

			Console.WriteLine ("\n Използване на -= ");
			a -= b; 
			Console.Write ( a );

			Console.WriteLine ("\n Използване на *= ");
			a *= b; 
			Console.Write ( a );

			Console.WriteLine ("\n Използване на ++ ");
			a++; 
			Console.WriteLine ( a );

			Console.WriteLine ("Стандартно делене:" + (7 / 3).ToString ()); // ->2 (7/3=2,333)
			Console.WriteLine ("Остатък от делене:" + (7 % 3).ToString ()); // ->1 (1/3=0,333)
			string[,] table = new string[2, 3];

			// Въвеждане на първи ред
			table[0,0] = "Мартин"; table[0,1] = "Симеонов"; table[0,2] = "31";

			// Въвеждане на втори ред
			table[1,0] = "Симеон"; table[1,1] = "Мартинов"; table[2,2] = "41";
			Console.WriteLine((table[0,0])[0] + ". " + table[0,1] + ", " + table[0,2] + " г.");

	}
}
}