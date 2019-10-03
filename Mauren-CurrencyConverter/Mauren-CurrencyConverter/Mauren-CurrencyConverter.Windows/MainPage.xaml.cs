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
                    txt_to.Text = $"€{result *= 1.00000}";
                }
                //Converting from Euro to AUD
                if (cmb_from.SelectedIndex == 0 && cmb_to.SelectedIndex == 1)
                {
                    txt_to.Text = $"${(result *= 1.62976)}";
                }
                //Converting from Euro to Sterling Pound
                if (cmb_from.SelectedIndex == 0 && cmb_to.SelectedIndex == 2)
                {
                    txt_to.Text = $"£{(result *= 0.888114)}";
                }
                //Converting from Euro to Indian Rupee
                if (cmb_from.SelectedIndex == 0 && cmb_to.SelectedIndex == 3)
                {
                    txt_to.Text = $"₹{result *= 77.7224}";
                }
                //Converting from Euro to US Dollar
                if (cmb_from.SelectedIndex == 0 && cmb_to.SelectedIndex == 4)
                {
                    txt_to.Text = $"${(result *= 1.09513)}";
                }
                //Converting from Australian Dollar to Euro
                if (cmb_from.SelectedIndex == 1 && cmb_to.SelectedIndex == 0)
                {
                    txt_to.Text = $"€{result *= 0.613586}";
                }
                //Converting from Australian Dollar to Australian Dollar
                if (cmb_from.SelectedIndex == 1 && cmb_to.SelectedIndex == 1)
                {
                    txt_to.Text = $"${result *= 1.00000}";
                }
                //Converting from Australian Dollar to Sterling Pound
                if (cmb_from.SelectedIndex == 1 && cmb_to.SelectedIndex == 2)
                {
                    txt_to.Text = $"£{result *= 0.544377}";
                }
                //Converting from Australian Dollar to Indian Rupee
                if (cmb_from.SelectedIndex == 1 && cmb_to.SelectedIndex == 3)
                {
                    txt_to.Text = $"₹{result *= 47.7136}";
                }
                //Converting from Australian Dollar to US Dollar
                if (cmb_from.SelectedIndex == 1 && cmb_to.SelectedIndex == 4)
                {
                    txt_to.Text = $"${result *= 0.671942}";
                }
                //Converting from Sterling Pound to Euro
                if (cmb_from.SelectedIndex == 2 && cmb_to.SelectedIndex == 0)
                {
                    txt_to.Text = $"€{result * 1.12598}";
                }
                //Converting from Sterling Pound to Australian Dollar
                if (cmb_from.SelectedIndex == 2 && cmb_to.SelectedIndex == 1)
                {
                    txt_to.Text = $"${result *= 1.83696}";
                }
                //Converting from Sterling Pound to Sterling Pound
                if (cmb_from.SelectedIndex == 2 && cmb_to.SelectedIndex == 2)
                {
                    txt_to.Text = $"${result *= 1.00000}";
                }
                //Converting from Sterling Pound to Indian Rupee.
                if (cmb_from.SelectedIndex == 2 && cmb_to.SelectedIndex == 3)
                {
                    txt_to.Text = $"₹{result *= 87.6294}";
                }
                //Converting from Sterling Pound to US Dollar
                if (cmb_from.SelectedIndex == 2 && cmb_to.SelectedIndex == 4)
                {
                    txt_to.Text = $"${result *= 1.23417}";
                }
                //Convert from Indian Rupee to Euro
                if (cmb_from.SelectedIndex == 3 && cmb_to.SelectedIndex == 0)
                {
                    txt_to.Text = $"€{result *= 0.0128663}";
                }
                //Convert from Indian Rupee to Australian Dollar
                if (cmb_from.SelectedIndex == 3 && cmb_to.SelectedIndex == 1)
                {
                    txt_to.Text = $"${result *= 0.0209584}";
                }
                //Convert from Indian Rupee to Sterling Pound
                if (cmb_from.SelectedIndex == 3 && cmb_to.SelectedIndex == 2)
                {
                    txt_to.Text = $"£{result *= 0.0114117}";
                }
                //Convert from Indian Rupee to Indian Rupee
                if (cmb_from.SelectedIndex == 3 && cmb_to.SelectedIndex == 3)
                {
                    txt_to.Text = $"₹{result *= 1.00000}";
                }
                //Convert from Indian Rupee to US Dollar
                if (cmb_from.SelectedIndex == 3 && cmb_to.SelectedIndex == 4)
                {
                    txt_to.Text = $"${result *= 0.0140854}";
                }
                //Converting from US Dollar to Euro
                if (cmb_from.SelectedIndex == 4 && cmb_to.SelectedIndex == 0)
                {
                    txt_to.Text = $"€{result *= 0.913134}";
                }
                //Converting from US Dollar to Australian Dollar
                if (cmb_from.SelectedIndex == 4 && cmb_to.SelectedIndex == 1)
                {
                    txt_to.Text = $"${result *= 1.448822}";
                }
                //Converting from US Dollar to Sterling Pound
                if (cmb_from.SelectedIndex == 4 && cmb_to.SelectedIndex == 2)
                {
                    txt_to.Text = $"£{result *= 0.810263}";
                }
                //Converting from US Dollar to Indian Rupee
                if (cmb_from.SelectedIndex == 4 && cmb_to.SelectedIndex == 3)
                {
                    txt_to.Text = $"₹{result *= 70.9953}";
                }
                if (cmb_from.SelectedIndex == 4 && cmb_to.SelectedIndex == 4)
                {
                    txt_to.Text = $"${result *= 1.00000}";
                }

                await Task.Delay(TimeSpan.FromSeconds(5));
                Windows.UI.Popups.MessageDialog round_opt = new Windows.UI.Popups.MessageDialog
                    ("Would you like to round the conversion to two decimal places?", "Mauren");
                round_opt.Commands.Clear();
                round_opt.Commands.Add(new Windows.UI.Popups.UICommand { Label = "Yes", Id = 1 });
                round_opt.Commands.Add(new Windows.UI.Popups.UICommand { Label = "No", Id = 0 });

                var decision = await round_opt.ShowAsync();
                if ((int)decision.Id == 1)
                {
                    txt_to.Text = Math.Round(result, 2).ToString();
                }
            }
            catch (FormatException ex)
            {
                //Display the message in a single line.
                await new Windows.UI.Popups.MessageDialog(ex.Message).ShowAsync();
            }
        }
    }
}
