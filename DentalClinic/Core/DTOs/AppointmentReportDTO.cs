﻿using System;
using System.Collections.Generic;

namespace DTOs
{
    public class AppointmentReportDTO
    {
        public string CategoryName { get; set; }
        public string UserFullName { get; set; }
        public string PatientFullName { get; set; }
        public string ClinicName { get; set; }
        public DateTime Date { get; set; }
        public float TotalPrice { get; set; }
        public float DiscountPercentage { get; set; }
        public float PaidAmount { get; set; }
        public string StateName { get; set; }
    }
}
