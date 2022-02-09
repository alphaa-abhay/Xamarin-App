/*
–-----------------------------------------------------------------------------------------------------------------------------------------
Create a app that will display if a students is pass or not exam (50% or more is pass). If the student is Pass than your program should display grade:
85% or more E for excellent
75% or more but less than 85% O for Outstanding
65% or more but less than 75% G for good
Less than 65% S for satisfactory
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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }
        public void btnPer(object sender, EventArgs args)
        {
            int s1 = int.Parse(txtmaths.Text);
            int s2 = int.Parse(txteng.Text);
            int s3 = int.Parse(txtcs.Text);
            int s4 = int.Parse(txtchem.Text);
            int s5 = int.Parse(txtphy.Text);
            int result = (s1+s2+s3+s4+s5)/5;
            string pr = result.ToString() + "%";
            if (result >= 50 && result < 65)
            {
                lblResult.Text ="Result: Passed with "+pr;
                lblGrade.Text ="Grade: S Satisfactory";
            }
            else if(result >= 65 && result < 75)
            {
                lblResult.Text ="Result: Passed with "+pr;
                lblGrade.Text ="Grade: G Good";
            }
            else if (result >= 75 && result < 85)
            {
                lblResult.Text ="Result: Passed with "+pr;
                lblGrade.Text ="Grade: O Outstanding";
            }
            else if (result >= 85 && result <= 100)
            {
                lblResult.Text ="Result: Passed with "+pr;
                lblGrade.Text ="Grade: E Excellent";
            }
            else
            {
                lblResult.Text ="Result: Failed with "+pr;
                lblGrade.Text ="Grade: F Fail";
            }
        }
    }
}
