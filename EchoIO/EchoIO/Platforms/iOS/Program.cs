// <copyright file="Program.cs" company="DimitriosPapageorgacopoulos">
// Copyright (c) DimitriosPapageorgacopoulos. All rights reserved.
// </copyright>

namespace EchoIO;

using ObjCRuntime;
using UIKit;

/// <summary>
/// The primary entry point for the application.
/// </summary>
public class Program
{
    /// <summary>
    /// Makes a call to initialize the UI.
    /// </summary>
    /// <param name="args">Additional runtime arguments.</param>
    internal static void Main(string[] args)
    {
        // if you want to use a different Application Delegate class from "AppDelegate"
        // you can specify it here.
        UIApplication.Main(args, null, typeof(AppDelegate));
    }
}