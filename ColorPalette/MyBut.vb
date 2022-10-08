'***********************************************************************
'Copyright 2022 Vijay Sridhara

'Licensed under the Apache License, Version 2.0 (the "License");
'you may not use this file except in compliance with the License.
'You may obtain a copy of the License at

'   http://www.apache.org/licenses/LICENSE-2.0

'Unless required by applicable law or agreed to in writing, software
'distributed under the License is distributed on an "AS IS" BASIS,
'WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'See the License for the specific language governing permissions and
'limitations under the License.
'***********************************************************************
Imports System.Drawing
Friend Class MyBut
    Inherits System.Windows.Forms.Button
    Event MouseHovered(sender As Object)
    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)

    End Sub
    Dim hover As Boolean = False

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        hover = True
        RaiseEvent MouseHovered(Me)
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        hover = False
    End Sub

    Private Sub MyBut_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles Me.Paint
        If Me.Focused Then
            e.Graphics.DrawRectangle(New Pen(Brushes.Cyan, 3), Me.ClientRectangle)

        ElseIf hover Then
            e.Graphics.DrawRectangle(New Pen(Brushes.White, 2), Me.ClientRectangle)
        End If


    End Sub
End Class
