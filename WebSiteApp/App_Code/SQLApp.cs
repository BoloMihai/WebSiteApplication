using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class SQLApp
{
    public SQLApp()
    {        
    }

    private string _customerName;
    private string _customerEmail;
    private int _customerId;

    public string CustomerName
    {
        get { return _customerName; }
        set { _customerName = value; }
    }

    public string CustomerEmail
    {
        get { return _customerEmail; }
        set { _customerEmail = value; }
    }
   
    public int CustomerID
    {
        get { return _customerId; }
        set { _customerId = value; }
    }

    string connectionStr = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;

    public string IsServerConnected()
    {
        using (SqlConnection connection = new SqlConnection(connectionStr))
        {
            try
            {
                connection.Open();
                return "CONNECTION TO SQL SERVER SUCCEDED";
            }
            catch (SqlException)
            {
                return "CONNECTION TO SQL SERVER FAILED";
            }
        }
    }

    public string Insert()
    {
        using (SqlConnection connection = new SqlConnection(connectionStr))
        {
            using (SqlCommand sqlCmd = new SqlCommand("spInsertUpdateCustomer", connection))
            {
                if (CustomerName != "" && CustomerEmail != "")
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@inputName", CustomerName);
                    sqlCmd.Parameters.AddWithValue("@inputEmail", CustomerEmail);

                    connection.Open();
                    using (SqlDataReader sqlReader = sqlCmd.ExecuteReader())
                    {
                        if (sqlReader.Read())
                        {
                            CustomerID = (int)sqlReader.GetValue(0);
                        }

                        sqlReader.Close();
                    }
                    int query = sqlCmd.ExecuteNonQuery();
                    connection.Close();

                    if (query > 0)
                        return "QUERY EXECUTED SUCCESSFULLY";
                    else
                        return "QUERY FAILED TO EXECUTE";
                }
                else
                    return "PLEASE PROVIDE CUSTOMER NAME AND EMAIL";
            }            
        }
    }

    public string Delete(string CustomerName, string CustomerEmail)
    {
        using (SqlConnection connection = new SqlConnection(connectionStr))
        {
            using (SqlCommand sqlCmd = new SqlCommand("spDeleteCustomer", connection))
            {
                if (CustomerName != "" && CustomerEmail != "")
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@inputName", CustomerName);
                    sqlCmd.Parameters.AddWithValue("@inputEmail", CustomerEmail);

                    connection.Open();
                    int query = sqlCmd.ExecuteNonQuery();
                    connection.Close();

                    if (query > 0)
                        return "QUERY EXECUTED SUCCESSFULLY";
                    else
                        return "QUERY FAILED TO EXECUTE";
                }
                else
                    return "PLEASE PROVIDE CUSTOMER NAME AND EMAIL";
            }               
        }
    }    
}