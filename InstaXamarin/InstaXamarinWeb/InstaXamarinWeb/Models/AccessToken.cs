﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InstaXamarinWeb.Models
{
    public class AccessToken
    {
        [Key]
        public String Token { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario UsuarioDados { get; set; }

        public DateTime Data { get; set; }
    }
}