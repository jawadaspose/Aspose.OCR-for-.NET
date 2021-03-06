Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.OCR
Imports System

Namespace Aspose.OCR.Examples.VisualBasic.PerformingandManagingOCR
    Public Class ReadPartInformation
        Public Shared Sub Run()
            ' ExStart:ReadPartInformation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_OCR()

            'Initialize an instance of OcrEngine
            Dim ocrEngine As New OcrEngine()

            'Set Image property by loading an image from file path
            ocrEngine.Image = ImageStream.FromFile(dataDir & "Sampleocr.bmp")

            'Run recognition process
            If ocrEngine.Process() Then
                Console.WriteLine(ocrEngine.Text)
                ' Retrieve an array of recognized text by parts
                Dim text() As IRecognizedPartInfo = ocrEngine.Text.PartsInfo
                ' Iterate over the text parts
                For Each symbol As IRecognizedTextPartInfo In text
                    ' Display part intomation
                    Console.WriteLine("Text : " & symbol.Text)
                    Console.WriteLine("isItalic : " & symbol.Italic)
                    Console.WriteLine("Language : " & symbol.Language)
                Next symbol
            End If
            ' ExEnd:ReadPartInformation
        End Sub
    End Class
End Namespace