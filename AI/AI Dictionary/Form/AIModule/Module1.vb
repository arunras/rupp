Module Module1

    Sub Main()

        Dim htbl As System.Collections.Hashtable
        htbl = GetHashTable()

        Dim ds As DataSet = New DataSet()
        ds = htbl("CustomerDetails")

        ' Display the dataset values on the console
        Console.WriteLine(vbCrLf & "Customer Details" & vbCrLf)

        Dim row As DataRow
        For Each row In ds.Tables(0).Rows
            Dim item As Object
            For Each item In row.ItemArray
                Console.WriteLine(item.ToString())
            Next
        Next

        Console.ReadLine()

    End Sub

    Public Function GetHashTable() As System.Collections.Hashtable

        Dim htbl As System.Collections.Hashtable
        htbl = New System.Collections.Hashtable()

        Dim ds As DataSet = New DataSet()
        ds.ReadXml("SomeFile.xml")

        htbl.Add("CustomerDetails", ds)

        Return htbl
    End Function
End Module
