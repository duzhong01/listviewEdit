using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace listviewEdit
{
    public class personInfo:INotifyPropertyChanged
    {
        private string _name;
        private int _workYears;
        private string _workPhoneNumber;
        private string _email;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Email
        {
            get { return _email; }
            set {
                _email = value;
                PropertyChanged(this,new PropertyChangedEventArgs("Email"));
            }
        }

        public string WorkPhoneNumber
        {
            get { return _workPhoneNumber; }
            set {
                _workPhoneNumber = value;
                PropertyChanged(this,new PropertyChangedEventArgs("WorkPhoneNumber"));
            }
        }

        public int WorkYears
        {
            get { return _workYears; }
            set {
                _workYears = value;
                PropertyChanged(this,new PropertyChangedEventArgs("WorkYears"));
            }
        }

        public string Name
        {
            get { return _name; }
            set {
                _name = value;
                PropertyChanged(this,new PropertyChangedEventArgs("Name"));
            }

        }

        public personInfo(string name, int workYears, string workPhoneNumber, string email)
        {
            _name = name;
            _workYears = workYears;
            _workPhoneNumber = workPhoneNumber;
            _email = email;
        }
    }
}
