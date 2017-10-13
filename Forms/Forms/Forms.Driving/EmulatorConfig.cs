using Forms.Driving.Data;

namespace Forms.Driving
{
    public class EmulatorConfig
    {
        public string ApiAuthority { get; set; } = "http://dev.inbest.pro";

        public string ApiAuthorityEmulator { get; set; } = "http://emulator.dev.inbest.pro";

        public string Phone { get; set; } = "79032006482";

        public string Password { get; set; } = "123";

        public Location CenterLocation => new Location(55.6818, 37.5164);

    }
}
