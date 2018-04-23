Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections

Namespace E799_Sample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			InitData()
			label1.Text = "In this example the data source is represented by the Records class which is inherited from the System.Collections.ArrayList class."
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
		Private Sub InitData()
			treeList1.DataSource = New Records()
			treeList1.PopulateColumns()
			treeList1.BestFitColumns()
			treeList1.ExpandAll()
			InitColumnsVisibleOrder()
			treeList1.Columns("Price").Format.FormatString = "c"
		End Sub

		Private Sub InitColumnsVisibleOrder()
			treeList1.Columns("Name").VisibleIndex = 0
			treeList1.Columns("Status").VisibleIndex = 1
			treeList1.Columns("Price").VisibleIndex = 2
			treeList1.Columns("Supplier").VisibleIndex = 3
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If treeList1.AllNodesCount = 0 Then
				Return
			End If
			treeList1.LockReloadNodes()
			Try
				Dim sel As Hashtable = GetNodesForDeleting()
				Dim nodes As IDictionaryEnumerator = sel.GetEnumerator()
				nodes.Reset()
				Do While nodes.MoveNext()
					treeList1.DeleteNode(CType(nodes.Value, DevExpress.XtraTreeList.Nodes.TreeListNode))
				Loop
			Finally
				treeList1.UnlockReloadNodes()
			End Try
		End Sub

		Private nodesForDeleting As Hashtable

		Private Function GetNodesForDeleting() As Hashtable
			nodesForDeleting = New Hashtable()
			Dim sel As IEnumerator = treeList1.Selection.GetEnumerator()
			sel.Reset()
			Do While sel.MoveNext()
				AddSelectedNode(CType(sel.Current, DevExpress.XtraTreeList.Nodes.TreeListNode))
			Loop
			Return nodesForDeleting
		End Function

		Private Sub AddSelectedNode(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode)
			Dim pnode As DevExpress.XtraTreeList.Nodes.TreeListNode = GetSelectedParent(node)
			nodesForDeleting(pnode) = pnode
		End Sub

		Private Function GetSelectedParent(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode) As DevExpress.XtraTreeList.Nodes.TreeListNode
			Dim pnode As DevExpress.XtraTreeList.Nodes.TreeListNode = node
			Do While pnode.ParentNode IsNot Nothing AndAlso pnode.ParentNode.Selected
				pnode = pnode.ParentNode
			Loop
			Return pnode
		End Function
	End Class
	Public Class Records
		Inherits ArrayList
		Public Sub New()
			Add(New Record("Dairy Products", RecordType.Category, 0, "", 0))
			Add(New Record("Queso Manchego La Pastora", RecordType.Product, 37.89, "Cooperativa de Quesos", 1, 0))
			Add(New Record("Queso Cabrales", RecordType.Product, 21.0, "Cooperativa de Quesos", 2, 0))
			Add(New Record("Gorgonzola Telino", RecordType.Product, 12.5, "Formaggi Fortini", 3, 0))
			Add(New Record("Confections", RecordType.Category, 0, "", 4))
			Add(New Record("Sir Rodney's Marmalade", RecordType.Product, 81.0, "Specialty Biscuits, Ltd.", 5, 4))
			Add(New Record("Sir Rodney's Scones", RecordType.Product, 10.1, "Specialty Biscuits, Ltd.", 6, 4))
			Add(New Record("Gula Malacca", RecordType.Product, 19.45, "Leka Trading", 7, 4))
			Add(New Record("Grandma's Boysenberry Spread", RecordType.Product, 25.0, "Grandma Kelly's Homestead", 8, 4))
			Add(New Record("Pavlova", RecordType.Product, 17.45, "Pavlova, Ltd.", 9, 4))
		End Sub
	End Class
	Public Class Record
		Private _id, _parentID As Integer
		Private _name, _supplier As String
		Private _status As RecordType
		Private _price As Double

		Public Sub New(ByVal name As String, ByVal status As RecordType, ByVal price As Double, ByVal supplier As String, ByVal id As Integer)
			Me.New(name, status, price, supplier, id, -1)
		End Sub
		Public Sub New(ByVal name As String, ByVal status As RecordType, ByVal price As Double, ByVal supplier As String, ByVal id As Integer, ByVal parentID As Integer)
			_id = id
			_parentID = parentID
			_name = name
			_status = status
			_price = price
			_supplier = supplier
		End Sub

		Public ReadOnly Property ID() As Integer
			Get
				Return _id
			End Get
		End Property


		Public ReadOnly Property ParentID() As Integer
			Get
				Return _parentID
			End Get
		End Property

		Public ReadOnly Property ImageIndex() As Integer
			Get
				If _status = RecordType.Category Then
					Return (0)
				Else
					Return (1)
				End If
			End Get
		End Property

		Public Property Name() As String
			Get
				Return _name
			End Get
			Set(ByVal value As String)
			   _name = value
			End Set
		End Property

		Public ReadOnly Property Status() As RecordType
			Get
				Return _status
			End Get
		End Property

		Public Property Price() As Double
			Get
				Return _price
			End Get
			Set(ByVal value As Double)
				If _status = RecordType.Product Then
					_price = value
				End If

			End Set
		End Property

		Public Property Supplier() As String
			Get
				Return _supplier
			End Get
			Set(ByVal value As String)
				_supplier = value
			End Set
		End Property
	End Class
	Public Enum RecordType
		Category
		Product
	End Enum
End Namespace