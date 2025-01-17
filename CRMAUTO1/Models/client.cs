﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRMAUTO.Models
{
    public class client
    {
        [Required] [Key] 
        public string ClientID { get; set; }
        [Required]
        [Display(Name="CIN")]
        public string cin { get; set; }
        [Required][Display(Name = "Name :")]
        public string Name  { get; set; }
        [Required] [Display(Name = "Prenom :")]
        public string UserName { get; set; }
        [Required] [Display(Name = "Date de naissance :")]
        [DataType(DataType.Date)]
        public DateTime Datadenaissance { get; set; }
        [Required]
        [Display(Name = "Numéro de téléphone :")]
        [DataType(DataType.PhoneNumber)]
        public int numtele { get; set; }
        [Required] [Display(Name = "Ville Client :")]

     
        public string adresse { get; set; }
        [Required]  [Display(Name = "Numero de pérmis :")]
        public string Numpermis { get; set; }
        public virtual ICollection<contrat> Contrats { get; set; }
    }
}