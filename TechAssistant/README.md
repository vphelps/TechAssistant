# TechAssistant

TechAssistant is a Windows utility application for diagnostics, configuration review, database analytics, and operational support for CenterEdge / Advantage environments.

## Current Features

### System Info

Displays workstation and environment information including:

- Computer information
- Operating system information
- Network information
- Advantage information
- Database information

### CE Db Info

Displays configuration information from the CenterEdge database.

#### Application Information

Displays values from ApplicationInfo.

#### Application Options

Displays values from AppOptions.

#### Web Options

Displays website and portal configuration information.

### Database Analytics

Provides database reporting and analytical information.

#### Database Table Sizes

Displays:

- Table names
- Row counts
- Table size information

#### Database Growth By Day

Displays database growth statistics over time.

### Utility Launchers

#### Advantage Utilities

Launch commonly used Advantage applications:

- Advantage Manager
- Point of Sale
- Advantage Groups
- Advantage Redemption
- Advantage Kiosk
- Kiosk Setup
- Advantage Report Editor

#### Windows Utilities

Launch commonly used Windows administration tools:

- Calculator
- Task Manager
- Services
- Event Viewer

Icons are automatically extracted from the associated executable when available.

### Grid Export

All DataGridViews support:

- Copy Cell
- Copy Row for Excel / Google Sheets
- Copy Row as CSV
- Copy All for Excel / Google Sheets
- Copy All as CSV

### Context-Sensitive Help

Each tab provides Quick Tips using the integrated help panel.

Help text automatically updates based on:

- Selected top-level tab
- Selected child tab

### User Settings

Settings are stored in:

```text
%APPDATA%\TechAssistant\options.json
```

Current settings include:

- Window Title
- Window Position
- Window Size
- Window State
- Last Database Server
- Preferred Export Format

## Technologies

- VB.NET
- WinForms
- SQL Server
- .NET 10

## Project Goals

Provide a lightweight utility for:

- Environment diagnostics
- Database configuration review
- Database analytics
- Operational troubleshooting
- Administrative support

## Planned Features

### Database Analytics

- Database Size
- Database Activity
- Index Statistics
- Connection Statistics

### Windows Tools

- Device Manager
- Computer Management
- Registry Editor
- PowerShell

### Reporting

- CSV Export
- Report Generation
- Dashboard Views

### Configuration

- Additional User Preferences
- Saved Layouts
- Export Options