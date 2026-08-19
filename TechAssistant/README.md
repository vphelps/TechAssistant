# TechAssistant

TechAssistant is a Windows utility application for diagnostics, configuration review, database analytics, service management, and operational support for CenterEdge / Advantage environments.

## Current Features

### System Info

Displays workstation and environment information including:

- Computer information
- Operating system information
- Network information
- Advantage information
- Database information

---

### CE Db Info

Displays configuration information from the CenterEdge database.

#### Application Information

Displays values from ApplicationInfo.

#### Application Options

Displays values from AppOptions.

#### Web Options

Displays website and portal configuration information.

---

### Database Analytics

Provides database reporting and analytical information.

#### Database Table Sizes

Displays:

- Table names
- Row counts
- Table size information

#### Database Growth By Day

Displays database growth statistics over time.

---

### Services

Provides management and monitoring of Advantage and SQL Server services.

#### Supported Advantage Services

- AdvApiServer
- AdvCoreService
- AdvantageCloudSyncService
- AdvCreditService
- AdvLicService
- AdvSignageService
- AdvTurnstileEngine
- AdvNotifyService
- AdvantageUpgradeService
- AdvRelayClient

#### Supported SQL Services

Automatically detects:

- MSSQLSERVER
- MSSQL$<InstanceName>
- SQLSERVERAGENT
- SQLAgent$<InstanceName>

#### Features

- Display service status
- Start services
- Stop services
- Restart services
- Multi-service selection
- Service status auto-refresh
- Status color coding
- Progress tracking during operations
- Selection restoration after operations complete
- Per-service error handling
- Batch operation processing
- Administrative privilege detection

#### Service Status Colors

| Status | Color |
|----------|----------|
| Running | Green |
| Stopped | Red |
| Paused | Yellow |
| Other States | Gray |

#### Multi-Service Operations

Multiple services may be selected and processed simultaneously.

Supported operations:

- Start
- Stop
- Restart

#### Real-Time Status Monitoring

When service operations are running:

- Service statuses refresh automatically
- Status colors update automatically
- Current service states are displayed live
- Transitional states are visible

Examples:

```text
StartPending
StopPending
PausePending
ContinuePending
```

#### Progress Tracking

During service operations:

- Service list automatically refreshes
- Current operation progress is displayed
- Current service name is displayed
- Completed count is displayed

Example:

```text
Processing (2 of 5): AdvNotifyService
```

#### Selection Preservation

When service operations begin:

1. Current selections are saved.
2. Grid selections are cleared.
3. Service operations execute.
4. Statuses continue updating.
5. Original selections are restored when processing completes.

#### Service Processing

Selected services are processed sequentially.

Example:

```text
AdvApiServer
AdvCoreService
AdvNotifyService
AdvRelayClient
```

#### Timeout Handling

Service state changes are monitored using active polling instead of fixed delays.

Each operation waits for the service to reach the expected state:

```text
Running
Stopped
```

Operations timeout after:

```text
2 minutes
```

if the expected state is not reached.

#### Error Handling

Each service is processed independently.

Example:

```text
AdvApiServer       Success
AdvCoreService     Success
AdvNotifyService   Failed
AdvRelayClient     Success
```

A failure in one service does not prevent remaining selected services from being processed.

Failures are summarized and displayed after processing completes.

#### Administrative Privileges

Service management functionality requires Administrator privileges.

Administrator status is detected during startup and stored globally for use throughout the application.

---

### Utility Launchers

#### Advantage Utilities

Launch commonly used Advantage applications:

- Advantage Manager
- Point Of Sale
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
- Programs and Features
- Devices and Printers

Icons are automatically extracted from the associated executable when available.

---

### Grid Export

All DataGridViews support:

- Copy Cell
- Copy Row for Excel / Google Sheets
- Copy Row as CSV
- Copy All for Excel / Google Sheets
- Copy All as CSV

---

### Context-Sensitive Help

