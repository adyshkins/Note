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
using System.Windows.Shapes;

namespace Note.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddNoteWindow.xaml
    /// </summary>
    public partial class AddNoteWindow : Window
    {
        public AddNoteWindow()
        {
            InitializeComponent();

            CmbAuthor.ItemsSource = EFClass.Context.Author.ToList();
            CmbAuthor.DisplayMemberPath = "NameAuthor";
            CmbAuthor.SelectedIndex = 0;
        }

        private void BtnAddNote_Click(object sender, RoutedEventArgs e)
        {
            DataBase.Note newNote = new DataBase.Note();

            newNote.Title = TxtTitle.Text;
            newNote.TextNote = TxtText.Text;
            newNote.IDAuthor = (CmbAuthor.SelectedItem as Author).IDAuthor;

            EFClass.Context.Note.Add(newNote);

            EFClass.Context.SaveChanges();

            MessageBox.Show("Заметка добавлена", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            
            
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
