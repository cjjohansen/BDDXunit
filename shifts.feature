
  
    
    

    Generated : 03/27/2018 18:36:06

    Scenario approving a shift
      Given an unapproved shift
      When approving the shift
      Then the shift should be approved
        And a ShiftApproved event should be raised

    Scenario creating a shift
      Given shiftId is 23
        And date is 2018-03-11
      When creating a shift with shiftId and date
      Then the shift should have Id equal to  
        And the shift should have OpeningDate equal to Monday, 1 January 0001

  
