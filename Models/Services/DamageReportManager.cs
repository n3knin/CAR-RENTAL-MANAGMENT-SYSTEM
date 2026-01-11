using System;
using RentalApp.DATA.Repositories;
using RentalApp.Models.Core;

namespace RentalApp.Models.Services
{
    public class DamageReportManager
    {
        private DamageReportRepository _damageRepository;

        public DamageReportManager()
        {
            _damageRepository = new DamageReportRepository();
        }

        public int AddReport(DamageReport report)
        {
            if (report.InspectionId <= 0)
            {
                throw new ArgumentException("Report must be linked to a valid Inspection ID.");
            }

            if (report.EstimatedCost < 0)
            {
                throw new ArgumentException("Estimated cost cannot be negative.");
            }

            return _damageRepository.Add(report);
        }

        public DamageReport GetReportForInspection(int inspectionId)
        {
            return _damageRepository.GetByInspectionId(inspectionId);
        }
    }
}
