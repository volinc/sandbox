using EF6Test.Data;
using EF6Test.Domain;
using System;
using System.Linq;

namespace EF6Test.Repositories
{
    public class ShiftRepository
    {
        private readonly Func<DateTimeOffset> now;
        private readonly ApplicationDbContext dbContext;

        public ShiftRepository(ApplicationDbContext dbContext, Func<DateTimeOffset> now)
        {
            this.dbContext = dbContext;
            this.now = now;
        }

        public Guid Create(Guid vehicleId, long driverId)
        {
            // ТС не доступно или не существует
            var vehicleData = dbContext.DriverVehicles.SingleOrDefault(x => x.VehicleId == vehicleId && x.DriverId == driverId);
            if (vehicleData == null)
                throw new InvalidOperationException();
            
            // Водитель находится в смене
            var currentShiftData = dbContext.Shifts.SingleOrDefault(x => x.DriverId == driverId && !x.ClosedAt.HasValue);
            if (currentShiftData != null)
                throw new InvalidOperationException();
            
            // ТС находится в смене
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

            dbContext.SaveChanges();

            return shiftData.Id;
        }
    }
}
