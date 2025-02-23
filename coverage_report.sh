#! /usr/bin/env bash

dotnet tool update -g dotnet-reportgenerator-globaltool
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=coverage.opencover.xml /p:Exclude="[*]Infra.Migrations*"
reportgenerator -reports:**/coverage.opencover.xml -targetdir:coverage_report
