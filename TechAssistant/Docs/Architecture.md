# Architecture

## Application Overview

TechAssistant is a WinForms application focused on diagnostics, configuration review, and database analytics for CenterEdge / Advantage environments.

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

Displays CenterEdge configuration data.

Child tabs:

- Application Information
- Application Options
- Web Options

### Database Analytics

Displays historical and analytical database information.

Child tabs:

- Database Table Sizes
- Database Growth by Day

---

# Models

## AppOptions

Stores persisted user preferences.

Current settings:

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

- Loaded application options

---

# Helpers

## DataTableHelper

Utility methods for DataTable manipulation.

### Functions

- PivotSingleRowToList()

---

## GridContextMenuHelper

Provides DataGridView context menu functionality.

### Features

- Copy Cell
- Copy Row for Excel / Google Sheets
- Copy Row as CSV
- Copy All for Excel / Google Sheets
- Copy All as CSV

### Export Behavior

- Excludes section headers
- Supports CSV formatting
- Supports spreadsheet-compatible formatting

---

## MessageHelper

Provides standardized application messages.

### Message Types

- Information
- Warning
- Error
- Question

---

## OptionsManager

Loads and saves user settings.

Storage location:

```text
%APPDATA%\TechAssistant\options.json
```

Uses:

- JSON serialization
- Automatic option creation
- Automatic option loading

---

# Form Partials

## FormMain.Hints.vb

Responsible for:

- Hint initialization
- Context-sensitive help
- Quick Tips display
- RichTextBox formatting

---

# Services

## DatabaseService

Provides SQL Server interaction.

Typical operations:

- ExecuteScalar()
- ExecuteNonQuery()
- Retrieve DataTables
- Test database connectivity

---

## SystemInfo

Builds system-information datasets.

Information categories include:

- Computer
- Operating System
- Hardware
- Network
- Database
- Advantage

---

# Resources

## Resources.resx

Embedded resources used throughout the application.

Examples:

- Context menu icons
- Application images