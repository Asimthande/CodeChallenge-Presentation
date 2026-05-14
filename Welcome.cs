using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic;

namespace Presentation
{
    public partial class Welcome : Form
    {
        private BusinessLogicLayer logic = new BusinessLogicLayer();

        private Color hintColor = Color.Gray;
        private Color normalColor = Color.Black;

        private string hintClientName = "e.g. John Smith";
        private string hintClientEmail = "e.g. john@email.com";
        private string hintWorkshopID = "e.g. W001";
        private string hintWorkshopTitle = "e.g. Excel Basics";
        private string hintSearchEmail = "e.g. john@email.com";
        private string hintRegistrationID = "e.g. R001";

        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            SetupHint(txtClientName, hintClientName);
            SetupHint(txtClientEmail, hintClientEmail);
            SetupHint(txtWorkshopID, hintWorkshopID);
            SetupHint(txtWorkshopTitle, hintWorkshopTitle);
            SetupHint(txtSearchEmail, hintSearchEmail);
            SetupHint(txtRegistrationID, hintRegistrationID);

            nudCapacity.Minimum = 1;
            nudCapacity.Maximum = 9999;
            nudCapacity.Value = 1;

            dvgWorkShops.DataSource = null;
            dgvRegistrations.DataSource = null;

            dvgWorkShops.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistrations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvgWorkShops.ReadOnly = true;
            dgvRegistrations.ReadOnly = true;
        }


