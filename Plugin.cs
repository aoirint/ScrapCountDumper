using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace ScrapCountDumper;

[BepInPlugin("com.aoirint.scrapcountdumper", "Scrap Dumper", "0.1.0")]
[BepInProcess("Lethal Company.exe")]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;

    private void Awake()
    {
        Logger = base.Logger;
        Logger.LogInfo("Plugin com.aoirint.scrapcountdumper is loaded!");

        Harmony.CreateAndPatchAll(typeof(Plugin));
    }

    static int GetGrabbableObjectCount()
    {
        var grabbableObjects = FindObjectsByType<GrabbableObject>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        return grabbableObjects.Length;
    }

    [HarmonyPatch(typeof(StartOfRound), "Awake")]
    [HarmonyPostfix]
    static void StartOfRoundAwakePostfix()
    {
        var grabbableObjectCount = GetGrabbableObjectCount();
        Logger.LogInfo($"GrabbableObject count at Awake: {grabbableObjectCount}");
    }

    [HarmonyPatch(typeof(StartOfRound), "SetShipReadyToLand")]
    [HarmonyPostfix]
    static void StartOfRoundSetShipReadyToLandPostfix()
    {
        var grabbableObjectCount = GetGrabbableObjectCount();
        Logger.LogInfo($"GrabbableObject count at SetShipReadyToLand: {grabbableObjectCount}");
    }
}
