﻿Imports Microsoft.Xna
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input
Imports Microsoft.Xna.Framework.GamerServices
Imports Microsoft.Xna.Framework.Content
Imports System.Timers

Class MainWindow
    Inherits Elysium.Controls.Window




    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

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
    Friend Sub SetUpCheckBox(ByVal value As Boolean)
        UpButton.IsChecked = value
    End Sub
    Friend Sub SetDownCheckBox(ByVal value As Boolean)
        DownButton.IsChecked = value
    End Sub
    Friend Sub SetLeftCheckBox(ByVal value As Boolean)
        LeftButton.IsChecked = value
    End Sub
    Friend Sub SetRightCheckBox(ByVal value As Boolean)
        RightButton.IsChecked = value
    End Sub
    Friend Sub SetStartCheckBox(ByVal value As Boolean)
        StartButton.IsChecked = value
    End Sub
    Friend Sub SetBackCheckBox(ByVal value As Boolean)
        BackButton.IsChecked = value
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
    Friend Sub SetUpProgressBar(ByVal value As Single)
        If value > 0 Then
            UpProgress.Value = Convert.ToDouble(value) * 100
        Else
            UpProgress.Value = 0
        End If
    End Sub
    Friend Sub SetDownProgressBar(ByVal value As Single)
        If value < 0 Then
            DownProgress.Value = Convert.ToDouble(value) * -100
        Else
            DownProgress.Value = 0
        End If

    End Sub
    Friend Sub SetLeftProgressBar(ByVal value As Single)
        If value < 0 Then
            LeftProgress.Value = Convert.ToDouble(value) * -100
        Else
            LeftProgress.Value = 0
        End If

    End Sub
    Friend Sub SetRightProgressBar(ByVal value As Single)
        If value > 0 Then
            RightProgress.Value = Convert.ToDouble(value) * 100
        Else
            RightProgress.Value = 0
        End If
    End Sub
    Friend Sub SetUp1ProgressBar(ByVal value As Single)
        If value > 0 Then
            Up1Progress.Value = Convert.ToDouble(value) * 100
        Else
            Up1Progress.Value = 0
        End If
    End Sub
    Friend Sub SetDown1ProgressBar(ByVal value As Single)
        If value < 0 Then
            Down1Progress.Value = Convert.ToDouble(value) * -100
        Else
            Down1Progress.Value = 0
        End If

    End Sub
    Friend Sub SetLeft1ProgressBar(ByVal value As Single)
        If value < 0 Then
            Left1Progress.Value = Convert.ToDouble(value) * -100
        Else
            Left1Progress.Value = 0
        End If

    End Sub
    Friend Sub SetRight1ProgressBar(ByVal value As Single)
        If value > 0 Then
            Right1Progress.Value = Convert.ToDouble(value) * 100
        Else
            Right1Progress.Value = 0
        End If
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
            'D Pad
            If currentState.DPad.Up = ButtonState.Pressed Then
                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetUpCheckBox), New Object() {DesiredValueTrue})
            Else

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetUpCheckBox), New Object() {DesiredValueFalse})
            End If
            If currentState.DPad.Down = ButtonState.Pressed Then
                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetDownCheckBox), New Object() {DesiredValueTrue})
            Else

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetDownCheckBox), New Object() {DesiredValueFalse})
            End If
            If currentState.DPad.Right = ButtonState.Pressed Then
                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetRightCheckBox), New Object() {DesiredValueTrue})
            Else

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetRightCheckBox), New Object() {DesiredValueFalse})
            End If
            If currentState.DPad.Left = ButtonState.Pressed Then
                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetLeftCheckBox), New Object() {DesiredValueTrue})
            Else

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetLeftCheckBox), New Object() {DesiredValueFalse})
            End If
            If currentState.Buttons.Start = ButtonState.Pressed Then
                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetStartCheckBox), New Object() {DesiredValueTrue})
            Else

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetStartCheckBox), New Object() {DesiredValueFalse})
            End If
            If currentState.Buttons.Back = ButtonState.Pressed Then
                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetBackCheckBox), New Object() {DesiredValueTrue})
            Else

                Me.Dispatcher.Invoke(New SetCheckBoxCallback(AddressOf SetBackCheckBox), New Object() {DesiredValueFalse})
            End If
            'Triggers
            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetLProgressBar), New Object() {LTriggerReading})
            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetRProgressBar), New Object() {RTriggerReading})

            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetUpProgressBar), New Object() {currentState.ThumbSticks.Left.Y})
            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetDownProgressBar), New Object() {currentState.ThumbSticks.Left.Y})
            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetLeftProgressBar), New Object() {currentState.ThumbSticks.Left.X})
            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetRightProgressBar), New Object() {currentState.ThumbSticks.Left.X})

            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetUp1ProgressBar), New Object() {currentState.ThumbSticks.Right.Y})
            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetDown1ProgressBar), New Object() {currentState.ThumbSticks.Right.Y})
            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetLeft1ProgressBar), New Object() {currentState.ThumbSticks.Right.X})
            Me.Dispatcher.Invoke(New SetProgressBarCallback(AddressOf SetRight1ProgressBar), New Object() {currentState.ThumbSticks.Right.X})
        End If

    End Sub

End Class
