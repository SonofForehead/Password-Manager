using System;
using System.IO;
using System.Windows;

namespace Password_Manager.View
{
    public partial class CreatePassword : Window
    {
        public string passwordPath = @"Settings\Passwords.txt";
        public CreatePassword()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            WriteInfo();
        }

        private void WriteInfo() 
        {
            Directory.CreateDirectory(@"Settings\");

            File.AppendAllText(passwordPath, "{\n");

            CreateProfile("");
            CreateEmail("");
            CreateUser("");
            CreatePass("");

            string info = File.ReadAllText(passwordPath);
            Console.WriteLine(info);
            Console.ReadLine();
        }

        private void CreateProfile(string profile)
        {
            profile = ProfileText.Text;

            File.AppendAllText(passwordPath, "profile: " + profile + "\n");
        }

        private void CreateEmail(string email)
        {
            email = EmailText.Text;

            File.AppendAllText(passwordPath, "email: " + email + "\n");
        }

        private void CreateUser(string user)
        {
            user = UsernameText.Text;

            File.AppendAllText(passwordPath, "user: " + user + "\n");
        }

        private void CreatePass(string password)
        {
            password = PasswordText.Text;

            File.AppendAllText(passwordPath, "password: " + password + "\n" + "}" + "\n");
        }
    }
}