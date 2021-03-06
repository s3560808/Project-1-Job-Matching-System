﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using iUni_Workshop.Models.JobRelatedModels;

namespace iUni_Workshop.Models.AdministratorModels
{
    public class UpdateField
    {
        [Required(ErrorMessage = "Field name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Correct Field Id is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter correct skill id")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Field status is required")]
        [Range(FieldStatus.InUse, FieldStatus.NoLongerUsed, ErrorMessage = "Please enter correct status for field")]
        public int Status { get; set; }
    }
}
