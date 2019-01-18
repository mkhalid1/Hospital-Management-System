' ++++++++++++++++++++++++++++++++++++++++++++++++++
' This code is generated by a tool and is provided "as is", without warranty of any kind,
' express or implied, including but not limited to the warranties of merchantability,
' fitness for a particular purpose and non-infringement.
' In no event shall the authors or copyright holders be liable for any claim, damages or
' other liability, whether in an action of contract, tort or otherwise, arising from,
' out of or in connection with the software or the use or other dealings in the software.
' ++++++++++++++++++++++++++++++++++++++++++++++++++
' 

Namespace MySqlWindowsFormsApplication5
	
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmdoctordoc
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdoctordoc))
            Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
            Me.doctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.newDataSet = New NewDataSet()
            Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
            Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
            Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
            Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
            Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
            Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
            Me.Doc_IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
            Me.Doc_IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
            Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.DocIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DocNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PassedFromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SpecialityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DoctorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.HospitalDataSet = New hospitalDataSet()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Cmdmain = New System.Windows.Forms.Button()
            Me.Cmdend = New System.Windows.Forms.Button()
            Me.CmdHelp = New System.Windows.Forms.Button()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.panel5 = New System.Windows.Forms.Panel()
            Me.panel6 = New System.Windows.Forms.Panel()
            Me.DoctorTableAdapter = New hospitalDataSetTableAdapters.doctorTableAdapter()
            CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.BindingNavigator1.SuspendLayout()
            CType(Me.doctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.newDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.FillByToolStrip.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DoctorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'BindingNavigator1
            '
            Me.BindingNavigator1.AddNewItem = Nothing
            Me.BindingNavigator1.BindingSource = Me.doctorBindingSource
            Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
            Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
            Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
            Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
            Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
            Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
            Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
            Me.BindingNavigator1.Name = "BindingNavigator1"
            Me.BindingNavigator1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
            Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
            Me.BindingNavigator1.Size = New System.Drawing.Size(1054, 25)
            Me.BindingNavigator1.TabIndex = 0
            Me.BindingNavigator1.Text = "BindingNavigator1"
            '
            'doctorBindingSource
            '
            Me.doctorBindingSource.DataMember = "doctor"
            Me.doctorBindingSource.DataSource = Me.newDataSet
            '
            'newDataSet
            '
            Me.newDataSet.DataSetName = "NewDataSet"
            Me.newDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'BindingNavigatorCountItem
            '
            Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
            Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
            Me.BindingNavigatorCountItem.Text = "of {0}"
            Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
            '
            'BindingNavigatorDeleteItem
            '
            Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.BindingNavigatorDeleteItem.Enabled = False
            Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
            Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
            Me.BindingNavigatorDeleteItem.Text = "Delete"
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
            Me.BindingNavigatorAddNewItem.Enabled = False
            Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
            Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
            Me.BindingNavigatorAddNewItem.Text = "Add new"
            '
            'ToolStripButton1
            '
            Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.ToolStripButton1.Enabled = False
            Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
            Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton1.Name = "ToolStripButton1"
            Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
            Me.ToolStripButton1.Text = "Save"
            '
            'ErrorProvider1
            '
            Me.ErrorProvider1.ContainerControl = Me
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.Panel1)
            Me.panel3.Controls.Add(Me.panel4)
            Me.panel3.Controls.Add(Me.panel5)
            Me.panel3.Controls.Add(Me.panel6)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel3.Location = New System.Drawing.Point(0, 25)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(1054, 447)
            Me.panel3.TabIndex = 19
            '
            'Panel1
            '
            Me.Panel1.AutoScroll = True
            Me.Panel1.AutoSize = True
            Me.Panel1.BackgroundImage = Global.MySqlWindowsFormsApplication5.My.Resources.Resources._6800415_light_blue_backgrounds
            Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel1.Controls.Add(Me.FillByToolStrip)
            Me.Panel1.Controls.Add(Me.DataGridView1)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.Cmdmain)
            Me.Panel1.Controls.Add(Me.Cmdend)
            Me.Panel1.Controls.Add(Me.CmdHelp)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(10, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1034, 437)
            Me.Panel1.TabIndex = 1
            '
            'FillByToolStrip
            '
            Me.FillByToolStrip.Dock = System.Windows.Forms.DockStyle.None
            Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Doc_IDToolStripLabel, Me.Doc_IDToolStripTextBox, Me.FillByToolStripButton})
            Me.FillByToolStrip.Location = New System.Drawing.Point(487, 62)
            Me.FillByToolStrip.Name = "FillByToolStrip"
            Me.FillByToolStrip.Size = New System.Drawing.Size(255, 25)
            Me.FillByToolStrip.TabIndex = 20
            Me.FillByToolStrip.Text = "FillByToolStrip"
            '
            'Doc_IDToolStripLabel
            '
            Me.Doc_IDToolStripLabel.Name = "Doc_IDToolStripLabel"
            Me.Doc_IDToolStripLabel.Size = New System.Drawing.Size(104, 22)
            Me.Doc_IDToolStripLabel.Text = "Enter your Doc_ID:"
            '
            'Doc_IDToolStripTextBox
            '
            Me.Doc_IDToolStripTextBox.Name = "Doc_IDToolStripTextBox"
            Me.Doc_IDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
            '
            'FillByToolStripButton
            '
            Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.FillByToolStripButton.Name = "FillByToolStripButton"
            Me.FillByToolStripButton.Size = New System.Drawing.Size(37, 22)
            Me.FillByToolStripButton.Text = "Load"
            '
            'DataGridView1
            '
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
            Me.DataGridView1.AutoGenerateColumns = False
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocIDDataGridViewTextBoxColumn, Me.DocNameDataGridViewTextBoxColumn, Me.PassedFromDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DesignationDataGridViewTextBoxColumn, Me.SpecialityDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn})
            Me.DataGridView1.DataSource = Me.DoctorBindingSource1
            Me.DataGridView1.Location = New System.Drawing.Point(2, 111)
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.ReadOnly = True
            Me.DataGridView1.Size = New System.Drawing.Size(841, 201)
            Me.DataGridView1.TabIndex = 90
            '
            'DocIDDataGridViewTextBoxColumn
            '
            Me.DocIDDataGridViewTextBoxColumn.DataPropertyName = "Doc_ID"
            Me.DocIDDataGridViewTextBoxColumn.HeaderText = "Doc_ID"
            Me.DocIDDataGridViewTextBoxColumn.Name = "DocIDDataGridViewTextBoxColumn"
            Me.DocIDDataGridViewTextBoxColumn.ReadOnly = True
            '
            'DocNameDataGridViewTextBoxColumn
            '
            Me.DocNameDataGridViewTextBoxColumn.DataPropertyName = "Doc_Name"
            Me.DocNameDataGridViewTextBoxColumn.HeaderText = "Doc_Name"
            Me.DocNameDataGridViewTextBoxColumn.Name = "DocNameDataGridViewTextBoxColumn"
            Me.DocNameDataGridViewTextBoxColumn.ReadOnly = True
            '
            'PassedFromDataGridViewTextBoxColumn
            '
            Me.PassedFromDataGridViewTextBoxColumn.DataPropertyName = "Passed_From"
            Me.PassedFromDataGridViewTextBoxColumn.HeaderText = "Passed_From"
            Me.PassedFromDataGridViewTextBoxColumn.Name = "PassedFromDataGridViewTextBoxColumn"
            Me.PassedFromDataGridViewTextBoxColumn.ReadOnly = True
            '
            'AgeDataGridViewTextBoxColumn
            '
            Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
            Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
            Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
            Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
            '
            'AddressDataGridViewTextBoxColumn
            '
            Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
            Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
            Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
            Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
            '
            'DesignationDataGridViewTextBoxColumn
            '
            Me.DesignationDataGridViewTextBoxColumn.DataPropertyName = "Designation"
            Me.DesignationDataGridViewTextBoxColumn.HeaderText = "Designation"
            Me.DesignationDataGridViewTextBoxColumn.Name = "DesignationDataGridViewTextBoxColumn"
            Me.DesignationDataGridViewTextBoxColumn.ReadOnly = True
            '
            'SpecialityDataGridViewTextBoxColumn
            '
            Me.SpecialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality"
            Me.SpecialityDataGridViewTextBoxColumn.HeaderText = "Speciality"
            Me.SpecialityDataGridViewTextBoxColumn.Name = "SpecialityDataGridViewTextBoxColumn"
            Me.SpecialityDataGridViewTextBoxColumn.ReadOnly = True
            '
            'SalaryDataGridViewTextBoxColumn
            '
            Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
            Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
            Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
            Me.SalaryDataGridViewTextBoxColumn.ReadOnly = True
            '
            'DoctorBindingSource1
            '
            Me.DoctorBindingSource1.DataMember = "doctor"
            Me.DoctorBindingSource1.DataSource = Me.HospitalDataSet
            '
            'HospitalDataSet
            '
            Me.HospitalDataSet.DataSetName = "hospitalDataSet"
            Me.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(450, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(354, 41)
            Me.Label1.TabIndex = 51
            Me.Label1.Text = "Doctor Information"
            '
            'Cmdmain
            '
            Me.Cmdmain.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.Cmdmain.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Cmdmain.FlatAppearance.BorderSize = 4
            Me.Cmdmain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
            Me.Cmdmain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Cmdmain.Location = New System.Drawing.Point(583, 363)
            Me.Cmdmain.Name = "Cmdmain"
            Me.Cmdmain.Size = New System.Drawing.Size(88, 33)
            Me.Cmdmain.TabIndex = 50
            Me.Cmdmain.Text = "Return to Main"
            Me.Cmdmain.UseVisualStyleBackColor = True
            '
            'Cmdend
            '
            Me.Cmdend.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.Cmdend.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Cmdend.FlatAppearance.BorderSize = 4
            Me.Cmdend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
            Me.Cmdend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Cmdend.Location = New System.Drawing.Point(677, 363)
            Me.Cmdend.Name = "Cmdend"
            Me.Cmdend.Size = New System.Drawing.Size(61, 33)
            Me.Cmdend.TabIndex = 49
            Me.Cmdend.Text = "Exit"
            Me.Cmdend.UseVisualStyleBackColor = True
            '
            'CmdHelp
            '
            Me.CmdHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.CmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.CmdHelp.FlatAppearance.BorderSize = 4
            Me.CmdHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
            Me.CmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.CmdHelp.Location = New System.Drawing.Point(540, 363)
            Me.CmdHelp.Name = "CmdHelp"
            Me.CmdHelp.Size = New System.Drawing.Size(37, 33)
            Me.CmdHelp.TabIndex = 48
            Me.CmdHelp.Text = "Help"
            Me.CmdHelp.UseVisualStyleBackColor = True
            '
            'panel4
            '
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel4.Location = New System.Drawing.Point(1044, 0)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(10, 437)
            Me.panel4.TabIndex = 3
            '
            'panel5
            '
            Me.panel5.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel5.Location = New System.Drawing.Point(0, 0)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(10, 437)
            Me.panel5.TabIndex = 5
            '
            'panel6
            '
            Me.panel6.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel6.Location = New System.Drawing.Point(0, 437)
            Me.panel6.Name = "panel6"
            Me.panel6.Size = New System.Drawing.Size(1054, 10)
            Me.panel6.TabIndex = 6
            '
            'DoctorTableAdapter
            '
            Me.DoctorTableAdapter.ClearBeforeFill = True
            '
            'frmdoctordoc
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1054, 472)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.BindingNavigator1)
            Me.Name = "frmdoctordoc"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Doctor"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.BindingNavigator1.ResumeLayout(False)
            Me.BindingNavigator1.PerformLayout()
            CType(Me.doctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.newDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.FillByToolStrip.ResumeLayout(False)
            Me.FillByToolStrip.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DoctorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
        Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
        Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
        Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
        Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
        Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents newDataSet As NewDataSet
        Friend WithEvents doctorBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents panel3 As System.Windows.Forms.Panel
        Friend WithEvents panel4 As System.Windows.Forms.Panel
        Friend WithEvents panel5 As System.Windows.Forms.Panel
        Friend WithEvents panel6 As System.Windows.Forms.Panel
        Friend WithEvents Cmdmain As System.Windows.Forms.Button
        Friend WithEvents Cmdend As System.Windows.Forms.Button
        Friend WithEvents CmdHelp As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
        Friend WithEvents HospitalDataSet As hospitalDataSet
        Friend WithEvents DoctorBindingSource1 As System.Windows.Forms.BindingSource
        Friend WithEvents DoctorTableAdapter As hospitalDataSetTableAdapters.doctorTableAdapter
        Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
        Friend WithEvents Doc_IDToolStripLabel As System.Windows.Forms.ToolStripLabel
        Friend WithEvents Doc_IDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
        Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
        Friend WithEvents DocIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DocNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents PassedFromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DesignationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SpecialityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents SalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
	
End Namespace