using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InspectionAPI.Models
{
    public class Inspection
    {
        public int id { get; set; }
     
        [StringLength(20)]
        public string  status { get; set; } = string.Empty;
    
        [StringLength(200)]
        public string comments { get; set; }=string.Empty;

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idInspectionType { get; set; }

        public InspectionType? inspectionType{ get; set; }
    }
}
