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
using System.Net;
using System.Threading;

namespace Messenger_Loop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		UserConnection client;
		IPAddress ip_server =  IPAddress.Parse("192.168.0.105");
		string Login;

		List<string> contactsList;

		public MainWindow()
        {
            InitializeComponent();
			AddContacts.IsEnabled = false;
			AddContacts.Visibility = Visibility.Hidden;
			contactsList = new List<string>();
		}

        #region Reg+Log
        private void LoginButton_Click(object sender, RoutedEventArgs e)
		{
			//ContactsScreen.Visibility = Visibility.Hidden;

			this.Cursor = Cursors.Wait;
            try
            {

            
			if (LoginBox.Text.Length >= 3 && PasswordBox.Password.Length >= 6 && Convert.ToInt32(PortBox.Text) >= 1000)
			{
				try
				{
					client = new UserConnection(ip_server.ToString(), int.Parse(PortBox.Text));
				}
				catch (Exception)
				{
					LoginMessageBlock.Text = "Wrong login or password or port!";
					LoginMessageBlock.Visibility = Visibility.Visible;
				}
				if (client.Connect())
				{
					client.Send("Logining");
					client.Read();
					client.Send(LoginBox.Text);
					client.Read();
					client.Send(PasswordBox.Password);
					

					string answer = client.Read();
					//Action action = () =>
					//{

					//};
					
					if (answer.Contains("Failed"))
					{
						LoginMessageBlock.Text = "Wrong login or password or port!";
						LoginMessageBlock.Visibility = Visibility.Visible;
					}
					else
					{
						Login = LoginBox.Text;
						Open(ContactsScreen);
						LoginMessageBlock.Visibility = Visibility.Hidden;
					}
				}
                else
                {
					LoginMessageBlock.Text = "Wrong login or password or port!";
					LoginMessageBlock.Visibility = Visibility.Visible;
				}


			}
			else
			{

				LoginMessageBlock.Text = "Wrong login or password or port!";
				LoginMessageBlock.Visibility = Visibility.Visible;
			}
			}
			catch(Exception)
            {
				LoginMessageBlock.Text = "Wrong login or password or port!";
				LoginMessageBlock.Visibility = Visibility.Visible;
			}
			this.Cursor = Cursors.Arrow;

		}
		private void RegRegistrationButton_Click(object sender, RoutedEventArgs e)
		{
			this.Cursor = Cursors.Wait;
			try
            {

            
			
			if (RegLogBox.Text.Length >= 3 && RegPasBox.Password.Length >= 6 && Convert.ToInt32(RegPortBox.Text) >= 1000)
			{
				try
				{
					client = new UserConnection(ip_server.ToString(), int.Parse(RegPortBox.Text));
				}
				catch (Exception)
				{
					RegMessageBlock.Text = "Wrong login or password or port!";
					RegMessageBlock.Visibility = Visibility.Visible;
				}
				if (client.Connect())
				{
					client.Send("Registration");
					client.Read();
					client.Send(RegLogBox.Text);
					client.Read();
					client.Send(RegPasBox.Password);
					
					string answer = client.Read();
					if (answer.Contains("Failed {Login}"))
					{
						RegMessageBlock.Text = "This Login is already exist!";
						RegMessageBlock.Visibility = Visibility.Visible;
					}
					else
					{
						Login = RegLogBox.Text;
						Open(ContactsScreen);
						RegMessageBlock.Visibility = Visibility.Hidden;
					}
				}
				else
				{
					RegMessageBlock.Text = "Wrong login or password or port!";
					RegMessageBlock.Visibility = Visibility.Visible;
				}

			}
			else
			{

				RegMessageBlock.Text = "Wrong login or password or port!";
				RegMessageBlock.Visibility = Visibility.Visible;
			}
			}
			catch(Exception)
            {
				RegMessageBlock.Text = "Wrong login or password or port!";
				RegMessageBlock.Visibility = Visibility.Visible;
			}
			this.Cursor = Cursors.Arrow;

		}

		private void LogLoginButton_Click(object sender, RoutedEventArgs e)
		{
			Open(LoginScreen);
			RegMessageBlock.Visibility = Visibility.Visible;
		}

		private void RegistrationButton_Click(object sender, RoutedEventArgs e)
		{
			Open(RegistrationScreen);
			LoginMessageBlock.Visibility = Visibility.Hidden;
		}

		#endregion

		private void Open(Border screen)
		{
			//Делаем все экраны невидимыми
			LoginScreen.Visibility = Visibility.Hidden;
			ContactsScreen.Visibility = Visibility.Hidden;
			ChatScreen.Visibility = Visibility.Hidden;
			RegistrationScreen.Visibility = Visibility.Hidden;
			AddContacts.Visibility = Visibility.Hidden;
			AddingNewContact.Visibility = Visibility.Hidden;
			RegMessageBlock.Visibility = Visibility.Hidden;
			AddMessageBoxWarning.Visibility = Visibility.Hidden;
			LoginMessageBlock.Visibility = Visibility.Hidden;

			//Делаем видимым необходиый экран
			screen.Visibility = Visibility.Visible;
			if(screen == ContactsScreen)
            {
				AddContacts.Visibility = Visibility.Visible;
				AddContacts.IsEnabled = true;
			

			}
		}


		private void ContactsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			if (ContactsList.SelectedIndex >= 0)
			{
				//Этот код будет написан позже
				//app.ChangeContact(ContactsList.SelectedIndex);
				//

				//app.LoadChat();
				//ChatName
				ContactsList.SelectedIndex = -1;
				ChatName.Text = ContactsList.Items.CurrentItem.ToString();

				Open(ChatScreen);
				
			}
		}

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
			Open(ContactsScreen);
			AddMessageBoxWarning.Visibility = Visibility.Hidden;
		}

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
			if(string.IsNullOrWhiteSpace( MessageBox.Text))
            {
				return;
            }
            client.Send("SetChat");
            client.Read();
            client.Send(MessageBox.Text);
            client.Read();
            client.Send(Login);
            client.Read();
            client.Send(ChatName.Text);

            MessagesList.Items.Add(MessageBox.Text);


		}

        


        

		private void DownloadList()
        {
			// Только ItemSource
			ContactsList.Items.Insert(0, "Add");
			ContactsList.Items.Add("Add");
		}

		private void AddToList(string Log)
		{
			// Только ItemSource
			client.Send("AddCotacts");
			client.Read();
			client.Send(Log);
			string answer = client.Read();
			if(answer.Contains("Success"))
            {
		

				contactsList.Add(Log);
				ContactsList.ItemsSource = null;
				ContactsList.ItemsSource = contactsList;
			}
            else
            {
				AddMessageBoxWarning.Text = "Uncorrect Login";
				AddMessageBoxWarning.Visibility = Visibility.Visible;

			}

			


		}


		private void AddContacts_Click(object sender, RoutedEventArgs e)
        {
			Open(AddingNewContact);
		}

        private void AddingConfirm_Click(object sender, RoutedEventArgs e)
        {
			bool already = false;
			if (AddLoginBox.Text.Length >= 3 && Login != AddLoginBox.Text.ToString())
			{
				//List<string> mylist = new List<string>();
				//private void btnAddToList_Click(object sender, System.Windows.RoutedEventArgs e)
				//{
				//	mylist.Add(txtList.Text);
				//	ListBox1.ItemsSource = null;
				//	ListBox1.ItemsSource = mylist;
				//}

				// Только ItemSource
				
				foreach(var item in contactsList)
                {
					if(item == AddLoginBox.Text)
                    {
						already = true;
						return;
                    }
                }

				if(already)
                {
					AddMessageBoxWarning.Text = "Uncorrect Login";
					AddMessageBoxWarning.Visibility = Visibility.Visible;
				}
				else
                {
					AddToList(AddLoginBox.Text);
				
				

					Open(ContactsScreen);
					AddMessageBoxWarning.Visibility = Visibility.Hidden;
				}
				

			}
			else
			{
				AddMessageBoxWarning.Text = "Uncorrect Login";
				AddMessageBoxWarning.Visibility = Visibility.Visible;
			}
		}

        private void RegPortBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
