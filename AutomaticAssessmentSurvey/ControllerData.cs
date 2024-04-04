using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AutomaticAssessmentSurvey
{
    class ControllerData
    {
        string filePath;
        Account account;
        
        public ControllerData() { }
        public ControllerData(string filePath)
        {
            this.filePath = filePath;
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] element = line.Split(';');
                        if (element.Length == 3)
                        {
                            string user = element[0];
                            string password = element[1];
                            string gioiTinh = element[2];
                            account = new Account(user,password,gioiTinh);
                        }
                    }
                }
            }
        }

        private void SaveDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(account.Info());
            }
        }

        public void EditData(Account content)
        {
            account = content;
            SaveDataToFile();
        }

        public void DeleteData()
        {
            account.User = null;
            account.Password = null;
            account.GioiTinh = null;
            SaveDataToFile();
        }

        public Account GetDataAccount()
        {
            return account;
        }
    }
}
