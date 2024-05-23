using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Drawing;  
using System.Runtime.CompilerServices;  

namespace EFCoreExample
{
    [Index(nameof(Description), IsUnique = true)]
    public class Stock : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;  

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")  
        {  
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }  

        public int Id { get; init; }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                if (value != this._description)
                {
                    this._description = value;
                    NotifyPropertyChanged();
                    System.Console.WriteLine("lkjKLJ");
                }
            }
        }
    }
}