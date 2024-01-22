﻿using Infrastructure.Library.BaseModels;

namespace Infrastructure.Library.Models.DTOs.WEB
{
    public class WebServiceDTO : BaseDTO
    {
        public string Value { get; set; }
        public string Change { get; set; }
        public string TimeStamp { get; set; }
        public string Date { get; set; }
    }
}