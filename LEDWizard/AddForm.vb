Public Class AddForm

    ' choose panels to hide or expose
    Private Sub Routine_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Routine_1.SelectedIndexChanged
        Dim loopitem1 As Integer
        loopitem1 = Routine_1.SelectedIndex
        Debug.Print("Found " + ToString(loopitem1))
        Select Case loopitem1
            Case 0                              'chase l to r
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = False
                FR_1.Text = "75" ' put a default forground value in boxen
                FG_1.Text = "75" ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                BR_1.Text = "0"  ' put a default background value in box
                BG_1.Text = "0"  ' put a default background value in box
                BB_1.Text = "75" ' put a default background value in box
                TextHold.Text = "This routine sequentialy moves a 'forground' color of your choice through the last background from the left to right"
            Case 1                              'chase r to l
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = False
                FR_1.Text = "75" ' put a default forground value in box
                FG_1.Text = "75" ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                TextHold.Text = "This routine sequentialy moves a 'forground' color of your choice through the last background from from right to left"
            Case 2                              'chase center
                Rout_1_BG_PNL.Visible = True
                Rout_1_FG_PNL.Visible = True
                cycle_pnl_1.Visible = True
                SO_1_PNL.Visible = False
                FR_1.Text = "75" ' put a default forground value in box
                FG_1.Text = "75" ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                BR_1.Text = "0"  ' put a default background value in box
                BG_1.Text = "0"  ' put a default background value in box
                BB_1.Text = "75" ' put a default background value in box
                cycles_1.Text = "3" ' Default Cycles
                TextHold.Text = "This routine sequentialy moves a 'forground' color of your choice through a 'background' color of your choice from the center to both sides"
            Case 3                              'all off
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = True
                cycle_pnl_1.Visible = False
                SO_1.Text = "0" ' Default 0 Second
                TextHold.Text = "This routine turns all leds off. 'Time' is how long to stay off. 1000 = 1 second"
            Case 4                              'all on
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                cycle_pnl_1.Visible = False
                SO_1_PNL.Visible = True
                FR_1.Text = "75" ' put a default forground value in box
                FG_1.Text = "75" ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                SO_1.Text = "3000" ' Default 3 Second
                TextHold.Text = "This routine turns all LED on to the color of your choice 'Time' is how long to leave on. 1000 equals about 1 second"
            Case 5                              'sparkle fast
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = False
                TextHold.Text = "This routine blinks a random pattern of colors (quickly)"
            Case 6                              'sparkle slow
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = False
                TextHold.Text = "This routine blinks a random pattern of colors (slowly)"
            Case 7                              ' Red wave
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = True
                cycles_1.Text = "3" ' Default Cycles
                TextHold.Text = "This routine creates a wave of white through a strip color of red"
            Case 8                              ' Blue wave
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = True
                cycles_1.Text = "3" ' Default Cycles
                TextHold.Text = "This routine creates a wave of white through a strip color of blue"
            Case 9                              ' Green wave
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = True
                cycles_1.Text = "3" ' Default Cycles
                TextHold.Text = "This routine creates a wave of white through a strip color of green"
            Case 10                              ' Fade Up
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = True
                cycle_pnl_1.Visible = False
                FR_1.Text = "75" ' put a default forground value in box
                FG_1.Text = "75" ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                SO_1.Text = "1000" ' Default 1 Second
                TextHold.Text = "This routine fades your chosen color up to highest brightness.'Time' is how long to stay on. 1000 equals 1 second."
            Case 11                              ' Fade Down
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = True
                cycle_pnl_1.Visible = False
                FR_1.Text = "75" ' put a default forground value in box
                FG_1.Text = "75" ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                SO_1.Text = "1000" ' Default 1 Second
                TextHold.Text = "This routine fades your chosen color down to lowest brightness.'Time' is how long to stay off. 1000 equals 1 second."
            Case 12                              ' Rainbow
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = False
                TextHold.Text = "This routine lights the string in a changing 'Rainbow' pattern"
            Case 13                              ' Dither
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = False
                FR_1.Text = "75" ' put a default forground value in box
                FG_1.Text = "75" ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                TextHold.Text = "This routine lights the string with the color of your choice one LED at a time at random locations"
            Case 14                              ' Kit Scan
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = False
                TextHold.Text = "This routine moves 5 red leds from left to right then from right to left 5 times"
            Case 15                              ' 5 Color Shift
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = True
                cycles_1.Text = "1" ' Default for Cycles
                TextHold.Text = "Lights the string with white, yellow, green, blue then shifts all to the left. Each 'Cycle' equals about 10 sec on a 25 LED string, Longer strings are longer"
            Case 16                              ' Random Color Sequence
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = True
                cycles_1.Text = 3  'Defalut Cycles
                TextHold.Text = "This routine fills the string randomly from random sides to random locations in the string with random colors "
            Case 17                              ' Fill from both ends
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = True
                cycle_pnl_1.Visible = True
                SO_1.Text = 60
                cycles_1.Text = "3" ' Default Cycles
                FR_1.Text = "75" ' put a default forground value in box
                FG_1.Text = "75" ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                TextHold.Text = "This routine fills the string with the same color one LED at a time.... First from the left then from the right 'Time' is how fast the fill happens (60 is a good number)"
            Case 18                              ' Random Color Twinkle
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = True
                cycles_1.Text = 200
                TextHold.Text = "This routine randomly changes the color of each seperate LED. The 'Cycle' component is how long this happens. 200 equals about 5 seconds "
            Case 19                              ' Up String Color Follow
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = False
                FR_1.Text = "75" ' put a default forground value in box
                FG_1.Text = "0"  ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                TextHold.Text = "This routine filles the string with a single color from left to right. "
            Case 20                              ' Down String Color Follow
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = False
                FR_1.Text = "75" ' put a default forground value in box
                FG_1.Text = "0"  ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                TextHold.Text = "This routine filles the string with a single color from right to left. "
            Case 21                              ' Drip
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = True
                FR_1.Text = "75" ' put a default forground value in box
                FG_1.Text = "0"  ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                cycles_1.Text = "3" ' Default Cycles
                TextHold.Text = "This routine moves 3 leds from left to right fading the leds at the end"
            Case 22                              ' Single Color White strobe
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = True
                FR_1.Text = "100" ' put a default forground value in box
                FG_1.Text = "40"  ' put a default forground value in box
                FB_1.Text = "0" ' put a default forground value in box
                cycles_1.Text = "3" ' Default Cycles
                TextHold.Text = "This routine Sets a single Background color then randomly blinks white"
            Case 23                              ' Theater marque
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = True
                FR_1.Text = "75" ' put a default forground value in box
                FG_1.Text = "75"  ' put a default forground value in box
                FB_1.Text = "75" ' put a default forground value in box
                cycles_1.Text = "50" ' Default Cycles
                TextHold.Text = "This routine uses a single color and moves spaces (like a theatre)"
            Case 24                              ' Theater rainbow marque
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = True
                cycles_1.Text = "50" ' Default Cycles
                TextHold.Text = "This routine uses a rainbow of colors and moves spaces (like a theatre)"
            Case 25                              ' Multi color white strobe
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = False
                SO_1_PNL.Visible = False
                cycle_pnl_1.Visible = True
                cycles_1.Text = "500" ' Default Cycles
                TextHold.Text = "This routine displays multi colors with white strobe"
            Case 26                              ' Single color white strobe
                Rout_1_BG_PNL.Visible = False
                Rout_1_FG_PNL.Visible = True
                SO_1_PNL.Visible = True
                cycle_pnl_1.Visible = True
                FR_1.Text = "50" ' put a default forground value in box
                FG_1.Text = "50" ' put a default forground value in box
                FB_1.Text = "0" ' put a default forground value in box
                cycles_1.Text = "500" ' Default Cycles
                SO_1.Text = "50"
                TextHold.Text = "This routine displays a single color with white strobe 500 cycles is good time should be 20 to 200 fast to slow"

        End Select
    End Sub
    ' write the color and text into the cell label, Save the cell info into memory
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim ctrl As Control
        Dim i As Integer = 0
        For i = 1 To 100

            MainForm.SS = MainForm.LEDnumber.Text

            '  Check for an open cell and write it and save the data
            For Each ctrl In MainForm.TableLayoutPanel1.Controls

                If ctrl.Name = "cell_" & i And ctrl.Text = "" Then
                    Dim loopitem1 As Integer
                    loopitem1 = Routine_1.SelectedIndex
                    Select Case loopitem1
                        Case 0                              'chase l to r

                            MainForm.C(i) = "chaseBetweenLToH(Color(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "),50,0," + MainForm.SS + "); //color, delay, low, high - chase led between two locations progressing up the chain"
                            ctrl.Text = "Chase Right"
                            ctrl.BackColor = Color.LightPink
                            MainForm.RoutineIndex(i) = 0
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            ' Debug.Print(Form1.C(i))

                        Case 1                              'chase r to l
                            MainForm.C(i) = "chaseBetweenHToL(Color(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "),50,0," + MainForm.SS + "); //color, delay, low, high - chase led between two locations progressing down the chain"
                            ctrl.Text = "Chase Left"
                            ctrl.BackColor = Color.Cyan
                            MainForm.RoutineIndex(i) = 1
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            ' Debug.Print(Form1.C(i))

                        Case 2                              'chase center
                            MainForm.C(i) = "centercolorChase(Color(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "),Color(" + BR_1.Text + "," + BG_1.Text + "," + BB_1.Text + "), 50," + cycles_1.Text + "); // Blue on Dim Blueishwhite (Foreground,Background, delay, number of cycles)"
                            ctrl.Text = "Chase Center"
                            ctrl.BackColor = Color.YellowGreen
                            MainForm.RoutineIndex(i) = 2
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            MainForm.CBR(i) = BR_1.Text
                            MainForm.CBG(i) = BG_1.Text
                            MainForm.CBB(i) = BB_1.Text
                            MainForm.Ccycles(i) = cycles_1.Text
                            'Debug.Print(Form1.C(i))

                        Case 3                              'all off
                            MainForm.C(i) = "turnAllOff(" + SO_1.Text + ");"
                            ctrl.Text = "All Off"
                            ctrl.BackColor = Color.Gray
                            MainForm.RoutineIndex(i) = 3
                            MainForm.CSO(i) = SO_1.Text
                            'Debug.Print(Form1.C(i))

                        Case 4                              'all on
                            MainForm.C(i) = "colorWipe(Color(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "),0," + SO_1.Text + "); // turn on all leds"
                            ctrl.Text = "All On"
                            ctrl.BackColor = Color.Yellow
                            MainForm.RoutineIndex(i) = 4
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            MainForm.CSO(i) = SO_1.Text
                            'Debug.Print(Form1.C(i))

                        Case 5                              'sparkle fast
                            MainForm.C(i) = MainForm.quickcolorsparkle
                            ctrl.Text = "Sparkle Fast"
                            ctrl.BackColor = Color.Goldenrod
                            MainForm.RoutineIndex(i) = 5
                            ' Debug.Print(Form1.C(i))

                        Case 6                              'sparkle slow
                            MainForm.C(i) = MainForm.slowcolorsparkle
                            ctrl.Text = "Sparkle Slow"
                            ctrl.BackColor = Color.Honeydew
                            MainForm.RoutineIndex(i) = 6
                            ' Debug.Print(Form1.C(i))

                        Case 7                              ' Red wave
                            MainForm.C(i) = "waveK(Color(0,75,0)," + cycles_1.Text + ", 40);       //Red with a white wave sends color, cycles, delay "
                            ctrl.Text = "Red Wave"
                            ctrl.BackColor = Color.Red
                            MainForm.RoutineIndex(i) = 7
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))

                        Case 8                              ' Blue wave
                            MainForm.C(i) = "waveK(Color(0,0,75)," + cycles_1.Text + ", 40);       //Blue with a white wave sends color, cycles, delay "
                            ctrl.Text = "Blue Wave"
                            ctrl.BackColor = Color.LightBlue
                            MainForm.RoutineIndex(i) = 8
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))

                        Case 9                              ' Green wave
                            MainForm.C(i) = "waveK(Color(75,0,0), " + cycles_1.Text + ", 40);       //Green with a white wave sends color, cycles, delay "
                            ctrl.Text = "Green Wave"
                            ctrl.BackColor = Color.LightGreen
                            MainForm.RoutineIndex(i) = 9
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))

                        Case 10                             ' Fade Up
                            MainForm.C(i) = "fadeUp(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "," + SO_1.Text + "); //red, green, blue, delay - fade up all pixels one color "
                            ctrl.Text = "Fade Up"
                            ctrl.BackColor = Color.PeachPuff
                            MainForm.RoutineIndex(i) = 10
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            MainForm.CSO(i) = SO_1.Text 'time
                            ' Debug.Print(Form1.C(i))

                        Case 11                             ' Fade Down
                            MainForm.C(i) = "fadeDown(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "," + SO_1.Text + "); //red, green, blue, delay - fade up all pixels one color "
                            ctrl.Text = "Fade Down"
                            ctrl.BackColor = Color.PapayaWhip
                            MainForm.RoutineIndex(i) = 11
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            MainForm.CSO(i) = SO_1.Text 'time
                            ' Debug.Print(Form1.C(i))
                        Case 12                             ' Rainbow
                            MainForm.C(i) = "rainbowCycle(20);"
                            ctrl.Text = "Rainbow"
                            ctrl.BackColor = Color.Thistle
                            MainForm.RoutineIndex(i) = 12
                            ' Debug.Print(Form1.C(i))
                        Case 13                             ' Dither
                            MainForm.C(i) = "dither(Color(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "),50); //color, delay - random fills up the strip"
                            ctrl.Text = "Dither"
                            ctrl.BackColor = Color.SaddleBrown
                            MainForm.RoutineIndex(i) = 13
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            ' Debug.Print(Form1.C(i))
                        Case 14                             ' Kit Scanner
                            MainForm.C(i) = "scanner(75,0,0,30);"
                            ctrl.Text = "Kit Scanner"
                            ctrl.BackColor = Color.Tomato
                            MainForm.RoutineIndex(i) = 14
                            ' Debug.Print(Form1.C(i))
                        Case 15                             ' 5 Color Shift
                            MainForm.C(i) = "shiftwybgr(300," + cycles_1.Text + ");"
                            ctrl.Text = "5 Color Shift"
                            ctrl.BackColor = Color.LightYellow
                            MainForm.RoutineIndex(i) = 15
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                        Case 16                             ' Random Color Sequence
                            MainForm.C(i) = "ran1(20," + cycles_1.Text + ");"
                            ctrl.Text = "Random Color Seq"
                            ctrl.BackColor = Color.Lime
                            MainForm.RoutineIndex(i) = 16
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                        Case 17                             ' Fill from both ends
                            MainForm.C(i) = "fillFromBoth(Color(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + ")," + SO_1.Text + "," + cycles_1.Text + ");"
                            ctrl.Text = "Fill From Both Ends"
                            ctrl.BackColor = Color.MediumOrchid
                            MainForm.RoutineIndex(i) = 17
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            MainForm.CSO(i) = SO_1.Text 'time
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                        Case 18                              ' Random Color Twinkle
                            MainForm.C(i) = "ran(30," + cycles_1.Text + ");       //Randomly turn on leds with changing colors. the number is equal to the speed "
                            ctrl.Text = "Rand Color Twinkle"
                            ctrl.BackColor = Color.MintCream
                            MainForm.RoutineIndex(i) = 18
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                        Case 19                              ' Up String color Follow
                            MainForm.C(i) = "randomSparkleUpSegment(Color(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "), 500, 75, 0," + MainForm.SS + "); // single color blink march from right to left"
                            ctrl.Text = "Up String Follow"
                            ctrl.BackColor = Color.Orange
                            MainForm.RoutineIndex(i) = 19
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                        Case 20                              ' Up String color Follow
                            MainForm.C(i) = "randomSparkleDwnSegment(Color(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "), 500, 75, 0," + MainForm.SS + "); // single color blink march from right to left"
                            ctrl.Text = "Down String Follow"
                            ctrl.BackColor = Color.SpringGreen
                            MainForm.RoutineIndex(i) = 20
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                        Case 21                             ' Drip
                            MainForm.C(i) = "drip(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "," + cycles_1.Text + ",30); //color, cycles, delay - 3 LED's move top to bottom to look like a drip"
                            ctrl.Text = "Drip"
                            ctrl.BackColor = Color.HotPink
                            MainForm.RoutineIndex(i) = 21
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                        Case 22                             ' Single Color White Strobe
                            MainForm.C(i) = "singleColorWhiteSparkle(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "," + cycles_1.Text + "); //A single color background with a randomly moving white strobe light"
                            ctrl.Text = "1 Color strb White"
                            ctrl.BackColor = Color.DarkOrchid
                            MainForm.RoutineIndex(i) = 22
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                        Case 23                             ' Theatre Marque
                            MainForm.C(i) = "theaterChase(strip.Color(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + ")," + cycles_1.Text + "); //A single color With moving space (Like a theatre marque)"
                            ctrl.Text = "Marque"
                            ctrl.BackColor = Color.DeepSkyBlue
                            MainForm.RoutineIndex(i) = 23
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                        Case 24                              ' Rainbow Marque
                            MainForm.C(i) = "theaterChaseRainbow(" + cycles_1.Text + ");       //Rainbow Marque (colors with a moving space) "
                            ctrl.Text = "Rainbow Marque"
                            ctrl.BackColor = Color.Lavender
                            MainForm.RoutineIndex(i) = 24
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                        Case 25                              ' Rainbow Marque
                            MainForm.C(i) = "multistrb(" + cycles_1.Text + ");       //multiple colors with white strobe "
                            ctrl.Text = "Mutli Strobe"
                            ctrl.BackColor = Color.CadetBlue
                            MainForm.RoutineIndex(i) = 25
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                    Case 26                              ' Single color with white strobe
                            MainForm.C(i) = "singlestrb(" + FR_1.Text + "," + FG_1.Text + "," + FB_1.Text + "," + cycles_1.Text + "," + SO_1.Text + ");       //single colors with white strobe "
                            ctrl.Text = "Single Strobe"
                            ctrl.BackColor = Color.DeepPink
                            MainForm.RoutineIndex(i) = 26
                            MainForm.CFR(i) = FR_1.Text
                            MainForm.CFG(i) = FG_1.Text
                            MainForm.CFB(i) = FB_1.Text
                            MainForm.CSO(i) = SO_1.Text
                            MainForm.Ccycles(i) = cycles_1.Text
                            ' Debug.Print(Form1.C(i))
                    End Select
                    Exit Sub
                End If
            Next
        Next
    End Sub
    ' pressing the done button closes this form
    Private Sub Done_Click(sender As Object, e As EventArgs) Handles Done.Click
        Close()
    End Sub

    Private Sub ctest_Click(sender As Object, e As EventArgs) Handles ctest.Click
        Dim rgb1, rgb2, rgb3 As Integer
        rgb1 = Convert.ToInt32(FR_1.Text)
        If rgb1 > 0 Then rgb1 = rgb1 / 75 * 255 ' get the percentage of the setting (0-75) then convert to 0-255
        If rgb1 > 255 Then rgb1 = 255
        rgb2 = Convert.ToInt32(FG_1.Text)
        If rgb2 > 0 Then rgb2 = rgb2 / 75 * 255
        If rgb2 > 255 Then rgb2 = 255
        rgb3 = Convert.ToInt32(FB_1.Text)
        If rgb3 > 0 Then rgb3 = rgb3 / 75 * 255
        If rgb3 > 255 Then rgb3 = 255
        Me.Rout_1_FG_PNL.BackColor = Color.FromArgb(rgb1, rgb2, rgb3)
    End Sub
End Class