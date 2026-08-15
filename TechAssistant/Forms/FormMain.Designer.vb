<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnTestConnection = New Button()
        btnCancel = New Button()
        btnTest1 = New Button()
        btnTestUpdate = New Button()
        btnTestConnect = New Button()
        tcFormMain = New TabControl()
        tpSystemInfo = New TabPage()
        dgvSystemInfo = New DataGridView()
        tpDbInfo = New TabPage()
        tcDbInfo = New TabControl()
        tpApplicationInfo = New TabPage()
        dgvApplicationInfo = New DataGridView()
        tpAppOptions = New TabPage()
        dgvAppOptions = New DataGridView()
        tpWebOptions = New TabPage()
        dgvWebOptions = New DataGridView()
        tpDbAnalytics = New TabPage()
        tcDbAnalytics = New TabControl()
        tpDbTableSizes = New TabPage()
        dgvTableSizes = New DataGridView()
        tpSizeByDay = New TabPage()
        tlpFormMain = New TableLayoutPanel()
        flpFormButtonsTop = New FlowLayoutPanel()
        flpFormButtonsBottom = New FlowLayoutPanel()
        flpTest = New FlowLayoutPanel()
        btnTest2 = New Button()
        btnTest3 = New Button()
        btnTest4 = New Button()
        dgvGrowthByDay = New DataGridView()
        tcFormMain.SuspendLayout()
        tpSystemInfo.SuspendLayout()
        CType(dgvSystemInfo, ComponentModel.ISupportInitialize).BeginInit()
        tpDbInfo.SuspendLayout()
        tcDbInfo.SuspendLayout()
        tpApplicationInfo.SuspendLayout()
        CType(dgvApplicationInfo, ComponentModel.ISupportInitialize).BeginInit()
        tpAppOptions.SuspendLayout()
        CType(dgvAppOptions, ComponentModel.ISupportInitialize).BeginInit()
        tpWebOptions.SuspendLayout()
        CType(dgvWebOptions, ComponentModel.ISupportInitialize).BeginInit()
        tpDbAnalytics.SuspendLayout()
        tcDbAnalytics.SuspendLayout()
        tpDbTableSizes.SuspendLayout()
        CType(dgvTableSizes, ComponentModel.ISupportInitialize).BeginInit()
        tpSizeByDay.SuspendLayout()
        tlpFormMain.SuspendLayout()
        flpFormButtonsTop.SuspendLayout()
        flpFormButtonsBottom.SuspendLayout()
        flpTest.SuspendLayout()
        CType(dgvGrowthByDay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTestConnection
        ' 
        btnTestConnection.Location = New Point(3, 3)
        btnTestConnection.Name = "btnTestConnection"
        btnTestConnection.Size = New Size(122, 23)
        btnTestConnection.TabIndex = 0
        btnTestConnection.Text = "Test Database"
        btnTestConnection.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(3, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnTest1
        ' 
        btnTest1.Location = New Point(3, 3)
        btnTest1.Name = "btnTest1"
        btnTest1.Size = New Size(75, 23)
        btnTest1.TabIndex = 3
        btnTest1.Text = "Test1"
        btnTest1.UseVisualStyleBackColor = True
        ' 
        ' btnTestUpdate
        ' 
        btnTestUpdate.Location = New Point(131, 3)
        btnTestUpdate.Name = "btnTestUpdate"
        btnTestUpdate.Size = New Size(122, 23)
        btnTestUpdate.TabIndex = 4
        btnTestUpdate.Text = "Test Update"
        btnTestUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnTestConnect
        ' 
        btnTestConnect.Location = New Point(3, 32)
        btnTestConnect.Name = "btnTestConnect"
        btnTestConnect.Size = New Size(122, 23)
        btnTestConnect.TabIndex = 5
        btnTestConnect.Text = "TestConnect"
        btnTestConnect.UseVisualStyleBackColor = True
        ' 
        ' tcFormMain
        ' 
        tcFormMain.Controls.Add(tpSystemInfo)
        tcFormMain.Controls.Add(tpDbInfo)
        tcFormMain.Controls.Add(tpDbAnalytics)
        tcFormMain.Dock = DockStyle.Fill
        tcFormMain.Location = New Point(3, 3)
        tcFormMain.Name = "tcFormMain"
        tcFormMain.SelectedIndex = 0
        tcFormMain.Size = New Size(931, 624)
        tcFormMain.TabIndex = 6
        ' 
        ' tpSystemInfo
        ' 
        tpSystemInfo.Controls.Add(dgvSystemInfo)
        tpSystemInfo.Location = New Point(4, 24)
        tpSystemInfo.Name = "tpSystemInfo"
        tpSystemInfo.Padding = New Padding(3)
        tpSystemInfo.Size = New Size(923, 596)
        tpSystemInfo.TabIndex = 0
        tpSystemInfo.Text = "System Info"
        ' 
        ' dgvSystemInfo
        ' 
        dgvSystemInfo.AllowUserToAddRows = False
        dgvSystemInfo.AllowUserToDeleteRows = False
        dgvSystemInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvSystemInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSystemInfo.Dock = DockStyle.Fill
        dgvSystemInfo.Location = New Point(3, 3)
        dgvSystemInfo.MultiSelect = False
        dgvSystemInfo.Name = "dgvSystemInfo"
        dgvSystemInfo.ReadOnly = True
        dgvSystemInfo.RowHeadersVisible = False
        dgvSystemInfo.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvSystemInfo.Size = New Size(917, 590)
        dgvSystemInfo.TabIndex = 2
        ' 
        ' tpDbInfo
        ' 
        tpDbInfo.Controls.Add(tcDbInfo)
        tpDbInfo.Location = New Point(4, 24)
        tpDbInfo.Name = "tpDbInfo"
        tpDbInfo.Padding = New Padding(3)
        tpDbInfo.Size = New Size(923, 596)
        tpDbInfo.TabIndex = 1
        tpDbInfo.Text = "CE Db Info"
        ' 
        ' tcDbInfo
        ' 
        tcDbInfo.Controls.Add(tpApplicationInfo)
        tcDbInfo.Controls.Add(tpAppOptions)
        tcDbInfo.Controls.Add(tpWebOptions)
        tcDbInfo.Dock = DockStyle.Fill
        tcDbInfo.Location = New Point(3, 3)
        tcDbInfo.Multiline = True
        tcDbInfo.Name = "tcDbInfo"
        tcDbInfo.SelectedIndex = 0
        tcDbInfo.Size = New Size(917, 590)
        tcDbInfo.TabIndex = 1
        ' 
        ' tpApplicationInfo
        ' 
        tpApplicationInfo.Controls.Add(dgvApplicationInfo)
        tpApplicationInfo.Location = New Point(4, 24)
        tpApplicationInfo.Name = "tpApplicationInfo"
        tpApplicationInfo.Padding = New Padding(3)
        tpApplicationInfo.Size = New Size(909, 562)
        tpApplicationInfo.TabIndex = 0
        tpApplicationInfo.Text = "ApplicationInfo"
        ' 
        ' dgvApplicationInfo
        ' 
        dgvApplicationInfo.AllowUserToAddRows = False
        dgvApplicationInfo.AllowUserToDeleteRows = False
        dgvApplicationInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvApplicationInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvApplicationInfo.Dock = DockStyle.Fill
        dgvApplicationInfo.Location = New Point(3, 3)
        dgvApplicationInfo.MultiSelect = False
        dgvApplicationInfo.Name = "dgvApplicationInfo"
        dgvApplicationInfo.ReadOnly = True
        dgvApplicationInfo.RowHeadersVisible = False
        dgvApplicationInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvApplicationInfo.Size = New Size(903, 556)
        dgvApplicationInfo.TabIndex = 0
        ' 
        ' tpAppOptions
        ' 
        tpAppOptions.Controls.Add(dgvAppOptions)
        tpAppOptions.Location = New Point(4, 24)
        tpAppOptions.Name = "tpAppOptions"
        tpAppOptions.Padding = New Padding(3)
        tpAppOptions.Size = New Size(909, 562)
        tpAppOptions.TabIndex = 1
        tpAppOptions.Text = "AppOptions"
        ' 
        ' dgvAppOptions
        ' 
        dgvAppOptions.AllowUserToAddRows = False
        dgvAppOptions.AllowUserToDeleteRows = False
        dgvAppOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvAppOptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAppOptions.Dock = DockStyle.Fill
        dgvAppOptions.Location = New Point(3, 3)
        dgvAppOptions.MultiSelect = False
        dgvAppOptions.Name = "dgvAppOptions"
        dgvAppOptions.ReadOnly = True
        dgvAppOptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAppOptions.Size = New Size(903, 556)
        dgvAppOptions.TabIndex = 0
        ' 
        ' tpWebOptions
        ' 
        tpWebOptions.Controls.Add(dgvWebOptions)
        tpWebOptions.Location = New Point(4, 24)
        tpWebOptions.Name = "tpWebOptions"
        tpWebOptions.Padding = New Padding(3)
        tpWebOptions.Size = New Size(909, 562)
        tpWebOptions.TabIndex = 2
        tpWebOptions.Text = "WebOptions"
        ' 
        ' dgvWebOptions
        ' 
        dgvWebOptions.AllowUserToAddRows = False
        dgvWebOptions.AllowUserToDeleteRows = False
        dgvWebOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvWebOptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvWebOptions.Dock = DockStyle.Fill
        dgvWebOptions.Location = New Point(3, 3)
        dgvWebOptions.MultiSelect = False
        dgvWebOptions.Name = "dgvWebOptions"
        dgvWebOptions.ReadOnly = True
        dgvWebOptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvWebOptions.Size = New Size(903, 556)
        dgvWebOptions.TabIndex = 1
        ' 
        ' tpDbAnalytics
        ' 
        tpDbAnalytics.Controls.Add(tcDbAnalytics)
        tpDbAnalytics.Location = New Point(4, 24)
        tpDbAnalytics.Name = "tpDbAnalytics"
        tpDbAnalytics.Padding = New Padding(3)
        tpDbAnalytics.Size = New Size(923, 596)
        tpDbAnalytics.TabIndex = 2
        tpDbAnalytics.Text = "Database Analytics"
        ' 
        ' tcDbAnalytics
        ' 
        tcDbAnalytics.Controls.Add(tpDbTableSizes)
        tcDbAnalytics.Controls.Add(tpSizeByDay)
        tcDbAnalytics.Dock = DockStyle.Fill
        tcDbAnalytics.Location = New Point(3, 3)
        tcDbAnalytics.Name = "tcDbAnalytics"
        tcDbAnalytics.SelectedIndex = 0
        tcDbAnalytics.Size = New Size(917, 590)
        tcDbAnalytics.TabIndex = 0
        ' 
        ' tpDbTableSizes
        ' 
        tpDbTableSizes.Controls.Add(dgvTableSizes)
        tpDbTableSizes.Location = New Point(4, 24)
        tpDbTableSizes.Name = "tpDbTableSizes"
        tpDbTableSizes.Padding = New Padding(3)
        tpDbTableSizes.Size = New Size(909, 562)
        tpDbTableSizes.TabIndex = 1
        tpDbTableSizes.Text = "Tables Sizes"
        tpDbTableSizes.UseVisualStyleBackColor = True
        ' 
        ' dgvTableSizes
        ' 
        dgvTableSizes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSizes.Dock = DockStyle.Fill
        dgvTableSizes.Location = New Point(3, 3)
        dgvTableSizes.Name = "dgvTableSizes"
        dgvTableSizes.Size = New Size(903, 556)
        dgvTableSizes.TabIndex = 0
        ' 
        ' tpSizeByDay
        ' 
        tpSizeByDay.Controls.Add(dgvGrowthByDay)
        tpSizeByDay.Location = New Point(4, 24)
        tpSizeByDay.Name = "tpSizeByDay"
        tpSizeByDay.Padding = New Padding(3)
        tpSizeByDay.Size = New Size(909, 562)
        tpSizeByDay.TabIndex = 0
        tpSizeByDay.Text = "Growth by Day"
        tpSizeByDay.UseVisualStyleBackColor = True
        ' 
        ' tlpFormMain
        ' 
        tlpFormMain.ColumnCount = 2
        tlpFormMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 76.0623245F))
        tlpFormMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 23.9376774F))
        tlpFormMain.Controls.Add(tcFormMain, 0, 0)
        tlpFormMain.Controls.Add(flpFormButtonsTop, 1, 0)
        tlpFormMain.Controls.Add(flpFormButtonsBottom, 1, 1)
        tlpFormMain.Controls.Add(flpTest, 0, 1)
        tlpFormMain.Dock = DockStyle.Fill
        tlpFormMain.Location = New Point(0, 0)
        tlpFormMain.Name = "tlpFormMain"
        tlpFormMain.RowCount = 2
        tlpFormMain.RowStyles.Add(New RowStyle(SizeType.Percent, 84.42822F))
        tlpFormMain.RowStyles.Add(New RowStyle(SizeType.Percent, 15.5717764F))
        tlpFormMain.Size = New Size(1232, 747)
        tlpFormMain.TabIndex = 7
        ' 
        ' flpFormButtonsTop
        ' 
        flpFormButtonsTop.Controls.Add(btnTestConnection)
        flpFormButtonsTop.Controls.Add(btnTestUpdate)
        flpFormButtonsTop.Controls.Add(btnTestConnect)
        flpFormButtonsTop.Dock = DockStyle.Top
        flpFormButtonsTop.Location = New Point(940, 3)
        flpFormButtonsTop.Name = "flpFormButtonsTop"
        flpFormButtonsTop.Size = New Size(289, 319)
        flpFormButtonsTop.TabIndex = 7
        ' 
        ' flpFormButtonsBottom
        ' 
        flpFormButtonsBottom.Controls.Add(btnCancel)
        flpFormButtonsBottom.Dock = DockStyle.Bottom
        flpFormButtonsBottom.Location = New Point(940, 644)
        flpFormButtonsBottom.Name = "flpFormButtonsBottom"
        flpFormButtonsBottom.Size = New Size(289, 100)
        flpFormButtonsBottom.TabIndex = 8
        ' 
        ' flpTest
        ' 
        flpTest.Controls.Add(btnTest1)
        flpTest.Controls.Add(btnTest2)
        flpTest.Controls.Add(btnTest3)
        flpTest.Controls.Add(btnTest4)
        flpTest.Location = New Point(3, 633)
        flpTest.Name = "flpTest"
        flpTest.Size = New Size(574, 100)
        flpTest.TabIndex = 9
        ' 
        ' btnTest2
        ' 
        btnTest2.Location = New Point(84, 3)
        btnTest2.Name = "btnTest2"
        btnTest2.Size = New Size(75, 23)
        btnTest2.TabIndex = 4
        btnTest2.Text = "Test2"
        btnTest2.UseVisualStyleBackColor = True
        ' 
        ' btnTest3
        ' 
        btnTest3.Location = New Point(165, 3)
        btnTest3.Name = "btnTest3"
        btnTest3.Size = New Size(75, 23)
        btnTest3.TabIndex = 5
        btnTest3.Text = "Test3"
        btnTest3.UseVisualStyleBackColor = True
        ' 
        ' btnTest4
        ' 
        btnTest4.Location = New Point(246, 3)
        btnTest4.Name = "btnTest4"
        btnTest4.Size = New Size(75, 23)
        btnTest4.TabIndex = 6
        btnTest4.Text = "Test4"
        btnTest4.UseVisualStyleBackColor = True
        ' 
        ' dgvGrowthByDay
        ' 
        dgvGrowthByDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGrowthByDay.Dock = DockStyle.Fill
        dgvGrowthByDay.Location = New Point(3, 3)
        dgvGrowthByDay.Name = "dgvGrowthByDay"
        dgvGrowthByDay.Size = New Size(903, 556)
        dgvGrowthByDay.TabIndex = 0
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1232, 747)
        Controls.Add(tlpFormMain)
        ForeColor = SystemColors.ControlText
        Name = "FormMain"
        Text = "FormMain"
        tcFormMain.ResumeLayout(False)
        tpSystemInfo.ResumeLayout(False)
        CType(dgvSystemInfo, ComponentModel.ISupportInitialize).EndInit()
        tpDbInfo.ResumeLayout(False)
        tcDbInfo.ResumeLayout(False)
        tpApplicationInfo.ResumeLayout(False)
        CType(dgvApplicationInfo, ComponentModel.ISupportInitialize).EndInit()
        tpAppOptions.ResumeLayout(False)
        CType(dgvAppOptions, ComponentModel.ISupportInitialize).EndInit()
        tpWebOptions.ResumeLayout(False)
        CType(dgvWebOptions, ComponentModel.ISupportInitialize).EndInit()
        tpDbAnalytics.ResumeLayout(False)
        tcDbAnalytics.ResumeLayout(False)
        tpDbTableSizes.ResumeLayout(False)
        CType(dgvTableSizes, ComponentModel.ISupportInitialize).EndInit()
        tpSizeByDay.ResumeLayout(False)
        tlpFormMain.ResumeLayout(False)
        flpFormButtonsTop.ResumeLayout(False)
        flpFormButtonsBottom.ResumeLayout(False)
        flpTest.ResumeLayout(False)
        CType(dgvGrowthByDay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnTestConnection As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnTest1 As Button
    Friend WithEvents btnTestUpdate As Button
    Friend WithEvents btnTestConnect As Button
    Friend WithEvents tcFormMain As TabControl
    Friend WithEvents tpSystemInfo As TabPage
    Friend WithEvents tpDbInfo As TabPage
    Friend WithEvents tpDbAnalytics As TabPage
    Friend WithEvents dgvAppOptions As DataGridView
    Friend WithEvents dgvApplicationInfo As DataGridView
    Friend WithEvents tlpFormMain As TableLayoutPanel
    Friend WithEvents flpFormButtonsTop As FlowLayoutPanel
    Friend WithEvents flpFormButtonsBottom As FlowLayoutPanel
    Friend WithEvents tcDbInfo As TabControl
    Friend WithEvents tpApplicationInfo As TabPage
    Friend WithEvents tpAppOptions As TabPage
    Friend WithEvents tpWebOptions As TabPage
    Friend WithEvents dgvWebOptions As DataGridView
    Friend WithEvents dgvSystemInfo As DataGridView
    Friend WithEvents flpTest As FlowLayoutPanel
    Friend WithEvents btnTest2 As Button
    Friend WithEvents btnTest3 As Button
    Friend WithEvents btnTest4 As Button
    Friend WithEvents tcDbAnalytics As TabControl
    Friend WithEvents tpSizeByDay As TabPage
    Friend WithEvents tpDbTableSizes As TabPage
    Friend WithEvents dgvTableSizes As DataGridView
    Friend WithEvents dgvGrowthByDay As DataGridView

End Class