        private void SetupHint(TextBox txt, string hint)
        {
            txt.Text = hint;
            txt.ForeColor = hintColor;

            txt.Enter += (s, ev) =>
            {
                if (txt.Text == hint)
                {
                    txt.Text = "";
                    txt.ForeColor = normalColor;
                }
                ResetHighlight(txt);
            };

            txt.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = hint;
                    txt.ForeColor = hintColor;
                }
            };
        }

        private string GetTextBoxValue(TextBox txt, string hint)
        {
            if (txt.Text == hint || txt.ForeColor == hintColor)
                return "";
            return txt.Text.Trim();
        }

        private void HighlightEmpty(TextBox txt, string hint)
        {
            if (string.IsNullOrWhiteSpace(GetTextBoxValue(txt, hint)))
                txt.BackColor = Color.LightPink;
        }

        private void ResetHighlight(TextBox txt)
        {
            txt.BackColor = Color.White;
        }

        private void ResetAllHighlights()
        {
            ResetHighlight(txtClientName);
            ResetHighlight(txtClientEmail);
            ResetHighlight(txtWorkshopID);
            ResetHighlight(txtWorkshopTitle);
            ResetHighlight(txtSearchEmail);
            ResetHighlight(txtRegistrationID);
            nudCapacity.BackColor = Color.White;
            cmbCategory.BackColor = Color.White;
        }

        private void btnViewWorkShop_Click(object sender, EventArgs e)
        {
            LoadWorkshopGrid();
            MessageBox.Show("Available workshops loaded successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadWorkshopGrid()
        {
            dvgWorkShops.DataSource = null;
            dvgWorkShops.DataSource = logic.GetAvailableWorkshops();

            if (dvgWorkShops.Columns.Count > 0)
            {
                if (dvgWorkShops.Columns.Contains("WorkshopID"))
                    dvgWorkShops.Columns["WorkshopID"].HeaderText = "Workshop ID";

                if (dvgWorkShops.Columns.Contains("Title"))
                    dvgWorkShops.Columns["Title"].HeaderText = "Title";

                if (dvgWorkShops.Columns.Contains("Category"))
                    dvgWorkShops.Columns["Category"].HeaderText = "Category";

                if (dvgWorkShops.Columns.Contains("Capacity"))
                    dvgWorkShops.Columns["Capacity"].HeaderText = "Capacity";

                if (dvgWorkShops.Columns.Contains("AvailableSpaces"))
                    dvgWorkShops.Columns["AvailableSpaces"].HeaderText = "Available Spaces";

                if (dvgWorkShops.Columns.Contains("Status"))
                    dvgWorkShops.Columns["Status"].Visible = false;

                if (dvgWorkShops.Columns.Contains("WorkshopTitle"))
                    dvgWorkShops.Columns["WorkshopTitle"].Visible = false;
            }

            dvgWorkShops.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgWorkShops.ReadOnly = true;
        }


        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            ResetAllHighlights();

            string clientName = GetTextBoxValue(txtClientName, hintClientName);
            string clientEmail = GetTextBoxValue(txtClientEmail, hintClientEmail);
            string workshopID = GetTextBoxValue(txtWorkshopID, hintWorkshopID);

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(clientName))
            {
                HighlightEmpty(txtClientName, hintClientName);
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(clientEmail))
            {
                HighlightEmpty(txtClientEmail, hintClientEmail);
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(workshopID))
            {
                HighlightEmpty(txtWorkshopID, hintWorkshopID);
                hasError = true;
            }

            if (hasError)
            {
                MessageBox.Show("Please fill in all highlighted fields.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = logic.RegisterClient(clientName, clientEmail, workshopID);

            if (result == "Registration successful.")
            {
                MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtClientName.Text = hintClientName;
                txtClientName.ForeColor = hintColor;
                txtClientEmail.Text = hintClientEmail;
                txtClientEmail.ForeColor = hintColor;
                txtWorkshopID.Text = hintWorkshopID;
                txtWorkshopID.ForeColor = hintColor;

                if (dvgWorkShops.Rows.Count > 0)
                    LoadWorkshopGrid();
            }
            else
            {
                MessageBox.Show(result, "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result.Contains("email"))
                    txtClientEmail.BackColor = Color.LightPink;
                else if (result.Contains("Workshop") || result.Contains("workshop"))
                    txtWorkshopID.BackColor = Color.LightPink;
                else if (result.Contains("name"))
                    txtClientName.BackColor = Color.LightPink;
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResetAllHighlights();

            string email = GetTextBoxValue(txtSearchEmail, hintSearchEmail);

            if (string.IsNullOrWhiteSpace(email))
            {
                txtSearchEmail.BackColor = Color.LightPink;
                MessageBox.Show("Please enter an email address to search.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<DataAcess.Registration> results = logic.SearchRegistrations(email);

            if (results.Count == 0)
            {
                MessageBox.Show("No registrations found for the given email.", "No Results",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvRegistrations.DataSource = null;
                return;
            }

            var display = results.Select(r => new
            {
                RegistrationID = r.RegistrationID,
                ClientName = r.ClientName,
                ClientEmail = r.ClientEmail,
                WorkshopID = r.WorkshopID,
                WorkshopTitle = r.WorkshopTitle,
                Status = r.Status
            }).ToList();

            dgvRegistrations.DataSource = null;
            dgvRegistrations.DataSource = display;

            if (dgvRegistrations.Columns.Count > 0)
            {
                dgvRegistrations.Columns["RegistrationID"].HeaderText = "Registration ID";
                dgvRegistrations.Columns["ClientName"].HeaderText = "Client Name";
                dgvRegistrations.Columns["ClientEmail"].HeaderText = "Client Email";
                dgvRegistrations.Columns["WorkshopID"].HeaderText = "Workshop ID";
                dgvRegistrations.Columns["WorkshopTitle"].HeaderText = "Workshop Title";
                dgvRegistrations.Columns["Status"].HeaderText = "Status";
            }

            dgvRegistrations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistrations.ReadOnly = true;

            MessageBox.Show($"{results.Count} registration(s) found.", "Search Results",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnCancelRegistrtion_Click(object sender, EventArgs e)
        {
            ResetAllHighlights();

            string registrationID = GetTextBoxValue(txtRegistrationID, hintRegistrationID);

            if (string.IsNullOrWhiteSpace(registrationID))
            {
                txtRegistrationID.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a Registration ID.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to cancel registration {registrationID}?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            string result = logic.CancelRegistration(registrationID);

            if (result == "Registration cancelled successfully.")
            {
                MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtRegistrationID.Text = hintRegistrationID;
                txtRegistrationID.ForeColor = hintColor;

                if (dvgWorkShops.Rows.Count > 0)
                    LoadWorkshopGrid();
            }
            else
            {
                txtRegistrationID.BackColor = Color.LightPink;
                MessageBox.Show(result, "Cancellation Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddWorkshop_Click(object sender, EventArgs e)
        {
            ResetAllHighlights();

            string title = GetTextBoxValue(txtWorkshopTitle, hintWorkshopTitle);
            string category = cmbCategory.SelectedItem != null ? cmbCategory.SelectedItem.ToString() : "";
            string capacityText = nudCapacity.Value.ToString();

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(title))
            {
                HighlightEmpty(txtWorkshopTitle, hintWorkshopTitle);
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                cmbCategory.BackColor = Color.LightPink;
                hasError = true;
            }

            if (nudCapacity.Value <= 0)
            {
                nudCapacity.BackColor = Color.LightPink;
                hasError = true;
            }

            if (hasError)
            {
                MessageBox.Show("Please fill in all highlighted fields.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = logic.AddWorkshop(title, category, capacityText);

            if (result == "Workshop added successfully.")
            {
                MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtWorkshopTitle.Text = hintWorkshopTitle;
                txtWorkshopTitle.ForeColor = hintColor;
                cmbCategory.SelectedIndex = -1;
                cmbCategory.BackColor = Color.White;
                nudCapacity.Value = 1;
                nudCapacity.BackColor = Color.White;

                if (dvgWorkShops.Rows.Count > 0)
                    LoadWorkshopGrid();
            }
            else
            {
                MessageBox.Show(result, "Add Workshop Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result.Contains("title"))
                    txtWorkshopTitle.BackColor = Color.LightPink;
                else if (result.Contains("category"))
                    cmbCategory.BackColor = Color.LightPink;
                else if (result.Contains("Capacity") || result.Contains("capacity"))
                    nudCapacity.BackColor = Color.LightPink;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
                Application.Exit();
        }


        private void txtClientEmail_TextChanged(object sender, EventArgs e) { }
        private void grpSearchRegistration_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dvgWorkShops_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblCategory_Click(object sender, EventArgs e) { }
        private void txtClientName_TextChanged(object sender, EventArgs e) { }
        private void txtClientEmail_TextChanged_1(object sender, EventArgs e) { }
        private void txtWorkshopTitle_TextChanged(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void txtRegistrationID_TextChanged(object sender, EventArgs e) { }
        private void txtSearchEmail_TextChanged(object sender, EventArgs e) { }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex >= 0)
                cmbCategory.BackColor = Color.White;
        }

        private void dgvRegistrations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}