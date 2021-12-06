using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameBaseSite.Models.Quiz
{
    public static class QuestionDB
    {
        public static Question GetQuestion(int questionId)
        {
            Question ansValue = new Question();

            if(questionId == 1)
            {
                ansValue.QText = "What is your favorite genre of movie?";
                ansValue.AnsPower = "Action";
                ansValue.AnsCasual = "Comedy";
                ansValue.AnsOld = "Vaudeville";
                ansValue.AnsBrainy = "Documentary";
            }

            if (questionId == 2)
            {
                ansValue.QText = "Are you a night-owl, or an early bird?";
                ansValue.AnsPower = "night-owl";
                ansValue.AnsCasual = "early-bird";
                ansValue.AnsOld = "early-bird";
                ansValue.AnsBrainy = "night-owl";
            }

            if (questionId == 3)
            {
                ansValue.QText = "Do you prefer to play alone or with friends?";
                ansValue.AnsPower = "With friends";
                ansValue.AnsCasual = "Alone";
                ansValue.AnsOld = "Alone";
                ansValue.AnsBrainy = "With friends";
            }

            if (questionId == 4)
            {
                ansValue.QText = "Whats your ideal game length?";
                ansValue.AnsPower = "8 or more hours";
                ansValue.AnsCasual = "4 hours or less";
                ansValue.AnsOld = "2 hours or less";
                ansValue.AnsBrainy = "I'll play for as long as I'm interested";
            }

            if (questionId == 5)
            {
                ansValue.QText = "Your friend shows you their new game. They hint that you should play it too. It looks fun but its $70. Do you buy it?";
                ansValue.AnsPower = "Yes, thats nothing for a good time";
                ansValue.AnsCasual = "No, I don't play enough to justify the expense";
                ansValue.AnsOld = "No, I have much better things to spend my money on";
                ansValue.AnsBrainy = "Maybe, does my friend think it was worth the price?";
            }

            if (questionId == 6)
            {
                ansValue.QText = "You are stuck on a very dificult boss. Just when you finally think you are going to win, the game freezes and the boss kills you. How do you react?";
                ansValue.AnsPower = "Wow! Did the devs not do any QA? This is a load of horse-hockey!";
                ansValue.AnsCasual = "I'm going to go do something else, I don't want to waste more time on this.";
                ansValue.AnsOld = "I didn't realize that Pong had bosses...";
                ansValue.AnsBrainy = "That freeze could be a hardware issue, let me check my hardware monitor. Now, where did I put that strategy guide...";
            }

            if (questionId == 7)
            {
                ansValue.QText = "Which of these types of games sounds the most appealing?";
                ansValue.AnsPower = "Competitive Arena shooter";
                ansValue.AnsCasual = "Casino and Card collection";
                ansValue.AnsOld = "Side-scrolling 2d platformer";
                ansValue.AnsBrainy = "Esoteric Puzzle strategy";
            }

            if (questionId == 8)
            {
                ansValue.QText = "What is your go-to snack while you play?";
                ansValue.AnsPower = "G-Fuel and Beef Jerkey";
                ansValue.AnsCasual = "Soda and Pizza";
                ansValue.AnsOld = "Prune Juice and Tapioca Pudding";
                ansValue.AnsBrainy = "Water and Assorted Vegetables";
            }

            if (questionId == 9)
            {
                ansValue.QText = "Do you keep up to date with the newest game and hardware releases?";
                ansValue.AnsPower = "Yes! If its new I HAVE to buy it!";
                ansValue.AnsCasual = "Not really, but I pick up a game or system from time to time";
                ansValue.AnsOld = "I prefer to see whats new at a thrift store or trade-in shop";
                ansValue.AnsBrainy = "Newer isn't always better. I prefer to wait and see what the reviews say";
            }

            if (questionId == 10)
            {
                ansValue.QText = "What do you prefer to sit on when gaming?";
                ansValue.AnsPower = "I've got a racing-style gaming chair";
                ansValue.AnsCasual = "My couch works just fine";
                ansValue.AnsOld = "I've recline back with my feet up in my La-Z-Boy";
                ansValue.AnsBrainy = "My spine and lumbar will be thanking me in 20 years, I use an ergonomic desk chair";
            }

            return ansValue;
        }
    }
}
