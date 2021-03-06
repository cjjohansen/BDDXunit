
  
    
    

    Generated : 10/27/2018 01:07:04

    Scenario approving a shift
      }) [01] Given an unapproved shift
      }) [02] When approving the shift
      }) [03] Then the shift should be approved
      }) [04] And a ShiftApproved event should be raised
      }) [01] Given an unapproved shift
      }) [02] When approving the shift
      }) [03] Then the shift should be approved
      }) [04] And a ShiftApproved event should be raised
      }) [01] Given an unapproved shift
      }) [02] When approving the shift
      }) [03] Then the shift should be approved
      }) [04] And a ShiftApproved event should be raised

    Scenario creating a shift
      Given shiftId is 1
        And date is Saturday, 11 March 2017
      When creating a shift with shiftId and date
      Then the shift should have Id equal to 1 
        And the shift should have OpeningDate equal to Saturday, 11 March 2017
      Given shiftId is 2
        And date is Sunday, 12 March 2017
      When creating a shift with shiftId and date
      Then the shift should have Id equal to 2 
        And the shift should have OpeningDate equal to Sunday, 12 March 2017
      Given shiftId is 3
        And date is Monday, 13 March 2017
      When creating a shift with shiftId and date
      Then the shift should have Id equal to 3 
        And the shift should have OpeningDate equal to Monday, 13 March 2017

  
