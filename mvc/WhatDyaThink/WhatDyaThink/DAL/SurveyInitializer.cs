using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhatDyaThink.Models;

namespace WhatDyaThink.DAL
{
    public class SurveyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SurveyContext>
    {
        protected override void Seed(SurveyContext sc)
        {
            var testSurveys = new List<Survey> 
            {
                new Survey{ surveyID= 1, surveyName="Test Survey 1"},
                new Survey{ surveyID = 2, surveyName="Test Survey 2"}
            };
            testSurveys.ForEach(s => sc.Survey.Add(s));
            sc.SaveChanges();

            var testQuestions = new List<Question> 
            {
                new Question{ surveyID = 1, questionID = 1, questionType=QuestionType.CheckBox,questionText = "How Old Are You ?" },
                new Question{surveyID = 1, questionID = 2, questionType=QuestionType.CheckBox,questionText = "What Is your favourite color ?"},
                new Question{surveyID = 1, questionID = 3, questionType=QuestionType.CheckBox,questionText = "What do you do for a living ?"},
                
                new Question{ surveyID = 2, questionID = 4, questionType=QuestionType.CheckBox,questionText = "Do you speak another lanuage?" },
                new Question{surveyID = 2, questionID = 5, questionType=QuestionType.CheckBox,questionText = "Do you drive ?"},
                new Question{surveyID = 2, questionID = 6, questionType=QuestionType.CheckBox,questionText = "Do you count sheep ?"}                
            };
            testQuestions.ForEach(q => sc.Question.Add(q));
            sc.SaveChanges();
            /// below dosn't seed data ??? has to be done through context
            //var testAnswers = new List<Responces> 
            //{
            //    new Responces{ questionID = 1, responceID = 1, responceCSS ="", responceType=ResponceType.CheckBox, responceValue= false, responceText="0 - 10"},
            //    new Responces{ questionID = 1, responceID = 2, responceCSS ="", responceType=ResponceType.CheckBox, responceValue= false, responceText="11 +"},
                
            //    new Responces{ questionID = 2, responceID = 3, responceCSS ="", responceType=ResponceType.CheckBox, responceValue= false, responceText="red"},
            //    new Responces{ questionID = 2, responceID = 4, responceCSS ="", responceType=ResponceType.CheckBox, responceValue= false, responceText="blue"},
                
            //    new Responces{ questionID = 3, responceID = 5, responceCSS ="", responceType=ResponceType.CheckBox, responceValue= false, responceText="carpenter"},
            //    new Responces{ questionID = 3, responceID = 6, responceCSS ="", responceType=ResponceType.CheckBox, responceValue= false, responceText="bomber"},
                
            //    new Responces{ questionID = 4, responceID = 7, responceCSS ="", responceType=ResponceType.CheckBox, responceValue= false, responceText="swedish"},
            //    new Responces{ questionID = 4, responceID = 8, responceCSS ="", responceType=ResponceType.CheckBox, responceValue= false, responceText="north korean"},
                
            //    new Responces{ questionID = 5, responceID = 9, responceCSS ="", responceType=ResponceType.RadioButton, responceValue= false, responceText="yes"},
            //    new Responces{ questionID = 5, responceID = 10, responceCSS ="", responceType=ResponceType.RadioButton, responceValue= false, responceText="no"},
                
            //    new Responces{ questionID = 6, responceID = 11, responceCSS ="", responceType=ResponceType.RadioButton, responceValue= false, responceText="yes"},
            //    new Responces{ questionID = 6, responceID = 12, responceCSS ="", responceType=ResponceType.RadioButton, responceValue= false, responceText="no"}
            //};
            //testAnswers.ForEach(a=> sc.Responces.Add(a));
            //sc.SaveChanges();
        }
    }
}