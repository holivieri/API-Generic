using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericAPI.APIDTOs
{
    public class PaginationDTO
    {
        public int recordsByPage { get; set; }
        public int currentPage { get; set; }

    }
}
