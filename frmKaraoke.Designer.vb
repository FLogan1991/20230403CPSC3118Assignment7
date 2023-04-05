<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaraoke
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKaraoke))
        Me.cbxSelection = New System.Windows.Forms.ComboBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtRentalTotal = New System.Windows.Forms.TextBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxSelection
        '
        Me.cbxSelection.DisplayMember = "Number of Songs ($2.99 per song)"
        Me.cbxSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSelection.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSelection.FormattingEnabled = True
        Me.cbxSelection.Items.AddRange(New Object() {"Number of Songs ($2.99 per Song)", "Hours in Private Karaoke Booth ($8.99 per Hour)"})
        Me.cbxSelection.Location = New System.Drawing.Point(444, 103)
        Me.cbxSelection.Name = "cbxSelection"
        Me.cbxSelection.Size = New System.Drawing.Size(373, 31)
        Me.cbxSelection.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHeader.Location = New System.Drawing.Point(494, 44)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(260, 36)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Karaoke Music Night"
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSelected.Location = New System.Drawing.Point(501, 179)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(213, 29)
        Me.lblSelected.TabIndex = 2
        Me.lblSelected.Text = "This is a placeholder"
        Me.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalCost.Location = New System.Drawing.Point(471, 379)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(252, 29)
        Me.lblTotalCost.TabIndex = 3
        Me.lblTotalCost.Text = "This is a placeholder too"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRentalTotal
        '
        Me.txtRentalTotal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentalTotal.Location = New System.Drawing.Point(601, 230)
        Me.txtRentalTotal.Name = "txtRentalTotal"
        Me.txtRentalTotal.Size = New System.Drawing.Size(49, 33)
        Me.txtRentalTotal.TabIndex = 4
        '
        'btnCost
        '
        Me.btnCost.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise
        Me.btnCost.FlatAppearance.BorderSize = 15
        Me.btnCost.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCost.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(435, 310)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(127, 45)
        Me.btnCost.TabIndex = 5
        Me.btnCost.Text = "Total Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise
        Me.btnClear.FlatAppearance.BorderSize = 15
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(681, 310)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(127, 45)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmKaraoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(906, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.txtRentalTotal)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.cbxSelection)
        Me.Name = "frmKaraoke"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karaoke Music Night"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxSelection As ComboBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtRentalTotal As TextBox
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
End Class
