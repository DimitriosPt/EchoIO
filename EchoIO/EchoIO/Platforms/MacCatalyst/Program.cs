// <copyright file="Program.cs" company="DimitriosPapageorgacopoulos">
// Copyright (c) DimitriosPapageorgacopoulos. All rights reserved.
// </copyright>

namespace EchoIO;

using ObjCRuntime;
using UIKit;

/// <summary>
/// Handles the launching of the maui application.
/// </summary>
public class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// <param name="args">Additional startup arguments.</param>
    internal static void Main(string[] args)
    {
        // if you want to use a different Application Delegate class from "AppDelegate"
        // you can specify it here.
#pragma warning disable CA1416 // Validate platform compatibility
        UIApplication.Main(args, null, typeof(AppDelegate));
#pragma warning restore CA1416 // Validate platform compatibility
    }
}