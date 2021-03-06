﻿using Acr.UserDialogs;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CursoXamarin.PageModels
{
    public class BasePageModel : FreshBasePageModel, INotifyPropertyChanged
    {
        public IUserDialogs PageDialog = UserDialogs.Instance;

        public override void Init(object initData)
        {
            base.Init(initData);
        }
    }
}