using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FastReport; //FastReport для кнопки Печать
using FastReport.Export.Pdf;

namespace KBJU
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SQLClass Menu_week = new SQLClass(); // Класс для работы с SQL
        DataTable zav = new DataTable();
        DataTable obed = new DataTable();
        DataTable yzhin = new DataTable();
        public int id_menu;
        public string name_menu;
        byte day = 1; // День недели, с которым работаем

        private void Form2_Shown(object sender, EventArgs e)
        {//Список блюд
            dgv_bludo.AutoGenerateColumns = false;
            tb_menu.Text = name_menu;
            Menu_week.SELcmd = new SqlCommand("SELECT [id_bludo],[name_bludo] FROM [kbju].[dbo].[bludo]");
            dgv_bludo.DataSource = Menu_week.SelConnect(Menu_week.SELcmd); // Вывод блюд в левую таблицу
            SearchBludoDay(day);// Загружаем блюда ПН при открытии окна
        }

        public void SearchBludoDay(int days)
        {//Метод выбора блюд конкретного дня
            //Завтрак
            Menu_week.SELcmd = new SqlCommand("SELECT b.id_bludo, b.name_bludo FROM [dbo].[menu_bludo] m JOIN [dbo].[bludo] b ON m.id_bludo=b.id_bludo WHERE m.meal=1 and m.day_of_week=" + days.ToString() + " and m.id_menu=" + id_menu.ToString());
            zav = Menu_week.SelConnect(Menu_week.SELcmd);
            dgv_zav.DataSource = zav;
            //Обед
            Menu_week.SELcmd = new SqlCommand("SELECT b.id_bludo, b.name_bludo FROM [dbo].[menu_bludo] m JOIN [dbo].[bludo] b ON m.id_bludo=b.id_bludo WHERE m.meal=2 and m.day_of_week=" + days.ToString() + " and m.id_menu=" + id_menu.ToString());
            obed = Menu_week.SelConnect(Menu_week.SELcmd);
            dgv_obed.DataSource = obed;
            //Ужин
            Menu_week.SELcmd = new SqlCommand("SELECT b.id_bludo, b.name_bludo FROM [dbo].[menu_bludo] m JOIN [dbo].[bludo] b ON m.id_bludo=b.id_bludo WHERE m.meal=3 and m.day_of_week=" + days.ToString() + " and m.id_menu=" + id_menu.ToString());
            yzhin = Menu_week.SelConnect(Menu_week.SELcmd);
            dgv_yzhin.DataSource = yzhin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "Меню на понедельник";
            day = 1;
            SearchBludoDay(day);
        }

        private void btn_Vt_Click(object sender, EventArgs e)
        {
            Text = "Меню на вторник";
            day = 2;
            SearchBludoDay(day);
        }

        private void btn_Sr_Click(object sender, EventArgs e)
        {
            Text = "Меню на среду";
            day = 3;
            SearchBludoDay(day);
        }

        private void btn_Ct_Click(object sender, EventArgs e)
        {
            Text = "Меню на четверг";
            day = 4;
            SearchBludoDay(day);
        }

        private void btn_Pt_Click(object sender, EventArgs e)
        {
            Text = "Меню на пятницу";
            day = 5;
            SearchBludoDay(day);
        }

        private void btn_Sb_Click(object sender, EventArgs e)
        {
            Text = "Меню на субботу";
            day = 6;
            SearchBludoDay(day);
        }

        private void btn_Vs_Click(object sender, EventArgs e)
        {
            Text = "Меню на воскресенье";
            day = 7;
            SearchBludoDay(day);
        }

        public void FastRep(int day)
        {//Метод компиляции отчета PDF
            DataSet sqlrez = new DataSet();
            report1.Load(Application.StartupPath + "\\Print.frx"); // загружаем шаблон отчета
            (report1.FindObject("tb_name") as TextObject).Text = name_menu;//Заполняем название отчета в шаблоне

            Menu_week.SELcmd = new SqlCommand("select case when mb.meal = '1' then 'Завтрак' when mb.meal = '2' then 'Обед' when mb.meal = '3' then 'Ужин' end as meal,  "
                                           + "b.name_bludo, cast(sum(1.0 * pr.kilocalorii / 100 * bp.massa) as int) as kilocalorii, cast(sum(1.0 * pr.belki / 100 * bp.massa) as int) as belki, "
                                           + "cast(sum(1.0 * pr.zhiry / 100 * bp.massa) as int) as zhiry, cast(sum(1.0 * pr.uglevody / 100 * bp.massa) as int) as uglevody "
                                           + "from product pr "
                                           + "join bludo_product bp on bp.id_product = pr.id_product "
                                           + "join bludo b on b.id_bludo = bp.id_bludo "
                                           + "join menu_bludo mb on mb.id_bludo = b.id_bludo "
                                           + "join menu m on m.id_menu = mb.id_menu "
                                           + "where m.id_menu = @id_menu "
                                           + "and mb.day_of_week = @day "
                                           + "group by b.name_bludo, mb.day_of_week, mb.meal ");
            Menu_week.SELcmd.Parameters.Add("@id_menu", SqlDbType.BigInt).Value = id_menu;
            Menu_week.SELcmd.Parameters.Add("@day", SqlDbType.BigInt).Value = day;
            sqlrez.Tables.Add(Menu_week.SelConnect(Menu_week.SELcmd));

            switch (day)
            {//Заполняем день недели в шаблоне отчета
                case 1: (report1.FindObject("tb_day") as TextObject).Text = "Понедельник"; break;
                case 2: (report1.FindObject("tb_day") as TextObject).Text = "Вторник"; break;
                case 3: (report1.FindObject("tb_day") as TextObject).Text = "Среда"; break;
                case 4: (report1.FindObject("tb_day") as TextObject).Text = "Четверг"; break;
                case 5: (report1.FindObject("tb_day") as TextObject).Text = "Пятница"; break;
                case 6: (report1.FindObject("tb_day") as TextObject).Text = "Суббота"; break;
                case 7: (report1.FindObject("tb_day") as TextObject).Text = "Воскресенье"; break;
            }
            FastReport.Table.TableBase Mytbl = (FastReport.Table.TableBase)report1.Report.FindObject("Table1");
            //привязываем источник
            report1.Dictionary.Clear();
            report1.Dictionary.Report.RegisterData(sqlrez.Tables[0], "Table");//Table - имя как записан в шаблоне отчета([Table.ColName])
            report1.GetDataSource("Table").Enabled = true;
            //обращаемся к нашему Data блоку, созданному в отчете
            DataBand data1 = report1.FindObject("DataLine") as DataBand;
            //указываем, что он должен брать данные из переданной таблицы
            data1.DataSource = report1.GetDataSource("Table");
            


            //Заполняем итоги дня
            Menu_week.SELcmd = new SqlCommand("select cast(sum(1.0 * pr.kilocalorii / 100 * bp.massa) as int) as kkal, cast(sum(1.0 * pr.belki / 100 * bp.massa) as int) as belki, "
                                           + "cast(sum(1.0 * pr.zhiry / 100 * bp.massa) as int) as zhir, cast(sum(1.0 * pr.uglevody / 100 * bp.massa) as int) as uglevod "
                                           + "from product pr "
                                           + "join bludo_product bp on bp.id_product = pr.id_product "
                                           + "join bludo b on b.id_bludo = bp.id_bludo "
                                           + "join menu_bludo mb on mb.id_bludo = b.id_bludo "
                                           + "join menu m on m.id_menu = mb.id_menu "
                                           + "where m.id_menu = @id_menu "
                                           + "and mb.day_of_week = @day ");
            Menu_week.SELcmd.Parameters.Add("@id_menu", SqlDbType.BigInt).Value = id_menu;
            Menu_week.SELcmd.Parameters.Add("@day", SqlDbType.BigInt).Value = day;
            sqlrez.Tables.Add(Menu_week.SelConnect(Menu_week.SELcmd));

            //привязываем источник
            report1.RegisterData(sqlrez.Tables[1], "Tab1");//Table - имя как записан в шаблоне отчета([Table.ColName])
                                                 //обращаемся к нашему Data блоку, созданному в отчете
            DataBand data2 = report1.FindObject("DataItog") as DataBand;
            //указываем, что он должен брать данные из переданной таблицы
            data2.DataSource = report1.GetDataSource("Tab1");

            report1.Prepare();
            PDFExport pdf = new PDFExport();
            report1.Export(pdf, "ExportedPDF.pdf");//Сохраняем в PDF
            System.Diagnostics.Process.Start(Application.StartupPath + @"\\ExportedPDF.pdf");//Открываем файл
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {//Печать
            FastRep(day);
        }

        private void dgv_bludo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {//При двойном клике по ячейке DGV передаем блюдо в DT привязанный к DGV завтрака/обеда/ужина
            if (id_menu == 0)
            {//Если меню новое, то записываем его в БД при первом внесении блюда
                Menu_week.SELcmd = new SqlCommand("INSERT INTO [kbju].[dbo].[menu] ([name_menu]) VALUES ('"+tb_menu.Text+ "') SELECT @@Identity");
                Menu_week.AppTable = Menu_week.SelConnect(Menu_week.SELcmd);
                id_menu = Convert.ToInt32(Menu_week.AppTable.Rows[0][0]);
            }

           if (rbt_zav.Checked)
            {//завтрак
                zav.Rows.Add(dgv_bludo[0, e.RowIndex].Value, dgv_bludo[1, e.RowIndex].Value);
                AddRowBD(Convert.ToInt32(dgv_bludo[0, e.RowIndex].Value), 1);
            } 
           else if (rbt_obed.Checked)
            {//обед
                obed.Rows.Add(dgv_bludo[0, e.RowIndex].Value, dgv_bludo[1, e.RowIndex].Value);
                AddRowBD(Convert.ToInt32(dgv_bludo[0, e.RowIndex].Value), 2);
            }
           else
            {//ужин
                yzhin.Rows.Add(dgv_bludo[0, e.RowIndex].Value, dgv_bludo[1, e.RowIndex].Value);
                AddRowBD(Convert.ToInt32(dgv_bludo[0, e.RowIndex].Value), 3);
            }
        }

        public void AddRowBD(int id_bludo, byte meal)
        {//Запись блюда в БД
            Menu_week.SELcmd = new SqlCommand("INSERT INTO [kbju].[dbo].[menu_bludo] VALUES ("+id_menu+"," +id_bludo+","+day+","+meal+")");
            Menu_week.AppTable = Menu_week.SelConnect(Menu_week.SELcmd);
        }
    }

}
