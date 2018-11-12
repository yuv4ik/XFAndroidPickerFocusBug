using System;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFAndroidPickerFocusBug.Droid;

[assembly: ExportRenderer(typeof(Picker), typeof(GenericPickerRenderer))]
namespace XFAndroidPickerFocusBug.Droid
{
    public class GenericPickerRenderer : PickerRenderer
    {
        public GenericPickerRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Gravity = Android.Views.GravityFlags.Center;
            }
        }
    }
}
