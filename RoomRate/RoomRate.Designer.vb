<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomRate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoomRate))
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHotel = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pbxLogo2 = New System.Windows.Forms.PictureBox()
        Me.grpRoomCharges = New System.Windows.Forms.GroupBox()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.lblNightsStayed = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblNightlyRate = New System.Windows.Forms.Label()
        Me.grpMiscCharges = New System.Windows.Forms.GroupBox()
        Me.txtTV = New System.Windows.Forms.TextBox()
        Me.lblTVCharges = New System.Windows.Forms.Label()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.lblServiceCharges = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhoneCharges = New System.Windows.Forms.Label()
        Me.grpTotalCharges = New System.Windows.Forms.GroupBox()
        Me.lblGrand = New System.Windows.Forms.Label()
        Me.lblTaxTotal = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblMiscTotal = New System.Windows.Forms.Label()
        Me.lblLodgeTotal = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblLiveDate = New System.Windows.Forms.Label()
        Me.lblLiveTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRoomCharges.SuspendLayout()
        Me.grpMiscCharges.SuspendLayout()
        Me.grpTotalCharges.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(189, 423)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(316, 423)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(473, 369)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(75, 23)
        Me.btnTotal.TabIndex = 3
        Me.btnTotal.Text = "&Calculate"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(444, 423)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(91, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Brian Nicewander"
        '
        'lblHotel
        '
        Me.lblHotel.Font = New System.Drawing.Font("Vivaldi", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblHotel.Location = New System.Drawing.Point(140, 12)
        Me.lblHotel.Name = "lblHotel"
        Me.lblHotel.Size = New System.Drawing.Size(286, 71)
        Me.lblHotel.TabIndex = 4
        Me.lblHotel.Text = "Ice Wolf Hotel"
        Me.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(18, 12)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(122, 71)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 5
        Me.pbxLogo.TabStop = False
        '
        'pbxLogo2
        '
        Me.pbxLogo2.Image = CType(resources.GetObject("pbxLogo2.Image"), System.Drawing.Image)
        Me.pbxLogo2.Location = New System.Drawing.Point(432, 12)
        Me.pbxLogo2.Name = "pbxLogo2"
        Me.pbxLogo2.Size = New System.Drawing.Size(122, 71)
        Me.pbxLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo2.TabIndex = 6
        Me.pbxLogo2.TabStop = False
        '
        'grpRoomCharges
        '
        Me.grpRoomCharges.Controls.Add(Me.txtNights)
        Me.grpRoomCharges.Controls.Add(Me.lblNightsStayed)
        Me.grpRoomCharges.Controls.Add(Me.txtRate)
        Me.grpRoomCharges.Controls.Add(Me.lblNightlyRate)
        Me.grpRoomCharges.Location = New System.Drawing.Point(12, 125)
        Me.grpRoomCharges.Name = "grpRoomCharges"
        Me.grpRoomCharges.Size = New System.Drawing.Size(122, 203)
        Me.grpRoomCharges.TabIndex = 1
        Me.grpRoomCharges.TabStop = False
        Me.grpRoomCharges.Text = "Room Charges"
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(6, 145)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 20)
        Me.txtNights.TabIndex = 1
        '
        'lblNightsStayed
        '
        Me.lblNightsStayed.AutoSize = True
        Me.lblNightsStayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNightsStayed.Location = New System.Drawing.Point(7, 106)
        Me.lblNightsStayed.Name = "lblNightsStayed"
        Me.lblNightsStayed.Size = New System.Drawing.Size(92, 16)
        Me.lblNightsStayed.TabIndex = 2
        Me.lblNightsStayed.Text = "Nights Stayed"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(6, 66)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 0
        '
        'lblNightlyRate
        '
        Me.lblNightlyRate.AutoSize = True
        Me.lblNightlyRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNightlyRate.Location = New System.Drawing.Point(7, 31)
        Me.lblNightlyRate.Name = "lblNightlyRate"
        Me.lblNightlyRate.Size = New System.Drawing.Size(81, 16)
        Me.lblNightlyRate.TabIndex = 0
        Me.lblNightlyRate.Text = "Nightly Rate"
        '
        'grpMiscCharges
        '
        Me.grpMiscCharges.Controls.Add(Me.txtTV)
        Me.grpMiscCharges.Controls.Add(Me.lblTVCharges)
        Me.grpMiscCharges.Controls.Add(Me.txtService)
        Me.grpMiscCharges.Controls.Add(Me.lblServiceCharges)
        Me.grpMiscCharges.Controls.Add(Me.txtPhone)
        Me.grpMiscCharges.Controls.Add(Me.lblPhoneCharges)
        Me.grpMiscCharges.Location = New System.Drawing.Point(150, 125)
        Me.grpMiscCharges.Name = "grpMiscCharges"
        Me.grpMiscCharges.Size = New System.Drawing.Size(128, 203)
        Me.grpMiscCharges.TabIndex = 2
        Me.grpMiscCharges.TabStop = False
        Me.grpMiscCharges.Text = "Misc Charges"
        '
        'txtTV
        '
        Me.txtTV.Location = New System.Drawing.Point(7, 168)
        Me.txtTV.Name = "txtTV"
        Me.txtTV.Size = New System.Drawing.Size(100, 20)
        Me.txtTV.TabIndex = 2
        '
        'lblTVCharges
        '
        Me.lblTVCharges.AutoSize = True
        Me.lblTVCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTVCharges.Location = New System.Drawing.Point(4, 145)
        Me.lblTVCharges.Name = "lblTVCharges"
        Me.lblTVCharges.Size = New System.Drawing.Size(80, 16)
        Me.lblTVCharges.TabIndex = 4
        Me.lblTVCharges.Text = "TV Charges"
        '
        'txtService
        '
        Me.txtService.Location = New System.Drawing.Point(7, 108)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(100, 20)
        Me.txtService.TabIndex = 1
        '
        'lblServiceCharges
        '
        Me.lblServiceCharges.AutoSize = True
        Me.lblServiceCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceCharges.Location = New System.Drawing.Point(4, 89)
        Me.lblServiceCharges.Name = "lblServiceCharges"
        Me.lblServiceCharges.Size = New System.Drawing.Size(108, 16)
        Me.lblServiceCharges.TabIndex = 2
        Me.lblServiceCharges.Text = "Service Charges"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(7, 50)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 0
        '
        'lblPhoneCharges
        '
        Me.lblPhoneCharges.AutoSize = True
        Me.lblPhoneCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneCharges.Location = New System.Drawing.Point(4, 31)
        Me.lblPhoneCharges.Name = "lblPhoneCharges"
        Me.lblPhoneCharges.Size = New System.Drawing.Size(101, 16)
        Me.lblPhoneCharges.TabIndex = 0
        Me.lblPhoneCharges.Text = "Phone Charges"
        '
        'grpTotalCharges
        '
        Me.grpTotalCharges.Controls.Add(Me.lblGrand)
        Me.grpTotalCharges.Controls.Add(Me.lblTaxTotal)
        Me.grpTotalCharges.Controls.Add(Me.lblSub)
        Me.grpTotalCharges.Controls.Add(Me.lblMiscTotal)
        Me.grpTotalCharges.Controls.Add(Me.lblLodgeTotal)
        Me.grpTotalCharges.Location = New System.Drawing.Point(298, 125)
        Me.grpTotalCharges.Name = "grpTotalCharges"
        Me.grpTotalCharges.Size = New System.Drawing.Size(256, 203)
        Me.grpTotalCharges.TabIndex = 9
        Me.grpTotalCharges.TabStop = False
        Me.grpTotalCharges.Text = "Total Charges"
        '
        'lblGrand
        '
        Me.lblGrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrand.Location = New System.Drawing.Point(6, 168)
        Me.lblGrand.Name = "lblGrand"
        Me.lblGrand.Size = New System.Drawing.Size(244, 20)
        Me.lblGrand.TabIndex = 4
        Me.lblGrand.Text = "Grand Total:"
        Me.lblGrand.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTaxTotal
        '
        Me.lblTaxTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxTotal.Location = New System.Drawing.Point(86, 118)
        Me.lblTaxTotal.Name = "lblTaxTotal"
        Me.lblTaxTotal.Size = New System.Drawing.Size(164, 20)
        Me.lblTaxTotal.TabIndex = 3
        Me.lblTaxTotal.Text = "Tax Total:"
        Me.lblTaxTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSub
        '
        Me.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSub.Location = New System.Drawing.Point(86, 89)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(164, 17)
        Me.lblSub.TabIndex = 2
        Me.lblSub.Text = "Sub Total:"
        Me.lblSub.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMiscTotal
        '
        Me.lblMiscTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMiscTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiscTotal.Location = New System.Drawing.Point(86, 50)
        Me.lblMiscTotal.Name = "lblMiscTotal"
        Me.lblMiscTotal.Size = New System.Drawing.Size(164, 20)
        Me.lblMiscTotal.TabIndex = 1
        Me.lblMiscTotal.Text = "Misc Total:"
        Me.lblMiscTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLodgeTotal
        '
        Me.lblLodgeTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLodgeTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLodgeTotal.Location = New System.Drawing.Point(86, 16)
        Me.lblLodgeTotal.Name = "lblLodgeTotal"
        Me.lblLodgeTotal.Size = New System.Drawing.Size(164, 21)
        Me.lblLodgeTotal.TabIndex = 0
        Me.lblLodgeTotal.Text = "Room Rate:"
        Me.lblLodgeTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLiveDate
        '
        Me.lblLiveDate.AutoSize = True
        Me.lblLiveDate.Location = New System.Drawing.Point(83, 351)
        Me.lblLiveDate.Name = "lblLiveDate"
        Me.lblLiveDate.Size = New System.Drawing.Size(33, 13)
        Me.lblLiveDate.TabIndex = 10
        Me.lblLiveDate.Text = "Date:"
        '
        'lblLiveTime
        '
        Me.lblLiveTime.AutoSize = True
        Me.lblLiveTime.Location = New System.Drawing.Point(83, 379)
        Me.lblLiveTime.Name = "lblLiveTime"
        Me.lblLiveTime.Size = New System.Drawing.Size(33, 13)
        Me.lblLiveTime.TabIndex = 11
        Me.lblLiveTime.Text = "Time:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(30, 348)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(37, 16)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "Date"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(30, 376)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 16)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "Time"
        '
        'RoomRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 463)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblLiveTime)
        Me.Controls.Add(Me.lblLiveDate)
        Me.Controls.Add(Me.grpTotalCharges)
        Me.Controls.Add(Me.grpMiscCharges)
        Me.Controls.Add(Me.grpRoomCharges)
        Me.Controls.Add(Me.pbxLogo2)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.lblHotel)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Name = "RoomRate"
        Me.Text = "Room Charge Calculator"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRoomCharges.ResumeLayout(False)
        Me.grpRoomCharges.PerformLayout()
        Me.grpMiscCharges.ResumeLayout(False)
        Me.grpMiscCharges.PerformLayout()
        Me.grpTotalCharges.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblHotel As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pbxLogo2 As PictureBox
    Friend WithEvents grpRoomCharges As GroupBox
    Friend WithEvents txtNights As TextBox
    Friend WithEvents lblNightsStayed As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents lblNightlyRate As Label
    Friend WithEvents grpMiscCharges As GroupBox
    Friend WithEvents txtTV As TextBox
    Friend WithEvents lblTVCharges As Label
    Friend WithEvents txtService As TextBox
    Friend WithEvents lblServiceCharges As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhoneCharges As Label
    Friend WithEvents grpTotalCharges As GroupBox
    Friend WithEvents lblGrand As Label
    Friend WithEvents lblTaxTotal As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents lblMiscTotal As Label
    Friend WithEvents lblLodgeTotal As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblLiveDate As Label
    Friend WithEvents lblLiveTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
End Class
