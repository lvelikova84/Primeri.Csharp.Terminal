using System;

namespace TaskModul2Video6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		//Console.WriteLine ("Hello World!");
		/*Задачи:Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World". 
		 * Декларирайте променлива от тип object и й присвоете стойността на конкатенацията на двете променливи от тип string
		 * (не изпускайте интервала по средата). 
		* Декларирайте трета променлива от тип string и я инициализирайте със стойността на променливата от тип object. 
		* ( Hint: Трябва да използвате type casting.)
		* Да се въведат от командния ред 1 число или цифра и 1 дума/стринг. 
		* След това да изведе дължината на получения стринг при конкатенация, 
		* тоест броя на символите в новополучения стринг при конкатенация. 
		* (Hint: Трябва да преобразувате int към String и след това да конкатениратe.)
		*/
			string first = "Hello" , second = "World";
			object one = first + " " + second;
				Console.WriteLine (one);

			//string third = one;

			int a = 0;
			string forth = "";
			Console.Write ("Моля въведете едно число: ");
			a = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Моля въведете една дума: ");
			forth =  (Console.ReadLine ());
			Console.Write ("Резултата от конкатенацията на числото и думата: ");
			Console.WriteLine ( a + forth);
				

		}
	}
}
