using QuizApp_WPF.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuizApp_WPF
{
    public class QuizModel
    {
        public int Id { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        public string Title { get; set; } = "";
    }
}
