
package validate_;
import bai_thuc_hanh_test.entity.Organization;
import java.util.regex.Pattern;

public class OrganizationValidator {

    public static String validate(Organization org) {
        if (org.getOrgName() == null || org.getOrgName().trim().isEmpty())
            return "Organization Name is required";

        if (org.getOrgName().length() < 3 || org.getOrgName().length() > 255)
            return "Organization Name must be 3–255 characters";

        if (org.getEmail() != null && !org.getEmail().isBlank()) {
            if (!Pattern.matches("^[\\w.-]+@[\\w.-]+\\.[a-zA-Z]{2,}$", org.getEmail()))
                return "Invalid email format";
        }

        if (org.getPhone() != null && !org.getPhone().isBlank()) {
            if (!org.getPhone().matches("\\d{9,12}"))
                return "Phone must be 9–12 digits";
        }

        return null; // hợp lệ
    }
}