﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Configuration;

namespace NotarialOfficeCustomers
{
    public partial class LoginForm : Telerik.WinControls.UI.RadForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radButtonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            // строка подключаения, данные для подключения берутся с файла App.config через system.configuration
            string connectionString = ConfigurationManager.ConnectionStrings["DBNotarialOfficeConnectionString"].ToString();

         
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            // получение данных с формы
            string login = userName.Text;
            string password = userPassword.Text;
            // запрос к базе данных на выборку с таблицы пользователей
            SqlCommand cmd = new SqlCommand("SELECT userName, userPass FROM [user] WHERE userName = '" + login + "'AND userPass='" + password + "' AND role = 'admin'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // если результат больше 0, то пользователь админ
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Авторизация администратора в системе прошла успешно!");
                PanelForm panelForm = new PanelForm();
                panelForm.Show();
                this.Hide();
            }
            else
            {
                // проверка автоирационных данных пользователя не админа
                SqlCommand cmdh = new SqlCommand("SELECT userName, userPass FROM [user] WHERE userName = '" + login + "'AND userPass='" + password + "'", con);

                SqlDataAdapter dah = new SqlDataAdapter(cmdh);
                DataTable dth = new DataTable();
                dah.Fill(dth);
                // если есть результат, пользователь авторизован
                if (dth.Rows.Count > 0)
                {
                    MessageBox.Show("Авторизация помощника в системе прошла успешно!");
                    PanelFormNoAdmin panelFormNoAdmin = new PanelFormNoAdmin();
                    panelFormNoAdmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка входа в систему");
                }
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
