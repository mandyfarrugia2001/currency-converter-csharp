using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Mauren_CurrencyConverter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        double result;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void btn_convert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                /* Text box values are string by default.
                 * Said value is converted to double. */
                result = double.Parse(txt_from.Text);

                //Converting from Euro to Euro
                if (cmb_from.SelectedIndex == 0 && cmb_to.SelectedIndex == 0)
                {
                    prefix_rate("€");   
                    txt_to.Text = $"€{result *= 1.00000}";
                    round_rate("€");
                }
                //Converting from Euro to AUD
                if (cmb_from.SelectedIndex == 0 && cmb_to.SelectedIndex == 1)
                {
                    prefix_rate("€");
                    txt_to.Text = $"${(result *= 1.62976)}";
                    round_rate("$");
                }
                //Converting from Euro to Sterling Pound
                if (cmb_from.SelectedIndex == 0 && cmb_to.SelectedIndex == 2)
                {
                    prefix_rate("€");
                    txt_to.Text = $"£{(result *= 0.888114)}";
                    round_rate("£");
                }
                //Converting from Euro to Indian Rupee
                if (cmb_from.SelectedIndex == 0 && cmb_to.SelectedIndex == 3)
                {
                    prefix_rate("€");
                    txt_to.Text = $"₹{result *= 77.7224}";
                    round_rate("₹");
                }
                //Converting from Euro to US Dollar
                if (cmb_from.SelectedIndex == 0 && cmb_to.SelectedIndex == 4)
                {
                    prefix_rate("€");
                    txt_to.Text = $"${(result *= 1.09513)}";
                    round_rate("$");
                }
                //Converting from Australian Dollar to Euro
                if (cmb_from.SelectedIndex == 1 && cmb_to.SelectedIndex == 0)
                {
                    prefix_rate("$");
                    txt_to.Text = $"€{result *= 0.613586}";
                    round_rate("€");
                }
                //Converting from Australian Dollar to Australian Dollar
                if (cmb_from.SelectedIndex == 1 && cmb_to.SelectedIndex == 1)
                {
                    prefix_rate("$");
                    txt_to.Text = $"${result *= 1.00000}";
                    round_rate("$");
                }
                //Converting from Australian Dollar to Sterling Pound
                if (cmb_from.SelectedIndex == 1 && cmb_to.SelectedIndex == 2)
                {
                    prefix_rate("$");
                    txt_to.Text = $"£{result *= 0.544377}";
                    round_rate("£");
                }
                //Converting from Australian Dollar to Indian Rupee
                if (cmb_from.SelectedIndex == 1 && cmb_to.SelectedIndex == 3)
                {
                    prefix_rate("$");
                    txt_to.Text = $"₹{result *= 47.7136}";
                    round_rate("₹");
                }
                //Converting from Australian Dollar to US Dollar
                if (cmb_from.SelectedIndex == 1 && cmb_to.SelectedIndex == 4)
                {
                    prefix_rate("$");
                    txt_to.Text = $"${result *= 0.671942}";
                    round_rate("$");
                }
                //Converting from Sterling Pound to Euro
                if (cmb_from.SelectedIndex == 2 && cmb_to.SelectedIndex == 0)
                {
                    prefix_rate("£");
                    txt_to.Text = $"€{result * 1.12598}";
                    round_rate("€");
                }
                //Converting from Sterling Pound to Australian Dollar
                if (cmb_from.SelectedIndex == 2 && cmb_to.SelectedIndex == 1)
                {
                    prefix_rate("£");
                    txt_to.Text = $"${result *= 1.83696}";
                    round_rate("$");
                }
                //Converting from Sterling Pound to Sterling Pound
                if (cmb_from.SelectedIndex == 2 && cmb_to.SelectedIndex == 2)
                {
                    prefix_rate("£");
                    txt_to.Text = $"£{result *= 1.00000}";
                    round_rate("£");
                }
                //Converting from Sterling Pound to Indian Rupee.
                if (cmb_from.SelectedIndex == 2 && cmb_to.SelectedIndex == 3)
                {
                    prefix_rate("£");
                    txt_to.Text = $"₹{result *= 87.6294}";
                    round_rate("₹");
                }
                //Converting from Sterling Pound to US Dollar
                if (cmb_from.SelectedIndex == 2 && cmb_to.SelectedIndex == 4)
                {
                    prefix_rate("£");
                    txt_to.Text = $"${result *= 1.23417}";
                    round_rate("$");
                }
                //Convert from Indian Rupee to Euro
                if (cmb_from.SelectedIndex == 3 && cmb_to.SelectedIndex == 0)
                {
                    prefix_rate("₹");
                    txt_to.Text = $"€{result *= 0.0128663}";
                    round_rate("€");
                }
                //Convert from Indian Rupee to Australian Dollar
                if (cmb_from.SelectedIndex == 3 && cmb_to.SelectedIndex == 1)
                {
                    prefix_rate("₹");
                    txt_to.Text = $"${result *= 0.0209584}";
                    round_rate("$");
                }
                //Convert from Indian Rupee to Sterling Pound
                if (cmb_from.SelectedIndex == 3 && cmb_to.SelectedIndex == 2)
                {
                    prefix_rate("₹");
                    txt_to.Text = $"£{result *= 0.0114117}";
                    round_rate("£");
                }
                //Convert from Indian Rupee to Indian Rupee
                if (cmb_from.SelectedIndex == 3 && cmb_to.SelectedIndex == 3)
                {
                    prefix_rate("₹");
                    txt_to.Text = $"₹{result *= 1.00000}";
                    round_rate("₹");
                }
                //Convert from Indian Rupee to US Dollar
                if (cmb_from.SelectedIndex == 3 && cmb_to.SelectedIndex == 4)
                {
                    prefix_rate("₹");
                    txt_to.Text = $"${result *= 0.0140854}";
                    round_rate("$");
                }
                //Converting from US Dollar to Euro
                if (cmb_from.SelectedIndex == 4 && cmb_to.SelectedIndex == 0)
                {
                    prefix_rate("$");
                    txt_to.Text = $"€{result *= 0.913134}";
                    round_rate("€");
                }
                //Converting from US Dollar to Australian Dollar
                if (cmb_from.SelectedIndex == 4 && cmb_to.SelectedIndex == 1)
                {
                    prefix_rate("$");
                    txt_to.Text = $"${result *= 1.448822}";
                    round_rate("$");
                }
                //Converting from US Dollar to Sterling Pound
                if (cmb_from.SelectedIndex == 4 && cmb_to.SelectedIndex == 2)
                {
                    prefix_rate("$");
                    txt_to.Text = $"£{result *= 0.810263}";
                    round_rate("£");
                }
                //Converting from US Dollar to Indian Rupee
                if (cmb_from.SelectedIndex == 4 && cmb_to.SelectedIndex == 3)
                {
                    prefix_rate("$");
                    txt_to.Text = $"₹{result *= 70.9953}";
                    round_rate("₹");
                }
                //Converting from US Dollar to US Dollar
                if (cmb_from.SelectedIndex == 4 && cmb_to.SelectedIndex == 4)
                {
                    prefix_rate("$");
                    txt_to.Text = $"${result *= 1.00000}";
                    round_rate("$");
                }
            }
            //Handling format mismatch exception.
            catch (FormatException ex)
            {
                //Display the message in a single line.
                await new Windows.UI.Popups.MessageDialog(ex.Message).ShowAsync();
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            //A static method to terminate the application.
            Windows.ApplicationModel.Core.CoreApplication.Exit();
        }

        //Specify the currency sign when calling this method.
        public void prefix_rate(string currency)
        {
            //Prefix value with the respective currency sign.
            txt_from.Text = $"{currency}{txt_from.Text}";
        }

        //Specify the currency sign when calling this method.
        public async void round_rate(string currency)
        {
            /* Program must be paused for five seconds. 
             * Do not confuse with Thread.Sleep()
             * where parameter is accepted in milliseconds. */
            await Task.Delay(TimeSpan.FromSeconds(5));

            //Create a new message dialog to ask for user's preferences.
            Windows.UI.Popups.MessageDialog round_opt = 
                new Windows.UI.Popups.MessageDialog
                ("Would you like to round the conversion to two decimal places?", "Mauren");
            round_opt.Commands.Clear();
            //Add the options.
            round_opt.Commands.Add(new Windows.UI.Popups.UICommand { Label = "Yes", Id = 1 });
            round_opt.Commands.Add(new Windows.UI.Popups.UICommand { Label = "No", Id = 0 });

            //Display the message dialog.
            var decision = await round_opt.ShowAsync();
            //If user clicks Yes, the exchange result is rounded to two decimal places.
            if ((int)decision.Id == 1)
            {
                txt_to.Text = $"{currency}{Math.Round(result, 2).ToString()}";
            }
            //If user selects No, nothing will happen. (no need to use else-if)
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            //Clear all data from text fields.
            txt_from.Text = String.Empty;
            txt_to.Text = String.Empty;
        }
    }
}
