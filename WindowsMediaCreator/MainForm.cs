using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Newtonsoft.Json;

namespace WindowsMediaCreator
{
    public partial class MainForm : Form
    {
        // Lista para almacenar los ítems originales
        private List<ListViewItem> originalItems = new List<ListViewItem>();

        private class Archivo
        {
            public string edition { get; set; }
            public string windows { get; set; }
            public string arch { get; set; }
            public string version { get; set; }
            public string develooper { get; set; }
            public string size { get; set; }
            public string server { get; set; }
        }

        private static SynchronizationContext synchronizationContext;
        public MainForm()
        {
            InitializeComponent();

            synchronizationContext = SynchronizationContext.Current;
            configuraListView();
            SetLanguage(Properties.Settings.Default.lang);
            RefreshUI();
        }

        private void configuraListView()
        {
            listViewArchivos.View = View.Details;
            listViewArchivos.Columns.Add("", 18);
            listViewArchivos.Columns.Add("Edition", 95);
            listViewArchivos.Columns.Add("Windows", 160);
            listViewArchivos.Columns.Add("Arch", 40);
            listViewArchivos.Columns.Add("Version", 80);
            listViewArchivos.Columns.Add("Mod by", 0);
            listViewArchivos.Columns.Add("Size", 58);
            listViewArchivos.Columns.Add("Server", 0);
            listViewArchivos.LabelEdit = false;
            listViewArchivos.AllowColumnReorder = false;

            //Obtener los datos del servidor
            getData();

            //Seleccionar el primer index del comboBox
            cmbFilter.SelectedIndex = 0;
        }

        private async void getData()
        {
            try
            {
                await Task.Run(async () =>
                    {
                        //Archivo json con los datos de las descargas
                        List<Archivo> winDatos = await "https://servidor.com/APP/WINDOWS_ISO/datas.js".GetJsonAsync<List<Archivo>>();
                        foreach (Archivo archivo in winDatos)
                        {
                            synchronizationContext.Post(value =>
                            {
                                var datos = (Archivo)value;
                                listViewArchivos.Items.Add(new
                                    ListViewItem(new[]
                                    {
                                        "",
                                        datos.edition,
                                        datos.windows,
                                        datos.arch,
                                        datos.version,
                                        datos.develooper,
                                        datos.size,
                                        datos.server
                                    }));
                            }, archivo);
                        }
                    });

                // Copiar los ítems del ListView a la lista originalItems
                foreach (ListViewItem item in listViewArchivos.Items)
                {
                    // Clonar el ítem para evitar referencias a los ítems del ListView
                    originalItems.Add((ListViewItem)item.Clone());
                }
            }
            catch { MessageBox.Show(GetResourceString("serverError"), "WMC", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        string server_url;
        string name;
        string version;
        string size;
        string by;
        string winver;
        private void listViewArchivos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < listViewArchivos.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    listViewArchivos.Items[i].Checked = false;
                }
            }

            if (e.NewValue == CheckState.Checked)
            {
                listViewArchivos.Items[e.Index].Selected = true;
                ListViewItem listViewItem = listViewArchivos.Items[e.Index];

                server_url = listViewItem.SubItems[7].Text;
                name = listViewItem.SubItems[1].Text;
                version = listViewItem.SubItems[4].Text;
                size = listViewItem.SubItems[6].Text;
                by = listViewItem.SubItems[5].Text;
                winver = listViewItem.SubItems[2].Text;
                btnDownload.Enabled = true;
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                listViewArchivos.Items[e.Index].Selected = false;
                btnDownload.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                DownloadForm download = new DownloadForm(server_url, this, Properties.Settings.Default.lang,by);
                download.lblName.Text = name;
                download.lblDev.Text = GetResourceString("ModBy") + by;
                download.lblVersion.Text = GetResourceString("ModVersion") +": "+ version;
                download.lblSize.Text = GetResourceString("ModSize") + ": "+ size;
                download.lblwinver.Text = GetResourceString("lblwinver") + winver;
                download.Show();
                this.Hide();
            }
            catch { }
        }

        private void listViewArchivos_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            // Desactivar el controlador de eventos
            listViewArchivos.ColumnWidthChanged -= listViewArchivos_ColumnWidthChanged;

            int columnIndex = e.ColumnIndex;

            switch (columnIndex)
            {
                case 0:
                    listViewArchivos.Columns[0].Width = 18; break;
                case 1:
                    listViewArchivos.Columns[1].Width = 95; break;
                case 2:
                    listViewArchivos.Columns[2].Width = 160; break;
                case 3:
                    listViewArchivos.Columns[3].Width = 40; break;
                case 4:
                    listViewArchivos.Columns[4].Width = 80; break;
                case 5:
                    listViewArchivos.Columns[5].Width = 0; break;
                case 6:
                    listViewArchivos.Columns[6].Width = 58; break;
                case 7:
                    listViewArchivos.Columns[7].Width = 0; break;
                default:
                    break;
            }


