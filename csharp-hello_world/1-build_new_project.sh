#!/usr/bin/env bash
DIR="1-new_project"

if [ -d "$DIR" ]; then
  rm -rf "$DIR"
fi
dotnet new console -o "$DIR"

dotnet build "$DIR"