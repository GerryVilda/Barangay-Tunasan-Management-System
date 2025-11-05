<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Panel1 = New Panel()
        btnSave = New Button()
        Label13 = New Label()
        Label12 = New Label()
        cmbProcessed = New ComboBox()
        txtReceiptNo = New TextBox()
        dtpDate = New DateTimePicker()
        cmbStatus = New ComboBox()
        txtAmount = New TextBox()
        cmbType = New ComboBox()
        txtResidentID = New TextBox()
        txtPaymentID = New TextBox()
        btnUpdate = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 1)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 43
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(179, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 54)
        Label1.TabIndex = 44
        Label1.Text = "Payment"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(11, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 28)
        Label2.TabIndex = 45
        Label2.Text = "Payment ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(11, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 28)
        Label3.TabIndex = 46
        Label3.Text = "Resident ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(11, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 28)
        Label4.TabIndex = 47
        Label4.Text = "Payment Type:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(11, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 28)
        Label5.TabIndex = 48
        Label5.Text = "Amount:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(11, 253)
        Label7.Name = "Label7"
        Label7.Size = New Size(157, 28)
        Label7.TabIndex = 49
        Label7.Text = "Payment Status:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(11, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 28)
        Label6.TabIndex = 50
        Label6.Text = "Payment Date:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(11, 301)
        Label8.Name = "Label8"
        Label8.Size = New Size(165, 28)
        Label8.TabIndex = 52
        Label8.Text = "Receipt Number:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(11, 345)
        Label9.Name = "Label9"
        Label9.Size = New Size(137, 28)
        Label9.TabIndex = 53
        Label9.Text = "Processed By:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(11, 392)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 28)
        Label10.TabIndex = 54
        Label10.Text = "Created At:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(11, 438)
        Label11.Name = "Label11"
        Label11.Size = New Size(123, 28)
        Label11.TabIndex = 55
        Label11.Text = "Updated By:"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(cmbProcessed)
        Panel1.Controls.Add(txtReceiptNo)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(dtpDate)
        Panel1.Controls.Add(cmbStatus)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtAmount)
        Panel1.Controls.Add(cmbType)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtResidentID)
        Panel1.Controls.Add(txtPaymentID)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(179, 152)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1196, 498)
        Panel1.TabIndex = 56
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(582, 419)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 47)
        btnSave.TabIndex = 57
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(182, 438)
        Label13.Name = "Label13"
        Label13.Size = New Size(79, 28)
        Label13.TabIndex = 56
        Label13.Text = "Label13"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(182, 392)
        Label12.Name = "Label12"
        Label12.Size = New Size(79, 28)
        Label12.TabIndex = 55
        Label12.Text = "Label12"
        ' 
        ' cmbProcessed
        ' 
        cmbProcessed.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbProcessed.FormattingEnabled = True
        cmbProcessed.Location = New Point(182, 342)
        cmbProcessed.Name = "cmbProcessed"
        cmbProcessed.Size = New Size(394, 36)
        cmbProcessed.TabIndex = 54
        ' 
        ' txtReceiptNo
        ' 
        txtReceiptNo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtReceiptNo.Location = New Point(182, 298)
        txtReceiptNo.Name = "txtReceiptNo"
        txtReceiptNo.Size = New Size(394, 34)
        txtReceiptNo.TabIndex = 53
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDate.Location = New Point(182, 200)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(394, 34)
        dtpDate.TabIndex = 52
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(182, 250)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(394, 36)
        cmbStatus.TabIndex = 51
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAmount.Location = New Point(182, 152)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(394, 34)
        txtAmount.TabIndex = 50
        ' 
        ' cmbType
        ' 
        cmbType.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbType.FormattingEnabled = True
        cmbType.Location = New Point(182, 102)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(394, 36)
        cmbType.TabIndex = 49
        ' 
        ' txtResidentID
        ' 
        txtResidentID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtResidentID.Location = New Point(182, 55)
        txtResidentID.Name = "txtResidentID"
        txtResidentID.Size = New Size(394, 34)
        txtResidentID.TabIndex = 48
        ' 
        ' txtPaymentID
        ' 
        txtPaymentID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPaymentID.Location = New Point(182, 11)
        txtPaymentID.Name = "txtPaymentID"
        txtPaymentID.Size = New Size(394, 34)
        txtPaymentID.TabIndex = 46
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.Black
        btnUpdate.Location = New Point(482, 419)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 47)
        btnUpdate.TabIndex = 58
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1539, 844)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Margin = New Padding(2)
        Name = "Payment"
        Text = "Payment"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents txtResidentID As TextBox
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbProcessed As ComboBox
    Friend WithEvents txtReceiptNo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
End Class
