﻿using System;
using System.Windows.Media;

using CommunityToolkit.Mvvm.ComponentModel;

namespace ClassIsland.Models;

public class CountDownMiniInfoProviderSettings : ObservableRecipient
{
    private string _countDownName = "";
    private DateTime _overTime = DateTime.Now;
    private int _daysLeft = 0;
    private Color _fontColor = Color.FromRgb(255,0,0);
    private int _fontSize = 16;

    public string countDownName
    {
        get => _countDownName;
        set
        {
            if (value == null) return;
            if (value.Equals(_countDownName)) return;
            _countDownName = value;
            OnPropertyChanged();
        }
    }

    public DateTime overTime
    {
        get => _overTime;
        set
        {
            if (value == null) return;
            if (value.Equals(_overTime)) return;
            _overTime = value;
            OnPropertyChanged();
        }
    }

    public int DaysLeft
    {
        get => _daysLeft;
        set
        {
            if (value == _daysLeft) return;
            _daysLeft = value > 0 ? value : 0;
            OnPropertyChanged();
        }
    }

    public Color fontColor
    {
        get => _fontColor;
        set
        {
            if (value == null) return;
            if (value.Equals(_fontColor)) return;
            _fontColor = value;
            OnPropertyChanged();
        }
    }

    public int fontSize
    {
        get => _fontSize;
        set
        {
            if (value == null) return;
            if (value.Equals(_fontSize)) return;
            _fontSize = value;
            OnPropertyChanged();
        }
    }
}
