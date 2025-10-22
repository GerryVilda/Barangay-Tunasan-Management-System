<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmincident
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmincident))
        Panel1 = New Panel()
        btnRefresh = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        btnSearch = New Button()
        TextBox1 = New TextBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        Panel4 = New Panel()
        Button1 = New Button()
        btnSave = New Button()
        ComboBox3 = New ComboBox()
        Label15 = New Label()
        ComboBox2 = New ComboBox()
        Label14 = New Label()
        TextBox3 = New TextBox()
        Label13 = New Label()
        TextBox2 = New TextBox()
        Label12 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label11 = New Label()
        Label10 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(195, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(923, 52)
        Panel1.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Blue
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.Transparent
        btnRefresh.Location = New Point(794, 9)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(97, 32)
        btnRefresh.TabIndex = 26
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.Transparent
        btnDelete.Location = New Point(668, 9)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(97, 32)
        btnDelete.TabIndex = 25
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Yellow
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(547, 9)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(97, 32)
        btnEdit.TabIndex = 24
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.Transparent
        btnAdd.Location = New Point(430, 9)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(97, 32)
        btnAdd.TabIndex = 23
        btnAdd.Text = "Add New"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(290, 46)
        Label1.TabIndex = 22
        Label1.Text = "Incident Reports"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(173, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(195, 61)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(923, 74)
        Panel2.TabIndex = 22
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(436, 41)
        Label9.Name = "Label9"
        Label9.Size = New Size(22, 25)
        Label9.TabIndex = 10
        Label9.Text = "0"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(370, 38)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 28)
        Label8.TabIndex = 9
        Label8.Text = "Total:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(323, 41)
        Label7.Name = "Label7"
        Label7.Size = New Size(22, 25)
        Label7.TabIndex = 8
        Label7.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(219, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 28)
        Label6.TabIndex = 7
        Label6.Text = "Resolved:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(160, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(22, 25)
        Label5.TabIndex = 6
        Label5.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(62, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 28)
        Label4.TabIndex = 5
        Label4.Text = "Pending:"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), Image)
        btnSearch.BackgroundImageLayout = ImageLayout.Zoom
        btnSearch.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(673, 4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(42, 31)
        btnSearch.TabIndex = 4
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(428, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search by complainant/respondent"
        TextBox1.Size = New Size(239, 30)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(345, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 28)
        Label3.TabIndex = 2
        Label3.Text = "Search:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"All", "Pending" & vbTab, "Resolved", "On Hold"})
        ComboBox1.Location = New Point(160, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 31)
        ComboBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 28)
        Label2.TabIndex = 0
        Label2.Text = "Filter by Status:"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(DataGridView1)
        Panel3.Location = New Point(12, 159)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(792, 611)
        Panel3.TabIndex = 23
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(786, 605)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(btnSave)
        Panel4.Controls.Add(ComboBox3)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(ComboBox2)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(TextBox3)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(TextBox2)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(DateTimePicker1)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(810, 162)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(308, 608)
        Panel4.TabIndex = 24
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gray
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(156, 503)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 39)
        Button1.TabIndex = 22
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(57, 503)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(93, 39)
        btnSave.TabIndex = 21
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"All", "Pending" & vbTab, "Resolved", "On Hold"})
        ComboBox3.Location = New Point(3, 423)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(302, 36)
        ComboBox3.TabIndex = 20
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(3, 392)
        Label15.Name = "Label15"
        Label15.Size = New Size(65, 28)
        Label15.TabIndex = 19
        Label15.Text = "Status"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"All", "Pending" & vbTab, "Resolved", "On Hold"})
        ComboBox2.Location = New Point(3, 341)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(302, 36)
        ComboBox2.TabIndex = 11
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(3, 310)
        Label14.Name = "Label14"
        Label14.Size = New Size(128, 28)
        Label14.TabIndex = 18
        Label14.Text = "Incident Type"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(3, 258)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(302, 34)
        TextBox3.TabIndex = 17
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(3, 227)
        Label13.Name = "Label13"
        Label13.Size = New Size(116, 28)
        Label13.TabIndex = 16
        Label13.Text = "Respondent"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(3, 177)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(302, 34)
        TextBox2.TabIndex = 15
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(3, 146)
        Label12.Name = "Label12"
        Label12.Size = New Size(124, 28)
        Label12.TabIndex = 14
        Label12.Text = "Complainant"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(3, 97)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(302, 34)
        DateTimePicker1.TabIndex = 13
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(3, 66)
        Label11.Name = "Label11"
        Label11.Size = New Size(117, 28)
        Label11.TabIndex = 12
        Label11.Text = "Report Date"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(3, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(184, 31)
        Label10.TabIndex = 11
        Label10.Text = "Incident Details"
        ' 
        ' frmincident
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(214), CByte(153))
        ClientSize = New Size(1130, 782)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "frmincident"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmincident"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label14 As Label
End Class
