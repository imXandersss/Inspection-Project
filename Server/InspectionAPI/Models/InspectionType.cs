﻿using System.ComponentModel.DataAnnotations;

namespace InspectionAPI.Models
{
    public class InspectionType
    {
        public int id { get; set; }

        [StringLength(20)]
        public string inspectionName { get; set; }= string.Empty;
    }
}
