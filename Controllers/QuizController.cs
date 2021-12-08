using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameBaseSite.Models;
using System.Diagnostics;
using GameBaseSite.Models.Quiz;

namespace GameBaseSite.Controllers
{
    public class QuizController : Controller
    {
        private LibraryContext Context { get; set; }

        public QuizController(LibraryContext ctx)
        {
            Context = ctx;
        }


        [HttpGet]
       public IActionResult QuizIndex()
        {
            ViewBag.powerScore = 0;
            ViewBag.casualScore = 0;
            ViewBag.oldschoolScore = 0;
            ViewBag.brainyScore = 0;
            ViewBag.questionId = 1;

            Question q = QuestionDB.GetQuestion(ViewBag.questionId);
            ViewBag.QuestionText = q.QText;
            ViewBag.AnswerPText = q.AnsPower;
            ViewBag.AnswerCText = q.AnsCasual;
            ViewBag.AnswerOText = q.AnsOld;
            ViewBag.AnswerBText = q.AnsBrainy;

            return View();
        }

        [HttpPost]
        public IActionResult QuizIndex(QuizState inModel, GameModel game)
        {
            ViewBag.powerScore = inModel.powerScore;
            ViewBag.casualScore = inModel.casualScore;
            ViewBag.oldschoolScore = inModel.oldschoolScore;
            ViewBag.brainyScore = inModel.brainyScore;
            ViewBag.questionId = inModel.questionId + 1;

            if (inModel.Answer == "A") { ViewBag.powerScore++; }
            if (inModel.Answer == "B") { ViewBag.casualScore++; }
            if (inModel.Answer == "C") { ViewBag.oldschoolScore++; }
            if (inModel.Answer == "D") { ViewBag.brainyScore++; }

            Question q = QuestionDB.GetQuestion(ViewBag.questionId);
            ViewBag.QuestionText = q.QText;
            ViewBag.AnswerPText = q.AnsPower;
            ViewBag.AnswerCText = q.AnsCasual;
            ViewBag.AnswerOText = q.AnsOld;
            ViewBag.AnswerBText = q.AnsBrainy;

            ModelState.Clear();

            if(ViewBag.questionId > 10)
            {
                

                var typeTemp = inModel.getType();
                ViewBag.Type = typeTemp;
                ViewBag.games = Context.Games.Where(g => g.Type.Contains(typeTemp)).ToList();

                return View("GamerType");
            }

            return View();
        }


      
    }
}
