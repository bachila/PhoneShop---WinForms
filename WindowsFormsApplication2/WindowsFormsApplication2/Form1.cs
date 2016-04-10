using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        BindingList<Phone> phones;
        BindingList<Option> options;
        public Form1()
        {
            InitializeComponent();

        }
        [Serializable]
        class Phone
        {
            string os;
            string name;
            double price;
            string imgPath;
            string processor;
            BindingList<Option> options;
            public string ImgPath1
            {
                get { return imgPath; }
                set { imgPath = value; }
            }
            public BindingList<Option> Options
            {
                get { return options; }
                set { options = value; }
            }
            public string Processor
            {
                get { return processor; }
                set { processor = value; }
            }
            public string Os
            {
                get { return os; }
                set { os = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Price
            {
                get { return price; }
                set { price = value; }
            }
            public string ImgPath
            {
                get { return imgPath; }
                set { imgPath = value; }
            }


        }
        [Serializable]
        class Option
        {
            string name;
            string description;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Description
            {
                get { return description; }
                set { description = value; }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region tab1
            options = new BindingList<Option>()
            {
                new Option(){Name = "Wi-Fi", Description = "Соединение с интернетом"},
                new Option(){Name = "Цветной экран", Description = "Можете различить больше цветов на экране"},
                new Option(){Name = "Две симки", Description = "Много звонков"}
            };
            phones = new BindingList<Phone>()
            {
                new Phone(){ Name = "samsung", ImgPath = @"samsung.jpg", Price = 200, Os = "android", Processor = "AMD", Options = new BindingList<Option>()
                                            {
                                               options[0],
                                               options[1]
                                            }
                },
                new Phone(){ Name = "microsoft", ImgPath = @"microsoft.jpg", Price = 600, Os = "windows", Processor = "Intel", Options = new BindingList<Option>()
                                            {
                                               options[0],
                                               options[1],
                                               options[2]
                                            } },
                new Phone(){ Name = "iphone", ImgPath = @"iphone.jpg", Price = 800,Os = "ios", Processor = "Intel", Options = new BindingList<Option>()
                                            {
                                               options[0],
                                            }   },
                new Phone(){ Name = "nokia", ImgPath = @"nokia.jpg", Price = 100,Os = "-", Processor = "Intel", Options = new BindingList<Option>()
                                            {
                                               options[1],
                                               options[2]
                                            }   }
            };



            listBoxPhone.DataSource = phones;
            listBoxPhone.DisplayMember = "Name";

            checkedListBoxEditOption.DataSource = options;
            checkedListBoxEditOption.DisplayMember = "Name";
            #endregion
            #region tab2
            AddOption.Enabled = false;

            #endregion
        }

        private void listBoxPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPhone.SelectedItem != null)
            {
                Phone phone = (Phone)listBoxPhone.SelectedItem;
                pictureBoxPhone.ImageLocation = textBoxEditPicture.Text = phone.ImgPath;
                textBoxModel.Text = textBoxEditModel.Text = phone.Name;
                textBoxPrice.Text = textBoxEditPrice.Text = phone.Price.ToString();
                textBoxOS.Text = textBoxEditOs.Text = phone.Os;
                textBoxProc.Text = textBoxEditProcessor.Text = phone.Processor;
                for (int i = 0; i < options.Count; i++)
                {
                    checkedListBoxEditOption.SetItemChecked(i, false);
                    foreach (Option item in phone.Options)
                    {
                        if (options[i].Name == item.Name)
                        {
                            int a = checkedListBoxEditOption.FindString(item.Name);
                            checkedListBoxEditOption.SetItemChecked(a, true);
                        }
                    }
                }
                listBoxOption.DataSource = phone.Options;
                listBoxOption.DisplayMember = "Name";

            }
        }

        private void BtnDlt_Click(object sender, EventArgs e)
        {
            Phone phone = (Phone)listBoxPhone.SelectedItem;
            phones.Remove(phone);
            listBoxPhone.DataSource = null;
            listBoxPhone.DataSource = phones;
            listBoxPhone.DisplayMember = "Name";
        }

        private void BtnDltAllList_Click(object sender, EventArgs e)
        {
            phones.Clear();
            listBoxPhone.DataSource = null;
            listBoxPhone.DataSource = phones;
        }

        private void SaveBtnEdit_Click(object sender, EventArgs e)
        {
            Phone phone = (Phone)listBoxPhone.SelectedItem;
            phone.Name = textBoxEditModel.Text;
            phone.Os = textBoxEditOs.Text;
            if (textBoxEditPrice.TextLength <= 0)
            {
               phone.Price = 0;
            }
            else
            {
                phone.Price = Convert.ToInt32(textBoxEditPrice.Text);
            }
            phone.Processor = textBoxEditProcessor.Text;
            phone.ImgPath = textBoxEditPicture.Text;
            phone.Options.Clear();
            for (int i = 0; i < options.Count; i++)
            {
                if (checkedListBoxEditOption.GetItemChecked(i))
                {
                    phone.Options.Add(options[i]);
                }
            }
            listBoxPhone.DataSource = null;
            listBoxPhone.DataSource = phones;
            listBoxPhone.DisplayMember = "Name";


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void AddOption_Click(object sender, EventArgs e)
        {
            options.Add(new Option() { Name = textBoxAddOption.Text });
            checkedListBoxEditOption.DataSource = null;
            checkedListBoxEditOption.DataSource = options;
            checkedListBoxEditOption.DisplayMember = "Name";

        }

        private void addPhone_Click(object sender, EventArgs e)
        {
            BindingList<Option> opt = new BindingList<Option>(); ;
            for (int i = 0; i < options.Count; i++)
            {
                if (checkedListBoxEditOption.GetItemChecked(i))
                {
                    opt.Add(new Option(){Name = options[i].Name});
                }
            }
            int phoneTemp;
            if (textBoxEditPrice.TextLength <= 0)
            {
                phoneTemp = 0;
            }
            else
            {
                phoneTemp = Convert.ToInt32(textBoxEditPrice.Text);
            }
            phones.Add(new Phone()
            {
                Name = textBoxEditModel.Text,
                ImgPath = textBoxEditPicture.Text,
                Os = textBoxEditOs.Text,
                Price = phoneTemp,
                Processor = textBoxEditProcessor.Text,
                Options = opt
            });
            listBoxPhone.DataSource = null;
            listBoxPhone.DataSource = phones;
            listBoxPhone.DisplayMember = "Name";
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(@"phone.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, phones);
            }
            using (FileStream fs = new FileStream(@"option.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, options);
            }
        }

        private void ReturnPhone_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"option.txt") && File.Exists(@"phone.txt"))
            {
                using (FileStream fs = new FileStream(@"option.txt", FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    options = (BindingList<Option>)formatter.Deserialize(fs);
                    //checkedListBoxEditOption.DataSource = null;
                    //checkedListBoxEditOption.DataSource = options;
                    //checkedListBoxEditOption.DataSource = "Name";
                }
                using (FileStream fs = new FileStream(@"phone.txt", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    phones = (BindingList<Phone>)formatter.Deserialize(fs);
                    listBoxPhone.DataSource = null;
                    listBoxPhone.DataSource = phones;
                    listBoxPhone.DisplayMember = "Name";
                    checkedListBoxEditOption.DataSource = null;
                    checkedListBoxEditOption.DataSource = options;
                    checkedListBoxEditOption.DisplayMember = "Name";
                }
            }
            else
            {
                MessageBox.Show("Файл не существует", "Для начала создайте файл", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClrFld_Click(object sender, EventArgs e)
        {
            Phone phone = (Phone)listBoxPhone.SelectedItem;
            var tab = tabPage2.Controls.OfType<TextBox>();
            foreach (var item in tab)
            {
                item.Text = "";
            }
            for (int i = 0; i < options.Count; i++)
            {
                checkedListBoxEditOption.SetItemChecked(i, false);
            }
        }

        private void textBoxEditPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 47 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxAddOption_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAddOption.TextLength <= 0)
            {
                AddOption.Enabled = false;
            }
            else
            {
                AddOption.Enabled = true;
            }
        }

        private void buttonDltOption_Click(object sender, EventArgs e)
        {
            int a = checkedListBoxEditOption.SelectedIndex;
            options.RemoveAt(a);
            checkedListBoxEditOption.DataSource = null;
            checkedListBoxEditOption.DataSource = options;
            checkedListBoxEditOption.DisplayMember = "Name";
        }


        private void textBoxEditPicture_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            var MyFiles = ((string[])e.Data.GetData(DataFormats.FileDrop));
            var filePath = MyFiles[0];
            textBoxEditPicture.Text = filePath;

        }
    }
}
