using System;
using System.IO;
using System.Windows;

namespace Password_Manager.View
{
    public partial class CreatePassword : Window
    {
        public string email = "";
        public string passwordPath = @"Settings\Passwords.txt";
        public CreatePassword()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            email = EmailText.Text;

            WriteInfo();
        }

        private void WriteInfo() 
        {
            Directory.CreateDirectory(@"Settings\");

            File.WriteAllText(passwordPath, "{ Email: " + email + " }");
            string info = File.ReadAllText(passwordPath);
            Console.WriteLine(info);
            Console.ReadLine();
        }
    }
}