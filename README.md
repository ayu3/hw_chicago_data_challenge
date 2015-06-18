# hw_chicago_data_challenge

COMP 312 OPEN SOURCE COMPUTING

1. Summary of project

	I am using the "Public Health Statistics - Life Expectancy by Community Area" (https://data.cityofchicago.org/Health-Human-Services/Public-Health-Statistics-Life-Expectancy-By-Commun/qjr3-bm53)
	and "Grocery Stores-2011" (https://data.cityofchicago.org/Community-Economic-Development/Grocery-Stores-2011/4u6w-irs9) 
	datasets to see if there is a correlation between the ease of access to healthy foods and longer life expectancy. 
	Specifically looking at whether residents who live in communities where there is a larger amount of grocery stores tend to live 
	longer. 

2. Datasets

	Datasets used are named "Grocery_Stores_-_2011.csv" and "Public_Health_Statistics-_Life_Expectancy_By_Community_Area.csv".

3. Files

	3.1 GroceryStoreData.cs

		Contains a class that is required in order to successfully store the data read from "Grocery_Stores_-_2011.csv".

	3.2 Public Health Data.cs

		Contains a class that is required in order to successfully store the data read from  "Public_Health_Statistics-_Life_Expectancy_By_Community_Area.csv".

	3.3 Reader_and_Correlation.cs

		Contains the code to read the files, store their data and calculate their correlation using the correlation coefficient.