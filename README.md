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