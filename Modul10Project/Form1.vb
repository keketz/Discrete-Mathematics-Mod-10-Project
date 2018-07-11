Public Class Form1
    Structure Course
        Dim classNumber As String
        Dim className As String
        Dim teachersName As String
        Dim quarter As String
        Dim subject As String

        Sub New(ByVal _classNumber As String, ByVal _className As String, ByVal _teachersName As String, ByVal _quarter As String, ByVal _subject As String)
            classNumber = _classNumber
            className = _className
            teachersName = _teachersName
            quarter = _quarter
            subject = _subject
        End Sub
    End Structure

    'defualt inofrmation at start
    Dim courseList() As Course = {
        New Course("CDA1202", "Foundations Of Software Design", "Bee", "Summer2014", "Computer"),
        New Course("COP1125", "Programming Fundamentals", "Cronker", "Summer2014", "Computer"),
        New Course("MAC1200", "Precalculus", "Nebula", "Summer2014", "Math"),
        New Course("PHI2103", "Introduction to Critical Thinking", "Rockadoole", "Summer2014", "Writing"),
        New Course("CDA2110", "Introduction to Computer Systems", "Sumbudy", "Fall2014", "Computer"),
        New Course("CGS1545", "Relational Databases", "Nevel", "Fall2014", "Computer"),
        New Course("COP2323", "Object Oriented Programming", "White", "Fall2014", "Computer"),
        New Course("COT1202", "Discrete Structures for Computer Science", "Guy", "Fall2014", "Computer"),
        New Course("COP1224", "Programming I", "Sumba", "Winter2015", "Computer"),
        New Course("E242", "Career Development", "Doyel", "Winter2015", "Career"),
        New Course("ENC1121", "English Composition II", "Grenger", "Winter2015", "Writing"),
        New Course("MMC3407", "Visual Communication in the Media", "Bloobelle", "Winter2015", "Writing"),
        New Course("COP2224", "Programming II", "Samurai", "Spring2015", "Computer"),
        New Course("COP2250", "Java I", "Coff", "Spring2015", "Computer"),
        New Course("GEO3204", "Physical Geography", "Cronker", "Spring2015", "Natural Science"),
        New Course("MAC2100", "Calculus I", "Jackson", "Spring2015", "Math"),
        New Course("AMH3304", "Visions of America Since 1945", "Swan", "Summer2015", "Writing"),
        New Course("CEN1400", "Mobile Application Development", "Rockadoole", "Summer2015", "Computer"),
        New Course("MAC2200", "Calculus II", "Fray", "Summer2015", "Math"),
        New Course("MAD2112", "Introduction to Discrete Mathematics", "Kimbel", "Summer2015", "Math"),
        New Course("E320", "Web Application Architecture And Design", "Seminei", "Summer2015Term1", "Seminar"),
        New Course("CDA3112", "Junior Seminar", "Bloobelle", "Fall2015", "Computer"),
        New Course("CEN3410", "Software Systems Principles", "Maraco", "Fall2015", "Computer"),
        New Course("LIT3191", "Contemporary World Literature:  1900 to the Present", "Rockadoole", "Fall2015", "Writing"),
        New Course("MAD3113", "Applied Discrete Mathematics", "Lacquer", "Fall2015", "Math")
    }

    'creates a contact list array
    Dim listSize = 24

    'when the form is opened, the list of contacts is defined and displayed unordered. 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prints info line by line-
        For j As Integer = 0 To listSize
            TextBox1.AppendText(courseList(j).classNumber + " | " + courseList(j).className + " | " + courseList(j).teachersName + " | " + courseList(j).quarter + " | " + courseList(j).subject + vbNewLine)
        Next j
    End Sub

    'If button is pressed, sorts by number
    Private Sub btnSortByNumber_Click(sender As Object, e As EventArgs) Handles btnSortByNumber.Click
        TextBox1.Text = ""

        Dim query As IEnumerable(Of Course) = courseList.OrderBy(Function(courseList) courseList.classNumber)
        'pets.OrderBy(Function(pet) pet.Age)

        Dim output As New System.Text.StringBuilder

        For Each cL As Course In query
            TextBox1.AppendText(cL.classNumber + " | " + cL.className + " | " + cL.teachersName + " | " + cL.quarter + " | " + cL.subject + vbNewLine)
        Next
    End Sub

    'if button is pressed, sorts by name
    Private Sub btnSortByName_Click(sender As Object, e As EventArgs) Handles btnSortByName.Click
        TextBox1.Text = ""

        Dim query As IEnumerable(Of Course) = courseList.OrderBy(Function(courseList) courseList.className)
        'pets.OrderBy(Function(pet) pet.Age)

        Dim output As New System.Text.StringBuilder

        For Each cL As Course In query
            TextBox1.AppendText(cL.classNumber + " | " + cL.className + " | " + cL.teachersName + " | " + cL.quarter + " | " + cL.subject + vbNewLine)
        Next
    End Sub

    'if button is pressed, sorts by teachers name
    Private Sub btnSortByTeacher_Click(sender As Object, e As EventArgs) Handles btnSortByTeacher.Click
        TextBox1.Text = ""

        Dim query As IEnumerable(Of Course) = courseList.OrderBy(Function(courseList) courseList.teachersName)
        'pets.OrderBy(Function(pet) pet.Age)

        Dim output As New System.Text.StringBuilder

        For Each cL As Course In query
            TextBox1.AppendText(cL.classNumber + " | " + cL.className + " | " + cL.teachersName + " | " + cL.quarter + " | " + cL.subject + vbNewLine)
        Next
    End Sub

    'if button is pressed, sorts by quarter
    Private Sub btnSortByQuarter_Click(sender As Object, e As EventArgs) Handles btnSortByQuarter.Click
        TextBox1.Text = ""

        Dim query As IEnumerable(Of Course) = courseList.OrderBy(Function(courseList) courseList.quarter)
        'pets.OrderBy(Function(pet) pet.Age)

        Dim output As New System.Text.StringBuilder

        For Each cL As Course In query
            TextBox1.AppendText(cL.classNumber + " | " + cL.className + " | " + cL.teachersName + " | " + cL.quarter + " | " + cL.subject + vbNewLine)
        Next
    End Sub

    'if button is pressed, sorts by subject
    Private Sub btnSortBySubject_Click(sender As Object, e As EventArgs) Handles btnSortBySubject.Click
        TextBox1.Text = ""

        Dim query As IEnumerable(Of Course) = courseList.OrderBy(Function(courseList) courseList.subject)
        'pets.OrderBy(Function(pet) pet.Age)

        Dim output As New System.Text.StringBuilder

        For Each cL As Course In query
            TextBox1.AppendText(cL.classNumber + " | " + cL.className + " | " + cL.teachersName + " | " + cL.quarter + " | " + cL.subject + vbNewLine)
        Next
    End Sub

    'adds a new class to the list
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        listSize += 1

        'Resizes the array! WOO! FINALLY!
        Array.Resize(courseList, courseList.Length + 1)
        courseList(listSize) = New Course(txtNumberInput.Text, txtNameInput.Text, txtTeacherInput.Text, txtQuarterInput.Text, txtSubjectInput.Text)

        'adds the new course to the list
        TextBox1.AppendText(courseList(listSize).classNumber + " | " + courseList(listSize).className + " | " + courseList(listSize).teachersName + " | " + courseList(listSize).quarter + " | " + courseList(listSize).subject + vbNewLine)

        txtNumberInput.Text = ""
        txtNameInput.Text = ""
        txtTeacherInput.Text = ""
        txtQuarterInput.Text = ""
        txtSubjectInput.Text = ""
    End Sub
End Class
