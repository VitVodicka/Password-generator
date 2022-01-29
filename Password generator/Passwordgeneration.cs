using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_generator
{
    class Passwordgeneration:INotifyPropertyChanged
    {
        public string GeneratedPassword { get; set; }
        public Passwordgeneration()
        {
            
        }
        #region Inotify
        public event PropertyChangedEventHandler PropertyChanged;

        public void Change(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        #endregion

        public void Set()
        {
            Random r = new Random();
            GeneratedPassword = r.Next().ToString();
            Change("GeneratedPassword");
        }
        
        
    }
}
