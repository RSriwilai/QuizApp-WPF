using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using QuizApp_WPF.Views;

namespace QuizApp_WPF.DataModels;   

public class Quiz
{
    private int _id = 0;
    public int Id => _id;
    private IEnumerable<Question> _questions;
    private string _title = string.Empty;
    public IEnumerable<Question> Questions => _questions;
    public string Title => _title;

    public Quiz()
    {
        _questions = new List<Question>();
    }

    public Quiz (int Id, List<Question> questions, string title)
    {
        _id = Id;
        _questions = questions;
        _title = title;
    }

    public Question? GetRandomQuestion(string? category)
    {
        var random = new Random();
        var notAskedQuestions = _questions.ToList()
            .FindAll(q => !q.IsAsked && q.Category.ToString() == category || category == "All" && !q.IsAsked);

        if (notAskedQuestions.Count == 0) 
            return null;

        var result = notAskedQuestions[random.Next(notAskedQuestions.Count)];
        return result;
    }
}