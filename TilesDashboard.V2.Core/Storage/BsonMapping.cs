﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Options;
using MongoDB.Bson.Serialization.Serializers;
using System.Collections.Generic;
using TilesDashboard.V2.Core.Entities;
using TilesDashboard.V2.Core.Entities.Enums;

namespace TilesDashboard.V2.Core.Storage
{
    public static class BsonMapping
    {
        public static void RegisterMappings()
        {
            BsonClassMap.RegisterClassMap<TileId>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty(c => c.Type).SetSerializer(new EnumSerializer<TileType>(BsonType.String));
            });

               BsonClassMap.RegisterClassMap<TileEntity>(cm =>
            {
                cm.AutoMap();
                cm.MapIdMember(x => x.Id).SetSerializer(new StringSerializer(BsonType.ObjectId));
                cm.MapProperty("TileConfiguration")
                                    .SetSerializer(new DictionaryInterfaceImplementerSerializer<Dictionary<string, object>>(DictionaryRepresentation.Document));
            });
        }
    }
}