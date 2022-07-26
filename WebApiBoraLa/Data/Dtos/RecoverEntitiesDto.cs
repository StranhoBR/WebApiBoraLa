﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationServicesSO.Data.Dtos
{
    public class RecoverEntitiesDto
    {
        [Key]
        [Required]
        public int key { get; set; }
        public string Org { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ReportName { get; set; }
        
    }
}