            // Volver a activar el controlador de eventos
            listViewArchivos.ColumnWidthChanged += listViewArchivos_ColumnWidthChanged;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            Filtro(txtFind.Text.ToLower(),cmbFilter.SelectedIndex);
            if (string.IsNullOrEmpty(txtFind.Text))
                rdGeneral.Checked = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            GetInfo infoForm = new GetInfo(Properties.Settings.Default.lang);
            infoForm.ShowDialog();

            // Mostrar la información obtenida
            string systemInfo = infoForm.SystemInfo;
            MessageBox.Show(systemInfo, GetResourceString("SysInfo"), MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            // Muestra el menú en la posición del botón
            Point pos = btnLang.PointToScreen(new Point(0, btnLang.Height));
            mnuLang.Show(pos);
        }

        private void mnuEnglish_Click(object sender, EventArgs e)
        {
            SetLanguage("en");

            Properties.Settings.Default.lang = "en";
            Properties.Settings.Default.Save();

            RefreshUI();
        }

        private void SetLanguage(string languageCode)
        {
            // Establecer la cultura global de la aplicación
            CultureInfo cultureInfo = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }

        private void RefreshUI()
        {
            foreach (Control control in this.Controls)
            {
                control.Text = GetResourceString(control.Name);
            }
            Text = GetResourceString("MainForm");
            UpdateListViewColumns();
            UpdateComboFilter();
        }

        private void UpdateComboFilter()
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add(GetResourceString("listViewArchivos_Column1"));
            cmbFilter.Items.Add("Windows");
            cmbFilter.Items.Add(GetResourceString("listViewArchivos_Column3"));
            cmbFilter.Items.Add(GetResourceString("ModVersion"));
            cmbFilter.Items.Add(GetResourceString("ModSize"));
            cmbFilter.SelectedIndex = 0;
        }

        private void UpdateListViewColumns()
        {
            listViewArchivos.Columns[1].Text = GetResourceString("listViewArchivos_Column1"); // Edition
            listViewArchivos.Columns[3].Text = GetResourceString("listViewArchivos_Column3"); // Arch
            listViewArchivos.Columns[4].Text = GetResourceString("ModVersion"); // Version
            listViewArchivos.Columns[5].Text = GetResourceString("ModBy"); // Mod by
            listViewArchivos.Columns[6].Text = GetResourceString("ModSize"); // Size

            listViewArchivos.Refresh();
        }

        private string GetResourceString(string name)
        {
            return Properties.Resources.ResourceManager.GetString(name);
        }

        private void mnuSpanish_Click(object sender, EventArgs e)
        {
            SetLanguage("es");

            Properties.Settings.Default.lang = "es";
            Properties.Settings.Default.Save();

            RefreshUI();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WindowsMediaCreator" +
               Environment.NewLine + GetResourceString("ModVersion") + ": " + "1.2" +
               Environment.NewLine + GetResourceString("build") + " LYK011024" +
               Environment.NewLine + GetResourceString("DevBy") +
               Environment.NewLine + GetResourceString("Disclaimer"),
               GetResourceString("About"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdWin10_CheckedChanged(object sender, EventArgs e)
        {
            Filtro("windows 10",1);
        }

        private void rdWin11_CheckedChanged(object sender, EventArgs e)
        {
            Filtro("windows 11",1);
        }

        private void Filtro(string filtro, int tipo)
        {
            // Obtener el texto del filtro
            string filter = filtro;

            // Limpiar el ListView y luego agregar los ítems filtrados
            listViewArchivos.Items.Clear();

            // Si el TextBox está vacío, mostrar todos los ítems originales
            if (string.IsNullOrWhiteSpace(filter))
            {
                listViewArchivos.Items.AddRange(originalItems.ToArray());
            }
            else
            {
                // Filtrar y mostrar los ítems que coinciden con el filtro
                foreach (ListViewItem item in originalItems)
                {
                    int index = tipo;
                    switch (index)
                    {
                        case 0:
                            {
                                if (item.SubItems[1].Text.ToLower().Contains(filter))
                                {
                                    listViewArchivos.Items.Add(item);
                                }
                                break;
                            }
                        case 1:
                            {
                                if (item.SubItems[2].Text.ToLower().Contains(filter))
                                {
                                    listViewArchivos.Items.Add(item);
                                }
                                break;
                            }
                        case 2:
                            {
                                if (item.SubItems[3].Text.ToLower().Contains(filter))
                                {
                                    listViewArchivos.Items.Add(item);
                                }
                                break;
                            }
                        case 3:
                            {
                                if (item.SubItems[4].Text.ToLower().Contains(filter))
                                {
                                    listViewArchivos.Items.Add(item);
                                }
                                break;
                            }
                        case 4:
                            {
                                if (item.SubItems[6].Text.ToLower().Contains(filter))
                                {
                                    listViewArchivos.Items.Add(item);
                                }
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
        }

        private void rdGeneral_CheckedChanged(object sender, EventArgs e)
        {
            Filtro(null,0);
        }
    }
}
