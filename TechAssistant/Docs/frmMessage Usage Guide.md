# frmMessage Usage Guide

## Overview

TechAssistant uses `frmMessage` as the standard dialog for displaying:

- Information messages
- Warning messages
- Error messages
- Questions requiring user input

Developers should use the methods in `MessageHelper` instead of creating `frmMessage` instances directly.

---

# Information Messages

Use for:

- Successful operations
- Status notifications
- User guidance

Example:

```vb
MessageHelper.ShowInfo(
    "Settings saved successfully.")
```

Custom title:

```vb
MessageHelper.ShowInfo(
    "Database refresh completed.",
    "Refresh Complete")
```

---

# Warning Messages

Use for:

- Missing optional files
- Missing applications
- Conditions that do not prevent execution

Example:

```vb
MessageHelper.ShowWarning(
    "Advantage Manager was not found.")
```

Custom title:

```vb
MessageHelper.ShowWarning(
    "No records were returned.",
    "Data Warning")
```

---

# Error Messages

Use for:

- Failed operations
- Exceptions
- Required files or resources not found

Example:

```vb
MessageHelper.ShowError(
    "Unable to connect to SQL Server.")
```

Custom title:

```vb
MessageHelper.ShowError(
    ex.Message,
    "Database Error")
```

---

# Question Messages

Use when user confirmation is required.

Returns:

```vb
DialogResult
```

Example:

```vb
If MessageHelper.ShowQuestion(
    "Refresh database statistics?") = DialogResult.Yes Then

    RefreshStatistics()

End If
```

Custom title:

```vb
If MessageHelper.ShowQuestion(
    "Exit TechAssistant?",
    "Confirm Exit") = DialogResult.Yes Then

    Me.Close()

End If
```

---

# Button Behavior

## ShowInfo

Displays:

```text
OK
```

Returns:

```vb
DialogResult.OK
```

---

## ShowWarning

Displays:

```text
OK
```

Returns:

```vb
DialogResult.OK
```

---

## ShowError

Displays:

```text
OK
```

Returns:

```vb
DialogResult.OK
```

---

## ShowQuestion

Displays:

```text
Yes
No
```

Returns:

```vb
DialogResult.Yes
```

or

```vb
DialogResult.No
```

---

# Message Types

## Information

Uses:

```vb
SystemIcons.Information
```

Recommended examples:

- Settings saved.
- Export completed.
- Data refresh completed.

---

## Warning

Uses:

```vb
SystemIcons.Warning
```

Recommended examples:

- Application not installed.
- No records found.
- Feature unavailable.

---

## Error

Uses:

```vb
SystemIcons.Error
```

Recommended examples:

- Database connection failed.
- Unable to save settings.
- Required file missing.

---

## Question

Uses:

```vb
SystemIcons.Question
```

Recommended examples:

- Continue?
- Delete item?
- Exit application?

---

# Recommended Standards

## Good Messages

```text
Settings saved successfully.
```

```text
Unable to connect to SQL Server.
```

```text
Advantage Manager is not installed.
```

---

## Avoid

```text
Operation completed.
```

```text
Error occurred.
```

```text
Failure.
```

Always try to tell the user:

- What happened
- What failed
- What action is needed

---

# Developer Rule

Use:

```vb
MessageHelper.ShowInfo()
MessageHelper.ShowWarning()
MessageHelper.ShowError()
MessageHelper.ShowQuestion()
```

Do not use:

```vb
MessageBox.Show(...)
```

unless there is a specific requirement that cannot be handled by `frmMessage`.

This ensures a consistent look and behavior throughout TechAssistant.