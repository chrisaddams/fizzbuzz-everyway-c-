#!/bin/bash
dotnet restore
for x in {1..5}
do
    for i in {1..50}
    do
        cat <(echo $x) | dotnet run
    done
done
dotnet tool install -g dotnet-script
dotnet script average.csx