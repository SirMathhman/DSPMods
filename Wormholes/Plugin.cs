using System;
using BepInEx;

namespace Wormholes
{
    [BepInPlugin("Wormholes", "Wormholes", "0.0")]
    internal class Plugin : BaseUnityPlugin
    {   
        public void Awake()
        {
            Logger.LogInfo("Wormholes loading...");
        }
    }
}