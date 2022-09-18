// <copyright file="MainApplication.cs" company="DimitriosPapageorgacopoulos">
// Copyright (c) DimitriosPapageorgacopoulos. All rights reserved.
// </copyright>

namespace EchoIO;

using Android.App;
using Android.Runtime;

/// <summary>
/// Launches the maui application.
/// </summary>
[Application]
public class MainApplication : MauiApplication
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainApplication"/> class.
    /// </summary>
    /// <param name="handle">Memory address handle.</param>
    /// <param name="ownership">Handle ownership.</param>
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    /// <summary>
    /// Creates the maui application.
    /// </summary>
    /// <returns>The new application that was created.</returns>
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}