/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package view;

import database_cn.OrganizationDAO;
import bai_thuc_hanh_test.entity.Organization;
import javax.swing.*;
import java.time.LocalDateTime;
import validate_.OrganizationValidator;

public class OrganizationForm extends JFrame {
    JTextField txtName = new JTextField();
    JTextField txtAddress = new JTextField();
    JTextField txtPhone = new JTextField();
    JTextField txtEmail = new JTextField();
    JButton btnSave = new JButton("Save");
    JButton btnBack = new JButton("Back");
    JButton btnDirector = new JButton("Director");
    OrganizationDAO dao = new OrganizationDAO();
    Organization savedOrg;

    public OrganizationForm() {
        setTitle("Organization Management");
        setSize(400, 300);
        setLayout(null);

        btnDirector.setEnabled(false);

        // layout
        add(new JLabel("Organization Name *")).setBounds(20, 20, 150, 25);
        txtName.setBounds(180, 20, 180, 25); add(txtName);

        add(new JLabel("Address")).setBounds(20, 60, 150, 25);
        txtAddress.setBounds(180, 60, 180, 25); add(txtAddress);

        add(new JLabel("Phone")).setBounds(20, 100, 150, 25);
        txtPhone.setBounds(180, 100, 180, 25); add(txtPhone);

        add(new JLabel("Email")).setBounds(20, 140, 150, 25);
        txtEmail.setBounds(180, 140, 180, 25); add(txtEmail);

        btnSave.setBounds(40, 190, 80, 30);
        btnDirector.setBounds(150, 190, 90, 30);
        btnBack.setBounds(270, 190, 80, 30);

        add(btnSave); add(btnDirector); add(btnBack);

        // events
        btnSave.addActionListener(e -> save());
        btnBack.addActionListener(e -> dispose());
        btnDirector.addActionListener(e -> openDirector());

        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setVisible(true);
    }

    void save() {
        try {
            Organization org = new Organization();
            org.setOrgName(txtName.getText());
            org.setAddress(txtAddress.getText());
            org.setPhone(txtPhone.getText());
            org.setEmail(txtEmail.getText());
            org.setCreatedDate(LocalDateTime.now());

            String error = OrganizationValidator.validate(org);
            if (error != null) {
                JOptionPane.showMessageDialog(this, error);
                return;
            }

            if (dao.existsByName(org.getOrgName())) {
                JOptionPane.showMessageDialog(this, "Organization Name already exists");
                return;
            }

            int id = dao.save(org);
            org.setOrgId(id);
            savedOrg = org;

            JOptionPane.showMessageDialog(this, "Save successfully");
            btnDirector.setEnabled(true);

        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, ex.getMessage());
        }
    }
void openDirector() {
        new DirectorForm(savedOrg);
    }
}
