﻿using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades.Tbl
{
    public partial class Personal
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double? PayRate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
