using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMediaCreator
{
    public partial class GetInfo : Form
    {
        public string SystemInfo { get; private set; }
        public GetInfo(string lang)
        {
            InitializeComponent();

            GetSystemInfo();

            SetLanguage(lang);
            RefreshUI();
        }

        private void RefreshUI()
        {
            lblInfo.Text = GetResourceString("lblInfo");
        }

        private string GetResourceString(string name)
        {
            return Properties.Resources.ResourceManager.GetString(name);
        }

        private void SetLanguage(string languageCode)
        {
            // Establecer la cultura global de la aplicación
            CultureInfo cultureInfo = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }

        private void GetSystemInfo()
        {
            var ram = GetRAM();
            var os = GetOperatingSystem();
            var processor = GetProcessor();
            var arch = GetArchitecture();
            string recommendedOS = RecommendOS(arch, ram);

            // Generar la información a mostrar
            SystemInfo = $"RAM: {ram} GB\n" + 
                GetResourceString("operatingS") + $"{os.Edition} ({os.Version})\n" +
                         GetResourceString("Processor") + $"{processor}\n"+ 
                         GetResourceString("listViewArchivos_Column3") + $": {arch}\n\n" +
                         GetResourceString("rOp") + $"{recommendedOS}";

            UpdateProgress();
        }

        private async void UpdateProgress()
        {
            for (int i = 5; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(10);
            }
            if (progressBar1.Value == 100)
                Close();
        }

        private double GetRAM()
        {
            double ram = 0;
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    ram = Math.Round(Convert.ToDouble(obj["TotalPhysicalMemory"]) / 1073741824, 2); // Convertir a GB
                }
            }
            return ram;
        }

        private (string Edition, string Version) GetOperatingSystem()
        {
            string edition = "";
            string version = "";
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    edition = obj["Caption"].ToString();
                    version = obj["Version"].ToString();
                }
            }
            return (edition, version);
        }

        private string GetProcessor()
        {
            string processor = "";
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor"))
            {
                foreach (var obj in searcher.Get())
                {
                    processor = $"{obj["Name"]} - {obj["MaxClockSpeed"]} MHz";
                }
            }
            return processor;
        }

        private string GetArchitecture()
        {
            string architecture = "";
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
            {
                foreach (var obj in searcher.Get())
                {
                    architecture = obj["OSArchitecture"].ToString();
                }
            }
            return architecture;
        }
        private string RecommendOS(string architecture, double ram)
        {
            // Lista de sistemas operativos (convertida desde el JSON que proporcionaste)
            var osList = new List<(string Edition, string Windows, string Arch, string Version, double MinRam)>
    {
        ("WX-Lite", "Windows 11 24H2 Pro", "x64", "Op 11-v4.2", 4.0),
        ("WX-Lite", "Windows 11 24H2 Home", "x64", "Op 11-v4", 4.0),
        ("WX-Lite", "Windows 10 22H2 Pro", "x64", "Op 10", 4.0),
        ("TomexOS", "Windows 10 22H2 Pro", "x64", "v2", 4.0),
        ("WinterOS", "Windows 11 23H2 Pro", "x64", "Rev13", 4.0),
        ("WinterOS", "Windows 10 Pro 22H2", "x64", "Rev13", 4.0),
        ("WinterOS", "Windows 10 Pro 22H2", "x32", "Rev13", 4.0),
        ("WinterOS", "Windows 10 LTSC2021", "x64", "Rev13", 4.0),
        ("WinterOS", "Windows 10 LTSC2021", "x32", "Rev13", 4.0),
        ("WinterOS", "Windows 10 LTSC2019", "x64", "Rev13", 4.0),
        ("WinterOS", "Windows 10 LTSC2019", "x32", "Rev13", 4.0),
        ("MiniOS 10", "Windows 10 LTSB 1607", "x64", "v2024.09", 4.0),
        ("ShowOS Pro", "Windows 11 Pro 24H2", "x64", "V1.0", 4.0),
        ("WinterOS", "Windows 10 Pro 22H2", "x64", "Rev11", 4.0),
        ("WinterOS", "Windows 10 Pro 22H2", "x32", "Rev11", 4.0),
        ("WinterOS", "Windows 10 LTSC2021", "x64", "Rev11", 4.0),
        ("WinterOS", "Windows 10 LTSC2021", "x32", "Rev11", 4.0),
        ("WinterOS", "Windows 10 LTSC2019", "x64", "Rev11", 4.0),
        ("WinterOS", "Windows 10 LTSC2019", "x32", "Rev11", 4.0),
        ("WinterOS", "Windows 11 23H2 Pro", "x64", "Rev11", 4.0),
        ("MiniOS 11", "Windows 11 Pro 24H2", "x64", "v2024.06", 4.0),
        ("MiniOS 11", "Windows 11 LTSC 24H2", "x64", "v2024.06", 4.0),
        ("MiniOS 10", "Windows 10 Pro 22H2", "x64", "v2024.05", 4.0),
        ("MiniOS 10", "Windows 10 LTSC 21H2", "x64", "v2024.01", 4.0),
        ("MiniOS 10", "Windows 10 LTSC 1809", "x64", "v2024.01", 4.0),
        ("MiniOS 10", "Windows 10 LTSB 1607", "x64", "v2024.01", 4.0)
    };

            // Filtrar por arquitectura y RAM
            architecture = architecture.ToLower(); // Para manejar minúsculas y mayúsculas
            bool is64Bit = architecture.Contains("64");

            // Filtrar los sistemas operativos que cumplen con la arquitectura y los requisitos de RAM
            var filteredList = osList.Where(os => os.Arch.ToLower() == (is64Bit ? "x64" : "x32") && os.MinRam <= ram).ToList();

            // Si no hay sistemas operativos disponibles, retornar mensaje
            if (filteredList.Count == 0)
            {
                return "No se encuentra una recomendación adecuada para tu sistema.";
            }

            // Seleccionar un sistema operativo aleatorio de la lista filtrada
            var randomOS = filteredList[new Random().Next(filteredList.Count)];

            // Devolver el nombre del sistema operativo recomendado
            return $"{randomOS.Edition} ({randomOS.Windows}) {randomOS.Arch} - Versión: {randomOS.Version}";
        }

    }
}
