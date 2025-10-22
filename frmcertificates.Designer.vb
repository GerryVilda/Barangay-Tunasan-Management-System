<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcertificates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCertificates))
        Panel1 = New Panel()
        Label2 = New Label()
        CboCertificatesSearchBy = New ComboBox()
        btnGeneratePDF = New Button()
        dgvcertifications = New DataGridView()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(dgvcertifications, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(CboCertificatesSearchBy)
        Panel1.Controls.Add(btnGeneratePDF)
        Panel1.Controls.Add(dgvcertifications)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(33, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1369, 903)
        Panel1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 38)
        Label2.TabIndex = 25
        Label2.Text = "Search by:"
        ' 
        ' CboCertificatesSearchBy
        ' 
        CboCertificatesSearchBy.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CboCertificatesSearchBy.FormattingEnabled = True
        CboCertificatesSearchBy.Location = New Point(169, 107)
        CboCertificatesSearchBy.Name = "CboCertificatesSearchBy"
        CboCertificatesSearchBy.Size = New Size(470, 40)
        CboCertificatesSearchBy.TabIndex = 24
        ' 
        ' btnGeneratePDF
        ' 
        btnGeneratePDF.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGeneratePDF.Location = New Point(1126, 763)
        btnGeneratePDF.Name = "btnGeneratePDF"
        btnGeneratePDF.Size = New Size(223, 101)
        btnGeneratePDF.TabIndex = 23
        btnGeneratePDF.Text = "📄 Generate PDF"
        btnGeneratePDF.UseVisualStyleBackColor = True
        ' 
        ' dgvcertifications
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(184), CByte(77))
        dgvcertifications.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvcertifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcertifications.Location = New Point(17, 165)
        dgvcertifications.Name = "dgvcertifications"
        dgvcertifications.RowHeadersWidth = 62
        dgvcertifications.Size = New Size(1333, 577)
        dgvcertifications.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(49), CByte(146))
        Label1.Location = New Point(17, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(329, 65)
        Label1.TabIndex = 0
        Label1.Text = "Certifications"
        ' 
        ' FrmCertificates
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1434, 978)
        Controls.Add(Panel1)
        Name = "FrmCertificates"
        Text = "frmcertificates"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvcertifications, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGeneratePDF As Button
    Friend WithEvents dgvcertifications As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CboCertificatesSearchBy As ComboBox
    Friend WithEvents Label2 As Label
End Class
