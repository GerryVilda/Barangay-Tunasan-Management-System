<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RequestForm))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtRequestID = New TextBox()
        cmbRequestType = New ComboBox()
        dtpDateRequested = New DateTimePicker()
        btnSave = New Button()
        Label3 = New Label()
        Label4 = New Label()
        txtPurpose = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        txtStatus = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 44
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(194, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 54)
        Label1.TabIndex = 45
        Label1.Text = "Request Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(468, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 38)
        Label2.TabIndex = 46
        Label2.Text = "Request ID:"
        ' 
        ' txtRequestID
        ' 
        txtRequestID.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtRequestID.Location = New Point(711, 180)
        txtRequestID.Name = "txtRequestID"
        txtRequestID.ReadOnly = True
        txtRequestID.Size = New Size(389, 38)
        txtRequestID.TabIndex = 47
        ' 
        ' cmbRequestType
        ' 
        cmbRequestType.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbRequestType.FormattingEnabled = True
        cmbRequestType.Items.AddRange(New Object() {"Barangay Clearance (Personal Use)", "Barangay Clearance (Business)", "Residency Certificate", "Indigency Certificate", "Community Tax Certificate / Cedula", "Barangay Business Clearance", "Good Moral Certificate", "Senior Citizen / PWD Certificate", "Solo Parent Certificate", "Certificate of Occupancy / Lot Clearance", "Certificate of Barangay Employment"})
        cmbRequestType.Location = New Point(711, 264)
        cmbRequestType.Name = "cmbRequestType"
        cmbRequestType.Size = New Size(389, 39)
        cmbRequestType.TabIndex = 48
        ' 
        ' dtpDateRequested
        ' 
        dtpDateRequested.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDateRequested.Location = New Point(711, 513)
        dtpDateRequested.Name = "dtpDateRequested"
        dtpDateRequested.Size = New Size(389, 38)
        dtpDateRequested.TabIndex = 49
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(1001, 659)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(99, 42)
        btnSave.TabIndex = 50
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(468, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(193, 38)
        Label3.TabIndex = 51
        Label3.Text = "Request Type:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(468, 340)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 38)
        Label4.TabIndex = 52
        Label4.Text = "Purpose:"
        ' 
        ' txtPurpose
        ' 
        txtPurpose.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPurpose.Location = New Point(711, 340)
        txtPurpose.Multiline = True
        txtPurpose.Name = "txtPurpose"
        txtPurpose.Size = New Size(389, 150)
        txtPurpose.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(468, 513)
        Label5.Name = "Label5"
        Label5.Size = New Size(225, 38)
        Label5.TabIndex = 54
        Label5.Text = "Date Requested:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(468, 586)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 38)
        Label6.TabIndex = 55
        Label6.Text = "Status:"
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtStatus.Location = New Point(711, 586)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(389, 38)
        txtStatus.TabIndex = 56
        ' 
        ' RequestForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1539, 844)
        Controls.Add(txtStatus)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtPurpose)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnSave)
        Controls.Add(dtpDateRequested)
        Controls.Add(cmbRequestType)
        Controls.Add(txtRequestID)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "RequestForm"
        Text = "RequestForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRequestID As TextBox
    Friend WithEvents cmbRequestType As ComboBox
    Friend WithEvents dtpDateRequested As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPurpose As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStatus As TextBox
End Class
