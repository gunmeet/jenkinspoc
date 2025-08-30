echo "# jenkinspoc" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/gunmeet/jenkinspoc.git
git push -u origin main


git remote add origin https://github.com/gunmeet/jenkinspoc.git
git branch -M main
git push -u origin main


CASE 1 -->.NET Core + xUnit + Console + Dockeries + GitHub + Jenkins  = CI CD(Localhost)
CASE 2 -->.NET Core + xUnit + EF COare + Azure DB + GitHub + GitHub Action + Azure Web APP  = CI CD(Localhost)
CASE 3 -->.NET Core + xUnit + EF COare + Azure DB + GitHub + Azure DevOps + Azure Web APP  = CI CD(Localhost)
CASE 4 -->Azure Service Bus

echo ==== Restore Solution ====
dotnet restore Product.sln

echo ==== Build Solution ====
dotnet build Product.sln --configuration Release

echo ==== Run Tests ====
dotnet test ProductTests\ProductTests.csproj --logger:trx

echo ==== Publish Console App ====
dotnet publish Product\Product.csproj -c Release -o %WORKSPACE%\publish\Product

echo ==== Publish API (not used, but included) ====
dotnet publish ProductApi\ProductApi.csproj -c Release -o %WORKSPACE%\publish\ProductApi

echo ==== Build Docker Images ====
docker build -t product:latest ./Product
docker build -t productApi:latest ./ProductApi