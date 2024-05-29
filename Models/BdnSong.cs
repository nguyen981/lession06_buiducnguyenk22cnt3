using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BdnLesson06.Models
{
    public class BdnSong
    {
        [Key] 
        public int Id { get; set; }
        [Required(ErrorMessage ="Bdn: Hay nhap tieu de")]
        [DisplayName("Tieu de")]
        public string BdnTitle { get; set; }
        [Required(ErrorMessage = "Bdn: Hay nhap tac gia")]
        [DisplayName("tac gia")]
        public string BdnAuthor { get; set; }
        [Required(ErrorMessage = "Bdn: Hay nhap nghe si")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Bdn: ten nghe si co toi theiu 2 ky tu, toi da 50 ki tu")]
        [DisplayName("nghe si")]
        public string BdnArtist { get; set; }

        [Required(ErrorMessage = "Bdn: Hay nhap nam xuat ban")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage =" Nhap xuat ban phai co 2 ky tu so")]
        [Range(1900,2024, ErrorMessage ="Bdn: nam xuat ban trong khoang 1900-2024")]
        [DisplayName("Nam xuat ban")]
        public int BdnYearRelease { get; set; }
    }
}