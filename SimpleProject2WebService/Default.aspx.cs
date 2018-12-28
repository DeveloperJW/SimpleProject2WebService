using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleProject2WebService
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // there should only be one Session created
            if (!IsPostBack)
            {
                List<Employee> employeeList = new List<Employee>();
                Session["TheList"] = employeeList;
            }
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            string firstName = TxtFirstName.Text;
            string lastName = TxtLastName.Text;
            string position = TxtPosition.Text;
            string manager = TxtManager.Text;
            string department = DdlDepartment.Text;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.Position = position;
            employee.Manager = manager;
            employee.Department = department;
            List<Employee> theList = (List<Employee>)Session["TheList"];
            theList.Add(employee);
            Session["TheList"] = theList;
        }

        protected void BtnDetails_Click(object sender, EventArgs e)
        {
            // When the go to details button is clicked, redirect to Details.aspx
            // Session["totalSumSession"] = totalSum;
            Response.Redirect("Details.aspx");
        }
    }
}