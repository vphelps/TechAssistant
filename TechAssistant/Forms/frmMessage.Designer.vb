<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        picIcon = New PictureBox()
        lblMessage = New Label()
        btnOk = New Button()
        btnCancel = New Button()
        btnYes = New Button()
        btnNo = New Button()
        CType(picIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picIcon
        ' 
        picIcon.Location = New Point(20, 20)
        picIcon.Name = "picIcon"
        picIcon.Size = New Size(72, 50)
        picIcon.SizeMode = PictureBoxSizeMode.AutoSize
        picIcon.TabIndex = 0
        picIcon.TabStop = False
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(98, 20)
        lblMessage.MaximumSize = New Size(350, 0)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(66, 15)
        lblMessage.TabIndex = 2
        lblMessage.Text = "lblMessage"
        ' 
        ' btnOk
        ' 
        btnOk.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnOk.DialogResult = DialogResult.OK
        btnOk.Location = New Point(22, 198)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(75, 23)
        btnOk.TabIndex = 3
        btnOk.Text = "Ok"
        btnOk.UseVisualStyleBackColor = True
        btnOk.Visible = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCancel.DialogResult = DialogResult.Cancel
        btnCancel.Location = New Point(265, 198)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        btnCancel.Visible = False
        ' 
        ' btnYes
        ' 
        btnYes.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnYes.DialogResult = DialogResult.Yes
        btnYes.Location = New Point(103, 198)
        btnYes.Name = "btnYes"
        btnYes.Size = New Size(75, 23)
        btnYes.TabIndex = 5
        btnYes.Text = "Yes"
        btnYes.UseVisualStyleBackColor = True
        btnYes.Visible = False
        ' 
        ' btnNo
        ' 
        btnNo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnNo.DialogResult = DialogResult.No
        btnNo.Location = New Point(184, 198)
        btnNo.Name = "btnNo"
        btnNo.Size = New Size(75, 23)
        btnNo.TabIndex = 6
        btnNo.Text = "No"
        btnNo.UseVisualStyleBackColor = True
        btnNo.Visible = False
        ' 
        ' frmMessage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(356, 233)
        ControlBox = False
        Controls.Add(btnNo)
        Controls.Add(btnYes)
        Controls.Add(btnCancel)
        Controls.Add(btnOk)
        Controls.Add(lblMessage)
        Controls.Add(picIcon)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmMessage"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "frmMessage"
        CType(picIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picIcon As PictureBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
End Class
