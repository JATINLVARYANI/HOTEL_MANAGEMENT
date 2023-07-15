<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Book_Room
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book_Room))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.H_ItemTableAdapter = New HOTEL.THE_SHIV_GRANDDataSetTableAdapters.H_ItemTableAdapter()
        Me.HItemBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.THE_SHIV_GRANDDataSet1 = New HOTEL.THE_SHIV_GRANDDataSet1()
        Me.H_ItemTableAdapter1 = New HOTEL.THE_SHIV_GRANDDataSet1TableAdapters.H_ItemTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.drp_to = New System.Windows.Forms.DateTimePicker()
        Me.drp_frm = New System.Windows.Forms.DateTimePicker()
        Me.cmb_rmno = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_cpcty = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_rmtp = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lbl_mbrs = New System.Windows.Forms.Label()
        Me.nud_mbrs = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.btn_slctrm = New System.Windows.Forms.Button()
        Me.lbl_rate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_rms = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_fndrm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_rmtp = New System.Windows.Forms.Label()
        Me.lbl_to = New System.Windows.Forms.Label()
        Me.lbl_frm = New System.Windows.Forms.Label()
        Me.pnl_details = New System.Windows.Forms.Panel()
        Me.lbl_nat4 = New System.Windows.Forms.Label()
        Me.cmb_nat_m4 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_mem4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_mem4 = New System.Windows.Forms.Label()
        Me.lbl_nat3 = New System.Windows.Forms.Label()
        Me.cmb_nat_m3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lbl_nat2 = New System.Windows.Forms.Label()
        Me.cmb_nat_m2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lbl_nat1 = New System.Windows.Forms.Label()
        Me.cmb_nat_m1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_mem3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_mem2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_mem1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_cctct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_cname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_genbill = New System.Windows.Forms.Button()
        Me.lbl_mem3 = New System.Windows.Forms.Label()
        Me.lbl_mem2 = New System.Windows.Forms.Label()
        Me.lbl_mem1 = New System.Windows.Forms.Label()
        Me.btn_srch = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_htl_ctct = New System.Windows.Forms.Label()
        Me.pnl_bill = New System.Windows.Forms.Panel()
        Me.cmb_dis = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_mode = New System.Windows.Forms.Label()
        Me.cmb_pmode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lbl_rmcat = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lbl_ppl = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lbl_tot = New System.Windows.Forms.Label()
        Me.lbl_days = New System.Windows.Forms.Label()
        Me.lbl_chkout = New System.Windows.Forms.Label()
        Me.lbl_chkin = New System.Windows.Forms.Label()
        Me.lbl_rrpn = New System.Windows.Forms.Label()
        Me.lbl_roomno = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_invc = New System.Windows.Forms.Label()
        Me.lbl_amnt = New System.Windows.Forms.Label()
        Me.txt_Amnt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.rad_pay_advc = New System.Windows.Forms.RadioButton()
        Me.rad_pay_chkt = New System.Windows.Forms.RadioButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.Guna2ContextMenuStrip2 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.Panel2.SuspendLayout()
        CType(Me.HItemBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.THE_SHIV_GRANDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nud_mbrs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_details.SuspendLayout()
        Me.pnl_bill.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.HItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel2.Controls.Add(Me.btn_clear)
        Me.Panel2.Controls.Add(Me.btn_close)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1288, 59)
        Me.Panel2.TabIndex = 6
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.Guna2HtmlLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(438, 10)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(412, 38)
        Me.Guna2HtmlLabel2.TabIndex = 22
        Me.Guna2HtmlLabel2.Text = "Hotel Shiv Grand - Book Room"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.btn_clear, BunifuAnimatorNS.DecorationType.None)
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(1152, 0)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(70, 59)
        Me.btn_clear.TabIndex = 22
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.btn_close, BunifuAnimatorNS.DecorationType.None)
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(1221, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(64, 59)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel2
        Me.BunifuDragControl1.Vertical = True
        '
        'H_ItemTableAdapter
        '
        Me.H_ItemTableAdapter.ClearBeforeFill = True
        '
        'HItemBindingSource2
        '
        Me.HItemBindingSource2.DataMember = "H_Item"
        Me.HItemBindingSource2.DataSource = Me.THE_SHIV_GRANDDataSet1
        '
        'THE_SHIV_GRANDDataSet1
        '
        Me.THE_SHIV_GRANDDataSet1.DataSetName = "THE_SHIV_GRANDDataSet1"
        Me.THE_SHIV_GRANDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'H_ItemTableAdapter1
        '
        Me.H_ItemTableAdapter1.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.drp_to)
        Me.Panel1.Controls.Add(Me.drp_frm)
        Me.Panel1.Controls.Add(Me.cmb_rmno)
        Me.Panel1.Controls.Add(Me.cmb_cpcty)
        Me.Panel1.Controls.Add(Me.cmb_rmtp)
        Me.Panel1.Controls.Add(Me.lbl_mbrs)
        Me.Panel1.Controls.Add(Me.nud_mbrs)
        Me.Panel1.Controls.Add(Me.btn_slctrm)
        Me.Panel1.Controls.Add(Me.lbl_rate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbl_rms)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_fndrm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_rmtp)
        Me.Panel1.Controls.Add(Me.lbl_to)
        Me.Panel1.Controls.Add(Me.lbl_frm)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 667)
        Me.Panel1.TabIndex = 7
        '
        'drp_to
        '
        Me.drp_to.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.drp_to.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.drp_to, BunifuAnimatorNS.DecorationType.None)
        Me.drp_to.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drp_to.Location = New System.Drawing.Point(13, 124)
        Me.drp_to.MaxDate = New Date(2021, 10, 3, 0, 0, 0, 0)
        Me.drp_to.MinDate = New Date(1753, 1, 16, 0, 0, 0, 0)
        Me.drp_to.Name = "drp_to"
        Me.drp_to.Size = New System.Drawing.Size(301, 30)
        Me.drp_to.TabIndex = 81
        Me.drp_to.Value = New Date(2021, 9, 15, 0, 0, 0, 0)
        '
        'drp_frm
        '
        Me.drp_frm.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.drp_frm.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.drp_frm, BunifuAnimatorNS.DecorationType.None)
        Me.drp_frm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drp_frm.Location = New System.Drawing.Point(13, 37)
        Me.drp_frm.MaxDate = New Date(2021, 10, 3, 0, 0, 0, 0)
        Me.drp_frm.MinDate = New Date(1753, 1, 16, 0, 0, 0, 0)
        Me.drp_frm.Name = "drp_frm"
        Me.drp_frm.Size = New System.Drawing.Size(301, 30)
        Me.drp_frm.TabIndex = 80
        Me.drp_frm.Value = New Date(2021, 9, 15, 0, 0, 0, 0)
        '
        'cmb_rmno
        '
        Me.cmb_rmno.BackColor = System.Drawing.Color.Transparent
        Me.cmb_rmno.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmb_rmno.BorderThickness = 3
        Me.BunifuTransition1.SetDecoration(Me.cmb_rmno, BunifuAnimatorNS.DecorationType.None)
        Me.cmb_rmno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_rmno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rmno.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_rmno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_rmno.FocusedState.Parent = Me.cmb_rmno
        Me.cmb_rmno.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_rmno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_rmno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_rmno.HoverState.Parent = Me.cmb_rmno
        Me.cmb_rmno.ItemHeight = 30
        Me.cmb_rmno.Items.AddRange(New Object() {"1", "2", "4"})
        Me.cmb_rmno.ItemsAppearance.Parent = Me.cmb_rmno
        Me.cmb_rmno.Location = New System.Drawing.Point(16, 464)
        Me.cmb_rmno.Name = "cmb_rmno"
        Me.cmb_rmno.ShadowDecoration.Parent = Me.cmb_rmno
        Me.cmb_rmno.Size = New System.Drawing.Size(122, 36)
        Me.cmb_rmno.TabIndex = 58
        '
        'cmb_cpcty
        '
        Me.cmb_cpcty.BackColor = System.Drawing.Color.Transparent
        Me.cmb_cpcty.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmb_cpcty.BorderThickness = 3
        Me.BunifuTransition1.SetDecoration(Me.cmb_cpcty, BunifuAnimatorNS.DecorationType.None)
        Me.cmb_cpcty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_cpcty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cpcty.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_cpcty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_cpcty.FocusedState.Parent = Me.cmb_cpcty
        Me.cmb_cpcty.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_cpcty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_cpcty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_cpcty.HoverState.Parent = Me.cmb_cpcty
        Me.cmb_cpcty.ItemHeight = 30
        Me.cmb_cpcty.Items.AddRange(New Object() {"1", "2", "4"})
        Me.cmb_cpcty.ItemsAppearance.Parent = Me.cmb_cpcty
        Me.cmb_cpcty.Location = New System.Drawing.Point(210, 204)
        Me.cmb_cpcty.Name = "cmb_cpcty"
        Me.cmb_cpcty.ShadowDecoration.Parent = Me.cmb_cpcty
        Me.cmb_cpcty.Size = New System.Drawing.Size(110, 36)
        Me.cmb_cpcty.TabIndex = 57
        '
        'cmb_rmtp
        '
        Me.cmb_rmtp.BackColor = System.Drawing.Color.Transparent
        Me.cmb_rmtp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmb_rmtp.BorderThickness = 3
        Me.BunifuTransition1.SetDecoration(Me.cmb_rmtp, BunifuAnimatorNS.DecorationType.None)
        Me.cmb_rmtp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_rmtp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rmtp.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_rmtp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_rmtp.FocusedState.Parent = Me.cmb_rmtp
        Me.cmb_rmtp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_rmtp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_rmtp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_rmtp.HoverState.Parent = Me.cmb_rmtp
        Me.cmb_rmtp.ItemHeight = 30
        Me.cmb_rmtp.Items.AddRange(New Object() {"Normal", "Delux", "Super Delux"})
        Me.cmb_rmtp.ItemsAppearance.Parent = Me.cmb_rmtp
        Me.cmb_rmtp.Location = New System.Drawing.Point(13, 204)
        Me.cmb_rmtp.Name = "cmb_rmtp"
        Me.cmb_rmtp.ShadowDecoration.Parent = Me.cmb_rmtp
        Me.cmb_rmtp.Size = New System.Drawing.Size(140, 36)
        Me.cmb_rmtp.TabIndex = 56
        '
        'lbl_mbrs
        '
        Me.lbl_mbrs.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_mbrs, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_mbrs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.lbl_mbrs.ForeColor = System.Drawing.Color.Black
        Me.lbl_mbrs.Location = New System.Drawing.Point(242, 435)
        Me.lbl_mbrs.Name = "lbl_mbrs"
        Me.lbl_mbrs.Size = New System.Drawing.Size(95, 22)
        Me.lbl_mbrs.TabIndex = 42
        Me.lbl_mbrs.Text = "Members"
        '
        'nud_mbrs
        '
        Me.nud_mbrs.BackColor = System.Drawing.Color.Transparent
        Me.nud_mbrs.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.nud_mbrs.BorderThickness = 3
        Me.nud_mbrs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.nud_mbrs, BunifuAnimatorNS.DecorationType.None)
        Me.nud_mbrs.DisabledState.Parent = Me.nud_mbrs
        Me.nud_mbrs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nud_mbrs.FocusedState.Parent = Me.nud_mbrs
        Me.nud_mbrs.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.nud_mbrs.ForeColor = System.Drawing.Color.Black
        Me.nud_mbrs.Location = New System.Drawing.Point(246, 461)
        Me.nud_mbrs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nud_mbrs.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nud_mbrs.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_mbrs.Name = "nud_mbrs"
        Me.nud_mbrs.ShadowDecoration.Parent = Me.nud_mbrs
        Me.nud_mbrs.Size = New System.Drawing.Size(91, 44)
        Me.nud_mbrs.TabIndex = 41
        Me.nud_mbrs.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.nud_mbrs.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_slctrm
        '
        Me.btn_slctrm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.btn_slctrm, BunifuAnimatorNS.DecorationType.None)
        Me.btn_slctrm.FlatAppearance.BorderSize = 0
        Me.btn_slctrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_slctrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_slctrm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_slctrm.Location = New System.Drawing.Point(16, 606)
        Me.btn_slctrm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_slctrm.Name = "btn_slctrm"
        Me.btn_slctrm.Size = New System.Drawing.Size(304, 36)
        Me.btn_slctrm.TabIndex = 32
        Me.btn_slctrm.Text = "Select Room"
        Me.btn_slctrm.UseVisualStyleBackColor = False
        '
        'lbl_rate
        '
        Me.lbl_rate.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_rate, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_rate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.lbl_rate.ForeColor = System.Drawing.Color.Black
        Me.lbl_rate.Location = New System.Drawing.Point(283, 547)
        Me.lbl_rate.Name = "lbl_rate"
        Me.lbl_rate.Size = New System.Drawing.Size(32, 22)
        Me.lbl_rate.TabIndex = 31
        Me.lbl_rate.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 547)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 22)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Room Rate Per Night :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 22)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Room No."
        '
        'lbl_rms
        '
        Me.lbl_rms.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_rms, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_rms.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.lbl_rms.ForeColor = System.Drawing.Color.Black
        Me.lbl_rms.Location = New System.Drawing.Point(283, 390)
        Me.lbl_rms.Name = "lbl_rms"
        Me.lbl_rms.Size = New System.Drawing.Size(32, 22)
        Me.lbl_rms.TabIndex = 27
        Me.lbl_rms.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 22)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Rooms Available : "
        '
        'btn_fndrm
        '
        Me.btn_fndrm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.btn_fndrm, BunifuAnimatorNS.DecorationType.None)
        Me.btn_fndrm.FlatAppearance.BorderSize = 0
        Me.btn_fndrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_fndrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fndrm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fndrm.Location = New System.Drawing.Point(13, 285)
        Me.btn_fndrm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_fndrm.Name = "btn_fndrm"
        Me.btn_fndrm.Size = New System.Drawing.Size(304, 36)
        Me.btn_fndrm.TabIndex = 25
        Me.btn_fndrm.Text = "Find Rooms"
        Me.btn_fndrm.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(225, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 22)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Capacity"
        '
        'lbl_rmtp
        '
        Me.lbl_rmtp.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_rmtp, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_rmtp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.lbl_rmtp.ForeColor = System.Drawing.Color.Black
        Me.lbl_rmtp.Location = New System.Drawing.Point(12, 172)
        Me.lbl_rmtp.Name = "lbl_rmtp"
        Me.lbl_rmtp.Size = New System.Drawing.Size(94, 22)
        Me.lbl_rmtp.TabIndex = 23
        Me.lbl_rmtp.Text = "Catagory"
        '
        'lbl_to
        '
        Me.lbl_to.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_to, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_to.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.lbl_to.ForeColor = System.Drawing.Color.Black
        Me.lbl_to.Location = New System.Drawing.Point(12, 97)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(33, 22)
        Me.lbl_to.TabIndex = 22
        Me.lbl_to.Text = "To"
        '
        'lbl_frm
        '
        Me.lbl_frm.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_frm, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_frm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.lbl_frm.ForeColor = System.Drawing.Color.Black
        Me.lbl_frm.Location = New System.Drawing.Point(12, 12)
        Me.lbl_frm.Name = "lbl_frm"
        Me.lbl_frm.Size = New System.Drawing.Size(57, 22)
        Me.lbl_frm.TabIndex = 20
        Me.lbl_frm.Text = "From"
        '
        'pnl_details
        '
        Me.pnl_details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_details.Controls.Add(Me.lbl_nat4)
        Me.pnl_details.Controls.Add(Me.cmb_nat_m4)
        Me.pnl_details.Controls.Add(Me.txt_mem4)
        Me.pnl_details.Controls.Add(Me.lbl_mem4)
        Me.pnl_details.Controls.Add(Me.lbl_nat3)
        Me.pnl_details.Controls.Add(Me.cmb_nat_m3)
        Me.pnl_details.Controls.Add(Me.lbl_nat2)
        Me.pnl_details.Controls.Add(Me.cmb_nat_m2)
        Me.pnl_details.Controls.Add(Me.lbl_nat1)
        Me.pnl_details.Controls.Add(Me.cmb_nat_m1)
        Me.pnl_details.Controls.Add(Me.txt_mem3)
        Me.pnl_details.Controls.Add(Me.txt_mem2)
        Me.pnl_details.Controls.Add(Me.txt_mem1)
        Me.pnl_details.Controls.Add(Me.txt_cctct)
        Me.pnl_details.Controls.Add(Me.txt_cname)
        Me.pnl_details.Controls.Add(Me.btn_genbill)
        Me.pnl_details.Controls.Add(Me.lbl_mem3)
        Me.pnl_details.Controls.Add(Me.lbl_mem2)
        Me.pnl_details.Controls.Add(Me.lbl_mem1)
        Me.pnl_details.Controls.Add(Me.btn_srch)
        Me.pnl_details.Controls.Add(Me.btn_add)
        Me.pnl_details.Controls.Add(Me.Label7)
        Me.pnl_details.Controls.Add(Me.lbl_htl_ctct)
        Me.BunifuTransition1.SetDecoration(Me.pnl_details, BunifuAnimatorNS.DecorationType.None)
        Me.pnl_details.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_details.Location = New System.Drawing.Point(349, 59)
        Me.pnl_details.Name = "pnl_details"
        Me.pnl_details.Size = New System.Drawing.Size(396, 667)
        Me.pnl_details.TabIndex = 8
        Me.pnl_details.Visible = False
        '
        'lbl_nat4
        '
        Me.lbl_nat4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_nat4, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_nat4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nat4.ForeColor = System.Drawing.Color.Black
        Me.lbl_nat4.Location = New System.Drawing.Point(285, 470)
        Me.lbl_nat4.Name = "lbl_nat4"
        Me.lbl_nat4.Size = New System.Drawing.Size(107, 22)
        Me.lbl_nat4.TabIndex = 63
        Me.lbl_nat4.Text = "Nationality"
        Me.lbl_nat4.Visible = False
        '
        'cmb_nat_m4
        '
        Me.cmb_nat_m4.BackColor = System.Drawing.Color.Transparent
        Me.cmb_nat_m4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmb_nat_m4.BorderThickness = 3
        Me.BunifuTransition1.SetDecoration(Me.cmb_nat_m4, BunifuAnimatorNS.DecorationType.None)
        Me.cmb_nat_m4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_nat_m4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nat_m4.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_nat_m4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_nat_m4.FocusedState.Parent = Me.cmb_nat_m4
        Me.cmb_nat_m4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_nat_m4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_nat_m4.HoverState.Parent = Me.cmb_nat_m4
        Me.cmb_nat_m4.ItemHeight = 30
        Me.cmb_nat_m4.Items.AddRange(New Object() {"INDIAN", "NRI", "FOREIGNER"})
        Me.cmb_nat_m4.ItemsAppearance.Parent = Me.cmb_nat_m4
        Me.cmb_nat_m4.Location = New System.Drawing.Point(270, 494)
        Me.cmb_nat_m4.Name = "cmb_nat_m4"
        Me.cmb_nat_m4.ShadowDecoration.Parent = Me.cmb_nat_m4
        Me.cmb_nat_m4.Size = New System.Drawing.Size(117, 36)
        Me.cmb_nat_m4.TabIndex = 62
        Me.cmb_nat_m4.Visible = False
        '
        'txt_mem4
        '
        Me.txt_mem4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_mem4.BorderThickness = 3
        Me.txt_mem4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txt_mem4, BunifuAnimatorNS.DecorationType.None)
        Me.txt_mem4.DefaultText = ""
        Me.txt_mem4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_mem4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_mem4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_mem4.DisabledState.Parent = Me.txt_mem4
        Me.txt_mem4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_mem4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_mem4.FocusedState.Parent = Me.txt_mem4
        Me.txt_mem4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_mem4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_mem4.HoverState.Parent = Me.txt_mem4
        Me.txt_mem4.Location = New System.Drawing.Point(10, 495)
        Me.txt_mem4.Name = "txt_mem4"
        Me.txt_mem4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mem4.PlaceholderText = ""
        Me.txt_mem4.SelectedText = ""
        Me.txt_mem4.ShadowDecoration.Parent = Me.txt_mem4
        Me.txt_mem4.Size = New System.Drawing.Size(254, 36)
        Me.txt_mem4.TabIndex = 61
        Me.txt_mem4.Visible = False
        '
        'lbl_mem4
        '
        Me.lbl_mem4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_mem4, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_mem4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mem4.ForeColor = System.Drawing.Color.Black
        Me.lbl_mem4.Location = New System.Drawing.Point(6, 469)
        Me.lbl_mem4.Name = "lbl_mem4"
        Me.lbl_mem4.Size = New System.Drawing.Size(159, 22)
        Me.lbl_mem4.TabIndex = 60
        Me.lbl_mem4.Text = "Member 4 Name"
        Me.lbl_mem4.Visible = False
        '
        'lbl_nat3
        '
        Me.lbl_nat3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_nat3, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_nat3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nat3.ForeColor = System.Drawing.Color.Black
        Me.lbl_nat3.Location = New System.Drawing.Point(285, 392)
        Me.lbl_nat3.Name = "lbl_nat3"
        Me.lbl_nat3.Size = New System.Drawing.Size(107, 22)
        Me.lbl_nat3.TabIndex = 59
        Me.lbl_nat3.Text = "Nationality"
        Me.lbl_nat3.Visible = False
        '
        'cmb_nat_m3
        '
        Me.cmb_nat_m3.BackColor = System.Drawing.Color.Transparent
        Me.cmb_nat_m3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmb_nat_m3.BorderThickness = 3
        Me.BunifuTransition1.SetDecoration(Me.cmb_nat_m3, BunifuAnimatorNS.DecorationType.None)
        Me.cmb_nat_m3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_nat_m3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nat_m3.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_nat_m3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_nat_m3.FocusedState.Parent = Me.cmb_nat_m3
        Me.cmb_nat_m3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_nat_m3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_nat_m3.HoverState.Parent = Me.cmb_nat_m3
        Me.cmb_nat_m3.ItemHeight = 30
        Me.cmb_nat_m3.Items.AddRange(New Object() {"INDIAN", "NRI", "FOREIGNER"})
        Me.cmb_nat_m3.ItemsAppearance.Parent = Me.cmb_nat_m3
        Me.cmb_nat_m3.Location = New System.Drawing.Point(270, 418)
        Me.cmb_nat_m3.Name = "cmb_nat_m3"
        Me.cmb_nat_m3.ShadowDecoration.Parent = Me.cmb_nat_m3
        Me.cmb_nat_m3.Size = New System.Drawing.Size(117, 36)
        Me.cmb_nat_m3.TabIndex = 58
        Me.cmb_nat_m3.Visible = False
        '
        'lbl_nat2
        '
        Me.lbl_nat2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_nat2, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_nat2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nat2.ForeColor = System.Drawing.Color.Black
        Me.lbl_nat2.Location = New System.Drawing.Point(285, 315)
        Me.lbl_nat2.Name = "lbl_nat2"
        Me.lbl_nat2.Size = New System.Drawing.Size(107, 22)
        Me.lbl_nat2.TabIndex = 57
        Me.lbl_nat2.Text = "Nationality"
        Me.lbl_nat2.Visible = False
        '
        'cmb_nat_m2
        '
        Me.cmb_nat_m2.BackColor = System.Drawing.Color.Transparent
        Me.cmb_nat_m2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmb_nat_m2.BorderThickness = 3
        Me.BunifuTransition1.SetDecoration(Me.cmb_nat_m2, BunifuAnimatorNS.DecorationType.None)
        Me.cmb_nat_m2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_nat_m2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nat_m2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_nat_m2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_nat_m2.FocusedState.Parent = Me.cmb_nat_m2
        Me.cmb_nat_m2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_nat_m2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_nat_m2.HoverState.Parent = Me.cmb_nat_m2
        Me.cmb_nat_m2.ItemHeight = 30
        Me.cmb_nat_m2.Items.AddRange(New Object() {"INDIAN", "NRI", "FOREIGNER"})
        Me.cmb_nat_m2.ItemsAppearance.Parent = Me.cmb_nat_m2
        Me.cmb_nat_m2.Location = New System.Drawing.Point(270, 340)
        Me.cmb_nat_m2.Name = "cmb_nat_m2"
        Me.cmb_nat_m2.ShadowDecoration.Parent = Me.cmb_nat_m2
        Me.cmb_nat_m2.Size = New System.Drawing.Size(117, 36)
        Me.cmb_nat_m2.TabIndex = 56
        Me.cmb_nat_m2.Visible = False
        '
        'lbl_nat1
        '
        Me.lbl_nat1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_nat1, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_nat1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nat1.ForeColor = System.Drawing.Color.Black
        Me.lbl_nat1.Location = New System.Drawing.Point(285, 238)
        Me.lbl_nat1.Name = "lbl_nat1"
        Me.lbl_nat1.Size = New System.Drawing.Size(107, 22)
        Me.lbl_nat1.TabIndex = 55
        Me.lbl_nat1.Text = "Nationality"
        Me.lbl_nat1.Visible = False
        '
        'cmb_nat_m1
        '
        Me.cmb_nat_m1.BackColor = System.Drawing.Color.Transparent
        Me.cmb_nat_m1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmb_nat_m1.BorderThickness = 3
        Me.BunifuTransition1.SetDecoration(Me.cmb_nat_m1, BunifuAnimatorNS.DecorationType.None)
        Me.cmb_nat_m1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_nat_m1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nat_m1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_nat_m1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_nat_m1.FocusedState.Parent = Me.cmb_nat_m1
        Me.cmb_nat_m1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_nat_m1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_nat_m1.HoverState.Parent = Me.cmb_nat_m1
        Me.cmb_nat_m1.ItemHeight = 30
        Me.cmb_nat_m1.Items.AddRange(New Object() {"INDIAN", "NRI", "FOREIGNER"})
        Me.cmb_nat_m1.ItemsAppearance.Parent = Me.cmb_nat_m1
        Me.cmb_nat_m1.Location = New System.Drawing.Point(270, 263)
        Me.cmb_nat_m1.Name = "cmb_nat_m1"
        Me.cmb_nat_m1.ShadowDecoration.Parent = Me.cmb_nat_m1
        Me.cmb_nat_m1.Size = New System.Drawing.Size(117, 36)
        Me.cmb_nat_m1.TabIndex = 54
        Me.cmb_nat_m1.Visible = False
        '
        'txt_mem3
        '
        Me.txt_mem3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_mem3.BorderThickness = 3
        Me.txt_mem3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txt_mem3, BunifuAnimatorNS.DecorationType.None)
        Me.txt_mem3.DefaultText = ""
        Me.txt_mem3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_mem3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_mem3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_mem3.DisabledState.Parent = Me.txt_mem3
        Me.txt_mem3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_mem3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_mem3.FocusedState.Parent = Me.txt_mem3
        Me.txt_mem3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_mem3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_mem3.HoverState.Parent = Me.txt_mem3
        Me.txt_mem3.Location = New System.Drawing.Point(10, 418)
        Me.txt_mem3.Name = "txt_mem3"
        Me.txt_mem3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mem3.PlaceholderText = ""
        Me.txt_mem3.SelectedText = ""
        Me.txt_mem3.ShadowDecoration.Parent = Me.txt_mem3
        Me.txt_mem3.Size = New System.Drawing.Size(254, 36)
        Me.txt_mem3.TabIndex = 53
        '
        'txt_mem2
        '
        Me.txt_mem2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_mem2.BorderThickness = 3
        Me.txt_mem2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txt_mem2, BunifuAnimatorNS.DecorationType.None)
        Me.txt_mem2.DefaultText = ""
        Me.txt_mem2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_mem2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_mem2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_mem2.DisabledState.Parent = Me.txt_mem2
        Me.txt_mem2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_mem2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_mem2.FocusedState.Parent = Me.txt_mem2
        Me.txt_mem2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_mem2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_mem2.HoverState.Parent = Me.txt_mem2
        Me.txt_mem2.Location = New System.Drawing.Point(10, 340)
        Me.txt_mem2.Name = "txt_mem2"
        Me.txt_mem2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mem2.PlaceholderText = ""
        Me.txt_mem2.SelectedText = ""
        Me.txt_mem2.ShadowDecoration.Parent = Me.txt_mem2
        Me.txt_mem2.Size = New System.Drawing.Size(254, 37)
        Me.txt_mem2.TabIndex = 52
        '
        'txt_mem1
        '
        Me.txt_mem1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_mem1.BorderThickness = 3
        Me.txt_mem1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txt_mem1, BunifuAnimatorNS.DecorationType.None)
        Me.txt_mem1.DefaultText = ""
        Me.txt_mem1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_mem1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_mem1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_mem1.DisabledState.Parent = Me.txt_mem1
        Me.txt_mem1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_mem1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_mem1.FocusedState.Parent = Me.txt_mem1
        Me.txt_mem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_mem1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_mem1.HoverState.Parent = Me.txt_mem1
        Me.txt_mem1.Location = New System.Drawing.Point(7, 263)
        Me.txt_mem1.Name = "txt_mem1"
        Me.txt_mem1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mem1.PlaceholderText = ""
        Me.txt_mem1.SelectedText = ""
        Me.txt_mem1.ShadowDecoration.Parent = Me.txt_mem1
        Me.txt_mem1.Size = New System.Drawing.Size(257, 36)
        Me.txt_mem1.TabIndex = 51
        '
        'txt_cctct
        '
        Me.txt_cctct.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_cctct.BorderThickness = 3
        Me.txt_cctct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txt_cctct, BunifuAnimatorNS.DecorationType.None)
        Me.txt_cctct.DefaultText = ""
        Me.txt_cctct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cctct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cctct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cctct.DisabledState.Parent = Me.txt_cctct
        Me.txt_cctct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cctct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cctct.FocusedState.Parent = Me.txt_cctct
        Me.txt_cctct.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cctct.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_cctct.HoverState.Parent = Me.txt_cctct
        Me.txt_cctct.Location = New System.Drawing.Point(10, 118)
        Me.txt_cctct.MaxLength = 10
        Me.txt_cctct.Name = "txt_cctct"
        Me.txt_cctct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cctct.PlaceholderText = ""
        Me.txt_cctct.ReadOnly = True
        Me.txt_cctct.SelectedText = ""
        Me.txt_cctct.ShadowDecoration.Parent = Me.txt_cctct
        Me.txt_cctct.Size = New System.Drawing.Size(277, 36)
        Me.txt_cctct.TabIndex = 50
        '
        'txt_cname
        '
        Me.txt_cname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_cname.BorderThickness = 3
        Me.txt_cname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txt_cname, BunifuAnimatorNS.DecorationType.None)
        Me.txt_cname.DefaultText = ""
        Me.txt_cname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cname.DisabledState.Parent = Me.txt_cname
        Me.txt_cname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cname.FocusedState.Parent = Me.txt_cname
        Me.txt_cname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.txt_cname.HoverState.Parent = Me.txt_cname
        Me.txt_cname.Location = New System.Drawing.Point(10, 33)
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cname.PlaceholderText = ""
        Me.txt_cname.ReadOnly = True
        Me.txt_cname.SelectedText = ""
        Me.txt_cname.ShadowDecoration.Parent = Me.txt_cname
        Me.txt_cname.Size = New System.Drawing.Size(277, 36)
        Me.txt_cname.TabIndex = 49
        '
        'btn_genbill
        '
        Me.btn_genbill.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.btn_genbill, BunifuAnimatorNS.DecorationType.None)
        Me.btn_genbill.Enabled = False
        Me.btn_genbill.FlatAppearance.BorderSize = 0
        Me.btn_genbill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_genbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_genbill.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_genbill.Location = New System.Drawing.Point(38, 605)
        Me.btn_genbill.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_genbill.Name = "btn_genbill"
        Me.btn_genbill.Size = New System.Drawing.Size(304, 36)
        Me.btn_genbill.TabIndex = 33
        Me.btn_genbill.Text = "Generate Bill"
        Me.btn_genbill.UseVisualStyleBackColor = False
        '
        'lbl_mem3
        '
        Me.lbl_mem3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_mem3, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_mem3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mem3.ForeColor = System.Drawing.Color.Black
        Me.lbl_mem3.Location = New System.Drawing.Point(6, 392)
        Me.lbl_mem3.Name = "lbl_mem3"
        Me.lbl_mem3.Size = New System.Drawing.Size(159, 22)
        Me.lbl_mem3.TabIndex = 37
        Me.lbl_mem3.Text = "Member 3 Name"
        Me.lbl_mem3.Visible = False
        '
        'lbl_mem2
        '
        Me.lbl_mem2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_mem2, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_mem2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mem2.ForeColor = System.Drawing.Color.Black
        Me.lbl_mem2.Location = New System.Drawing.Point(9, 315)
        Me.lbl_mem2.Name = "lbl_mem2"
        Me.lbl_mem2.Size = New System.Drawing.Size(159, 22)
        Me.lbl_mem2.TabIndex = 35
        Me.lbl_mem2.Text = "Member 2 Name"
        Me.lbl_mem2.Visible = False
        '
        'lbl_mem1
        '
        Me.lbl_mem1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_mem1, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_mem1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mem1.ForeColor = System.Drawing.Color.Black
        Me.lbl_mem1.Location = New System.Drawing.Point(6, 238)
        Me.lbl_mem1.Name = "lbl_mem1"
        Me.lbl_mem1.Size = New System.Drawing.Size(159, 22)
        Me.lbl_mem1.TabIndex = 33
        Me.lbl_mem1.Text = "Member 1 Name"
        Me.lbl_mem1.Visible = False
        '
        'btn_srch
        '
        Me.btn_srch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.btn_srch, BunifuAnimatorNS.DecorationType.None)
        Me.btn_srch.FlatAppearance.BorderSize = 0
        Me.btn_srch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_srch.Image = CType(resources.GetObject("btn_srch.Image"), System.Drawing.Image)
        Me.btn_srch.Location = New System.Drawing.Point(7, 170)
        Me.btn_srch.Name = "btn_srch"
        Me.btn_srch.Size = New System.Drawing.Size(41, 44)
        Me.btn_srch.TabIndex = 32
        Me.btn_srch.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.btn_add, BunifuAnimatorNS.DecorationType.None)
        Me.btn_add.Enabled = False
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(54, 170)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(41, 44)
        Me.btn_add.TabIndex = 1
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(3, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 22)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Customer Contact"
        '
        'lbl_htl_ctct
        '
        Me.lbl_htl_ctct.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_htl_ctct, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_htl_ctct.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_htl_ctct.ForeColor = System.Drawing.Color.Black
        Me.lbl_htl_ctct.Location = New System.Drawing.Point(3, 8)
        Me.lbl_htl_ctct.Name = "lbl_htl_ctct"
        Me.lbl_htl_ctct.Size = New System.Drawing.Size(157, 22)
        Me.lbl_htl_ctct.TabIndex = 28
        Me.lbl_htl_ctct.Text = "Customer Name"
        '
        'pnl_bill
        '
        Me.pnl_bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_bill.Controls.Add(Me.cmb_dis)
        Me.pnl_bill.Controls.Add(Me.Label18)
        Me.pnl_bill.Controls.Add(Me.Label15)
        Me.pnl_bill.Controls.Add(Me.Label13)
        Me.pnl_bill.Controls.Add(Me.Label10)
        Me.pnl_bill.Controls.Add(Me.Label9)
        Me.pnl_bill.Controls.Add(Me.Label8)
        Me.pnl_bill.Controls.Add(Me.Label5)
        Me.pnl_bill.Controls.Add(Me.Label3)
        Me.pnl_bill.Controls.Add(Me.lbl_mode)
        Me.pnl_bill.Controls.Add(Me.cmb_pmode)
        Me.pnl_bill.Controls.Add(Me.lbl_rmcat)
        Me.pnl_bill.Controls.Add(Me.Label32)
        Me.pnl_bill.Controls.Add(Me.lbl_ppl)
        Me.pnl_bill.Controls.Add(Me.Label30)
        Me.pnl_bill.Controls.Add(Me.lbl_tot)
        Me.pnl_bill.Controls.Add(Me.lbl_days)
        Me.pnl_bill.Controls.Add(Me.lbl_chkout)
        Me.pnl_bill.Controls.Add(Me.lbl_chkin)
        Me.pnl_bill.Controls.Add(Me.lbl_rrpn)
        Me.pnl_bill.Controls.Add(Me.lbl_roomno)
        Me.pnl_bill.Controls.Add(Me.lbl_name)
        Me.pnl_bill.Controls.Add(Me.lbl_invc)
        Me.pnl_bill.Controls.Add(Me.lbl_amnt)
        Me.pnl_bill.Controls.Add(Me.txt_Amnt)
        Me.pnl_bill.Controls.Add(Me.rad_pay_advc)
        Me.pnl_bill.Controls.Add(Me.rad_pay_chkt)
        Me.pnl_bill.Controls.Add(Me.Label22)
        Me.pnl_bill.Controls.Add(Me.Label21)
        Me.pnl_bill.Controls.Add(Me.Label20)
        Me.pnl_bill.Controls.Add(Me.Label19)
        Me.pnl_bill.Controls.Add(Me.Label17)
        Me.pnl_bill.Controls.Add(Me.Label16)
        Me.pnl_bill.Controls.Add(Me.Label14)
        Me.pnl_bill.Controls.Add(Me.Label12)
        Me.pnl_bill.Controls.Add(Me.Panel6)
        Me.BunifuTransition1.SetDecoration(Me.pnl_bill, BunifuAnimatorNS.DecorationType.None)
        Me.pnl_bill.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_bill.Location = New System.Drawing.Point(743, 59)
        Me.pnl_bill.Name = "pnl_bill"
        Me.pnl_bill.Size = New System.Drawing.Size(545, 667)
        Me.pnl_bill.TabIndex = 9
        Me.pnl_bill.Visible = False
        '
        'cmb_dis
        '
        Me.cmb_dis.BackColor = System.Drawing.Color.Transparent
        Me.cmb_dis.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmb_dis.BorderThickness = 3
        Me.BunifuTransition1.SetDecoration(Me.cmb_dis, BunifuAnimatorNS.DecorationType.None)
        Me.cmb_dis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_dis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dis.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_dis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_dis.FocusedState.Parent = Me.cmb_dis
        Me.cmb_dis.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_dis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_dis.HoverState.Parent = Me.cmb_dis
        Me.cmb_dis.ItemHeight = 30
        Me.cmb_dis.Items.AddRange(New Object() {"0", "5", "10", "15", "20", "25", "30"})
        Me.cmb_dis.ItemsAppearance.Parent = Me.cmb_dis
        Me.cmb_dis.Location = New System.Drawing.Point(381, 340)
        Me.cmb_dis.Name = "cmb_dis"
        Me.cmb_dis.ShadowDecoration.Parent = Me.cmb_dis
        Me.cmb_dis.Size = New System.Drawing.Size(69, 36)
        Me.cmb_dis.TabIndex = 79
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label18, BunifuAnimatorNS.DecorationType.None)
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(-1, 500)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(748, 22)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(-103, 321)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(748, 22)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(-3, 452)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(748, 22)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(386, 415)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 22)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "@5%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(383, 382)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 22)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "@10%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 22)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Luxry Tax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 382)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 22)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "GST "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 22)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Discount"
        '
        'lbl_mode
        '
        Me.lbl_mode.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_mode, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_mode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mode.ForeColor = System.Drawing.Color.Black
        Me.lbl_mode.Location = New System.Drawing.Point(240, 579)
        Me.lbl_mode.Name = "lbl_mode"
        Me.lbl_mode.Size = New System.Drawing.Size(156, 22)
        Me.lbl_mode.TabIndex = 69
        Me.lbl_mode.Text = "Payament Mode"
        Me.lbl_mode.Visible = False
        '
        'cmb_pmode
        '
        Me.cmb_pmode.BackColor = System.Drawing.Color.Transparent
        Me.cmb_pmode.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmb_pmode.BorderThickness = 3
        Me.BunifuTransition1.SetDecoration(Me.cmb_pmode, BunifuAnimatorNS.DecorationType.None)
        Me.cmb_pmode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_pmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pmode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_pmode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_pmode.FocusedState.Parent = Me.cmb_pmode
        Me.cmb_pmode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_pmode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_pmode.HoverState.Parent = Me.cmb_pmode
        Me.cmb_pmode.ItemHeight = 30
        Me.cmb_pmode.Items.AddRange(New Object() {"Cash", "Card", "Online"})
        Me.cmb_pmode.ItemsAppearance.Parent = Me.cmb_pmode
        Me.cmb_pmode.Location = New System.Drawing.Point(408, 570)
        Me.cmb_pmode.Name = "cmb_pmode"
        Me.cmb_pmode.ShadowDecoration.Parent = Me.cmb_pmode
        Me.cmb_pmode.Size = New System.Drawing.Size(131, 36)
        Me.cmb_pmode.TabIndex = 64
        Me.cmb_pmode.Visible = False
        '
        'lbl_rmcat
        '
        Me.lbl_rmcat.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_rmcat, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_rmcat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rmcat.ForeColor = System.Drawing.Color.Black
        Me.lbl_rmcat.Location = New System.Drawing.Point(384, 157)
        Me.lbl_rmcat.Name = "lbl_rmcat"
        Me.lbl_rmcat.Size = New System.Drawing.Size(46, 22)
        Me.lbl_rmcat.TabIndex = 68
        Me.lbl_rmcat.Text = "------"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label32, BunifuAnimatorNS.DecorationType.None)
        Me.Label32.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(7, 157)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(152, 22)
        Me.Label32.TabIndex = 67
        Me.Label32.Text = "Room Catagory"
        '
        'lbl_ppl
        '
        Me.lbl_ppl.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_ppl, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_ppl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ppl.ForeColor = System.Drawing.Color.Black
        Me.lbl_ppl.Location = New System.Drawing.Point(383, 322)
        Me.lbl_ppl.Name = "lbl_ppl"
        Me.lbl_ppl.Size = New System.Drawing.Size(46, 22)
        Me.lbl_ppl.TabIndex = 66
        Me.lbl_ppl.Text = "------"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label30, BunifuAnimatorNS.DecorationType.None)
        Me.Label30.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(5, 322)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(124, 22)
        Me.Label30.TabIndex = 65
        Me.Label30.Text = "Total People"
        '
        'lbl_tot
        '
        Me.lbl_tot.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_tot, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_tot.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tot.ForeColor = System.Drawing.Color.Black
        Me.lbl_tot.Location = New System.Drawing.Point(383, 478)
        Me.lbl_tot.Name = "lbl_tot"
        Me.lbl_tot.Size = New System.Drawing.Size(46, 22)
        Me.lbl_tot.TabIndex = 61
        Me.lbl_tot.Text = "------"
        '
        'lbl_days
        '
        Me.lbl_days.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_days, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_days.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_days.ForeColor = System.Drawing.Color.Black
        Me.lbl_days.Location = New System.Drawing.Point(383, 289)
        Me.lbl_days.Name = "lbl_days"
        Me.lbl_days.Size = New System.Drawing.Size(46, 22)
        Me.lbl_days.TabIndex = 60
        Me.lbl_days.Text = "------"
        '
        'lbl_chkout
        '
        Me.lbl_chkout.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_chkout, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_chkout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chkout.ForeColor = System.Drawing.Color.Black
        Me.lbl_chkout.Location = New System.Drawing.Point(383, 256)
        Me.lbl_chkout.Name = "lbl_chkout"
        Me.lbl_chkout.Size = New System.Drawing.Size(46, 22)
        Me.lbl_chkout.TabIndex = 59
        Me.lbl_chkout.Text = "------"
        '
        'lbl_chkin
        '
        Me.lbl_chkin.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_chkin, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_chkin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chkin.ForeColor = System.Drawing.Color.Black
        Me.lbl_chkin.Location = New System.Drawing.Point(383, 223)
        Me.lbl_chkin.Name = "lbl_chkin"
        Me.lbl_chkin.Size = New System.Drawing.Size(46, 22)
        Me.lbl_chkin.TabIndex = 58
        Me.lbl_chkin.Text = "------"
        '
        'lbl_rrpn
        '
        Me.lbl_rrpn.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_rrpn, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_rrpn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rrpn.ForeColor = System.Drawing.Color.Black
        Me.lbl_rrpn.Location = New System.Drawing.Point(383, 190)
        Me.lbl_rrpn.Name = "lbl_rrpn"
        Me.lbl_rrpn.Size = New System.Drawing.Size(46, 22)
        Me.lbl_rrpn.TabIndex = 56
        Me.lbl_rrpn.Text = "------"
        '
        'lbl_roomno
        '
        Me.lbl_roomno.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_roomno, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_roomno.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_roomno.ForeColor = System.Drawing.Color.Black
        Me.lbl_roomno.Location = New System.Drawing.Point(383, 124)
        Me.lbl_roomno.Name = "lbl_roomno"
        Me.lbl_roomno.Size = New System.Drawing.Size(46, 22)
        Me.lbl_roomno.TabIndex = 55
        Me.lbl_roomno.Text = "------"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_name, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_name.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_name.Location = New System.Drawing.Point(383, 91)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(46, 22)
        Me.lbl_name.TabIndex = 53
        Me.lbl_name.Text = "------"
        '
        'lbl_invc
        '
        Me.lbl_invc.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_invc, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_invc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invc.ForeColor = System.Drawing.Color.Black
        Me.lbl_invc.Location = New System.Drawing.Point(383, 58)
        Me.lbl_invc.Name = "lbl_invc"
        Me.lbl_invc.Size = New System.Drawing.Size(46, 22)
        Me.lbl_invc.TabIndex = 52
        Me.lbl_invc.Text = "------"
        '
        'lbl_amnt
        '
        Me.lbl_amnt.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbl_amnt, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_amnt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amnt.ForeColor = System.Drawing.Color.Black
        Me.lbl_amnt.Location = New System.Drawing.Point(317, 538)
        Me.lbl_amnt.Name = "lbl_amnt"
        Me.lbl_amnt.Size = New System.Drawing.Size(81, 22)
        Me.lbl_amnt.TabIndex = 51
        Me.lbl_amnt.Text = "Amount"
        Me.lbl_amnt.Visible = False
        '
        'txt_Amnt
        '
        Me.txt_Amnt.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Amnt.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Amnt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_Amnt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Amnt.BorderThickness = 3
        Me.txt_Amnt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.txt_Amnt, BunifuAnimatorNS.DecorationType.None)
        Me.txt_Amnt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_Amnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Amnt.isPassword = False
        Me.txt_Amnt.Location = New System.Drawing.Point(405, 527)
        Me.txt_Amnt.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Amnt.Name = "txt_Amnt"
        Me.txt_Amnt.Size = New System.Drawing.Size(134, 36)
        Me.txt_Amnt.TabIndex = 39
        Me.txt_Amnt.Text = "00.00"
        Me.txt_Amnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Amnt.Visible = False
        '
        'rad_pay_advc
        '
        Me.rad_pay_advc.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.rad_pay_advc, BunifuAnimatorNS.DecorationType.None)
        Me.rad_pay_advc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_pay_advc.Location = New System.Drawing.Point(7, 570)
        Me.rad_pay_advc.Name = "rad_pay_advc"
        Me.rad_pay_advc.Size = New System.Drawing.Size(172, 26)
        Me.rad_pay_advc.TabIndex = 50
        Me.rad_pay_advc.TabStop = True
        Me.rad_pay_advc.Text = "Pay In Advance"
        Me.rad_pay_advc.UseVisualStyleBackColor = True
        '
        'rad_pay_chkt
        '
        Me.rad_pay_chkt.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.rad_pay_chkt, BunifuAnimatorNS.DecorationType.None)
        Me.rad_pay_chkt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_pay_chkt.Location = New System.Drawing.Point(7, 530)
        Me.rad_pay_chkt.Name = "rad_pay_chkt"
        Me.rad_pay_chkt.Size = New System.Drawing.Size(192, 26)
        Me.rad_pay_chkt.TabIndex = 49
        Me.rad_pay_chkt.TabStop = True
        Me.rad_pay_chkt.Text = "Pay At Check Out"
        Me.rad_pay_chkt.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
        Me.Label22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(7, 478)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 22)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Total"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label21, BunifuAnimatorNS.DecorationType.None)
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(6, 289)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 22)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Days "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label20, BunifuAnimatorNS.DecorationType.None)
        Me.Label20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(6, 256)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(154, 22)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Check Out Date"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label19, BunifuAnimatorNS.DecorationType.None)
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(6, 223)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 22)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Check In Date"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(6, 190)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(202, 22)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Room Rate Per Night"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 22)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Room No."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(6, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(157, 22)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Customer Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 22)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Invoice No."
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Panel6.Controls.Add(Me.btn_save)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.BunifuTransition1.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(543, 47)
        Me.Panel6.TabIndex = 22
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.btn_save, BunifuAnimatorNS.DecorationType.None)
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(477, 0)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(68, 47)
        Me.btn_save.TabIndex = 1
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(245, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 38)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Bill"
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'Guna2ContextMenuStrip1
        '
        Me.BunifuTransition1.SetDecoration(Me.Guna2ContextMenuStrip1, BunifuAnimatorNS.DecorationType.None)
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Guna2ContextMenuStrip2
        '
        Me.BunifuTransition1.SetDecoration(Me.Guna2ContextMenuStrip2, BunifuAnimatorNS.DecorationType.None)
        Me.Guna2ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2"
        Me.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'Book_Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 726)
        Me.Controls.Add(Me.pnl_bill)
        Me.Controls.Add(Me.pnl_details)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Book_Room"
        Me.Text = "Book_Room"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.HItemBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.THE_SHIV_GRANDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nud_mbrs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_details.ResumeLayout(False)
        Me.pnl_details.PerformLayout()
        Me.pnl_bill.ResumeLayout(False)
        Me.pnl_bill.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.HItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents HItemBindingSource As BindingSource
    Friend WithEvents H_ItemTableAdapter As THE_SHIV_GRANDDataSetTableAdapters.H_ItemTableAdapter
    Friend WithEvents HItemBindingSource1 As BindingSource
    Friend WithEvents THE_SHIV_GRANDDataSet1 As THE_SHIV_GRANDDataSet1
    Friend WithEvents HItemBindingSource2 As BindingSource
    Friend WithEvents H_ItemTableAdapter1 As THE_SHIV_GRANDDataSet1TableAdapters.H_ItemTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_to As Label
    Friend WithEvents lbl_frm As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_rmtp As Label
    Friend WithEvents pnl_details As Panel
    Friend WithEvents btn_slctrm As Button
    Friend WithEvents lbl_rate As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_rms As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_fndrm As Button
    Friend WithEvents btn_srch As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_htl_ctct As Label
    Friend WithEvents pnl_bill As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_genbill As Button
    Friend WithEvents lbl_mem3 As Label
    Friend WithEvents lbl_mem2 As Label
    Friend WithEvents lbl_mem1 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_amnt As Label
    Friend WithEvents txt_Amnt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents rad_pay_advc As RadioButton
    Friend WithEvents rad_pay_chkt As RadioButton
    Friend WithEvents lbl_tot As Label
    Friend WithEvents lbl_days As Label
    Friend WithEvents lbl_chkout As Label
    Friend WithEvents lbl_chkin As Label
    Friend WithEvents lbl_rrpn As Label
    Friend WithEvents lbl_roomno As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_invc As Label
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents nud_mbrs As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents lbl_mbrs As Label
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Guna2ContextMenuStrip2 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents txt_cctct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_cname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents lbl_ppl As Label
    Friend WithEvents lbl_rmcat As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_mem1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_mem2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_mem3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents cmb_cpcty As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_rmtp As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_rmno As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lbl_nat1 As Label
    Friend WithEvents cmb_nat_m1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lbl_nat4 As Label
    Friend WithEvents cmb_nat_m4 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_mem4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_mem4 As Label
    Friend WithEvents lbl_nat3 As Label
    Friend WithEvents cmb_nat_m3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lbl_nat2 As Label
    Friend WithEvents cmb_nat_m2 As Guna.UI2.WinForms.Guna2ComboBox

    Private Sub txt_mem1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Friend WithEvents lbl_mode As Label
    Friend WithEvents cmb_pmode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label



    Friend WithEvents cmb_dis As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents drp_frm As DateTimePicker
    Friend WithEvents drp_to As DateTimePicker
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
