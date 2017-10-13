using Forms.Driving.Data;

namespace Forms.Driving
{
    public class EmulatorConfig
    {

#if DEBUG
        public string ApiAuthority { get; set; } = "http://localhost:57749";
        public string ApiAuthorityEmulator { get; set; } = "http://localhost:56433";
#else
        public string ApiAuthority { get; set; } = "http://dev.inbest.pro";
        public string ApiAuthorityEmulator { get; set; } = "http://emulator.dev.inbest.pro";
#endif

        public string Phone { get; set; } = "79991112233";

        public string Password { get; set; } = "123";

        public Location CenterLocation => new Location(55.6818, 37.5164);

    }
}
