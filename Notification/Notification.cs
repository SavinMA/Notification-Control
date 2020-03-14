using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NotificationControl
{
    public class Notification : INotifyPropertyChanged
    {
        private bool isRead;

        private Command readInverseCommand;

        public Command ReadInverseCommand
        {
            get
            {
                return readInverseCommand ??
                    (readInverseCommand = new Command(obj => IsRead = !IsRead));
            }
        }


        public string BankName { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }

        public bool IsRead
        {
            get { return isRead; }
            set { isRead = value; OnPropertyChanged(); OnPropertyChanged("LeftBorderColor"); OnPropertyChanged("BackgroundColor"); OnPropertyChanged("FontColor"); }
        }

        public Brush LeftBorderColor
        {
            get { return IsRead ? new SolidColorBrush(Color.FromRgb(163, 169, 178)) : new SolidColorBrush(Color.FromRgb(132, 199, 218)); }
        }

        public Brush BackgroundColor
        { 
            get { return IsRead ? Brushes.White : new SolidColorBrush(Color.FromRgb(226, 241, 255)); }
        }

        public Brush FontColor
        {
            get { return IsRead ? Brushes.Gray : new SolidColorBrush(Color.FromRgb(19, 19, 19)); }
        }

        public Notification()
        {
            CreationTime = DateTime.Now;
            IsRead = false;
        }

        public Notification(string bankName, string description)
        {
            CreationTime = DateTime.Now;
            IsRead = false;

            BankName = bankName;
            Description = description;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
