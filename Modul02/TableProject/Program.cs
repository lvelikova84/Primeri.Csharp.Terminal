using System;

namespace TableProject
{
	class MainClass
	{
		enum ti {ime=0, familia, godini}
		public static void Main (string[] args)
		{
//			Console.WriteLine ("Hello World!");
//			string [] row = new string[3];
//			row [0] = "Ред 1";
//			row [1] = "Ред 2";
//			row [2] = "Ред 3";
//			Console.WriteLine ("Масив row: " + row [0] + ", " + row [1] + ", " + row [2]);
//
//			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
//			Console.WriteLine ("Броят на цифрите в масива:\n" + "1,2,3,4,5,6,7,8,9\n\nе: " + parse.Length);
//
//			string list1 = string.Join (";", parse);
//			Console.WriteLine ("Новият стринг е:\n" + list1 + "\n\n");

			//Дефиниране на таблица
			string[,] table = new string[2, 3];

			// Въвеждане на първи ред
			table[0, (int) ti.ime] = "Мартин"; table[0, (int) ti.familia] = "Симеонов"; table[0, (int) ti.godini] = "31";

			// Въвеждане на втори ред
			table[1, (int) ti.ime] = "Симеон"; table[1, (int) ti.familia] = "Мартинов"; table[1, (int) ti.godini] = "41";
			//Печат
			//Console.WriteLine((table[0,0])[0] + ". " + table[0,1] + ", " + table[0,2] + " г.");
			Console.Write("Кой ред искате да видите: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;
			Console.WriteLine(
				(table[_index, (int) ti.ime])[0] + ". " + 
				 table[_index, (int) ti.familia] + ", " + 
				table[_index, (int) ti.godini] + " г.");
		}
	}
}
