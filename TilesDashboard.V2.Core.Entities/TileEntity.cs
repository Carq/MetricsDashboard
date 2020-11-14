﻿using System.Collections.Generic;

namespace TilesDashboard.V2.Core.Entities
{
    public class TileEntity
    {
        public string Id { get; private set; }

        public TileId TileId { get; private set; }

        protected Dictionary<string, object> TileConfiguration { get; private set; }
    }
}
