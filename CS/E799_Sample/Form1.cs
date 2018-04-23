using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace E799_Sample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            InitData();
            label1.Text = "In this example the data source is represented by the Records class which is inherited from the System.Collections.ArrayList class.";
        }
        private void InitData() {
            treeList1.DataSource = new Records();
            treeList1.PopulateColumns();
            treeList1.BestFitColumns();
            treeList1.ExpandAll();
            InitColumnsVisibleOrder();
            treeList1.Columns["Price"].Format.FormatString = "c";
        }

        private void InitColumnsVisibleOrder() {
            treeList1.Columns["Name"].VisibleIndex = 0;
            treeList1.Columns["Status"].VisibleIndex = 1;
            treeList1.Columns["Price"].VisibleIndex = 2;
            treeList1.Columns["Supplier"].VisibleIndex = 3;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (treeList1.AllNodesCount == 0) return;
            treeList1.DeleteSelectedNodes();
        }
    }
    public class Records : ArrayList {
        public Records() {
            Add(new Record("Dairy Products", RecordType.Category, 0, "", 0));
            Add(new Record("Queso Manchego La Pastora", RecordType.Product, 37.89, "Cooperativa de Quesos", 1, 0));
            Add(new Record("Queso Cabrales", RecordType.Product, 21.0, "Cooperativa de Quesos", 2, 0));
            Add(new Record("Gorgonzola Telino", RecordType.Product, 12.5, "Formaggi Fortini", 3, 0));
            Add(new Record("Confections", RecordType.Category, 0, "", 4));
            Add(new Record("Sir Rodney's Marmalade", RecordType.Product, 81.0, "Specialty Biscuits, Ltd.", 5, 4));
            Add(new Record("Sir Rodney's Scones", RecordType.Product, 10.1, "Specialty Biscuits, Ltd.", 6, 4));
            Add(new Record("Gula Malacca", RecordType.Product, 19.45, "Leka Trading", 7, 4));
            Add(new Record("Grandma's Boysenberry Spread", RecordType.Product, 25.0, "Grandma Kelly's Homestead", 8, 4));
            Add(new Record("Pavlova", RecordType.Product, 17.45, "Pavlova, Ltd.", 9, 4));
        }
    }
    public class Record {
        private int _id, _parentID;
        private string _name, _supplier;
        private RecordType _status;
        private double _price;

        public Record(string name, RecordType status, double price, string supplier, int id)
            : this(name, status, price, supplier, id, -1) {
        }
        public Record(string name, RecordType status, double price, string supplier, int id, int parentID) {
            _id = id;
            _parentID = parentID;
            _name = name;
            _status = status;
            _price = price;
            _supplier = supplier;
        }

        public int ID {
            get {
                return _id;
            }
        }


        public int ParentID {
            get {
                return _parentID;
            }
        }

        public int ImageIndex {
            get {
                return (_status == RecordType.Category ? 0 : 1);
            }
        }

        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        public RecordType Status {
            get {
                return _status;
            }
        }

        public double Price {
            get {
                return _price;
            }
            set {
                if (_status == RecordType.Product)
                    _price = value;

            }
        }

        public string Supplier {
            get {
                return _supplier;
            }
            set {
                _supplier = value;
            }
        }
    }
    public enum RecordType { Category, Product };
}