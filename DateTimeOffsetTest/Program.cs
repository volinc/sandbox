namespace DateTimeOffsetTest
{
    using System;
    using System.Runtime.Serialization;

    internal class Program
    {
        private static void Main()
        {
            var bookedFor = DateTime.Parse("2019-12-17T05:30:00");
            var bookedFor2 = (DateTimeOffset)bookedFor;
            var bookedFor3 = new DateTimeOffset(bookedFor2.Year,
                                                bookedFor2.Month,
                                                bookedFor2.Day,
                                                bookedFor2.Hour,
                                                bookedFor2.Minute,
                                                bookedFor2.Second,
                                                TimeSpan.FromHours(3));

            var bookedFor4 = bookedFor3.ToOffset(TimeSpan.FromHours(3)).DateTime;

            Console.WriteLine(bookedFor);
            Console.WriteLine(bookedFor2);
            Console.WriteLine(bookedFor3);
            Console.WriteLine(bookedFor4);

            //const int onePointSize = sizeof(int) + 4 * sizeof(double) + 2 * sizeof(long);
            //var perMinuteSize = 15 * onePointSize;
            //var perHourSize = 60 * perMinuteSize;
            //Console.WriteLine(perHourSize * 3d / 1000000d);

            //var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //var maxLength = cultures.Select(x => x.TwoLetterISOLanguageName.Length).Max();

            //foreach (var culture in cultures)
            //{
            //    Console.WriteLine(culture.TwoLetterISOLanguageName);
            //}

            //var startAt = DateTimeOffset.Parse("2019-12-17 05:30:00.0000000 +03:00").ToUniversalTime();
            //var endAt = DateTimeOffset.Parse("2019-12-17 05:40:00.0000000 +03:00").ToUniversalTime();
            //var expiredAt = DateTimeOffset.Parse("2019-12-17 03:10:00.1139870 +00:00");

            //Console.WriteLine(startAt);
            //Console.WriteLine(endAt);
            //Console.WriteLine(expiredAt);

            //Console.WriteLine(startAt > expiredAt);
            //Console.WriteLine(endAt > expiredAt);
        }
    }

    [DataContract]
    public struct DriverLocation
    {
        [DataMember]
        public int? Index { get; set; }

        [DataMember]
        public double Latitude { get; set; }

        [DataMember]
        public double Longitude { get; set; }

        [DataMember]
        public DateTimeOffset Timestamp { get; set; }

        [DataMember]
        public double Speed { get; set; }

        [DataMember]
        public double Heading { get; set; }
    }
}
