<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIsotopes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIsotopes))
        Me.isotopeTable = New System.Windows.Forms.DataGridView()
        Me.isotope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.protons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neutrons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.halflife = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.decay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.daughter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.isotopeTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'isotopeTable
        '
        Me.isotopeTable.AllowUserToDeleteRows = False
        Me.isotopeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.isotopeTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.isotope, Me.protons, Me.neutrons, Me.mass, Me.halflife, Me.decay, Me.daughter, Me.spin})
        Me.isotopeTable.Location = New System.Drawing.Point(12, 12)
        Me.isotopeTable.Name = "isotopeTable"
        Me.isotopeTable.Size = New System.Drawing.Size(867, 347)
        Me.isotopeTable.TabIndex = 25
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
        'FormIsotopes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 371)
        Me.Controls.Add(Me.isotopeTable)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormIsotopes"
        Me.Text = "Isotopes - Name"
        CType(Me.isotopeTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents isotopeTable As DataGridView
    Friend WithEvents isotope As DataGridViewTextBoxColumn
    Friend WithEvents protons As DataGridViewTextBoxColumn
    Friend WithEvents neutrons As DataGridViewTextBoxColumn
    Friend WithEvents mass As DataGridViewTextBoxColumn
    Friend WithEvents halflife As DataGridViewTextBoxColumn
    Friend WithEvents decay As DataGridViewTextBoxColumn
    Friend WithEvents daughter As DataGridViewTextBoxColumn
    Friend WithEvents spin As DataGridViewTextBoxColumn
End Class
