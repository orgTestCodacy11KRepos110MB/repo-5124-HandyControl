﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HandyControl.Controls;
using HandyControl.Data;
using HandyControlDemo.UserControl;

namespace HandyControlDemo.ViewModel;

public class NotificationDemoViewModel : ViewModelBase
{
    public RelayCommand OpenCmd => new(() => Notification.Show(new AppNotification(), ShowAnimation, StaysOpen));

    private ShowAnimation _showAnimation;

    public ShowAnimation ShowAnimation
    {
        get => _showAnimation;
#if NET40
        set => Set(nameof(ShowAnimation) ,ref _showAnimation, value);
#else
        set => Set(ref _showAnimation, value);
#endif
    }

    private bool _staysOpen = true;

    public bool StaysOpen
    {
        get => _staysOpen;
#if NET40
        set => Set(nameof(StaysOpen) ,ref _staysOpen, value);
#else
        set => Set(ref _staysOpen, value);
#endif
    }
}
