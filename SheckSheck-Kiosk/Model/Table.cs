using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SheckSheck_Kiosk.Model
{
    class Table : INotifyPropertyChanged
    {
        public int Number { get; set; }
        private DateTime paidAt { get; set; }
        public DateTime PaidAt { 
            get => paidAt;
            set
            {
                paidAt = value;
                OnPropertyChanged("PaidAt");
                ExpireAt = PaidAt.AddMinutes(1);
            }
        }
        private DateTime expireAt { get; set; }
        public DateTime ExpireAt {
            get => expireAt;
            set
            {
                expireAt = value;
                OnPropertyChanged("ExpireAt");
            }
        }
        private int remainSeconds { get; set; }
        public int RemainSeconds
        {
            get {
                return Convert.ToInt32(ExpireAt.Subtract(PaidAt).TotalSeconds);
            }
            set
            {
                remainSeconds = value;
                OnPropertyChanged("RemainSeconds");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
