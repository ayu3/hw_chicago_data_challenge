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
			//reader for Public Health Statistics
			using (var hsr = new StreamReader (@"Public_Health_Statistics-_Life_Expectancy_By_Community_Area.csv")) {
				var healthreader = new CsvReader (hsr);
				healthreader.Configuration.RegisterClassMap<PublicHealthMap> ();
				Console.WriteLine("Public Health Statistics");
				while (healthreader.Read ()) {
					var healthrecord = healthreader.GetRecord<PublicHealthDataDef> ();
					//for code comprehension purposes
					Console.WriteLine (healthrecord.ComAreaNumber + " " + healthrecord.ComArea + " " + healthrecord.LifeExp2010);
				}
			}

			//reader for Grocery Store Statistics
			using (var gsr = new StreamReader (@"Grocery_Stores_-_2011.csv")) {
				var groceryreader = new CsvReader (gsr);
				groceryreader.Configuration.RegisterClassMap<GroceryStoreMap> ();
				Console.WriteLine("\nGrocery Store Statistics");
				while (groceryreader.Read ()) {
					var groceryrecord = groceryreader.GetRecord<GroceryStoreDef> ();
					//for code comprehension purposes
					Console.WriteLine (groceryrecord.ComAreaNum + " " +groceryrecord.ComArea);
				}
			}
		}
	}
}