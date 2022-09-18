// <copyright file="WeatherForecastService.cs" company="DimitriosPapageorgacopoulos">
// Copyright (c) DimitriosPapageorgacopoulos. All rights reserved.
// </copyright>

namespace EchoIO.Data;

/// <summary>
/// An example class for retrieving dummy weather information.
/// </summary>
public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching",
    };

    /// <summary>
    /// Retrieves dummy weather information.
    /// </summary>
    /// <param name="startDate">A starting date time to retrieve weather for.</param>
    /// <returns>An array of <see cref="WeatherForecast"/> objects representing a mocked week long forecast.</returns>
    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
        }).ToArray());
    }
}