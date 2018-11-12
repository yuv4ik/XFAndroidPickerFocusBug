# XF Android Picker Focus Bug
Reproduction of a focus related bug on Android using a `Picker` and `Xamarin.Forms` 3.3.0.967583.

### Reproduction steps:
- Add a `Picker` control to the `MainPage`
- Create and register a custom `PickerRenderer` with the next code:
```
protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
{
    base.OnElementChanged(e);
    if (Control != null)
    {
        Control.Gravity = Android.Views.GravityFlags.Center;
    }
}
```

### Actual result:
The `Picker` control will be always focused after the first interaction and pressing the hardware volume up button will trigger a tap on a `Picker` itself, which will show the selection popup / alert view twice.

![Demo](https://github.com/yuv4ik/XFAndroidPickerFocusBug/raw/master/Screenshots/xf_android_picker_bug.gif)

### Expected result:
The `Picker` should release the focus and shoult not be triggered without a direct user interaction.

### Acknowledgements:
Many thanks for `Eve Nagel` for discovering and reporting this bug.
