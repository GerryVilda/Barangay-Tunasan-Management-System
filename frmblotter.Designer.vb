<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmblotter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmblotter))
        Label1 = New Label()
        Panel1 = New Panel()
        btndeleteblotter = New Button()
        btnupdateblotter = New Button()
        btnsaveblotter = New Button()
        dgvblotters = New DataGridView()
        txtdetails = New TextBox()
        txtincidentdate = New DateTimePicker()
        dtpcreatedat = New DateTimePicker()
        txtremarks = New TextBox()
        txtlocation = New TextBox()
        txtincidentype = New TextBox()
        txtrespondent = New TextBox()
        txtcomplaint = New TextBox()
        txtblotterid = New TextBox()
        cbostatus = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(dgvblotters, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(17, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(306, 54)
        Label1.TabIndex = 0
        Label1.Text = "Blotter Reports"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btndeleteblotter)
        Panel1.Controls.Add(btnupdateblotter)
        Panel1.Controls.Add(btnsaveblotter)
        Panel1.Controls.Add(dgvblotters)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtdetails)
        Panel1.Controls.Add(txtincidentdate)
        Panel1.Controls.Add(dtpcreatedat)
        Panel1.Controls.Add(txtremarks)
        Panel1.Controls.Add(txtlocation)
        Panel1.Controls.Add(txtincidentype)
        Panel1.Controls.Add(txtrespondent)
        Panel1.Controls.Add(txtcomplaint)
        Panel1.Controls.Add(txtblotterid)
        Panel1.Controls.Add(cbostatus)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(30, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1369, 903)
        Panel1.TabIndex = 3
        ' 
        ' btndeleteblotter
        ' 
        btndeleteblotter.Location = New Point(1180, 502)
        btndeleteblotter.Name = "btndeleteblotter"
        btndeleteblotter.Size = New Size(171, 101)
        btndeleteblotter.TabIndex = 23
        btndeleteblotter.Text = "🗑️ Delete"
        btndeleteblotter.UseVisualStyleBackColor = True
        ' 
        ' btnupdateblotter
        ' 
        btnupdateblotter.Location = New Point(1003, 502)
        btnupdateblotter.Name = "btnupdateblotter"
        btnupdateblotter.Size = New Size(171, 101)
        btnupdateblotter.TabIndex = 22
        btnupdateblotter.Text = "✏️ Update"
        btnupdateblotter.UseVisualStyleBackColor = True
        ' 
        ' btnsaveblotter
        ' 
        btnsaveblotter.Location = New Point(826, 502)
        btnsaveblotter.Name = "btnsaveblotter"
        btnsaveblotter.Size = New Size(171, 101)
        btnsaveblotter.TabIndex = 21
        btnsaveblotter.Text = "➕ Save"
        btnsaveblotter.UseVisualStyleBackColor = True
        ' 
        ' dgvblotters
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        dgvblotters.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvblotters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvblotters.Location = New Point(18, 609)
        dgvblotters.Name = "dgvblotters"
        dgvblotters.RowHeadersWidth = 62
        dgvblotters.Size = New Size(1333, 279)
        dgvblotters.TabIndex = 20
        ' 
        ' txtdetails
        ' 
        txtdetails.Location = New Point(537, 52)
        txtdetails.Multiline = True
        txtdetails.Name = "txtdetails"
        txtdetails.Size = New Size(815, 263)
        txtdetails.TabIndex = 19
        ' 
        ' txtincidentdate
        ' 
        txtincidentdate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtincidentdate.Location = New Point(190, 330)
        txtincidentdate.Name = "txtincidentdate"
        txtincidentdate.Size = New Size(337, 34)
        txtincidentdate.TabIndex = 18
        ' 
        ' dtpcreatedat
        ' 
        dtpcreatedat.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        dtpcreatedat.Location = New Point(190, 513)
        dtpcreatedat.Name = "dtpcreatedat"
        dtpcreatedat.Size = New Size(337, 34)
        dtpcreatedat.TabIndex = 17
        ' 
        ' txtremarks
        ' 
        txtremarks.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtremarks.Location = New Point(538, 356)
        txtremarks.Multiline = True
        txtremarks.Name = "txtremarks"
        txtremarks.Size = New Size(813, 140)
        txtremarks.TabIndex = 16
        ' 
        ' txtlocation
        ' 
        txtlocation.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtlocation.Location = New Point(190, 390)
        txtlocation.Name = "txtlocation"
        txtlocation.Size = New Size(337, 34)
        txtlocation.TabIndex = 15
        ' 
        ' txtincidentype
        ' 
        txtincidentype.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtincidentype.Location = New Point(190, 276)
        txtincidentype.Name = "txtincidentype"
        txtincidentype.Size = New Size(337, 34)
        txtincidentype.TabIndex = 14
        ' 
        ' txtrespondent
        ' 
        txtrespondent.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtrespondent.Location = New Point(190, 222)
        txtrespondent.Name = "txtrespondent"
        txtrespondent.Size = New Size(337, 34)
        txtrespondent.TabIndex = 13
        ' 
        ' txtcomplaint
        ' 
        txtcomplaint.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtcomplaint.Location = New Point(190, 168)
        txtcomplaint.Name = "txtcomplaint"
        txtcomplaint.Size = New Size(337, 34)
        txtcomplaint.TabIndex = 12
        ' 
        ' txtblotterid
        ' 
        txtblotterid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtblotterid.Location = New Point(190, 113)
        txtblotterid.Name = "txtblotterid"
        txtblotterid.ReadOnly = True
        txtblotterid.Size = New Size(337, 34)
        txtblotterid.TabIndex = 11
        ' 
        ' cbostatus
        ' 
        cbostatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        cbostatus.FormattingEnabled = True
        cbostatus.Items.AddRange(New Object() {"Pending", "Under Investigation", "Resolved"})
        cbostatus.Location = New Point(190, 448)
        cbostatus.Name = "cbostatus"
        cbostatus.Size = New Size(337, 36)
        cbostatus.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.Location = New Point(17, 518)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 28)
        Label7.TabIndex = 9
        Label7.Text = "Created A t:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label8.Location = New Point(535, 321)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 28)
        Label8.TabIndex = 8
        Label8.Text = "Remarks:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label9.Location = New Point(17, 448)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 28)
        Label9.TabIndex = 7
        Label9.Text = "Status:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label10.Location = New Point(17, 335)
        Label10.Name = "Label10"
        Label10.Size = New Size(139, 28)
        Label10.TabIndex = 6
        Label10.Text = "Incident Date:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label11.Location = New Point(17, 171)
        Label11.Name = "Label11"
        Label11.Size = New Size(110, 28)
        Label11.TabIndex = 5
        Label11.Text = "Complaint:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.Location = New Point(532, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 28)
        Label6.TabIndex = 4
        Label6.Text = "Details:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(17, 390)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 28)
        Label5.TabIndex = 3
        Label5.Text = "Location:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(18, 279)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 28)
        Label4.TabIndex = 2
        Label4.Text = "Incident Type:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(18, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 28)
        Label3.TabIndex = 1
        Label3.Text = "Respondent:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(17, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 28)
        Label2.TabIndex = 0
        Label2.Text = "Blotter ID:"
        ' 
        ' frmblotter
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1777, 1055)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmblotter"
        Text = "frmblotter"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvblotters, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtincidentdate As DateTimePicker
    Friend WithEvents dtpcreatedat As DateTimePicker
    Friend WithEvents txtremarks As TextBox
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents txtincidentype As TextBox
    Friend WithEvents txtrespondent As TextBox
    Friend WithEvents txtcomplaint As TextBox
    Friend WithEvents txtblotterid As TextBox
    Friend WithEvents cbostatus As ComboBox
    Friend WithEvents txtdetails As TextBox
    Friend WithEvents dgvblotters As DataGridView
    Friend WithEvents btndeleteblotter As Button
    Friend WithEvents btnupdateblotter As Button
    Friend WithEvents btnsaveblotter As Button
End Class
