# Project Objective

This project was built with .NET Core 3.1 and the purpose is to see the differences between each service lifetime of dependency injection.

## AddSingleton<>

One instance per app life cycle.

## AddTransient<>

New instance per http request.

## AddScoped<>

One instance within same http request.

To know more about the services, please visit this link - [Click Here](https://t.ly/fjefi)
