﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastaMaestra.Models.DTOs.Auction
{
    public class AuctionSummaryDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public AuctionDTO? State { get; set; }
    }

}
