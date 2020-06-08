<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ArtistsForms
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
        Me.components = New System.ComponentModel.Container()
        Dim Artist_IDLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArtistsForms))
        Me.PG_DatabaseDataSet = New PG_Management_FinalPaper_.PG_DatabaseDataSet()
        Me.Artist_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Artist_TBTableAdapter = New PG_Management_FinalPaper_.PG_DatabaseDataSetTableAdapters.Artist_TBTableAdapter()
        Me.TableAdapterManager = New PG_Management_FinalPaper_.PG_DatabaseDataSetTableAdapters.TableAdapterManager()
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
        Me.Artist_TBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Artist_TBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Artist_TBDataGridView = New System.Windows.Forms.DataGridView()
        Me.ViewArtist = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Artist_IDTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Add_Artist = New System.Windows.Forms.Button()
        Me.Update_Artist = New System.Windows.Forms.Button()
        Me.Delete_Artist = New System.Windows.Forms.Button()
        Me.FillBy_IDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Artist_IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Artist_IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy_IDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Artist_IDLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.PG_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Artist_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Artist_TBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Artist_TBBindingNavigator.SuspendLayout()
        CType(Me.Artist_TBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy_IDToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Artist_IDLabel
        '
        Artist_IDLabel.AutoSize = True
        Artist_IDLabel.Location = New System.Drawing.Point(19, 346)
        Artist_IDLabel.Name = "Artist_IDLabel"
        Artist_IDLabel.Size = New System.Drawing.Size(47, 13)
        Artist_IDLabel.TabIndex = 2
        Artist_IDLabel.Text = "Artist ID:"
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(19, 372)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(57, 13)
        FullNameLabel.TabIndex = 4
        FullNameLabel.Text = "Full Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(19, 398)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 6
        GenderLabel.Text = "Gender:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(19, 424)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 8
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(19, 450)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 10
        AddressLabel.Text = "Address:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(19, 476)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Email:"
        '
        'PG_DatabaseDataSet
        '
        Me.PG_DatabaseDataSet.DataSetName = "PG_DatabaseDataSet"
        Me.PG_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Artist_TBBindingSource
        '
        Me.Artist_TBBindingSource.DataMember = "Artist_TB"
        Me.Artist_TBBindingSource.DataSource = Me.PG_DatabaseDataSet
        '
        'Artist_TBTableAdapter
        '
        Me.Artist_TBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Art_TBTableAdapter = Nothing
        Me.TableAdapterManager.Artist_TBTableAdapter = Me.Artist_TBTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Collector_TBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PG_Management_FinalPaper_.PG_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
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
        'Artist_TBBindingNavigatorSaveItem
        '
        Me.Artist_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Artist_TBBindingNavigatorSaveItem.Image = CType(resources.GetObject("Artist_TBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Artist_TBBindingNavigatorSaveItem.Name = "Artist_TBBindingNavigatorSaveItem"
        Me.Artist_TBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Artist_TBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Artist_TBBindingNavigator
        '
        Me.Artist_TBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Artist_TBBindingNavigator.BindingSource = Me.Artist_TBBindingSource
        Me.Artist_TBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Artist_TBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Artist_TBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Artist_TBBindingNavigatorSaveItem})
        Me.Artist_TBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Artist_TBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Artist_TBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Artist_TBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Artist_TBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Artist_TBBindingNavigator.Name = "Artist_TBBindingNavigator"
        Me.Artist_TBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Artist_TBBindingNavigator.Size = New System.Drawing.Size(769, 25)
        Me.Artist_TBBindingNavigator.TabIndex = 0
        Me.Artist_TBBindingNavigator.Text = "BindingNavigator1"
        '
        'Artist_TBDataGridView
        '
        Me.Artist_TBDataGridView.AutoGenerateColumns = False
        Me.Artist_TBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Artist_TBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ViewArtist, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Artist_TBDataGridView.DataSource = Me.Artist_TBBindingSource
        Me.Artist_TBDataGridView.Location = New System.Drawing.Point(12, 72)
        Me.Artist_TBDataGridView.Name = "Artist_TBDataGridView"
        Me.Artist_TBDataGridView.Size = New System.Drawing.Size(708, 220)
        Me.Artist_TBDataGridView.TabIndex = 1
        '
        'ViewArtist
        '
        Me.ViewArtist.DataPropertyName = "Artist_ID"
        Me.ViewArtist.HeaderText = "View Artist"
        Me.ViewArtist.Name = "ViewArtist"
        Me.ViewArtist.ReadOnly = True
        Me.ViewArtist.Text = "View Artist"
        Me.ViewArtist.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Artist_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Artist_ID"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Artist_IDTextBox
        '
        Me.Artist_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "Artist_ID", True))
        Me.Artist_IDTextBox.Location = New System.Drawing.Point(106, 343)
        Me.Artist_IDTextBox.Name = "Artist_IDTextBox"
        Me.Artist_IDTextBox.Size = New System.Drawing.Size(229, 20)
        Me.Artist_IDTextBox.TabIndex = 3
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "FullName", True))
        Me.FullNameTextBox.Location = New System.Drawing.Point(106, 369)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(229, 20)
        Me.FullNameTextBox.TabIndex = 5
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(106, 395)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(229, 20)
        Me.GenderTextBox.TabIndex = 7
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(106, 421)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(229, 20)
        Me.PhoneNumberTextBox.TabIndex = 9
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(106, 447)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(229, 20)
        Me.AddressTextBox.TabIndex = 11
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(106, 473)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(229, 20)
        Me.EmailTextBox.TabIndex = 13
        '
        'Add_Artist
        '
        Me.Add_Artist.Location = New System.Drawing.Point(341, 414)
        Me.Add_Artist.Name = "Add_Artist"
        Me.Add_Artist.Size = New System.Drawing.Size(75, 23)
        Me.Add_Artist.TabIndex = 14
        Me.Add_Artist.Text = "Add"
        Me.Add_Artist.UseVisualStyleBackColor = True
        '
        'Update_Artist
        '
        Me.Update_Artist.Location = New System.Drawing.Point(422, 414)
        Me.Update_Artist.Name = "Update_Artist"
        Me.Update_Artist.Size = New System.Drawing.Size(75, 23)
        Me.Update_Artist.TabIndex = 14
        Me.Update_Artist.Text = "Update"
        Me.Update_Artist.UseVisualStyleBackColor = True
        '
        'Delete_Artist
        '
        Me.Delete_Artist.Location = New System.Drawing.Point(503, 414)
        Me.Delete_Artist.Name = "Delete_Artist"
        Me.Delete_Artist.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Artist.TabIndex = 14
        Me.Delete_Artist.Text = "Delete"
        Me.Delete_Artist.UseVisualStyleBackColor = True
        '
        'FillBy_IDToolStrip
        '
        Me.FillBy_IDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Artist_IDToolStripLabel, Me.Artist_IDToolStripTextBox, Me.FillBy_IDToolStripButton})
        Me.FillBy_IDToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillBy_IDToolStrip.Name = "FillBy_IDToolStrip"
        Me.FillBy_IDToolStrip.Size = New System.Drawing.Size(769, 25)
        Me.FillBy_IDToolStrip.TabIndex = 15
        Me.FillBy_IDToolStrip.Text = "FillBy_IDToolStrip"
        '
        'Artist_IDToolStripLabel
        '
        Me.Artist_IDToolStripLabel.Name = "Artist_IDToolStripLabel"
        Me.Artist_IDToolStripLabel.Size = New System.Drawing.Size(99, 22)
        Me.Artist_IDToolStripLabel.Text = "Enter ID to search"
        '
        'Artist_IDToolStripTextBox
        '
        Me.Artist_IDToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Artist_IDToolStripTextBox.Name = "Artist_IDToolStripTextBox"
        Me.Artist_IDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy_IDToolStripButton
        '
        Me.FillBy_IDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy_IDToolStripButton.Name = "FillBy_IDToolStripButton"
        Me.FillBy_IDToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.FillBy_IDToolStripButton.Text = "Search"
        '
        'ArtistsForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 550)
        Me.Controls.Add(Me.FillBy_IDToolStrip)
        Me.Controls.Add(Me.Delete_Artist)
        Me.Controls.Add(Me.Update_Artist)
        Me.Controls.Add(Me.Add_Artist)
        Me.Controls.Add(Artist_IDLabel)
        Me.Controls.Add(Me.Artist_IDTextBox)
        Me.Controls.Add(FullNameLabel)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Artist_TBDataGridView)
        Me.Controls.Add(Me.Artist_TBBindingNavigator)
        Me.Name = "ArtistsForms"
        Me.Text = "ArtistsForms"
        CType(Me.PG_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Artist_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Artist_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Artist_TBBindingNavigator.ResumeLayout(False)
        Me.Artist_TBBindingNavigator.PerformLayout()
        CType(Me.Artist_TBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy_IDToolStrip.ResumeLayout(False)
        Me.FillBy_IDToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PG_DatabaseDataSet As PG_DatabaseDataSet
    Friend WithEvents Artist_TBBindingSource As BindingSource
    Friend WithEvents Artist_TBTableAdapter As PG_DatabaseDataSetTableAdapters.Artist_TBTableAdapter
    Friend WithEvents TableAdapterManager As PG_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Artist_TBBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Artist_TBBindingNavigator As BindingNavigator
    Friend WithEvents Artist_TBDataGridView As DataGridView
    Friend WithEvents Artist_IDTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Add_Artist As Button
    Friend WithEvents Update_Artist As Button
    Friend WithEvents Delete_Artist As Button
    Friend WithEvents ViewArtist As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents FillBy_IDToolStrip As ToolStrip
    Friend WithEvents Artist_IDToolStripLabel As ToolStripLabel
    Friend WithEvents Artist_IDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillBy_IDToolStripButton As ToolStripButton
End Class
