using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace helpdesk.Pages
{
    /// <summary>
    /// Логика взаимодействия для DividedPage.xaml
    /// </summary>
    public partial class DividedPage : Page
    {
        public DividedPage()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Open_Executed(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                TextRange range = new TextRange(rtbAnswer.Document.ContentStart, rtbAnswer.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
            }
        } //использовать заранее созданные текстовые документы, но нужно подумать над выгрузкой из памяти уже существующие

        private void Save_Executed(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                TextRange range = new TextRange(rtbAnswer.Document.ContentStart, rtbAnswer.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
            }
        }

        private void lviWelcome_Selected(object sender, RoutedEventArgs e)
        {
            FileStream fileStream = new FileStream("../../BasedText/Welcome.rtf", FileMode.Open);
            TextRange range = new TextRange(rtbAnswer.Document.ContentStart, rtbAnswer.Document.ContentEnd);
            range.Load(fileStream, DataFormats.Rtf);
            fileStream.Close();
        }

        private void lviAddEditDelete_Selected(object sender, RoutedEventArgs e)
        {
            FileStream fileStream = new FileStream("../../BasedText/AddEditDelete.rtf", FileMode.Open);//@"BasedText\\AddEditDelete.rtf
            TextRange range = new TextRange(rtbAnswer.Document.ContentStart, rtbAnswer.Document.ContentEnd);
            range.Load(fileStream, DataFormats.Rtf);
            fileStream.Close();
        }
    }
}
