using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;

namespace hw2_chicago_data_challenge
{
	class FileReader
	{
		public static void Main ()
		{
			//structures for storing data
			var healthlist = new List<float>();	//keeping the average life expectancy by community area
			float[] groceryarray = new float[77];	//keeping the number of grocery stores in each community area

			//reader for Public Health Statistics
			using (var hsr = new StreamReader (@"Public_Health_Statistics-_Life_Expectancy_By_Community_Area.csv")) {
				var healthreader = new CsvReader (hsr);
				healthreader.Configuration.RegisterClassMap<PublicHealthMap> ();
				while (healthreader.Read ()) {
					var healthrecord = healthreader.GetRecord<PublicHealthDataDef> ();
					float age = Single.Parse (healthrecord.LifeExp2010);
					healthlist.Add (age);
				}

				healthlist.RemoveAt (healthlist.Count - 1);	//last item of list is not needed bc it is an average life expectancy of the entire city of Chicago
				//conversion of list to array for consistancy
				float[] healtharray = healthlist.ToArray();


				//reader for Grocery Store Statistics
				using (var gsr = new StreamReader (@"Grocery_Stores_-_2011.csv")) {
					var groceryreader = new CsvReader (gsr);
					groceryreader.Configuration.RegisterClassMap<GroceryStoreMap> ();

					while (groceryreader.Read ()) {
						var groceryrecord = groceryreader.GetRecord<GroceryStoreDef> ();
						//convert area number to correspond with array position
						int garea = Int32.Parse (groceryrecord.ComAreaNum);
						int gpos = garea - 1;
						//increasing count of array
						groceryarray [gpos] = groceryarray [gpos] + 1;
					}
				}

				Console.WriteLine ("Test: " + CorrelationCoefficient (array1, array2));
				Console.WriteLine ("Life Expectancy and Grocery Store Correlation Coefficient: " + CorrelationCoefficient (healtharray, groceryarray));
			}
		}

		//code taken from http://stackoverflow.com/questions/17447817/correlation-of-two-arrays-in-c-sharp
		static double CorrelationCoefficient(float[] array1, float[] array2){
			if (array1.Length != array2.Length) {
				Console.WriteLine ("Values must be the same length");
			}
			var avg1 = array1.Average ();
			var avg2 = array2.Average ();

			var sum1 = array1.Zip (array2, (x1, y1) => (x1 - avg1) * (y1 - avg2)).Sum ();

			var sqr1 = array1.Sum (x => Math.Pow ((x - avg1), 2.0));
			var sqr2 = array2.Sum (y => Math.Pow ((y - avg2), 2.0));

			var result = sum1 / Math.Sqrt (sqr1 * sqr2);

			return result;
		}
	}
}