using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KBJU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Добавить
            Form2 menu_week = new Form2();
            menu_week.id_menu = 0;
            menu_week.name_menu = "Меню от " + System.DateTime.Now;
            menu_week.Show();
        }
        DataTable edit_bludo = new DataTable();

        private void Form1_Shown(object sender, EventArgs e)
        {//Получаем список меню при запуске
            dgv_menu.AutoGenerateColumns = false;
            SQLClass Need_data = new SQLClass();
            Need_data.SELcmd = new SqlCommand("SELECT [id_menu],[name_menu],[date_menu] FROM [kbju].[dbo].[menu]");
            dgv_menu.DataSource = Need_data.SelConnect(Need_data.SELcmd);
            
        }

        private void dgv_menu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {//Открытие параметров графика блюд в новом окне
            Form2 menu_week = new Form2();
            menu_week.id_menu = Convert.ToInt32(dgv_menu[0, e.RowIndex].Value); // Передаем параметры в новое окно
            menu_week.name_menu = dgv_menu[1, e.RowIndex].Value.ToString();
            menu_week.Show();
        }

        private void dgv_allbluda_Enter(object sender, EventArgs e)
        {//Вывод всех блюд при клике на DGV
            SQLClass Need_data = new SQLClass();
            Need_data.SELcmd = new SqlCommand("SELECT [id_bludo],[name_bludo] FROM [kbju].[dbo].[bludo]");
            edit_bludo= Need_data.SelConnect(Need_data.SELcmd);
            dgv_allbluda.DataSource = edit_bludo;
        }

        private void dgv_allbluda_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {//Редактирование блюд в БД
            SQLClass Upd_data = new SQLClass();
            Upd_data.UPDcmd = new SqlCommand("UPDATE [kbju].[dbo].[bludo] SET [name_bludo] = @name_bludo WHERE id_bludo=@id", Upd_data.MyConnection);
            Upd_data.UPDcmd.Parameters.Add("@id", SqlDbType.BigInt).SourceColumn = "id_bludo";
            Upd_data.UPDcmd.Parameters.Add("@name_bludo", SqlDbType.VarChar).SourceColumn = "name_bludo";
            if (edit_bludo.GetChanges(DataRowState.Modified) != null)
            {//Если строка изменена, то фиксируем
                Upd_data.FixChanges(edit_bludo.GetChanges(DataRowState.Modified));//Отправить UPDATE по строка с модификатором Modified
                edit_bludo.AcceptChanges();//Применить изменения в DT, смена модификатора строки, чтобы они не считались измененными после отправки UPDATE
            }
        }

        private void dgv_prod_Enter(object sender, EventArgs e)
        {//Вывод всех ингредиентов при клике на DGV
            SQLClass Need_data = new SQLClass();
            Need_data.SELcmd = new SqlCommand("SELECT [id_product],[name_product],[kilocalorii],[belki],[zhiry],[uglevody] FROM [kbju].[dbo].[product]");
            edit_bludo = Need_data.SelConnect(Need_data.SELcmd);
            dgv_prod.DataSource = edit_bludo;
        }

        private void dgv_prod_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {//Редактирование ингредиентов в БД
            SQLClass Upd_data = new SQLClass();
            Upd_data.UPDcmd = new SqlCommand("UPDATE [dbo].[product] SET[name_product] = @name_product, [kilocalorii] = @kilocalorii, [belki] = @belki, [zhiry] = @zhiry, [uglevody] = @uglevody WHERE id_product = @id", Upd_data.MyConnection);
            Upd_data.UPDcmd.Parameters.Add("@id", SqlDbType.BigInt).SourceColumn = "id_product";
            Upd_data.UPDcmd.Parameters.Add("@name_product", SqlDbType.VarChar).SourceColumn = "name_product";
            Upd_data.UPDcmd.Parameters.Add("@kilocalorii", SqlDbType.BigInt).SourceColumn = "kilocalorii";
            Upd_data.UPDcmd.Parameters.Add("@belki", SqlDbType.BigInt).SourceColumn = "belki";
            Upd_data.UPDcmd.Parameters.Add("@zhiry", SqlDbType.BigInt).SourceColumn = "zhiry";
            Upd_data.UPDcmd.Parameters.Add("@uglevody", SqlDbType.BigInt).SourceColumn = "uglevody";
            edit_bludo.GetChanges(DataRowState.Modified);
            if (edit_bludo.GetChanges(DataRowState.Modified)!=null)
            {//Если строка изменена, то фиксируем
                Upd_data.FixChanges(edit_bludo.GetChanges(DataRowState.Modified));//Отправить UPDATE по строка с модификатором Modified
                edit_bludo.AcceptChanges();//Применить изменения в DT, смена модификатора строки, чтобы они не считались измененными после отправки UPDATE
            }
        }

        private void dgv_menu_Enter(object sender, EventArgs e)
        {
            SQLClass Need_data = new SQLClass();
            Need_data.SELcmd = new SqlCommand("SELECT [id_menu],[name_menu],[date_menu] FROM [kbju].[dbo].[menu]");
            dgv_menu.DataSource = Need_data.SelConnect(Need_data.SELcmd);
        }
    }
}
