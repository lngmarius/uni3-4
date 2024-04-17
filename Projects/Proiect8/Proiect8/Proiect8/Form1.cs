using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Proiect8
{
    public partial class Form1 : Form
    {
        private SortOrder sortOrder = SortOrder.Ascending;

        public Form1()
        {
            InitializeComponent();
            ConstruiesteHeader();
            BuildLista();
        }

        private void ConstruiesteHeader()
        {
            listView1.View = View.Details;

            ColumnHeader colHead = new ColumnHeader();
            colHead.Text = "Nume fisier";
            listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Dimensiune";
            listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Ultima accesare";
            listView1.Columns.Add(colHead);
        }

        private void BuildLista()
        {
            listView1.Items.Clear();

            calea_curenta.Text = @"C:\" + "(Dublu clic pe folder)";
            DirectoryInfo dir = new DirectoryInfo(@"C:\");

            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();

            foreach (DirectoryInfo di in dirs)
            {
                ListViewItem item = new ListViewItem(di.Name);
                item.ImageIndex = 1;
                item.SubItems.Add(""); 
                item.SubItems.Add(di.LastAccessTime.ToString());
                listView1.Items.Add(item);
            }

            foreach (FileInfo fi in files)
            {
                ListViewItem item = new ListViewItem(fi.Name);
                item.ImageIndex = 0;
                item.SubItems.Add(fi.Length.ToString());
                item.SubItems.Add(fi.LastAccessTime.ToString());
                listView1.Items.Add(item);
            }

            ResizeList();
        }

        private void ResizeList()
        {
            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2;
            }
        }


        private void listView1_ColumnClick_1(object sender, ColumnClickEventArgs e)
        {
            int columnIndex = e.Column;
            if (columnIndex == 0)
                sortNumeFisier();
            else if (columnIndex == 1)
                sortDimensiune();
            else if (columnIndex == 2)
                sortLastTime();
        }

        private void sortNumeFisier()
        {
            listView1.ListViewItemSorter = new ListViewItemComparer(0, sortOrder);
            sortOrder = (sortOrder == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            listView1.Sort();
        }

        private void sortDimensiune()
        {
            listView1.ListViewItemSorter = new ListViewItemComparer(1, sortOrder);
            sortOrder = (sortOrder == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            listView1.Sort();
        }

        private void sortLastTime()
        {
            listView1.ListViewItemSorter = new ListViewItemComparer(2, sortOrder);
            sortOrder = (sortOrder == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            listView1.Sort();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                calea_curenta.Text = @"C:\" + selectedItem.Text; 
            }
        }

    }

    public class ListViewItemComparer : IComparer
    {
        private int column;
        private SortOrder order;

        public ListViewItemComparer()
        {
            column = 0;
            order = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            this.column = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;

            if (column == 0 || column == 1)
            {
                returnVal = string.Compare(((ListViewItem)x).SubItems[column].Text,
                                           ((ListViewItem)y).SubItems[column].Text);
            }
            else if (column == 2)
            {
                DateTime firstDate, secondDate;
                if (DateTime.TryParse(((ListViewItem)x).SubItems[column].Text, out firstDate) &&
                    DateTime.TryParse(((ListViewItem)y).SubItems[column].Text, out secondDate))
                {
                    returnVal = DateTime.Compare(firstDate, secondDate);
                }
            }

            if (order == SortOrder.Descending)
                returnVal *= -1;

            return returnVal;
        }
    }
}
