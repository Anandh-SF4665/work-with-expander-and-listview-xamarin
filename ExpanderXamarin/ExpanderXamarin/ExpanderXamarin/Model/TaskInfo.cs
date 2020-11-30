﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExpanderXamarin.Model
{
    public class ToDoItem : INotifyPropertyChanged
    {
        #region Fields

        private string name;
        #endregion

        #region Constructor

        public ToDoItem()
        {

        }

        #endregion

        #region Properties

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
