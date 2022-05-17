using System;
using System.Text;
using Nautilus;
namespace TestIOSCSharpApp2
{
    public class Parser
    {
        public Parser()
        {
        }

        public string ParseTrackstring(string Trackstring)
        {
            try
            {
                DriverLicense parseResult = DriverLicense.ParseText(Trackstring);
                string deviceid = DriverLicense.ComputerId;
                if (parseResult != null)
                {
                    StringBuilder parseResultString = new StringBuilder("");
                    parseResultString.Append($"Device ID:{deviceid}\n\n");
                    parseResultString.Append($"License number:{parseResult.LicenseNumber}\n");
                    parseResultString.Append($"Firstname:{parseResult.FirstName}\n");
                    parseResultString.Append($"Lastname:{parseResult.LastName}\nBirthdate:{parseResult.Birthdate}");
                    return parseResultString.ToString();
                }
                else
                {
                    return "Parseresult is null";
                }
            }
            catch(Exception ex)
            {
                return $"PARSER ERROR:{ex}";
            }
        }
    }
}
