
PATH=$PATH:"/c/Program Files (x86)/IObit/IObit Unlocker/":"/c/Program Files (x86)/Comarch ERP XL 2019.3/"

echo "dotnet build \"XLHydraZaNOfeEdycjaBase.csproj\" -c Release"

cd "D:/Praca/HydraXLStanyZalegajace/src/ZaNOfeEdycja/XLHydraZaNOfeEdycjaBase"

dotnet build "XLHydraZaNOfeEdycjaBase.csproj" -c Release -o "/D/Praca/HydraXLStanyZalegajace/.publish/release-win-86"

echo "dotnet build \"XLHydraZaNZamEdycjaSprBase.csproj\" -c Release"

cd "D:/Praca/HydraXLStanyZalegajace/src/ZaNZamEdycjaSpr/XLHydraZaNZamEdycjaSprBase"

dotnet build "XLHydraZaNZamEdycjaSprBase.csproj" -c Release -o "/D/Praca/HydraXLStanyZalegajace/.publish/release-win-86"
