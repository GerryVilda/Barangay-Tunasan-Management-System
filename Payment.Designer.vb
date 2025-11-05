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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        cbositio = New ComboBox()
        btndelete = New Button()
        btnupdate = New Button()
        btnadd = New Button()
        txtsearch = New TextBox()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        cbogender = New ComboBox()
        cbostatus = New ComboBox()
        dtpbirthdate = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtage = New TextBox()
        txtlastname = New TextBox()
        txtfirstname = New TextBox()
        txtresidentid = New TextBox()
        DataGridView1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbositio
        ' 
        cbositio.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        cbositio.FormattingEnabled = True
        cbositio.Items.AddRange(New Object() {"Camella Homes III", "", "Lake Shore Subdivision", "", "Lindenwood Residences", "", "Midland II Subdivision", "", "Parkhomes Subdivision", "", "Planas", "", "Sto. Niño Village", "", "Susana Heights Subdivision", "", "Villa Carolina I", "", "Villa Carolina II"})
        cbositio.Location = New Point(973, 104)
        cbositio.Margin = New Padding(2)
        cbositio.Name = "cbositio"
        cbositio.Size = New Size(395, 36)
        cbositio.TabIndex = 49
        ' 
        ' btndelete
        ' 
        btndelete.Location = New Point(1478, 141)
        btndelete.Margin = New Padding(2)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(246, 50)
        btndelete.TabIndex = 48
        btndelete.Text = "🗑️ Delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(1478, 88)
        btnupdate.Margin = New Padding(2)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(246, 50)
        btnupdate.TabIndex = 47
        btnupdate.Text = "✏️ Update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(1478, 35)
        btnadd.Margin = New Padding(2)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(246, 50)
        btnadd.TabIndex = 46
        btnadd.Text = "➕ Add"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(128, 170)
        txtsearch.Margin = New Padding(2)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(218, 27)
        txtsearch.TabIndex = 45
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(21, 170)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 28)
        Label9.TabIndex = 44
        Label9.Text = "Search By:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(21, 10)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 43
        PictureBox1.TabStop = False
        ' 
        ' cbogender
        ' 
        cbogender.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        cbogender.FormattingEnabled = True
        cbogender.Items.AddRange(New Object() {"Male", "Female"})
        cbogender.Location = New Point(973, 17)
        cbogender.Margin = New Padding(2)
        cbogender.Name = "cbogender"
        cbogender.Size = New Size(395, 36)
        cbogender.TabIndex = 42
        ' 
        ' cbostatus
        ' 
        cbostatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        cbostatus.FormattingEnabled = True
        cbostatus.Items.AddRange(New Object() {"Single ", "Married", "Widowed", "Separated", "Annulled", "Divorced", "Live-in / Common-law"})
        cbostatus.Location = New Point(973, 143)
        cbostatus.Margin = New Padding(2)
        cbostatus.Name = "cbostatus"
        cbostatus.Size = New Size(395, 36)
        cbostatus.TabIndex = 41
        ' 
        ' dtpbirthdate
        ' 
        dtpbirthdate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpbirthdate.Location = New Point(973, 58)
        dtpbirthdate.Margin = New Padding(2)
        dtpbirthdate.Name = "dtpbirthdate"
        dtpbirthdate.Size = New Size(395, 34)
        dtpbirthdate.TabIndex = 40
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(875, 147)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 28)
        Label5.TabIndex = 39
        Label5.Text = "Status"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.Location = New Point(875, 104)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 28)
        Label6.TabIndex = 38
        Label6.Text = "Sitio"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.Location = New Point(875, 62)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 28)
        Label7.TabIndex = 37
        Label7.Text = "Birthdate"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label8.Location = New Point(875, 22)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 28)
        Label8.TabIndex = 36
        Label8.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(429, 147)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 28)
        Label4.TabIndex = 35
        Label4.Text = "Age"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(429, 106)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 28)
        Label3.TabIndex = 34
        Label3.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(428, 66)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 28)
        Label2.TabIndex = 33
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(429, 26)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 28)
        Label1.TabIndex = 32
        Label1.Text = "Resident ID"
        ' 
        ' txtage
        ' 
        txtage.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtage.Location = New Point(550, 141)
        txtage.Margin = New Padding(2)
        txtage.Name = "txtage"
        txtage.Size = New Size(266, 34)
        txtage.TabIndex = 31
        ' 
        ' txtlastname
        ' 
        txtlastname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtlastname.Location = New Point(550, 100)
        txtlastname.Margin = New Padding(2)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(266, 34)
        txtlastname.TabIndex = 30
        ' 
        ' txtfirstname
        ' 
        txtfirstname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtfirstname.Location = New Point(550, 60)
        txtfirstname.Margin = New Padding(2)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(266, 34)
        txtfirstname.TabIndex = 29
        ' 
        ' txtresidentid
        ' 
        txtresidentid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtresidentid.Location = New Point(550, 19)
        txtresidentid.Margin = New Padding(2)
        txtresidentid.Name = "txtresidentid"
        txtresidentid.Size = New Size(266, 34)
        txtresidentid.TabIndex = 28
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(21, 207)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1768, 965)
        DataGridView1.TabIndex = 27
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        ClientSize = New Size(1539, 844)
        Controls.Add(cbositio)
        Controls.Add(btndelete)
        Controls.Add(btnupdate)
        Controls.Add(btnadd)
        Controls.Add(txtsearch)
        Controls.Add(Label9)
        Controls.Add(PictureBox1)
        Controls.Add(cbogender)
        Controls.Add(cbostatus)
        Controls.Add(dtpbirthdate)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtage)
        Controls.Add(txtlastname)
        Controls.Add(txtfirstname)
        Controls.Add(txtresidentid)
        Controls.Add(DataGridView1)
        Margin = New Padding(2)
        Name = "Payment"
        Text = "Payment"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbositio As ComboBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbogender As ComboBox
    Friend WithEvents cbostatus As ComboBox
    Friend WithEvents dtpbirthdate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtresidentid As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
