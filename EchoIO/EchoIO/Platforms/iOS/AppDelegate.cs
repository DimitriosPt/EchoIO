// <copyright file="AppDelegate.cs" company="DimitriosPapageorgacopoulos">
// Copyright (c) DimitriosPapageorgacopoulos. All rights reserved.
// </copyright>

namespace EchoIO;

using Foundation;

/// <summary>
/// An application delegate for the maui launcher.
/// </summary>
[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    /// <summary>
    /// Initializes a new Maui application.
    /// </summary>
    /// <returns>The new maui app.</returns>
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}