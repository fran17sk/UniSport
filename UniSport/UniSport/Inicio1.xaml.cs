﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniSport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio1 : TabbedPage
    {
        public Inicio1()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        
    }
}