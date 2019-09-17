using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_prod_msilva
{
    public partial class Form1 : Form
    {
        private Data data = new Data();
        public Form1()
        {
            InitializeComponent();

            string ssql = "select * from Pessoas";
            string ssql_activity = "select * from Actividades";
            this.data.FillCombo(combo_Users, ssql, "nome");
            this.data.FillCombo(combo_activity, ssql_activity, "designacao");
        }

        private void btn_listGrid_Click(object sender, EventArgs e)
        {
            string ssql = "SELECT r.id, p.nome, r.quota, a.designacao " +
                          "FROM Registos_Associacao r, Pessoas p, Actividades a " +
                          "WHERE r.pessoa = p.id " +
                          "AND a.id = r.actividade";
            grid_association.DataSource = this.data.GetData(ssql);
            grid_association.AutoResizeColumns();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.grid_association.DataSource = null;
            this.grid_association.Rows.Clear();
        }

        private void btn_listPeople_Click(object sender, EventArgs e)
        {
            this.grid_association.DataSource = this.data.GetData("select * from Pessoas");
            grid_association.AutoResizeColumns();
        }

        private void btn_activities_Click(object sender, EventArgs e)
        {
            this.grid_association.DataSource = this.data.GetData("select * from Actividades");
            grid_association.AutoResizeColumns();
        }

        /*
         * Buttons to add new info to the database
         */
        private void btn_newPerson_Click(object sender, EventArgs e)
        {
            string name = txt_insertName.Text;
            int year = Convert.ToInt32(txt_insert_Year.Text);
            string gender = txt_insertGender.Text;

            this.data.AddData(name, year, gender);
        }

        private void btn_addPersonAtActivity_Click(object sender, EventArgs e)
        {
            int name = Convert.ToInt32(combo_Users.SelectedValue);
            string activity = combo_activity.SelectedValue.ToString();
            string quote = txt_YesNo.Text;

            this.data.AddActivityRegisterData(name, activity, quote);
        }
        private void btn_insertNewActivity_Click(object sender, EventArgs e)
        {
            string id = txt_insertCodeActivity.Text;
            string designation = txt_insertActivityName.Text;

            this.data.AddNewActivity(id, designation);
        }

        /*
         * Method and controls to find the users from the specific gender 
         * and that the age is above X
         */
        private void ListByGender()
        {
            string gender = "";
            int age;
            try
            {
                age = Convert.ToInt32(txt_ageToSearch.Text);
            } catch (Exception)
            {
                age = 0;
            }            

            if (rd_male.Checked) 
                gender = "M"; 
            if(rd_female.Checked)  
                gender = "F";

            string query = $"select * from Pessoas where sexo = '{gender}' and (2019 - ano_nascimento) > {age}";
            grid_answers.DataSource = this.data.GetData(query);
           
        }   

        private void rd_male_CheckedChanged(object sender, EventArgs e)
        {
            ListByGender();
        }

        private void rd_female_CheckedChanged(object sender, EventArgs e)
        {
            ListByGender();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListByGender();
        }

        /*
         * Using the datatable and the sql query to get the necessary data
         * then converting those query results to an int which are saved at the row[0][0]
         */
        private void btn_Mbox_Click(object sender, EventArgs e)
        {
            DataTable data = this.data.GetData("select count(*) from Pessoas where sexo = 'M'");
            int count_male = Convert.ToInt32(data.Rows[0][0]);

            data = this.data.GetData("select count(*) from Pessoas where sexo = 'F'");            
            int count_female = Convert.ToInt32(data.Rows[0][0]);
            
            data = this.data.GetData("select count(*) from Pessoas");
            int count_total = Convert.ToInt32(data.Rows[0][0]);
            
            MessageBox.Show($"Esta associação tem no total {count_total} pessoas, " +
                $"sendo {count_female} do sexo feminino e {count_male} do sexo masculino.");
        }

        /*
         * Method takes the value from the grid currently selected
         * then we apply it to variables to pass it to the update method 
         * from the data class
         */
        public string GetGridValue(int cell)
        {
            return grid_association.CurrentRow.Cells[cell].Value.ToString();
        }


        /*
         * Button controls that update the information for the person and activity
         */
        private void btn_updateInfo_Click(object sender, EventArgs e)
        {
            string id = GetGridValue(0);
            string designation = GetGridValue(1);

            this.data.UpdateActivityInfo(id, designation);
        }

        private void btn_updatePerson_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GetGridValue(0));
            string name = GetGridValue(1);
            int bday = Convert.ToInt32(GetGridValue(2));
            string gender = GetGridValue(3);

            this.data.UpdatePersonInfo(id, name, bday, gender);
        }

      
    }
}
