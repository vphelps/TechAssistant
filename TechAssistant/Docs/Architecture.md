# Architecture

## Application Overview

TechAssistant is a WinForms application focused on diagnosing and analyzing CenterEdge / Advantage environments.

The application is separated into:

- Forms
- Models
- Helpers
- Services

---

# Forms

## FormMain

Main application window.

Contains:

### System Info

Displays workstation and environment information.

### CE Db Info

Displays database configuration information.

### Database Analytics

Reserved for database reporting and statistics features.

---

# Models

## AppOptions

Stores user preferences.

Examples:

- Window Size
- Window Position
- Export Preferences

## ApplicationState

Stores application-wide runtime state.

Examples:

- Loaded AppOptions

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

- Skips section header rows
- Supports tab-delimited export
- Supports CSV export

---

## MessageHelper

Standardized application messages.

### Message Types

- Information
- Warning
- Error
- Question

---

## OptionsManager

Loads and saves application settings.

Storage:

%APPDATA%\TechAssistant\options.json

---

# Services

## DatabaseService

Handles SQL Server interaction.

### Functions

- ExecuteScalar()
- ExecuteNonQuery()
- GetDataTable()
- TestConnection()

---

## SystemInfo

Builds system information datasets.

Information includes:

- Computer
- Hardware
- Operating System
- Network
- Database
- Advantage

---

# Resources

## Resources.resx

Embedded application resources.

Examples:

- Context menu icons
- Application images