using System;
using System.Windows.Forms;

namespace KEP_Diffie_Hellman
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        MainForm formA, formB;
        private void OnClickButtonParticipantA(object sender, EventArgs e)
        {
            if (formA != null) return;
            formA = new MainForm();
            formA.Text = "Участник A";
            formA.buttonSendAcceptedValue.Text = "Отправить X";
            formA.buttonAcceptAcceptedValue.Text = "Принять Y";
            formA.label_selectedValue.Text = "Число x:";
            formA.label_acceptedValue.Text = "Принятое число Y:";
            formA.Show();
        }
        private void OnClickButtonParticipantB(object sender, EventArgs e)
        {
            if (formB != null) return;
            formB = new MainForm();
            formB.Text = "Участник В";
            formB.buttonSendAcceptedValue.Text = "Отправить Y";
            formB.buttonAcceptAcceptedValue.Text = "Принять Х";
            formB.label_selectedValue.Text = "Число y:";
            formB.label_acceptedValue.Text = "Принятое число X:";
            formB.Show();
        }
    }
}
