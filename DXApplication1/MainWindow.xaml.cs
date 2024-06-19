using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DXApplication1.ViewModels;

namespace DXApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BarButtonItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Close();
        }
        

        private void AccordionItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("HOLA");
            DataContext = new HomeViewModel();
        }

        private void acrView1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataContext = new View1ViewModel();
        }
    }
}
