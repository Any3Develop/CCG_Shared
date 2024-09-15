﻿using CCG.Shared.Abstractions.Game.Runtime.Objects;

namespace CCG.Shared.Abstractions.Game.Collections
{
    public interface IObjectsCollection : IRuntimeCollection<IRuntimeObject>
    {
        int GetOccupiedTableSpace(string ownerId);
    }
}