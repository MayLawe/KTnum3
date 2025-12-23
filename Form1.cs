using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Text;
using System.Formats.Nrbf;
using System.Net.Http.Headers;
using System.Windows.Forms.Design;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormProject;

public partial class Form1 : Form
{
    
        
        public Form1()
        {
            GroupBox volumeBox = new GroupBox();
            volumeBox.Location = new System.Drawing.Point(20,50);
            volumeBox.Size = new System.Drawing.Size(200,150);
            
            volumeBox.Text = "Выберите громкость";
            
            CheckBox loudBox = new CheckBox();
            CheckBox middleBox = new CheckBox();
            CheckBox tinyLoudBox = new CheckBox();
            loudBox.Location = new Point(10,30);
            middleBox.Location = new Point(10,60);
            tinyLoudBox.Location = new Point(10,90);
            loudBox.Text = "Громко"; 
            middleBox.Text = "Средне";
            tinyLoudBox.Text = "Тихо";
            loudBox.CheckedChanged += volumeSendMessage;
            middleBox.CheckedChanged += volumeSendMessage;
            tinyLoudBox.CheckedChanged += volumeSendMessage;
            volumeBox.Controls.Add(loudBox);
            volumeBox.Controls.Add(middleBox);
            volumeBox.Controls.Add(tinyLoudBox);

            this.Controls.Add(volumeBox);
            GroupBox visualBox = new GroupBox();
            visualBox.Location = new System.Drawing.Point(220,50);
            visualBox.Size = new System.Drawing.Size(200,150);
            
            visualBox.Text = "Выберите вариант отображения";
            RadioButton smallBox = new RadioButton();
            RadioButton bigBox = new RadioButton();

            smallBox.Location = new Point(10,30);
            bigBox.Location = new Point(10,60);

            smallBox.Text = "Плоский";
            bigBox.Text = "Объемный";

            visualBox.Controls.Add(smallBox);
            visualBox.Controls.Add(bigBox);
            bigBox.CheckedChanged += visualCheckBoxForm;
            smallBox.CheckedChanged += visualCheckBoxForm;

            
            this.Controls.Add(visualBox);   

        


            InitializeComponent();
            
            
        }
        private void volumeSendMessage(object sender, EventArgs e)
        {   
            CheckBox cb = sender as CheckBox;
            if (cb != null && cb.Checked)
            {
                MessageBox.Show($"Выбрана громкость: {cb.Text}");
            }
            
            
                
            
        }
        private void visualCheckBoxForm(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            var ParentControl = rb.Parent;
            if (rb != null && rb.Checked)
            {
                
                string textOf = rb.Text;
                switch (textOf)
                {
                    case "Объемный":
                        ParentControl.BackColor = Color.RoyalBlue;
                        MessageBox.Show($"Выбрана визуальная тема:{rb.Text}");
                        ParentControl.BackColor = Color.Black;

                    
                        break;
                    case "Плоский":
                        MessageBox.Show($"Выбрана визуальная тема:{rb.Text}");
                        ParentControl.BackColor = Color.Yellow;
                        break;
                
                }   
                



            }
        }

}
        
