using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Password_generator
{
    class Passwordgeneration:INotifyPropertyChanged
    {
        public string input { get; set; }
        public string pass_input { get; set; }
        public Passwordgeneration()
        {
            Set();
            
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
            #region init
            Random r = new Random();
            string[] pole = new string[12];
            List<int> position = new List<int>(new int[12]);
            char BigLetter;
            int Position;
            char SmallLetter;
            char character;
            char number;
            bool k;
            #endregion
            #region Big letters
            for (int i = 0; i < 3; i++)
            {
                BigLetter = (char)r.Next(65, 90);
                k = true;
                while (k)
                {
                    Position = r.Next(0, 12);
                    if (position.Contains(Position) == false)
                    {
                        position.Add(Position);
                        pole[Position] = BigLetter.ToString();
                        k = false;
                    }

                }




            }
            #endregion
            #region small letters

            for (int i = 0; i < 3; i++)
            {
                SmallLetter = (char)r.Next(97, 122);
                k = true;
                while (k)
                {
                    Position = r.Next(0, 12);
                    if (position.Contains(Position) == false)
                    {
                        position.Add(Position);
                        pole[Position] = SmallLetter.ToString();
                        k = false;
                    }

                }




            }
            #endregion
            #region character
            for (int i = 0; i < 3; i++)
            {
                character = (char)r.Next(58, 64);
                k = true;
                while (k)
                {
                    Position = r.Next(0, 12);
                    if (position.Contains(Position) == false)
                    {
                        position.Add(Position);
                        pole[Position] = character.ToString();

                        k = false;
                    }


                }

            }
            #endregion
            #region number

            for (int i = 0; i < 2; i++)
            {
                number = (char)r.Next(48, 57);
                k = true;
                while (k)
                {
                    Position = r.Next(0, 12);
                    if ((position.Contains(Position) == false))
                    {
                        position.Add(Position);
                        pole[Position] = number.ToString();
                        k = false;
                    }



                }

            }
            #endregion
            input = string.Join("", pole);
            Change("input");
        }
            
        }
        
        
    }

