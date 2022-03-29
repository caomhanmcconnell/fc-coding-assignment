using System;

public class productTable
{
	private void CreateProductTable()
	{
		DataTable productTable = new DataTable("Products");
		DataColumn dtColumn;
		DataRow newDataRow;

		//Create Product ID column
		dtColumn = new DataColumn();
		dtColumn.DataType = typeof(Int32);
		dtColumn.ColumnName = "id";
		dtColumn.Caption = "Product ID";
		dtColumn.ReadOnly = false;
		dtColumn.Unique = true;
		//Add column to product table
		productTable.Columns.Add(dtColumn);

		//Create Product column
		dtColumn = new DataColumn();
		dtColumn.DataType = typeof(String);
		dtColumn.ColumnName = "product";
		dtColumn.Caption = "Product";
		dtColumn.ReadOnly = false;
		dtColumn.Unique = false;
		//Add column to product table
		productTable.Columns.Add(dtColumn);

		//Create January 2018 column
		dtColumn = new DataColumn();
		dtColumn.DataType = typeof(double);
		dtColumn.ColumnName = "jan 2018";
		dtColumn.Caption = "January 2018";
		dtColumn.ReadOnly = false;
		dtColumn.Unique = true;
		//Add column to product table
		productTable.Columns.Add(dtColumn);

		//Create Feburary 2018 column
		dtColumn = new DataColumn();
		dtColumn.DataType = typeof(double);
		dtColumn.ColumnName = "feb 2018";
		dtColumn.Caption = "Feburary 2018";
		dtColumn.ReadOnly = false;
		dtColumn.Unique = true;
		//Add column to product table
		productTable.Columns.Add(dtColumn);

		//Create March 2018 column
		dtColumn = new DataColumn();
		dtColumn.DataType = typeof(double);
		dtColumn.ColumnName = "mar 2018";
		dtColumn.Caption = "March 2018";
		dtColumn.ReadOnly = false;
		dtColumn.Unique = true;
		//Add column to product table
		productTable.Columns.Add(dtColumn);

		//ensuring product id is primary key
		DataColumn[] PrimaryKeyColumns = new DataColumn[1];
		PrimaryKeyColumns[0] = productTable.Columns["id"];
		productTable.PrimaryKey = PrimaryKeyColumns;


		//Creating new DataSet
		dtSet = new DataSet();

		//Add product table to DataSet
		dtSet.Tables.Add(productTable);

		//Populating product table with data
		//
		//need to read in file of products then append to table
		//with each product using data from file...


	}
}
