using System.Reflection;
using HarmonyLib;
using Verse;

namespace DrugScheduleWhileWorking;

public class DrugScheduleWhileWorking : Mod
{
    public DrugScheduleWhileWorking(ModContentPack content) : base(content)
    {
        var harmony = new Harmony("com.arquebus.rimworld.mod.drugschedulewhilesorking");
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
}