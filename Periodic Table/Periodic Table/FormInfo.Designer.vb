<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInfo))
        Me.eTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eOverview = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.eAtomicStructure1 = New System.Windows.Forms.Label()
        Me.eAtomicStructure2 = New System.Windows.Forms.Label()
        Me.eAtomicStructure3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ePhysicalProperties1 = New System.Windows.Forms.Label()
        Me.ePhysicalProperties2 = New System.Windows.Forms.Label()
        Me.ePhysicalProperties3 = New System.Windows.Forms.Label()
        Me.ePhysicalProperties4 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.eOxidationStates1 = New System.Windows.Forms.Label()
        Me.eOxidationStates2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.viewWiki = New System.Windows.Forms.Button()
        Me.tmpElName = New System.Windows.Forms.TextBox()
        Me.eIsRadioactive = New System.Windows.Forms.PictureBox()
        Me.eIsotopes = New System.Windows.Forms.Label()
        Me.viewIsotopes = New System.Windows.Forms.Button()
        Me.viewIsotopes2 = New System.Windows.Forms.Button()
        CType(Me.eIsRadioactive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'eTitle
        '
        Me.eTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eTitle.Location = New System.Drawing.Point(12, 9)
        Me.eTitle.Name = "eTitle"
        Me.eTitle.Size = New System.Drawing.Size(1257, 34)
        Me.eTitle.TabIndex = 8
        Me.eTitle.Text = "Element Name"
        Me.eTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 34)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Overview"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'eOverview
        '
        Me.eOverview.AutoSize = True
        Me.eOverview.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eOverview.Location = New System.Drawing.Point(12, 77)
        Me.eOverview.Name = "eOverview"
        Me.eOverview.Size = New System.Drawing.Size(272, 14)
        Me.eOverview.TabIndex = 10
        Me.eOverview.Text = "The element x has the symbol x and is a x"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 34)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Atomic Structure"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'eAtomicStructure1
        '
        Me.eAtomicStructure1.AutoSize = True
        Me.eAtomicStructure1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eAtomicStructure1.Location = New System.Drawing.Point(12, 140)
        Me.eAtomicStructure1.Name = "eAtomicStructure1"
        Me.eAtomicStructure1.Size = New System.Drawing.Size(355, 14)
        Me.eAtomicStructure1.TabIndex = 12
        Me.eAtomicStructure1.Text = "It has an atomic weight of x and an atomic number of x"
        '
        'eAtomicStructure2
        '
        Me.eAtomicStructure2.AutoSize = True
        Me.eAtomicStructure2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eAtomicStructure2.Location = New System.Drawing.Point(14, 160)
        Me.eAtomicStructure2.Name = "eAtomicStructure2"
        Me.eAtomicStructure2.Size = New System.Drawing.Size(282, 14)
        Me.eAtomicStructure2.TabIndex = 13
        Me.eAtomicStructure2.Text = "x has x protons, x electrons and x neutrons"
        '
        'eAtomicStructure3
        '
        Me.eAtomicStructure3.AutoSize = True
        Me.eAtomicStructure3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eAtomicStructure3.Location = New System.Drawing.Point(14, 180)
        Me.eAtomicStructure3.Name = "eAtomicStructure3"
        Me.eAtomicStructure3.Size = New System.Drawing.Size(363, 14)
        Me.eAtomicStructure3.TabIndex = 14
        Me.eAtomicStructure3.Text = "x is in the x-block, and has an electron configuration of x"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(14, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 34)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Physical Properties"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ePhysicalProperties1
        '
        Me.ePhysicalProperties1.AutoSize = True
        Me.ePhysicalProperties1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ePhysicalProperties1.Location = New System.Drawing.Point(14, 239)
        Me.ePhysicalProperties1.Name = "ePhysicalProperties1"
        Me.ePhysicalProperties1.Size = New System.Drawing.Size(198, 14)
        Me.ePhysicalProperties1.TabIndex = 16
        Me.ePhysicalProperties1.Text = "x is a x x at room temperature"
        '
        'ePhysicalProperties2
        '
        Me.ePhysicalProperties2.AutoSize = True
        Me.ePhysicalProperties2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ePhysicalProperties2.Location = New System.Drawing.Point(14, 259)
        Me.ePhysicalProperties2.Name = "ePhysicalProperties2"
        Me.ePhysicalProperties2.Size = New System.Drawing.Size(339, 14)
        Me.ePhysicalProperties2.TabIndex = 17
        Me.ePhysicalProperties2.Text = "It has a melting boint of xC, and a boiling point of xC"
        '
        'ePhysicalProperties3
        '
        Me.ePhysicalProperties3.AutoSize = True
        Me.ePhysicalProperties3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ePhysicalProperties3.Location = New System.Drawing.Point(14, 279)
        Me.ePhysicalProperties3.Name = "ePhysicalProperties3"
        Me.ePhysicalProperties3.Size = New System.Drawing.Size(170, 14)
        Me.ePhysicalProperties3.TabIndex = 18
        Me.ePhysicalProperties3.Text = "It has a density of xg/cm³"
        '
        'ePhysicalProperties4
        '
        Me.ePhysicalProperties4.AutoSize = True
        Me.ePhysicalProperties4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ePhysicalProperties4.Location = New System.Drawing.Point(14, 299)
        Me.ePhysicalProperties4.Name = "ePhysicalProperties4"
        Me.ePhysicalProperties4.Size = New System.Drawing.Size(192, 14)
        Me.ePhysicalProperties4.TabIndex = 19
        Me.ePhysicalProperties4.Text = "x has a x crystalline structure"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(12, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 34)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Oxidation States"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'eOxidationStates1
        '
        Me.eOxidationStates1.AutoSize = True
        Me.eOxidationStates1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eOxidationStates1.Location = New System.Drawing.Point(14, 364)
        Me.eOxidationStates1.Name = "eOxidationStates1"
        Me.eOxidationStates1.Size = New System.Drawing.Size(268, 14)
        Me.eOxidationStates1.TabIndex = 21
        Me.eOxidationStates1.Text = "x can form the following oxidation states:"
        '
        'eOxidationStates2
        '
        Me.eOxidationStates2.AutoSize = True
        Me.eOxidationStates2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eOxidationStates2.Location = New System.Drawing.Point(12, 384)
        Me.eOxidationStates2.Name = "eOxidationStates2"
        Me.eOxidationStates2.Size = New System.Drawing.Size(44, 14)
        Me.eOxidationStates2.TabIndex = 22
        Me.eOxidationStates2.Text = "x, x, x"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(14, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 34)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Isotopes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'viewWiki
        '
        Me.viewWiki.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.viewWiki.Location = New System.Drawing.Point(767, 9)
        Me.viewWiki.Name = "viewWiki"
        Me.viewWiki.Size = New System.Drawing.Size(121, 22)
        Me.viewWiki.TabIndex = 26
        Me.viewWiki.Text = "View Wikipedia Entry"
        Me.viewWiki.UseVisualStyleBackColor = True
        '
        'tmpElName
        '
        Me.tmpElName.Location = New System.Drawing.Point(431, 9)
        Me.tmpElName.Name = "tmpElName"
        Me.tmpElName.Size = New System.Drawing.Size(121, 20)
        Me.tmpElName.TabIndex = 27
        Me.tmpElName.Visible = False
        '
        'eIsRadioactive
        '
        Me.eIsRadioactive.Image = Global.Periodic_Table.My.Resources.Resources.radioactive1
        Me.eIsRadioactive.Location = New System.Drawing.Point(375, 9)
        Me.eIsRadioactive.Name = "eIsRadioactive"
        Me.eIsRadioactive.Size = New System.Drawing.Size(50, 54)
        Me.eIsRadioactive.TabIndex = 28
        Me.eIsRadioactive.TabStop = False
        Me.eIsRadioactive.Visible = False
        '
        'eIsotopes
        '
        Me.eIsotopes.AutoSize = True
        Me.eIsotopes.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eIsotopes.Location = New System.Drawing.Point(14, 455)
        Me.eIsotopes.Name = "eIsotopes"
        Me.eIsotopes.Size = New System.Drawing.Size(110, 14)
        Me.eIsotopes.TabIndex = 29
        Me.eIsotopes.Text = "x has x isotopes"
        '
        'viewIsotopes
        '
        Me.viewIsotopes.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.viewIsotopes.Location = New System.Drawing.Point(12, 472)
        Me.viewIsotopes.Name = "viewIsotopes"
        Me.viewIsotopes.Size = New System.Drawing.Size(121, 22)
        Me.viewIsotopes.TabIndex = 30
        Me.viewIsotopes.Text = "View Isotopes"
        Me.viewIsotopes.UseVisualStyleBackColor = True
        '
        'viewIsotopes2
        '
        Me.viewIsotopes2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.viewIsotopes2.Location = New System.Drawing.Point(767, 37)
        Me.viewIsotopes2.Name = "viewIsotopes2"
        Me.viewIsotopes2.Size = New System.Drawing.Size(121, 22)
        Me.viewIsotopes2.TabIndex = 31
        Me.viewIsotopes2.Text = "View Isotopes"
        Me.viewIsotopes2.UseVisualStyleBackColor = True
        '
        'FormInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(911, 513)
        Me.Controls.Add(Me.viewIsotopes2)
        Me.Controls.Add(Me.viewIsotopes)
        Me.Controls.Add(Me.eIsotopes)
        Me.Controls.Add(Me.eIsRadioactive)
        Me.Controls.Add(Me.tmpElName)
        Me.Controls.Add(Me.viewWiki)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.eOxidationStates2)
        Me.Controls.Add(Me.eOxidationStates1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ePhysicalProperties4)
        Me.Controls.Add(Me.ePhysicalProperties3)
        Me.Controls.Add(Me.ePhysicalProperties2)
        Me.Controls.Add(Me.ePhysicalProperties1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.eAtomicStructure3)
        Me.Controls.Add(Me.eAtomicStructure2)
        Me.Controls.Add(Me.eAtomicStructure1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.eOverview)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.eTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormInfo"
        Me.Text = "Information - Name"
        CType(Me.eIsRadioactive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents eTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents eOverview As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents eAtomicStructure1 As Label
    Friend WithEvents eAtomicStructure2 As Label
    Friend WithEvents eAtomicStructure3 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ePhysicalProperties1 As Label
    Friend WithEvents ePhysicalProperties2 As Label
    Friend WithEvents ePhysicalProperties3 As Label
    Friend WithEvents ePhysicalProperties4 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents eOxidationStates1 As Label
    Friend WithEvents eOxidationStates2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents viewWiki As Button
    Friend WithEvents tmpElName As TextBox
    Friend WithEvents eIsRadioactive As PictureBox
    Friend WithEvents eIsotopes As Label
    Friend WithEvents viewIsotopes As Button
    Friend WithEvents viewIsotopes2 As Button
End Class
