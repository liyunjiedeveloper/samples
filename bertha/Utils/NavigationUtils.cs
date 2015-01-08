﻿// © Copyright(C) Microsoft. All rights reserved.

using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace bertha
{
    internal static class NavigationUtils
    {
        internal static void NavigateToScreen(Type screenType)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(screenType, null);
        }

        internal static void GoBack()
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.GoBack();
        }
    }
}
