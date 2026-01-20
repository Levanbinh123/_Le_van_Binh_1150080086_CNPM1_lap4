
package database_cn;
import bai_thuc_hanh_test.entity.Organization;
import java.sql.*;

public class OrganizationDAO {

    public boolean existsByName(String name) throws Exception {
        String sql = "SELECT 1 FROM ORGANIZATION WHERE LOWER(OrgName)=LOWER(?)";
        try (Connection con = DBConnection.getConnection();
             PreparedStatement ps = con.prepareStatement(sql)) {
            ps.setString(1, name);
            return ps.executeQuery().next();
        }
    }

    public int save(Organization org) throws Exception {
        String sql = """
            INSERT INTO ORGANIZATION
            (OrgName, Address, Phone, Email, CreatedDate)
            VALUES (?, ?, ?, ?, ?)
        """;
        try (Connection con = DBConnection.getConnection();
             PreparedStatement ps = con.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS)) {

            ps.setString(1, org.getOrgName());
            ps.setString(2, org.getAddress());
            ps.setString(3, org.getPhone());
            ps.setString(4, org.getEmail());
            ps.setTimestamp(5, Timestamp.valueOf(org.getCreatedDate()));

            ps.executeUpdate();
            ResultSet rs = ps.getGeneratedKeys();
            return rs.next() ? rs.getInt(1) : 0;
        }
    }
}