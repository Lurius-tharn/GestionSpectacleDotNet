namespace GestionSpectacle.Vue.utils;

public static class FormUtilities
{
    public static void ShowFormInPanel(Panel panelContainer, Form formToShow)
    {
        panelContainer.Controls.Clear();

        formToShow.TopLevel = false;
        formToShow.FormBorderStyle = FormBorderStyle.None;
        formToShow.Dock = DockStyle.Fill;
        panelContainer.Controls.Add(formToShow);
        formToShow.Show();
    }
}