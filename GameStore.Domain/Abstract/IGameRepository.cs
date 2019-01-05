using System;
using System.Collections.Generic;
using GameStore.Domain.Entities;

namespace GameStore.Domain.Abstract
{
    public interface IGameRepository
    {
        IEquatable<Game> Games { get; }
    }
}
