using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Management;

namespace DadosMaquina
{
    class Dados
    {
        public static String getMacAddress()
        {
            return (from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()).FirstOrDefault();
        }

        public static String getComputerName()
        {
            return Environment.MachineName;
        }

        public static String getTypeOfSystem()
        {
            String tipoSistema;
            if (Environment.Is64BitOperatingSystem){
                tipoSistema = "Sistema 64 bits";
            }else{
                tipoSistema = "Sistema 32 bits";
            }
            return tipoSistema;
        }

        public static String getProcessador()
        {
            String proc = "";
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject managementObject in managementObjectSearcher.Get())
            {
                proc = managementObject.GetPropertyValue("Name").ToString();
            }

            return proc;
        }

        public static String getMotherBoard()
        {
            String proc = "";
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_BaseBoard");

            foreach (ManagementObject managementObject in managementObjectSearcher.Get())
            {
                proc = managementObject.GetPropertyValue("Product").ToString() + Convert.ToString(managementObject.GetPropertyValue("SerialNumber"));
            }

            return proc;
        }
    }
}
