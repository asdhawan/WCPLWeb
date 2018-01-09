using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WCPLWebUI.Classes {
    public static class ExternalSiteScraper {
        public static string ScrapeSite(string url) {
            String strResult;
            WebResponse objResponse;
            WebRequest objRequest = HttpWebRequest.Create(url);
            objResponse = objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream())) {
                strResult = sr.ReadToEnd();
                sr.Close();
            }

            // strResult = strResult.Remove(0, strResult.LastIndexOf("<table>"));
            string[] values = strResult.Split(new string[] { "<tbody>", "</tbody>" }, StringSplitOptions.RemoveEmptyEntries);

            // Response.Write("<table>" + values[1] + "</table>");
            //ConvertHTMLTablesToDataSet("<table>" + values[1] + "</table>");
            //  List<string> list = new List<string>(values);

            return strResult;
        }

        //private DataSet ConvertHTMLTablesToDataSet(string HTML) {
        //    // Declarations 
        //    DataSet ds = new DataSet();
        //    DataTable dt = null;
        //    DataRow dr = null;
        //    DataColumn dc = null;
        //    string TableExpression = "<table[^>]*>(.*?)</string></string></table>";
        //    string HeaderExpression = "<th[^>]*>(.*?)";
        //    string RowExpression = "<tr[^>]*>(.*?)";
        //    string ColumnExpression = "<td[^>]*>(.*?)";
        //    bool HeadersExist = false;
        //    int iCurrentColumn = 0;
        //    int iCurrentRow = 0;

        //    // Get a match for all the tables in the HTML 
        //    MatchCollection Tables = Regex.Matches(HTML, TableExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

        //    // Loop through each table element 
        //    foreach (Match Table in Tables) {
        //        // Reset the current row counter and the header flag 
        //        iCurrentRow = 0;
        //        HeadersExist = false;

        //        // Add a new table to the DataSet 
        //        dt = new DataTable();

        //        //Create the relevant amount of columns for this table (use the headers if they exist, otherwise use default names) 
        //        if (Table.Value.Contains("<th"))>
        //        {
        //            // Set the HeadersExist flag 
        //            HeadersExist = true;

        //            // Get a match for all the rows in the table 
        //            MatchCollection Headers = Regex.Matches(Table.Value, HeaderExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

        //            // Loop through each header element 
        //            foreach (Match Header in Headers) {
        //                dt.Columns.Add(Header.Groups[1].ToString());
        //            }
        //        }
        //    else
        //    {
        //            for (int iColumns = 1; iColumns <= Regex.Matches(Regex.Matches(Regex.Matches(Table.Value, TableExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase)[0].ToString(), RowExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase)[0].ToString(), ColumnExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase).Count; iColumns++) {
        //                dt.Columns.Add("Column " + iColumns);
        //            }
        //        }


        //        //Get a match for all the rows in the table 

        //        MatchCollection Rows = Regex.Matches(Table.Value, RowExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

        //        // Loop through each row element 
        //        foreach (Match Row in Rows) {
        //            // Only loop through the row if it isn't a header row 
        //            if (!(iCurrentRow == 0 && HeadersExist)) {
        //                // Create a new row and reset the current column counter 
        //                dr = dt.NewRow();
        //                iCurrentColumn = 0;

        //                // Get a match for all the columns in the row 
        //                MatchCollection Columns = Regex.Matches(Row.Value, ColumnExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

        //                // Loop through each column element 
        //                foreach (Match Column in Columns) {
        //                    // Add the value to the DataRow 
        //                    dr[iCurrentColumn] = Column.Groups[1].ToString();

        //                    // Increase the current column  
        //                    iCurrentColumn++;
        //                }

        //                // Add the DataRow to the DataTable 
        //                dt.Rows.Add(dr);

        //            }

        //            // Increase the current row counter 
        //            iCurrentRow++;
        //        }


        //        // Add the DataTable to the DataSet 
        //        ds.Tables.Add(dt);

        //    }
        //    GridView1.DataSource = ds;
        //    GridView1.DataBind();
        //    return ds;

        //}
    }
}