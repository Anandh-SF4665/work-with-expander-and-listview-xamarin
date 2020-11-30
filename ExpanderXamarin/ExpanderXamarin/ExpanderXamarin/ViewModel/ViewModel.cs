using ExpanderXamarin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ExpanderXamarin.ViewModel
{
    public class ViewModel
    {
        #region Fields

        private ObservableCollection<InboxInfo> inboxInfo;
        private ObservableCollection<ToDoItem> tasksInfo;

        #endregion

        #region Constructor

        public ViewModel()
        {
            GenerateSource();
        }

        #endregion

        #region Properties

        public ObservableCollection<InboxInfo> InboxInfo
        {
            get { return inboxInfo; }
            set { this.inboxInfo = value; }
        }

        public ObservableCollection<ToDoItem> TasksInfo
        {
            get { return tasksInfo; }
            set { this.tasksInfo = value; }
        }
        #endregion

        #region Methods

        private void GenerateSource()
        {
            InfoRepository itemInfo = new InfoRepository();
            inboxInfo = itemInfo.GetInboxInfo();
            tasksInfo = itemInfo.GetToDoList();
        }
        #endregion
    }
}
