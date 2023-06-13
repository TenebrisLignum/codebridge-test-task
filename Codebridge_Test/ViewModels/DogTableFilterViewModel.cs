using Codebridge_Test.Domain.Enums;
using Codebridge_Test.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Codebridge_Test.ViewModels
{
    public class DogTableFilterViewModel
    {
        [Display(Name = "Field Name")]
        public DogFieldsName FieldName { get; set; }

        [Display(Name = "Sort Order")]
        public SortOrder SortOrder { get; set; }

        [Display(Name = "Page Size")]
        [Range(1, int.MaxValue, ErrorMessage = Consts.InvalidInteger)]
        public int PageSize { get; set; }

        [Display(Name = "Page Number")]
        [Range(1, int.MaxValue, ErrorMessage = Consts.InvalidInteger)]
        public int PageNumber { get; set; }

        // Default values
        public DogTableFilterViewModel()
        {
            FieldName = DogFieldsName.Name;
            SortOrder = SortOrder.Ascending;
            PageSize = 10;
            PageNumber = 1;
        }
    }
}
