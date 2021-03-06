using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CatchTracker.Classes;
using Autofac;

namespace CatchTracker.Activitys
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        private IUser currentUser = null;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            using (var scope = App.Container.BeginLifetimeScope())
            {
                currentUser = scope.Resolve<IUser>();
            }
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnPause()
        {
            base.OnPause();
        }
    }
}