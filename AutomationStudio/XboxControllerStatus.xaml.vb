Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input
Imports System.Timers
Imports System.Windows.Threading

Public Class XboxControllerStatus
    Friend WithEvents Timer1 As Timer

    Delegate Sub SetCheckBoxCallback(ByVal value As Boolean)
    Friend Sub SetXCheckBox(ByVal value As Boolean)
        XButton.IsChecked = value
    End Sub
    Friend Sub SetYCheckBox(ByVal value As Boolean)
        YButton.IsChecked = value
    End Sub
    Friend Sub SetACheckBox(ByVal value As Boolean)
        AButton.IsChecked = value
    End Sub
    Friend Sub SetBCheckBox(ByVal value As Boolean)
        BButton.IsChecked = value
    End Sub
    Delegate Sub SetButtonCallback(ByVal value As String)
    Friend Sub SetLBButton(ByVal value As String)
        LB.Content = value
    End Sub
    Friend Sub SetRBButton(ByVal value As String)
        RB.Content = value
    End Sub
    Delegate Sub SetProgressBarCallback(ByVal value As Single)
    Friend Sub SetLProgressBar(ByVal value As Single)
        LProgress.Value = Convert.ToDouble(value) * 100
    End Sub
    Friend Sub SetRProgressBar(ByVal value As Single)
        RProgress.Value = Convert.ToDouble(value) * 100
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Elapsed

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.One)
        Dim DesiredValueTrue As Boolean = True
        Dim DesiredValueFalse As Boolean = False
        Dim DesiredContentPressed As String = "Pressed"
        Dim DesiredContentLB As String = "LB"
        Dim DesiredContentRB As String = "RB"
        Dim LTriggerReading As Single = currentState.Triggers.Left
        Dim RTriggerReading As Single = currentState.Triggers.Right
        If currentState.IsConnected Then
            'Right side control buttons
            If currentState.Buttons.X = ButtonState.Pressed Then

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetXCheckBox), New Object() {DesiredValueTrue})
            Else

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetXCheckBox), New Object() {DesiredValueFalse})
            End If
            If currentState.Buttons.Y = ButtonState.Pressed Then

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetYCheckBox), New Object() {DesiredValueTrue})
            Else

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetYCheckBox), New Object() {DesiredValueFalse})
            End If
            If currentState.Buttons.A = ButtonState.Pressed Then

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetACheckBox), New Object() {DesiredValueTrue})
            Else

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetACheckBox), New Object() {DesiredValueFalse})
            End If
            If currentState.Buttons.B = ButtonState.Pressed Then

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetBCheckBox), New Object() {DesiredValueTrue})
            Else

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetBCheckBox), New Object() {DesiredValueFalse})
            End If
            'Left and right shoulders
            If currentState.Buttons.LeftShoulder = ButtonState.Pressed Then

                Me.Dispatcher.Invoke(New SetButtonCallback(AddressOf SetLBButton), New Object() {DesiredContentPressed})
            Else
                Me.Dispatcher.Invoke(New SetButtonCallback(AddressOf SetLBButton), New Object() {DesiredContentLB})

            End If
            If currentState.Buttons.RightShoulder = ButtonState.Pressed Then
                Me.Dispatcher.Invoke(New SetButtonCallback(AddressOf SetRBButton), New Object() {DesiredContentPressed})
            Else
                Me.Dispatcher.Invoke(New SetButtonCallback(AddressOf SetRBButton), New Object() {DesiredContentRB})

            End If
            'Triggers
            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetLProgressBar), New Object() {LTriggerReading})
            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetRProgressBar), New Object() {RTriggerReading})
        End If

    End Sub

End Class
