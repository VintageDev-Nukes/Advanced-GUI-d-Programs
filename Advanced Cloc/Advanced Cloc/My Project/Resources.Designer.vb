﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18052
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Advanced_Cloc.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to @Echo OFF
        ''' 
        '''Set &quot;WorkingDir=%1&quot;
        '''SET &quot;Directory=%2&quot;
        '''SET &quot;OutputFile=%3&quot;
        '''
        '''Echo Comenzando a leer. &gt; &quot;%OutputFile%&quot;
        '''Echo. &gt;&gt; &quot;%OutputFile%&quot;
        '''Echo ========================== &gt;&gt; &quot;%OutputFile%&quot;
        '''Echo. &gt;&gt; &quot;%OutputFile%&quot;
        '''
        '''Echo Carpeta: &quot;%Directory%&quot; &gt;&gt; &quot;%OutputFile%&quot;
        '''Echo. &gt;&gt; &quot;%OutputFile%&quot;
        '''&quot;%WorkingDir%\cloc-1.60.exe&quot; &quot;%Directory%&quot; &gt;&gt; &quot;%OutputFile%&quot;
        '''Echo. &gt;&gt; &quot;%OutputFile%&quot;
        '''Echo ========================== &gt;&gt; &quot;%OutputFile%&quot;
        '''Echo. &gt;&gt; &quot;%OutputFile%&quot;
        ''' 
        '''PUSHD &quot;%Directory%&quot;
        '''(
        '''	FOR /D /R %%@ in (&quot;*&quot;) DO  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property StartCloc() As String
            Get
                Return ResourceManager.GetString("StartCloc", resourceCulture)
            End Get
        End Property
    End Module
End Namespace