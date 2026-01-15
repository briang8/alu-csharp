#!/usr/bin/env bash

dotnet new console -o 2-new_project


sed -i 's/Console.WriteLine("Hello, World!");/Console.WriteLine("Hello World!");/' 2-new_project/Program.cs


dotnet build 2-new_project

dotnet run --project 2-new_project