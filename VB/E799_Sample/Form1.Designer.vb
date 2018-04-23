Imports Microsoft.VisualBasic
Imports System
Namespace E799_Sample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.button1 = New System.Windows.Forms.Button()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.panel1.SuspendLayout()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(499, 37)
			Me.panel1.TabIndex = 0
			' 
			' label1
			' 
			Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label1.Location = New System.Drawing.Point(20, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(479, 37)
			Me.label1.TabIndex = 2
			' 
			' label2
			' 
			Me.label2.Dock = System.Windows.Forms.DockStyle.Left
			Me.label2.Image = (CType(resources.GetObject("label2.Image"), System.Drawing.Image))
			Me.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.label2.Location = New System.Drawing.Point(0, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(20, 37)
			Me.label2.TabIndex = 3
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 37)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsSelection.MultiSelect = True
			Me.treeList1.SelectImageList = Me.imageList1
			Me.treeList1.Size = New System.Drawing.Size(499, 311)
			Me.treeList1.TabIndex = 1
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(23, 312)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(182, 24)
			Me.button1.TabIndex = 2
			Me.button1.Text = "Delete Selection"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Fuchsia
			Me.imageList1.Images.SetKeyName(0, "align_left16_d.bmp")
			Me.imageList1.Images.SetKeyName(1, "arrowright_green16_d.bmp")
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(499, 348)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "TreeList SimpleMode"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.panel1.ResumeLayout(False)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Friend label1 As System.Windows.Forms.Label
		Friend label2 As System.Windows.Forms.Label
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private WithEvents button1 As System.Windows.Forms.Button
		Private imageList1 As System.Windows.Forms.ImageList
	End Class
End Namespace

