// <copyright file="AppDelegate.cs" company="DimitriosPapageorgacopoulos">
// Copyright (c) DimitriosPapageorgacopoulos. All rights reserved.
// </copyright>
namespace EchoIO;

using Foundation;

/// <summary>
/// Creates a new maui application.
/// </summary>
[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    /// <summary>
    /// Creates a new maui application.
    /// </summary>
    /// <returns>The newly created maui application.</returns>
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}