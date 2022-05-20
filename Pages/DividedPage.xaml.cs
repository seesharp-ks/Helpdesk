using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using helpdesk.Baza;
using helpdesk.Windows;
using System.Linq;
using System.Reflection;

namespace helpdesk.Pages
{
    /// <summary>
    /// Логика взаимодействия для DividedPage.xaml
    /// </summary>
    public partial class DividedPage : Page
    {
        Entities Entities = new Entities();
        public DividedPage()
        {
            InitializeComponent();
            RunTest.Text = "Добро пожаловать, " + AuthWindow.acc.Rank.RankName + " " + AuthWindow.acc.Login + "\n\n~    Выберите пункт слева для перехода к справочной информации.    ~";
            if (AuthWindow.acc.IDRank != 1)
            {
                //Bward.IsEnabled = false;
                //Fward.IsEnabled = false;
                Open.IsEnabled = false;
                lviAddEditDeleteOp.Visibility = Visibility.Hidden;
            }
            else
            {
                Open.IsEnabled = true;
                lviAddEditDeleteOp.Visibility = Visibility.Visible;
            }
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

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        { }

        private void lviTemporary_Selected(object sender, RoutedEventArgs e)
        {
            FileStream fileStream = new FileStream("../../BasedText/Temporary.rtf", FileMode.Open);//@"BasedText\\AddEditDelete.rtf
            TextRange range = new TextRange(rtbAnswer.Document.ContentStart, rtbAnswer.Document.ContentEnd);
            range.Load(fileStream, DataFormats.Rtf);
            fileStream.Close();
        }

        private void lviAddEditDeleteOp_Selected(object sender, RoutedEventArgs e)
        {
            FileStream fileStream = new FileStream("../../BasedText/AddEditDeleteOp.rtf", FileMode.Open);//@"BasedText\\AddEditDelete.rtf
            TextRange range = new TextRange(rtbAnswer.Document.ContentStart, rtbAnswer.Document.ContentEnd);
            range.Load(fileStream, DataFormats.Rtf);
            fileStream.Close();
        }
    }
}
