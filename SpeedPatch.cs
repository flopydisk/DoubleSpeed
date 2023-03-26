using HarmonyLib;

namespace DoubleSpeed
{
    [HarmonyPatch(typeof(PLPlayerController), "HandleMovement")]
    internal class HandleMovement
    {
        private static void Prefix(PLPlayerController __instance)
        {
            if (__instance.MyPawn && __instance.MyPawn.GetPlayer() && __instance.MyPawn.GetPlayer().GetPlayerID() == PLNetworkManager.Instance.LocalPlayerID)
            {
                __instance.DefaultPawnSpeed = 8f;
                __instance.SprintPawnSpeed = 12f;
            }
        }
    }
}
