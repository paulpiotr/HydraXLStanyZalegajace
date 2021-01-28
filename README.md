# Stany zalegające
## Dodatki dla programu Comarch ERP XL 2019.3

## Informacje

##### Dodatki zostały skompilowane z wersją programu Comarch ERP XL 2019.3 z zestawem CdnHydra 2019.3.0.0 v4.0.30319 dla środowiska .NET Framework 4.7 i procesorów z rodziny x86

##### Kompilacja programu została ustawiona bezpośrednio do katalogu programu 

```
C:\Program Files (x86)\Comarch ERP XL 2019.3
```

##### W celu zmiany katalogu wyjściowego należy zmienić ścieżkę wyjścia w właściwościach projektu zakładka "Kompilacja"

## Instalacja dodatku

##### 1) Wyłączyć program XL i wszystkie jego instancje oraz okna
##### 2) Skopiować wszystkie pliki do katalogu instalacji programu XL (domyślny katalog instalacji programu XL znajduje się w lokalizacji):

```
C:\Program Files (x86)\Comarch ERP XL 2019.3
```

##### Binarne wersja plików znajdują się pod adresem:

```
http://tfs:8080/tfs/ELTECH/_git/HydraXLStanyZalegajace?path=%2F.publish&version=GBmaster&_a=contents
```


##### Lista plików do skopiowania - wszystkie pliki z katalogu
##### debug-win-86 lub release-win-86
##### http://tfs:8080/tfs/ELTECH/_git/HydraXLStanyZalegajace?path=%2F.publish&version=GBmaster&_a=contents

```
/debug-win-86 (wersja binarna w kompilacji debug)
/release-win-86 (wersja binarna w kompilacji release)
```

##### 3) Dodanie dodatku do programu XL

```
1) Uruchomić narzędzie Administrator programu XL domyślna lokalizacja programu:
"C:\Program Files (x86)\Comarch ERP XL 2019.3\CDNADM.EXE"
2) Zalogować się danymi operatora z uprawnieniami Administratora
3) Kliknąć System / Dodatki - menu w lewym górnym rogu programu
4) Kliknąć Importuj
5) Wybrać plik "ZaNOfeEdycja.XLHydraZaNOfeEdycjaBase.dll" z głównej lokalizacji programu XL po uprzednim skopiowaniu (punkt 2)
6) Kliknąć Edytuj w oknie
7) Zaznaczyć Aktywny
8) Kliknąć Zapisz
9) Punkty 4,5,6,7,8 ponowić wybierając plik "ZaNZamEdycjaSpr.XLHydraZaNZamEdycjaSprBase.dll"
10) Kliknąć Struktura firmy w menu Ogólne
11) Kliknąć dwa razy w Firma Główna (lub inna nazwa firmy dla której instalujemy dodatek) - Edycja struktury firmy
12) Wybrać TAB "Dodatki" (Przewijany pasek ze strzałkami)
13) Kliknąć ikonę plusa (Dodaj)
14) Wybrać zainstalowany dodatek "Stany zalegające w zakładce oferty."
15) Kliknąć ikonę dyskietki (Zapisz)
16) Punkty 10, 11, 12, 13, 14, 15 wykonać dla drugiego dodatku "Stany zalegające w zakładce zamówienia."
```