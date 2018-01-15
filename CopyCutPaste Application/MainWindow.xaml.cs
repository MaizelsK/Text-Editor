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

namespace CopyCutPaste_Application
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            //Clipboard.SetText(text.Document., TextDataFormat.Text);
        }

        private void PasteButton_Click(object sender, RoutedEventArgs e)
        {
            //text.SelectedText = Clipboard.GetText();
        }

        private void CutButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
