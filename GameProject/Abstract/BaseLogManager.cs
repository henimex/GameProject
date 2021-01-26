using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    class BaseLogManager : ILogService
    {
        public void LogAttempt(Gamer gamer)
        {
            var now = DateTime.Now;
            Console.WriteLine("-----------------------------------\n" +
                "Register Log System Entry: \nRegister Denied Not Valid Person :: \nGamer NID \t: {0} \nGamer Name \t: {1} \nGamer Surname \t: {2} \nBirth Year \t: {3} \nAttempt Date \t: {4}" +
                "\n-----------------------------------",
                gamer.NationalID,
                gamer.Name,
                gamer.Surname,
                gamer.BirthDate.Year,
                now);
        }

        public void LogSuccess(Gamer gamer)
        {
            var now = DateTime.Now;
            Console.WriteLine("++++++++++++++++++++++++++++++\n" +
                "Register Log System Entry: \nRegister Successful :: \nGamer Name \t: {0} \nGamer Surname \t: {1} \nProfessionality : {2} \nDate \t\t: {3} " +
                "\n++++++++++++++++++++++++++++++",
                gamer.Name,
                gamer.Surname,
                gamer.Professionality,
                now);
        }
    }
}
