Imports Microsoft.Xna
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input
Imports Microsoft.Xna.Framework.GamerServices
Imports Microsoft.Xna.Framework.Content
'references

'goto project-add references
'add all xna from .net tab
'go to project - properties -references tag
'under imported namespace check
'Microsoft.xna
'Microsoft.XnaFramework
'Microsoft.XnaFramework.Content
'Microsoft.XnaFramework.GameServices

Public Class xBox360Controller



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.One)

        If currentState.IsConnected Then



            If currentState.Buttons.A = ButtonState.Pressed Then

                tbButtonA.Text = "  Pressed"

            Else
                tbButtonA.Text = "  Released"

            End If

            If currentState.Buttons.X = ButtonState.Pressed Then
                tbButtonX.Text = "  Pressed"
            Else
                tbButtonX.Text = "  Released"
            End If

            If currentState.Buttons.Y = ButtonState.Pressed Then
                tbButtonY.Text = "  Pressed"
            Else
                tbButtonY.Text = "  Released"
            End If

            If currentState.Buttons.B = ButtonState.Pressed Then
                tbButtonB.Text = "  Pressed"
            Else
                tbButtonB.Text = "  Released"
            End If

            If currentState.Buttons.RightShoulder = ButtonState.Pressed Then
                tbRB.Text = "  Pressed"
            Else
                tbRB.Text = "  Released"
            End If




            If currentState.Buttons.Start = ButtonState.Pressed Then
                tbStartButton.Text = "Pressed"
            Else
                tbStartButton.Text = "Released"
            End If

            If currentState.Buttons.Back = ButtonState.Pressed Then
                tbBackButton.Text = "Pressed"
            Else
                tbBackButton.Text = "Released"
            End If





            'Triggers
            If currentState.Triggers.Right = ButtonState.Pressed Then
                tbRT.Text = "  Pressed"
                GamePad.SetVibration(PlayerIndex.One, 10, 0)
            Else
                tbRT.Text = "  Released"
                GamePad.SetVibration(PlayerIndex.One, 0, 0)
            End If



            If currentState.Buttons.LeftShoulder = ButtonState.Pressed Then
                tbLB.Text = "  Pressed"

            Else
                tbLB.Text = "  Released"

            End If



            If currentState.Triggers.Left = ButtonState.Pressed Then
                tbLT.Text = "  Pressed"
                GamePad.SetVibration(PlayerIndex.One, 0, 10)
            Else
                tbLT.Text = "  Released"
                GamePad.SetVibration(PlayerIndex.One, 0, 0)
            End If

            'DPad
            If currentState.DPad.Down = ButtonState.Pressed Then
                tbDpad.Text = "  DOWN"
            ElseIf currentState.DPad.Left = ButtonState.Pressed Then
                tbDpad.Text = "  LEFT"
            ElseIf currentState.DPad.Right = ButtonState.Pressed Then
                tbDpad.Text = "  RIGHT"
            ElseIf currentState.DPad.Up = ButtonState.Pressed Then
                tbDpad.Text = "  UP"
            Else
                tbDpad.Text = "  NULL"
            End If

            'ThumbSticks
            tbRightStickX.Text = currentState.ThumbSticks.Right.X.ToString()
            tbRightStickY.Text = currentState.ThumbSticks.Right.Y.ToString()

            If currentState.Buttons.RightStick = ButtonState.Pressed Then
                tbRightStickPress.Text = "  Pressed"
            Else
                tbRightStickPress.Text = "  Released"
            End If



            tbLeftStickX.Text = currentState.ThumbSticks.Left.X.ToString()
            tbLeftStickY.Text = currentState.ThumbSticks.Left.Y.ToString()

            If currentState.Buttons.LeftStick = ButtonState.Pressed Then
                tbLeftStickPress.Text = "  Pressed"
            Else
                tbLeftStickPress.Text = "  Released"
            End If



        End If

    End Sub

End Class