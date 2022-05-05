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
using helpdesk.Pages;

namespace helpdesk
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); //https://metanit.com/sharp/wpf/5.10.php TabControl; https://www.wpf-tutorial.com/rich-text-controls/richtextbox-control/ RichTextBox; https://www.wpf-tutorial.com/rich-text-controls/how-to-creating-a-rich-text-editor/ RichTextEditor;
            MainFrame.Navigate(new DividedPage());
            //https://www.codeproject.com/Articles/30134/LINQ-group-by-and-WPF-Data-Binding -- Список
        }
    }
}
