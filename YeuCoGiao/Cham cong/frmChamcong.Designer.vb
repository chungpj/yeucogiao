<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChamcong
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChamcong))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.dtgcChamcong = New DevExpress.XtraGrid.GridControl()
        Me.dtgvChamcong = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnNapDL = New DevExpress.XtraEditors.SimpleButton()
        Me.cboNam = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboThang = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboLop = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dtgcChamcong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvChamcong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboThang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnLuu)
        Me.LayoutControl1.Controls.Add(Me.dtgcChamcong)
        Me.LayoutControl1.Controls.Add(Me.btnNapDL)
        Me.LayoutControl1.Controls.Add(Me.cboNam)
        Me.LayoutControl1.Controls.Add(Me.cboThang)
        Me.LayoutControl1.Controls.Add(Me.cboLop)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1026, 439)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnLuu
        '
        Me.btnLuu.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.Appearance.Options.UseFont = True
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(901, 3)
        Me.btnLuu.MaximumSize = New System.Drawing.Size(122, 22)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnLuu.Size = New System.Drawing.Size(122, 22)
        Me.btnLuu.StyleController = Me.LayoutControl1
        Me.btnLuu.TabIndex = 20
        Me.btnLuu.Text = "Lưu dữ liệu(F2)"
        '
        'dtgcChamcong
        '
        Me.dtgcChamcong.Location = New System.Drawing.Point(3, 29)
        Me.dtgcChamcong.MainView = Me.dtgvChamcong
        Me.dtgcChamcong.Name = "dtgcChamcong"
        Me.dtgcChamcong.Size = New System.Drawing.Size(1020, 407)
        Me.dtgcChamcong.TabIndex = 19
        Me.dtgcChamcong.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dtgvChamcong})
        '
        'dtgvChamcong
        '
        Me.dtgvChamcong.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgvChamcong.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvChamcong.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Navy
        Me.dtgvChamcong.Appearance.FocusedCell.Options.UseBackColor = True
        Me.dtgvChamcong.Appearance.FocusedCell.Options.UseFont = True
        Me.dtgvChamcong.Appearance.FocusedCell.Options.UseForeColor = True
        Me.dtgvChamcong.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgvChamcong.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvChamcong.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Navy
        Me.dtgvChamcong.Appearance.FocusedRow.Options.UseBackColor = True
        Me.dtgvChamcong.Appearance.FocusedRow.Options.UseFont = True
        Me.dtgvChamcong.Appearance.FocusedRow.Options.UseForeColor = True
        Me.dtgvChamcong.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvChamcong.Appearance.HeaderPanel.Options.UseFont = True
        Me.dtgvChamcong.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgvChamcong.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvChamcong.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Navy
        Me.dtgvChamcong.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.dtgvChamcong.Appearance.HideSelectionRow.Options.UseFont = True
        Me.dtgvChamcong.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.dtgvChamcong.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvChamcong.Appearance.Row.Options.UseFont = True
        Me.dtgvChamcong.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.dtgvChamcong.GridControl = Me.dtgcChamcong
        Me.dtgvChamcong.Name = "dtgvChamcong"
        Me.dtgvChamcong.OptionsBehavior.Editable = False
        Me.dtgvChamcong.OptionsBehavior.ReadOnly = True
        Me.dtgvChamcong.OptionsCustomization.AllowFilter = False
        Me.dtgvChamcong.OptionsCustomization.AllowSort = False
        Me.dtgvChamcong.OptionsFilter.AllowFilterEditor = False
        Me.dtgvChamcong.OptionsPrint.AutoWidth = False
        Me.dtgvChamcong.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.dtgvChamcong.OptionsSelection.EnableAppearanceHideSelection = False
        Me.dtgvChamcong.OptionsView.ColumnAutoWidth = False
        Me.dtgvChamcong.OptionsView.ShowGroupPanel = False
        Me.dtgvChamcong.OptionsView.ShowIndicator = False
        '
        'btnNapDL
        '
        Me.btnNapDL.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNapDL.Appearance.Options.UseFont = True
        Me.btnNapDL.Image = CType(resources.GetObject("btnNapDL.Image"), System.Drawing.Image)
        Me.btnNapDL.Location = New System.Drawing.Point(522, 3)
        Me.btnNapDL.Name = "btnNapDL"
        Me.btnNapDL.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnNapDL.Size = New System.Drawing.Size(126, 22)
        Me.btnNapDL.StyleController = Me.LayoutControl1
        Me.btnNapDL.TabIndex = 7
        Me.btnNapDL.Text = "Nạp Dữ liệu (F5)"
        '
        'cboNam
        '
        Me.cboNam.Location = New System.Drawing.Point(435, 3)
        Me.cboNam.Name = "cboNam"
        Me.cboNam.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNam.Properties.Appearance.Options.UseFont = True
        Me.cboNam.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNam.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboNam.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)})
        Me.cboNam.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboNam.Size = New System.Drawing.Size(83, 20)
        Me.cboNam.StyleController = Me.LayoutControl1
        Me.cboNam.TabIndex = 6
        '
        'cboThang
        '
        Me.cboThang.Location = New System.Drawing.Point(287, 3)
        Me.cboThang.Name = "cboThang"
        Me.cboThang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboThang.Properties.Appearance.Options.UseFont = True
        Me.cboThang.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboThang.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboThang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)})
        Me.cboThang.Properties.Items.AddRange(New Object() {"Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"})
        Me.cboThang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboThang.Size = New System.Drawing.Size(103, 20)
        Me.cboThang.StyleController = Me.LayoutControl1
        Me.cboThang.TabIndex = 5
        '
        'cboLop
        '
        Me.cboLop.Location = New System.Drawing.Point(63, 3)
        Me.cboLop.Name = "cboLop"
        Me.cboLop.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLop.Properties.Appearance.Options.UseFont = True
        Me.cboLop.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLop.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboLop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)})
        Me.cboLop.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenlop", "tenlop")})
        Me.cboLop.Properties.NullText = ""
        Me.cboLop.Properties.NullValuePrompt = "Chọn lớp"
        Me.cboLop.Properties.ShowFooter = False
        Me.cboLop.Properties.ShowHeader = False
        Me.cboLop.Size = New System.Drawing.Size(173, 20)
        Me.cboLop.StyleController = Me.LayoutControl1
        Me.cboLop.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1026, 439)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me.cboLop
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(237, 26)
        Me.LayoutControlItem1.Text = "Chọn lớp :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(57, 14)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.Control = Me.cboThang
        Me.LayoutControlItem2.Location = New System.Drawing.Point(237, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(154, 26)
        Me.LayoutControlItem2.Text = "Tháng :"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(42, 14)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.Control = Me.cboNam
        Me.LayoutControlItem3.Location = New System.Drawing.Point(391, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(128, 26)
        Me.LayoutControlItem3.Text = "Năm  :"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(36, 14)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnNapDL
        Me.LayoutControlItem4.Location = New System.Drawing.Point(519, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(130, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dtgcChamcong
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1024, 411)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(649, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(249, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnLuu
        Me.LayoutControlItem6.Location = New System.Drawing.Point(898, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(126, 26)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'frmChamcong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 439)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmChamcong"
        Me.Text = "Chấm ngày ăn"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dtgcChamcong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvChamcong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboThang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnNapDL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboNam As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboThang As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboLop As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtgcChamcong As DevExpress.XtraGrid.GridControl
    Friend WithEvents dtgvChamcong As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
