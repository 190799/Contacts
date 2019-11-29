using AppContacs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppContacs.ViewModels
{
    public class MainViewModel
    {
        #region properties
        public List<Contacts> ListContacts { get; set; }
        #endregion 

        #region singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance==null)
            {
                instance = new MainViewModel();
            }
            return (instance);
        }
        #endregion

        #region ViewModels
        public ContactsViewModel contactsViewModel { get; set; }

        #endregion 
    }
}
