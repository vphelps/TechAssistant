Public NotInheritable Class Queries

    Public Const GetAppOptionsTable As String =
        "SELECT *
         FROM AppOptions"
    Public Const GetWebOptionsTable As String =
        "SELECT *
         FROM WebOptions"
    Public Const GetApplicationInfoTable As String =
        "SELECT *
         FROM ApplicationInfo"

    Public Const UpdateAdminUnlockedUntil As String =
        "UPDATE AppOptions
         SET OptionValue = CONVERT(VARCHAR(24), DATEADD(DAY, 1, GETDATE()), 120) + 'Z'
         WHERE OptionName = @OptionName"
    Public Const GetDbTableSizes As String =
        "SELECT 
                t.NAME AS TableName,
                s.Name AS SchemaName,
                p.rows AS RowCounts,
                SUM(a.total_pages) * 8 AS TotalSpaceKB, 
                SUM(a.used_pages) * 8 AS UsedSpaceKB, 
                (SUM(a.total_pages) - SUM(a.used_pages)) * 8 AS UnusedSpaceKB
            FROM 
                sys.tables t
            INNER JOIN      
                sys.indexes i ON t.OBJECT_ID = i.object_id
            INNER JOIN 
                sys.partitions p ON i.object_id = p.OBJECT_ID AND i.index_id = p.index_id
            INNER JOIN 
                sys.allocation_units a ON p.partition_id = a.container_id
            LEFT OUTER JOIN 
                sys.schemas s ON t.schema_id = s.schema_id
            WHERE 
                t.is_ms_shipped = 0 AND i.OBJECT_ID > 255 
            GROUP BY 
                t.Name, s.Name, p.Rows
            ORDER BY 
                TotalSpaceKB DESC"
    Public Const GetDbGrowthByDay As String =
        "--Grouped by day:
DECLARE @dbname NVARCHAR(1024), @days INT;      

SET @dbname = 'CenterEdge';
SET @days = 365;

WITH TempTable(Row,database_name,backup_start_date,Mb) AS (
	SELECT ROW_NUMBER() OVER(ORDER BY backup_start_date) AS Row, database_name, backup_start_date, CAST(backup_size/1024/1024 AS decimal(10,2)) Mb 
	FROM msdb..backupset
	WHERE TYPE = 'D' AND database_name=@dbname AND backup_start_date > GETDATE() - @days
)
SELECT CAST(A.backup_start_date AS DATE), SUM(A.Mb - B.Mb) AS increment_mb
FROM TempTable A LEFT JOIN TempTable B ON A.Row = B.Row + 1
GROUP BY CAST(A.backup_start_date AS DATE)
ORDER BY CAST(A.backup_start_date AS DATE) DESC
"

End Class