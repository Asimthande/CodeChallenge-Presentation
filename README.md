Save the following as `README.txt` inside your solution folder.

```txt
================================================================
README - Workshop Registration System
================================================================

Project Name:
Workshop Registration System

Architecture Used:
Multi-Tier Architecture
- Presentation Layer
- Business Logic Layer
- Data Access Layer

================================================================
1. HOW DOES THE DATA ACCESS LAYER SKIP INVALID CSV RECORDS?
================================================================

The Data Access Layer reads the CSV files line by line using
StreamReader.

Before a record is added into the system, several validation
checks are performed to ensure the data is correct and safe
to use.

The system skips records if:

- The line is empty
- The line has too many or too few fields
- Capacity is missing or not numeric
- Capacity is less than 1
- Workshop status is not "Open" or "Closed"
- Registration status is not "Active" or "Cancelled"
- Required fields are empty

All CSV reading logic is wrapped inside try-catch blocks.
If a record contains invalid or malformed data, the system
skips that record safely and continues processing the rest
of the file without crashing.

This improves the robustness and stability of the application.

================================================================
2. HOW DOES THE SYSTEM CALCULATE AVAILABLE WORKSHOP SPACES?
================================================================

The system calculates available workshop spaces using the
following formula:

Available Spaces = Capacity - Active Registrations

Process:
1. The system loads the workshop information
2. The workshop capacity is retrieved
3. All registrations are loaded
4. The system counts only registrations with:
   - Matching Workshop ID
   - Status = Active
5. The active registration count is subtracted from
   the workshop capacity

Example:
If a workshop capacity is 20 and there are 5 active
registrations:

20 - 5 = 15 available spaces

Cancelled registrations do not count toward capacity.

================================================================
3. HOW DOES THE SYSTEM PREVENT DUPLICATE REGISTRATIONS?
================================================================

Before creating a new registration, the system checks whether
the client already has an active registration for the same
workshop.

The system compares:
- Client Email
- Workshop ID
- Registration Status

Duplicate registration exists when:
- Email matches
- Workshop ID matches
- Status is Active

The email comparison is case-insensitive.

If a duplicate is found, the registration is rejected and
the system displays the message:

"Duplicate registration detected."

If the old registration was cancelled, the client is allowed
to register again.

================================================================
4. HOW DOES WORKSHOP ID AND REGISTRATION ID GENERATION WORK?
================================================================

The system automatically generates IDs for both workshops
and registrations.

WORKSHOP ID GENERATION:
- All workshops are loaded
- The numeric part of each ID is extracted
- Invalid IDs are ignored safely
- The highest number is found
- 1 is added to the highest number
- The new ID is formatted with leading zeros

Example:
W001
W002
W003

Next generated ID:
W004

REGISTRATION ID GENERATION:
The same process is used for registration IDs but with
the letter "R".

Example:
R001
R002
R003

Next generated ID:
R004

This ensures all IDs remain unique and correctly formatted.

================================================================
5. WHICH PART OF THE SOLUTION WAS THE MOST DIFFICULT?
================================================================

The most difficult parts of the project were:

1. Placeholder Hints in TextBoxes
Windows Forms does not provide built-in placeholder text
support like modern applications.

To solve this:
- Enter events were used to remove placeholder text
- Leave events were used to restore placeholder text
- Text colour changes were used to distinguish hints
  from actual user input

This logic had to be repeated carefully for multiple
text boxes.

2. Handling Invalid Workshop IDs
Some CSV records contained invalid IDs, extra spaces,
or lowercase letters.

To solve this:
- IDs were trimmed
- IDs were normalised to uppercase
- Validation checks were added
- Invalid IDs were skipped safely

This improved stability and prevented crashes during
ID generation and validation.

================================================================
END OF README
================================================================
