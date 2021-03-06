// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Utilities;

namespace Microsoft.Data.Entity.Relational.Query
{
    public class CommandParameter
    {
        public CommandParameter([NotNull] string name, [NotNull] object value)
        {
            Check.NotNull(name, nameof(name));
            Check.NotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        public virtual string Name { get; }

        public virtual object Value { get; }
    }
}
