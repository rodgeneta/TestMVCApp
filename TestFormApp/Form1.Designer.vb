<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.lbl_product_name = New System.Windows.Forms.Label()
        Me.lbl_product_design = New System.Windows.Forms.Label()
        Me.lbl_product_color = New System.Windows.Forms.Label()
        Me.lbl_product_warranty = New System.Windows.Forms.Label()
        Me.lbl_product_launch = New System.Windows.Forms.Label()
        Me.txtb_product_id = New System.Windows.Forms.TextBox()
        Me.txtb_product_name = New System.Windows.Forms.TextBox()
        Me.txtb_product_design = New System.Windows.Forms.TextBox()
        Me.cmb_product_color = New System.Windows.Forms.ComboBox()
        Me.dtp_product_launch = New System.Windows.Forms.DateTimePicker()
        Me.rb_allowed = New System.Windows.Forms.RadioButton()
        Me.rb_notallowed = New System.Windows.Forms.RadioButton()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.dgv_data = New System.Windows.Forms.DataGridView()
        Me.txtb_search = New System.Windows.Forms.TextBox()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 65)
        Me.Panel1.TabIndex = 0
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(435, 22)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(119, 20)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "SimpleCRUD"
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_id.Location = New System.Drawing.Point(12, 83)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(89, 20)
        Me.lbl_product_id.TabIndex = 1
        Me.lbl_product_id.Text = "Product ID"
        '
        'lbl_product_name
        '
        Me.lbl_product_name.AutoSize = True
        Me.lbl_product_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_name.Location = New System.Drawing.Point(12, 157)
        Me.lbl_product_name.Name = "lbl_product_name"
        Me.lbl_product_name.Size = New System.Drawing.Size(116, 20)
        Me.lbl_product_name.TabIndex = 2
        Me.lbl_product_name.Text = "Product Name"
        '
        'lbl_product_design
        '
        Me.lbl_product_design.AutoSize = True
        Me.lbl_product_design.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_design.Location = New System.Drawing.Point(12, 231)
        Me.lbl_product_design.Name = "lbl_product_design"
        Me.lbl_product_design.Size = New System.Drawing.Size(125, 20)
        Me.lbl_product_design.TabIndex = 3
        Me.lbl_product_design.Text = "Product Design"
        '
        'lbl_product_color
        '
        Me.lbl_product_color.AutoSize = True
        Me.lbl_product_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_color.Location = New System.Drawing.Point(12, 305)
        Me.lbl_product_color.Name = "lbl_product_color"
        Me.lbl_product_color.Size = New System.Drawing.Size(112, 20)
        Me.lbl_product_color.TabIndex = 4
        Me.lbl_product_color.Text = "Product Color"
        '
        'lbl_product_warranty
        '
        Me.lbl_product_warranty.AutoSize = True
        Me.lbl_product_warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_warranty.Location = New System.Drawing.Point(12, 379)
        Me.lbl_product_warranty.Name = "lbl_product_warranty"
        Me.lbl_product_warranty.Size = New System.Drawing.Size(140, 20)
        Me.lbl_product_warranty.TabIndex = 5
        Me.lbl_product_warranty.Text = "Product Warranty"
        '
        'lbl_product_launch
        '
        Me.lbl_product_launch.AutoSize = True
        Me.lbl_product_launch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_launch.Location = New System.Drawing.Point(12, 453)
        Me.lbl_product_launch.Name = "lbl_product_launch"
        Me.lbl_product_launch.Size = New System.Drawing.Size(127, 20)
        Me.lbl_product_launch.TabIndex = 6
        Me.lbl_product_launch.Text = "Product Launch"
        '
        'txtb_product_id
        '
        Me.txtb_product_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_product_id.Location = New System.Drawing.Point(16, 106)
        Me.txtb_product_id.Name = "txtb_product_id"
        Me.txtb_product_id.Size = New System.Drawing.Size(336, 26)
        Me.txtb_product_id.TabIndex = 7
        '
        'txtb_product_name
        '
        Me.txtb_product_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_product_name.Location = New System.Drawing.Point(16, 179)
        Me.txtb_product_name.Name = "txtb_product_name"
        Me.txtb_product_name.Size = New System.Drawing.Size(336, 26)
        Me.txtb_product_name.TabIndex = 8
        '
        'txtb_product_design
        '
        Me.txtb_product_design.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_product_design.Location = New System.Drawing.Point(16, 252)
        Me.txtb_product_design.Name = "txtb_product_design"
        Me.txtb_product_design.Size = New System.Drawing.Size(336, 26)
        Me.txtb_product_design.TabIndex = 9
        '
        'cmb_product_color
        '
        Me.cmb_product_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_product_color.FormattingEnabled = True
        Me.cmb_product_color.Items.AddRange(New Object() {"Black", "White", "Gray", "Red", "Pink", "Blue", "Green", "Others"})
        Me.cmb_product_color.Location = New System.Drawing.Point(16, 325)
        Me.cmb_product_color.Name = "cmb_product_color"
        Me.cmb_product_color.Size = New System.Drawing.Size(336, 28)
        Me.cmb_product_color.TabIndex = 10
        '
        'dtp_product_launch
        '
        Me.dtp_product_launch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_product_launch.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_product_launch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtp_product_launch.Location = New System.Drawing.Point(16, 475)
        Me.dtp_product_launch.Name = "dtp_product_launch"
        Me.dtp_product_launch.Size = New System.Drawing.Size(336, 26)
        Me.dtp_product_launch.TabIndex = 12
        Me.dtp_product_launch.Value = New Date(2024, 5, 20, 10, 9, 30, 0)
        '
        'rb_allowed
        '
        Me.rb_allowed.AutoSize = True
        Me.rb_allowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_allowed.Location = New System.Drawing.Point(16, 403)
        Me.rb_allowed.Name = "rb_allowed"
        Me.rb_allowed.Size = New System.Drawing.Size(88, 24)
        Me.rb_allowed.TabIndex = 13
        Me.rb_allowed.TabStop = True
        Me.rb_allowed.Text = "Allowed"
        Me.rb_allowed.UseVisualStyleBackColor = True
        '
        'rb_notallowed
        '
        Me.rb_notallowed.AutoSize = True
        Me.rb_notallowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_notallowed.Location = New System.Drawing.Point(233, 403)
        Me.rb_notallowed.Name = "rb_notallowed"
        Me.rb_notallowed.Size = New System.Drawing.Size(119, 24)
        Me.rb_notallowed.TabIndex = 14
        Me.rb_notallowed.TabStop = True
        Me.rb_notallowed.Text = "Not Allowed"
        Me.rb_notallowed.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(16, 536)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(104, 43)
        Me.btn_add.TabIndex = 15
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(132, 536)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(104, 43)
        Me.btn_update.TabIndex = 16
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(248, 536)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(104, 43)
        Me.btn_delete.TabIndex = 17
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'dgv_data
        '
        Me.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data.Location = New System.Drawing.Point(390, 157)
        Me.dgv_data.Name = "dgv_data"
        Me.dgv_data.RowHeadersWidth = 51
        Me.dgv_data.RowTemplate.Height = 24
        Me.dgv_data.Size = New System.Drawing.Size(586, 422)
        Me.dgv_data.TabIndex = 18
        '
        'txtb_search
        '
        Me.txtb_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_search.Location = New System.Drawing.Point(390, 106)
        Me.txtb_search.Name = "txtb_search"
        Me.txtb_search.Size = New System.Drawing.Size(346, 26)
        Me.txtb_search.TabIndex = 20
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_search.Location = New System.Drawing.Point(386, 83)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(186, 20)
        Me.lbl_search.TabIndex = 19
        Me.lbl_search.Text = "Search (Product Name)"
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(742, 83)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(114, 49)
        Me.btn_search.TabIndex = 21
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(862, 83)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(114, 49)
        Me.btn_refresh.TabIndex = 22
        Me.btn_refresh.Text = "Refresh DB"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 592)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.txtb_search)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.dgv_data)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.rb_notallowed)
        Me.Controls.Add(Me.rb_allowed)
        Me.Controls.Add(Me.dtp_product_launch)
        Me.Controls.Add(Me.cmb_product_color)
        Me.Controls.Add(Me.txtb_product_design)
        Me.Controls.Add(Me.txtb_product_name)
        Me.Controls.Add(Me.txtb_product_id)
        Me.Controls.Add(Me.lbl_product_launch)
        Me.Controls.Add(Me.lbl_product_warranty)
        Me.Controls.Add(Me.lbl_product_color)
        Me.Controls.Add(Me.lbl_product_design)
        Me.Controls.Add(Me.lbl_product_name)
        Me.Controls.Add(Me.lbl_product_id)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents lbl_product_name As Label
    Friend WithEvents lbl_product_design As Label
    Friend WithEvents lbl_product_color As Label
    Friend WithEvents lbl_product_warranty As Label
    Friend WithEvents lbl_product_launch As Label
    Friend WithEvents txtb_product_id As TextBox
    Friend WithEvents txtb_product_name As TextBox
    Friend WithEvents txtb_product_design As TextBox
    Friend WithEvents cmb_product_color As ComboBox
    Friend WithEvents dtp_product_launch As DateTimePicker
    Friend WithEvents rb_allowed As RadioButton
    Friend WithEvents rb_notallowed As RadioButton
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents dgv_data As DataGridView
    Friend WithEvents txtb_search As TextBox
    Friend WithEvents lbl_search As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_refresh As Button
End Class
