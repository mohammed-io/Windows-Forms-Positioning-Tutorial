Imports System.ComponentModel

Public Class Form1
    ' The next lines are used for the magic
    Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub Notify(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
    ' The end of magical lines

    Private _LeftValue As Integer
    Public Property LeftValue() As Integer
        Get
            Return _LeftValue
        End Get
        Set(ByVal value As Integer)
            _LeftValue = value
            Notify("LeftValue")
        End Set
    End Property

    Private _TopValue As Integer
    Public Property TopValue() As Integer
        Get
            Return _TopValue
        End Get
        Set(ByVal value As Integer)
            _TopValue = value
            Notify("LeftValue")
        End Set
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Dont think a lot about this, it's like a magic!
        MovingButton.DataBindings.Add(New Binding("Left", Me, "LeftValue"))
        MovingButton.DataBindings.Add(New Binding("Top", Me, "TopValue"))

        HorizontalTrackBar.DataBindings.Add(New Binding("Maximum", Me, "Width"))

        VerticalTrackBar.DataBindings.Add(New Binding("Maximum", Me, "Height"))
        ' The end of magic

        VerticalTrackBar.Value = VerticalTrackBar.Maximum
        UpdateFormText()
    End Sub

    Private Sub MovingButton_Click(sender As Object, e As EventArgs) Handles MovingButton.Click
        MessageBox.Show("The Width: " & MovingButton.Width & ", The Height: " & MovingButton.Height)
    End Sub

    Private Sub HorizontalTrackBar_Scroll(sender As Object, e As EventArgs) Handles HorizontalTrackBar.Scroll
        LeftValue = HorizontalTrackBar.Value

        UpdateFormText()
    End Sub

    Private Sub VerticalTrackBar_Scroll(sender As Object, e As EventArgs) Handles VerticalTrackBar.Scroll
        TopValue = VerticalTrackBar.Maximum - VerticalTrackBar.Value

        UpdateFormText()
    End Sub

    Private Sub UpdateFormText()
        Me.Text = "Top: " & MovingButton.Top & ", Bottom: " & MovingButton.Bottom & ", Left: " & MovingButton.Left & ", Right: " & MovingButton.Right
    End Sub

End Class
