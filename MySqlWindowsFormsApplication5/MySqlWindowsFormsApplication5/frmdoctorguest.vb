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
	
    Public Class frmdoctorguest

        Private ad As MySqlDataAdapter

        Private Sub frmdoctor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = "port=3306;server=localhost;user id=root;database=hospital;password=fus939597;persistsecurityinfo=True;allowuservariables=True;"
            ad = New MySqlDataAdapter("select * from `doctor`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.doctor)
            ad.DeleteCommand = builder.GetDeleteCommand()
            ad.UpdateCommand = builder.GetUpdateCommand()
            ad.InsertCommand = builder.GetInsertCommand()

        End Sub

        Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
            If Not Me.Validate() Then
                Return
            End If
            DoctorBindingSource2.EndEdit()
            ad.Update(Me.newDataSet.doctor)
        End Sub

        Private Sub frmdoctor_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            e.Cancel = False
        End Sub





        Private Sub Cmdmain_Click(sender As Object, e As EventArgs) Handles Cmdmain.Click
            frmmainguest.Show()
            Me.Hide()
        End Sub
        Private Sub Cmdend_Click(sender As Object, e As EventArgs) Handles Cmdend.Click
            Dim response As String
            response = MsgBox("Do you want to close?", MsgBoxStyle.YesNoCancel) 'a message will be displayed and answer will be stored as string variable
            If response = vbYes Then 'use of selection programming structure
                Me.Close()
            End If
        End Sub



        Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        End Sub
    End Class
	
End Namespace