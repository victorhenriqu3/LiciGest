dotnet tool update -g dotnet-reportgenerator-globaltool
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=coverage.opencover.xml /p:Exclude="[*]Infra.Migrations*"
#Abre o arquivo no browser padrão
coverage_report\index.html