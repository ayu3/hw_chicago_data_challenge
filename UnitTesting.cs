using System;
using NUnit;

namespace hw2_chicago_data_challenge
{
	class UnitTesting
	{
		public class CorrelationTest
		{
			//test that the function CorrelationCoefficient properly catches 
			public void SameLength (){
				float[] array1 = { 1, 2, 3, 4, 5, 6 };
				float[] array2 = { 1, 2, 3 };
				Reader_and_Correlation.CorrelationCoefficient (array1, array2);
			}
		}
	}
}
		