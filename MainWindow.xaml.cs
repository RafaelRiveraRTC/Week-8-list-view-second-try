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

namespace Week_8_list_view_second_try
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        List<ClassesDnd> characterNames = new List<ClassesDnd>() ;
        public MainWindow()
        {
            InitializeComponent();

            characterNames.Add(new ClassesDnd("Will"));
            characterNames.Add(new ClassesDnd("Rafael"));
            characterNames.Add(new ClassesDnd("Charles"));
            lvCharacters.ItemsSource = characterNames;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex =lvCharacters.SelectedIndex;

            if(lvCharacters.SelectedIndex != -1)
            {

                MessageBox.Show(lvCharacters.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Selected a row from the list view");
            }



        }
    }
}