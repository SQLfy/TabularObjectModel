using System;
using Microsoft.AnalysisServices.AdomdClient;
 
namespace QueryTool
{
    class Program
    {
        static void Main(string[] args)
        {
            /*******************************************************
                Define Connection
            *******************************************************/
 
            AdomdConnection adomdConnection = new AdomdConnection("Data Source=localhost:59473");
            
            /*******************************************************
                Define Query (as a Command)
                - the AdomdCommant uses the above connection
                - subsitute this for your own query
            *******************************************************/
 
            String query = @"
            EVALUATE
                SUMMARIZECOLUMNS(
                    //GROUP BY 
                    Customer[Country-Region] ,
                     
                    //FILTER BY
                    TREATAS( {""Red"",""Blue""} , 'Product'[Color] ) ,
                     
                    // MEASURES
                    ""Sum of Sales Amount"" , SUM(Sales[Sales Amount]) ,
                    ""Sum of Order Quantity"" , SUM(Sales[Order Quantity])
                )
            ";
            AdomdCommand adomdCommand = new AdomdCommand(query,adomdConnection);
 
            /*******************************************************
                Run the Query
                - Open the connection
                - Issue the query
                - Iterate through each row of the reader
                - Iterate through each column of the current row
                - Close the connection
            *******************************************************/
 
            adomdConnection.Open();
             
            AdomdDataReader reader = adomdCommand.ExecuteReader();
 
            // Create a loop for every row in the resultset
            while(reader.Read())
            {
                String rowResults = "";
                // Create a loop for every column in the current row
                for (
                    int columnNumber = 0;
                    columnNumber<reader.FieldCount;
                    columnNumber++
                    )
                {
                rowResults += $"\t{reader.GetValue(columnNumber)}";
                }
                Console.WriteLine(rowResults);
            }
            adomdConnection.Close();
        }
    }
}
