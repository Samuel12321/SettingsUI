﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using SettingsUI.Helpers;

namespace SettingsUI.Demo;

public sealed partial class MainWindow : Window
{
    public Grid ApplicationTitleBar => AppTitleBar;
    internal static MainWindow Instance { get; private set; }
    public MainWindow()
    {
        this.InitializeComponent();
        Instance = this;
        TitleBarHelper.Initialize(this, TitleTextBlock, AppTitleBar, LeftPaddingColumn, IconColumn, TitleColumn, LeftDragColumn, SearchColumn, RightDragColumn, RightPaddingColumn);
    }
}
