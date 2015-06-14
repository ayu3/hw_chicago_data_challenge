using System;
using System.IO;
using CsvHelper;

/*trying a tutorial from 
 * http://carlosferreira.com/reading-csv-files-using-csvhelper-package-c-ienumerable/
 * on how to use CvsHelper
*/

namespace hw2_chicago_data_challenge
{
	public class PublicHealthData
	{
		public String ComAreaNumber { get; set; }
		public String ComArea { get; set; }
		public String LifeExp1990 { get; set; }
		public String Lower1990 { get; set; }
		public String Upper1990 { get; set; }
		public String LifeExp2000 { get; set; }
		public String Lower2000 { get; set; }
		public String Upper2000 { get; set; }
		public String LifeExp2010 { get; set; }
		public String Lower2010 { get; set; }
		public String Upper2010 { get; set; }
	}
}