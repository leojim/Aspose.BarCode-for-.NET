﻿Imports Aspose.BarCode
'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class ControlBarsFillingofOneDBarcodes
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            Using builder As New BarCodeBuilder("TEXT", Symbology.Code128)
                builder.FilledBars = False
                builder.Save(dataDir & Convert.ToString("ControlBarsFillingofOneDBarcodes_out.png"))
            End Using
        End Sub
    End Class
End Namespace
