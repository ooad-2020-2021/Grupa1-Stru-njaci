﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace SpaceCat
{
    public class Putovanje
    {
        #region Properties
        [Key]
        [Required]
        public int ID { get; set; }
        [NotMapped]

        [Range(0, 10, ErrorMessage = "Broj macaka odabranih za putovanje ne smije biti veci od 10")]
        public List<Macka> SpisakMacaka { get; set; }
        [DataType(DataType.Date)]
        public DateTime? VrijemePolaska { get; set; }
        public Destinacija Destinacija { get; set; }
        [DataType(DataType.Date)]
        public DateTime? KrajPutovanja { get; set; }
        public string mackeZaPutovanje { get; set; }
        #endregion
        #region Konstruktori
        public Putovanje() { }
        public Putovanje(DateTime vrijemePolaska, Destinacija destinacija, DateTime krajPutovanja)
        {
            VrijemePolaska = vrijemePolaska;
            Destinacija = destinacija;
            KrajPutovanja = krajPutovanja;
        }
        #endregion
        #region Metode
        public void DodajMacku(Macka macka)
        {
            SpisakMacaka.Add(macka);
        }
        #endregion
    }
}
