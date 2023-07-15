<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Master
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_Master))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_cname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_cname = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txt_cid = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_cid = New System.Windows.Forms.Label()
        Me.txt_cmail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_cmail = New System.Windows.Forms.Label()
        Me.txt_cctct = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_cctct = New System.Windows.Forms.Label()
        Me.txt_cadar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_cadar = New System.Windows.Forms.Label()
        Me.dgv_cus_mst = New System.Windows.Forms.DataGridView()
        Me.C_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnl_head = New System.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv_cus_mst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_head.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Pencil-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "database-arrow-up-icon.png")
        '
        'txt_cname
        '
        Me.txt_cname.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cname.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cname.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cname.BorderThickness = 3
        Me.txt_cname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cname.isPassword = False
        Me.txt_cname.Location = New System.Drawing.Point(20, 34)
        Me.txt_cname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.Size = New System.Drawing.Size(280, 44)
        Me.txt_cname.TabIndex = 12
        Me.txt_cname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_cname
        '
        Me.lbl_cname.AutoSize = True
        Me.lbl_cname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cname.ForeColor = System.Drawing.Color.Black
        Me.lbl_cname.Location = New System.Drawing.Point(16, 8)
        Me.lbl_cname.Name = "lbl_cname"
        Me.lbl_cname.Size = New System.Drawing.Size(157, 22)
        Me.lbl_cname.TabIndex = 6
        Me.lbl_cname.Text = "Customer Name"
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_refresh.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_refresh.FlatAppearance.BorderSize = 0
        Me.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Image = CType(resources.GetObject("btn_refresh.Image"), System.Drawing.Image)
        Me.btn_refresh.Location = New System.Drawing.Point(0, 408)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(154, 136)
        Me.btn_refresh.TabIndex = 22
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_clear.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(0, 272)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(154, 136)
        Me.btn_clear.TabIndex = 23
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.Location = New System.Drawing.Point(0, 136)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(154, 136)
        Me.btn_edit.TabIndex = 22
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_add.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(0, 0)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(154, 136)
        Me.btn_add.TabIndex = 21
        Me.btn_add.UseVisualStyleBackColor = False
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_refresh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_clear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_edit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_add)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_cid)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_cid)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_cmail)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_cmail)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_cctct)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_cctct)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_cadar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_cadar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv_cus_mst)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_cname)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_cname)
        Me.SplitContainer1.Size = New System.Drawing.Size(1288, 667)
        Me.SplitContainer1.SplitterDistance = 154
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 5
        '
        'txt_cid
        '
        Me.txt_cid.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cid.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cid.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cid.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cid.BorderThickness = 3
        Me.txt_cid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cid.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cid.isPassword = False
        Me.txt_cid.Location = New System.Drawing.Point(596, 127)
        Me.txt_cid.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cid.Name = "txt_cid"
        Me.txt_cid.Size = New System.Drawing.Size(280, 44)
        Me.txt_cid.TabIndex = 33
        Me.txt_cid.TabStop = False
        Me.txt_cid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cid.Visible = False
        '
        'lbl_cid
        '
        Me.lbl_cid.AutoSize = True
        Me.lbl_cid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cid.ForeColor = System.Drawing.Color.Black
        Me.lbl_cid.Location = New System.Drawing.Point(592, 101)
        Me.lbl_cid.Name = "lbl_cid"
        Me.lbl_cid.Size = New System.Drawing.Size(127, 22)
        Me.lbl_cid.TabIndex = 32
        Me.lbl_cid.Text = "Customer_Id"
        Me.lbl_cid.Visible = False
        '
        'txt_cmail
        '
        Me.txt_cmail.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cmail.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cmail.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cmail.BorderThickness = 3
        Me.txt_cmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cmail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cmail.isPassword = False
        Me.txt_cmail.Location = New System.Drawing.Point(308, 127)
        Me.txt_cmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cmail.Name = "txt_cmail"
        Me.txt_cmail.Size = New System.Drawing.Size(280, 44)
        Me.txt_cmail.TabIndex = 29
        Me.txt_cmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_cmail
        '
        Me.lbl_cmail.AutoSize = True
        Me.lbl_cmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cmail.ForeColor = System.Drawing.Color.Black
        Me.lbl_cmail.Location = New System.Drawing.Point(304, 101)
        Me.lbl_cmail.Name = "lbl_cmail"
        Me.lbl_cmail.Size = New System.Drawing.Size(155, 22)
        Me.lbl_cmail.TabIndex = 28
        Me.lbl_cmail.Text = "Customer Email"
        '
        'txt_cctct
        '
        Me.txt_cctct.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cctct.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cctct.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cctct.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cctct.BorderThickness = 3
        Me.txt_cctct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cctct.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cctct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cctct.isPassword = False
        Me.txt_cctct.Location = New System.Drawing.Point(308, 34)
        Me.txt_cctct.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cctct.Name = "txt_cctct"
        Me.txt_cctct.Size = New System.Drawing.Size(280, 44)
        Me.txt_cctct.TabIndex = 27
        Me.txt_cctct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_cctct
        '
        Me.lbl_cctct.AutoSize = True
        Me.lbl_cctct.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cctct.ForeColor = System.Drawing.Color.Black
        Me.lbl_cctct.Location = New System.Drawing.Point(304, 8)
        Me.lbl_cctct.Name = "lbl_cctct"
        Me.lbl_cctct.Size = New System.Drawing.Size(212, 22)
        Me.lbl_cctct.TabIndex = 26
        Me.lbl_cctct.Text = "Customer Contact No."
        '
        'txt_cadar
        '
        Me.txt_cadar.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cadar.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cadar.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cadar.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cadar.BorderThickness = 3
        Me.txt_cadar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cadar.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_cadar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_cadar.isPassword = False
        Me.txt_cadar.Location = New System.Drawing.Point(20, 127)
        Me.txt_cadar.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_cadar.Name = "txt_cadar"
        Me.txt_cadar.Size = New System.Drawing.Size(280, 72)
        Me.txt_cadar.TabIndex = 25
        Me.txt_cadar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_cadar
        '
        Me.lbl_cadar.AutoSize = True
        Me.lbl_cadar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cadar.ForeColor = System.Drawing.Color.Black
        Me.lbl_cadar.Location = New System.Drawing.Point(16, 101)
        Me.lbl_cadar.Name = "lbl_cadar"
        Me.lbl_cadar.Size = New System.Drawing.Size(181, 22)
        Me.lbl_cadar.TabIndex = 24
        Me.lbl_cadar.Text = "Customer Address"
        '
        'dgv_cus_mst
        '
        Me.dgv_cus_mst.AllowUserToAddRows = False
        Me.dgv_cus_mst.AllowUserToDeleteRows = False
        Me.dgv_cus_mst.AllowUserToResizeColumns = False
        Me.dgv_cus_mst.AllowUserToResizeRows = False
        Me.dgv_cus_mst.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_cus_mst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_cus_mst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_cus_mst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_cus_mst.ColumnHeadersHeight = 30
        Me.dgv_cus_mst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_cus_mst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_Id, Me.C_Name, Me.C_Address, Me.C_Contact, Me.C_Email})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_cus_mst.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_cus_mst.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_cus_mst.EnableHeadersVisualStyles = False
        Me.dgv_cus_mst.GridColor = System.Drawing.SystemColors.Control
        Me.dgv_cus_mst.Location = New System.Drawing.Point(0, 207)
        Me.dgv_cus_mst.MultiSelect = False
        Me.dgv_cus_mst.Name = "dgv_cus_mst"
        Me.dgv_cus_mst.ReadOnly = True
        Me.dgv_cus_mst.RowHeadersVisible = False
        Me.dgv_cus_mst.RowHeadersWidth = 51
        Me.dgv_cus_mst.RowTemplate.Height = 24
        Me.dgv_cus_mst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cus_mst.Size = New System.Drawing.Size(1133, 460)
        Me.dgv_cus_mst.TabIndex = 23
        '
        'C_Id
        '
        Me.C_Id.DataPropertyName = "C_Id"
        Me.C_Id.HeaderText = "ID"
        Me.C_Id.MinimumWidth = 6
        Me.C_Id.Name = "C_Id"
        Me.C_Id.ReadOnly = True
        Me.C_Id.Visible = False
        Me.C_Id.Width = 150
        '
        'C_Name
        '
        Me.C_Name.DataPropertyName = "C_Name"
        Me.C_Name.HeaderText = "Name"
        Me.C_Name.MinimumWidth = 6
        Me.C_Name.Name = "C_Name"
        Me.C_Name.ReadOnly = True
        Me.C_Name.Width = 190
        '
        'C_Address
        '
        Me.C_Address.DataPropertyName = "C_Address"
        Me.C_Address.HeaderText = "Address"
        Me.C_Address.MinimumWidth = 6
        Me.C_Address.Name = "C_Address"
        Me.C_Address.ReadOnly = True
        Me.C_Address.Width = 350
        '
        'C_Contact
        '
        Me.C_Contact.DataPropertyName = "C_Contact"
        Me.C_Contact.HeaderText = "Contact"
        Me.C_Contact.MinimumWidth = 6
        Me.C_Contact.Name = "C_Contact"
        Me.C_Contact.ReadOnly = True
        Me.C_Contact.Width = 150
        '
        'C_Email
        '
        Me.C_Email.DataPropertyName = "C_Email"
        Me.C_Email.HeaderText = "E-Mail"
        Me.C_Email.MinimumWidth = 6
        Me.C_Email.Name = "C_Email"
        Me.C_Email.ReadOnly = True
        Me.C_Email.Width = 240
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1223, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pnl_head
        '
        Me.pnl_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.pnl_head.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnl_head.Controls.Add(Me.Button1)
        Me.pnl_head.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_head.Location = New System.Drawing.Point(0, 0)
        Me.pnl_head.Name = "pnl_head"
        Me.pnl_head.Size = New System.Drawing.Size(1288, 59)
        Me.pnl_head.TabIndex = 4
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnl_head
        Me.BunifuDragControl1.Vertical = True
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(433, 10)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(481, 38)
        Me.Guna2HtmlLabel2.TabIndex = 24
        Me.Guna2HtmlLabel2.Text = "Hotel Shiv Grand - Customer Master"
        '
        'Customer_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 726)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnl_head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customer_Master"
        Me.Text = "Customer_Master"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv_cus_mst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_head.ResumeLayout(False)
        Me.pnl_head.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txt_cname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_cname As Label
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnl_head As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents dgv_cus_mst As DataGridView
    Friend WithEvents txt_cid As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_cid As Label
    Friend WithEvents txt_cmail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_cmail As Label
    Friend WithEvents txt_cctct As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_cctct As Label
    Friend WithEvents txt_cadar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_cadar As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents C_Id As DataGridViewTextBoxColumn
    Friend WithEvents C_Name As DataGridViewTextBoxColumn
    Friend WithEvents C_Address As DataGridViewTextBoxColumn
    Friend WithEvents C_Contact As DataGridViewTextBoxColumn
    Friend WithEvents C_Email As DataGridViewTextBoxColumn
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
