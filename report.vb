Imports System.Drawing.Printing
Public Class report
    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FLOOD_RECOVERY_SYSTEMDataSet.VICTIM' table. You can move, or remove it, as needed.
        Me.VICTIMTableAdapter.Fill(Me.FLOOD_RECOVERY_SYSTEMDataSet.VICTIM)

    End Sub

    Private Sub VICTIMBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VICTIMBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VICTIMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FLOOD_RECOVERY_SYSTEMDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class