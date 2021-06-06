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

namespace lab4z2
{
    /// <summary>
    /// Interaction logic for ShowGradeWindow.xaml
    /// </summary>
    public partial class ShowGradeWindow : Window
    {
        public Student student;

        public ShowGradeWindow(Student student = null)
        {
            this.student = student;
            InitializeComponent();

            dgGrades.Columns.Add(new DataGridTextColumn() { Header = "Kurs", Binding = new Binding("kurs") });
            dgGrades.Columns.Add(new DataGridTextColumn() { Header = "Ocena", Binding = new Binding("ocena") });
            
            dgGrades.AutoGenerateColumns = false;
            dgGrades.ItemsSource = this.student.ListaOcen;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
