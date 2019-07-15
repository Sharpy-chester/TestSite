using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tesstsite1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            float age;
            string test = txtAge.Text;
            float killMe;

            if (float.TryParse(txtAge.Text, out (age)))
            {

                if (age > 0)
                {
                    if (age > 17)
                    {
                        lblFinal.Text = "Hello, you are over the minimum age, please enter your name to continue";
                        if (txtName.Text.Length > 0)
                        {
                            lblAgeConfirm.Text = "";
                            lblFinal.Text = "Hello " + txtName.Text + " who is " + test + " years old";
                        }
                        else
                        {
                            lblFinal.Text = "Hello, you are over the minimum age, please enter your name to continue";
                        }

                    }
                    else
                    {

                        if (age > 0)
                        {
                            float testname = 18 - age;
                            if (testname > 1)
                            {
                                lblAgeConfirm.Text = "";
                                lblFinal.Text = "Sorry " + txtName.Text + " you are " + testname + " years too young";
                            }
                            else
                            {
                                lblAgeConfirm.Text = "";
                                lblFinal.Text = "Sorry " + txtName.Text + " you are " + testname + " year too young";
                            }
                        }
                        else
                        {
                            lblFinal.Text = "Please enter a valid age";
                        }
                        

                    }

                }
                else
                {
                    lblAgeConfirm.Text = "";
                    lblFinal.Text = "Please enter your age";
                }

            }
            else
            {
                lblAgeConfirm.Text = "";
                lblFinal.Text = "Please enter your age";
            }

            if (float.TryParse(txtName.Text, out (killMe)))
            {
                lblFinal.Text = "Sorry, please enter a valid name";
            }
            else
            {
                if (name.Length > 0)
                {
                    if (txtAge.Text.Length > 0)
                    {
                        if (age > 17)
                        {
                            lblConfirm.Text = "";
                            lblFinal.Text = "Hi " + txtName.Text + " aged " + txtAge.Text + ", I have saved your data";
                        }
                        else
                        {
                            if (float.TryParse(txtAge.Text, out (age)))
                            {
                                float testname = 18 - age;
                                if (testname > 1)
                                {
                                    lblAgeConfirm.Text = "";
                                    lblFinal.Text = "Sorry " + txtName.Text + " you are " + testname + " years too young";
                                }
                                else
                                {
                                    lblAgeConfirm.Text = "";
                                    lblFinal.Text = "Sorry " + txtName.Text + " you are " + testname + " year too young";
                                }
                            }
                            else
                            {
                                lblFinal.Text = "Sorry, please enter a valid age";
                            }
                                
                        }

                    }
                }

                else
                {
                    lblConfirm.Text = "";
                    lblFinal.Text = "Hello " + txtName.Text + ", please enter your age";
                }

            }
            //else
            //{
            //    lblConfirm.Text = "";
            //    lblFinal.Text = "Please enter your name";
            //}
        }
        protected void btnAge_Click(object sender, EventArgs e)
        {



        }
    }
}