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
using System.Windows.Forms;
using System.IO;

namespace SharpPad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected bool textChanged;
        protected string currentFileName;


        public MainWindow()
        {
            InitializeComponent();
            textChanged = false;

        }
        public void openButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".rtf";
            open.Filter = "Rich Text files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (textChanged == true)
            {
                toSave();
            }
            System.Windows.Forms.DialogResult result = open.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ClearText();
                TextBlock1.AppendText(System.IO.File.ReadAllText(open.FileName));
                textChanged = false;
                currentFileName = open.FileName;
            }
        }
        
        public void toSave()
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Wold you like to save this document?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                saveAsFunction();
            }
        }

        public void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentFileName == null)
            {
                saveAsFunction();
            }
            else
            {
                string myText = new TextRange(TextBlock1.Document.ContentStart, TextBlock1.Document.ContentEnd).Text;
                System.IO.File.WriteAllText(currentFileName, myText);
                textChanged = false;
            }
        }

        public void saveAsButton_Click(object sender, RoutedEventArgs e)
        {
            saveAsFunction();
        }

        public void saveAsFunction()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".rtf";
            save.Filter = "Rich Text files (*.rtf)|*.rtf|All files (*.*)|*.*";
            System.Windows.Forms.DialogResult result = save.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string myText = new TextRange(TextBlock1.Document.ContentStart, TextBlock1.Document.ContentEnd).Text;
                File.WriteAllText(save.FileName, myText);
                currentFileName = save.FileName;
                textChanged = false;
            }

        }

        public void newButton_Click(object sender, RoutedEventArgs e)
        {
            if (textChanged)
            {
                toSave();
            }
            ClearText();
            currentFileName = null;
        }

        

        public void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            About aboutWindow = new About();
            aboutWindow.Show();
        }

        public void ClearText()
        {
            TextBlock1.Document.Blocks.Clear();
        }

        
        public void TextBlock1_TextChanged(object sender, TextChangedEventArgs e)
        {
            textChanged = true;
        }

        private void exitAsButton_Click(object sender, RoutedEventArgs e)
        {
            if (textChanged)
            {
                toSave();
            }
            this.Close();
        }
        private void printButton_Click(object sender, RoutedEventArgs e)
        {
            /*System.Windows.Controls.PrintDialog pd = new System.Windows.Controls.PrintDialog();
            bool result;
            result = (bool)pd.ShowDialog();
            if ((result))
            {
                //use either one of the below      
                //pd.PrintVisual(TextBlock1 as Visual, "printing as visual");
                pd.PrintDocument((((IDocumentPaginatorSource)TextBlock1.Document).DocumentPaginator), "printing as paginator");
            }*/
            
        }
        private void printPreviewButton_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private void zoomInButton_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void ZoomOutButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        
        

       

    }
}
