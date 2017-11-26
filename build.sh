#!/bin/bash
set -ev
dotnet restore src/Churchill.sln
dotnet build src/Churchill.sln
dotnet test src/tests/IterationZero.Churchill.WebApi.Tests.Unit/IterationZero.Churchill.WebApi.Tests.Unit.csproj