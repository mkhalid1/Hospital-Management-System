' ++++++++++++++++++++++++++++++++++++++++++++++++++
' This code is generated by a tool and is provided "as is", without warranty of any kind,
' express or implied, including but not limited to the warranties of merchantability,
' fitness for a particular purpose and non-infringement.
' In no event shall the authors or copyright holders be liable for any claim, damages or
' other liability, whether in an action of contract, tort or otherwise, arising from,
' out of or in connection with the software or the use or other dealings in the software.
' ++++++++++++++++++++++++++++++++++++++++++++++++++
' 

Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Namespace MySqlWindowsFormsApplication5
	
	Public Class frmnurse
		
		Private ad As MySqlDataAdapter
		
		Private Sub frmnurse_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = "port=3306;server=localhost;user id=root;database=hospital;password=fus939597;persistsecurityinfo=True;allowuservariables=True;"
			ad = New MySqlDataAdapter("select * from `nurse`", strConn)
			Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
			ad.Fill(Me.newDataSet.nurse)
			ad.DeleteCommand = builder.GetDeleteCommand()
			ad.UpdateCommand = builder.GetUpdateCommand()
			ad.InsertCommand = builder.GetInsertCommand()
			Dim ad3 As MySqlDataAdapter
		End Sub
		
		Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
			If Not Me.Validate() Then
				Return
			End If
			nurseBindingSource.EndEdit()
			ad.Update(Me.newDataSet.nurse)
		End Sub
		
		Private Sub frmnurse_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
			e.Cancel = False
		End Sub
		
        Private Sub Nurse_IDTextBox_Validating(sender As Object, e As CancelEventArgs) Handles Nurse_IDTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(Nurse_IDTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(Nurse_IDTextBox, "The field Nurse_ID is required")
            End If
            Dim v As Integer
            Dim s As String = Nurse_IDTextBox.Text
            If Not Integer.TryParse(s, v) Then
                e.Cancel = True
                ErrorProvider1.SetError(Nurse_IDTextBox, "The field Nurse_ID must be Integer.")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(Nurse_IDTextBox, "")
            End If
        End Sub
		
        Private Sub Nurse_NameTextBox_Validating(sender As Object, e As CancelEventArgs) Handles Nurse_NameTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(Nurse_NameTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(Nurse_NameTextBox, "The field Nurse_Name is required")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(Nurse_NameTextBox, "")
            End If
        End Sub
		
        Private Sub AgeTextBox_Validating(sender As Object, e As CancelEventArgs) Handles AgeTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(AgeTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(AgeTextBox, "The field Age is required")
            End If
            Dim v As Integer
            Dim s As String = AgeTextBox.Text
            If Not Integer.TryParse(s, v) Then
                e.Cancel = True
                ErrorProvider1.SetError(AgeTextBox, "The field Age must be Integer.")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(AgeTextBox, "")
            End If
        End Sub
		
        Private Sub AddressTextBox_Validating(sender As Object, e As CancelEventArgs) Handles AddressTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(AddressTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(AddressTextBox, "The field Address is required")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(AddressTextBox, "")
            End If
        End Sub
		
        Private Sub WorkShiftTextBox_Validating(sender As Object, e As CancelEventArgs) Handles WorkShiftTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(WorkShiftTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(WorkShiftTextBox, "The field WorkShift is required")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(WorkShiftTextBox, "")
            End If
            Dim s As String = WorkShiftTextBox.Text()
            If s <> "night" And s <> "morning" And s <> "afternoon" Then
                e.Cancel = True
                ErrorProvider1.SetError(WorkShiftTextBox, "The shift can only be of morning, afternoon or night.")
            Else
                e.Cancel = False
                ErrorProvider1.SetError(WorkShiftTextBox, "")
            End If
        End Sub
		
        Private Sub ExperienceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles ExperienceTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(ExperienceTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(ExperienceTextBox, "The field Experience is required")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(ExperienceTextBox, "")
            End If
        End Sub
		
        Private Sub salaryTextBox_Validating(sender As Object, e As CancelEventArgs) Handles salaryTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(salaryTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(salaryTextBox, "The field salary is required")
            End If
            Dim v As Integer
            Dim s As String = salaryTextBox.Text
            If Not Integer.TryParse(s, v) Then
                e.Cancel = True
                ErrorProvider1.SetError(salaryTextBox, "The field salary must be Integer.")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(salaryTextBox, "")
            End If
            v = CInt(s)
            If v < 10000 Then
                e.Cancel = True
                ErrorProvider1.SetError(salaryTextBox, "The Salary cannot be less than Ward Boy Salary.(10,000)")
            End If
        End Sub
		
		
        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
            nurseBindingSource.AddNew()
        End Sub
        Private Sub Cmdmain_Click(sender As Object, e As EventArgs) Handles Cmdmain.Click
            frmmainreceptionist.Show()
            Me.Hide()
        End Sub
        Private Sub Cmdend_Click(sender As Object, e As EventArgs) Handles Cmdend.Click
            Dim response As String
            response = MsgBox("Do you want to close?", MsgBoxStyle.YesNoCancel) 'a message will be displayed and answer will be stored as string variable
            If response = vbYes Then 'use of selection programming structure
                Me.Close()
            End If
        End Sub
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            nurseBindingSource.MoveNext()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            nurseBindingSource.MovePrevious()
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            nurseBindingSource.MoveFirst()
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            nurseBindingSource.MoveLast()
        End Sub

        Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
            ad.Update(Me.newDataSet.nurse)
        End Sub

        Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
            nurseBindingSource.AddNew()
        End Sub

        Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
            nurseBindingSource.RemoveCurrent()
        End Sub

        Private Sub salaryTextBox_TextChanged(sender As Object, e As EventArgs) Handles salaryTextBox.TextChanged

        End Sub
    
        Private Sub WorkShiftTextBox_TextChanged(sender As Object, e As EventArgs) Handles WorkShiftTextBox.TextChanged

        End Sub

        Private Sub BindingNavigatorPositionItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.Click
   

        End Sub

        Private Sub BindingNavigatorCountItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorCountItem.Click

        End Sub

        Private Sub Nurse_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles Nurse_IDTextBox.TextChanged

        End Sub
    End Class
	
End Namespace
