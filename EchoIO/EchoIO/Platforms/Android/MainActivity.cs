// <copyright file="MainActivity.cs" company="DimitriosPapageorgacopoulos">
// Copyright (c) DimitriosPapageorgacopoulos. All rights reserved.
// </copyright>
namespace EchoIO;

using Android.App;
using Android.Content.PM;
using Android.OS;

/// <summary>
/// Launches the main window.
/// </summary>
[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
}