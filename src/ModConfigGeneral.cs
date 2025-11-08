using MGSC;
using ModConfigMenu.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IncreaseFactionItemGen
{
    // Token: 0x02000006 RID: 6
    public class ModConfigGeneral
    {
        // Token: 0x0600001D RID: 29 RVA: 0x00002840 File Offset: 0x00000A40
        public ModConfigGeneral(string ModName, string ConfigPath)
        {
            this.ModName = ModName;
            this.ModData = new ModConfigData(ConfigPath);
            this.ModData.AddConfigHeader("STRING:General Settings", "general");

            this.ModData.AddConfigValue("general", "about_1", "STRING:For Every <color=#f51b1b>[Period]</color> weeks, each station have <color=#f51b1b>[percentage]</color>% of producing <color=#f51b1b>[Count]</color># of item from faction item pool.\n");
            this.ModData.AddConfigValue("general", "Faction_Item_Period", 2, 1, 10, "STRING:Faction Item Gen Period", "STRING:Faction Item production period, in unit of week.");
            this.ModData.AddConfigValue("general", "Faction_Item_Percentage", 25, 0, 100, "STRING:Faction item % Per Station", "STRING:Each station have % to product item per production period.");
            this.ModData.AddConfigValue("general", "Faction_Item_Count", 5, 0, 50, "STRING:Faction item per Occurrence", "STRING:When above 2 conditions are met, This amount of item is generated.");
            this.ModData.AddConfigValue("general", "about_final", "STRING:<color=#f51b1b>The game must be restarted after setting then saving this config to take effect.</color>\n");
            this.ModData.RegisterModConfigData(ModName);
        }

        // Token: 0x04000011 RID: 17
        private string ModName;

        // Token: 0x04000012 RID: 18
        public ModConfigData ModData;

    }
}
