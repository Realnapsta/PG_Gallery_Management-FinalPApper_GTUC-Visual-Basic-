<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollectorsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CollectorsForm))
        Dim Collector_IDLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
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
        Me.Collector_TBDataGridView = New System.Windows.Forms.DataGridView()
        Me.Collector_IDTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Add_Collector = New System.Windows.Forms.Button()
        Me.Update_Collector = New System.Windows.Forms.Button()
        Me.Delete_Collector = New System.Windows.Forms.Button()
        Me.ViewCollector = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FillBy_IDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Collector_IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Collector_IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy_IDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Collector_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PG_DatabaseDataSet = New PG_Management_FinalPaper_.PG_DatabaseDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Collector_TBTableAdapter = New PG_Management_FinalPaper_.PG_DatabaseDataSetTableAdapters.Collector_TBTableAdapter()
        Me.TableAdapterManager = New PG_Management_FinalPaper_.PG_DatabaseDataSetTableAdapters.TableAdapterManager()
        Collector_IDLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        CType(Me.Collector_TBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Collector_TBBindingNavigator.SuspendLayout()
        CType(Me.Collector_TBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy_IDToolStrip.SuspendLayout()
        CType(Me.Collector_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PG_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Collector_TBBindingNavigator.Size = New System.Drawing.Size(871, 25)
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Collector_TBBindingNavigatorSaveItem
        '
        Me.Collector_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Collector_TBBindingNavigatorSaveItem.Image = CType(resources.GetObject("Collector_TBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Collector_TBBindingNavigatorSaveItem.Name = "Collector_TBBindingNavigatorSaveItem"
        Me.Collector_TBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Collector_TBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Collector_TBDataGridView
        '
        Me.Collector_TBDataGridView.AutoGenerateColumns = False
        Me.Collector_TBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Collector_TBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ViewCollector, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Collector_TBDataGridView.DataSource = Me.Collector_TBBindingSource
        Me.Collector_TBDataGridView.Location = New System.Drawing.Point(12, 81)
        Me.Collector_TBDataGridView.Name = "Collector_TBDataGridView"
        Me.Collector_TBDataGridView.Size = New System.Drawing.Size(806, 313)
        Me.Collector_TBDataGridView.TabIndex = 1
        '
        'Collector_IDLabel
        '
        Collector_IDLabel.AutoSize = True
        Collector_IDLabel.Location = New System.Drawing.Point(19, 413)
        Collector_IDLabel.Name = "Collector_IDLabel"
        Collector_IDLabel.Size = New System.Drawing.Size(65, 13)
        Collector_IDLabel.TabIndex = 2
        Collector_IDLabel.Text = "Collector ID:"
        '
        'Collector_IDTextBox
        '
        Me.Collector_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Collector_TBBindingSource, "Collector_ID", True))
        Me.Collector_IDTextBox.Location = New System.Drawing.Point(90, 410)
        Me.Collector_IDTextBox.Name = "Collector_IDTextBox"
        Me.Collector_IDTextBox.Size = New System.Drawing.Size(239, 20)
        Me.Collector_IDTextBox.TabIndex = 3
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(19, 439)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(57, 13)
        FullNameLabel.TabIndex = 4
        FullNameLabel.Text = "Full Name:"
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Collector_TBBindingSource, "FullName", True))
        Me.FullNameTextBox.Location = New System.Drawing.Point(90, 436)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(239, 20)
        Me.FullNameTextBox.TabIndex = 5
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(19, 465)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 6
        LocationLabel.Text = "Location:"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Collector_TBBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(90, 462)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(239, 20)
        Me.LocationTextBox.TabIndex = 7
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(19, 491)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 8
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Collector_TBBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(90, 488)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(239, 20)
        Me.EmailTextBox.TabIndex = 9
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(19, 517)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 10
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Collector_TBBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(90, 514)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(239, 20)
        Me.PhoneTextBox.TabIndex = 11
        '
        'Add_Collector
        '
        Me.Add_Collector.Location = New System.Drawing.Point(348, 460)
        Me.Add_Collector.Name = "Add_Collector"
        Me.Add_Collector.Size = New System.Drawing.Size(75, 23)
        Me.Add_Collector.TabIndex = 12
        Me.Add_Collector.Text = "Add"
        Me.Add_Collector.UseVisualStyleBackColor = True
        '
        'Update_Collector
        '
        Me.Update_Collector.Location = New System.Drawing.Point(429, 460)
        Me.Update_Collector.Name = "Update_Collector"
        Me.Update_Collector.Size = New System.Drawing.Size(75, 23)
        Me.Update_Collector.TabIndex = 12
        Me.Update_Collector.Text = "Update"
        Me.Update_Collector.UseVisualStyleBackColor = True
        '
        'Delete_Collector
        '
        Me.Delete_Collector.Location = New System.Drawing.Point(512, 460)
        Me.Delete_Collector.Name = "Delete_Collector"
        Me.Delete_Collector.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Collector.TabIndex = 12
        Me.Delete_Collector.Text = "Delete"
        Me.Delete_Collector.UseVisualStyleBackColor = True
        '
        'ViewCollector
        '
        Me.ViewCollector.HeaderText = "View Collector"
        Me.ViewCollector.Name = "ViewCollector"
        Me.ViewCollector.Text = "View Collector"
        Me.ViewCollector.UseColumnTextForButtonValue = True
        '
        'FillBy_IDToolStrip
        '
        Me.FillBy_IDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Collector_IDToolStripLabel, Me.Collector_IDToolStripTextBox, Me.FillBy_IDToolStripButton})
        Me.FillBy_IDToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillBy_IDToolStrip.Name = "FillBy_IDToolStrip"
        Me.FillBy_IDToolStrip.Size = New System.Drawing.Size(871, 25)
        Me.FillBy_IDToolStrip.TabIndex = 13
        Me.FillBy_IDToolStrip.Text = "FillBy_IDToolStrip"
        '
        'Collector_IDToolStripLabel
        '
        Me.Collector_IDToolStripLabel.Name = "Collector_IDToolStripLabel"
        Me.Collector_IDToolStripLabel.Size = New System.Drawing.Size(103, 22)
        Me.Collector_IDToolStripLabel.Text = "Enter ID to Search:"
        '
        'Collector_IDToolStripTextBox
        '
        Me.Collector_IDToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Collector_IDToolStripTextBox.Name = "Collector_IDToolStripTextBox"
        Me.Collector_IDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy_IDToolStripButton
        '
        Me.FillBy_IDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy_IDToolStripButton.Name = "FillBy_IDToolStripButton"
        Me.FillBy_IDToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.FillBy_IDToolStripButton.Text = "Search"
        '
        'Collector_TBBindingSource
        '
        Me.Collector_TBBindingSource.DataMember = "Collector_TB"
        Me.Collector_TBBindingSource.DataSource = Me.PG_DatabaseDataSet
        '
        'PG_DatabaseDataSet
        '
        Me.PG_DatabaseDataSet.DataSetName = "PG_DatabaseDataSet"
        Me.PG_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Collector_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Collector_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FullName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FullName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
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
        'CollectorsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 569)
        Me.Controls.Add(Me.FillBy_IDToolStrip)
        Me.Controls.Add(Me.Delete_Collector)
        Me.Controls.Add(Me.Update_Collector)
        Me.Controls.Add(Me.Add_Collector)
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
        Me.Controls.Add(Me.Collector_TBDataGridView)
        Me.Controls.Add(Me.Collector_TBBindingNavigator)
        Me.Name = "CollectorsForm"
        Me.Text = "CollectorsForm"
        CType(Me.Collector_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Collector_TBBindingNavigator.ResumeLayout(False)
        Me.Collector_TBBindingNavigator.PerformLayout()
        CType(Me.Collector_TBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy_IDToolStrip.ResumeLayout(False)
        Me.FillBy_IDToolStrip.PerformLayout()
        CType(Me.Collector_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PG_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Collector_TBDataGridView As DataGridView
    Friend WithEvents Collector_IDTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Add_Collector As Button
    Friend WithEvents Update_Collector As Button
    Friend WithEvents Delete_Collector As Button
    Friend WithEvents ViewCollector As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents FillBy_IDToolStrip As ToolStrip
    Friend WithEvents Collector_IDToolStripLabel As ToolStripLabel
    Friend WithEvents Collector_IDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillBy_IDToolStripButton As ToolStripButton
End Class
