#!/usr/bin/env bash
dotnet new console -o 1-new_project --force > /dev/null 2>&1

dotnet build 1-new_project | grep -A 2 "Build succeeded"