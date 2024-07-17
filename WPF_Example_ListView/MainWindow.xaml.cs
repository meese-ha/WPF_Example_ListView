using System.Collections;
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

namespace WPF_Example_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("a");
            lvEntries.Items.Add("a1");
            lvEntries.Items.Add("a2");
            lvEntries.Items.Add("a3");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            //int index = lvEntries.SelectedIndex;
            //object item = lvEntries.SelectedItem;
            var items = lvEntries.SelectedItems;

            //var result = MessageBox.Show($"Are you sure delete : {(string)item} ?", "sure?", MessageBoxButton.YesNo);
            var result = MessageBox.Show($"Are you sure you want to delete {items.Count} items?", "sure?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var itemList = new ArrayList(items);
                foreach (var item in itemList)
                {
                    lvEntries.Items.Remove(item);
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}