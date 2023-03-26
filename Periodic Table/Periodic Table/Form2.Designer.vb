<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.eTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eGeneral = New System.Windows.Forms.DataGridView()
        Me.one = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.two = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.eIsotope = New System.Windows.Forms.DataGridView()
        Me.isotope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.protons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neutrons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.halflife = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.decay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.daughter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.viewWiki = New System.Windows.Forms.Button()
        Me.tmpElName = New System.Windows.Forms.TextBox()
        CType(Me.eGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eIsotope, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'eTitle
        '
        Me.eTitle.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eTitle.Location = New System.Drawing.Point(12, 9)
        Me.eTitle.Name = "eTitle"
        Me.eTitle.Size = New System.Drawing.Size(190, 34)
        Me.eTitle.TabIndex = 7
        Me.eTitle.Text = "name (symbol)"
        Me.eTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Isotopes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'eGeneral
        '
        Me.eGeneral.AllowUserToDeleteRows = False
        Me.eGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.eGeneral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.one, Me.two})
        Me.eGeneral.Location = New System.Drawing.Point(12, 83)
        Me.eGeneral.Name = "eGeneral"
        Me.eGeneral.Size = New System.Drawing.Size(262, 368)
        Me.eGeneral.TabIndex = 10
        '
        'one
        '
        Me.one.HeaderText = "Name"
        Me.one.Name = "one"
        '
        'two
        '
        Me.two.HeaderText = "Value"
        Me.two.Name = "two"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "General"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'eIsotope
        '
        Me.eIsotope.AllowUserToDeleteRows = False
        Me.eIsotope.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.eIsotope.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.isotope, Me.protons, Me.neutrons, Me.mass, Me.halflife, Me.decay, Me.daughter, Me.spin})
        Me.eIsotope.Location = New System.Drawing.Point(294, 83)
        Me.eIsotope.Name = "eIsotope"
        Me.eIsotope.Size = New System.Drawing.Size(857, 368)
        Me.eIsotope.TabIndex = 12
        '
        'isotope
        '
        Me.isotope.HeaderText = "Isotope"
        Me.isotope.Name = "isotope"
        '
        'protons
        '
        Me.protons.HeaderText = "Protons"
        Me.protons.Name = "protons"
        '
        'neutrons
        '
        Me.neutrons.HeaderText = "Neutrons"
        Me.neutrons.Name = "neutrons"
        '
        'mass
        '
        Me.mass.HeaderText = "Mass"
        Me.mass.Name = "mass"
        '
        'halflife
        '
        Me.halflife.HeaderText = "Halflife"
        Me.halflife.Name = "halflife"
        '
        'decay
        '
        Me.decay.HeaderText = "Decay Mode(s)"
        Me.decay.Name = "decay"
        '
        'daughter
        '
        Me.daughter.HeaderText = "Daughter Isotope(s)"
        Me.daughter.Name = "daughter"
        '
        'spin
        '
        Me.spin.HeaderText = "Nuclear Spin"
        Me.spin.Name = "spin"
        '
        'viewWiki
        '
        Me.viewWiki.Location = New System.Drawing.Point(1055, 9)
        Me.viewWiki.Name = "viewWiki"
        Me.viewWiki.Size = New System.Drawing.Size(121, 22)
        Me.viewWiki.TabIndex = 13
        Me.viewWiki.Text = "See Wikipedia Entry"
        Me.viewWiki.UseVisualStyleBackColor = True
        '
        'tmpElName
        '
        Me.tmpElName.Location = New System.Drawing.Point(1076, 37)
        Me.tmpElName.Name = "tmpElName"
        Me.tmpElName.Size = New System.Drawing.Size(100, 20)
        Me.tmpElName.TabIndex = 14
        Me.tmpElName.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 463)
        Me.Controls.Add(Me.tmpElName)
        Me.Controls.Add(Me.viewWiki)
        Me.Controls.Add(Me.eIsotope)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.eGeneral)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.eTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Information - Name"
        CType(Me.eGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eIsotope, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents eTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents eGeneral As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents eIsotope As DataGridView
    Friend WithEvents one As DataGridViewTextBoxColumn
    Friend WithEvents two As DataGridViewTextBoxColumn
    Friend WithEvents isotope As DataGridViewTextBoxColumn
    Friend WithEvents protons As DataGridViewTextBoxColumn
    Friend WithEvents neutrons As DataGridViewTextBoxColumn
    Friend WithEvents mass As DataGridViewTextBoxColumn
    Friend WithEvents halflife As DataGridViewTextBoxColumn
    Friend WithEvents decay As DataGridViewTextBoxColumn
    Friend WithEvents daughter As DataGridViewTextBoxColumn
    Friend WithEvents spin As DataGridViewTextBoxColumn
    Friend WithEvents viewWiki As Button
    Friend WithEvents tmpElName As TextBox
End Class
