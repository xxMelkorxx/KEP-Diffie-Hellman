using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace KEP_Diffie_Hellman
{
    public partial class MainForm : Form
    {
        private uint setValue, sentValue, acceptedValue, n, g, key;

        public MainForm()
        {
            InitializeComponent();
        }
        private void OnClickButtonSendAcceptedValue(object sender, EventArgs e)
        {
            sentValue = DH.GetOpenValue(g, n, setValue);
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
                using (var sw = new StreamWriter(saveDialog.OpenFile(), Encoding.Default))
                    sw.WriteLine(sentValue);
            else return;
        }
        private void OnClickButtonAcceptAcceptedValue(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
                using (var sr = new StreamReader(dialog.OpenFile(), Encoding.Default))
                    textBox_acceptedValue.Text = sr.ReadToEnd();
            else return;
            buttonGetKey.Enabled = true;
        }
        /// <summary>
        /// Событие клика "Отправить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonSend(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
                using (var sw = new StreamWriter(saveDialog.OpenFile(), Encoding.Default))
                    sw.WriteLine(textBox_moduleN.Text + " " + textBox_footingG.Text);
            else return;
        }
        /// <summary>
        /// Событие клика "Принять".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonAccept(object sender, EventArgs e)
        {
            string[] subs;
            var dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
                using (var sr = new StreamReader(dialog.OpenFile(), Encoding.Default))
                    subs = sr.ReadToEnd().Split(' ');
            else return;

            textBox_moduleN.Text = subs[0];
            textBox_footingG.Text = subs[1];
            buttonSendAcceptedValue.Enabled = true;
        }
        /// <summary>
        /// Событие клика "Сгенерировать" значения n и g.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonGeneratePN(object sender, EventArgs e)
        {
            DH.GeneratePN(ref n, ref g);
            textBox_moduleN.Text = n.ToString();
            textBox_footingG.Text = g.ToString();
            buttonSend.Enabled = true;
            buttonSendAcceptedValue.Enabled = true;
        }
        /// <summary>
        /// Событие клика "Получить" вычисленный код.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonGetKey(object sender, EventArgs e)
        {
            key = DH.GetKey(acceptedValue, setValue, n);
            textBox_key.Text = key.ToString();
        }
        /// <summary>
        /// Инициализация заданного значения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextChangedTextBoxSetValue(object sender, EventArgs e)
        {
            setValue = (textBox_setValue.Text == "") ? 0 : Convert.ToUInt32(textBox_setValue.Text);
        }
        /// <summary>
        /// Инициализация полученного значения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextChangedTextBoxAcceptedValue(object sender, EventArgs e)
        {
            acceptedValue = Convert.ToUInt32(textBox_acceptedValue.Text);
        }
        /// <summary>
        /// Инициализация модуля n.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextChangedTextBoxModuleN(object sender, EventArgs e)
        {
            n = Convert.ToUInt32(textBox_moduleN.Text);
        }
        /// <summary>
        /// Инициализация основания g.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextChangedTextBoxFootingG(object sender, EventArgs e)
        {
            g = Convert.ToUInt32(textBox_footingG.Text);
        }
    }
}