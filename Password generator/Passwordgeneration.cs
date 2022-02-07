using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public string PassInput(string s)
        {

            string[] arr = new string[5];
            var regex = new Regex("([:-@])|([!-/])|([[-`])|([{-~])");
            int help = 0;

            if (s.Length < 8)
            {
                arr[0] = "too short,";

            }
            else { arr[0] = "";help += 1; }
            
            if (s.Any(char.IsUpper) == false)
            {
                arr[1] = " dosen't have a uppercase letter,";
            }
            else { arr[1] = ""; help += 1; }
            if (s.Any(char.IsLower) == false)
            {
                arr[2] = " dosen't have a lowercase letter,";
            }
            else { arr[2] = ""; help += 1; }
            if (s.Any(char.IsDigit) == false)
            {
                arr[3] = " dosen't have a number,";
            }
            else
            {
                arr[3] = "";
                help += 1;
            }
            if (regex.IsMatch(s)==false)
            {
                arr[4] = " dosen't have a symbol";
            }
            else { arr[4] = ""; help += 1; }

            string d= String.Join("", arr);

            if (help == 5)
            {
                d = "Your password is safe";
            }
            return d;
        }
        }
        
        
    }

