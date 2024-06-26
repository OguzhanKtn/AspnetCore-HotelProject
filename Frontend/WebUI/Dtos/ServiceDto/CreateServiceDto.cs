using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.ServiceDto
{
    public record CreateServiceDto
    (
        [Required(ErrorMessage = "Hizmet ikon linki giriniz.")]
        string ServiceIcon,

        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100,ErrorMessage ="Hizmet başlığı en fazla 100 karakter olabilir.")]
         string Title,

        string Description
    );
}
