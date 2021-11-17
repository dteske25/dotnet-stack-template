# Download SqlServer docker image
docker pull mcr.microsoft.com/mssql/server
# Run the container and set the password
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Str0ngPa\$\$w0rd" -p 1433:1433 -d mcr.microsoft.com/mssql/server
# Install EF tooling
dotnet tool install --global dotnet-ef
# Run any previously created migrations
dotnet ef database update --project "./DotnetStack.DataAccessHandlers/" --startup-project "./DotnetStack.Api/"