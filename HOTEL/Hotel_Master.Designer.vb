<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hotel_Master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hotel_Master))
        Me.pnl_head = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btn_rfrsh = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_htl_tgln = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_htl_tgln = New System.Windows.Forms.Label()
        Me.txt_htl_gst = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_htl_gst = New System.Windows.Forms.Label()
        Me.txt_htl_id = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_htl_id = New System.Windows.Forms.Label()
        Me.txt_htl_ctct = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_htl_ctct = New System.Windows.Forms.Label()
        Me.txt_htl_addr = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_htl_addr = New System.Windows.Forms.Label()
        Me.txt_htl_name = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_htk_name = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_head.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_head
        '
        Me.pnl_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.pnl_head.Controls.Add(Me.Panel1)
        Me.pnl_head.Controls.Add(Me.Button1)
        Me.pnl_head.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_head.Location = New System.Drawing.Point(0, 0)
        Me.pnl_head.Name = "pnl_head"
        Me.pnl_head.Size = New System.Drawing.Size(1288, 59)
        Me.pnl_head.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1288, 59)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1288, 59)
        Me.Panel2.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(1223, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 59)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1223, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 59)
        Me.Button2.TabIndex = 0
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1223, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 59)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_rfrsh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_edit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_update)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_htl_tgln)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_htl_tgln)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_htl_gst)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_htl_gst)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_htl_id)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_htl_id)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_htl_ctct)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_htl_ctct)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_htl_addr)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_htl_addr)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_htl_name)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_htk_name)
        Me.SplitContainer1.Size = New System.Drawing.Size(1288, 667)
        Me.SplitContainer1.SplitterDistance = 154
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 6
        '
        'btn_rfrsh
        '
        Me.btn_rfrsh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btn_rfrsh.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_rfrsh.FlatAppearance.BorderSize = 0
        Me.btn_rfrsh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_rfrsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rfrsh.Image = CType(resources.GetObject("btn_rfrsh.Image"), System.Drawing.Image)
        Me.btn_rfrsh.Location = New System.Drawing.Point(0, 272)
        Me.btn_rfrsh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_rfrsh.Name = "btn_rfrsh"
        Me.btn_rfrsh.Size = New System.Drawing.Size(154, 136)
        Me.btn_rfrsh.TabIndex = 22
        Me.btn_rfrsh.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btn_edit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.Location = New System.Drawing.Point(0, 136)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(154, 136)
        Me.btn_edit.TabIndex = 22
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btn_update.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.Location = New System.Drawing.Point(0, 0)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(154, 136)
        Me.btn_update.TabIndex = 21
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'txt_htl_tgln
        '
        Me.txt_htl_tgln.BackColor = System.Drawing.SystemColors.Window
        Me.txt_htl_tgln.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_tgln.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_htl_tgln.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_tgln.BorderThickness = 3
        Me.txt_htl_tgln.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_htl_tgln.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_htl_tgln.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_tgln.isPassword = False
        Me.txt_htl_tgln.Location = New System.Drawing.Point(332, 121)
        Me.txt_htl_tgln.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_htl_tgln.Name = "txt_htl_tgln"
        Me.txt_htl_tgln.Size = New System.Drawing.Size(280, 44)
        Me.txt_htl_tgln.TabIndex = 33
        Me.txt_htl_tgln.TabStop = False
        Me.txt_htl_tgln.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_htl_tgln
        '
        Me.lbl_htl_tgln.AutoSize = True
        Me.lbl_htl_tgln.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_htl_tgln.ForeColor = System.Drawing.Color.Black
        Me.lbl_htl_tgln.Location = New System.Drawing.Point(328, 95)
        Me.lbl_htl_tgln.Name = "lbl_htl_tgln"
        Me.lbl_htl_tgln.Size = New System.Drawing.Size(130, 22)
        Me.lbl_htl_tgln.TabIndex = 32
        Me.lbl_htl_tgln.Text = "Hotel Tagline"
        '
        'txt_htl_gst
        '
        Me.txt_htl_gst.BackColor = System.Drawing.SystemColors.Window
        Me.txt_htl_gst.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_gst.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_htl_gst.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_gst.BorderThickness = 3
        Me.txt_htl_gst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_htl_gst.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_htl_gst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_gst.isPassword = False
        Me.txt_htl_gst.Location = New System.Drawing.Point(332, 27)
        Me.txt_htl_gst.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_htl_gst.Name = "txt_htl_gst"
        Me.txt_htl_gst.Size = New System.Drawing.Size(280, 44)
        Me.txt_htl_gst.TabIndex = 31
        Me.txt_htl_gst.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_htl_gst
        '
        Me.lbl_htl_gst.AutoSize = True
        Me.lbl_htl_gst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_htl_gst.ForeColor = System.Drawing.Color.Black
        Me.lbl_htl_gst.Location = New System.Drawing.Point(328, 1)
        Me.lbl_htl_gst.Name = "lbl_htl_gst"
        Me.lbl_htl_gst.Size = New System.Drawing.Size(86, 22)
        Me.lbl_htl_gst.TabIndex = 30
        Me.lbl_htl_gst.Text = "GST No."
        '
        'txt_htl_id
        '
        Me.txt_htl_id.BackColor = System.Drawing.SystemColors.Window
        Me.txt_htl_id.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_id.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_htl_id.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_id.BorderThickness = 3
        Me.txt_htl_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_htl_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_htl_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_id.isPassword = False
        Me.txt_htl_id.Location = New System.Drawing.Point(332, 220)
        Me.txt_htl_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_htl_id.Name = "txt_htl_id"
        Me.txt_htl_id.Size = New System.Drawing.Size(280, 44)
        Me.txt_htl_id.TabIndex = 29
        Me.txt_htl_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_htl_id
        '
        Me.lbl_htl_id.AutoSize = True
        Me.lbl_htl_id.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_htl_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_htl_id.Location = New System.Drawing.Point(328, 194)
        Me.lbl_htl_id.Name = "lbl_htl_id"
        Me.lbl_htl_id.Size = New System.Drawing.Size(87, 22)
        Me.lbl_htl_id.TabIndex = 28
        Me.lbl_htl_id.Text = "Email-ID"
        '
        'txt_htl_ctct
        '
        Me.txt_htl_ctct.BackColor = System.Drawing.SystemColors.Window
        Me.txt_htl_ctct.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_ctct.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_htl_ctct.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_ctct.BorderThickness = 3
        Me.txt_htl_ctct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_htl_ctct.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_htl_ctct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_ctct.isPassword = False
        Me.txt_htl_ctct.Location = New System.Drawing.Point(20, 121)
        Me.txt_htl_ctct.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_htl_ctct.Name = "txt_htl_ctct"
        Me.txt_htl_ctct.Size = New System.Drawing.Size(280, 44)
        Me.txt_htl_ctct.TabIndex = 27
        Me.txt_htl_ctct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_htl_ctct
        '
        Me.lbl_htl_ctct.AutoSize = True
        Me.lbl_htl_ctct.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_htl_ctct.ForeColor = System.Drawing.Color.Black
        Me.lbl_htl_ctct.Location = New System.Drawing.Point(16, 95)
        Me.lbl_htl_ctct.Name = "lbl_htl_ctct"
        Me.lbl_htl_ctct.Size = New System.Drawing.Size(135, 22)
        Me.lbl_htl_ctct.TabIndex = 26
        Me.lbl_htl_ctct.Text = "Hotel Contact"
        '
        'txt_htl_addr
        '
        Me.txt_htl_addr.BackColor = System.Drawing.SystemColors.Window
        Me.txt_htl_addr.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_addr.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_htl_addr.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_addr.BorderThickness = 3
        Me.txt_htl_addr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_htl_addr.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_htl_addr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_addr.isPassword = False
        Me.txt_htl_addr.Location = New System.Drawing.Point(20, 220)
        Me.txt_htl_addr.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_htl_addr.Name = "txt_htl_addr"
        Me.txt_htl_addr.Size = New System.Drawing.Size(280, 88)
        Me.txt_htl_addr.TabIndex = 25
        Me.txt_htl_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_htl_addr
        '
        Me.lbl_htl_addr.AutoSize = True
        Me.lbl_htl_addr.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_htl_addr.ForeColor = System.Drawing.Color.Black
        Me.lbl_htl_addr.Location = New System.Drawing.Point(16, 194)
        Me.lbl_htl_addr.Name = "lbl_htl_addr"
        Me.lbl_htl_addr.Size = New System.Drawing.Size(140, 22)
        Me.lbl_htl_addr.TabIndex = 24
        Me.lbl_htl_addr.Text = "Hotel Address"
        '
        'txt_htl_name
        '
        Me.txt_htl_name.BackColor = System.Drawing.SystemColors.Window
        Me.txt_htl_name.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_name.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txt_htl_name.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_name.BorderThickness = 3
        Me.txt_htl_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_htl_name.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_htl_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_htl_name.isPassword = False
        Me.txt_htl_name.Location = New System.Drawing.Point(20, 27)
        Me.txt_htl_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_htl_name.Name = "txt_htl_name"
        Me.txt_htl_name.Size = New System.Drawing.Size(280, 44)
        Me.txt_htl_name.TabIndex = 12
        Me.txt_htl_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_htk_name
        '
        Me.lbl_htk_name.AutoSize = True
        Me.lbl_htk_name.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_htk_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_htk_name.Location = New System.Drawing.Point(16, 1)
        Me.lbl_htk_name.Name = "lbl_htk_name"
        Me.lbl_htk_name.Size = New System.Drawing.Size(116, 22)
        Me.lbl_htk_name.TabIndex = 6
        Me.lbl_htk_name.Text = "Hotel Name"
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
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(438, 10)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(423, 38)
        Me.Guna2HtmlLabel2.TabIndex = 23
        Me.Guna2HtmlLabel2.Text = "Hotel Shiv Grand - Hotel Master"
        '
        'Hotel_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 726)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnl_head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Hotel_Master"
        Me.Text = "Hotel_Master"
        Me.pnl_head.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_head As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btn_rfrsh As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_htl_tgln As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_htl_tgln As Label
    Friend WithEvents txt_htl_gst As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_htl_gst As Label
    Friend WithEvents txt_htl_id As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_htl_id As Label
    Friend WithEvents txt_htl_ctct As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_htl_ctct As Label
    Friend WithEvents txt_htl_addr As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_htl_addr As Label
    Friend WithEvents txt_htl_name As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_htk_name As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
