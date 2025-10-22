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
        txtsitio = New TextBox()
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 259)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1389, 707)
        DataGridView1.TabIndex = 0
        ' 
        ' txtresidentid
        ' 
        txtresidentid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtresidentid.Location = New Point(389, 4)
        txtresidentid.Name = "txtresidentid"
        txtresidentid.Size = New Size(332, 39)
        txtresidentid.TabIndex = 1
        ' 
        ' txtfirstname
        ' 
        txtfirstname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtfirstname.Location = New Point(389, 55)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(332, 39)
        txtfirstname.TabIndex = 2
        ' 
        ' txtlastname
        ' 
        txtlastname.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtlastname.Location = New Point(389, 105)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(332, 39)
        txtlastname.TabIndex = 3
        ' 
        ' txtage
        ' 
        txtage.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtage.Location = New Point(389, 156)
        txtage.Name = "txtage"
        txtage.Size = New Size(332, 39)
        txtage.TabIndex = 4
        ' 
        ' txtsitio
        ' 
        txtsitio.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtsitio.Location = New Point(864, 109)
        txtsitio.Name = "txtsitio"
        txtsitio.Size = New Size(337, 39)
        txtsitio.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(238, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 32)
        Label1.TabIndex = 9
        Label1.Text = "Resident ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(236, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 32)
        Label2.TabIndex = 10
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(238, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 32)
        Label3.TabIndex = 11
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(238, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 32)
        Label4.TabIndex = 12
        Label4.Text = "Age"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(741, 172)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 32)
        Label5.TabIndex = 16
        Label5.Text = "Status"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.Location = New Point(741, 112)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 32)
        Label6.TabIndex = 15
        Label6.Text = "Sitio"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.Location = New Point(741, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 32)
        Label7.TabIndex = 14
        Label7.Text = "Birthdate"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label8.Location = New Point(741, 10)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 32)
        Label8.TabIndex = 13
        Label8.Text = "Gender"
        ' 
        ' dtpbirthdate
        ' 
        dtpbirthdate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpbirthdate.Location = New Point(864, 55)
        dtpbirthdate.Name = "dtpbirthdate"
        dtpbirthdate.Size = New Size(337, 39)
        dtpbirthdate.TabIndex = 17
        ' 
        ' cbostatus
        ' 
        cbostatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        cbostatus.FormattingEnabled = True
        cbostatus.Items.AddRange(New Object() {"Single ", "Married", "Widowed", "Separated", "Annulled", "Divorced", "Live-in / Common-law"})
        cbostatus.Location = New Point(864, 161)
        cbostatus.Name = "cbostatus"
        cbostatus.Size = New Size(337, 40)
        cbostatus.TabIndex = 18
        ' 
        ' cbogender
        ' 
        cbogender.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        cbogender.FormattingEnabled = True
        cbogender.Items.AddRange(New Object() {"Male", "Female"})
        cbogender.Location = New Point(864, 4)
        cbogender.Name = "cbogender"
        cbogender.Size = New Size(337, 40)
        cbogender.TabIndex = 19
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(216, 189)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(13, 212)
        Label9.Name = "Label9"
        Label9.Size = New Size(127, 32)
        Label9.TabIndex = 21
        Label9.Text = "Search By:"
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(146, 213)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(272, 31)
        txtsearch.TabIndex = 22
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(1242, 12)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(159, 62)
        btnadd.TabIndex = 23
        btnadd.Text = "➕ Add"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(1242, 78)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(159, 62)
        btnupdate.TabIndex = 24
        btnupdate.Text = "✏️ Update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Location = New Point(1242, 150)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(159, 62)
        btndelete.TabIndex = 25
        btndelete.Text = "🗑️ Delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' frmresidents
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        ClientSize = New Size(1412, 978)
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
        Controls.Add(txtsitio)
        Controls.Add(txtage)
        Controls.Add(txtlastname)
        Controls.Add(txtfirstname)
        Controls.Add(txtresidentid)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmresidents"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmresidents"
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
    Friend WithEvents txtsitio As TextBox
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
End Class
