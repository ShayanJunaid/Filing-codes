Module Module1

    Sub Main()
        Dim menuselector As Integer
        menuselector = 0
        Do
            Console.WriteLine("If you start new record, press 1")
            Console.WriteLine("If you want to add to existing record, press 2")
            Console.WriteLine("If you want to search for a record, press 3")
            Console.WriteLine("if you want to add more details to record, press 4")
            Console.WriteLine("Press 9 if you want to exit program")

            menuselector = Console.ReadLine
            If menuselector = 1 Then
                Call addrecord()
            End If
            If menuselector = 2 Then
                Call addtorecord()
            End If
            If menuselector = 3 Then
                Call searchrecord()
            End If
            If menuselector = 4 Then
                Call moredetails()
            End If
            Console.Clear()
        Loop Until menuselector = 9
    End Sub
    Sub addrecord()
        Dim name, ID, more As String
        more = "n"
        Console.Clear()
        FileOpen(1, "C:\Test\clubtask.txt", OpenMode.Output)
        Do
            Console.WriteLine("Name of member:")
            name = Console.ReadLine
            Console.WriteLine("ID of member:")
            ID = Console.ReadLine
            WriteLine(1, name)
            WriteLine(1, ID)
            Console.WriteLine("do you want to add more? (y/n)")
            more = Console.ReadLine()
        Loop While more <> "n"
        FileClose(1)
        Console.WriteLine("press any button to continue")
        Console.ReadKey()
    End Sub
    Sub addtorecord()
        Dim ID, name, more As String
        more = "n"
        Console.Clear()
        FileOpen(1, "C:\Test\clubtask.txt", OpenMode.Append)
        Do
            Console.WriteLine("Name of member:")
            name = Console.ReadLine()
            Console.WriteLine("ID fo member:")
            ID = Console.ReadLine()
            WriteLine(1, name)
            WriteLine(1, ID)
            Console.WriteLine("do you want to add more(y/n):")
            more = Console.ReadLine
        Loop While more <> "n"
        FileClose(1)
        Console.WriteLine("Press any key to contineu:")
        Console.ReadKey()
    End Sub
    Sub searchrecord()
        Console.Clear()
        FileOpen(1, "C:\Test\clubtask.txt", OpenMode.Input)
        Dim name, ID, searchname, foundid As String
        Dim found As Boolean
        foundid = ""
        Console.WriteLine("Enter name to search:")
        searchname = Console.ReadLine()
        While Not EOF(1)
            Input(1, name)
            Input(1, ID)
            If name = searchname Then
                foundid = ID & foundid
                found = True
            End If
        End While
        FileClose(1)
        If found = True Then
            Console.WriteLine("record was found with ID:" & foundid)
        End If
        Console.WriteLine("press any key to continue")
        Console.ReadKey()
    End Sub
    Sub moredetails()
        Console.Clear()
        Dim name, ID, tele, joindate As String
        name = ""
        ID = ""
        tele = ""
        joindate = ""
        FileOpen(1, "C:\Test\clubtask.txt", OpenMode.Input)
        FileOpen(2, "C:\Test\updatedclubtask.txt", OpenMode.Output)
        Do While Not EOF(1)
            Input(1, name)
            Input(1, ID)
            Console.WriteLine("please enter telephone number for :" & name & " ID:" & ID)
            tele = Console.ReadLine
            Console.WriteLine("please enter joining date for :" & name & " ID:" & ID & "in format dd/mm/yy")
            joindate = Console.ReadLine
            WriteLine(2, name)
            WriteLine(2, ID)
            WriteLine(2, tele)
            WriteLine(2, joindate)
        Loop
        FileClose(1)
        FileClose(2)
        Console.WriteLine("press any key to continue")
        Console.ReadKey()
    End Sub


End Module