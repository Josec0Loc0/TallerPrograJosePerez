using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPrograJosePerez.Models
{
    internal class About
    {
        public string Title { get; set; } = "Yo mismo";
        public string Version { get; set; } = "1.0";
        public string Name { get; set; } = "José Perez";
        public string Description { get; set; } = "Soy estudiante apasionado por la tecnología y el coco.";
        public string Icon { get; set; } = "icon_memeabout.jpg"; // Asegúrate de tener este ícono en tus recursos
    }
}
