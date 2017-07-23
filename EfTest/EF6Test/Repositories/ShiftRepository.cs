using EF6Test.Data;
using EF6Test.Domain;
using System;
using System.Linq;

namespace EF6Test.Repositories
{
    public class ShiftRepository
    {
        private Func<DateTimeOffset> now;
        private readonly ApplicationDbContext dbContext;

        public ShiftRepository(ApplicationDbContext dbContext, Func<DateTimeOffset> now)
        {
            this.dbContext = dbContext;
        }

        public Guid Create(Guid vehicleId, long driverId)
        {
            var vehicleData = dbContext.Vehicles.SingleOrDefault(x => x.Id == vehicleId);
            if (vehicleData == null)
                throw new InvalidOperationException();

            var currentShiftData = dbContext.Shifts.SingleOrDefault(x => x.DriverId == driverId && !x.ClosedAt.HasValue);
            if (currentShiftData != null)
                throw new InvalidOperationException();
            
            currentShiftData = dbContext.Shifts.SingleOrDefault(x => x.VehicleId == vehicleId && !x.ClosedAt.HasValue);
            if (currentShiftData != null)
                throw new InvalidOperationException();

            var shiftData = dbContext.Shifts.Add(new ShiftData
            {
                VehicleId = vehicleId,
                DriverId = driverId,
                State = ShiftState.Pause,
                OpenedAt = now()
            });

            return shiftData.Id;
        }
    }
}
