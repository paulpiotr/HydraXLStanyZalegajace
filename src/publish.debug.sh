﻿
PATH=$PATH:"/c/Program Files (x86)/IObit/IObit Unlocker/":"/c/Program Files (x86)/Comarch ERP XL 2019.3/"

#echo "dotnet build \"XLHydraZaNOfeEdycjaBase.csproj\" -c Debug"

#cd "D:/Praca/HydraXLStanyZalegajace/src/ZaNOfeEdycja/XLHydraZaNOfeEdycjaBase"

#dotnet build "XLHydraZaNOfeEdycjaBase.csproj" -c Debug -o "/D/Praca/HydraXLStanyZalegajace/.publish/debug-win-86"

#echo "dotnet build \"XLHydraZaNZamEdycjaSprBase.csproj\" -c Debug"

#cd "D:/Praca/HydraXLStanyZalegajace/src/ZaNZamEdycjaSpr/XLHydraZaNZamEdycjaSprBase"

#dotnet build "XLHydraZaNZamEdycjaSprBase.csproj" -c Debug -o "/D/Praca/HydraXLStanyZalegajace/.publish/debug-win-86"

echo "dotnet build \"XLHydraZaEEdycjaBase.csproj\" -c Debug"

cd "/D/Praca/HydraXLStanyZalegajace/src/ZaEEdycja/XLHydraZaEEdycjaBase"

rm -rf "/D/Praca/HydraXLStanyZalegajace/.publish/debug-win-86/"

dotnet build "XLHydraZaEEdycjaBase.csproj" -c Debug -o "/D/Praca/HydraXLStanyZalegajace/.publish/debug-win-86"


