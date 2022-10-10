using System;
using System.Collections.Generic;
using BepInEx;
using HarmonyLib;

namespace Wormholes
{
    [BepInPlugin("Wormholes", "Wormholes", "0.0")]
    internal class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            Logger.LogInfo("Wormholes loading...");
            
            var harmony = new Harmony(GetType().ToString());
            Logger.LogInfo("Wormholes loading...");
            var method = AccessTools.PropertyGetter(typeof(LDB), "items");
            Logger.LogInfo("Wormholes loading...");
            var postFix = SymbolExtensions.GetMethodInfo<ItemProtoSet>((value) => MyPostFix(ref value));
            Logger.LogInfo("Wormholes loading...");
            try
            {

                harmony.Patch(method, null, new HarmonyMethod(postFix));
            }
            catch (Exception e)
            {
                Logger.LogError(e);
                throw;
            }
            Logger.LogInfo("Wormholes loading...");
            
            Logger.LogInfo(LDB.items.Length + " items present in modded game.");
        }

        private void MyPostFix(ref ItemProtoSet __result)
        {
            Logger.LogInfo("MyPostFix");
            __result.Init(__result.Length + 1);
            Logger.LogInfo("MyPostFix");
            __result[__result.Length] = new ItemProto();
            Logger.LogInfo("MyPostFix");
        }
    }
}