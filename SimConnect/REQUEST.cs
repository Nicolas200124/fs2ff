// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace fs2ff.SimConnect
{
    public enum REQUEST : uint
    {
        Undefined,
        Position,
        Attitude,
        AGLAltitude,
        TrafficAircraft,
        TrafficHelicopter,
        TrafficObjectBase = 0x01000000
    }
}
