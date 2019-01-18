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
	
    Public Class frmprescriptiondoc

        Private ad As MySqlDataAdapter

        Private Sub frmprescription_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            
            Dim strConn As String = "port=3306;server=localhost;user id=root;database=hospital;password=fus939597;persistsecurityinfo=True;allowuservariables=True;"
            ad = New MySqlDataAdapter("select * from `prescription`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.prescription)
            ad.DeleteCommand = builder.GetDeleteCommand()
            ad.UpdateCommand = builder.GetUpdateCommand()
            ad.InsertCommand = builder.GetInsertCommand()
            Dim ad3 As MySqlDataAdapter
            ad3 = New MySqlDataAdapter("select * from `doctor`", strConn)
            ad3.Fill(Me.newDataSet.doctor)
            Me.Doc_ID_comboBox.DataSource = Me.newDataSet.doctor
            Me.Doc_ID_comboBox.DisplayMember = "Doc_ID"
            Me.Doc_ID_comboBox.ValueMember = "Doc_ID"
            Me.Doc_ID_comboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrescriptionBindingSource, "Doc_ID", True))
            ad3.Dispose()
            ad3 = New MySqlDataAdapter("select * from `medication`", strConn)
            ad3.Fill(Me.newDataSet.medication)
            Me.Med_ID_comboBox.DataSource = Me.newDataSet.medication
            Me.Med_ID_comboBox.DisplayMember = "Med_ID"
            Me.Med_ID_comboBox.ValueMember = "Med_ID"
            Me.Med_ID_comboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrescriptionBindingSource, "Med_ID", True))
            ad3.Dispose()
            ad3 = New MySqlDataAdapter("select * from `patient`", strConn)
            ad3.Fill(Me.newDataSet.patient)
            Me.Patient_ID_comboBox.DataSource = Me.newDataSet.patient
            Me.Patient_ID_comboBox.DisplayMember = "Patient_ID"
            Me.Patient_ID_comboBox.ValueMember = "Patient_ID"
            Me.Patient_ID_comboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrescriptionBindingSource, "Patient_ID", True))
            ad3.Dispose()
        End Sub

        Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
            If Not Me.Validate() Then
                Return
            End If
            If TypeOf (CType(PrescriptionBindingSource.Current, DataRowView)("Date")) Is DBNull Then
                CType(PrescriptionBindingSource.Current, DataRowView)("Date") = Date_dateTimePicker.Value
            End If
            PrescriptionBindingSource.EndEdit()
            ad.Update(Me.newDataSet.prescription)
        End Sub

        Private Sub frmprescription_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            e.Cancel = False
        End Sub

        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

            PrescriptionBindingSource.AddNew()
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
            prescriptionBindingSource.MoveNext()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            prescriptionBindingSource.MovePrevious()
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            prescriptionBindingSource.MoveFirst()
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            prescriptionBindingSource.MoveLast()
        End Sub

        Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
            ad.Update(Me.newDataSet.prescription)

        End Sub

        Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
            PrescriptionBindingSource.AddNew()
        End Sub

        Private Sub Button7_Click(sender As Object, e As EventArgs)
            PrescriptionBindingSource.RemoveCurrent()
        End Sub

        Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        End Sub

        Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
            Try
                Me.PrescriptionTableAdapter.Fill(Me.HospitalDataSet.prescription, CType(ToolStripTextBox1.Text, Integer))


            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End Sub
    End Class
	
End Namespace
