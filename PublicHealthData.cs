using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;

namespace hw2_chicago_data_challenge
{
	public sealed class PublicHealthMap : CsvClassMap<PublicHealthDataDef>
	{
		public PublicHealthMap()
		{
			Map (m => m.ComAreaNumber).Name ("Community Area Number");
			Map (m => m.ComArea).Name ("Community Area");
			Map (m => m.LifeExp1990).Name ("1990 Life Expectancy");
			Map (m => m.Lower1990).Name ("1990 Lower 95% CI");
			Map (m => m.Upper1990).Name ("1990 Upper 95% CI");
			Map (m => m.LifeExp2000).Name ("2000 Life Expectancy");
			Map (m => m.Lower2000).Name ("2000 Lower 95% CI");
			Map (m => m.Upper2000).Name ("2000 Upper 95% CI");
			Map (m => m.LifeExp2010).Name ("2010 Life Expectancy");
			Map (m => m.Lower2010).Name ("2010 Lower 95% CI");
			Map (m => m.Upper2010).Name ("2010 Upper 95% CI");
		}
	}

	public sealed class PublicHealthDataDef
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