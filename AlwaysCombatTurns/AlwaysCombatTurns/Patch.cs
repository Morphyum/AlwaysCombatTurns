using BattleTech;
using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AlwaysCombatTurns {

    [HarmonyPatch(typeof(EncounterLayerData))]
    [HarmonyPatch("ContractInitialize")]
    public static class EncounterLayerData_ContractInitialize_Patch {
        static void Prefix(EncounterLayerData __instance) {
            try {
                __instance.turnDirectorBehavior = TurnDirectorBehaviorType.AlwaysInterleaved;
            }
            catch (Exception e) {
            }
        }
    }
}