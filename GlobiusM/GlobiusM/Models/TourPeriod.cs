﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobiusM.Models
{
    public class TourPeriod
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}