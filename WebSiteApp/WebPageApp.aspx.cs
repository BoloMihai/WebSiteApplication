using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebPageApp : System.Web.UI.Page
{
    SQLApp sqlApp;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBoxCustomerName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBoxCustomerEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnInsertUpdate_Click(object sender, EventArgs e)
    {
        string customerName = TextBoxCustomerName.Text;
        string customerEmail = TextBoxCustomerEmail.Text;
        WebServiceApp web = new WebServiceApp();
        var queryStatus = web.InsertUpdateCustomer(customerName, customerEmail);


        if (queryStatus == "Customer was not populated.")
            LabelQueryStatus.Text = "Customer was not populated.";
        else
            LabelQueryStatus.Text = queryStatus;
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string customerName = TextBoxCustomerName.Text;
        string customerEmail = TextBoxCustomerEmail.Text;
        WebServiceApp web = new WebServiceApp();
        var queryStatus = web.DeleteCustomer(customerName, customerEmail);

        if (queryStatus == "Customer was not deleted. Please choose to delete Customer by his existing unique Email.")
            LabelQueryStatus.Text = "Customer was not deleted. Please choose to delete Customer by his existing unique Email.";
        else
            LabelQueryStatus.Text = queryStatus;
    }
}