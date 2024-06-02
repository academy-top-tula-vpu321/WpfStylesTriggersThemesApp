using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStylesTriggersThemesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Style txtBoxStyle = new();
            txtBoxStyle.Setters.Add(
                new Setter()
                {
                    Property = Control.FontSizeProperty,
                    Value = 26.0
                });
            txtBoxStyle.Setters.Add(
                new Setter()
                {
                    Property = Control.BackgroundProperty,
                    Value = new SolidColorBrush(Colors.Aqua)
                });

            txtBox.Style = txtBoxStyle;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                if (btn.Content.ToString() == "Button 1")
                    MessageBox.Show("Hello world");

                if (btn.Content.ToString() == "Button 2")
                    MessageBox.Show("Good By world");
            }
        }
    }
}