 Behave Tests
=============

Scheduling Domain Specs Shift Features
--------------------------------------

### reating_a_shift

#### shiftId: 1, date: Saturday, 11 March 2017

- (Background) Given employee is member of department
- (Background) And employee is manager
- Given shiftId is 1
- And date is Saturday, 11 March 2017
- When creating a shift with shiftId and date
- Then the shift should have Id equal to 1 
- And the shift should have OpeningDate equal to Saturday, 11 March 2017

#### shiftId: 2, date: Sunday, 12 March 2017

- (Background) Given employee is member of department
- (Background) And employee is manager
- Given shiftId is 2
- And date is Sunday, 12 March 2017
- When creating a shift with shiftId and date
- Then the shift should have Id equal to 2 
- And the shift should have OpeningDate equal to Sunday, 12 March 2017

#### shiftId: 3, date: Monday, 13 March 2017

- (Background) Given employee is member of department
- (Background) And employee is manager
- Given shiftId is 3
- And date is Monday, 13 March 2017
- When creating a shift with shiftId and date
- Then the shift should have Id equal to 3 
- And the shift should have OpeningDate equal to Monday, 13 March 2017

### pproving_a_shift

#### shiftId: 1, date: Saturday, 11 March 2017, aShift: Shift { Id = 1, IsApproved = False, OpeningDate = Saturday, 11 March 2017, RaisedEvents = [] }

- (Background) Given employee is member of department
- (Background) And employee is manager
- Given an unapproved shift
- When approving the shift
- Then the shift should be approved
- And a ShiftApproved event should be raised

#### shiftId: 1, date: Sunday, 12 March 2017, aShift: Shift { Id = 2, IsApproved = False, OpeningDate = Sunday, 12 March 2017, RaisedEvents = [] }

- (Background) Given employee is member of department
- (Background) And employee is manager
- Given an unapproved shift
- When approving the shift
- Then the shift should be approved
- And a ShiftApproved event should be raised

#### shiftId: 1, date: Monday, 13 March 2017, aShift: Shift { Id = 3, IsApproved = False, OpeningDate = Monday, 13 March 2017, RaisedEvents = [] }

- (Background) Given employee is member of department
- (Background) And employee is manager
- Given an unapproved shift
- When approving the shift
- Then the shift should be approved
- And a ShiftApproved event should be raised
