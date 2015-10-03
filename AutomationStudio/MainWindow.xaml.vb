Imports Microsoft.Xna
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input
Imports Microsoft.Xna.Framework.GamerServices
Imports Microsoft.Xna.Framework.Content
Imports System.Timers

Class MainWindow
    Inherits Elysium.Controls.Window




    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Reset_Btn_Click(sender As Object, e As RoutedEventArgs) Handles Reset_Btn.Click
        Dim XboxControlSt As XboxControllerStatus = New XboxControllerStatus
        XboxControlSt.Show()
        XboxControlSt.Timer1 = New Timer()
        XboxControlSt.Timer1.Start()
    End Sub
End Class
