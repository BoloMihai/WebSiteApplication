using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class WebServiceApp : System.Web.Services.WebService
{

    public WebServiceApp()
    {
    }

    SQLApp sqlApp;

    private void Common(string customerName, string customerEmail)
    {
        

        sqlApp = new SQLApp
        {
            CustomerName = customerName,
            CustomerEmail = customerEmail
        };        
    }

    [WebMethod]
    public string InsertUpdateCustomer(string customerName, string customerEmail)
    {        
        Common(customerName, customerEmail);

        if (sqlApp.IsServerConnected() == "CONNECTION TO SQL SERVER FAILED")
            return "You are not connected to SQL Server. Please check the connection string credentials.";
        else
        {
            string queryStatus = sqlApp.Insert();

            if (queryStatus == "QUERY EXECUTED SUCCESSFULLY")
                return "Customer (" + sqlApp.CustomerName + ") with e-mail (" + sqlApp.CustomerEmail + ") was fully populated at id (" + sqlApp.CustomerID + ").";
            else
                return "Customer was not populated. Please provide customer Name and Email";
        }
    }

    [WebMethod]
    public string DeleteCustomer(string customerName, string customerEmail)
    {
        Common(customerName, customerEmail);

        if (sqlApp.IsServerConnected() == "CONNECTION TO SQL SERVER FAILED")
            return "You are not connected to SQL Server. Please check the connection string credentials.";
        else
        {
            string queryStatus = sqlApp.Delete(customerName, customerEmail);

            if (queryStatus == "QUERY EXECUTED SUCCESSFULLY")
                return "Customer (" + sqlApp.CustomerName + ") with e-mail (" + sqlApp.CustomerEmail + ") was deleted.";
            else
                return "Customer was not deleted. Please choose te delete existing Customer by Name and Email.";
        }

    }
}
