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

namespace DataGridComboboxColumn
{
    /// <summary> 
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<CalendarItem> items = new List<CalendarItem>()
            {
                new CalendarItem(3, "Work"),
                new CalendarItem(2, "travel"),
                new CalendarItem(1, "vacation"),
                new CalendarItem(6, "Fishing")
            };
            
            dataGrid1.ItemsSource = items;

            Days.ItemsSource = DayOfWeek.days;
        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void DayChanged(object sender, SelectionChangedEventArgs e)
        {
            var d = (sender as ComboBox).SelectedItem;
        }
    }
    class CalendarItem
    {
        public DayOfWeek Day { get; set; }
        public string Text { get; set; }

        public CalendarItem(int i, string txt)
        {
            Day = new DayOfWeek(i);
            Text = txt; ;
        }
    }

    public class DayOfWeek
    {
        public static readonly List<string> days = new List<string>()
        { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};

        public int Id { get; set;  }
        public string Name { get; set; }

        public DayOfWeek(int i)
        { Id = i;  Name = days[i - 1]; }
    }
}
