<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Room_Master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Room_Master))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_head = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cmb_rmcp = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_rmtp = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dgv_rm_mst = New System.Windows.Forms.DataGridView()
        Me.Room_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room_Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Capacity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ROW_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_rmno = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_rmno = New System.Windows.Forms.Label()
        Me.lbl_rmtp = New System.Windows.Forms.Label()
        Me.lbl_rmrt = New System.Windows.Forms.Label()
        Me.txt_rmrt = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl_rmcp = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnl_head.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv_rm_mst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pnl_head.TabIndex = 2
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(404, 10)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(481, 38)
        Me.Guna2HtmlLabel2.TabIndex = 25
        Me.Guna2HtmlLabel2.Text = "Hotel Shiv Grand - Customer Master"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1224, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmb_rmcp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmb_rmtp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv_rm_mst)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_rmno)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_rmno)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_rmtp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_rmrt)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_rmrt)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_rmcp)
        Me.SplitContainer1.Size = New System.Drawing.Size(1288, 714)
        Me.SplitContainer1.SplitterDistance = 154
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 3
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_refresh.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_refresh.FlatAppearance.BorderSize = 0
        Me.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_clear.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_edit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_add.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.Location = New System.Drawing.Point(0, 0)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(154, 136)
        Me.btn_add.TabIndex = 21
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'cmb_rmcp
        '
        Me.cmb_rmcp.BackColor = System.Drawing.Color.Transparent
        Me.cmb_rmcp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.cmb_rmcp.BorderThickness = 3
        Me.cmb_rmcp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_rmcp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rmcp.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_rmcp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_rmcp.FocusedState.Parent = Me.cmb_rmcp
        Me.cmb_rmcp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_rmcp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_rmcp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_rmcp.HoverState.Parent = Me.cmb_rmcp
        Me.cmb_rmcp.ItemHeight = 30
        Me.cmb_rmcp.Items.AddRange(New Object() {"1", "2", "4"})
        Me.cmb_rmcp.ItemsAppearance.Parent = Me.cmb_rmcp
        Me.cmb_rmcp.Location = New System.Drawing.Point(315, 132)
        Me.cmb_rmcp.Name = "cmb_rmcp"
        Me.cmb_rmcp.ShadowDecoration.Parent = Me.cmb_rmcp
        Me.cmb_rmcp.Size = New System.Drawing.Size(304, 36)
        Me.cmb_rmcp.TabIndex = 23
        '
        'cmb_rmtp
        '
        Me.cmb_rmtp.BackColor = System.Drawing.Color.Transparent
        Me.cmb_rmtp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.cmb_rmtp.BorderThickness = 3
        Me.cmb_rmtp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_rmtp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rmtp.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_rmtp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_rmtp.FocusedState.Parent = Me.cmb_rmtp
        Me.cmb_rmtp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_rmtp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_rmtp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cmb_rmtp.HoverState.Parent = Me.cmb_rmtp
        Me.cmb_rmtp.ItemHeight = 30
        Me.cmb_rmtp.Items.AddRange(New Object() {"Normal", "Delux", "Super Delux"})
        Me.cmb_rmtp.ItemsAppearance.Parent = Me.cmb_rmtp
        Me.cmb_rmtp.Location = New System.Drawing.Point(315, 34)
        Me.cmb_rmtp.Name = "cmb_rmtp"
        Me.cmb_rmtp.ShadowDecoration.Parent = Me.cmb_rmtp
        Me.cmb_rmtp.Size = New System.Drawing.Size(304, 36)
        Me.cmb_rmtp.TabIndex = 22
        '
        'dgv_rm_mst
        '
        Me.dgv_rm_mst.AllowUserToAddRows = False
        Me.dgv_rm_mst.AllowUserToDeleteRows = False
        Me.dgv_rm_mst.AllowUserToResizeColumns = False
        Me.dgv_rm_mst.AllowUserToResizeRows = False
        Me.dgv_rm_mst.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_rm_mst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_rm_mst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_rm_mst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_rm_mst.ColumnHeadersHeight = 30
        Me.dgv_rm_mst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_rm_mst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Room_No, Me.Room_Type, Me.Room_Rate, Me.Capacity, Me.ROW_ID})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_rm_mst.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_rm_mst.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_rm_mst.EnableHeadersVisualStyles = False
        Me.dgv_rm_mst.Location = New System.Drawing.Point(0, 211)
        Me.dgv_rm_mst.MultiSelect = False
        Me.dgv_rm_mst.Name = "dgv_rm_mst"
        Me.dgv_rm_mst.ReadOnly = True
        Me.dgv_rm_mst.RowHeadersVisible = False
        Me.dgv_rm_mst.RowHeadersWidth = 51
        Me.dgv_rm_mst.RowTemplate.Height = 24
        Me.dgv_rm_mst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_rm_mst.ShowCellToolTips = False
        Me.dgv_rm_mst.Size = New System.Drawing.Size(1133, 503)
        Me.dgv_rm_mst.TabIndex = 21
        '
        'Room_No
        '
        Me.Room_No.DataPropertyName = "Room_No"
        Me.Room_No.Frozen = True
        Me.Room_No.HeaderText = "Room No."
        Me.Room_No.MinimumWidth = 6
        Me.Room_No.Name = "Room_No"
        Me.Room_No.ReadOnly = True
        Me.Room_No.Width = 125
        '
        'Room_Type
        '
        Me.Room_Type.DataPropertyName = "Room_Type"
        Me.Room_Type.Frozen = True
        Me.Room_Type.HeaderText = "Catagory"
        Me.Room_Type.MinimumWidth = 6
        Me.Room_Type.Name = "Room_Type"
        Me.Room_Type.ReadOnly = True
        Me.Room_Type.Width = 195
        '
        'Room_Rate
        '
        Me.Room_Rate.DataPropertyName = "Room_Rate"
        Me.Room_Rate.Frozen = True
        Me.Room_Rate.HeaderText = "Price Per Night"
        Me.Room_Rate.MinimumWidth = 6
        Me.Room_Rate.Name = "Room_Rate"
        Me.Room_Rate.ReadOnly = True
        Me.Room_Rate.Width = 175
        '
        'Capacity
        '
        Me.Capacity.DataPropertyName = "Capacity"
        Me.Capacity.Frozen = True
        Me.Capacity.HeaderText = "Room Capacity"
        Me.Capacity.MinimumWidth = 6
        Me.Capacity.Name = "Capacity"
        Me.Capacity.ReadOnly = True
        Me.Capacity.Width = 200
        '
        'ROW_ID
        '
        Me.ROW_ID.DataPropertyName = "Col_Id"
        Me.ROW_ID.Frozen = True
        Me.ROW_ID.HeaderText = "ROW_ID"
        Me.ROW_ID.MinimumWidth = 6
        Me.ROW_ID.Name = "ROW_ID"
        Me.ROW_ID.ReadOnly = True
        Me.ROW_ID.Visible = False
        Me.ROW_ID.Width = 125
        '
        'txt_rmno
        '
        Me.txt_rmno.BackColor = System.Drawing.SystemColors.Window
        Me.txt_rmno.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_rmno.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.txt_rmno.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_rmno.BorderThickness = 3
        Me.txt_rmno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_rmno.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_rmno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_rmno.isPassword = False
        Me.txt_rmno.Location = New System.Drawing.Point(20, 34)
        Me.txt_rmno.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rmno.Name = "txt_rmno"
        Me.txt_rmno.Size = New System.Drawing.Size(280, 44)
        Me.txt_rmno.TabIndex = 12
        Me.txt_rmno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_rmno
        '
        Me.lbl_rmno.AutoSize = True
        Me.lbl_rmno.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rmno.ForeColor = System.Drawing.Color.Black
        Me.lbl_rmno.Location = New System.Drawing.Point(26, 4)
        Me.lbl_rmno.Name = "lbl_rmno"
        Me.lbl_rmno.Size = New System.Drawing.Size(99, 22)
        Me.lbl_rmno.TabIndex = 6
        Me.lbl_rmno.Text = "Room No."
        '
        'lbl_rmtp
        '
        Me.lbl_rmtp.AutoSize = True
        Me.lbl_rmtp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.lbl_rmtp.ForeColor = System.Drawing.Color.Black
        Me.lbl_rmtp.Location = New System.Drawing.Point(303, 4)
        Me.lbl_rmtp.Name = "lbl_rmtp"
        Me.lbl_rmtp.Size = New System.Drawing.Size(113, 22)
        Me.lbl_rmtp.TabIndex = 10
        Me.lbl_rmtp.Text = "Room Type"
        '
        'lbl_rmrt
        '
        Me.lbl_rmrt.AutoSize = True
        Me.lbl_rmrt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.lbl_rmrt.ForeColor = System.Drawing.Color.Black
        Me.lbl_rmrt.Location = New System.Drawing.Point(26, 106)
        Me.lbl_rmrt.Name = "lbl_rmrt"
        Me.lbl_rmrt.Size = New System.Drawing.Size(211, 22)
        Me.lbl_rmrt.TabIndex = 13
        Me.lbl_rmrt.Text = "Room Rate(Per Night)"
        '
        'txt_rmrt
        '
        Me.txt_rmrt.BackColor = System.Drawing.SystemColors.Window
        Me.txt_rmrt.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_rmrt.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.txt_rmrt.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_rmrt.BorderThickness = 3
        Me.txt_rmrt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_rmrt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_rmrt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_rmrt.isPassword = False
        Me.txt_rmrt.Location = New System.Drawing.Point(20, 132)
        Me.txt_rmrt.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rmrt.Name = "txt_rmrt"
        Me.txt_rmrt.Size = New System.Drawing.Size(280, 44)
        Me.txt_rmrt.TabIndex = 14
        Me.txt_rmrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl_rmcp
        '
        Me.lbl_rmcp.AutoSize = True
        Me.lbl_rmcp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.lbl_rmcp.ForeColor = System.Drawing.Color.Black
        Me.lbl_rmcp.Location = New System.Drawing.Point(303, 106)
        Me.lbl_rmcp.Name = "lbl_rmcp"
        Me.lbl_rmcp.Size = New System.Drawing.Size(149, 22)
        Me.lbl_rmcp.TabIndex = 15
        Me.lbl_rmcp.Text = "Room Capacity"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Pencil-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "database-arrow-up-icon.png")
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnl_head
        Me.BunifuDragControl1.Vertical = True
        '
        'Room_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 773)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnl_head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Room_Master"
        Me.Text = "Room_Master"
        Me.pnl_head.ResumeLayout(False)
        Me.pnl_head.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv_rm_mst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_head As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txt_rmno As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_rmtp As Label
    Friend WithEvents lbl_rmno As Label
    Friend WithEvents lbl_rmcp As Label
    Friend WithEvents txt_rmrt As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl_rmrt As Label
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents dgv_rm_mst As DataGridView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Room_No As DataGridViewTextBoxColumn
    Friend WithEvents Room_Type As DataGridViewTextBoxColumn
    Friend WithEvents Room_Rate As DataGridViewTextBoxColumn
    Friend WithEvents Capacity As DataGridViewTextBoxColumn
    Friend WithEvents ROW_ID As DataGridViewTextBoxColumn
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents cmb_rmcp As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_rmtp As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
