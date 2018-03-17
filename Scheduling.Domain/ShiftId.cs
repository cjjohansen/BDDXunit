using System;
using System.Collections.Generic;
using Value;

namespace Scheduling.Domain
{
    public class ShiftId : ValueType<ShiftId>
    {
        private readonly long id;

        public long Id => id;

        public ShiftId(long id)
        {
            if (id < 1)
            {
                throw new ArgumentException(" id must be greater than 0", nameof(id));
            }

            this.id = id;
        }

        protected override IEnumerable<object> GetAllAttributesToBeUsedForEquality()
        {
            return new List<object>() { this.id };
        }

        public static implicit operator ShiftId(long id)
        {
            return new ShiftId(id);
        }

        public static implicit operator long( ShiftId id )
        {
            return id.Id;
        }
    }
}