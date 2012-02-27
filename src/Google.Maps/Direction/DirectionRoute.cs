﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Google.Api.Maps.Service.Direction
{
    [JsonObject(MemberSerialization.OptIn)]
    public class DirectionRoute
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("legs")]
        public DirectionLeg[] Legs { get; set; }

        [JsonProperty("copyrights")]
        public string Copyrights { get; set; }

        [JsonProperty("overview_polyline")]
        public Polyline OverviewPolyline { get; set; }
    }
}