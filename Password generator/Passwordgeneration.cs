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
            int[] array = new int[11];
            char BigNumber;
            int BigNumberPosition;
            
            //velké čísla
            for(int i = 0; i < r.Next(1,5);i++)
            {
                BigNumber = (char)r.Next(65,91);
                BigNumberPosition = r.Next(0,13);

                while (array[BigNumberPosition]!=null)
                {
                    
                    BigNumberPosition = r.Next(0, 13);
                }
                
                array[BigNumberPosition] = BigNumber;
                

            }
            Change("GeneratedPassword");
        }
        
        
    }
}
