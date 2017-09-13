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
    /// Interaction logic for Edit_Airplane.xaml
    /// </summary>
    public partial class Edit_Airplane : Window
    {
        private ServiceAirNautis.Airplane airplane;
        private ServiceAirNautis.AirNautisServiceClient airNautisService = new ServiceAirNautis.AirNautisServiceClient();
        
        
        public Edit_Airplane(ServiceAirNautis.Airplane new_airplane)
        {
            InitializeComponent();
            this.airplane = new_airplane;
            Fill_Information(this.airplane);
        }

        public void Fill_Information(ServiceAirNautis.Airplane airplane_received)
        {
            txtBoxModel.Text = airplane_received.Model;
            txtBoxCapacity.Text = airplane_received.Capacity.ToString();
            txtBoxYear.Text = airplane_received.Year.ToString();
        }

        private void btnEditAirplane_Click(object sender, RoutedEventArgs e)
        {

            ServiceAirNautis.Airplane airplane = airNautisService.GetAirplaneById(this.airplane.Id);

            if (!String.IsNullOrEmpty(txtBoxModel.Text) || !String.IsNullOrEmpty(txtBoxYear.Text) || !String.IsNullOrEmpty(txtBoxCapacity.Text))
            {
                int year_value, capacity_value;

                if (int.TryParse(txtBoxYear.Text, out year_value))
                {
                    if (year_value <= 1970)
                    {
                        MessageBox.Show("Sorry, for reasons of safety we only accept modern airplanes", "Alert", MessageBoxButton.OK);
                        txtBoxYear.Focus();
                    }
                    if (year_value <= 2013)
                    {
                        if (int.TryParse(txtBoxCapacity.Text, out capacity_value))
                        {

                            if (capacity_value <= 0)
                            {
                                MessageBox.Show("The capacity value needs to be greater than zero", "Error", MessageBoxButton.OK);
                                txtBoxCapacity.Text = "";
                                txtBoxCapacity.Focus();
                            }
                            if (capacity_value > 0 && capacity_value <= 1000)
                            {
                                airplane.Model = txtBoxModel.Text.Trim();
                                airplane.Year = year_value;
                                airplane.Capacity = capacity_value;

                                if (airNautisService.EditAirplane(airplane))
                                {
                                    MessageBox.Show(string.Format("Airplane {0} successfully updated!", txtBoxModel.Text), "Success", MessageBoxButton.OK);
                                    DialogResult = true;
                                }
                                else
                                {
                                    MessageBox.Show("Sorry, please verify fields", "Error", MessageBoxButton.OK);
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Sorry, no airplane has that number of capacity", "Alert", MessageBoxButton.OK);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Value of the field Capacity needs to be a number", "Error", MessageBoxButton.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Year value", "Error", MessageBoxButton.OK);
                        txtBoxYear.Focus();
                    }
                    
                    

                }
                else
                {
                    MessageBox.Show("Value of the field Year needs to be a number","Error",MessageBoxButton.OK);
                }
            }
        }
    }
}
