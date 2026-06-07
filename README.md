# Password Reset Brute Force Application

## Assignment Objective

Create a WinForms application for password reset using brute force attack and multi-threading.

## Planned Features

- Password generation
- SHA256 hashing with static salt
- Single-thread brute force
- Multi-thread brute force
- Progress display
- Elapsed time display
- Found password display
- Performance comparison

## Classes

- Form1
- PasswordGenerator
- PasswordHasher
- PasswordValidator
- BruteForceGenerator
- BruteForceEngine
- PerformanceLogger

## Development History

### Version 1
- Created WinForms project
- Designed GUI
- Created class structure
- Created UML diagram

### Version 2
- Implemented PasswordGenerator class
- Added random password generation
- Password length set to 4–6 characters
- Connected Generate Password button
- Password displayed in GUI

### Version 3

- Implemented PasswordHasher class
- Added SHA256 hashing
- Added constant salt
- Implemented PasswordValidator class
- Password hash generated after password creation

### Version 4 

- Implemented BruteForceGenerator class
- Separated brute force generation from validation
- Prepared project for brute force search implementation

### Version 5

- Implemented BruteForceEngine
- Added recursive brute force attack
- Search starts from length 1
- Search continues up to length 6
- Password successfully recovered from SHA256 hash
- Updated UML diagram

### Version 6 (Final Version)

- Implemented MultiThreadBruteForceEngine
- Added Task-based multi-threading
- Used Environment.ProcessorCount - 1 workers
- Added automatic stopping when password is found
- Added PerformanceLogger class
- Added performance comparison between single-thread and multi-thread attacks
- Added progress bar updates
- Added elapsed time display
- Added Start Attack functionality
- Added Stop Attack functionality
- Added SHA256 hash display in GUI
- Added live timer updates during execution
- Updated UML diagram