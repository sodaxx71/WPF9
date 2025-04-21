﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Task9.App.View;

namespace Task9.App.Services
{
    public class DialogService : IDialogService
    {
        Window coffeeDetailView = null;

        public DialogService()
        {
        }

        public void ShowDetailDialog()
        {
            coffeeDetailView = new CoffeeDetailView();
            coffeeDetailView.ShowDialog();
        }

        public void CloseDetailDialog()
        {
            if (coffeeDetailView != null)
                coffeeDetailView.Close();
        }
    }
}
