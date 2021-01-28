
PATH=$PATH:"/c/Program Files (x86)/IObit/IObit Unlocker/":"/c/Program Files (x86)/Comarch ERP XL 2019.3/"
#cd "/c/Program Files (x86)/Comarch ERP XL 2019.3/"
#IObitUnlocker.exe //Delete //Advanced "HydraXLStanyZalegajace.XLHydraChildWindow.dll"

echo "Kill process CDNSPR.EXE"

if [[ ! -z $(tasklist | grep CDNSPR.EXE | awk '{ print $2 }') ]]; then
    taskkill //PID $(tasklist | grep CDNSPR.EXE | awk '{ print $2 }') //F
fi

echo "dotnet build \"XLHydraZaNZamEdycjaSprBase.csproj\" -c Release"

cd "D:/Praca/HydraXLStanyZalegajace/src/ZaNZamEdycjaSpr/XLHydraZaNZamEdycjaSprBase"

dotnet build "XLHydraZaNZamEdycjaSprBase.csproj" -c Release

echo "START CDNSPR.EXE"

cd "/c/Program Files (x86)/Comarch ERP XL 2019.3/"

START CDNSPR.EXE