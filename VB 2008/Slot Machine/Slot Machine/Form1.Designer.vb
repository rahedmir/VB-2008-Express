<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlotMachine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlotMachine))
        Me.lblSlot1 = New System.Windows.Forms.Label
        Me.lblSlot2 = New System.Windows.Forms.Label
        Me.lblSlot3 = New System.Windows.Forms.Label
        Me.btnSpin = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.GroupBox = New System.Windows.Forms.GroupBox
        Me.lblSpinLeft = New System.Windows.Forms.Label
        Me.lblSpinNum = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblSpinPoint = New System.Windows.Forms.Label
        Me.lblPoint = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSlot1
        '
        Me.lblSlot1.BackColor = System.Drawing.Color.White
        Me.lblSlot1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSlot1.Font = New System.Drawing.Font("Palatino Linotype", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlot1.Location = New System.Drawing.Point(14, 21)
        Me.lblSlot1.Name = "lblSlot1"
        Me.lblSlot1.Size = New System.Drawing.Size(107, 108)
        Me.lblSlot1.TabIndex = 0
        Me.lblSlot1.Text = "0"
        Me.lblSlot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSlot2
        '
        Me.lblSlot2.BackColor = System.Drawing.Color.White
        Me.lblSlot2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSlot2.Font = New System.Drawing.Font("Palatino Linotype", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlot2.Location = New System.Drawing.Point(136, 21)
        Me.lblSlot2.Name = "lblSlot2"
        Me.lblSlot2.Size = New System.Drawing.Size(120, 108)
        Me.lblSlot2.TabIndex = 1
        Me.lblSlot2.Text = "0"
        Me.lblSlot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSlot3
        '
        Me.lblSlot3.BackColor = System.Drawing.Color.White
        Me.lblSlot3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSlot3.Font = New System.Drawing.Font("Palatino Linotype", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlot3.Location = New System.Drawing.Point(269, 21)
        Me.lblSlot3.Name = "lblSlot3"
        Me.lblSlot3.Size = New System.Drawing.Size(113, 108)
        Me.lblSlot3.TabIndex = 2
        Me.lblSlot3.Text = "0"
        Me.lblSlot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSpin
        '
        Me.btnSpin.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpin.Location = New System.Drawing.Point(12, 174)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(397, 57)
        Me.btnSpin.TabIndex = 3
        Me.btnSpin.Text = "Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(12, 237)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(397, 57)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(26, 144)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(368, 174)
        Me.GroupBox.TabIndex = 5
        Me.GroupBox.TabStop = False
        '
        'lblSpinLeft
        '
        Me.lblSpinLeft.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpinLeft.Location = New System.Drawing.Point(21, 338)
        Me.lblSpinLeft.Name = "lblSpinLeft"
        Me.lblSpinLeft.Size = New System.Drawing.Size(107, 33)
        Me.lblSpinLeft.TabIndex = 6
        Me.lblSpinLeft.Text = "Spin left :"
        '
        'lblSpinNum
        '
        Me.lblSpinNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSpinNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpinNum.Location = New System.Drawing.Point(134, 338)
        Me.lblSpinNum.Name = "lblSpinNum"
        Me.lblSpinNum.Size = New System.Drawing.Size(41, 33)
        Me.lblSpinNum.TabIndex = 7
        Me.lblSpinNum.Text = "10"
        Me.lblSpinNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSlot1)
        Me.GroupBox1.Controls.Add(Me.lblSlot2)
        Me.GroupBox1.Controls.Add(Me.lblSlot3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 148)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'lblSpinPoint
        '
        Me.lblSpinPoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSpinPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpinPoint.Location = New System.Drawing.Point(352, 338)
        Me.lblSpinPoint.Name = "lblSpinPoint"
        Me.lblSpinPoint.Size = New System.Drawing.Size(41, 33)
        Me.lblSpinPoint.TabIndex = 10
        Me.lblSpinPoint.Text = "0"
        Me.lblSpinPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPoint
        '
        Me.lblPoint.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint.Location = New System.Drawing.Point(268, 338)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(78, 33)
        Me.lblPoint.TabIndex = 9
        Me.lblPoint.Text = "Point :"
        '
        'frmSlotMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 391)
        Me.Controls.Add(Me.lblSpinPoint)
        Me.Controls.Add(Me.lblPoint)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.lblSpinNum)
        Me.Controls.Add(Me.lblSpinLeft)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSlotMachine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slot Machine"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSlot1 As System.Windows.Forms.Label
    Friend WithEvents lblSlot2 As System.Windows.Forms.Label
    Friend WithEvents lblSlot3 As System.Windows.Forms.Label
    Friend WithEvents btnSpin As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents lblSpinLeft As System.Windows.Forms.Label
    Friend WithEvents lblSpinNum As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSpinPoint As System.Windows.Forms.Label
    Friend WithEvents lblPoint As System.Windows.Forms.Label

End Class
