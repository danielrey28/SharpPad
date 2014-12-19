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

namespace SharpPad
{
    /// <summary>
    /// Interaction logic for about.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
            AboutSharpPad();
        }

        public void AboutSharpPad()
        {
            /*System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            appName.Content = asm.GetCustomAttributes(typeof(System.Reflection.AssemblyTitleAttribute), false);
            appCreator.Content = asm.GetCustomAttributes(typeof(System.Reflection.AssemblyCompanyAttribute), false);
            appCopywrite.Content = asm.GetCustomAttributes(typeof(System.Reflection.AssemblyCopyrightAttribute), false);
            appVersion.Content = asm.GetCustomAttributes(typeof(System.Reflection.AssemblyVersionAttribute), false);
             * */
        }
    }
}
