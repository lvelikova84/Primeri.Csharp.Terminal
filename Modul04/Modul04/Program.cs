﻿using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			for ( int i = 0; i < 5 ; i++)
//			{
//				//Код на цикъла
//				Console.WriteLine ( i.ToString () );
//			}

//			for ( int i = 0; i < 5 ; i += 2)
//			{
//				//Код на цикъла
//				Console.WriteLine ( i.ToString () );
//			}

//			for ( int i = 5; i > 0 ; i--)
//			{
//				//Код на цикъла
//				Console.WriteLine ( i.ToString () );
//			}

			string[,] _table = {
				{ "Иван", 	"Георгиев", 	"19" },
				{ "Васил", 	"Иванов", 		"23" },
				{ "Милен", 	"Георгиев", 	"58" },
				{ "Цветан", "Бориславов", 	"14" },
				{ "Гергана", "Василева", 	"25" },
				{ "Ивана", "Христова",	 	"21" },
			};
			
			// Антетка на таблица
			Console.WriteLine ("Име".PadRight(12) + "Фамилия".PadRight(12) + "Години".PadRight(12));
			Console.WriteLine ( "===============================" );

			//Пример за цикъл for
			// Тяло на таблица
//			for (int i = 0; i < _table.Length / 3; i++) {
//				for (int j = 0; j < 3; j++) {
////				//Код на цикъла
//				Console.Write (_table [i, j].PadRight (12));
//				}
//				Console.WriteLine ();

				//Пример за цикъл while
//				int i = 0;
//			while (i < _table.Length / 3) 
//				{
//				Console.WriteLine (
//					_table[i,0].PadRight(12) + 
//					_table[i,1].PadRight(12) + 
//					_table[i,2].PadRight(12)
//				);
//				i++;
//					}
//		
			//Пример с цикъл do ... while
			int i = 0;
			do { 
					//Код
					Console.WriteLine (
									_table[i,0].PadRight(12) + 
									_table[i,1].PadRight(12) + 
									_table[i,2].PadRight(12)
								);
					i ++;
			}
			while(i < _table.Length/3 );
		}
	}
}
