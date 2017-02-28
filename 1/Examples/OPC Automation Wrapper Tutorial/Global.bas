Attribute VB_Name = "Global"
Public theServer As opcServer
Public theGroups As OPCGroups
Public currentHandle As Long


Public Function GetCanonicalType(theType As Integer) As String
    Dim Types As Variant
    Types = Array("VT_EMPTY", "VT_NULL", "VT_I2", "VT_I4", "VT_R4", "VT_R8", "VT_CY", "VT_DATE", _
    "VT_BSTR", "VT_DISPATCH", "VT_ERROR", "VT_BOOL", "VT_VARIANT", "VT_UNKNOWN", "VT_DECIMAL", _
    "VT_SPARE", "VT_I1", "VT_UI1", "VT_UI2", "VT_UI4", "VT_I8")
    If theType > vbArray Then ' it's an array
        GetCanonicalType = "Array of " & Types(theType - vbArray)
    Else
        GetCanonicalType = Types(theType)
    End If
End Function

