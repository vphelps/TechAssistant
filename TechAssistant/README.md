# TechAssistant

TechAssistant is a Windows utility application for gathering diagnostics, configuration information, and operational statistics from CenterEdge / Advantage environments.

## Current Features

### System Info

Displays workstation and environment information including:

- Computer information
- Operating system information
- Network information
- Advantage information
- Database information

### CE Db Info

Displays configuration data from the CenterEdge database.

#### Application Information

Displays configuration values from the ApplicationInfo table.

#### Application Options

Displays application settings from AppOptions.

#### Web Options

Displays website and portal configuration settings.

### Database Analytics

Provides visibility into database growth and storage utilization.

#### Database Table Sizes

Displays:

- Table name
- Row counts
- Table size information

#### Database Growth by Day

Displays database size information collected over time to help identify growth patterns.

### Grid Export

All DataGridViews support:

- Copy Cell
- Copy Row for Excel / Google Sheets
- Copy Row as CSV
- Copy All for Excel / Google Sheets
- Copy All as CSV

Export functions exclude section header rows.

### User Settings

User preferences are stored as JSON in:

```text
%APPDATA%\TechAssistant\options.json
```

Current settings include:

- Window title
- Window position
- Window size
- Window state
- Preferred export format
- Last database server

### Context Sensitive Hints

Each tab provides usage guidance and tips through the Quick Tips panel.

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

## Future Features

### Database Analytics

- Database size
- Database activity
- Index statistics
- Connection statistics

### Services

- Service status
- Service validation
- Service restart operations

### Reporting

- CSV export
- Report generation
- Dashboard views