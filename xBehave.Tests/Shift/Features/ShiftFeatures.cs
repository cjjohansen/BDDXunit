using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using Xunit;
using FluentAssertions;
using NodaTime;
using xBehave.Tests;
using Xbehave;

namespace Scheduling.Domain.Specs
{
    public class ShiftFeatures
    {
        [Scenario]
        public void creating_a_shift(ShiftId shiftId, LocalDate date, Shift result)
        {
            "Given shiftId is 23".x(() => shiftId = 23);

            "And date is 2018-03-11".x(() => date = new LocalDate(2017, 3, 11));

            "When creating a shift with shiftId and date"
                .x(() => result = new Shift(shiftId, date));

            $"Then the shift should have Id equal to {shiftId} "
                .x(() => result.Id.Should().Be(shiftId));
            $"And the shift should have OpeningDate equal to {date}"
                .x(() => result.OpeningDate.Should().Be(date));
        }

        [Scenario]
        public void approving_a_shift(ShiftId shiftId, LocalDate date, Shift aShift)
        {
            "Given a shift with id 23".x(() =>
            {
                var fixture = new Fixture();
                fixture.Customizations.Add(new ShiftIdArg(23));

                fixture.Customizations.Add( new LocalDateArg(new LocalDate(2018,3,15) ) );


                aShift = fixture.Build<Shift>().Create();
            });


            "When approving a shift"
                .x(() => aShift.Approve());

            $"Then the shift should be approved "
                .x(() => aShift.IsApproved.Should().Be(true));
            $"And a ShiftApproved event should be raised"
                .x(() => aShift.RaisedEvents.Should().ContainSingle(x => x.GetType() == typeof(ShiftApproved)));
        }

    }
}
