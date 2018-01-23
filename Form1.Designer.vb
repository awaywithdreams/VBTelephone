<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.lstdir = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btndeldir = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuabout = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuclose = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menudeletedir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menucreate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuadd = New System.Windows.Forms.ToolStripMenuItem()
        Me.menumodify = New System.Windows.Forms.ToolStripMenuItem()
        Me.menudelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.menudisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvcontacts = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvcontacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Location = New System.Drawing.Point(6, 34)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(74, 39)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Location = New System.Drawing.Point(8, 76)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(72, 42)
        Me.btndelete.TabIndex = 1
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnmodify
        '
        Me.btnmodify.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmodify.Location = New System.Drawing.Point(84, 34)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(85, 39)
        Me.btnmodify.TabIndex = 2
        Me.btnmodify.Text = "Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btndisplay
        '
        Me.btndisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndisplay.Location = New System.Drawing.Point(84, 76)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(85, 42)
        Me.btndisplay.TabIndex = 3
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'lstdir
        '
        Me.lstdir.BackColor = System.Drawing.Color.Khaki
        Me.lstdir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstdir.FormattingEnabled = True
        Me.lstdir.ItemHeight = 23
        Me.lstdir.Location = New System.Drawing.Point(6, 27)
        Me.lstdir.Name = "lstdir"
        Me.lstdir.Size = New System.Drawing.Size(230, 92)
        Me.lstdir.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btndisplay)
        Me.GroupBox1.Controls.Add(Me.btnmodify)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(278, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 133)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Controls"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btncreate)
        Me.GroupBox2.Controls.Add(Me.btndeldir)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 107)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Directory Controls"
        '
        'btncreate
        '
        Me.btncreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncreate.Location = New System.Drawing.Point(86, 52)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(75, 39)
        Me.btncreate.TabIndex = 1
        Me.btncreate.Text = "Create"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'btndeldir
        '
        Me.btndeldir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeldir.Location = New System.Drawing.Point(6, 52)
        Me.btndeldir.Name = "btndeldir"
        Me.btndeldir.Size = New System.Drawing.Size(75, 39)
        Me.btndeldir.TabIndex = 0
        Me.btndeldir.Text = "Delete"
        Me.btndeldir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DirectoriesToolStripMenuItem, Me.ContactsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(471, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuabout, Me.menuclose})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'menuabout
        '
        Me.menuabout.Image = CType(resources.GetObject("menuabout.Image"), System.Drawing.Image)
        Me.menuabout.Name = "menuabout"
        Me.menuabout.Size = New System.Drawing.Size(152, 24)
        Me.menuabout.Text = "About"
        '
        'menuclose
        '
        Me.menuclose.Image = CType(resources.GetObject("menuclose.Image"), System.Drawing.Image)
        Me.menuclose.Name = "menuclose"
        Me.menuclose.Size = New System.Drawing.Size(152, 24)
        Me.menuclose.Text = "Close"
        '
        'DirectoriesToolStripMenuItem
        '
        Me.DirectoriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menudeletedir, Me.menucreate})
        Me.DirectoriesToolStripMenuItem.Image = CType(resources.GetObject("DirectoriesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DirectoriesToolStripMenuItem.Name = "DirectoriesToolStripMenuItem"
        Me.DirectoriesToolStripMenuItem.Size = New System.Drawing.Size(115, 24)
        Me.DirectoriesToolStripMenuItem.Text = "Directories"
        '
        'menudeletedir
        '
        Me.menudeletedir.Image = CType(resources.GetObject("menudeletedir.Image"), System.Drawing.Image)
        Me.menudeletedir.Name = "menudeletedir"
        Me.menudeletedir.Size = New System.Drawing.Size(124, 24)
        Me.menudeletedir.Text = "Delete"
        '
        'menucreate
        '
        Me.menucreate.Image = CType(resources.GetObject("menucreate.Image"), System.Drawing.Image)
        Me.menucreate.Name = "menucreate"
        Me.menucreate.Size = New System.Drawing.Size(124, 24)
        Me.menucreate.Text = "Create"
        '
        'ContactsToolStripMenuItem
        '
        Me.ContactsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuadd, Me.menumodify, Me.menudelete, Me.menudisplay})
        Me.ContactsToolStripMenuItem.Image = CType(resources.GetObject("ContactsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
        Me.ContactsToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.ContactsToolStripMenuItem.Text = "Contacts"
        '
        'menuadd
        '
        Me.menuadd.Image = CType(resources.GetObject("menuadd.Image"), System.Drawing.Image)
        Me.menuadd.Name = "menuadd"
        Me.menuadd.Size = New System.Drawing.Size(134, 24)
        Me.menuadd.Text = "Add"
        '
        'menumodify
        '
        Me.menumodify.Image = CType(resources.GetObject("menumodify.Image"), System.Drawing.Image)
        Me.menumodify.Name = "menumodify"
        Me.menumodify.Size = New System.Drawing.Size(134, 24)
        Me.menumodify.Text = "Modify"
        '
        'menudelete
        '
        Me.menudelete.Image = CType(resources.GetObject("menudelete.Image"), System.Drawing.Image)
        Me.menudelete.Name = "menudelete"
        Me.menudelete.Size = New System.Drawing.Size(134, 24)
        Me.menudelete.Text = "Delete"
        '
        'menudisplay
        '
        Me.menudisplay.Image = CType(resources.GetObject("menudisplay.Image"), System.Drawing.Image)
        Me.menudisplay.Name = "menudisplay"
        Me.menudisplay.Size = New System.Drawing.Size(134, 24)
        Me.menudisplay.Text = "Display"
        '
        'dgvcontacts
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvcontacts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvcontacts.BackgroundColor = System.Drawing.Color.Khaki
        Me.dgvcontacts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvcontacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvcontacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcontacts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvcontacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcontacts.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvcontacts.GridColor = System.Drawing.Color.Gold
        Me.dgvcontacts.Location = New System.Drawing.Point(6, 29)
        Me.dgvcontacts.Name = "dgvcontacts"
        Me.dgvcontacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcontacts.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvcontacts.RowHeadersVisible = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Thistle
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvcontacts.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvcontacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcontacts.Size = New System.Drawing.Size(258, 124)
        Me.dgvcontacts.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.dgvcontacts)
        Me.GroupBox3.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(189, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(270, 159)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contacts"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.lstdir)
        Me.GroupBox4.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(250, 133)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Directories"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(471, 341)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Phone Directories"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvcontacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnadd As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnmodify As Button
    Friend WithEvents btndisplay As Button
    Friend WithEvents lstdir As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btncreate As Button
    Friend WithEvents btndeldir As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuabout As ToolStripMenuItem
    Friend WithEvents menuclose As ToolStripMenuItem
    Friend WithEvents DirectoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menudeletedir As ToolStripMenuItem
    Friend WithEvents menucreate As ToolStripMenuItem
    Friend WithEvents ContactsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuadd As ToolStripMenuItem
    Friend WithEvents menumodify As ToolStripMenuItem
    Friend WithEvents menudelete As ToolStripMenuItem
    Friend WithEvents menudisplay As ToolStripMenuItem
    Friend WithEvents dgvcontacts As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
