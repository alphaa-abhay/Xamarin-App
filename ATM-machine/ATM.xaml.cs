/*
–-----------------------------------------------------------------------------------------------------------------------------------------
Q2. Suppose there is an ATM machine and you want to withdrawal some amount. Currency is available in ATM:2000 Rs. 500 Rs and 100 Rs. 
Find out total no. of currency according to withdrawal amount. Make sure withdrawal amount should be multiple of 100.
For eg:
Input: Enter withdrawal amount
2500
output: Total 2000 note: 1
Total 500 note: 1
Total 100 note: 0
–----------------------------------------------------------------------------------------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Android_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }
        public void btnWithdrawal(object sender, EventArgs args)
        {
            double amt = double.Parse(txtAmount.Text),twoamt, fiveamt, hundamt,r1,r2,r3;
            if ((amt%100) == 0)
            {
                r1 = amt % 2000;
                twoamt = (amt-r1)/2000;
                lblTwo.Text = "Notes of 2000: "+twoamt.ToString();
                r2 = r1 % 500;
                fiveamt = (r1-r2)/500;
                lblFive.Text = "Notes of 500: "+fiveamt.ToString();
                r3 = r2 % 100;
                hundamt = (r2-r3)/100;
                lblSau.Text = "Notes of 100: "+hundamt.ToString();
            }
            else {
                lblTwo.Text = "Couldn't Proceed Your Request";
                lblFive.Text = "Error! while proceeding your request";
                lblSau.Text = "Please try Another Amount.";
            }
        }
    }
}
