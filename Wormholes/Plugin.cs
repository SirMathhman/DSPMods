using System;
using System.Collections.Generic;
using BepInEx;

namespace Wormholes
{
    [BepInPlugin("Wormholes", "Wormholes", "0.0")]
    internal class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            Logger.LogInfo("Wormholes loading...");

            var itemsProperty = typeof(LDB).GetProperty("items");
            if (itemsProperty == null) return;
            
            var itemSet = (ItemProtoSet)itemsProperty.GetValue(null);
            var items = new List<ItemProto>(itemSet.dataArray);
            Logger.LogInfo(items.Count + " items in default game.");

            var item = new ItemProto();
            items.Add(item);
            itemSet.dataArray = items.ToArray();
            
            itemsProperty.SetValue(null, itemSet);
            Logger.LogInfo(LDB.items.Length + " items present in modded game.");
        }
    }
}