<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.pnl_head = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_bck2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_login = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnl_pass = New System.Windows.Forms.Panel()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_usr = New System.Windows.Forms.Panel()
        Me.txt_usr = New System.Windows.Forms.TextBox()
        Me.lbl_rmno = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnl_head.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_pass.SuspendLayout()
        Me.pnl_usr.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_head
        '
        Me.pnl_head.BackColor = System.Drawing.Color.Gold
        Me.pnl_head.Controls.Add(Me.Label2)
        Me.pnl_head.Controls.Add(Me.Button1)
        Me.pnl_head.Controls.Add(Me.lbl_title)
        Me.pnl_head.Controls.Add(Me.btn_bck2)
        Me.pnl_head.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_head.Location = New System.Drawing.Point(0, 0)
        Me.pnl_head.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_head.Name = "pnl_head"
        Me.pnl_head.Size = New System.Drawing.Size(849, 125)
        Me.pnl_head.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(237, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Label2.Size = New System.Drawing.Size(375, 63)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Hotel Shiv Grand"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(792, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 55)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(373, 80)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_title.Size = New System.Drawing.Size(103, 45)
        Me.lbl_title.TabIndex = 3
        Me.lbl_title.Text = "Login"
        '
        'btn_bck2
        '
        Me.btn_bck2.FlatAppearance.BorderSize = 0
        Me.btn_bck2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bck2.Image = CType(resources.GetObject("btn_bck2.Image"), System.Drawing.Image)
        Me.btn_bck2.Location = New System.Drawing.Point(1086, -1)
        Me.btn_bck2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_bck2.Name = "btn_bck2"
        Me.btn_bck2.Size = New System.Drawing.Size(57, 55)
        Me.btn_bck2.TabIndex = 2
        Me.btn_bck2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.pnl_pass)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pnl_usr)
        Me.Panel1.Controls.Add(Me.lbl_rmno)
        Me.Panel1.Location = New System.Drawing.Point(163, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 380)
        Me.Panel1.TabIndex = 8
        '
        'btn_login
        '
        Me.btn_login.Activecolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login.BorderRadius = 0
        Me.btn_login.ButtonText = "Login"
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.DisabledColor = System.Drawing.Color.Gray
        Me.btn_login.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_login.Iconimage = CType(resources.GetObject("btn_login.Iconimage"), System.Drawing.Image)
        Me.btn_login.Iconimage_right = Nothing
        Me.btn_login.Iconimage_right_Selected = Nothing
        Me.btn_login.Iconimage_Selected = Nothing
        Me.btn_login.IconMarginLeft = 0
        Me.btn_login.IconMarginRight = 0
        Me.btn_login.IconRightVisible = True
        Me.btn_login.IconRightZoom = 0R
        Me.btn_login.IconVisible = True
        Me.btn_login.IconZoom = 90.0R
        Me.btn_login.IsTab = False
        Me.btn_login.Location = New System.Drawing.Point(99, 287)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_login.OnHovercolor = System.Drawing.Color.DeepSkyBlue
        Me.btn_login.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_login.selected = False
        Me.btn_login.Size = New System.Drawing.Size(284, 43)
        Me.btn_login.TabIndex = 9
        Me.btn_login.Text = "Login"
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_login.Textcolor = System.Drawing.Color.White
        Me.btn_login.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(190, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'pnl_pass
        '
        Me.pnl_pass.Controls.Add(Me.txt_pass)
        Me.pnl_pass.Location = New System.Drawing.Point(99, 224)
        Me.pnl_pass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_pass.Name = "pnl_pass"
        Me.pnl_pass.Size = New System.Drawing.Size(304, 40)
        Me.pnl_pass.TabIndex = 8
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(8, 7)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(288, 27)
        Me.txt_pass.TabIndex = 0
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(99, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Password"
        '
        'pnl_usr
        '
        Me.pnl_usr.Controls.Add(Me.txt_usr)
        Me.pnl_usr.Location = New System.Drawing.Point(99, 140)
        Me.pnl_usr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_usr.Name = "pnl_usr"
        Me.pnl_usr.Size = New System.Drawing.Size(304, 40)
        Me.pnl_usr.TabIndex = 8
        '
        'txt_usr
        '
        Me.txt_usr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usr.Location = New System.Drawing.Point(8, 7)
        Me.txt_usr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_usr.Name = "txt_usr"
        Me.txt_usr.Size = New System.Drawing.Size(288, 27)
        Me.txt_usr.TabIndex = 0
        '
        'lbl_rmno
        '
        Me.lbl_rmno.AutoSize = True
        Me.lbl_rmno.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.lbl_rmno.ForeColor = System.Drawing.Color.Black
        Me.lbl_rmno.Location = New System.Drawing.Point(99, 116)
        Me.lbl_rmno.Name = "lbl_rmno"
        Me.lbl_rmno.Size = New System.Drawing.Size(111, 22)
        Me.lbl_rmno.TabIndex = 7
        Me.lbl_rmno.Text = "User Name"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(849, 500)
        Me.Controls.Add(Me.pnl_head)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnl_head.ResumeLayout(False)
        Me.pnl_head.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_pass.ResumeLayout(False)
        Me.pnl_pass.PerformLayout()
        Me.pnl_usr.ResumeLayout(False)
        Me.pnl_usr.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_head As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_bck2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_login As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnl_pass As Panel
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnl_usr As Panel
    Friend WithEvents txt_usr As TextBox
    Friend WithEvents lbl_rmno As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label2 As Label
End Class