Each tab provides Quick Tips using the integrated help panel.

Help text automatically updates based on:

- Selected top-level tab
- Selected child tab

Features include:

- Grid-specific tips
- Custom help content
- Line-level bold emphasis
- Context-sensitive guidance

---

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

---

## Technologies

- VB.NET
- WinForms
- SQL Server
- .NET 10
- System.ServiceProcess
- JSON Configuration

---

## Project Goals

Provide a lightweight utility for:

- Environment diagnostics
- Database configuration review
- Database analytics
- Service management
- Operational troubleshooting
- Administrative support

---

## Usage Examples

### Review Environment Information

1. Open TechAssistant.
2. Select the **System Info** tab.
3. Review:

   - Computer information
   - Operating system information
   - Network configuration
   - Advantage information
   - Database information

This is useful when gathering information for troubleshooting or support cases.

---

### Review Application Configuration

1. Open **CE Db Info**.
2. Select one of the following tabs:

   - Application Information
   - Application Options
   - Web Options

3. Review the returned values.

Common uses:

- Confirming configuration changes
- Comparing settings between environments
- Validating deployment configurations

---

### Analyze Database Growth

1. Open **Database Analytics**.
2. Select **Database Growth By Day**.
3. Review historical database growth trends.

Common uses:

- Identifying abnormal database growth
- Planning storage requirements
- Monitoring growth after software changes

---

### Find Large Database Tables

1. Open **Database Table Sizes**.
2. Sort by:

   - Row Count
   - Table Size

3. Identify unusually large tables.

Common uses:

- Performance troubleshooting
- Disk space investigations
- Data cleanup planning

---

### Restart Multiple Advantage Services

1. Open the **Services** tab.
2. Select one or more services.
3. Click **Restart**.
4. Confirm the operation.

Example:

```text
AdvApiServer
AdvCoreService
AdvNotifyService
```

During processing:

```text
Processing (2 of 3): AdvCoreService
```

The service list automatically refreshes until all selected services have been processed.

---

### Start Stopped Services

1. Open the **Services** tab.
2. Select one or more stopped services.
3. Click **Start**.
4. Confirm the operation.

The service status updates automatically as services transition through states such as:

```text
StartPending
Running
```

---

### Stop Running Services

1. Open the **Services** tab.
2. Select one or more running services.
3. Click **Stop**.
4. Confirm the operation.

The service list will refresh automatically until the services reach:

```text
Stopped
```

---

### Export Grid Data to Excel

1. Right-click any grid row.
2. Select:

```text
Copy All for Excel / Google Sheets
```

3. Open Excel or Google Sheets.
4. Paste the data.

The clipboard is automatically formatted for spreadsheet import.

---

### Export Grid Data as CSV

1. Right-click a grid.
2. Choose:

```text
Copy All as CSV
```

3. Paste into:

   - Notepad
   - VS Code
   - Excel
   - Import utilities

---

### Launch Advantage Utilities

1. Open the **Utilities** tab.
2. Select an Advantage utility.

Examples:

```text
Advantage Manager
Point Of Sale
Advantage Groups
Advantage Redemption
```

The selected application launches directly from TechAssistant.

---

### Launch Windows Administrative Tools

1. Open the **Utilities** tab.
2. Select a Windows tool.

Examples:

```text
Services
Task Manager
Event Viewer
Calculator
```

This provides quick access to commonly used administrative tools.

---

### Review Context-Sensitive Help

1. Select any tab.
2. View the Help panel.

The displayed help automatically changes based on the active tab and provides:

- Feature descriptions
- Usage guidance
- Grid tips
- Administrative notes

Example:

```text
Advantage/SQL Services

• Shows the status of the Advantage/SQL services.
• Use buttons to Start, Stop, or Restart the services.

• Only available when running as an administrator.
```
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

### Service Management

- Service dependency visualization
- Service startup type display
- Service startup type modification
- Service operation history
- Service health dashboard
- Service filtering and search
- Service groups and favorites