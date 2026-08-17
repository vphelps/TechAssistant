# Architecture

## Application Overview

TechAssistant is a WinForms application focused on diagnostics, administration, configuration review, and database analytics for CenterEdge / Advantage environments.

The application is organized into:

- Forms
- Models
- Helpers
- Services

---

# Forms

## FormMain

Main application window.

### System Info

Displays workstation and environment diagnostics.

### CE Db Info

Displays database configuration information.

Child tabs:

- Application Information
- Application Options
- Web Options

### Database Analytics

Displays database reporting and analytics.

Child tabs:

- Database Table Sizes
- Database Growth By Day

### Utility Launchers

Provides quick access to:

#### Advantage Utilities

- Advantage Manager
- Point of Sale
- Advantage Groups
- Advantage Redemption
- Advantage Kiosk
- Kiosk Setup
- Advantage Report Editor

#### Windows Utilities

- Calculator
- Task Manager
- Services
- Event Viewer

---

# Form Partials

## FormMain.Hints.vb

Responsible for:

- Quick Tips initialization
- Context-sensitive help
- RichTextBox formatting
- Tab-based hint selection

### Features

- Dictionary-based hint storage
- Shared grid export tip generation
- Automatic help updates

---

## FormMain.Icons.vb

Responsible for:

- Utility button initialization
- Icon extraction
- Tooltip assignment
- Advantage utility registration
- Windows utility registration

### Features

- ToolButtonDefinition model
- ToolCategory enumeration
- Automatic executable icon extraction
- Multiple tooltip categories

---

# Models

## AppOptions

Stores persisted user preferences.

### Application

- WindowTitle

### Main Window

- RememberWindowSize
- WindowLeft
- WindowTop
- WindowWidth
- WindowHeight
- WindowState

### Database

- LastDatabaseServer

### Export

- PreferredExportFormat

---

## ApplicationState

Provides application-wide runtime state.

Current usage:

- Loaded AppOptions instance

---

# Helpers

## DataTableHelper

Utility methods for DataTable manipulation.

### Functions

- PivotSingleRowToList()

---

## GridContextMenuHelper

Provides DataGridView export functionality.

### Features

- Copy Cell
- Copy Row for Excel
- Copy Row as CSV
- Copy All for Excel
- Copy All as CSV

### Export Behavior

- Excludes section header rows
- Supports spreadsheet-compatible export
- Supports CSV export

---

## MessageHelper

Provides standardized user messaging.

### Message Types

- Information
- Warning
- Error
- Question

---

## OptionsManager

Loads and saves user configuration.

Storage location:

```text
%APPDATA%\TechAssistant\options.json
```

### Responsibilities

- Create default options
- Load options
- Save options
- Validate option persistence

---

# Services

## DatabaseService

Provides database interaction.

Typical operations:

- ExecuteScalar()
- ExecuteNonQuery()
- Retrieve DataTables
- Test database connectivity

---

## SystemInfo

Builds datasets for:

- Computer Information
- Operating System Information
- Hardware Information
- Network Information
- Database Information
- Advantage Information

---

# Resources

## Resources.resx

Embedded application resources including:

- Context menu images
- Application images
- Future UI assets