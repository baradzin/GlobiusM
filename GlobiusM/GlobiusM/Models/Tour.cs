using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobiusM.Models
{
    public class Tour
    {
        // ID тура
        public int Id { get; set; }
        // название тура
        public string Name { get; set; }
        // описание тура
        public string Description { get; set; }
        // цена
        public int Price { get; set; }
        // Доступные даты
        public List<TourPeriod> TourPeriodList { get; set; }
    }
}