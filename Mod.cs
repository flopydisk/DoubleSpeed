using PulsarModLoader;

namespace DoubleSpeed
{
    public class Mod : PulsarMod
    {
        public override string Version => "0.1";
        public override string Author => "FloppyDisk";
        public override string Name => "DoubleSpeed";
        public override string HarmonyIdentifier() => $"{Author}.{Name}";
        public override string ShortDescription => "Doubles Speed";
        public override string LongDescription => "Licence: GPL 3.0-only";
    }
}
