namespace HexRomana.Engine
{
    public enum ESpecialization : byte
    {
        // no real need to differentiate between the 2 since a unit can only be one or the other
        Heavy = 1,
        HeavyInfantry = 1,
        HeavyCavalry = 1,

        Light = 2,
        LightInfantry = 2,
        LightCavalry = 2,

        Archer = 3,
        Scout = 4,
        Artillery = 5,
        Engineering = 6,
        Transport = 7,
    }
}
