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
    /// Логика взаимодействия для NoteInfoWindow.xaml
    /// </summary>
    public partial class NoteInfoWindow : Window
    {
        public NoteInfoWindow()
        {
            InitializeComponent();
        }

        public NoteInfoWindow(DataBase.Note note)
        {
            InitializeComponent();

            TbTitle.Text = note.Title;

            TbAuthor.Text = EFClass.Context.Author.ToList().
                Where(i => i.IDAuthor == note.IDAuthor).
                FirstOrDefault().NameAuthor; 

            TbText.Text = note.TextNote;
        }
    }
}
