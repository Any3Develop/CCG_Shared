﻿using CCG.Shared.Abstractions.Game.Data;
using CCG.Shared.Game.Data.Enums;

namespace CCG.Shared.Game.Data
{
    public abstract class ObjectData : IData
    {
        public string Id { get; set; }
        public ObjectType Type { get; set; }
        public string Title { get; set; }
        public string ArtId { get; set; }
        public string[] StatIds { get; set; } = Array.Empty<string>();
        public string[] EffectIds { get; set; } = Array.Empty<string>();
    }
}