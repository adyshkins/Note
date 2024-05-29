using Note.DataBase;
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

using Note.Windows;

namespace Note
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LvNote.ItemsSource = EFClass.Context.Note.ToList();
        }

        private void BtnInfoNote_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button == null)
            {
                return;
            }

            var note = button.DataContext as DataBase.Note;

            NoteInfoWindow noteInfoWindow = new NoteInfoWindow(note);
            noteInfoWindow.ShowDialog();
        }

        private void BtnAddNote_Click(object sender, RoutedEventArgs e)
        {
            AddNoteWindow addNoteWindow = new AddNoteWindow();
            addNoteWindow.Show();
            this.Close();

        }
    }
}
