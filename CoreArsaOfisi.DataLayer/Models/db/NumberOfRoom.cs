﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CoreArsaOfisi.DataLayer.Models.db
{
    public partial class NumberOfRoom
    {
        public NumberOfRoom()
        {
            AdvertisementDetails = new HashSet<AdvertisementDetail>();
        }

        public int Id { get; set; }
        public string RoomName { get; set; }

        public virtual ICollection<AdvertisementDetail> AdvertisementDetails { get; set; }
    }
}
