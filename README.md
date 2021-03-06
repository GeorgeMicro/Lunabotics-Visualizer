# Lunabotics-Visualizer
Visualizer is the Command Center (Human Machine Interface)  for Purdue Lunabot !

![Alt text](https://github.com/piyushnet/Lunabotics-Visualizer/blob/master/AutomationStudio/Preview/04_Banner.png "Preview")

Summary:
It is at the heart of the command/control room and provides all the teams with valuable information EARLY in the design & build process and more importantly during the competition.

It allows multiple instances to run on different/same machine(s). It also allows multiple Lunabots to be monitored simulatneously. In addition, you can select the communcation interface between Wifi and Wired Ethernet depending on your needs. (Please see Communications Tab for Details.)

Organisation of Information:
The overview window allows the key parameters to be monitored at a glance. Further, the Team Specific Tabs allow detailed supervision of parameters related to a perticular team. This means, each team can request the variables they would like to monitor during the design/build phase and during the competition.

Support:
If you have any questions feel free to Email me at 
sharm152@purdue.edu.

Piyush Sharma

The Communications and User Interface Team,
Purdue Lunabotics


Dependency Install Tutorial for XNA (Xbox GamePad Driver)

1. Download XNA Framework 4.0 refresh from
https://msxna.codeplex.com/releases
To Setting up for visual Studio 2015
http://stackoverflow.com/questions/28008970/how-to-install-xna-in-visual-studio-2015-preview

2. Run the setups in all four folders

3. Add all the XNA related references in Project -> Add References
 

Example code for controller interfacing
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
 
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick 
 
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
            If currentState.Buttons.LeftShoulder = ButtonState.Pressed Then 
                tbLB.Text = "  Pressed" 
            Else 
                tbLB.Text = "  Released" 
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
            If currentState.Triggers.Left = ButtonState.Pressed Then 
                tbLT.Text = "  Pressed" 
                GamePad.SetVibration(PlayerIndex.One, 0, 10) 
            Else 
                tbLT.Text = "  Released" 
                GamePad.SetVibration(PlayerIndex.One, 0, 0) 
            End If 
            'D-Pad 
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