<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollectorDetails
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CollectorDetails))
        Dim Collector_IDLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Me.PG_DatabaseDataSet = New PG_Management_FinalPaper_.PG_DatabaseDataSet()
        Me.Collector_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Collector_TBTableAdapter = New PG_Management_FinalPaper_.PG_DatabaseDataSetTableAdapters.Collector_TBTableAdapter()
        Me.TableAdapterManager = New PG_Management_FinalPaper_.PG_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Collector_TBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Collector_TBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Collector_IDTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Collector_IDLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        CType(Me.PG_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Collector_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Collector_TBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Collector_TBBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PG_DatabaseDataSet
        '
        Me.PG_DatabaseDataSet.DataSetName = "PG_DatabaseDataSet"
        Me.PG_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Collector_TBBindingSource
        '
        Me.Collector_TBBindingSource.DataMember = "Collector_TB"
        Me.Collector_TBBindingSource.DataSource = Me.PG_DatabaseDataSet
        '
        'Collector_TBTableAdapter
        '
        Me.Collector_TBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Art_TBTableAdapter = Nothing
        Me.TableAdapterManager.Artist_TBTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Collector_TBTableAdapter = Me.Collector_TBTableAdapter
        Me.TableAdapterManager.UpdateOrder = PG_Management_FinalPaper_.PG_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Collector_TBBindingNavigator
        '
        Me.Collector_TBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Collector_TBBindingNavigator.BindingSource = Me.Collector_TBBindingSource
        Me.Collector_TBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Collector_TBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Collector_TBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Collector_TBBindingNavigatorSaveItem})
        Me.Collector_TBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Collector_TBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Collector_TBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Collector_TBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Collector_TBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Collector_TBBindingNavigator.Name = "Collector_TBBindingNavigator"
        Me.Collector_TBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Collector_TBBindingNavigator.Size = New System.Drawing.Size(399, 25)
        Me.Collector_TBBindingNavigator.TabIndex = 0
        Me.Collector_TBBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Collector_TBBindingNavigatorSaveItem
        '
        Me.Collector_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Collector_TBBindingNavigatorSaveItem.Image = CType(resources.GetObject("Collector_TBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Collector_TBBindingNavigatorSaveItem.Name = "Collector_TBBindingNavigatorSaveItem"
        Me.Collector_TBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Collector_TBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Collector_IDLabel
        '
        Collector_IDLabel.AutoSize = True
        Collector_IDLabel.Location = New System.Drawing.Point(20, 88)
        Collector_IDLabel.Name = "Collector_IDLabel"
        Collector_IDLabel.Size = New System.Drawing.Size(65, 13)
        Collector_IDLabel.TabIndex = 1
        Collector_IDLabel.Text = "Collector ID:"
        '
        'Collector_IDTextBox
        '
        Me.Collector_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Collector_TBBindingSource, "Collector_ID", True))
        Me.Collector_IDTextBox.Location = New System.Drawing.Point(91, 85)
        Me.Collector_IDTextBox.Name = "Collector_IDTextBox"
        Me.Collector_IDTextBox.Size = New System.Drawing.Size(257, 20)
        Me.Collector_IDTextBox.TabIndex = 2
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(20, 114)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(57, 13)
        FullNameLabel.TabIndex = 3
        FullNameLabel.Text = "Full Name:"
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Collector_TBBindingSource, "FullName", True))
        Me.FullNameTextBox.Location = New System.Drawing.Point(91, 111)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(257, 20)
        Me.FullNameTextBox.TabIndex = 4
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(20, 140)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 5
        LocationLabel.Text = "Location:"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Collector_TBBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(91, 137)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(257, 20)
        Me.LocationTextBox.TabIndex = 6
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(20, 166)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Collector_TBBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(91, 163)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(257, 20)
        Me.EmailTextBox.TabIndex = 8
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(20, 192)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 9
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Collector_TBBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(91, 189)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(257, 20)
        Me.PhoneTextBox.TabIndex = 10
        '
        'CollectorDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 261)
        Me.Controls.Add(Collector_IDLabel)
        Me.Controls.Add(Me.Collector_IDTextBox)
        Me.Controls.Add(FullNameLabel)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.Collector_TBBindingNavigator)
        Me.Name = "CollectorDetails"
        Me.Text = "CollectorDetails"
        CType(Me.PG_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Collector_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Collector_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Collector_TBBindingNavigator.ResumeLayout(False)
        Me.Collector_TBBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PG_DatabaseDataSet As PG_DatabaseDataSet
    Friend WithEvents Collector_TBBindingSource As BindingSource
    Friend WithEvents Collector_TBTableAdapter As PG_DatabaseDataSetTableAdapters.Collector_TBTableAdapter
    Friend WithEvents TableAdapterManager As PG_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Collector_TBBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Collector_TBBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Collector_IDTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
End Class
