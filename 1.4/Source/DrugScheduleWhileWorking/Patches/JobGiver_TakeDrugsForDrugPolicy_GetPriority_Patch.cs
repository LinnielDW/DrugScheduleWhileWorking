using HarmonyLib;
using RimWorld;

namespace DrugScheduleWhileWorking.Patches;

[HarmonyPatch(typeof(JobGiver_TakeDrugsForDrugPolicy), "GetPriority")]
public static class JobGiver_TakeDrugsForDrugPolicy_GetPriority_Patch
{
    static void Postfix(ref float __result)
    {
        if (__result > 0) //TODO: add settings here
        {
            __result = 9.1f;
        }
    }
}