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
			//reader
			using (var sr = new StreamReader (@"Public_Health_Statistics-_Life_Expectancy_By_Community_Area.csv")) {
				var reader = new CsvReader (sr);
				reader.Configuration.RegisterClassMap<PublicHealthMap> ();
				while (reader.Read ()) {
					var record = reader.GetRecord<PublicHealthDataDef> ();
				}
			}
		}
	}
}