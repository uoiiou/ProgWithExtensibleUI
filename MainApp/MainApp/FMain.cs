using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using AttributePanelLoad;
using AttributeGroupBox;
using AttributeTabControl;

namespace MainApp
{
    public partial class FShowComponents : Form
    {
        private List<string> formnames = new List<string>();
        private int index = 0;

        public FShowComponents()
        {
            InitializeComponent();


            tabcontrol.TabPages.Clear();
            List<string> waysToFiles = getWaysToFiles();

            foreach (string wayToFile in waysToFiles)
            {
                loadForms(wayToFile);
                index++;
            }
        }

        private List<string> getWaysToFiles()
        {
            List<string> result = new List<string>();

            string currdir = Directory.GetCurrentDirectory();
            string directory = Directory.GetParent(currdir).Parent.Parent.Parent.Parent.FullName;
            string folder = directory + "\\TestedApps\\";

            string[] projects = Directory.GetDirectories(folder);

            for (int i = 0; i < projects.Length; i++)
            {
                string dirname = Path.GetFileName(projects[i]);
                formnames.Add(dirname);
                string[] files = Directory.GetFiles(projects[i] + "\\", "*.dll", SearchOption.AllDirectories);

                for (int j = 0; j < files.Length; j++)
                    if (string.Compare(Path.ChangeExtension(Path.GetFileName(files[j]), null), dirname) == 0)
                    {
                        result.Add(files[j]);
                        break;
                    }
            }

            return result;
        }

        private void loadForms(string wayToFile)
        {
            Assembly assembly = Assembly.LoadFrom(wayToFile);
            Type[] typesFromAsm = assembly.GetTypes();

            for (int i = 0; i < typesFromAsm.Length; i++)
            {
                if (typesFromAsm[i].BaseType == typeof(Form))
                {
                    List<string> valueFromAttributes = getValuesFromAttributes(typesFromAsm[i]);

                    if (valueFromAttributes.Count != 0)
                    {
                        loadForm(typesFromAsm[i], valueFromAttributes);
                    }
                }
            }
        }

        private List<string> getValuesFromAttributes(Type type)
        {
            List<string> result = new List<string>();
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            foreach(Attribute attribute in attributes)
            {
                if (attribute is OnPanelAttribute)
                {
                    OnPanelAttribute ona = (OnPanelAttribute)attribute;

                    if (ona.getCanBeOnPanel())
                        result.Add("OnPanel");
                }
                else if (attribute is OnGroupBoxAttribute)
                {
                    OnGroupBoxAttribute ogba = (OnGroupBoxAttribute)attribute;

                    if (ogba.getCanBeOnGroupBox())
                        result.Add("OnGroupBox");
                }
                else if (attribute is OnTabControlAttribute)
                {
                    OnTabControlAttribute otca = (OnTabControlAttribute)attribute;

                    if (otca.getCanBeOnTabControl())
                        result.Add("OnTabControl");
                }
            }

            return result;
        }

        private void loadForm(Type type, List<string> valueFromAttribute)
        {
            foreach(string value in valueFromAttribute)
            {
                if (value == "OnPanel")
                {
                    loadFormOn_Panel_GroupBox(type, value);
                }
                else if (value == "OnGroupBox")
                {
                    loadFormOn_Panel_GroupBox(type, value);
                }
                else if (value == "OnTabControl")
                {
                    loadFormOnTabControl(type);
                }
            }
        }

        private void loadFormOnTabControl(Type type)
        {
            object obj = Activator.CreateInstance(type);
            Form form = (Form)obj;

            TabPage tabpage = new TabPage();
            tabpage.Name = "tabpage" + formnames[index];
            tabpage.Text = formnames[index];

            while (form.Controls.Count != 0)
            {
                Control control = form.Controls[0];

                tabpage.Controls.Add(control);
            }

            tabcontrol.TabPages.Add(tabpage);
        }
        
        private int getHeight(string control_type)
        {
            int result = 0;

            foreach (Control control in (control_type == "OnPanel") ? panel.Controls : groupBox.Controls)
            {
                if (control.Bottom > result)
                    result = control.Bottom;
            }

            return result + 20;
        }

        private void loadFormOn_Panel_GroupBox(Type type, string control_type)
        {
            object obj = Activator.CreateInstance(type);
            Form form = (Form)obj;
            int height = getHeight(control_type);

            while (form.Controls.Count != 0)
            {
                Control control = form.Controls[0];

                control.Top += height;

                if (control_type == "OnPanel")
                    panel.Controls.Add(control);
                else
                    groupBox.Controls.Add(control);
            }
        }
    }
}