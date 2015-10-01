Public Class MainForm
    'C=the cell number, CSO = Cell text These are arrays of information that keeps track of what cell has what info in it.
    ' RoutineIndex ....
    Public RoutineIndex(0 To 200), C(0 To 200), CSO(0 To 200) As String, cellnumber As Integer
    'CFR,G,B = Forgroung RGB color, CGR,G,B = RGB Background color
    Public CFR(0 To 200), CFG(0 To 200), CFB(0 To 200), CBR(0 To 200), CBG(0 To 200), CBB(0 To 200), Ccycles(0 To 200), Ctime(0 To 200) As String, dblclicked As String, heldcell As String
    Public quickcolorsparkle As String = "randomColorSparkle(50,200); //delay - random color sparkles (delay, time to next routine)"
    Public slowcolorsparkle As String = "randomColorSparkle(200,50); //delay - random color sparkles (delay, time to next routine)"
    Public SS As String = 10


    ' this is where the pde file is assembled before it is compiled
    Private Sub WriteArduino_Click(sender As Object, e As EventArgs) Handles WriteArduino.Click
        Dim OpenLoopReader As String
        Dim headerReader As String
        Dim setupReader As String
        Dim loopReader As String = ""
        Dim subroutineReader As String
        Dim File_NAME As String = "C:\ledwiz\prgfile.pde"
        Dim closeloop As String = "}"
        Dim SS As String = LEDnumber.Text
        Dim PN As String = PINnumber.Text
        Dim WS2801stringsize As String = "Adafruit_WS2801 strip = Adafruit_WS2801(" + SS + ");"
        Dim WS2811stringsize As String = "Adafruit_NeoPixel strip = Adafruit_NeoPixel(" + SS + "," + PN + ", NEO_GRB + NEO_KHZ800);"
        Dim LPD8806stringsize As String = "LPD8806 strip = LPD8806(" + SS + ");"
        Dim numled As String = "const int numled =  " + SS + ";"

        ' make sure there is a valid led string selected in the LED type box
        If LEDchoice.Text = "" Then
            MessageBox.Show(" Please enter a valid LED type")
            Exit Sub
        End If
        ' make sure that there is a number in the "LED Number" box
        If IsNumeric(LEDnumber.Text) = False Then
            MessageBox.Show(" Please enter a valid NUMBER in the 'Number of LEDs' Box")
            Exit Sub
        End If
        ' make sure there is a valid CPU string selected in the CPU type box
        If CPUchoice.Text = "" Then
            MessageBox.Show(" Please enter a valid CPU type")
            Exit Sub
        End If
        ' We need the Com port string before we can create a routine
        If ComPortSel.Text = "" Then
            MessageBox.Show(" Please enter a valid Com port for the Arduino")
            Exit Sub
        End If
        Dim objWriter As New System.IO.StreamWriter(File_NAME, False) ' Open the pde file for write

        OpenLoopReader = My.Computer.FileSystem.ReadAllText("C:\ledwiz\data\OpenLoop.txt")
        setupReader = My.Computer.FileSystem.ReadAllText("C:\ledwiz\data\LEDsetup.txt")


        ' Choose which header based on what led strip is selected
        Dim ledstyle As Integer
        ledstyle = LEDchoice.SelectedIndex

        Select Case ledstyle
            Case 0
                headerReader = My.Computer.FileSystem.ReadAllText("C:\ledwiz\data\WS2801headers.txt")
                objWriter.WriteLine(headerReader) ' write header
                objWriter.WriteLine(WS2801stringsize) ' Write LED length size in LED def
                objWriter.WriteLine(numled) ' Write LED length size for calculations
                ' MessageBox.Show("WS2801")

            Case 1
                headerReader = My.Computer.FileSystem.ReadAllText("C:\ledwiz\data\LPD8806headers.txt")
                objWriter.WriteLine(headerReader)
                objWriter.WriteLine(LPD8806stringsize)
                objWriter.WriteLine(numled)
                'MessageBox.Show("LPD8806")
            Case 2
                headerReader = My.Computer.FileSystem.ReadAllText("C:\ledwiz\data\WS2811headers.txt")
                objWriter.WriteLine(headerReader)
                objWriter.WriteLine(WS2811stringsize)
                objWriter.WriteLine(numled)
                'MessageBox.Show("WS2811")
        End Select


        ' write the subroutines for all of the routines
        subroutineReader = My.Computer.FileSystem.ReadAllText("C:\ledwiz\data\subroutines.txt")
        objWriter.WriteLine(subroutineReader)

        ' Write the setup (this is the same for all LED strings)
        objWriter.WriteLine(setupReader)

        ' write the Void loop() { to the pde file 
        objWriter.WriteLine(OpenLoopReader)

        ' Check to see if user has entered at least one routine
        loopReader = C(1) ' if a routine is loaded for write then "C1" will ALWAYS have something in it
        If loopReader = "" Then
            MessageBox.Show(" You must add at least one 'Routine'")
            objWriter.Close()
            Exit Sub
        End If

        ' this writes all of the routines to the pde file
        For p As Integer = 1 To 32
            loopReader = C(p)
            objWriter.WriteLine(loopReader)
        Next



        ' write the Close loop } to the pde file
        objWriter.WriteLine(closeloop)


        objWriter.Close() ' Close the pde file


        Create_Batch() ' create the proper cpu batch file

        ' prgbuild.bat compiles and loads the pde file to the teensy arduino
            System.Diagnostics.Process.Start("C:\ledwiz\prgbuild.bat")


    End Sub
    ' Anytime a cell is double clicked. We come here to put the cell number into a var "m" and call modform which finds stored data
    ' about the cell and places that data into the moodform form
    ' double click stores cell number into "m" then launches the (Modify Form) to modify said cell
    Private Sub cell_1_Click(sender As Object, e As EventArgs) Handles cell_1.DoubleClick

        Dim m As Integer = 1

        Call modform(m)

    End Sub

    Private Sub cell_2_Click(sender As Object, e As EventArgs) Handles cell_2.DoubleClick

 
        Dim m As Integer = 2

        Call modform(m)

    End Sub

    Private Sub cell_3_Click(sender As Object, e As EventArgs) Handles cell_3.DoubleClick

        Dim m As Integer = 3

        Call modform(m)


    End Sub

    Private Sub cell_4_Click(sender As Object, e As EventArgs) Handles cell_4.DoubleClick

        Dim m As Integer = 4

        Call modform(m)


    End Sub

    Private Sub cell_5_Click(sender As Object, e As EventArgs) Handles cell_5.DoubleClick

        Dim m As Integer = 5

        Call modform(m)


    End Sub

    Private Sub cell_6_Click(sender As Object, e As EventArgs) Handles cell_6.DoubleClick

        Dim m As Integer = 6

        Call modform(m)


    End Sub

    Private Sub cell_7_Click(sender As Object, e As EventArgs) Handles cell_7.DoubleClick

        Dim m As Integer = 7

        Call modform(m)


    End Sub

    Private Sub cell_8_Click(sender As Object, e As EventArgs) Handles cell_8.DoubleClick

        Dim m As Integer = 8

        Call modform(m)


    End Sub

    Private Sub cell_9_Click(sender As Object, e As EventArgs) Handles cell_9.DoubleClick

        Dim m As Integer = 9

        Call modform(m)


    End Sub

    Private Sub cell_10_Click(sender As Object, e As EventArgs) Handles cell_10.DoubleClick

        Dim m As Integer = 10

        Call modform(m)


    End Sub

    Private Sub cell_11_Click(sender As Object, e As EventArgs) Handles cell_11.DoubleClick

        Dim m As Integer = 11

        Call modform(m)


    End Sub

    Private Sub cell_12_Click(sender As Object, e As EventArgs) Handles cell_12.DoubleClick

        Dim m As Integer = 12

        Call modform(m)


    End Sub

    Private Sub cell_13_Click(sender As Object, e As EventArgs) Handles cell_13.DoubleClick

        Dim m As Integer = 13

        Call modform(m)


    End Sub

    Private Sub cell_14_Click(sender As Object, e As EventArgs) Handles cell_14.DoubleClick

        Dim m As Integer = 14

        Call modform(m)


    End Sub

    Private Sub cell_15_Click(sender As Object, e As EventArgs) Handles cell_15.DoubleClick

        Dim m As Integer = 15

        Call modform(m)


    End Sub

    Private Sub cell_16_Click(sender As Object, e As EventArgs) Handles cell_16.DoubleClick

        Dim m As Integer = 16

        Call modform(m)


    End Sub

    Private Sub cell_17_Click(sender As Object, e As EventArgs) Handles cell_17.DoubleClick

        Dim m As Integer = 17

        Call modform(m)


    End Sub

    Private Sub cell_18_Click(sender As Object, e As EventArgs) Handles cell_18.DoubleClick

        Dim m As Integer = 18

        Call modform(m)


    End Sub

    Private Sub cell_19_Click(sender As Object, e As EventArgs) Handles cell_19.DoubleClick

        Dim m As Integer = 19

        Call modform(m)


    End Sub

    Private Sub cell_20_Click(sender As Object, e As EventArgs) Handles cell_20.DoubleClick

        Dim m As Integer = 20

        Call modform(m)


    End Sub

    Private Sub cell_21_Click(sender As Object, e As EventArgs) Handles cell_21.DoubleClick

        Dim m As Integer = 21

        Call modform(m)


    End Sub

    Private Sub cell_22_Click(sender As Object, e As EventArgs) Handles cell_22.DoubleClick

        Dim m As Integer = 22

        Call modform(m)


    End Sub

    Private Sub cell_23_Click(sender As Object, e As EventArgs) Handles cell_23.DoubleClick

        Dim m As Integer = 23

        Call modform(m)


    End Sub

    Private Sub cell_24_Click(sender As Object, e As EventArgs) Handles cell_24.DoubleClick

        Dim m As Integer = 24

        Call modform(m)


    End Sub

    Private Sub cell_25_Click(sender As Object, e As EventArgs) Handles cell_25.DoubleClick

        Dim m As Integer = 25

        Call modform(m)


    End Sub

    Private Sub cell_26_Click(sender As Object, e As EventArgs) Handles cell_26.DoubleClick

        Dim m As Integer = 26

        Call modform(m)


    End Sub

    Private Sub cell_27_Click(sender As Object, e As EventArgs) Handles cell_27.DoubleClick

        Dim m As Integer = 27

        Call modform(m)


    End Sub

    Private Sub cell_28_Click(sender As Object, e As EventArgs) Handles cell_28.DoubleClick

        Dim m As Integer = 28

        Call modform(m)


    End Sub

    Private Sub cell_29_Click(sender As Object, e As EventArgs) Handles cell_29.DoubleClick

        Dim m As Integer = 29

        Call modform(m)


    End Sub

    Private Sub cell_30_Click(sender As Object, e As EventArgs) Handles cell_30.DoubleClick

        Dim m As Integer = 30

        Call modform(m)


    End Sub

    Private Sub cell_31_Click(sender As Object, e As EventArgs) Handles cell_31.DoubleClick

        Dim m As Integer = 31

        Call modform(m)


    End Sub

    Private Sub cell_32_Click(sender As Object, e As EventArgs) Handles cell_32.DoubleClick

        Dim m As Integer = 32

        Call modform(m)


    End Sub
    ' Launches "add routine" form
    Private Sub addroutine_Click(sender As Object, e As EventArgs) Handles addroutine.Click
        If CPUchoice.Text = "" Then
            MessageBox.Show(" Please enter a valid CPU type from the CPU type drop down menu")
            Exit Sub
        End If
        ' We need the number of LED's in the string before we can create a routine
        If LEDnumber.Text = "" Then
            MessageBox.Show(" Please enter a valid NUMBER in the 'Number of LEDs' Box")
            Exit Sub
        End If
        AddForm.ShowDialog()
    End Sub
    ' This is the cell double click sub. it is executed and loads the "Modify Routine" form 
    Private Sub modform(m)
        'make sure the cell is populated
        SS = LEDnumber.Text ' put the number of LED's entered by user into memory (again) 
        If C(m) = "" Then
            Exit Sub
        End If

        Dim ctrl As Control ' put the control name into ctrl


        For Each ctrl In Me.TableLayoutPanel1.Controls ' Search all controls on the form and see which ones are "Cells"
            ' Debug.Print("I found " + ctrl.Name)
            If ctrl.Name = ("cell_" & m) Then 'If the control name contains "cell_m" m is a number indicating which cell then...
                heldcell = ("cell_" & m) ' put the cell name in heldcell
                cellnumber = m
                ModifyForm.Show() ' write the information that was stored about the cell into the modify cell form.
                ModifyForm.Routine_1.SelectedIndex = RoutineIndex(m)
                ModifyForm.FR_1.Text = CFR(m)
                ModifyForm.FG_1.Text = CFG(m)
                ModifyForm.FB_1.Text = CFB(m)
                ModifyForm.BR_1.Text = CBR(m)
                ModifyForm.BG_1.Text = CBG(m)
                ModifyForm.BB_1.Text = CBB(m)
                ModifyForm.cycles_1.Text = Ccycles(m)
                ModifyForm.SO_1.Text = CSO(m)
                dblclicked = "yes"
                Exit Sub
            End If
        Next
    End Sub

    ' Write the configuration information for the routines with the "Save config" menu button
    Private Sub SaveConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveConfigToolStripMenuItem.Click
        Dim i As Integer
        Dim cfg_file As String = "C:\ledwiz\ledwiz.cfg"
        Dim savecfg As New System.IO.StreamWriter(cfg_file, False) ' Open the config file for write
        savecfg.WriteLine(LEDchoice.Text)
        savecfg.WriteLine(LEDnumber.Text)
        'savecfg.WriteLine(cellnumber.ToString())
        savecfg.WriteLine(SS)
        savecfg.WriteLine(dblclicked)
        savecfg.WriteLine(heldcell)
        For i = 1 To 33
            savecfg.WriteLine(RoutineIndex(i))
            savecfg.WriteLine(C(i))
            savecfg.WriteLine(CSO(i))
            savecfg.WriteLine(CFR(i))
            savecfg.WriteLine(CFG(i))
            savecfg.WriteLine(CFB(i))
            savecfg.WriteLine(CBR(i))
            savecfg.WriteLine(CBG(i))
            savecfg.WriteLine(CBB(i))
            savecfg.WriteLine(Ccycles(i))
            savecfg.WriteLine(Ctime(i))
            'Debug.Print("wrote")
        Next
        savecfg.Close()
    End Sub
    ' Read the configuration file 
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim i As Integer
        Dim cfg_file As String = "C:\ledwiz\ledwiz.cfg"
        Dim readcfg As New System.IO.StreamReader(cfg_file, False) ' Open the config file for read

        LEDchoice.Text = readcfg.ReadLine() 'LEDchoice.Text = LEDchoice.Text & readcfg.ReadLine() & vbNewLine
        LEDnumber.Text = readcfg.ReadLine()
        ' cellnumber = readcfg.ReadLine()
        SS = readcfg.ReadLine()
        dblclicked = readcfg.ReadLine()
        heldcell = readcfg.ReadLine()
        For i = 1 To 33
            RoutineIndex(i) = readcfg.ReadLine()
            C(i) = readcfg.ReadLine()
            CSO(i) = readcfg.ReadLine()
            CFR(i) = readcfg.ReadLine()
            CFG(i) = readcfg.ReadLine()
            CFB(i) = readcfg.ReadLine()
            CBR(i) = readcfg.ReadLine()
            CBG(i) = readcfg.ReadLine()
            CBB(i) = readcfg.ReadLine()
            Ccycles(i) = readcfg.ReadLine()
            Ctime(i) = readcfg.ReadLine()
        Next

        readcfg.Close()

        clearcells()

        rewritecells()


    End Sub
    ' Save pde AS
    Private Sub SavePdeFFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavePdeFFileToolStripMenuItem.Click
        Dim OpenLoopReader As String
        Dim headerReader As String
        Dim setupReader As String
        Dim loopReader As String = ""
        Dim subroutineReader As String
        Dim closeloop As String = "}"
        ' Dim SS As String = LEDnumber.Text
        Dim WS2801stringsize As String = "Adafruit_WS2801 strip = Adafruit_WS2801(" + SS + ");"
        Dim LPD8806stringsize As String = "LPD8806 strip = LPD8806(" + SS + ");"
        Dim numled As String = "int numled = " + SS + ";"

        DialogResult = SaveFileDialog1.ShowDialog

        If DialogResult = Windows.Forms.DialogResult.OK Then
            Dim objectwriter As New System.IO.StreamWriter(SaveFileDialog1.FileName, False)

            OpenLoopReader = My.Computer.FileSystem.ReadAllText("C:\ledwiz\data\OpenLoop.txt")
            setupReader = My.Computer.FileSystem.ReadAllText("C:\ledwiz\data\LEDsetup.txt")


            ' Choose which header based on what led strip is selected
            Dim ledstyle As Integer
            ledstyle = LEDchoice.SelectedIndex

            Select Case ledstyle
                Case 0
                    headerReader = My.Computer.FileSystem.ReadAllText("C:\ledwiz\data\WS2801headers.txt")
                    objectwriter.WriteLine(headerReader) ' write header
                    objectwriter.WriteLine(WS2801stringsize) ' Write LED length size in LED def
                    objectwriter.WriteLine(numled) ' Write LED length size for calculations
                    ' MessageBox.Show("WS2801")

                Case 1
                    headerReader = My.Computer.FileSystem.ReadAllText("C:\ledwiz\data\LPD8806headers.txt")
                    objectwriter.WriteLine(headerReader)
                    objectwriter.WriteLine(LPD8806stringsize)
                    objectwriter.WriteLine(numled)
                    'MessageBox.Show("LPD8806")
            End Select


            ' write the subroutines for all of the routines
            subroutineReader = My.Computer.FileSystem.ReadAllText("C:\ledwiz\data\subroutines.txt")
            objectwriter.WriteLine(subroutineReader)

            ' Write the setup (this is the same for all LED strings)
            objectwriter.WriteLine(setupReader)

            ' write the Void loop() { to the pde file 
            objectwriter.WriteLine(OpenLoopReader)

            ' Check to see if user has entered at least one routine
            loopReader = C(1) ' if a routine is loaded for write then "C1" will ALWAYS have something in it
            If loopReader = "" Then
                MessageBox.Show(" You must add at least one 'Routine'")
                objectwriter.Close()
                Exit Sub
            End If

            ' this writes all of the routines to the pde file
            For p As Integer = 1 To 32
                loopReader = C(p)
                objectwriter.WriteLine(loopReader)
            Next



            ' write the Close loop } to the pde file
            objectwriter.WriteLine(closeloop)


            objectwriter.Close() ' Close the pde file
        ElseIf DialogResult = Windows.Forms.DialogResult.Cancel Then
        End If
    End Sub

    ' Config "Save As"
    Private Sub SaveConfigAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveConfigAsToolStripMenuItem.Click
        DialogResult = SaveFileDialog2.ShowDialog

        If DialogResult = Windows.Forms.DialogResult.OK Then
            Dim objectwriter As New System.IO.StreamWriter(SaveFileDialog2.FileName, False)
            Dim i As Integer
            objectwriter.WriteLine(LEDchoice.Text)
            objectwriter.WriteLine(LEDnumber.Text)
            'objectwriter.WriteLine(cellnumber.ToString())
            objectwriter.WriteLine(SS)
            objectwriter.WriteLine(dblclicked)
            objectwriter.WriteLine(heldcell)
            For i = 1 To 33
                objectwriter.WriteLine(RoutineIndex(i))
                objectwriter.WriteLine(C(i))
                objectwriter.WriteLine(CSO(i))
                objectwriter.WriteLine(CFR(i))
                objectwriter.WriteLine(CFG(i))
                objectwriter.WriteLine(CFB(i))
                objectwriter.WriteLine(CBR(i))
                objectwriter.WriteLine(CBG(i))
                objectwriter.WriteLine(CBB(i))
                objectwriter.WriteLine(Ccycles(i))
                objectwriter.WriteLine(Ctime(i))
                'Debug.Print("wrote")
            Next
            objectwriter.Close()
        ElseIf DialogResult = Windows.Forms.DialogResult.Cancel Then
        End If

    End Sub

    Private Sub OpenConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenConfigToolStripMenuItem.Click
        DialogResult = OpenFileDialog1.ShowDialog
    End Sub
    ' open a cfg file
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        Dim i As Integer

        Dim readcfg As New System.IO.StreamReader(OpenFileDialog1.OpenFile(), False) ' Open the config file for read

        LEDchoice.Text = readcfg.ReadLine() 'LEDchoice.Text = LEDchoice.Text & readcfg.ReadLine() & vbNewLine
        LEDnumber.Text = readcfg.ReadLine()
        ' cellnumber = readcfg.ReadLine()
        SS = readcfg.ReadLine()
        dblclicked = readcfg.ReadLine()
        heldcell = readcfg.ReadLine()
        For i = 1 To 33
            RoutineIndex(i) = readcfg.ReadLine()
            C(i) = readcfg.ReadLine()
            CSO(i) = readcfg.ReadLine()
            CFR(i) = readcfg.ReadLine()
            CFG(i) = readcfg.ReadLine()
            CFB(i) = readcfg.ReadLine()
            CBR(i) = readcfg.ReadLine()
            CBG(i) = readcfg.ReadLine()
            CBB(i) = readcfg.ReadLine()
            Ccycles(i) = readcfg.ReadLine()
            Ctime(i) = readcfg.ReadLine()
        Next

        readcfg.Close()
        clearcells()
        rewritecells()

    End Sub
    ' re-writes the cells after configuration file is loaded into the program
    Private Sub rewritecells()
        Dim ctrl As Control
        Dim z As Integer = 0
        For z = 1 To 100

            '  find the used cells and re-populate them
            For Each ctrl In TableLayoutPanel1.Controls

                If ctrl.Name = "cell_" & z And C(z) <> "" Then
                    Dim loopitem1 As Integer
                    loopitem1 = RoutineIndex(z)
                    Select Case loopitem1

                        Case 0                              'chase l to r

                            ctrl.Text = "Chase Right"
                            ctrl.BackColor = Color.LightPink

                        Case 1                              'chase r to l

                            ctrl.Text = "Chase Left"
                            ctrl.BackColor = Color.Cyan


                        Case 2                              'chase center

                            ctrl.Text = "Chase Center"
                            ctrl.BackColor = Color.YellowGreen

                        Case 3                              'all off

                            ctrl.Text = "All Off"
                            ctrl.BackColor = Color.Gray


                        Case 4                              'all on

                            ctrl.Text = "All On"
                            ctrl.BackColor = Color.Yellow

                        Case 5                              'sparkle fast

                            ctrl.Text = "Sparkle Fast"
                            ctrl.BackColor = Color.Goldenrod


                        Case 6                              'sparkle slow

                            ctrl.Text = "Sparkle Slow"
                            ctrl.BackColor = Color.Honeydew

                        Case 7                              ' Red wave

                            ctrl.Text = "Red Wave"
                            ctrl.BackColor = Color.Red

                        Case 8                              ' Blue wave

                            ctrl.Text = "Blue Wave"
                            ctrl.BackColor = Color.LightBlue


                        Case 9                              ' Green wave

                            ctrl.Text = "Green Wave"
                            ctrl.BackColor = Color.LightGreen


                        Case 10                             ' Fade Up

                            ctrl.Text = "Fade Up"
                            ctrl.BackColor = Color.PeachPuff

                        Case 11                             ' Fade Down

                            ctrl.Text = "Fade Down"
                            ctrl.BackColor = Color.PapayaWhip

                        Case 12                             ' Rainbow

                            ctrl.Text = "Rainbow"
                            ctrl.BackColor = Color.Thistle

                        Case 13                             ' Dither

                            ctrl.Text = "Dither"
                            ctrl.BackColor = Color.SaddleBrown

                        Case 14                             ' Kit Scanner

                            ctrl.Text = "Kit Scanner"
                            ctrl.BackColor = Color.Tomato

                        Case 15                             ' 5 Color Shift

                            ctrl.Text = "5 Color Shift"
                            ctrl.BackColor = Color.LightYellow

                        Case 16                             ' Random Color Sequence

                            ctrl.Text = "Random Color Seq"
                            ctrl.BackColor = Color.Lime

                        Case 17                             ' Fill from both ends

                            ctrl.Text = "Fill From Both Ends"
                            ctrl.BackColor = Color.MediumOrchid
  
                        Case 18                              ' Random Color Twinkle

                            ctrl.Text = "Rand Color Twinkle"
                            ctrl.BackColor = Color.MintCream

                        Case 19                              ' Up String color Sparkle

                            ctrl.Text = "Up String Sparkle"
                            ctrl.BackColor = Color.Orange

                        Case 20                              ' Up String color Follow

                            ctrl.Text = "Down String Follow"
                            ctrl.BackColor = Color.SpringGreen

                        Case 21                             ' Drip

                            ctrl.Text = "Drip"
                            ctrl.BackColor = Color.HotPink

                        Case 22                             ' SingleColor White Strobe

                            ctrl.Text = "Single Color White Strobe"
                            ctrl.BackColor = Color.DarkOrchid

                        Case 23                             ' Marque

                            ctrl.Text = "Marque"
                            ctrl.BackColor = Color.DeepSkyBlue
                        Case 24                             ' Marque

                            ctrl.Text = "Rainbow Marque"
                            ctrl.BackColor = Color.Lavender
                        Case 25                             'Multi Strobe

                            ctrl.Text = "Multi storbe"
                            ctrl.BackColor = Color.CadetBlue
                        Case 26                             'Single Strobe

                            ctrl.Text = "Single storbe"
                            ctrl.BackColor = Color.DeepPink


                    End Select
                End If
            Next
        Next
    End Sub

    ' Clears all of the cells before new file is loaded into the program
    Private Sub clearcells()
        Dim ctrl As Control
        Dim z As Integer = 0
        For z = 1 To 100

            '  cells and clear the text and set the background to blank
            For Each ctrl In TableLayoutPanel1.Controls

                If ctrl.Name = "cell_" & z Then

                    ctrl.Text = ""
                    ctrl.BackColor = Color.Transparent
                End If
            Next
        Next
    End Sub
    ' Launch the about box
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ledwizAbout.Show()
    End Sub
    ' Clear the memory and the form
    Private Sub ClearFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFormToolStripMenuItem.Click
        clearcells()
        Dim i As Integer
        For i = 1 To 100
            RoutineIndex(i) = ""
            C(i) = ""
            CSO(i) = ""
            CFR(i) = ""
            CFG(i) = ""
            CFB(i) = ""
            CBR(i) = ""
            CBG(i) = ""
            CBB(i) = ""
            Ccycles(i) = ""
            Ctime(i) = ""
        Next
    End Sub
    ' Display "Help"
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        System.Windows.Forms.Help.ShowHelp(Me, HelpProvider1.HelpNamespace)
    End Sub
    ' Choose the com port that is connected to Arduino
    Private Sub ComPortSel_MouseDown(sender As Object, e As MouseEventArgs) Handles ComPortSel.MouseDown
        ComPortSel.Items.Clear() ' Clear the cop port selection box
        ' Show all available COM ports. 
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComPortSel.Items.Add(sp)
        Next
    End Sub

    Private Sub Create_Batch()
        Dim CP As String = ComPortSel.Text
        Dim BatfileHeader1 As String = "copy c:\ledwiz\prgfile.pde c:\ledwiz\prgfile\prgfile.ino /y"
        Dim BatfileHeader2 As String = "cd c:\ledwiz\arduino"
        Dim BatfileTeensy As String = "arduino --upload c:\ledwiz\prgfile\prgfile.ino --board teensy:avr:teensy2 --port " + CP
        Dim BatfileTrinket As String = "arduino --upload c:\ledwiz\prgfile\prgfile.ino --board adafruit:avr:trinket5 --port " + CP
        Dim BFile_NAME As String = "C:\ledwiz\prgbuild.bat"        ' We need the CPU type before we can create a routine
        Dim cputype As Integer
        cputype = CPUchoice.SelectedIndex
        Dim objWriter As New System.IO.StreamWriter(BFile_NAME, False) ' Open the batch file file for write
        Select Case cputype
            Case 0
                objWriter.WriteLine(BatfileHeader1) ' write first line of batch file
                objWriter.WriteLine(BatfileHeader2) ' Write second line of batch file
                objWriter.WriteLine(BatfileTrinket) ' Write CPU type
                ' MessageBox.Show("Trinket")

            Case 1
                objWriter.WriteLine(BatfileHeader1) ' write first line of batch file
                objWriter.WriteLine(BatfileHeader2) ' Write second line of batch file
                objWriter.WriteLine(BatfileTeensy) ' Write CPU type
                ' MessageBox.Show("Teensy")
        End Select
        objWriter.Close() ' Close the batch file
    End Sub


End Class