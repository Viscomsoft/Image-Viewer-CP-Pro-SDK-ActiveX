Option Strict Off
Option Explicit On




Friend Class Form1
    Inherits System.Windows.Forms.Form

    Dim iSelLeft As Integer
    Dim iSelTop As Integer
    Dim iSelWidth As Integer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Dim iSelHeight As Integer
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Text2 As System.Windows.Forms.TextBox
    Public WithEvents Text1 As System.Windows.Forms.TextBox
    Public WithEvents cbooutputtype As System.Windows.Forms.ComboBox
    Public WithEvents Command5 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents AxImageViewer1 As AxSCRIBBLELib.AxImageViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttotalpage As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtalpha As System.Windows.Forms.TextBox
    Friend WithEvents btnsaveonly As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.cbooutputtype = New System.Windows.Forms.ComboBox()
        Me.Command5 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.AxImageViewer1 = New AxSCRIBBLELib.AxImageViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttotalpage = New System.Windows.Forms.TextBox()
        Me.btnsaveonly = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtalpha = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Enabled = False
        Me.Text2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(240, 608)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(65, 18)
        Me.Text2.TabIndex = 21
        Me.Text2.Text = "0"
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Enabled = False
        Me.Text1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(88, 608)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(65, 18)
        Me.Text1.TabIndex = 19
        Me.Text1.Text = "0"
        '
        'cbooutputtype
        '
        Me.cbooutputtype.BackColor = System.Drawing.SystemColors.Window
        Me.cbooutputtype.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbooutputtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbooutputtype.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbooutputtype.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbooutputtype.Location = New System.Drawing.Point(269, 632)
        Me.cbooutputtype.Name = "cbooutputtype"
        Me.cbooutputtype.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbooutputtype.Size = New System.Drawing.Size(97, 20)
        Me.cbooutputtype.TabIndex = 16
        '
        'Command5
        '
        Me.Command5.BackColor = System.Drawing.SystemColors.Control
        Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command5.Location = New System.Drawing.Point(386, 623)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(152, 33)
        Me.Command5.TabIndex = 15
        Me.Command5.Text = "Save hightlight for all pages"
        Me.Command5.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(8, 560)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Select Image"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(168, 608)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "File Height"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 608)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "File Width"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(185, 639)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Ouput Format"
        '
        'AxImageViewer1
        '
        Me.AxImageViewer1.Enabled = True
        Me.AxImageViewer1.Location = New System.Drawing.Point(8, 8)
        Me.AxImageViewer1.Name = "AxImageViewer1"
        Me.AxImageViewer1.OcxState = CType(resources.GetObject("AxImageViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageViewer1.Size = New System.Drawing.Size(784, 544)
        Me.AxImageViewer1.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 640)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Total Page"
        '
        'txttotalpage
        '
        Me.txttotalpage.Enabled = False
        Me.txttotalpage.Location = New System.Drawing.Point(88, 640)
        Me.txttotalpage.Name = "txttotalpage"
        Me.txttotalpage.Size = New System.Drawing.Size(72, 20)
        Me.txttotalpage.TabIndex = 56
        Me.txttotalpage.Text = "1"
        '
        'btnsaveonly
        '
        Me.btnsaveonly.Enabled = False
        Me.btnsaveonly.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaveonly.Location = New System.Drawing.Point(386, 678)
        Me.btnsaveonly.Name = "btnsaveonly"
        Me.btnsaveonly.Size = New System.Drawing.Size(152, 40)
        Me.btnsaveonly.TabIndex = 57
        Me.btnsaveonly.Text = "Save hightlight for page 2 only"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 39)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Hightlight"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 565)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 14)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Hightlight Alpha(0-255)"
        '
        'txtalpha
        '
        Me.txtalpha.Location = New System.Drawing.Point(393, 564)
        Me.txtalpha.Name = "txtalpha"
        Me.txtalpha.Size = New System.Drawing.Size(79, 20)
        Me.txtalpha.TabIndex = 60
        Me.txtalpha.Text = "128"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(525, 567)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 41)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Undo Last Hightlight"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(888, 721)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtalpha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnsaveonly)
        Me.Controls.Add(Me.txttotalpage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxImageViewer1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.cbooutputtype)
        Me.Controls.Add(Me.Command5)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Highlight the text - DrawFillRectangle "
        CType(Me.AxImageViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Form1
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Form1
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Form1()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(value As Form1)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region


    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim strFile As String
        Me.OpenFileDialog1.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif|PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico"


        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            strFile = OpenFileDialog1.FileName

            If strFile.Substring(strFile.Length - 3, 3) = "tif" Or strFile.Substring(strFile.Length - 3, 3) = "pdf" Or strFile.Substring(strFile.Length - 3, 3) = "iff" Then

                Me.AxImageViewer1.LoadMultiPage(strFile, 0)

                txttotalpage.Text = CStr(AxImageViewer1.GetTotalPage)
            Else

                Me.AxImageViewer1.FileName = OpenFileDialog1.FileName
                txttotalpage.Text = "1"

            End If

            Text1.Text = CStr(AxImageViewer1.FileWidth)
            Text2.Text = CStr(AxImageViewer1.FileHeight)


        End If

        AxImageViewer1.ClearDrawFillRectangle()
        MessageBox.Show("Now you may draw the selection rectangle (press left mouse button and drag) on image, then click Hightlight button")



    End Sub
    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)



    End Sub



    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer
        Dim iFindIndex As Integer

        strType = cbooutputtype.Items(cbooutputtype.SelectedIndex)

        SaveFileDialog1.Filter = strType + " file (*." + strType + ")|*." + strType + "||"

        SaveFileDialog1.DefaultExt = strType

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            strFile = SaveFileDialog1.FileName


            'cut the extension string
            iFindIndex = strFile.IndexOf("." + strType)

            If iFindIndex <> -1 Then
                strFile = strFile.Substring(0, iFindIndex)
            End If

            AxImageViewer1.ClearDrawPageOnly()

            If strType = "ICO" Then
                iResult = AxImageViewer1.SaveBySize(strFile, "ico", 32, 32)

            Else
                iResult = AxImageViewer1.Save(strFile, strType)

            End If

            If iResult = 1 Then
                MessageBox.Show("Save " + strFile + "." + strType + " Complete")
            Else
                MessageBox.Show("Failed")

            End If

        End If
    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim i As Integer



        cbooutputtype.Items.Add("Bmp")
        cbooutputtype.Items.Add("JPG")
        cbooutputtype.Items.Add("TIF")
        cbooutputtype.Items.Add("PDF")
        cbooutputtype.Items.Add("WBMP")
        cbooutputtype.Items.Add("GIF")
        cbooutputtype.Items.Add("PCX")
        cbooutputtype.Items.Add("TGA")
        cbooutputtype.Items.Add("ICO")
        cbooutputtype.Items.Add("JP2")
        cbooutputtype.Items.Add("JPC")
        cbooutputtype.Items.Add("RAS")
        cbooutputtype.Items.Add("PGX")
        cbooutputtype.Items.Add("PNM")
        cbooutputtype.Items.Add("PNG")
        cbooutputtype.SelectedIndex = 1
        AxImageViewer1.MouseTrackMode = SCRIBBLELib.MOUSE_TRACKMODE.SelectionRectMode




    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsaveonly.Click
        Dim strFile As String
        Dim strType As String
        Dim iResult As Integer

        Dim iFindIndex As Integer

        strType = cbooutputtype.Items(cbooutputtype.SelectedIndex)

        SaveFileDialog1.Filter = strType + " file (*." + strType + ")|*." + strType + "||"

        SaveFileDialog1.DefaultExt = strType

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            strFile = SaveFileDialog1.FileName


            'cut the extension string
            iFindIndex = strFile.IndexOf("." + strType)

            If iFindIndex <> -1 Then
                strFile = strFile.Substring(0, iFindIndex)
            End If

            AxImageViewer1.DrawPageOnly(2)

            If strType = "ICO" Then
                iResult = AxImageViewer1.SaveBySize(strFile, "ico", 32, 32)

            Else
                iResult = AxImageViewer1.Save(strFile, strType)

            End If

            If iResult = 1 Then
                MessageBox.Show("Save " + strFile + "." + strType + " Complete")
            End If
        End If
    End Sub

    Private Sub cbooutputtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbooutputtype.SelectedIndexChanged
        Me.btnsaveonly.Enabled = False

        Select Case cbooutputtype.SelectedIndex

            Case 2
                Me.btnsaveonly.Enabled = True

            Case 3
                Me.btnsaveonly.Enabled = True

        End Select
    End Sub

    Private Sub cbooutputtype_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbooutputtype.Click

    End Sub

    Private Sub AxImageViewer1_SelectionRectDrawn(sender As System.Object, e As AxSCRIBBLELib._DImageViewerEvents_SelectionRectDrawnEvent) Handles AxImageViewer1.SelectionRectDrawn
        iSelLeft = e.iLeft
        iSelTop = e.iTop
        iSelWidth = e.iWidth
        iSelHeight = e.iHeight

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.AxImageViewer1.BackupCurrentImage()
        Me.AxImageViewer1.DrawFillRectangle(iSelLeft, iSelTop, iSelWidth, iSelHeight, RGB(255, 0, 0), txtalpha.Text, True)
        Button2.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Me.AxImageViewer1.ClearDrawFillRectangleByIndex(AxImageViewer1.GetCountDrawFillRectangle - 1)
        ' update the screen, so call ResetDefaultImage
        Me.AxImageViewer1.ResetDefaultImage(True)

        Button2.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)


    End Sub
End Class