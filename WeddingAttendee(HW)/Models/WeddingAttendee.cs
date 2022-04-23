using System;
using System.ComponentModel.DataAnnotations;

namespace introDotNetCore.Models
{
    public class WeddingAttendee
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez")]
        [MinLength(2,ErrorMessage ="En az iki karakter girilmelidir.")]
        [Display(Name ="Kayıt Olacak Kişinin Adı-Soyadı")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="E-Posta boş geçilemez")]
        [EmailAddress(ErrorMessage ="E-Posta tipi yanlış")]
        [Display(Name = "Kayıt Olacak Kişinin E-Posta Adresi")]
        public string Email { get; set; }

        [Display(Name = "Düğüne katılacaksanız kaç kişi katılacaksınız?")]
        public int HowManyPeople { get; set; }

        [Required(ErrorMessage = "Gelip gelmeyeceğiniz alanı boş bırakmayınız.")]
        [Display(Name = "Düğüne katılacak mısınız?")]
        public bool isComeWedding { get; set; }
    }
}
