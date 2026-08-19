# Architecture

## Overview

TechAssistant is a WinForms-based utility application for diagnostics, configuration review, database analytics, service management, and operational support of CenterEdge / Advantage environments.

The application follows a lightweight layered architecture that separates:

- User Interface
- Application State
- Business Logic
- Data Access
- Utility Services

This approach keeps UI code focused on presentation while reusable functionality is implemented in helper classes.

---

## High-Level Architecture

```text
┌─────────────────────────────┐
│           UI Layer          │
│         FormMain            │
└─────────────┬───────────────┘
              │
              ▼
┌─────────────────────────────┐
│      Application Layer      │
│  ApplicationState           │
│  OptionsManager             │
│  ServiceHelper              │
│  SecurityHelper             │
│  ExportHelper               │
└─────────────┬───────────────┘
              │
              ▼
┌─────────────────────────────┐
│       Data Access Layer     │
│     SQL Server Database     │
└─────────────────────────────┘
```

---

## Project Organization

```text
Forms
│
├── FormMain.vb
├── FormMain.SystemInfo.vb
├── FormMain.Database.vb
├── FormMain.Services.vb
├── FormMain.Export.vb
├── FormMain.Hints.vb
└── FormMain.Utilities.vb

Helpers
│
├── ServiceHelper.vb
├── SecurityHelper.vb
├── ExportHelper.vb
├── MessageHelper.vb
├── UtilityLauncher.vb
└── Database Helpers

Models
│
├── AppOptions.vb
└── Other Data Models

Configuration
│
└── options.json
```

---

## User Interface Layer

### FormMain

FormMain serves as the central application shell.

Responsibilities include:

- Navigation
- Data presentation
- User interaction
- Service management UI
- Hint display
- Export operations

Feature logic is separated into partial classes to keep the codebase manageable.

```text
FormMain
├── System Information
├── Database Information
├── Services
├── Utilities
├── Export Functions
└── Help/Hints
```

---

## Application State

### ApplicationState

ApplicationState stores global information that is needed throughout the application.

Examples:

```vb
ApplicationState.Options
ApplicationState.RunningAsAdmin
```

The state is initialized during application startup and remains accessible throughout the lifetime of the application.

---

## Security

### SecurityHelper

SecurityHelper centralizes security-related checks.

Current responsibilities:

- Detecting elevated execution
- Determining administrative privileges

Example:

```vb
ApplicationState.RunningAsAdmin =
    SecurityHelper.IsRunningElevated()
```

This allows administrative features to be enabled or disabled consistently throughout the application.

---

## Configuration Management

User settings are stored as JSON.

Location:

```text
%APPDATA%\TechAssistant\options.json
```

Stored settings include:

- Window title
- Window size
- Window position
- Window state
- Last database server
- Preferred export format

Configuration is loaded during startup and persisted when changes occur.

---

## Database Information

The Database Information section retrieves and displays configuration values from SQL Server.

Supported areas:

### Application Information

Displays values from:

```text
ApplicationInfo
```

### Application Options

Displays values from:

```text
AppOptions
```

### Web Options

Displays:

- Website configuration
- Portal configuration
- Related web settings

---

## Database Analytics

Provides database reporting and analysis.

### Database Table Sizes

Displays:

- Table names
- Row counts
- Table sizes

### Database Growth By Day

Displays:

- Historical database growth
- Daily size changes
- Trend analysis information

All results are displayed using DataGridViews.

---

## Service Management

The Services module provides monitoring and control of Advantage and SQL services.

### Supported Services

#### Advantage Services

```text
AdvApiServer
AdvCoreService
AdvantageCloudSyncService
AdvCreditService
AdvLicService
AdvSignageService
AdvTurnstileEngine
AdvNotifyService
AdvantageUpgradeService
AdvRelayClient
```

#### SQL Services

Automatically detected:

```text
MSSQLSERVER
MSSQL$<InstanceName>
SQLSERVERAGENT
SQLAgent$<InstanceName>
```

---

### Service Discovery

Service discovery is performed through:

```vb
ServiceController.GetServices()
```

