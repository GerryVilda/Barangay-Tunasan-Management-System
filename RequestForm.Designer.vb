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
        cmbcertificateType = New ComboBox()
        dtpDate = New DateTimePicker()
        btnSubmit = New Button()
        Label3 = New Label()
        Label4 = New Label()
        txtPurpose = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        txtStatus = New TextBox()
        txtresidentname = New TextBox()
        Label7 = New Label()
        txtfee = New TextBox()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(216, 189)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 44
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(242, 59)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(334, 65)
        Label1.TabIndex = 45
        Label1.Text = "Request Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(585, 170)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 45)
        Label2.TabIndex = 46
        Label2.Text = "Request ID:"
        ' 
        ' txtRequestID
        ' 
        txtRequestID.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtRequestID.Location = New Point(889, 170)
        txtRequestID.Margin = New Padding(4)
        txtRequestID.Name = "txtRequestID"
        txtRequestID.ReadOnly = True
        txtRequestID.Size = New Size(485, 44)
        txtRequestID.TabIndex = 47
        ' 
        ' cmbcertificateType
        ' 
        cmbcertificateType.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbcertificateType.FormattingEnabled = True
        cmbcertificateType.Items.AddRange(New Object() {"Barangay Clearance (Personal Use)", "Barangay Clearance (Business)", "Barangay Clearance (First Job)", "Residency Certificate", "Indigency Certificate", "Community Tax Certificate / Cedula", "Barangay Business Clearance", "Good Moral Certificate", "Senior Citizen / PWD Certificate", "Solo Parent Certificate", "Certificate of Occupancy / Lot Clearance", "Certificate of Barangay Employment"})
        cmbcertificateType.Location = New Point(889, 330)
        cmbcertificateType.Margin = New Padding(4)
        cmbcertificateType.Name = "cmbcertificateType"
        cmbcertificateType.Size = New Size(485, 46)
        cmbcertificateType.TabIndex = 48
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDate.Location = New Point(889, 721)
        dtpDate.Margin = New Padding(4)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(485, 44)
        dtpDate.TabIndex = 49
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(1061, 878)
        btnSubmit.Margin = New Padding(4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(313, 81)
        btnSubmit.TabIndex = 50
        btnSubmit.Text = "Request Certificate"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(585, 331)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 45)
        Label3.TabIndex = 51
        Label3.Text = "Request Type:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(585, 505)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 45)
        Label4.TabIndex = 52
        Label4.Text = "Purpose:"
        ' 
        ' txtPurpose
        ' 
        txtPurpose.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPurpose.Location = New Point(889, 505)
        txtPurpose.Margin = New Padding(4)
        txtPurpose.Multiline = True
        txtPurpose.Name = "txtPurpose"
        txtPurpose.Size = New Size(485, 186)
        txtPurpose.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(585, 721)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(267, 45)
        Label5.TabIndex = 54
        Label5.Text = "Date Requested:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(585, 812)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 45)
        Label6.TabIndex = 55
        Label6.Text = "Status:"
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtStatus.Location = New Point(889, 812)
        txtStatus.Margin = New Padding(4)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(485, 44)
        txtStatus.TabIndex = 56
        txtStatus.Text = "Pending"
        ' 
        ' txtresidentname
        ' 
        txtresidentname.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtresidentname.Location = New Point(889, 248)
        txtresidentname.Margin = New Padding(4)
        txtresidentname.Name = "txtresidentname"
        txtresidentname.Size = New Size(485, 44)
        txtresidentname.TabIndex = 58
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(585, 248)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(256, 45)
        Label7.TabIndex = 57
        Label7.Text = "Resident Name:"
        ' 
        ' txtfee
        ' 
        txtfee.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtfee.Location = New Point(889, 410)
        txtfee.Margin = New Padding(4)
        txtfee.Name = "txtfee"
        txtfee.Size = New Size(485, 44)
        txtfee.TabIndex = 60
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(585, 410)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(81, 45)
        Label8.TabIndex = 59
        Label8.Text = "Fee:"
        ' 
        ' RequestForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1924, 1055)
        Controls.Add(txtfee)
        Controls.Add(Label8)
        Controls.Add(txtresidentname)
        Controls.Add(Label7)
        Controls.Add(txtStatus)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtPurpose)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnSubmit)
        Controls.Add(dtpDate)
        Controls.Add(cmbcertificateType)
        Controls.Add(txtRequestID)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Margin = New Padding(4)
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
    Friend WithEvents cmbcertificateType As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPurpose As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtresidentname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtfee As TextBox
    Friend WithEvents Label8 As Label
End Class
