using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UsersMonitoring
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DBUsersContext DBContext;

        List<Group> SelectedGroups;

        private void MainForm_Load(object sender, EventArgs e)
        {
            DBContext = new DBUsersContext();
            SelectedGroups = new List<Group>();
            UpdateGroupsGrid();
            UpdateGroupsComboBox();
            UpdateUsersGrid();
        }

        private void UpdateGroupsGrid()
        {
            var data = DBContext.GetGroupsStatistics();
            data.Columns[0].ColumnName = "ID группы";
            data.Columns[1].ColumnName = "Название группы";
            data.Columns[2].ColumnName = "Сотрудников в группе";
            GroupsGrid.DataSource = data;
        }
        private void UpdateGroupsComboBox()
        {
            GroupsComboBox.DataSource = DBContext.GetGroups();
            GroupsComboBox.DisplayMember = "Desc";
        }
        private void UpdateUsersGrid()
        {
            var data = DBContext.GetUsers();
            data.Columns[0].ColumnName = "ID сотрудника";
            data.Columns[1].ColumnName = "ФИО сотрудника";
            data.Columns[2].ColumnName = "Входит в группы";
            UsersGrid.DataSource = data;
        }

        private void AddUserGroupButton_Click(object sender, EventArgs e)
        {
            if (GroupsComboBox.SelectedItem != null)
            {
                var group = (Group)GroupsComboBox.SelectedItem;
                if (!SelectedGroups.Contains(group))
                {
                    SelectedGroups.Add((Group)GroupsComboBox.SelectedItem);
                }
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            DBContext.AddUser(FioTextBox.Text, SelectedGroups);
            SelectedGroups.Clear();
            UpdateGroupsGrid();
            UpdateUsersGrid();
        }

        private void ShowDeleteMenu(DataGridView DataGrid, string MenuName, int X, int Y, Action<int> CallBack)
        {
            int currentMouseOverRow = DataGrid.HitTest(X, Y).RowIndex;
            if (currentMouseOverRow >= 0)
            {
                int id = Convert.ToInt32(DataGrid.Rows[currentMouseOverRow].Cells[0].Value);
                var m = new ContextMenu();
                var mi = new MenuItem(MenuName);
                mi.Click += (s, args) => CallBack(id);
                m.MenuItems.Add(mi);
                m.Show(DataGrid, new Point(X, Y));
            }
        }

        private void UsersGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ShowDeleteMenu(UsersGrid, "Удалить сотрудника", e.X, e.Y, CallBack: id =>
                {
                    DBContext.DeleteUser(id);
                    UpdateGroupsGrid();
                    UpdateUsersGrid();
                });
            }
        }

        private void GroupsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ShowDeleteMenu(GroupsGrid, "Удалить группу", e.X, e.Y, CallBack: id =>
                {
                    DBContext.DeleteGroup(id);
                    UpdateGroupsComboBox();
                    UpdateGroupsGrid();
                    UpdateUsersGrid();
                });
            }
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            DBContext.AddGroup(GroupDescTextBox.Text);
            UpdateGroupsComboBox();
            UpdateGroupsGrid();
        }
    }
}
