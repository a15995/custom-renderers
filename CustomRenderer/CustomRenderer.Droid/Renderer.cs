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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using CustomRenderer;
using CustomRenderer.Droid;

[assembly: ExportRenderer (typeof(MyEntry), typeof(MyEntryRenderer))]
namespace CustomRenderer.Droid
{
    class MyEntryRenderer : EntryRenderer // MyEntryRenderer nedarver fra EntryRenderer, som nedarver fra Entry (EntryControl.cs)
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged (e);

            if (Control != null) {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen); // Android anvender Control frem for View (PCL)
            }
        }
    }
}