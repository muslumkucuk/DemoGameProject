﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGameProject
{
    public class GamerManager : IGamerService
    {
        private IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, Kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer + " Kaydı silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer + " Kayıt güncellendi.");
        }
    }
}
