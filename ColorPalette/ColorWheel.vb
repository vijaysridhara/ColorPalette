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
Imports System.Windows.Forms
Imports System.Drawing

Public Class ColorWheel
    Private cc(0 To 17, 0 To 11) As MyBut
    Dim leftGap As Single = 1
    Private _col As Color = Drawing.Color.White
    Private WithEvents blkBut As New MyBut
    Private WithEvents whtBut As New MyBut
    Public Property Color As Color
        Get
            Return _col
        End Get
        Set(value As Color)
            _col = value
            For Each c As Button In cc
                If c.BackColor = _col Then
                    c.Focus()
                    Exit Property
                End If
            Next
            If _col = blkBut.BackColor Then
                blkBut.Focus()
                Exit Property
            End If
            If _col = whtBut.BackColor Then
                whtBut.Focus()
                Exit Property
            End If
            cc(0, 0).Focus()
        End Set

    End Property
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For i As Integer = 1 To 18
            For j As Integer = 1 To 12

                cc(i - 1, j - 1) = New MyBut
                cc(i - 1, j - 1).FlatStyle = FlatStyle.Flat
                cc(i - 1, j - 1).FlatAppearance.BorderSize = 0
                cc(i - 1, j - 1).AutoSize = False
                cc(i - 1, j - 1).Size = New Size(30, 20)
                cc(i - 1, j - 1).Location = New Drawing.Point(5 + (i - 1) * leftGap + (i - 1) * 30, (j - 1) * leftGap + 5 + (j - 1) * 20)
                Me.Controls.Add(cc(i - 1, j - 1))

                AddHandler cc(i - 1, j - 1).GotFocus, AddressOf butgotFocus
                AddHandler cc(i - 1, j - 1).Click, AddressOf butClick
                AddHandler cc(i - 1, j - 1).MouseHovered, AddressOf MouseHovered
            Next
        Next
        blkBut.FlatStyle = FlatStyle.Flat
        blkBut.FlatAppearance.BorderSize = 0

        whtBut.FlatStyle = FlatStyle.Flat
        whtBut.FlatAppearance.BorderSize = 0
        blkBut.BackColor = Color.Black
        whtBut.BackColor = Color.White
        blkBut.Size = New Size(30, 20)
        whtBut.Size = New Size(30, 20)
        AddHandler blkBut.GotFocus, AddressOf butgotFocus
        AddHandler blkBut.Click, AddressOf butClick
        AddHandler whtBut.GotFocus, AddressOf butgotFocus
        AddHandler whtBut.Click, AddressOf butClick
        AddHandler blkBut.MouseHovered, AddressOf MouseHovered
        AddHandler whtBut.MouseHovered, AddressOf MouseHovered
        blkBut.Location = New Point(5, cc(0, 11).Location.Y + 20 + leftGap)
        whtBut.Location = New Point(blkBut.Location.X + 30 + leftGap, blkBut.Location.Y)
        Me.Controls.Add(blkBut)
        Me.Controls.Add(whtBut)
        LoadColors()
    End Sub
    Private Sub MouseHovered(sender As Object)
        txtRGB.Text = sender.BackColor.R & "," & sender.BackColor.G & "," & sender.BackColor.B & " Alpha: " & TrackBar1.Value
    End Sub
    Private Sub butClick(sender As Object, e As EventArgs)
        _col = sender.backcolor
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub ColorWheel_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub
    Private Sub ColorWheel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        Label1.TabIndex = 219
        txtRGB.TabIndex = 220
        Label2.TabIndex = 221
        TrackBar1.TabIndex = 222

        cc(0, 0).Focus()


    End Sub
    Dim red As Integer
    Dim blue As Integer
    Dim green As Integer
    Private Sub butgotFocus(sender As Object, e As EventArgs)
        txtRGB.Text = sender.BackColor.R & "," & sender.BackColor.G & "," & sender.BackColor.B & " Alpha: " & TrackBar1.Value
    End Sub
    Private Sub LoadColors()

        For i As Integer = 1 To 18
            For j As Integer = 1 To 12

                If i <= 6 Then
                    red = i * 42
                    If j <= 6 Then
                        green = j * 42
                        blue = 42
                    ElseIf j > 6 Then
                        green = (j - 6) * 42
                        blue = 42 * 2
                    End If
                ElseIf i > 6 And i <= 12 Then
                    red = (i - 6) * 42
                    If j <= 6 Then
                        green = j * 42
                        blue = 42 * 3
                    ElseIf j > 6 Then
                        green = (j - 6) * 42
                        blue = 42 * 4
                    End If
                Else
                    If j <= 6 Then
                        green = j * 42
                        blue = 42 * 5
                    ElseIf j > 6 Then
                        green = (j - 6) * 42
                        blue = 42 * 6
                    End If

                End If
                cc(i - 1, j - 1).BackColor = System.Drawing.Color.FromArgb(TrackBar1.Value, red, green, blue)




            Next
        Next

    End Sub

 

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        LoadColors()
        txtRGB.Text = " Alpha: " & TrackBar1.Value
    End Sub

    Private Sub butSysColors_Click(sender As Object, e As EventArgs) Handles butSysColors.Click
        Dim cfd As New ColorDialog
        cfd.Color = Me.Color
        If cfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Color = cfd.Color
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class