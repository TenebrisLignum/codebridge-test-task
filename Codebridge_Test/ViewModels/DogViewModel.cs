using Codebridge_Test.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codebridge_Test.ViewModels
{
    public class DogViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = Consts.RequiredFiedError)]
        public string Name { get; set; }

        [Display(Name = "Color")]
        [Required(ErrorMessage = Consts.RequiredFiedError)]
        public string Color { get; set; }

        [Display(Name = "Tail Length")]
        [Required(ErrorMessage = Consts.RequiredFiedError)]
        [Range(0, 250, ErrorMessage = Consts.LengthError)]
        public int TailLength { get; set; }

        [Display(Name = "Weight")]
        [Required(ErrorMessage = Consts.RequiredFiedError)]
        [Range(0, 250, ErrorMessage = Consts.LengthError)]
        public int Weight { get; set; }
    }
}
