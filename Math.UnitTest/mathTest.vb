Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Math

<TestClass()> Public Class mathTest

    <TestMethod()> Public Sub addTest()
        Dim sum As Integer = Math.add(5, 6)
        Assert.AreEqual(11, sum)
    End Sub

End Class