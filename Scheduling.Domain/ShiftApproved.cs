namespace Scheduling.Domain
{
    public class ShiftApproved : IDomainEvent
    {
        public ShiftApproved(ShiftId id)
        {
            AggregateId = id;
        }

        public ShiftId AggregateId { get; set; }
    }
}