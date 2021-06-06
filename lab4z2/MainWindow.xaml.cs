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

namespace lab4z2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> ListaStudentow { get; set; }
        public MainWindow()
        {
            ListaStudentow = new List<Student>()
            {
                new Student(){ imie="Jan", nazwisko="Kowalski", NrIndeksu=1234, wydzial="KIS"},
                new Student(){ imie="Anna", nazwisko="Nowak", NrIndeksu=4321, wydzial="KIS"},
                new Student(){ imie="Michał", nazwisko="Jacek", NrIndeksu=34567, wydzial="KIS"}
            };

            InitializeComponent();

            dgStudents.Columns.Add(new DataGridTextColumn() { Header = "Imię", Binding = new Binding("imie") });
            dgStudents.Columns.Add(new DataGridTextColumn() { Header = "Nazwisko", Binding = new Binding("nazwisko") });
            dgStudents.Columns.Add(new DataGridTextColumn() { Header = "Nr indeksu", Binding = new Binding("NrIndeksu") });
            dgStudents.Columns.Add(new DataGridTextColumn() { Header = "Wydział", Binding = new Binding("wydzial") });

            dgStudents.AutoGenerateColumns = false;
            dgStudents.ItemsSource = ListaStudentow;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow();
            if (dialog.ShowDialog() == true)
            {
                ListaStudentow.Add(dialog.student);
                dgStudents.Items.Refresh();
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudents.SelectedItem is Student)
                ListaStudentow.Remove((Student)dgStudents.SelectedItem);
            dgStudents.Items.Refresh();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudents.SelectedItem is not Student)
                return;
            var dialog = new StudentWindow((Student)dgStudents.SelectedItem);
            if (dialog.ShowDialog() == true)
                dgStudents.Items.Refresh();
        }

        private void btnAddGrades_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudents.SelectedItem is not Student)
                return;
            var dialog = new AddGradeWindow((Student)dgStudents.SelectedItem);
            if (dialog.ShowDialog() == true)
                dgStudents.Items.Refresh();
        }

        private void btnShowGrades_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudents.SelectedItem is not Student)
                return;
            var dialog = new ShowGradeWindow((Student)dgStudents.SelectedItem);
            if (dialog.ShowDialog() == true)
                dgStudents.Items.Refresh();
        }
    }
}
