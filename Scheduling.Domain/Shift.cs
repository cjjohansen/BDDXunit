using System.Collections.Generic;
using NodaTime;

namespace Scheduling.Domain
{
    public class Shift
    {
        protected Shift()
        {

        }

        public Shift( ShiftId id, LocalDate date )
        {
            Id = id;
            OpeningDate = date;
        }

        public LocalDate OpeningDate { get; }

        public ShiftId Id { get; }

        public void Approve()
        {
            this.IsApproved = true;
            Raise( new ShiftApproved( this.Id ) );
        }

        private void Raise( IDomainEvent @event )
        {
            RaisedEvents.Add( @event );
        }

        public ISet<IDomainEvent> RaisedEvents { get; private set; } = new HashSet<IDomainEvent>();

        public bool IsApproved { get; private set; }
    }

}
