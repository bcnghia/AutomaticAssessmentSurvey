using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutomaticAssessmentSurvey
{
    class ControllerDataComment
    {
        Random random = new Random();
        string filePath;
        string commentString;
        List<string> commentsList = new List<string>();

        public ControllerDataComment() { }
        public ControllerDataComment(string filePath)
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
                        //if (line != null) commentString += line;
                        if (!string.IsNullOrEmpty(line.Trim())) // phân biệt đoạn nào trống để bỏ qua
                        {
                            commentString += line + "\n";
                            commentsList.Add(line);
                        }
                        else continue;
                    }
                }
            }
        }

        private void SaveDataToFile() 
        // lệnh này sẽ ghi đè vào nội dung có sẵn nên sẽ không lo bị lặp dữ liệu
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(commentString);
            }
        }

        public void EditData(string newComment)
        {
            commentString += newComment;
            commentsList.Add(newComment); // đoạn này có thể text sẽ lưu vào nhưng không xuống dòng
            SaveDataToFile();
        }

        public void DeleteData()
        {
            commentString = null;
            commentsList.Clear();
            SaveDataToFile();
        }

        public string GetDataDisplay()
        {
            string cmt = "";
            foreach (string comment in commentsList)
            {
                cmt += "• " + comment + "\n";
            }
            return cmt;
        }

        public List<string> GetDataCommentList()
        {
            return commentsList;
        }

        public string GetComment()
        {
            if (commentsList.Count != 0)
            {
                int randomIndex = random.Next(0, commentsList.Count);
                string randomItem = commentsList[randomIndex];
                return randomItem;
            }
            else return "Không";
        }
    }
}
