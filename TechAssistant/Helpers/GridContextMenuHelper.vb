Imports System.Windows.Forms

Public NotInheritable Class GridContextMenuHelper

    Private Sub New()
    End Sub
    Private Class GridContextState

        Public Property ClickedCell As DataGridViewCell

    End Class
    Private Shared Function IsSectionHeader(
    row As DataGridViewRow) As Boolean

        If row.Cells.Count = 0 Then
            Return False
        End If

        Dim value As String =
        Convert.ToString(
            row.Cells(0).Value)

        Return Not String.IsNullOrWhiteSpace(value) AndAlso
           value.StartsWith("===")

    End Function
    Private Shared Function CsvEscape(
    value As String,
    delimiter As String) As String

        If String.IsNullOrEmpty(value) Then

            If delimiter = "," Then
                Return """"""
            End If

            Return String.Empty

        End If

        If delimiter = "," Then

            Return $"""{value.Replace("""", """""")}"""

        End If

        Return value

    End Function
    Public Shared Sub Attach(dgv As DataGridView)

        Dim state As New GridContextState()

        AddHandler dgv.CellMouseDown,
        Sub(sender, e)

            If e.Button <> MouseButtons.Right Then
                Exit Sub
            End If

            If e.RowIndex < 0 OrElse
               e.ColumnIndex < 0 Then
                Exit Sub
            End If

            dgv.ClearSelection()

            dgv.CurrentCell = dgv.Rows(e.RowIndex).Cells(e.ColumnIndex)

            dgv.Rows(e.RowIndex).Selected = True

            state.ClickedCell = dgv.Rows(e.RowIndex).Cells(e.ColumnIndex)

        End Sub

        Dim menu As New ContextMenuStrip()
        Dim copyCellItem As New ToolStripMenuItem("Copy Cell")
        Dim copyRowExcelItem As New ToolStripMenuItem("Copy Row (Copy for Excel or Google Sheets)")
        Dim copyRowCsvItem As New ToolStripMenuItem("Copy Row (Copy for CSV)")
        Dim copyAllExcelItem As New ToolStripMenuItem("Copy All (Copy for Excel or Google Sheets)")
        Dim copyAllCsvItem As New ToolStripMenuItem("Copy All (Copy for CSV)")

        copyCellItem.Image = TechAssistant.My.Resources.Resources.CopyIcon
        copyRowExcelItem.Image = TechAssistant.My.Resources.Resources.ExcelIcon
        copyRowCsvItem.Image = TechAssistant.My.Resources.Resources.CSVIcon
        copyAllExcelItem.Image = TechAssistant.My.Resources.Resources.ExcelIcon
        copyAllCsvItem.Image = TechAssistant.My.Resources.Resources.CSVIcon
        copyRowExcelItem.ToolTipText = "Copies the selected row using tab-delimited format."
        copyRowCsvItem.ToolTipText = "Copies the selected row using standard CSV format."
        copyAllExcelItem.ToolTipText = "Copies all rows for direct paste into Excel or Google Sheets."
        copyAllCsvItem.ToolTipText = "Copies all rows using standard CSV formatting."

        AddHandler menu.Opening,
    Sub(sender, e)

        Dim isHeader As Boolean =
            dgv.CurrentRow IsNot Nothing AndAlso
            IsSectionHeader(
                dgv.CurrentRow)

        copyCellItem.Enabled =
            Not isHeader

        copyRowExcelItem.Enabled =
            Not isHeader

        copyRowCsvItem.Enabled =
            Not isHeader

    End Sub


        AddHandler copyCellItem.Click,
        Sub()
            CopyCell(state)
        End Sub

        AddHandler copyRowExcelItem.Click,
    Sub()
        CopyRow(
            dgv,
            vbTab)
    End Sub

        AddHandler copyRowCsvItem.Click,
    Sub()
        CopyRow(
            dgv,
            ",")
    End Sub

        AddHandler copyAllExcelItem.Click,
            Sub()
                CopyAll(dgv, vbTab)
            End Sub

        AddHandler copyAllCsvItem.Click,
            Sub()
                CopyAll(dgv, ",")
            End Sub

        menu.Items.Add(copyCellItem)

        menu.Items.Add(New ToolStripSeparator())

        menu.Items.Add(copyRowExcelItem)
        menu.Items.Add(copyRowCsvItem)

        menu.Items.Add(New ToolStripSeparator())

        menu.Items.Add(copyAllExcelItem)
        menu.Items.Add(copyAllCsvItem)

        dgv.ContextMenuStrip = menu

    End Sub
    Private Shared Sub CopyCell(
    state As GridContextState)

        If state.ClickedCell Is Nothing Then
            Exit Sub
        End If

        If IsSectionHeader(
        state.ClickedCell.OwningRow) Then

            Exit Sub

        End If

        Clipboard.SetText(
        Convert.ToString(
            state.ClickedCell.Value))

    End Sub
    Private Shared Sub CopyRow(
    dgv As DataGridView,
    delimiter As String)

        If dgv.CurrentRow Is Nothing Then
            Exit Sub
        End If

        If IsSectionHeader(
        dgv.CurrentRow) Then
            Exit Sub
        End If

        Dim values As New List(Of String)

        For Each cell As DataGridViewCell In
        dgv.CurrentRow.Cells

            values.Add(
            CsvEscape(
                Convert.ToString(
                    cell.Value),
                delimiter))

        Next

        Clipboard.SetText(
        String.Join(
            delimiter,
            values))

    End Sub

    Private Shared Sub CopyAll(
    dgv As DataGridView,
    delimiter As String)

        Dim lines As New List(Of String)

        ' Headers
        Dim headers As New List(Of String)

        For Each col As DataGridViewColumn In dgv.Columns

            headers.Add(
            CsvEscape(
                col.HeaderText,
                delimiter))

        Next

        lines.Add(
        String.Join(
            delimiter,
            headers))

        ' Rows
        For Each row As DataGridViewRow In dgv.Rows

            If row.IsNewRow Then
                Continue For
            End If

            If IsSectionHeader(row) Then
                Continue For
            End If

            Dim values As New List(Of String)

            For Each cell As DataGridViewCell In row.Cells

                values.Add(
                CsvEscape(
                    Convert.ToString(cell.Value),
                    delimiter))

            Next

            lines.Add(
            String.Join(
                delimiter,
                values))

        Next

        Clipboard.SetText(
        String.Join(
            Environment.NewLine,
            lines))

    End Sub

End Class