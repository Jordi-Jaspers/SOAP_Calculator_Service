using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            LocalCalculator.CalculatorSoap wsClient = new LocalCalculator.CalculatorSoapClient("CalculatorSoap1");
            int Xval = int.Parse(InputX.Text);
            int Yval = int.Parse(InputY.Text);
            int Zsol = wsClient.Addition(Xval, Yval);

            labelSolution.Text = "" + Zsol;
        }

        protected void btnSub_Click1(object sender, EventArgs e)
        {
            LocalCalculator.CalculatorSoap wsClient = new LocalCalculator.CalculatorSoapClient("CalculatorSoap1");
            int Xval = int.Parse(InputX.Text);
            int Yval = int.Parse(InputY.Text);
            int Zsol = wsClient.Subtraction(Xval, Yval);

            labelSolution.Text = "" + Zsol;
        }

        protected void btn_Mult_Click(object sender, EventArgs e)
        {
            LocalCalculator.CalculatorSoap wsClient = new LocalCalculator.CalculatorSoapClient("CalculatorSoap1");
            int Xval = int.Parse(InputX.Text);
            int Yval = int.Parse(InputY.Text);
            int Zsol = wsClient.Multiplication(Xval, Yval);

            labelSolution.Text = "" + Zsol;
        }

        protected void btn_Div_Click(object sender, EventArgs e)
        {
            LocalCalculator.CalculatorSoap wsClient = new LocalCalculator.CalculatorSoapClient("CalculatorSoap1");
            int Xval = int.Parse(InputX.Text);
            int Yval = int.Parse(InputY.Text);
            int Zsol = wsClient.Division(Xval, Yval);

            labelSolution.Text = "" + Zsol;
        }
    }
}