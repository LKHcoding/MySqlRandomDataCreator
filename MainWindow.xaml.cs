using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        static int indexing;

        public MainWindow()
        {
            InitializeComponent();



            Init();

            //insert();

            //select();
        }

        private void select()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=" + this.DBname.Text + ";Uid=" + this.DBID.Text + ";Pwd=" + this.DBPW.Text + ""))
            {
                try//예외 처리
                {
                    this.ListBox.Items.Clear();
                    connection.Open();
                    string sql = "SELECT * FROM " + this.TableName.Text;

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이타 가져오기
                    MySqlCommand cmd = new MySqlCommand(sql, connection);

                    MySqlDataReader table = cmd.ExecuteReader();

                    //List<string> strList = new List<string>();

                    //사용가능한 필드명들 받아오기
                    var columns = new List<string>();

                    for (int i2 = 0; i2 < table.FieldCount; i2++)
                    {
                        columns.Add(table.GetName(i2));
                    }

                    int aa = 0;
                    while (table.Read())
                    {
                        string Results = "";
                        for (int ii = 0; ii < columns.Count; ii++)
                        {
                            Results += columns[ii] + " : " + table[columns[ii]] + ", ";
                        }

                        this.ListBox.Items.Add(Results);

                        //this.ListBox.Items.Add("[" + table[this.Column1.Text] + "] 이름 : " + table[this.Column2.Text] + ", 나이 : " + table[this.Column3.Text] + ", 주소 : " + table[this.Column4.Text] + ", 번호 : " + table[this.Column5.Text]/* + ", 메일 : " + table[this.Column6.Text]*/);
                        if (aa % 10 == 0 && aa != 0)
                        {
                            this.ListBox.Items.Add("----------------------------------------------------------------");
                        }
                        aa++;
                        //strList.Add(table["name"]);
                        //Console.WriteLine("{0} {1}", table["idx"], table["header"], table["body"]);
                    }
                    table.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    this.ListBox.Items.Add(ex);
                    //Console.WriteLine("실패");
                    //Console.WriteLine(ex.ToString());
                }
            }
        }


        private void insert()
        {
            string[] names = DummyInputClass.GetName(int.Parse(this.howmuch.Text));
            int[] age = DummyInputClass.GetAge(int.Parse(this.howmuch.Text));
            string[] address = DummyInputClass.GetAddress(int.Parse(this.howmuch.Text));
            string[] phoneNo = DummyInputClass.GetPhoneNumber(int.Parse(this.howmuch.Text));
            string[] email = DummyInputClass.GetMailAddress(int.Parse(this.howmuch.Text));


            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=" + this.DBname.Text + ";Uid=" + this.DBID.Text + ";Pwd=" + this.DBPW.Text + ""))
            {

                try//예외 처리
                {
                    connection.Open();
                    for (int i = 0; i < int.Parse(this.howmuch.Text); i++)
                    {

                        string query = "(";

                        if (this.Chk2.IsChecked.Value == true)
                        {
                            query += this.Column2.Text + ",";
                        }
                        if (this.Chk3.IsChecked.Value == true)
                        {
                            query += this.Column3.Text + ",";
                        }
                        if (this.Chk4.IsChecked.Value == true)
                        {
                            query += this.Column4.Text + ",";
                        }
                        if (this.Chk5.IsChecked.Value == true)
                        {
                            query += this.Column5.Text + ",";
                        }
                        if (this.Chk6.IsChecked.Value == true)
                        {
                            query += this.Column6.Text + ",";
                        }

                        query += ")";
                        query = query.Replace(",)", ")");

                        //query = query.Split(",)")[0] + ")";


                        string values = "(";

                        if (this.Chk2.IsChecked.Value == true)
                        {
                            values += "'" + names[i] + "',";
                        }
                        if (this.Chk3.IsChecked.Value == true)
                        {
                            values += "'" + age[i] + "',";
                        }
                        if (this.Chk4.IsChecked.Value == true)
                        {
                            values += "'" + address[i] + "',";
                        }
                        if (this.Chk5.IsChecked.Value == true)
                        {
                            values += "'" + phoneNo[i] + "',";
                        }
                        if (this.Chk6.IsChecked.Value == true)
                        {
                            values += "'" + email[i] + "',";
                        }

                        values += ")";
                        values = values.Replace(",)", ")");
                        //values = values.Split(",)")[0] + ")";


                        //+" ) values('" + names[i] + "', '" + age[i] + "','" + address[i] + "', '" + phoneNo[i] + "')";

                        //string sql = "SELECT * FROM mem";
                        string sql = "insert into " + this.TableName.Text + " " + query + " values" + values;

                        //ExecuteReader를 이용하여
                        //연결 모드로 데이타 가져오기
                        MySqlCommand cmd = new MySqlCommand(sql, connection);
                        //int a = cmd.ExecuteReader();

                        MySqlDataReader table = cmd.ExecuteReader();

                        //List<string> strList = new List<string>();


                        //while (table.Read())
                        //{
                        //    this.ListBox.Items.Add(table["name"]);

                        //    //strList.Add(table["name"]);
                        //    //Console.WriteLine("{0} {1}", table["idx"], table["header"], table["body"]);
                        //}
                        table.Close();

                    }
                    connection.Close();
                    select();
                }
                catch (Exception ex)
                {
                    this.ListBox.Items.Add(ex);

                }

            }
        }

        private void Init()
        {
            indexing = 0;

            //throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            indexing++;
            this.ListBox.Items.Clear();
            insert();
            //select();
        }
    }
}
