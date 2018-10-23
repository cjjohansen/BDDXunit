using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using Xunit;
using FluentAssertions;
using NodaTime;
using xBehave.Tests;
using Xbehave;
using Xunit.Abstractions;

namespace Scheduling.Domain.Specs
{
    // In order to build complicated widgets
    // As a widget builder
    // I want a calculator for performing basic arithmetic
    public class ShiftFeatures
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ShiftFeatures(ITestOutputHelper output)
        {
            _testOutputHelper = output;
        }


        //        [Background]
        //        public void background()
        //        {
        //            "Given employee is member of department".x(()=>{});
        //            "And employee is manager".x(()=>{});
        //        }
        //        

        public class ShiftTestData : TheoryData<ShiftId, LocalDate>
        {
            public ShiftTestData()
            {
                Add(new ShiftId(1), new LocalDate(2017, 3, 11));
                Add(new ShiftId(2), new LocalDate(2017, 3, 12));
                Add(new ShiftId(3), new LocalDate(2017, 3, 13));
            }
        }

        [Scenario]
        [ClassData(typeof(ShiftTestData))]
        public void creating_a_shift(ShiftId shiftId, LocalDate date)
        {
            Shift result = null;

            $"Given shiftId is {shiftId}".x(() => { });

            $"And date is {date}".x(() => { });

            $"When creating a shift with {nameof(shiftId)} and {nameof(date)}"
                .x(() => result = new Shift(shiftId, date));

            $"Then the shift should have Id equal to {shiftId} "
                .x(() => result.Id.Should().Be(shiftId));
            $"And the shift should have OpeningDate equal to {date.ToString()}"
                .x(() => result.OpeningDate.Should().Be(date));
        }

        [Scenario]
        [ClassData(typeof(ShiftTestData))]
        public void approving_a_shift(ShiftId shiftId, LocalDate date, Shift aShift)
        {
            "Given an unapproved shift".x(() =>
            {
                var fixture = new Fixture();
                fixture.Customizations.Add(new ShiftIdArg(shiftId));

                fixture.Customizations.Add(new LocalDateArg(date));

                aShift = fixture.Build<Shift>().Create();
                aShift.IsApproved.Should().BeFalse();
            });

            "When approving the shift"
                .x(() => aShift.Approve());

            $"Then the shift should be approved"
                .x(() => aShift.IsApproved.Should().Be(true));
            $"And a ShiftApproved event should be raised"
                .x(() => aShift.RaisedEvents.Should().ContainSingle(x => x.GetType() == typeof(ShiftApproved)));
        }

    }
}
