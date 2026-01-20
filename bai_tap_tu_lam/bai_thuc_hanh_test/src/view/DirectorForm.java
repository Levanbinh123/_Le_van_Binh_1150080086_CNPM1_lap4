
package view;
import bai_thuc_hanh_test.entity.Organization;
import javax.swing.JFrame;
public class DirectorForm extends JFrame {
    public DirectorForm(Organization org) {
        setTitle("Director - " + org.getOrgName());
        setSize(300, 200);
        setVisible(true);
    }
}