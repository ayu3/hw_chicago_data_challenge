using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;

namespace hw2_chicago_data_challenge
{
	public sealed class GroceryStoreMap : CsvClassMap<GroceryStoreDef>
	{
		public GroceryStoreMap()
		{
			Map (m => m.StoreName).Name ("STORE NAME");
			Map (m => m.LicenseID).Name ("LICENSE ID");
			Map (m => m.AccountNum).Name ("ACCOUNT NUMBER");
			Map (m => m.SquareFeet).Name ("SQUARE FEET");
			Map (m => m.BufferSize).Name ("BUFFER SIZE");
			Map (m => m.Address).Name ("ADDRESS");
			Map (m => m.ZipCode).Name ("ZIP CODE");
			Map (m => m.ComArea).Name ("COMMUNITY AREA NAME");
			Map (m => m.ComAreaNum).Name ("COMMUNITY AREA");
			Map (m => m.Ward).Name ("WARD");
			Map (m => m.CensusTract).Name ("CENSUS TRACT");
			Map (m => m.CensusBlock).Name ("CENSUS BLOCK");
			Map (m => m.XCoord).Name ("X COORDINATE");
			Map (m => m.YCoord).Name ("Y COORDINATE");
			Map (m => m.Latitude).Name ("LATITUDE");
			Map (m => m.Longitude).Name ("LONGITUDE");
			Map (m => m.Location).Name ("LOCATION");
		}
	}

	public sealed class GroceryStoreDef
	{
		public String StoreName { get; set; }
		public String LicenseID { get; set; }
		public String AccountNum { get; set; }
		public String SquareFeet { get; set; }
		public String BufferSize { get; set; }
		public String Address { get; set; }
		public String ZipCode { get; set; }
		public String ComArea { get; set; }
		public String ComAreaNum { get; set; }
		public String Ward { get; set; }
		public String CensusTract { get; set; }
		public String CensusBlock { get; set; }
		public String XCoord { get; set; }
		public String YCoord { get; set; }
		public String Latitude { get; set; }
		public String Longitude { get; set; }
		public String Location { get; set; }
	}
}