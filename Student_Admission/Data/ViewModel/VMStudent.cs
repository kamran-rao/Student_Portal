﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Student_Admission.Models;

namespace Student_Admission.Data.ViewModel
{
    public class VMStudent
    {
        public AdmissionForm AdmissionForrm { get; set; }
        [ValidateNever]

        
        public IEnumerable<AdmissionForm> MyList { get; set;}
    }
}
