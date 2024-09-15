﻿using CCG.Shared.Abstractions.Game.Runtime.Effects;

namespace CCG.Shared.Game.Events.Context.Effects
{
    public readonly struct BeforeEffectExecuteEvent
    {
        public IRuntimeEffect RuntimeEffect { get; }

        public BeforeEffectExecuteEvent(IRuntimeEffect runtimeEffect)
        {
            RuntimeEffect = runtimeEffect;
        }
    }
}