The resulting service collection is filtered to include only supported Advantage and SQL services.

---

### Service Operations

Supported operations:

```text
Start
Stop
Restart
```

Operations support:

- Single service selection
- Multiple service selection
- Batch processing

---

### Service Processing

Multiple selected services are processed sequentially.

Example:

```text
Service 1
Service 2
Service 3
Service 4
```

Each service is processed independently.

A failure in one service does not prevent processing of remaining services.

Example:

```text
AdvApiServer       Success
AdvCoreService     Success
AdvNotifyService   Failed
AdvRelayClient     Success
```

---

### Service Status Monitoring

Service status transitions are monitored actively.

Instead of relying on fixed delays, the application waits for services to reach expected states.

Examples:

```text
Running
Stopped
```

Transition states are also visible:

```text
StartPending
StopPending
PausePending
ContinuePending
```

Monitoring is implemented through:

```vb
ServiceController.Refresh()
```

combined with periodic status polling.

---

### Asynchronous Service Operations

Service operations execute on background worker threads using:

```vb
Task.Run()
```

Benefits:

- UI remains responsive
- Progress is displayed
- Service status continues refreshing
- Long-running operations do not freeze the application

---

### Real-Time Refresh

Service status updates are performed using:

```text
tmrServices
```

Responsibilities:

- Reload services
- Refresh statuses
- Update colors
- Update progress information

Refresh occurs while operations are actively running.

---

### Progress Tracking

During service operations the application displays progress information.

Example:

```text
Processing (2 of 5): AdvNotifyService
```

The display includes:

- Current service number
- Total selected services
- Current service name

---

### Selection Preservation

When a service operation begins:

1. Current selections are captured.
2. Selections are cleared.
3. Grid interaction is disabled.
4. Service operations execute.
5. Status updates continue.
6. Original selections are restored after completion.

This keeps the UI stable and prevents accidental user interaction during processing.

---

### Grid Locking During Operations

During service operations:

```text
DataGridView Disabled
Start Button Disabled
Stop Button Disabled
Restart Button Disabled
```

Benefits:

- Prevents conflicting operations
- Prevents selection changes
- Provides clear visual indication that processing is underway

Controls are automatically re-enabled when processing completes.

---

### Error Handling

Service operations use layered exception handling.

Failures are:

- Captured per service
- Collected into a failure list
- Reported after processing completes

Example:

```text
Some Services Failed

AdvNotifyService:
Service did not reach status 'Running' within 2 minutes.

AdvRelayClient:
Access denied.
```

---

## Utility Launchers

### Advantage Utilities

Launch supported Advantage applications:

```text
Advantage Manager
Point Of Sale
Advantage Groups
Advantage Redemption
Advantage Kiosk
Kiosk Setup
Advantage Report Editor
```

### Windows Utilities

Launch supported Windows tools:

```text
Calculator
Task Manager
Services
Event Viewer
Programs and Features
Devices and Printers
```

Application icons are automatically extracted when available.

---

## Grid Export Architecture

All DataGridViews share a common export framework.

Supported operations:

```text
Copy Cell
Copy Row
Copy Row As CSV
Copy All
Copy All As CSV
```

Excel-compatible clipboard formatting is supported.

---

## Context-Sensitive Help

The integrated hint system provides usage guidance for each tab.

Features include:

- Per-tab help content
- Automatic hint updates
- Grid-specific tips
- Line-level bold emphasis

Example:

```text
Advantage/SQL Services

• Shows the status of Advantage and SQL services.
• Use buttons to Start, Stop, or Restart services.

• Only available when running as an administrator.
```

Individual lines may be configured for emphasis through the hint metadata system.

---

## Technologies

```text
VB.NET
WinForms
.NET 10
SQL Server
System.ServiceProcess
JSON Configuration
```

---

## Design Goals

TechAssistant is designed to provide:

- Environment diagnostics
- Configuration review
- Database analysis
- Service management
- Operational troubleshooting
- Administrative support

while remaining:

- Lightweight
- Easy to deploy
- Easy to maintain
- Fast to use in production environments
- Familiar to Windows administrators