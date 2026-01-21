

namespace eCommerce.Core.DTO
{
 public record RegisterRequest
 (string?Email,
     String?Password,
     String? PersonName,
     GenderOptions Gender);
}
