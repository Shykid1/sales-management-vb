# Sales Management System

A modern Windows Forms application for managing sales, customers, staff, and generating reports. The system features a clean, modern UI with dark/light mode support and comprehensive data export capabilities.

## Features
- Modern UI with light/dark mode support
- Sales management and tracking
- Customer management
- Staff management
- Comprehensive reporting
- Data export (Excel and JSON formats)
- Dashboard with key metrics
- Recent sales tracking

## Team Members and Contributions

### Group Leader
**Student ID: 20230410030**
- Project architecture and planning
- Core system design and implementation
- UI/UX design and modernization
- Data model implementation
- Export functionality (Excel/JSON)
- Dark/light mode implementation
- Project documentation

### Team Members

**Student ID: 20220404164**
- Customer management implementation
- Form validations
- UI testing and bug fixes
- Data export features support

**Student ID: 20220412007**
- Staff management implementation
- Data service implementation
- Error handling
- Form design support

**Student ID: 20210412117**
- Sales reporting functionality
- DataGridView implementations
- Data visualization
- Testing and quality assurance

**Student ID: 20220412227**
- Sales entry form implementation
- Database integration support
- Form styling and consistency
- Documentation support

## Technical Details
- Language: Visual Basic .NET
- Framework: .NET 9.0
- UI Framework: Windows Forms
- External Libraries:
  - FontAwesome.Sharp (Modern icons)
  - ClosedXML (Excel export)
  - System.Text.Json (JSON handling)

## Development Tools
- Visual Studio 2022
- Git for version control
- NuGet package manager

## Data Storage
The application uses JSON files for data storage, located in the "Data" directory under the application's startup path. For a clean project submission:

1. Delete or clear the following files in the Data directory (if they exist):
   - Customers.json
   - Sales.json
   - Staff.json
   - SaleItems.json

2. When the application starts for the first time, it will automatically create these files as needed with empty data sets.

