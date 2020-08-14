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
using HideNaviBar.Droid;
using HideNaviBar.Models;
using Xamarin.Forms;

[assembly: Dependency(typeof(NaviBarService))]
namespace HideNaviBar.Droid
{
    public class NaviBarService : INaviBarService
    {
        public void HideNaviBar()
        {
            var decorView = MainActivity.Instance.Window.DecorView;
            var uiOptions = SystemUiFlags.LayoutStable
                | SystemUiFlags.LayoutHideNavigation
                | SystemUiFlags.LayoutFullscreen
                | SystemUiFlags.HideNavigation
                | SystemUiFlags.Fullscreen
                | SystemUiFlags.ImmersiveSticky;
            decorView.SystemUiVisibility = (StatusBarVisibility)(int)uiOptions;
        }

        public void VisibleNaviBar()
        {
            var decorView = MainActivity.Instance.Window.DecorView;
            var uiOptions = SystemUiFlags.Visible;
            decorView.SystemUiVisibility = (StatusBarVisibility)(int)uiOptions;
        }
    }
}