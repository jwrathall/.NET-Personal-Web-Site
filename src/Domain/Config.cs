using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Domain
{
    public class Config
    {
        public static string SmtpHost { get { return _getSettingString("SmtpHost"); } }
        public static string DefaultFromName { get { return _getSettingString("DefaultFromName"); } }
        public static string DefaultFromEmail { get { return _getSettingString("DefaultFromEmail"); } }
        public static string DefaultToEmail { get { return _getSettingString("DefaultToEmail"); } }


        private static object _getSetting(string setting)
        {
            return ConfigurationManager.AppSettings[setting];
        }
        private static string _getSettingString(string setting)
        {
            return (string) _getSetting(setting);
        }
        private static decimal _getSettingDecimal(string setting)
        {
            return
                Convert.ToDecimal(_getSetting(setting));
        }

        private static int _getSettingInt(string setting)
        {
            return
                Convert.ToInt32(_getSetting(setting));
        }

    }
}
