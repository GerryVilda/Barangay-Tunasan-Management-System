<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmresidents
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmresidents))
        DataGridView1 = New DataGridView()
        txtresidentid = New TextBox()
        txtfirstname = New TextBox()
        txtlastname = New TextBox()
        txtage = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        dtpbirthdate = New DateTimePicker()
        cbostatus = New ComboBox()
        cbogender = New ComboBox()
        PictureBox1 = New PictureBox()
        Label9 = New Label()
        txtsearch = New TextBox()
        btnadd = New Button()
        btnupdate = New Button()
        btndelete = New Button()
        cbositio = New ComboBox()
        Label10 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(10, 207)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1768, 965)
        DataGridView1.TabIndex = 0
        ' 
        ' txtresidentid
        ' 
        txtresidentid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtresidentid.Location = New Point(539, 19)
        txtresidentid.Margin = New Padding(2)
        txtresidentid.Name = "txtresidentid"
        txtresidentid.Size = New Size(266, 34)
        txtresidentid.TabIndex = 1
        ' 
        ' txtfirstname
        ' 
        txtfirstname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtfirstname.Location = New Point(539, 60)
        txtfirstname.Margin = New Padding(2)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(266, 34)
        txtfirstname.TabIndex = 2
        ' 
        ' txtlastname
        ' 
        txtlastname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtlastname.Location = New Point(539, 100)
        txtlastname.Margin = New Padding(2)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(266, 34)
        txtlastname.TabIndex = 3
        ' 
        ' txtage
        ' 
        txtage.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtage.Location = New Point(539, 141)
        txtage.Margin = New Padding(2)
        txtage.Name = "txtage"
        txtage.Size = New Size(266, 34)
        txtage.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(418, 26)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 28)
        Label1.TabIndex = 9
        Label1.Text = "Resident ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(417, 66)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 28)
        Label2.TabIndex = 10
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(418, 106)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 28)
        Label3.TabIndex = 11
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(418, 147)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 28)
        Label4.TabIndex = 12
        Label4.Text = "Age"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(864, 149)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 28)
        Label5.TabIndex = 16
        Label5.Text = "Status"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.Location = New Point(864, 103)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 28)
        Label6.TabIndex = 15
        Label6.Text = "Sitio"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.Location = New Point(864, 62)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 28)
        Label7.TabIndex = 14
        Label7.Text = "Birthdate"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label8.Location = New Point(864, 22)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 28)
        Label8.TabIndex = 13
        Label8.Text = "Gender"
        ' 
        ' dtpbirthdate
        ' 
        dtpbirthdate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpbirthdate.Location = New Point(962, 58)
        dtpbirthdate.Margin = New Padding(2)
        dtpbirthdate.Name = "dtpbirthdate"
        dtpbirthdate.Size = New Size(395, 34)
        dtpbirthdate.TabIndex = 17
        ' 
        ' cbostatus
        ' 
        cbostatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        cbostatus.FormattingEnabled = True
        cbostatus.Items.AddRange(New Object() {"Single ", "Married", "Widowed", "Separated", "Annulled", "Divorced", "Live-in / Common-law"})
        cbostatus.Location = New Point(962, 143)
        cbostatus.Margin = New Padding(2)
        cbostatus.Name = "cbostatus"
        cbostatus.Size = New Size(395, 36)
        cbostatus.TabIndex = 18
        ' 
        ' cbogender
        ' 
        cbogender.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        cbogender.FormattingEnabled = True
        cbogender.Items.AddRange(New Object() {"Male", "Female"})
        cbogender.Location = New Point(962, 17)
        cbogender.Margin = New Padding(2)
        cbogender.Name = "cbogender"
        cbogender.Size = New Size(395, 36)
        cbogender.TabIndex = 19
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 10)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(10, 170)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 28)
        Label9.TabIndex = 21
        Label9.Text = "Search By:"
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(117, 170)
        txtsearch.Margin = New Padding(2)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(218, 27)
        txtsearch.TabIndex = 22
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(1466, 35)
        btnadd.Margin = New Padding(2)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(246, 50)
        btnadd.TabIndex = 23
        btnadd.Text = "➕ Add"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(1466, 88)
        btnupdate.Margin = New Padding(2)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(246, 50)
        btnupdate.TabIndex = 24
        btnupdate.Text = "✏️ Update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Location = New Point(1466, 141)
        btndelete.Margin = New Padding(2)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(246, 50)
        btndelete.TabIndex = 25
        btndelete.Text = "🗑️ Delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' cbositio
        ' 
        cbositio.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        cbositio.FormattingEnabled = True
        cbositio.Items.AddRange(New Object() {"Camella Homes III", "", "Lake Shore Subdivision", "", "Lindenwood Residences", "", "Midland II Subdivision", "", "Parkhomes Subdivision", "", "Planas", "", "Sto. Niño Village", "", "Susana Heights Subdivision", "", "Villa Carolina I", "", "Villa Carolina II"})
        cbositio.Location = New Point(962, 100)
        cbositio.Margin = New Padding(2)
        cbositio.Name = "cbositio"
        cbositio.Size = New Size(395, 36)
        cbositio.TabIndex = 26
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label10.Location = New Point(188, 10)
        Label10.Name = "Label10"
        Label10.Size = New Size(203, 54)
        Label10.TabIndex = 45
        Label10.Text = "Residents"
        ' 
        ' frmresidents
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        ClientSize = New Size(1539, 844)
        Controls.Add(Label10)
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
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "frmresidents"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmresidents"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtresidentid As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpbirthdate As DateTimePicker
    Friend WithEvents cbostatus As ComboBox
    Friend WithEvents cbogender As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents cbositio As ComboBox
    Friend WithEvents Label10 As Label
End Class
