﻿namespace OnlineSinavPortali.ViewModels
{
    public class StudentAnswersModel
    {
        public int? QuestionID { get; set; }
        public int? ExamID { get; set; }
        public string? TeacherID { get; set; }

        public string? ExamType { get; set; }
        public string? QuestionText { get; set; }

        public string? QuestionAnswersText { get; set; }
        public string? optionAText { get; set; }
        public string? optionBText { get; set; }
        public string? optionCText { get; set; }
        public string? optionDText { get; set; }
        public int? StudentAnswerID { get; set; }
        public string? StudentID { get; set; }
     
        public string? AnswerText { get; set; }
    }
}
