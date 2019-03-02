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
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace listviewEdit
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
     
        public MainWindow()
        {
            InitializeComponent();
           

        }
        ObservableCollection<personInfo> personList = new ObservableCollection<personInfo>(); 

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            personList.Add(new personInfo("李白",10,"123456","1104840254@qq.com"));
            personList.Add(new personInfo("杜甫", 2, "78541", "984258621@qq.com"));
            personList.Add(new personInfo("苏轼", 4, "95462", "2324928123@qq.com"));
            personList.Add(new personInfo("李清照", 3, "41532", "84256144486@qq.com"));
            listView.ItemsSource = personList;
                
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            ObservableCollection<personInfo> pList = listView.ItemsSource as ObservableCollection<personInfo>;
            int index = listView.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("未中");
                return;
            }
            pList.RemoveAt(index);

        }
        
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            AddPersonWindow add = new AddPersonWindow();
            add.PassValuesEvent += new AddPersonWindow.PassValuesHandler(ReceiveValues);
            add.Show();
        }
        private void ReceiveValues(object sender, PassValuesEventArgs e)
        {
           if(e.isok)
           {
               ObservableCollection<personInfo> pList = listView.ItemsSource as ObservableCollection<personInfo>;
               pList.Add(e.pInfo);
           }
        }

        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.IsEnabled = true;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();


        }

        
    }
}
