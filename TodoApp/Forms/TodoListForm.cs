using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TodoApp.Apps.Service;
using TodoApp.Apps.Service.Impl;
using TodoApp.Domains.Entity;

namespace TodoApp.Forms
{
    public partial class TodoListForm : FormBase
    {
        #region "  "

        #endregion

        #region " Enum "
        private enum ColIdx
        {
            Title = 0,
            Change
        };

        #endregion

        #region " 変数 "

        private ITodoService todoService;

        #endregion

        #region " 初期化 "
        public TodoListForm()
        {
            InitializeComponent();

            todoService = new TodoServiceImpl();
        }

        private void TodoListForm_Load(object sender, EventArgs e)
        {
            InitForm();

            TodoTitleTxt.Focus();
        }

        private void InitForm()
        {
            InitTodoTitle();

            InitGrid();
        }

        private void InitTodoTitle()
        {
            TodoTitleTxt.Clear();
            TodoTitleTxt.Focus();
        }

        private void InitGrid()
        {
            var list = todoService.GetAll();

        }

        private void ShowTodoList(TodoList list)
        {
            try
            {
                TodoGrid.SuspendLayout();
                
                list.ForEach((todo) =>
                {
                    AddNewRow(todo);
                });
            }
            finally
            {
                TodoGrid.ResumeLayout();
                TodoGrid.Update();
            }
        }

        private void AddNewRow(TodoModel todo)
        {
            var idx = TodoGrid.Rows.Add();
            ShowTodo(todo, idx);
        }

        private void ShowTodo(TodoModel todo, int rowIdx)
        {
            SetValue(todo.Message(), rowIdx, ColIdx.Title);
            SetValue("変更", rowIdx, ColIdx.Change);
        }

        private void SetValue<T>(T value, int rowIdx, ColIdx col)
        {
            TodoGrid.Rows[rowIdx].Cells[(int)col].Value = value;
        }

        #endregion

        #region " 追加 "
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddTodo();
        }

        private void TodoTitleTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            AddTodo();
        }

        private void AddTodo()
        {

            string title = GetTodoTitle();
            if (string.IsNullOrEmpty(title)) return;

            var todo = todoService.Create(title);

            todoService.Store(todo);

            AddNewRow(todo);

            InitTodoTitle();
        }

        private string GetTodoTitle()
        {
            return TodoTitleTxt.Text;
        }
        

        #endregion


    }
}
