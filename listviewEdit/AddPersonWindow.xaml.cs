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
using System.Windows.Shapes;

namespace listviewEdit
{
    /// <summary>
    /// AddPersonWindow.xaml 的交互逻辑
    /// </summary>
    /// 
    public partial class AddPersonWindow : Window
    {
       
        public AddPersonWindow()
        {
            InitializeComponent();
        }

        public delegate void PassValuesHandler(object sender, PassValuesEventArgs e);

        public event PassValuesHandler PassValuesEvent; 

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            //string name=name
            bool isadd = true;
          personInfo  personInfo = new personInfo(name.Text,int.Parse(workYears.Text),workPhoneNumber.Text,email.Text);
            PassValuesEventArgs args = new PassValuesEventArgs(personInfo,isadd);
            PassValuesEvent(this, args);
            this.Close();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            bool isadd = false;
            personInfo personInfo = null;
            PassValuesEventArgs args = new PassValuesEventArgs(personInfo, isadd);
            PassValuesEvent(this, args);
            this.Close();
        }
    }

    public class PassValuesEventArgs : EventArgs
    {
        public bool isok;
        public personInfo pInfo;
        public PassValuesEventArgs(personInfo pInfo,bool isok)
        {
            this.pInfo = pInfo;
            this.isok = isok;
        }
    }
}
