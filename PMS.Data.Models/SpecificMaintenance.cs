using Microsoft.EntityFrameworkCore;
using PMS.Data.Models.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static PMS.Common.EntityValidationConstants.MaintenanceConstants;
using PMS.Data.Models.Enums;

namespace PMS.Data.Models
{
    public class SpecificMaintenance
    {
        public SpecificMaintenance()
        {
            this.SpecMaintId = Guid.NewGuid();
        }

        [Key]
        [Comment("Unique identifier of the RoutineMaintenance")]
        public Guid SpecMaintId { get; set; }

        [Required]
        [MaxLength(MaintenanceNameMaxLength)]
        [MinLength(MaintenanceNameMinLength)]
        [Comment("Name of the maintanance")]
        public string Name { get; set; } = null!;

        [MaxLength(MaintenanceDescriptionMaxLength)]
        [MinLength(MaintenanceDescriptionMinLength)]
        [Comment("Description of the maintenance")]
        public string? Description { get; set; }

        [Required]
        [Comment("Date when maintanance should be done")]
        public DateTime DueDate { get; set; }

        [Required]
        [Comment("Date when maintanance is completed")]
        public DateTime CompletedDate { get; set; }

        [Comment("Interval to do the maintanance")]
        public int Interval { get; set; }

        [Comment("Current status of the maintenance")]
        public Satus Satus { get; set; }

        [Comment("Condition of equipment after the job")]
        public ConditionAfter ConditionAfter { get; set; }

        [Comment("Is it postponed - the maintenance")]
        public bool IsPostponed { get; set; }

        public ICollection<Sparepart> Spareparts { get; set; } = new List<Sparepart>();

        [Required]
        [MaxLength(MaintenancePositionMaxLength)]
        [MinLength(MaintenancePositionMinLength)]
        [Comment("Position of the employee who did it")]
        public string EmployeePosition { get; set; } = null!;

        [Required]
        [MaxLength(MaintenanceNameMaxLength)]
        [MinLength(MaintenanceNameMinLength)]
        [Comment("Name of the employee who did it")]
        public string EmployeeName { get; set; }


        [Required]
        [Comment("Unique identifier of the equipment maintained")]
        public Guid EquipmentId { get; set; }

        [ForeignKey(nameof(EquipmentId))]
        public Equipment Equipment { get; set; } = null!;


        [Required]
        [Comment("Unique identifier of the creator of the maintenance")]
        public string CReatorId { get; set; } = null!;

        [ForeignKey(nameof(CReatorId))]
        public PMSUser Creator { get; set; } = null!;

        public bool IsDeleted { get; set; }

    }
   

}

