# ABV Calculator
A simple C# WinForms application to calculate the Alcohol By Volume (ABV) of a beverage based on its original gravity (OG) and final gravity (FG).

![](https://i.imgur.com/DlrkGAU.png)

## Features

- User-friendly interface to input original gravity and final gravity values
- Calculate ABV based on input values
- Display the calculated ABV in a message box

## Prerequisites

- Visual Studio with .NET Framework (at least 4.7.2) support

## Usage

1. Clone the repository or download the source code.
2. Open the solution file (`ABVCalc.sln`) in Visual Studio.
3. Build and run the application.

## How to Calculate ABV

The application calculates the Alcohol By Volume (ABV) using the following formula:

```csharp
ABV = (OG - FG) * 131.25
