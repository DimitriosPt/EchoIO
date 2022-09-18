// <copyright file="App.xaml.cs" company="DimitriosPapageorgacopoulos">
// Copyright (c) DimitriosPapageorgacopoulos. All rights reserved.
// </copyright>

namespace EchoIO;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new MainPage();
    }
}