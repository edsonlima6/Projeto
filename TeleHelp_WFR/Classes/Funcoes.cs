using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TeleHelp_WFR.Classes
{
    public class Funcoes
    {
        public static void LimpaCampos(Control.ControlCollection control)
        {
            foreach (var item in control)
            {
                if (item is RadPanel)
                {
                    foreach (var itemPanel in ((RadPanel)item).Controls)
                    {
                        if (itemPanel is RadGroupBox)
                        {
                            foreach (var itemgroup in ((RadGroupBox)itemPanel).Controls)
                            {
                                if (itemgroup is RadRadioButton)
                                {
                                    ((RadRadioButton)itemgroup).CheckState = CheckState.Unchecked;
                                }
                                if (itemgroup is RadTextBox)
                                {
                                    ((RadTextBox)itemgroup).Text = string.Empty;
                                }
                                if (itemgroup is RadDropDownList)
                                {
                                    ((RadDropDownList)itemgroup).SelectedIndex = -1;
                                    ((RadDropDownList)itemgroup).Text = "SELECIONE UMA OPÇÃO";
                                }
                                if (itemgroup is RadGridView)
                                {
                                    ((RadGridView)itemgroup).Rows.Clear();
                                }
                                if (itemgroup is RadCheckedListBox)
                                {
                                    foreach (var check in ((RadCheckedListBox)itemgroup).Items)
                                    {
                                        check.CheckState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate;
                                    }
                                }
                                if (item is RadMaskedEditBox)
                                {
                                    ((RadMaskedEditBox)item).Text = string.Empty;
                                }
                            }

                        }

                        if (itemPanel is RadTextBox)
                        {
                            ((RadTextBox)itemPanel).Text = string.Empty;
                        }
                        if (itemPanel is RadDropDownList)
                        {
                            ((RadDropDownList)itemPanel).SelectedIndex = -1;
                            ((RadDropDownList)itemPanel).Text = "SELECIONE UMA OPÇÃO";
                        }
                        if (itemPanel is RadCheckedListBox)
                        {
                            foreach (var check in ((RadCheckedListBox)itemPanel).Items)
                            {
                                check.CheckState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate;
                            }
                        }
                        if (itemPanel is RadMaskedEditBox)
                        {
                            ((RadMaskedEditBox)itemPanel).Text = string.Empty;
                        }
                        if (itemPanel is PictureBox)
                        {
                            ((PictureBox)itemPanel).Image = null;
                        }
                        if (itemPanel is RadRadioButton)
                        {
                            ((RadRadioButton)itemPanel).CheckState = CheckState.Unchecked;
                        }
                    }
                }
                if (item is RadTextBox)
                {
                    ((RadTextBox)item).Text = string.Empty;
                }
                if (item is RadDropDownList)
                {
                    ((RadDropDownList)item).SelectedIndex = -1;
                    ((RadDropDownList)item).Text = "SELECIONE UMA OPÇÃO";
                }
                if (item is RadCheckedListBox)
                {
                    foreach (var check in ((RadCheckedListBox)item).Items)
                    {
                        check.CheckState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate;
                    }
                }
                if (item is RadMaskedEditBox)
                {
                    ((RadMaskedEditBox)item).Text = string.Empty;
                }
                if (item is PictureBox )
                {
                    ((PictureBox)item).Image = null;
                }

                //GRUPO
                if (item is RadGroupBox)
                {
                    foreach (var itemgroup in ((RadGroupBox)item).Controls)
                    {
                        if (itemgroup is RadRadioButton)
                        {
                            ((RadRadioButton)itemgroup).CheckState = CheckState.Unchecked;
                        }
                        if (itemgroup is RadTextBox)
                        {
                            ((RadTextBox)itemgroup).Text = string.Empty;
                        }
                        if (itemgroup is RadDropDownList)
                        {
                            ((RadDropDownList)itemgroup).SelectedIndex = -1;
                            ((RadDropDownList)itemgroup).Text = "SELECIONE UMA OPÇÃO";
                        }
                        if (itemgroup is RadCheckedListBox)
                        {
                            foreach (var check in ((RadCheckedListBox)itemgroup).Items)
                            {
                                check.CheckState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate;
                            }
                        }
                        if (itemgroup is RadMaskedEditBox)
                        {
                            ((RadMaskedEditBox)itemgroup).Text = string.Empty;
                        }
                        if (itemgroup is PictureBox)
                        {
                            ((PictureBox)itemgroup).Image = null;
                        }
                    }
                }
                if (item is RadPageView)
                {
                    foreach (var pages in ((RadPageView)item).Pages)
                    {
                        foreach (var component in pages.Controls)
                        {
                            if (component is RadGroupBox)
                            {
                                foreach (var itemgroup in ((RadGroupBox)component).Controls)
                                {
                                    if (itemgroup is RadRadioButton)
                                    {
                                        ((RadRadioButton)itemgroup).CheckState = CheckState.Unchecked;
                                    }
                                    if (itemgroup is RadTextBox)
                                    {
                                        ((RadTextBox)itemgroup).Text = string.Empty;
                                    }
                                    if (itemgroup is RadDropDownList)
                                    {
                                        ((RadDropDownList)itemgroup).SelectedIndex = -1;
                                        ((RadDropDownList)itemgroup).Text = "SELECIONE UMA OPÇÃO";
                                    }
                                    if (itemgroup is RadGridView)
                                    {
                                        ((RadGridView)itemgroup).Rows.Clear();
                                    }
                                    if (itemgroup is RadCheckedListBox)
                                    {
                                        foreach (var check in ((RadCheckedListBox)itemgroup).Items)
                                        {
                                           check.CheckState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate;
                                        }
                                    }
                                    if (item is RadMaskedEditBox)
                                    {
                                        ((RadMaskedEditBox)item).Text = string.Empty;
                                    }
                                }
                            }
                        }
                        
                    }
                }
            }
        }
        public static byte[] ImageToByteArray(Image imageIn)
        {
            byte[] imagemByte = null;
            if (imageIn != null)
            {
                using (var bitmap = new Bitmap(imageIn))
                {
                    using (var ms = new MemoryStream())
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                        imagemByte = ms.ToArray();
                    }
                }
               
            }
            return imagemByte;
        }

        //public static Image byteArrayToImage(byte[] byteArrayIn)
        //{
        //    Image image = null;
        //    if (byteArrayIn != null)
        //    {
        //        using (var ms = new MemoryStream(byteArrayIn))
        //        {
        //            Image returnImage = Image.FromStream(ms);
        //            image = returnImage;
        //        }
        //    }
        //    return image;
        //}

        public static Image byteArrayToImage2(byte[] byteArrayIn)
        {
            Bitmap bit = null;
            if (byteArrayIn != null)
            {
                using (var mem = new MemoryStream(byteArrayIn))
                {
                    bit = new Bitmap(mem);
                }
            }
            return bit;
        }

        public static string CriptografaHash(string Hash)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Hash);

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < inputBytes.Length; i++)
            {
                sBuilder.Append(inputBytes[i].ToString("X2"));
            }

            return sBuilder.ToString();

        }

        public static bool VerificarHash(string input, string hash)
        {
            StringComparer compara = StringComparer.OrdinalIgnoreCase;

            if (0 == compara.Compare(input, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
