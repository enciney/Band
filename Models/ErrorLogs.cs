using System;
using System.ComponentModel.DataAnnotations;

namespace EternalBAND.Models
{
    public class ErrorLogs
    {
        public int Id { get; set; }
        [Display(Name = "Hata Alınan Yer")] public string PageOrMethod { get; set; }
        [Display(Name = "Mesaj")] public string Message { get; set; }
        [Display(Name = "Uzun Mesaj")] public string LongMessage { get; set; }
        [Display(Name = "Tarih")] public DateTime Date { get; set; }
    }
}