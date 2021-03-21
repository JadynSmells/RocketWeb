Imports CefSharp.WinForms
Imports CefSharp
Public Class Browser
    Public Browser As ChromiumWebBrowser
    Dim draggable As Boolean
    Dim resizable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub Browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fr As New IO.StreamReader(Application.StartupPath + "/Favourites.rocket")
        Dim settings As New CefSettings()
        settings.RemoteDebuggingPort = 8088
        Try
            settings.CefCommandLineArgs.Add("persist_session_cookies", "1")
            settings.CefCommandLineArgs.Add("renderer-process-limit", "1")
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Rocket"
            settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:86.0) Gecko/20100101 Firefox/86.0"
            CefSharp.Cef.Initialize(settings)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Browser = New ChromiumWebBrowser(My.Settings.Homepage)
        BrowserPanel.Controls.Add(Browser)
        Browser.Dock = DockStyle.Fill
        '-----------------------------
        BackHover.Visible = False
        ForwardHover.Visible = False
        MenuHover.Visible = False
        FavouriteHover.Visible = False
        FavouriteSelected.Visible = False
        FavouriteSelectedHover.Visible = False
        ReloadHover.Visible = False
        HomeHover.Visible = False
        '----------------------------
        Do While fr.Peek > -1
            Me.Favourites.Items.Add(fr.ReadLine)
        Loop
        fr.Close()
        fr.Dispose()
        fr = Nothing
    End Sub

    Private Sub BackNormal_MouseHover(sender As Object, e As EventArgs) Handles BackNormal.MouseHover
        If Browser.CanGoBack Then
            BackHover.Visible = True
        End If
    End Sub

    Private Sub BackHover_Click(sender As Object, e As EventArgs) Handles BackHover.Click
        Browser.Back
    End Sub

    Private Sub BackHover_MouseLeave(sender As Object, e As EventArgs) Handles BackHover.MouseLeave
        BackHover.Visible = False
    End Sub

    Private Sub ForwardHover_Click(sender As Object, e As EventArgs) Handles ForwardHover.Click
        Browser.Forward
    End Sub

    Private Sub ForwardNormal_MouseHover(sender As Object, e As EventArgs) Handles ForwardNormal.MouseHover
        If Browser.CanGoForward Then
            ForwardHover.Visible = True
        End If
    End Sub

    Private Sub ForwardHover_MouseLeave(sender As Object, e As EventArgs) Handles ForwardHover.MouseLeave
        ForwardHover.Visible = False
    End Sub

    Private Sub MenuHover_MouseLeave(sender As Object, e As EventArgs) Handles MenuHover.MouseLeave
        MenuHover.Visible = False
    End Sub

    Private Sub MenuNormal_MouseHover(sender As Object, e As EventArgs) Handles MenuNormal.MouseHover
        MenuHover.Visible = True
    End Sub

    Private Sub FavouriteHover_MouseLeave(sender As Object, e As EventArgs) Handles FavouriteHover.MouseLeave
        FavouriteHover.Visible = False
    End Sub

    Private Sub FavouriteNormal_MouseHover(sender As Object, e As EventArgs) Handles FavouriteNormal.MouseHover
        FavouriteHover.Visible = True
    End Sub

    Private Sub FavouriteHover_MouseClick(sender As Object, e As MouseEventArgs) Handles FavouriteHover.MouseClick
        Favourites.Items.Add(Browser.Address.Replace("https://", "").Replace("http://", "").Replace("www.", ""))
    End Sub

    Private Sub FavouriteSelected_MouseHover(sender As Object, e As EventArgs) Handles FavouriteSelected.MouseHover
        FavouriteSelectedHover.Visible = True
    End Sub

    Private Sub FavouriteSelectedHover_MouseLeave(sender As Object, e As EventArgs) Handles FavouriteSelectedHover.MouseLeave
        FavouriteSelectedHover.Visible = False
    End Sub

    Private Sub FavouriteSelectedHover_Click(sender As Object, e As EventArgs) Handles FavouriteSelectedHover.Click
        Favourites.Items.Remove(Browser.Address.Replace("https://", "").Replace("http://", "").Replace("www.", ""))
    End Sub
    Private Sub Favourites_DoubleClick(sender As Object, e As EventArgs) Handles Favourites.DoubleClick
        Favourites.Items.Remove(Favourites.SelectedItem)
    End Sub

    Private Sub BookmarkChecker_Tick(sender As Object, e As EventArgs) Handles FavouritesChecker.Tick
        If Favourites.Items.Contains((Browser.Address.Replace("https://", "").Replace("http://", "").Replace("www.", ""))) Then
            FavouriteSelected.Visible = True
        Else
            FavouriteSelected.Visible = False
        End If
    End Sub

    Private Sub ReloadHover_MouseLeave(sender As Object, e As EventArgs) Handles ReloadHover.MouseLeave
        ReloadHover.Visible = False
    End Sub

    Private Sub Reload_MouseHover(sender As Object, e As EventArgs) Handles Reload.MouseHover
        ReloadHover.Visible = True
    End Sub

    Private Sub ReloadHover_Click(sender As Object, e As EventArgs) Handles ReloadHover.Click
        Browser.Reload
    End Sub

    Private Sub AddressUpdate_Tick(sender As Object, e As EventArgs) Handles AddressUpdate.Tick
        If AdrText.Focused = False Then
            AdrText.Text = Browser.Address.ToString
        End If
        Me.Text = (Browser.Address.Replace("https://", "").Replace("http://", "").Replace("www.", "").Replace(".ww2", "") + " - Rocket")
        If Not Me.FormBorderStyle = FormBorderStyle.None Then
            If Favourites.Items.Count = 0 Then
                Favourites.Visible = False
            Else
                Favourites.Visible = True
            End If
        End If
    End Sub

    Private Sub AdrText_KeyDown(sender As Object, e As KeyEventArgs) Handles AdrText.KeyDown
        If e.KeyCode = Keys.Enter Then
            If AdrText.Text.Contains(".") And Not AdrText.Text.Contains(" ") Then
                Browser.Load(AdrText.Text)
            Else
                Browser.Load("https://www.google.com/search?q=" + AdrText.Text)
            End If
        End If
    End Sub

    Private Sub Favourites_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Favourites.SelectedIndexChanged
        Browser.Load(Favourites.SelectedItem)
        MenuHover.Visible = False
        Favourites.SelectionMode = SelectionMode.None
        Favourites.SelectionMode = SelectionMode.One
    End Sub

    Private Sub HomeNormal_MouseHover(sender As Object, e As EventArgs) Handles HomeNormal.MouseHover
        HomeHover.Visible = True
    End Sub

    Private Sub HomeHover_MouseLeave(sender As Object, e As EventArgs) Handles HomeHover.MouseLeave
        HomeHover.Visible = False
    End Sub

    Private Sub HomeHover_Click(sender As Object, e As EventArgs) Handles HomeHover.Click
        Browser.Load(My.Settings.Homepage)
    End Sub

    Private Sub Browser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fw As New IO.StreamWriter(Application.StartupPath + "/Favourites.rocket")
        My.Settings.Save()
        For Each itm As Object In Me.Favourites.Items
            fw.WriteLine(itm.ToString)
        Next
        fw.Close()
        fw.Dispose()
        fw = Nothing
    End Sub
    Private Sub MenuHover_Click(sender As Object, e As EventArgs) Handles MenuHover.Click
        If Me.FormBorderStyle = FormBorderStyle.None Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
            Panel1.Visible = True
            If Favourites.Items.Count = 0 Then
                Favourites.Visible = False
            Else
                Favourites.Visible = True
            End If
        Else
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            Panel1.Visible = False
            Favourites.Visible = False
        End If
    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        If Panel1.Visible = False Then
            Panel1.Visible = True
        End If
    End Sub

    Private Sub FullscreenPanelHide_Tick(sender As Object, e As EventArgs) Handles FullscreenPanelHide.Tick
        If Me.FormBorderStyle = FormBorderStyle.None And Cursor.Position.Y > 50 Then
            Panel1.Visible = False
        End If
    End Sub
End Class
