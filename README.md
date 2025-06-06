# Scrap Count Dumper

Lethal Company Mod to dump scrap count on entering the orbit.

## Development

Create a new directory `lib` at the repository root.
Copy a DLL file into `lib/` from `C:\Program Files (x86)\Steam\steamapps\common\Lethal Company`.

- `Lethal Company_Data\Managed\Assembly-CSharp.dll`
- `Lethal Company_Data\Managed\Unity.Netcode.Runtime.dll`

## Build

```powershell
# Debug build
dotnet build

# Release build
dotnet build --configuration Release
```

## Install

### Debug build

1. Install BeplnEx: https://docs.bepinex.dev/articles/user_guide/installation/index.html
2. Copy a DLL file into `C:\Program Files (x86)\Steam\steamapps\common\Lethal Company\BepInEx\plugins` from `bin\Debug\netstandard2.1\ScrapCountDumper.dll`.

### Release build

1. Install BeplnEx: https://docs.bepinex.dev/articles/user_guide/installation/index.html
2. Copy a DLL file into into `C:\Program Files (x86)\Steam\steamapps\common\Lethal Company\BepInEx\plugins` from `bin\Release\netstandard2.1\ScrapCountDumper.dll`.

### r2modman

1. Select a DLL file from `Settings > Import local mod`.
