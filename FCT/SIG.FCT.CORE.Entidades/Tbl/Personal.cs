using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class TblPersonal
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double? PayRate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
