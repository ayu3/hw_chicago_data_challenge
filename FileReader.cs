using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace hw2_chicago_data_challenge
{
	class FileReader
	{
		public static void Main (string[] args)
		{
			//structures for storing data
			var numb2names = new Dictionary<string, string> ();	//matching community areas to their assigned numbers
			var healthlist = new List<float>();	//keeping the average life expectancy by community area
			float[] grocerylist = new float[77];	//keeping the number of grocery stores in each community area
			//var grocerylist = new List<float>();	//keeping the number of grocery stores in each community area

			//reader for Public Health Statistics
			using (var hsr = new StreamReader (@"Public_Health_Statistics-_Life_Expectancy_By_Community_Area.csv")) {
				var healthreader = new CsvReader (hsr);
				healthreader.Configuration.RegisterClassMap<PublicHealthMap> ();
				Console.WriteLine("Public Health Statistics");
				while (healthreader.Read ()) {
					var healthrecord = healthreader.GetRecord<PublicHealthDataDef> ();
					numb2names[healthrecord.ComAreaNumber] = healthrecord.ComArea;
					float age = Single.Parse (healthrecord.LifeExp2010);
					healthlist.Add (age);
					//for code comprehension purposes
					//Console.WriteLine (healthrecord.ComAreaNumber + " " + healthrecord.ComArea + " " + healthrecord.LifeExp2010);
				}
				/*//for dictionary code comprehension purposes
				for (int i = 1; i < 11; i++) {
					string key = i.ToString();
					Console.WriteLine ("{0}", numb2names[key]);
				//for list code comprehension purposes
				for (int i = 0; i < healthlist.Count; i++) {
					Console.WriteLine (i + "- " + healthlist [i] + "\n");*/
			}

				//reader for Grocery Store Statistics
				using (var gsr = new StreamReader (@"Grocery_Stores_-_2011.csv")) {
					var groceryreader = new CsvReader (gsr);
					groceryreader.Configuration.RegisterClassMap<GroceryStoreMap> ();
					Console.WriteLine("\nGrocery Store Statistics");

					while (groceryreader.Read ()) {
						var groceryrecord = groceryreader.GetRecord<GroceryStoreDef> ();
						//convert area number to correspond with array position
						int garea = Int32.Parse (groceryrecord.ComAreaNum);
						int gpos = garea - 1;
						//increasing count of array
						grocerylist [gpos] = grocerylist [gpos] + 1;
						//for code comprehension purposes
						//Console.WriteLine (groceryrecord.ComAreaNum + " " +groceryrecord.ComArea);
					}
				}
				/*//for grocery array code comprehension purposes
				for (int i = 0; i < grocerylist.Length; i++) {
					Console.WriteLine (i + " - " + grocerylist [i]);*/
				}
			}
		}
	}
}