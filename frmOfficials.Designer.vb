<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOfficials
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOfficials))
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(28, 44)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1369, 903)
        Panel1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(31, 175)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1301, 693)
        DataGridView1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(446, 65)
        Label2.TabIndex = 1
        Label2.Text = "Barangay Officials"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(621, 82)
        Button1.Name = "Button1"
        Button1.Size = New Size(233, 75)
        Button1.TabIndex = 3
        Button1.Text = "Add Official"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(860, 82)
        Button2.Name = "Button2"
        Button2.Size = New Size(233, 75)
        Button2.TabIndex = 4
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1099, 82)
        Button3.Name = "Button3"
        Button3.Size = New Size(233, 75)
        Button3.TabIndex = 5
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' frmOfficials
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1434, 978)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "frmOfficials"
        Text = "frmOfficials"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
