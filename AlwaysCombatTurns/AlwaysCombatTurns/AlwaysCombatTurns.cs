using Harmony;
using System.Reflection;

namespace AlwaysCombatTurns
{
    public class AlwaysCombatTurns
    {
        internal static string ModDirectory;
        public static void Init(string directory, string settingsJSON) {
            ModDirectory = directory;
            var harmony = HarmonyInstance.Create("de.morphyum.AlwaysCombatTurns");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
