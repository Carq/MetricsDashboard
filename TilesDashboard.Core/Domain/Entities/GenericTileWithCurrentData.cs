﻿using System.Collections.Generic;
using Dawn;
using TilesDashboard.Core.Domain.Enums;
using TilesDashboard.Core.Storage.Entities;
using TilesDashboard.Handy.Extensions;

namespace TilesDashboard.Core.Domain.Entities
{
    public class GenericTileWithCurrentData
    {
        public GenericTileWithCurrentData(string name, TileType type, IList<TileData> data, object configuration = null)
        {
            Name = Guard.Argument(name, nameof(name)).NotNull().NotEmpty();
            Type = Guard.Argument(type, nameof(type)).NotDefault();
            Data.AddRange(data);
            Configuration = configuration;
        }

        public string Name { get; private set; }

        public TileType Type { get; private set; }

        public object Configuration { get; private set; }

        public IList<TileData> Data { get; private set; } = new List<TileData>();
    }
}
