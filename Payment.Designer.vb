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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payment))
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
        Panel1 = New Panel()
        btnUpdate = New Button()
        btnSave = New Button()
        cmbProcessedby = New ComboBox()
        txtReceiptNo = New TextBox()
        dtpDate = New DateTimePicker()
        cmbStatus = New ComboBox()
        txtAmount = New TextBox()
        cmbpaymentType = New ComboBox()
        txtResidentname = New TextBox()
        txtPaymentID = New TextBox()
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
        PictureBox1.Size = New Size(216, 189)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 43
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(224, 52)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 65)
        Label1.TabIndex = 44
        Label1.Text = "Payment"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(14, 18)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 32)
        Label2.TabIndex = 45
        Label2.Text = "Payment ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(14, 72)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 32)
        Label3.TabIndex = 46
        Label3.Text = "Resident Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(14, 131)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 32)
        Label4.TabIndex = 47
        Label4.Text = "Payment Type:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(14, 194)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 32)
        Label5.TabIndex = 48
        Label5.Text = "Amount:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(14, 316)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(189, 32)
        Label7.TabIndex = 49
        Label7.Text = "Payment Status:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(14, 254)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(174, 32)
        Label6.TabIndex = 50
        Label6.Text = "Payment Date:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(14, 376)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(197, 32)
        Label8.TabIndex = 52
        Label8.Text = "Receipt Number:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(14, 431)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(162, 32)
        Label9.TabIndex = 53
        Label9.Text = "Processed By:"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(cmbProcessedby)
        Panel1.Controls.Add(txtReceiptNo)
        Panel1.Controls.Add(dtpDate)
        Panel1.Controls.Add(cmbStatus)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtAmount)
        Panel1.Controls.Add(cmbpaymentType)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtResidentname)
        Panel1.Controls.Add(txtPaymentID)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(224, 190)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1495, 622)
        Panel1.TabIndex = 56
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.Black
        btnUpdate.Location = New Point(476, 512)
        btnUpdate.Margin = New Padding(4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(118, 59)
        btnUpdate.TabIndex = 58
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(602, 512)
        btnSave.Margin = New Padding(4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(118, 59)
        btnSave.TabIndex = 57
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' cmbProcessedby
        ' 
        cmbProcessedby.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbProcessedby.FormattingEnabled = True
        cmbProcessedby.Location = New Point(228, 428)
        cmbProcessedby.Margin = New Padding(4)
        cmbProcessedby.Name = "cmbProcessedby"
        cmbProcessedby.Size = New Size(492, 40)
        cmbProcessedby.TabIndex = 54
        ' 
        ' txtReceiptNo
        ' 
        txtReceiptNo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtReceiptNo.Location = New Point(228, 372)
        txtReceiptNo.Margin = New Padding(4)
        txtReceiptNo.Name = "txtReceiptNo"
        txtReceiptNo.Size = New Size(492, 39)
        txtReceiptNo.TabIndex = 53
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDate.Location = New Point(228, 250)
        dtpDate.Margin = New Padding(4)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(492, 39)
        dtpDate.TabIndex = 52
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(228, 312)
        cmbStatus.Margin = New Padding(4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(492, 40)
        cmbStatus.TabIndex = 51
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAmount.Location = New Point(228, 190)
        txtAmount.Margin = New Padding(4)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(492, 39)
        txtAmount.TabIndex = 50
        ' 
        ' cmbpaymentType
        ' 
        cmbpaymentType.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbpaymentType.FormattingEnabled = True
        cmbpaymentType.Location = New Point(228, 128)
        cmbpaymentType.Margin = New Padding(4)
        cmbpaymentType.Name = "cmbpaymentType"
        cmbpaymentType.Size = New Size(492, 40)
        cmbpaymentType.TabIndex = 49
        ' 
        ' txtResidentname
        ' 
        txtResidentname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtResidentname.Location = New Point(228, 69)
        txtResidentname.Margin = New Padding(4)
        txtResidentname.Name = "txtResidentname"
        txtResidentname.Size = New Size(492, 39)
        txtResidentname.TabIndex = 48
        ' 
        ' txtPaymentID
        ' 
        txtPaymentID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPaymentID.Location = New Point(228, 14)
        txtPaymentID.Margin = New Padding(4)
        txtPaymentID.Name = "txtPaymentID"
        txtPaymentID.Size = New Size(492, 39)
        txtPaymentID.TabIndex = 46
        ' 
        ' payment
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(2262, 1476)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Margin = New Padding(2)
        Name = "payment"
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbpaymentType As ComboBox
    Friend WithEvents txtResidentname As TextBox
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbProcessedby As ComboBox
    Friend WithEvents txtReceiptNo As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
End Class
