using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Console.WriteLine ("Hello World!");
			string [] row = new string[3];
			row [0] = "Ред 1";
			row [1] = "Ред 2";
			row [2] = "Ред 3";
			Console.WriteLine ("Масив row: " + row [0] + ", " + row [1] + ", " + row [2]);

			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
			Console.WriteLine ("Броят на цифрите в масива:\n" + "1,2,3,4,5,6,7,8,9\n\nе: " + parse.Length);

			string list1 = string.Join (";", parse);
			Console.WriteLine ("Новият стринг е:\n" + list1 + "\n\n");
		}
	}
}
