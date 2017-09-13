using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AirNautis
{
    /// <summary>
    /// Interaction logic for New_Hangar.xaml
    /// </summary>
    public partial class New_Hangar : Window
    {
        public New_Hangar()
        {
            InitializeComponent();
        }

        private ServiceAirNautis.AirNautisServiceClient airNautisService = null;


        private void btnCreateHangar_Click(object sender, RoutedEventArgs e)
        {
            airNautisService = new ServiceAirNautis.AirNautisServiceClient();
            ServiceAirNautis.Hangar hangar = new ServiceAirNautis.Hangar();

            if (!String.IsNullOrEmpty(txtBoxHangarCapacity.Text))
            {
                int capacity_value;

                if (int.TryParse(txtBoxHangarCapacity.Text, out capacity_value))
                {

                    if (capacity_value > 0)
                    {
                        hangar.Capacity = capacity_value;
                        if (airNautisService.CreateHangar(hangar))
                        {
                            MessageBox.Show(string.Format("Hangar successfully created with {0} capacity!", capacity_value), "Success", MessageBoxButton.OK);
                            DialogResult = true;
                        }
                        else
                        {
                            MessageBox.Show("Sorry, please verify fields", "Error", MessageBoxButton.OK);
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("The capacity value needs to be greater than zero", "Alert", MessageBoxButton.OK);
                        txtBoxHangarCapacity.Text = "";
                        txtBoxHangarCapacity.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Value of the field Capacity needs to be a number","Error", MessageBoxButton.OK);
                }
            }
   
        }
    }
}
