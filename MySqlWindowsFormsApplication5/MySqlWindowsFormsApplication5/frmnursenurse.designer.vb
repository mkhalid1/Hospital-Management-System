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
    Partial Class frmnursenurse
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmnursenurse))
            Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
            Me.newDataSet = New NewDataSet()
            Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
            Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
            Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Cmdmain = New System.Windows.Forms.Button()
            Me.Cmdend = New System.Windows.Forms.Button()
            Me.CmdHelp = New System.Windows.Forms.Button()
            Me.Nurse_IDLabel = New System.Windows.Forms.Label()
            Me.Nurse_IDTextBox = New System.Windows.Forms.TextBox()
            Me.NurseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.HospitalDataSet = New hospitalDataSet()
            Me.Nurse_NameLabel = New System.Windows.Forms.Label()
            Me.Nurse_NameTextBox = New System.Windows.Forms.TextBox()
            Me.AgeLabel = New System.Windows.Forms.Label()
            Me.AgeTextBox = New System.Windows.Forms.TextBox()
            Me.AddressLabel = New System.Windows.Forms.Label()
            Me.AddressTextBox = New System.Windows.Forms.TextBox()
            Me.WorkShiftLabel = New System.Windows.Forms.Label()
            Me.WorkShiftTextBox = New System.Windows.Forms.TextBox()
            Me.ExperienceLabel = New System.Windows.Forms.Label()
            Me.ExperienceTextBox = New System.Windows.Forms.TextBox()
            Me.salaryLabel = New System.Windows.Forms.Label()
            Me.salaryTextBox = New System.Windows.Forms.TextBox()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.panel5 = New System.Windows.Forms.Panel()
            Me.panel6 = New System.Windows.Forms.Panel()
            Me.NurseTableAdapter = New hospitalDataSetTableAdapters.nurseTableAdapter()
            CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.BindingNavigator1.SuspendLayout()
            CType(Me.newDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            CType(Me.NurseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'BindingNavigator1
            '
            Me.BindingNavigator1.AddNewItem = Nothing
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
            Me.BindingNavigator1.Size = New System.Drawing.Size(1052, 25)
            Me.BindingNavigator1.TabIndex = 0
            Me.BindingNavigator1.Text = "BindingNavigator1"
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
            'newDataSet
            '
            Me.newDataSet.DataSetName = "NewDataSet"
            Me.newDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'ErrorProvider1
            '
            Me.ErrorProvider1.ContainerControl = Me
            '
            'Panel1
            '
            Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel1.AutoScroll = True
            Me.Panel1.AutoSize = True
            Me.Panel1.BackgroundImage = Global.MySqlWindowsFormsApplication5.My.Resources.Resources._6800415_light_blue_backgrounds
            Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel1.Controls.Add(Me.ToolStrip1)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.Cmdmain)
            Me.Panel1.Controls.Add(Me.Cmdend)
            Me.Panel1.Controls.Add(Me.CmdHelp)
            Me.Panel1.Controls.Add(Me.Nurse_IDLabel)
            Me.Panel1.Controls.Add(Me.Nurse_IDTextBox)
            Me.Panel1.Controls.Add(Me.Nurse_NameLabel)
            Me.Panel1.Controls.Add(Me.Nurse_NameTextBox)
            Me.Panel1.Controls.Add(Me.AgeLabel)
            Me.Panel1.Controls.Add(Me.AgeTextBox)
            Me.Panel1.Controls.Add(Me.AddressLabel)
            Me.Panel1.Controls.Add(Me.AddressTextBox)
            Me.Panel1.Controls.Add(Me.WorkShiftLabel)
            Me.Panel1.Controls.Add(Me.WorkShiftTextBox)
            Me.Panel1.Controls.Add(Me.ExperienceLabel)
            Me.Panel1.Controls.Add(Me.ExperienceTextBox)
            Me.Panel1.Controls.Add(Me.salaryLabel)
            Me.Panel1.Controls.Add(Me.salaryTextBox)
            Me.Panel1.Location = New System.Drawing.Point(10, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1032, 437)
            Me.Panel1.TabIndex = 1
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton2})
            Me.ToolStrip1.Location = New System.Drawing.Point(493, 78)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(226, 25)
            Me.ToolStrip1.TabIndex = 52
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'ToolStripLabel1
            '
            Me.ToolStripLabel1.Name = "ToolStripLabel1"
            Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
            Me.ToolStripLabel1.Text = "Your ID:"
            '
            'ToolStripTextBox1
            '
            Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
            Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
            '
            'ToolStripButton2
            '
            Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
            Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton2.Name = "ToolStripButton2"
            Me.ToolStripButton2.Size = New System.Drawing.Size(63, 22)
            Me.ToolStripButton2.Text = "Load data"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(458, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(339, 41)
            Me.Label1.TabIndex = 51
            Me.Label1.Text = "Nurse Information"
            '
            'Cmdmain
            '
            Me.Cmdmain.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Cmdmain.FlatAppearance.BorderSize = 4
            Me.Cmdmain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
            Me.Cmdmain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Cmdmain.Location = New System.Drawing.Point(563, 381)
            Me.Cmdmain.Name = "Cmdmain"
            Me.Cmdmain.Size = New System.Drawing.Size(88, 33)
            Me.Cmdmain.TabIndex = 50
            Me.Cmdmain.Text = "Return to Main"
            Me.Cmdmain.UseVisualStyleBackColor = True
            '
            'Cmdend
            '
            Me.Cmdend.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Cmdend.FlatAppearance.BorderSize = 4
            Me.Cmdend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
            Me.Cmdend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Cmdend.Location = New System.Drawing.Point(657, 381)
            Me.Cmdend.Name = "Cmdend"
            Me.Cmdend.Size = New System.Drawing.Size(61, 33)
            Me.Cmdend.TabIndex = 49
            Me.Cmdend.Text = "Exit"
            Me.Cmdend.UseVisualStyleBackColor = True
            '
            'CmdHelp
            '
            Me.CmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.CmdHelp.FlatAppearance.BorderSize = 4
            Me.CmdHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
            Me.CmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.CmdHelp.Location = New System.Drawing.Point(520, 381)
            Me.CmdHelp.Name = "CmdHelp"
            Me.CmdHelp.Size = New System.Drawing.Size(37, 33)
            Me.CmdHelp.TabIndex = 48
            Me.CmdHelp.Text = "Help"
            Me.CmdHelp.UseVisualStyleBackColor = True
            '
            'Nurse_IDLabel
            '
            Me.Nurse_IDLabel.AutoSize = True
            Me.Nurse_IDLabel.BackColor = System.Drawing.Color.Transparent
            Me.Nurse_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Nurse_IDLabel.Location = New System.Drawing.Point(500, 137)
            Me.Nurse_IDLabel.Name = "Nurse_IDLabel"
            Me.Nurse_IDLabel.Size = New System.Drawing.Size(77, 20)
            Me.Nurse_IDLabel.TabIndex = 1
            Me.Nurse_IDLabel.Text = "Nurse_ID"
            '
            'Nurse_IDTextBox
            '
            Me.Nurse_IDTextBox.CausesValidation = False
            Me.Nurse_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NurseBindingSource, "Nurse_ID", True))
            Me.Nurse_IDTextBox.Location = New System.Drawing.Point(583, 137)
            Me.Nurse_IDTextBox.Name = "Nurse_IDTextBox"
            Me.Nurse_IDTextBox.ReadOnly = True
            Me.Nurse_IDTextBox.Size = New System.Drawing.Size(100, 20)
            Me.Nurse_IDTextBox.TabIndex = 2
            '
            'NurseBindingSource
            '
            Me.NurseBindingSource.DataMember = "nurse"
            Me.NurseBindingSource.DataSource = Me.HospitalDataSet
            '
            'HospitalDataSet
            '
            Me.HospitalDataSet.DataSetName = "hospitalDataSet"
            Me.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Nurse_NameLabel
            '
            Me.Nurse_NameLabel.AutoSize = True
            Me.Nurse_NameLabel.BackColor = System.Drawing.Color.Transparent
            Me.Nurse_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Nurse_NameLabel.Location = New System.Drawing.Point(475, 161)
            Me.Nurse_NameLabel.Name = "Nurse_NameLabel"
            Me.Nurse_NameLabel.Size = New System.Drawing.Size(102, 20)
            Me.Nurse_NameLabel.TabIndex = 3
            Me.Nurse_NameLabel.Text = "Nurse_Name"
            '
            'Nurse_NameTextBox
            '
            Me.Nurse_NameTextBox.CausesValidation = False
            Me.Nurse_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NurseBindingSource, "Nurse_Name", True))
            Me.Nurse_NameTextBox.Location = New System.Drawing.Point(583, 163)
            Me.Nurse_NameTextBox.Name = "Nurse_NameTextBox"
            Me.Nurse_NameTextBox.ReadOnly = True
            Me.Nurse_NameTextBox.Size = New System.Drawing.Size(100, 20)
            Me.Nurse_NameTextBox.TabIndex = 4
            '
            'AgeLabel
            '
            Me.AgeLabel.AutoSize = True
            Me.AgeLabel.BackColor = System.Drawing.Color.Transparent
            Me.AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AgeLabel.Location = New System.Drawing.Point(539, 189)
            Me.AgeLabel.Name = "AgeLabel"
            Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
            Me.AgeLabel.TabIndex = 5
            Me.AgeLabel.Text = "Age"
            '
            'AgeTextBox
            '
            Me.AgeTextBox.CausesValidation = False
            Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NurseBindingSource, "Age", True))
            Me.AgeTextBox.Location = New System.Drawing.Point(583, 189)
            Me.AgeTextBox.Name = "AgeTextBox"
            Me.AgeTextBox.ReadOnly = True
            Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
            Me.AgeTextBox.TabIndex = 6
            '
            'AddressLabel
            '
            Me.AddressLabel.AutoSize = True
            Me.AddressLabel.BackColor = System.Drawing.Color.Transparent
            Me.AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AddressLabel.Location = New System.Drawing.Point(509, 215)
            Me.AddressLabel.Name = "AddressLabel"
            Me.AddressLabel.Size = New System.Drawing.Size(68, 20)
            Me.AddressLabel.TabIndex = 7
            Me.AddressLabel.Text = "Address"
            '
            'AddressTextBox
            '
            Me.AddressTextBox.CausesValidation = False
            Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NurseBindingSource, "Address", True))
            Me.AddressTextBox.Location = New System.Drawing.Point(583, 215)
            Me.AddressTextBox.Name = "AddressTextBox"
            Me.AddressTextBox.ReadOnly = True
            Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
            Me.AddressTextBox.TabIndex = 8
            '
            'WorkShiftLabel
            '
            Me.WorkShiftLabel.AutoSize = True
            Me.WorkShiftLabel.BackColor = System.Drawing.Color.Transparent
            Me.WorkShiftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.WorkShiftLabel.Location = New System.Drawing.Point(498, 241)
            Me.WorkShiftLabel.Name = "WorkShiftLabel"
            Me.WorkShiftLabel.Size = New System.Drawing.Size(79, 20)
            Me.WorkShiftLabel.TabIndex = 9
            Me.WorkShiftLabel.Text = "WorkShift"
            '
            'WorkShiftTextBox
            '
            Me.WorkShiftTextBox.CausesValidation = False
            Me.WorkShiftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NurseBindingSource, "WorkShift", True))
            Me.WorkShiftTextBox.Location = New System.Drawing.Point(583, 241)
            Me.WorkShiftTextBox.Name = "WorkShiftTextBox"
            Me.WorkShiftTextBox.ReadOnly = True
            Me.WorkShiftTextBox.Size = New System.Drawing.Size(100, 20)
            Me.WorkShiftTextBox.TabIndex = 10
            '
            'ExperienceLabel
            '
            Me.ExperienceLabel.AutoSize = True
            Me.ExperienceLabel.BackColor = System.Drawing.Color.Transparent
            Me.ExperienceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ExperienceLabel.Location = New System.Drawing.Point(489, 267)
            Me.ExperienceLabel.Name = "ExperienceLabel"
            Me.ExperienceLabel.Size = New System.Drawing.Size(88, 20)
            Me.ExperienceLabel.TabIndex = 11
            Me.ExperienceLabel.Text = "Experience"
            '
            'ExperienceTextBox
            '
            Me.ExperienceTextBox.CausesValidation = False
            Me.ExperienceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NurseBindingSource, "Experience", True))
            Me.ExperienceTextBox.Location = New System.Drawing.Point(583, 267)
            Me.ExperienceTextBox.Name = "ExperienceTextBox"
            Me.ExperienceTextBox.ReadOnly = True
            Me.ExperienceTextBox.Size = New System.Drawing.Size(100, 20)
            Me.ExperienceTextBox.TabIndex = 12
            '
            'salaryLabel
            '
            Me.salaryLabel.AutoSize = True
            Me.salaryLabel.BackColor = System.Drawing.Color.Transparent
            Me.salaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.salaryLabel.Location = New System.Drawing.Point(527, 293)
            Me.salaryLabel.Name = "salaryLabel"
            Me.salaryLabel.Size = New System.Drawing.Size(53, 20)
            Me.salaryLabel.TabIndex = 13
            Me.salaryLabel.Text = "Salary"
            '
            'salaryTextBox
            '
            Me.salaryTextBox.CausesValidation = False
            Me.salaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NurseBindingSource, "salary", True))
            Me.salaryTextBox.Location = New System.Drawing.Point(583, 293)
            Me.salaryTextBox.Name = "salaryTextBox"
            Me.salaryTextBox.ReadOnly = True
            Me.salaryTextBox.Size = New System.Drawing.Size(100, 20)
            Me.salaryTextBox.TabIndex = 14
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
            Me.panel3.Size = New System.Drawing.Size(1052, 447)
            Me.panel3.TabIndex = 19
            '
            'panel4
            '
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel4.Location = New System.Drawing.Point(1042, 0)
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
            Me.panel6.Size = New System.Drawing.Size(1052, 10)
            Me.panel6.TabIndex = 6
            '
            'NurseTableAdapter
            '
            Me.NurseTableAdapter.ClearBeforeFill = True
            '
            'frmnursenurse
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1052, 472)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.BindingNavigator1)
            Me.Name = "frmnursenurse"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Nurse"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.BindingNavigator1.ResumeLayout(False)
            Me.BindingNavigator1.PerformLayout()
            CType(Me.newDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            CType(Me.NurseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
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
        Friend WithEvents Nurse_IDTextBox As System.Windows.Forms.TextBox
        Friend WithEvents Nurse_IDLabel As System.Windows.Forms.Label
        Friend WithEvents Nurse_NameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents Nurse_NameLabel As System.Windows.Forms.Label
        Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
        Friend WithEvents AgeLabel As System.Windows.Forms.Label
        Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
        Friend WithEvents AddressLabel As System.Windows.Forms.Label
        Friend WithEvents WorkShiftTextBox As System.Windows.Forms.TextBox
        Friend WithEvents WorkShiftLabel As System.Windows.Forms.Label
        Friend WithEvents ExperienceTextBox As System.Windows.Forms.TextBox
        Friend WithEvents ExperienceLabel As System.Windows.Forms.Label
        Friend WithEvents salaryTextBox As System.Windows.Forms.TextBox
        Friend WithEvents salaryLabel As System.Windows.Forms.Label
        Friend WithEvents panel3 As System.Windows.Forms.Panel
        Friend WithEvents panel4 As System.Windows.Forms.Panel
        Friend WithEvents panel5 As System.Windows.Forms.Panel
        Friend WithEvents panel6 As System.Windows.Forms.Panel
        Friend WithEvents Cmdmain As System.Windows.Forms.Button
        Friend WithEvents Cmdend As System.Windows.Forms.Button
        Friend WithEvents CmdHelp As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
        Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
        Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
        Friend WithEvents NurseBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents HospitalDataSet As hospitalDataSet
        Friend WithEvents NurseTableAdapter As hospitalDataSetTableAdapters.nurseTableAdapter

    End Class
	
End Namespace