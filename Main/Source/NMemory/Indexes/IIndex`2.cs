﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NMemory.Indexes
{
    public interface IIndex<TEntity, TKey> : IIndex<TEntity>
    {
        TKey Key(TEntity entity);

        IEnumerable<TEntity> Select(TKey value);

        IEnumerable<TEntity> Select(TKey from, TKey to, bool fromOpen, bool toOpen);

        IEnumerable<TEntity> SelectGreater(TKey from, bool open);

        IEnumerable<TEntity> SelectLess(TKey to, bool open);
    }
}
