<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtistsDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArtistsDetails))
        Dim Artist_IDLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.PG_DatabaseDataSet = New PG_Management_FinalPaper_.PG_DatabaseDataSet()
        Me.Artist_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Artist_TBTableAdapter = New PG_Management_FinalPaper_.PG_DatabaseDataSetTableAdapters.Artist_TBTableAdapter()
        Me.TableAdapterManager = New PG_Management_FinalPaper_.PG_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Artist_TBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Artist_IDTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
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
        Me.SuspendLayout()
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
        Me.Artist_TBBindingNavigator.Size = New System.Drawing.Size(448, 25)
        Me.Artist_TBBindingNavigator.TabIndex = 0
        Me.Artist_TBBindingNavigator.Text = "BindingNavigator1"
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
        'Artist_TBBindingNavigatorSaveItem
        '
        Me.Artist_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Artist_TBBindingNavigatorSaveItem.Image = CType(resources.GetObject("Artist_TBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Artist_TBBindingNavigatorSaveItem.Name = "Artist_TBBindingNavigatorSaveItem"
        Me.Artist_TBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Artist_TBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Artist_IDLabel
        '
        Artist_IDLabel.AutoSize = True
        Artist_IDLabel.Location = New System.Drawing.Point(20, 89)
        Artist_IDLabel.Name = "Artist_IDLabel"
        Artist_IDLabel.Size = New System.Drawing.Size(47, 13)
        Artist_IDLabel.TabIndex = 1
        Artist_IDLabel.Text = "Artist ID:"
        '
        'Artist_IDTextBox
        '
        Me.Artist_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "Artist_ID", True))
        Me.Artist_IDTextBox.Location = New System.Drawing.Point(107, 86)
        Me.Artist_IDTextBox.Name = "Artist_IDTextBox"
        Me.Artist_IDTextBox.Size = New System.Drawing.Size(295, 20)
        Me.Artist_IDTextBox.TabIndex = 2
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(20, 115)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(57, 13)
        FullNameLabel.TabIndex = 3
        FullNameLabel.Text = "Full Name:"
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "FullName", True))
        Me.FullNameTextBox.Location = New System.Drawing.Point(107, 112)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(295, 20)
        Me.FullNameTextBox.TabIndex = 4
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(20, 141)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 5
        GenderLabel.Text = "Gender:"
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(107, 138)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(295, 20)
        Me.GenderTextBox.TabIndex = 6
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(20, 167)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 7
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(107, 164)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(295, 20)
        Me.PhoneNumberTextBox.TabIndex = 8
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(20, 193)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(107, 190)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(295, 20)
        Me.AddressTextBox.TabIndex = 10
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(20, 219)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Artist_TBBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(107, 216)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(295, 20)
        Me.EmailTextBox.TabIndex = 12
        '
        'ArtistsDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 307)
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
        Me.Controls.Add(Me.Artist_TBBindingNavigator)
        Me.Name = "ArtistsDetails"
        Me.Text = "ArtistsDetails"
        CType(Me.PG_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Artist_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Artist_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Artist_TBBindingNavigator.ResumeLayout(False)
        Me.Artist_TBBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PG_DatabaseDataSet As PG_DatabaseDataSet
    Friend WithEvents Artist_TBBindingSource As BindingSource
    Friend WithEvents Artist_TBTableAdapter As PG_DatabaseDataSetTableAdapters.Artist_TBTableAdapter
    Friend WithEvents TableAdapterManager As PG_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Artist_TBBindingNavigator As BindingNavigator
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
    Friend WithEvents Artist_TBBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Artist_IDTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
End Class
