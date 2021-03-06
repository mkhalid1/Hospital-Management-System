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
	
    Public Class frmmedicationdoc

        Private ad As MySqlDataAdapter

        Private Sub frmmedication_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = "port=3306;server=localhost;user id=root;database=hospital;password=fus939597;persistsecurityinfo=True;allowuservariables=True;"
            ad = New MySqlDataAdapter("select * from `medication`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.medication)
            ad.DeleteCommand = builder.GetDeleteCommand()
            ad.UpdateCommand = builder.GetUpdateCommand()
            ad.InsertCommand = builder.GetInsertCommand()
            Dim ad3 As MySqlDataAdapter
        End Sub

        Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
            If Not Me.Validate() Then
                Return
            End If
            If TypeOf (CType(medicationBindingSource.Current, DataRowView)("Man_Date")) Is DBNull Then
                CType(medicationBindingSource.Current, DataRowView)("Man_Date") = Man_Date_dateTimePicker.Value
            End If
            If TypeOf (CType(medicationBindingSource.Current, DataRowView)("Exp_Date")) Is DBNull Then
                CType(medicationBindingSource.Current, DataRowView)("Exp_Date") = Exp_Date_dateTimePicker.Value
            End If
            medicationBindingSource.EndEdit()
            ad.Update(Me.newDataSet.medication)
        End Sub

        Private Sub frmmedication_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            e.Cancel = False
        End Sub

        Private Sub Med_IDTextBox_Validating(sender As Object, e As CancelEventArgs) Handles Med_IDTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(Med_IDTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(Med_IDTextBox, "The field Med_ID is required")
            End If
            Dim v As Integer
            Dim s As String = Med_IDTextBox.Text
            If Not Integer.TryParse(s, v) Then
                e.Cancel = True
                ErrorProvider1.SetError(Med_IDTextBox, "The field Med_ID must be Integer.")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(Med_IDTextBox, "")
            End If
        End Sub

        Private Sub Med_NameTextBox_Validating(sender As Object, e As CancelEventArgs) Handles Med_NameTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(Med_NameTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(Med_NameTextBox, "The field Med_Name is required")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(Med_NameTextBox, "")
            End If
        End Sub

        Private Sub CompanyTextBox_Validating(sender As Object, e As CancelEventArgs) Handles CompanyTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(CompanyTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(CompanyTextBox, "The field Company is required")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(CompanyTextBox, "")
            End If
        End Sub

        Private Sub PriceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PriceTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(PriceTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(PriceTextBox, "The field Price is required")
            End If
            Dim v As Integer
            Dim s As String = PriceTextBox.Text
            If Not Integer.TryParse(s, v) Then
                e.Cancel = True
                ErrorProvider1.SetError(PriceTextBox, "The field Price must be Integer.")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(PriceTextBox, "")
            End If
        End Sub


        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
            medicationBindingSource.AddNew()
        End Sub
        Private Sub Cmdmain_Click(sender As Object, e As EventArgs) Handles Cmdmain.Click
            frmmaindoctor.Show()
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
            medicationBindingSource.MoveNext()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            medicationBindingSource.MovePrevious()
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            medicationBindingSource.MoveFirst()
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            medicationBindingSource.MoveLast()
        End Sub

        Private Sub Button5_Click(sender As Object, e As EventArgs)
            ad.Update(Me.newDataSet.medication)
        End Sub

        Private Sub Button6_Click(sender As Object, e As EventArgs)
            medicationBindingSource.AddNew()
        End Sub

        Private Sub Button7_Click(sender As Object, e As EventArgs)
            medicationBindingSource.RemoveCurrent()
        End Sub

        Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
            Try
                Me.MedicationTableAdapter.Fill(Me.HospitalDataSet.medication, CType(TextBox1.Text, String))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End Sub
    End Class
	
End Namespace
