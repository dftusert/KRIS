using KRIS.database;
using KRIS.database.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KRIS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void gotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Логин") textBox.Clear();
        }

        private void lostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.TextLength == 0) textBox.Text = "Логин";
        }

        private void gotFocusPwd(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Пароль")
            {
                textBox.Clear();
                textBox.UseSystemPasswordChar = true;
            }
        }

        private void lostFocusPwd(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.TextLength == 0)
            {
                textBox.Text = "Пароль";
                textBox.UseSystemPasswordChar = false;
            }
        }

        private void loginUser(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            if (String.IsNullOrEmpty(login) || login.Equals("Логин")) MessageBox.Show("Не введен логин", "Информация");
            else if(String.IsNullOrEmpty(password) || password.Equals("Пароль")) MessageBox.Show("Не введен пароль", "Информация");
            password = getHash(getHash(password));

            Users user;
            string username = "";
            bool userAuth = false;
            List<string> rolenames = new List<string>();
            using (DBCtx db = new DBCtx())
            {
                user = (from u in db.Users
                       where u.username == login && u.password == password
                       select u).FirstOrDefault();

                if(user != null)
                {
                    userAuth = true;
                    username = user.username;
                    var roles = from ur in db.UserRole
                                from r in db.Role
                                where ur.role_id == r.id && ur.user_id == user.id
                                select r.rolename; 

                    Logs log = new Logs();
                    log.username = user.username;
                    log.acttime = DateTime.Now;

                    log.action = "Logined with roles: ";
                    foreach (var role in roles)
                    {
                        log.action += role + ' ';
                        rolenames.Add(role);
                    }

                    db.Logs.Add(log);
                    db.SaveChanges();
                }
            }

            if(!userAuth)
            {
                MessageBox.Show("Неправильный логин или пароль");
                return;
            }

            Kris kris = new Kris(username, rolenames);
            this.Hide();
            kris.ShowDialog();
            this.Close();
        }

        private string getHash(string text)
        {
            byte[] hashenc, bytes = Encoding.ASCII.GetBytes(text);
            string result = "";

            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                hashenc = md5.ComputeHash(bytes);
                foreach (var b in hashenc)
                    result += b.ToString("x2");
            }

            return result;
        }
    }
}
