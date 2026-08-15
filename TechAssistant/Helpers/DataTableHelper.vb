Imports System.Data

Public NotInheritable Class DataTableHelper

    Private Sub New()
    End Sub

    Public Shared Function PivotSingleRowToList(
        sourceTable As DataTable) As DataTable

        Dim result As New DataTable

        result.Columns.Add("Name")
        result.Columns.Add("Value")

        If sourceTable.Rows.Count = 0 Then
            Return result
        End If

        Dim sourceRow =
            sourceTable.Rows(0)

        For Each column As DataColumn In sourceTable.Columns

            result.Rows.Add(
                column.ColumnName,
                If(
                    sourceRow.IsNull(column),
                    String.Empty,
                    sourceRow(column).ToString()))

        Next

        Return result

    End Function

End Class