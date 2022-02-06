Public Class frmVB_Browser
    Dim x As Integer = 0
   
    Private Sub GO()
        If (Uri.IsWellFormedUriString(txtSearch.Text, UriKind.Absolute)) Then
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(txtSearch.Text)
        Else
            MsgBox("Invalid URL, Please check and try again" & vbNewLine & "Also, don't forget to start with http://", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "VB Browser")
        End If
    End Sub
    Private Sub PageSetUp()
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
    End Sub
    Private Sub PrintPreview()
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
    End Sub
    Private Sub Print()
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub
    Private Sub Loading(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        ToolStripProgressBar.Maximum = e.MaximumProgress
        ToolStripProgressBar.Value = e.CurrentProgress
        
    End Sub

    Private Sub Done(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)

        TabControl.SelectedTab.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        txtSearch.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString


    End Sub

    Private Sub frmVB_Browser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim msg As MsgBoxResult
        msg = MsgBox("Do you want to exit?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "VB Browser")
        If msg = MsgBoxResult.Yes Then
            Exit Sub
        ElseIf msg = vbNo Then

            e.Cancel = True
        End If
    End Sub

    Private Sub frmVB_Browser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Dim Browser As New WebBrowser
            TabControl.TabPages.Add("New Tab")
            Browser.Name = "VB Browser"
            Browser.CausesValidation = False
            Browser.ScriptErrorsSuppressed = True
            Browser.Dock = DockStyle.Fill
            TabControl.SelectedTab.Controls.Add(Browser)
            AddHandler Browser.ProgressChanged, AddressOf Loading
            AddHandler Browser.DocumentCompleted, AddressOf Done
            x = x + 1

            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.msn.com")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTabToolStripMenuItem.Click

        Try
            Dim Browser As New WebBrowser
            TabControl.TabPages.Add("New Tab")
            TabControl.SelectTab(x)
            Browser.Name = "VB Browser"
            Browser.CausesValidation = False
            Browser.ScriptErrorsSuppressed = True

            Browser.Dock = DockStyle.Fill
            TabControl.SelectedTab.Controls.Add(Browser)
            AddHandler Browser.ProgressChanged, AddressOf Loading
            AddHandler Browser.DocumentCompleted, AddressOf Done
            x = x + 1

            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.msn.com")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveTabToolStripMenuItem.Click
        Try
            If Not TabControl.TabPages.Count = 1 Then
                TabControl.TabPages.RemoveAt(TabControl.SelectedIndex)
                TabControl.SelectTab(TabControl.TabPages.Count - 1)
                x = x - 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim msg As MsgBoxResult
        msg = MsgBox("Do you want to exit?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "VB Browser")
        If msg = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoBack()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForward.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.msn.com")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Try
            GO()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Try
            ToolStripStatusLabel.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).StatusText
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                GO()
                
            End If
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click
        Try
            Dim new_window As String = Application.ExecutablePath

            Process.Start(new_window)
            Me.StartPosition = FormStartPosition.WindowsDefaultLocation

        Catch ex As Exception
            MsgBox("Executable path does not exist", MsgBoxStyle.Critical, "New Window")
        End Try
    End Sub

    Private Sub lblOldVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOldVersion.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.oldversion.com")
        Catch ex As Exception

        End Try
    End Sub

  
    Private Sub lblCnn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCnn.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://edition.cnn.com/US/OJ/")
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub lblDoleKemp96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDoleKemp96.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.dolekemp96.org/main.htm")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblITCorp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblITCorp.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://itcorp.com/")
        Catch ex As Exception

        End Try
    End Sub

  
    Private Sub lblAcme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAcme.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://acme.com/")
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub lblPmichaud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPmichaud.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.pmichaud.com/toast/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblMilk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMilk.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.milk.com")
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub lblMcom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMcom.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://home.mcom.com/home/welcome.html")
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub lblEditionCnn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEditionCnn.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://edition.cnn.com/EVENTS/1996/year.in.review/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        Try
            Application.Restart()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("VB Browser" & vbNewLine & "Version: 1.0.0" & vbNewLine & "Developed By: Mir Rahed Uddin" & vbNewLine & "Copyright: (C) 2021. All rights reserved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "VB Browser")
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem.Click
        Try
            PageSetUp()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        Try
            PrintPreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Try
            Print()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripPrint_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripPrint.ButtonClick
        Try
            Print()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintPreviewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem1.Click
        Try
            PrintPreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PageSetupToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem1.Click
        Try
            PageSetUp()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub SourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SourceToolStripMenuItem.Click
        Try
            frmSource.txtSource.TabStop = False
            frmSource.txtSource.WordWrap = False
            frmSource.txtSource.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentText
            frmSource.Text = "Source - " & CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
            frmSource.ShowDialog()

            frmSource.txtSource.TabStop = False
            frmSource.txtSource.WordWrap = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

                CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("file:///" & IO.Path.GetFullPath(My.Computer.FileSystem.GetName(OpenFileDialog.FileName)))

            End If
        Catch ex As Exception
            MsgBox("The file cannot be opened", MsgBoxStyle.Critical, "VB Browser")
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).ShowSaveAsDialog()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("http://www.msn.com")
        Catch ex As Exception

        End Try
    End Sub

    
    

    Private Sub ResetZoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetZoomToolStripMenuItem.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style = "zoom:100%"
           
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStrip70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip70.Click
        Try

            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style = "zoom:70%"
            

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStrip90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip90.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style = "zoom:90%"
           

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStrip120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip120.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style = "zoom:120%"
           

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStrip150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip150.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style = "zoom:150%"
           

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStrip180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStrip180.Click
        Try
            CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).Document.Body.Style = "zoom:180%"
            

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullScreenToolStripMenuItem.Click
        If FullScreenToolStripMenuItem.Text = "Full Screen" Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.TopMost = True
            Me.WindowState = FormWindowState.Maximized
            FullScreenToolStripMenuItem.Text = "Exit Full Screen"
        ElseIf FullScreenToolStripMenuItem.Text = "Exit Full Screen" Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.TopMost = False
            Me.WindowState = FormWindowState.Normal
            FullScreenToolStripMenuItem.Visible = True
            FullScreenToolStripMenuItem.Text = "Full Screen"
        End If
    End Sub
End Class
