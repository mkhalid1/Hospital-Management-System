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
	Partial Class frmroom
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmroom))
            Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
            Me.roomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Button7 = New System.Windows.Forms.Button()
            Me.Button6 = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Button5 = New System.Windows.Forms.Button()
            Me.Cmdmain = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.Cmdend = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.CmdHelp = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Room_IDLabel = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Room_IDTextBox = New System.Windows.Forms.TextBox()
            Me.Room_numLabel = New System.Windows.Forms.Label()
            Me.Room_numTextBox = New System.Windows.Forms.TextBox()
            Me.Room_TypeLabel = New System.Windows.Forms.Label()
            Me.Room_TypeTextBox = New System.Windows.Forms.TextBox()
            Me.Room_CostLabel = New System.Windows.Forms.Label()
            Me.Room_CostTextBox = New System.Windows.Forms.TextBox()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.panel5 = New System.Windows.Forms.Panel()
            Me.panel6 = New System.Windows.Forms.Panel()
            CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.BindingNavigator1.SuspendLayout()
            CType(Me.roomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.newDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'BindingNavigator1
            '
            Me.BindingNavigator1.AddNewItem = Nothing
            Me.BindingNavigator1.BindingSource = Me.roomBindingSource
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
            Me.BindingNavigator1.Size = New System.Drawing.Size(1055, 25)
            Me.BindingNavigator1.TabIndex = 0
            Me.BindingNavigator1.Text = "BindingNavigator1"
            '
            'roomBindingSource
            '
            Me.roomBindingSource.DataMember = "room"
            Me.roomBindingSource.DataSource = Me.newDataSet
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
            Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
            Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
            Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
            Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
            Me.BindingNavigatorAddNewItem.Text = "Add new"
            '
            'ToolStripButton1
            '
            Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
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
            'Panel1
            '
            Me.Panel1.AutoScroll = True
            Me.Panel1.AutoSize = True
            Me.Panel1.BackgroundImage = Global.MySqlWindowsFormsApplication5.My.Resources.Resources._6800415_light_blue_backgrounds
            Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel1.Controls.Add(Me.Button7)
            Me.Panel1.Controls.Add(Me.Button6)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.Button5)
            Me.Panel1.Controls.Add(Me.Cmdmain)
            Me.Panel1.Controls.Add(Me.Button4)
            Me.Panel1.Controls.Add(Me.Cmdend)
            Me.Panel1.Controls.Add(Me.Button3)
            Me.Panel1.Controls.Add(Me.CmdHelp)
            Me.Panel1.Controls.Add(Me.Button2)
            Me.Panel1.Controls.Add(Me.Room_IDLabel)
            Me.Panel1.Controls.Add(Me.Button1)
            Me.Panel1.Controls.Add(Me.Room_IDTextBox)
            Me.Panel1.Controls.Add(Me.Room_numLabel)
            Me.Panel1.Controls.Add(Me.Room_numTextBox)
            Me.Panel1.Controls.Add(Me.Room_TypeLabel)
            Me.Panel1.Controls.Add(Me.Room_TypeTextBox)
            Me.Panel1.Controls.Add(Me.Room_CostLabel)
            Me.Panel1.Controls.Add(Me.Room_CostTextBox)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(10, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1035, 437)
            Me.Panel1.TabIndex = 1
            '
            'Button7
            '
            Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button7.FlatAppearance.BorderSize = 4
            Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Button7.Location = New System.Drawing.Point(731, 297)
            Me.Button7.Name = "Button7"
            Me.Button7.Size = New System.Drawing.Size(61, 40)
            Me.Button7.TabIndex = 92
            Me.Button7.Text = "Delete"
            Me.Button7.UseVisualStyleBackColor = True
            '
            'Button6
            '
            Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button6.FlatAppearance.BorderSize = 4
            Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Button6.Location = New System.Drawing.Point(329, 297)
            Me.Button6.Name = "Button6"
            Me.Button6.Size = New System.Drawing.Size(61, 40)
            Me.Button6.TabIndex = 91
            Me.Button6.Text = "Addnew"
            Me.Button6.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(392, 60)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(352, 41)
            Me.Label1.TabIndex = 51
            Me.Label1.Text = "Rooms Information"
            '
            'Button5
            '
            Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button5.FlatAppearance.BorderSize = 4
            Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Button5.Location = New System.Drawing.Point(664, 297)
            Me.Button5.Name = "Button5"
            Me.Button5.Size = New System.Drawing.Size(61, 40)
            Me.Button5.TabIndex = 90
            Me.Button5.Text = "Save"
            Me.Button5.UseVisualStyleBackColor = True
            '
            'Cmdmain
            '
            Me.Cmdmain.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Cmdmain.FlatAppearance.BorderSize = 4
            Me.Cmdmain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Cmdmain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Cmdmain.Location = New System.Drawing.Point(515, 347)
            Me.Cmdmain.Name = "Cmdmain"
            Me.Cmdmain.Size = New System.Drawing.Size(88, 33)
            Me.Cmdmain.TabIndex = 50
            Me.Cmdmain.Text = "Return to Main"
            Me.Cmdmain.UseVisualStyleBackColor = True
            '
            'Button4
            '
            Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button4.FlatAppearance.BorderSize = 4
            Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Button4.Location = New System.Drawing.Point(597, 297)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(61, 40)
            Me.Button4.TabIndex = 89
            Me.Button4.Text = "Last"
            Me.Button4.UseVisualStyleBackColor = True
            '
            'Cmdend
            '
            Me.Cmdend.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Cmdend.FlatAppearance.BorderSize = 4
            Me.Cmdend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Cmdend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Cmdend.Location = New System.Drawing.Point(609, 347)
            Me.Cmdend.Name = "Cmdend"
            Me.Cmdend.Size = New System.Drawing.Size(61, 33)
            Me.Cmdend.TabIndex = 49
            Me.Cmdend.Text = "Exit"
            Me.Cmdend.UseVisualStyleBackColor = True
            '
            'Button3
            '
            Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button3.FlatAppearance.BorderSize = 4
            Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Button3.Location = New System.Drawing.Point(396, 297)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(61, 40)
            Me.Button3.TabIndex = 88
            Me.Button3.Text = "First"
            Me.Button3.UseVisualStyleBackColor = True
            '
            'CmdHelp
            '
            Me.CmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.CmdHelp.FlatAppearance.BorderSize = 4
            Me.CmdHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.CmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.CmdHelp.Location = New System.Drawing.Point(472, 347)
            Me.CmdHelp.Name = "CmdHelp"
            Me.CmdHelp.Size = New System.Drawing.Size(37, 33)
            Me.CmdHelp.TabIndex = 48
            Me.CmdHelp.Text = "Help"
            Me.CmdHelp.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button2.FlatAppearance.BorderSize = 4
            Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Button2.Location = New System.Drawing.Point(463, 297)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(61, 40)
            Me.Button2.TabIndex = 87
            Me.Button2.Text = "Previous"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Room_IDLabel
            '
            Me.Room_IDLabel.AutoSize = True
            Me.Room_IDLabel.BackColor = System.Drawing.Color.Transparent
            Me.Room_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Room_IDLabel.Location = New System.Drawing.Point(466, 172)
            Me.Room_IDLabel.Name = "Room_IDLabel"
            Me.Room_IDLabel.Size = New System.Drawing.Size(78, 20)
            Me.Room_IDLabel.TabIndex = 1
            Me.Room_IDLabel.Text = "Room_ID"
            '
            'Button1
            '
            Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.Button1.FlatAppearance.BorderSize = 4
            Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Button1.Location = New System.Drawing.Point(530, 297)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(61, 40)
            Me.Button1.TabIndex = 86
            Me.Button1.Text = "Next"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Room_IDTextBox
            '
            Me.Room_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.roomBindingSource, "Room_ID", True))
            Me.Room_IDTextBox.Location = New System.Drawing.Point(551, 172)
            Me.Room_IDTextBox.Name = "Room_IDTextBox"
            Me.Room_IDTextBox.Size = New System.Drawing.Size(100, 20)
            Me.Room_IDTextBox.TabIndex = 2
            '
            'Room_numLabel
            '
            Me.Room_numLabel.AutoSize = True
            Me.Room_numLabel.BackColor = System.Drawing.Color.Transparent
            Me.Room_numLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Room_numLabel.Location = New System.Drawing.Point(452, 198)
            Me.Room_numLabel.Name = "Room_numLabel"
            Me.Room_numLabel.Size = New System.Drawing.Size(92, 20)
            Me.Room_numLabel.TabIndex = 3
            Me.Room_numLabel.Text = "Room_num"
            '
            'Room_numTextBox
            '
            Me.Room_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.roomBindingSource, "Room_num", True))
            Me.Room_numTextBox.Location = New System.Drawing.Point(551, 198)
            Me.Room_numTextBox.Name = "Room_numTextBox"
            Me.Room_numTextBox.Size = New System.Drawing.Size(100, 20)
            Me.Room_numTextBox.TabIndex = 4
            '
            'Room_TypeLabel
            '
            Me.Room_TypeLabel.AutoSize = True
            Me.Room_TypeLabel.BackColor = System.Drawing.Color.Transparent
            Me.Room_TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Room_TypeLabel.Location = New System.Drawing.Point(449, 222)
            Me.Room_TypeLabel.Name = "Room_TypeLabel"
            Me.Room_TypeLabel.Size = New System.Drawing.Size(95, 20)
            Me.Room_TypeLabel.TabIndex = 5
            Me.Room_TypeLabel.Text = "Room_Type"
            '
            'Room_TypeTextBox
            '
            Me.Room_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.roomBindingSource, "Room_Type", True))
            Me.Room_TypeTextBox.Location = New System.Drawing.Point(551, 224)
            Me.Room_TypeTextBox.Name = "Room_TypeTextBox"
            Me.Room_TypeTextBox.Size = New System.Drawing.Size(100, 20)
            Me.Room_TypeTextBox.TabIndex = 6
            '
            'Room_CostLabel
            '
            Me.Room_CostLabel.AutoSize = True
            Me.Room_CostLabel.BackColor = System.Drawing.Color.Transparent
            Me.Room_CostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Room_CostLabel.Location = New System.Drawing.Point(450, 248)
            Me.Room_CostLabel.Name = "Room_CostLabel"
            Me.Room_CostLabel.Size = New System.Drawing.Size(94, 20)
            Me.Room_CostLabel.TabIndex = 7
            Me.Room_CostLabel.Text = "Room_Cost"
            '
            'Room_CostTextBox
            '
            Me.Room_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.roomBindingSource, "Room_Cost", True))
            Me.Room_CostTextBox.Location = New System.Drawing.Point(551, 250)
            Me.Room_CostTextBox.Name = "Room_CostTextBox"
            Me.Room_CostTextBox.Size = New System.Drawing.Size(100, 20)
            Me.Room_CostTextBox.TabIndex = 8
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
            Me.panel3.Size = New System.Drawing.Size(1055, 447)
            Me.panel3.TabIndex = 19
            '
            'panel4
            '
            Me.panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel4.Location = New System.Drawing.Point(1045, 0)
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
            Me.panel6.Size = New System.Drawing.Size(1055, 10)
            Me.panel6.TabIndex = 6
            '
            'frmroom
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1055, 472)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.BindingNavigator1)
            Me.Name = "frmroom"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Room"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.BindingNavigator1.ResumeLayout(False)
            Me.BindingNavigator1.PerformLayout()
            CType(Me.roomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.newDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
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
		Friend WithEvents roomBindingSource As System.Windows.Forms.BindingSource
		Friend WithEvents Room_IDTextBox As System.Windows.Forms.TextBox
		Friend WithEvents Room_IDLabel As System.Windows.Forms.Label
		Friend WithEvents Room_numTextBox As System.Windows.Forms.TextBox
		Friend WithEvents Room_numLabel As System.Windows.Forms.Label
		Friend WithEvents Room_TypeTextBox As System.Windows.Forms.TextBox
		Friend WithEvents Room_TypeLabel As System.Windows.Forms.Label
		Friend WithEvents Room_CostTextBox As System.Windows.Forms.TextBox
		Friend WithEvents Room_CostLabel As System.Windows.Forms.Label
		Friend WithEvents panel3 As System.Windows.Forms.Panel
		Friend WithEvents panel4 As System.Windows.Forms.Panel
		Friend WithEvents panel5 As System.Windows.Forms.Panel
        Friend WithEvents panel6 As System.Windows.Forms.Panel
        Friend WithEvents Cmdmain As System.Windows.Forms.Button
        Friend WithEvents Cmdend As System.Windows.Forms.Button
        Friend WithEvents CmdHelp As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Button7 As System.Windows.Forms.Button
        Friend WithEvents Button6 As System.Windows.Forms.Button
        Friend WithEvents Button5 As System.Windows.Forms.Button
        Friend WithEvents Button4 As System.Windows.Forms.Button
        Friend WithEvents Button3 As System.Windows.Forms.Button
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button1 As System.Windows.Forms.Button
		
	End Class
	
End Namespace
