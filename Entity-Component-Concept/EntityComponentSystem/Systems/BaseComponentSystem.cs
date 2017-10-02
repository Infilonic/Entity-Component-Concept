﻿using System;
using EntityComponentSystem.Base;
using EntityComponentSystem.Components;
using EntityComponentSystem.MessageChannels;
using EntityComponentSystem.MessageChannels.Messages;

namespace EntityComponentSystem.Systems
{
    /**
     * Use this class for all of your componentsystems
     */

    public abstract class BaseComponentSystem : BaseObserver, IComponentSystem
    {
        protected BaseComponentSystem() : base() {

        }

        public abstract void Update(IMessage message);
    }
}
