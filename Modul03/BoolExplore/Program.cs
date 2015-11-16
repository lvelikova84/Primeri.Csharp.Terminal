using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			bool _b = true;
//			bool _test = 5 > 10;
//			Console.WriteLine (_test);

			int[] _i = new int[] { 4, 3, 2 };
			int _ui = 0;
			string _input = "0";
			Console.Write ("Моля въведете индекс: ");
			_input = Console.ReadLine();

			bool _check01 = int.TryParse(_input,out _ui);		 //проверяваме дали индекса е число
			bool _check02 =	_ui <= _i.Length;					//проверяваме горната граница
			bool _check03 = _ui > 0;							//проверяваме долната граница


			if (_check01 && _check02 && _check03)
			{
				Console.WriteLine (_i [_ui - 1]);
			}

			if (!_check01) {
				Console.WriteLine ("Индекса трябва да бъде цяло число\n\n\n");
			}

			if (!_check02)
			{
				Console.WriteLine ("Индекса е прекалено голям\n\n\n");
			}
			
				if (!_check03 && _check01)
			{
				Console.WriteLine ("Индекса е прекалено малък\n\n\n");
				}
		
		}
	}
}
