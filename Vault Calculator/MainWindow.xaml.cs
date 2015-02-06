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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vault_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Vault v;

        public MainWindow()
        {
            InitializeComponent();
            v = new Vault();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int o = 0;
            int h = 0;
            int.TryParse(Layer.Text, out o);
            v.layer = o;

            v.x = Convert.ToInt32(Head.Text);
            v.y = Convert.ToInt32(Tail.Text);
            v.checkDouble = check.IsChecked.Value;

            Cost.Text = Convert.ToString(v.Cost());
            int.TryParse(Speed.Text, out o);
            int.TryParse(Speed_Copy.Text, out h);
            X_Time.Text = Convert.ToString(v.X_time(o, h, two.IsChecked.Value));
            Y_Time.Text = Convert.ToString(v.Y_time(o, h, two.IsChecked.Value));
            X.Text = Convert.ToString(v.X_layer());
            Y.Text = Convert.ToString(v.Y_layer());
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_6(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_7(object sender, TextChangedEventArgs e)
        {

        }
    }
}
