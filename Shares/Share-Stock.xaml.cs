/*
–-----------------------------------------------------------------------------------------------------------------------------------------
Q3. Swati bought 600 shares of stock at a price of $21.77 per share. She must pay her stock broker a 2% commission for the transaction. Write a program that calculates the display the following:
-The amount paid for the stock alone (without the commission)
-The amount of the commission
-The total amount paid
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
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
        }
		  public void btnPay(object sender, EventArgs args)
		  {
			  int numShares = int.Parse(txtstock.Text);
			  double sharePrice = 21.77,
			   commissionPerTran = .02,
			   stockBasePrice,
			   commissionAddOn,
			   totalStockPrice,
			   sellStockAt;
			  stockBasePrice = numShares* sharePrice;
			  commissionAddOn = stockBasePrice* commissionPerTran;
			  totalStockPrice = stockBasePrice + commissionAddOn;
			  lblShares.Text = "The amount paid for the stock alone is $"+stockBasePrice.ToString();
			  lblComm.Text = "The amount of commission for the transaction is $"+commissionAddOn.ToString();
			  lblTamt.Text = "The total amount paid for the stock with commission is $"+totalStockPrice.ToString();
		  }
    }
}
