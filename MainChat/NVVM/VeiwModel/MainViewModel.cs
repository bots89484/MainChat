using MainChat.Core;
using MainChat.NVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainChat.NVVM.VeiwModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        /* Commands */
        public RelayCommand SendCommand { get; set; }

        private ContactModel _SelectedContact;

        public ContactModel SelectedContact
        {
            get { return _SelectedContact; }
            set { _SelectedContact = value;
                OnPropertyChanged();
            }
        }


        private string _message;

        public string Message
        {
            get { return _message; }
            set 
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
            Messages.Add(new MessageModel
                    {
                       Message = Message,
                       FirstMessage = false
                    });

                Message = "";

            });

            Messages.Add(new MessageModel
            {

                Username = "Allison",
                UsernameColor = "409aff",
                ImageSource = "https://imgur.com/a/SXc6y4H.png",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true,
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {

                    Username = "Allison",
                    UsernameColor = "409aff",
                    ImageSource = "https://imgur.com/a/SXc6y4H.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false,
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {

                    Username = "Delta",
                    UsernameColor = "409aff",
                    ImageSource = "https://imgur.com/a/SXc6y4H.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });
            }

            Messages.Add(new MessageModel
            {

                Username = "Delta",
                UsernameColor = "409aff",
                ImageSource = "https://imgur.com/a/SXc6y4H.png",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                { 
                    Username = $"Allison {i}",
                    ImageSource = "https://i.imgur.com/i2szIsp.png",
                    Messages = Messages
                });
            }
        }
    }
}
