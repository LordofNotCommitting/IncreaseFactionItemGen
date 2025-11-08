

using HarmonyLib;
using MGSC;

namespace IncreaseFactionItemGen
{
    /// <summary>
    /// A Unity Debug Logger that includes the assembly name.
    /// Makes finding the mod that created the log entry easy to find.
    /// Calls the Unity.Debug functions that match the function names.
    /// </summary>

    [HarmonyPatch(typeof(StationSystem), nameof(StationSystem.StationsAddItemsTick))]
    // Specify the property name and indicate we are patching its Getter method
    public static class EditStationAddFactionItemsNumber
    {
        static int faction_item_period = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Faction_Item_Period", 2);
        static int faction_item_percentage_int = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Faction_Item_Percentage", 25);
        static int faction_item_count = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Faction_Item_Count", 5);
        static bool Prefix(SpaceTime spaceTime, Factions factions, Stations stations, SpaceTickTimers spaceTickTimers)
        {
            //Plugin.Logger.Log("heck yeah boy");
            Data.Global.StationAddFactionItemsTimerWeeks = faction_item_period;
            Data.Global.StationAddFactionItemsStationsPercent = ((float)faction_item_percentage_int / 100f);
            Data.Global.StationAddFactionItemsNumber = faction_item_count;
            return true;
        }

    }
}