﻿// <copyright file="EnsageServiceContext.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Service
{
    using System;
    using System.Security;

    [SecuritySafeCritical]
    public sealed class EnsageServiceContext : IEnsageServiceContext
    {
        public EnsageServiceContext(Hero unit)
        {
            if (unit == null || !unit.IsValid)
            {
                throw new ArgumentNullException(nameof(unit));
            }

            this.Owner = unit;
        }

        public Unit Owner { get; }

        public bool Equals(Unit other)
        {
            return this.Owner.Equals(other);
        }
    }
}