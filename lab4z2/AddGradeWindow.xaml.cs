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
using System.Text.RegularExpressions;

namespace lab4z2
{
    /// <summary>
    /// Interaction logic for AddGradeWindow.xaml
    /// </summary>
    public partial class AddGradeWindow : Window
    {
        public Student student;

        public AddGradeWindow(Student student = null)
        {
            InitializeComponent();
            this.student = student;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(tbKurs.Text, @"^\p{Lu}\p{Ll}{1,12}$"))
            {
                MessageBox.Show("Podano błędne dane.");
                return;
            }
            student.ListaOcen.Add(new Ocena(tbKurs.Text, int.Parse(cbOcena.Text)));
            this.DialogResult = true;
        }
    }
}
