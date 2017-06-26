using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AppGradeAcademica.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string Curso { get; set; }
        public string Turma { get; set; }
        [DisplayName("Horário de Aula")]
        public string Horario_de_aula { get; set; }
        [DisplayName("Horário de Atendimento")]
        public string Horario_de_atendimento { get; set; }
    }
}