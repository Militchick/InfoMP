using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace InfoMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
            It gets deleted after one pass on Form1.Designer
            so there are here for that
            */

            columns();
        }

        protected void columns()
        {
            vistalista.Columns.Add(new ColumnHeader());
            vistalista.Columns[0].Text = "Archivo";
            vistalista.Columns[0].Width = 150;
            vistalista.Columns.Add(new ColumnHeader());
            vistalista.Columns[1].Text = "Titulo";
            vistalista.Columns[1].Width = 150;
            vistalista.Columns.Add(new ColumnHeader());
            vistalista.Columns[2].Text = "Artista";
            vistalista.Columns[2].Width = 150;
            vistalista.Columns.Add(new ColumnHeader());
            vistalista.Columns[3].Text = "Album";
            vistalista.Columns[3].Width = 150;
            vistalista.Columns.Add(new ColumnHeader());
            vistalista.Columns[4].Text = "Ruta";
            vistalista.Columns[4].Width = 500;
            menuItem1.Enabled = false;
            menuItem2.Enabled = false;
        }

        private void abrirbtn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                vistalista.Clear();
                columns();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "All files (*.*)|*.*|mp3 files (*.mp3)|*.mp3";
                openFileDialog.FilterIndex = 2; //Number Filter of Names and Extensions
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] filePath = openFileDialog.FileNames;
                    int pathLimit = filePath.Length - 1;
                    int pathCount = 0;

                    foreach (string fileName in openFileDialog.SafeFileNames)
                    {
                        if (pathLimit == -1)
                        {
                            //Get the path of specified file
                            string filePathOne = openFileDialog.FileName;
                            //Read the contents of the file into a stream
                            var fileStream = openFileDialog.OpenFile();

                            InfoMP(fileName, filePathOne);
                        }
                        else
                        {
                            if (pathCount <= pathLimit)
                            {
                                var fileStream = openFileDialog.OpenFile();
                                InfoMP(fileName, filePath[pathCount]);
                                pathCount++;
                            }
                        }
                    }
                }
            }
        }

        protected void InfoMP(string name, string filePath)
        {
            try
            {
                using (var r = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    byte first = (byte)r.ReadByte();
                    byte second = (byte)r.ReadByte();
                    byte third = (byte)r.ReadByte();

                    string[] ext = name.Split('.');

                    //If is a file MP3

                    if (ext[ext.Length - 1] == "mp3")
                    {
                        r.Seek(-128, SeekOrigin.End);
                        byte[] data = new byte[128];
                        int read = r.Read(data, 0, 128);

                        if (data[0] == 'T' && data[1] == 'A'
                            && data[2] == 'G')
                        {
                            //Reset Basic Info
                            string title = "";
                            string artist = "";
                            string album = "";
                            string year = "";
                            string comment = "";
                            Etiqueta et = new Etiqueta();

                            //Add Title Info
                            for (int i = 3; i < 33; i++)
                                if (data[i] != 0)
                                    title += Convert.ToChar(data[i]);
                            titulotext.Text = title;
                            et.SetTitle(title);

                            //Add Artist Info
                            for (int i = 33; i < 63; i++)
                                if (data[i] != 0)
                                    artist += Convert.ToChar(data[i]);
                            artistatext.Text = artist;
                            et.SetArtist(artist);

                            //Add Album Info
                            for (int i = 63; i < 93; i++)
                                if (data[i] != 0)
                                    album += Convert.ToChar(data[i]);
                            albumtext.Text = album;
                            et.SetAlbum(album);

                            //Add Year Info
                            for (int i = 93; i < 97; i++)
                                if (data[i] != 0)
                                    year += Convert.ToChar(data[i]);
                            anyotext.Text = year;
                            et.SetYear(year);

                            //Add Comment Info
                            for (int i = 97; i < 127; i++)
                                if (data[i] != 0)
                                    comment += Convert.ToChar(data[i]);
                            comtext.Text = comment;
                            et.SetComment(comment);

                            DetectFile(name, filePath, et);
                        }
                    }
                    else
                    {
                        string message = "Error: Archivo Incompatible";
                        string caption = "Error";
                        MessageBox.Show(message, caption,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    r.Close();
                }
            }
            catch (Exception e)
            {
                string message = "Error: " + e.Message;
                string caption = "Error";
                DialogResult result = MessageBox.Show(message, caption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void DetectFile(string name, string filePath, Etiqueta et)
        {
            string[] ext = name.Split('.');

            if (ext[ext.Length - 1] == "mp3")
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    name, et.GetTitle(), et.GetArtist(), et.GetAlbum(), filePath },
                    -1, Color.Empty, Color.Empty, null);

                vistalista.Items.AddRange(new ListViewItem[] { listViewItem });
            }

        }

        /*
        protected void saving_file(string title, string )
        {
            //Global Count
            int countglobal = 0;

            //Title To Char...
            int countTitle = title.Length;
            char[] titchar = new char[title.Length];
            foreach (char ctit in title)
            {
                titchar[countglobal] = ctit;
                countglobal++;
            }

            countglobal = 0;

            //Char to byte and write to file...
            for (int i = 3; i < 33; i++)
            {
                if (countTitle < 33)
                {
                    data[i] = (byte)titchar[countglobal];
                    countglobal++;
                }
            }
        }
        */

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = vistalista.FocusedItem.SubItems[4].Text;
                string name = vistalista.FocusedItem.SubItems[0].Text;

                using (var r = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    byte first = (byte)r.ReadByte();
                    byte second = (byte)r.ReadByte();
                    byte third = (byte)r.ReadByte();
                    string[] ext = name.Split('.');

                    //If is a file MP3

                    if (ext[ext.Length - 1] == "mp3")
                    {
                        r.Seek(-128, SeekOrigin.End);
                        byte[] data = new byte[128];
                        int read = r.Read(data, 0, 128);
                        DirectoryInfo dir = new DirectoryInfo(".");
                        FileInfo[] fichs = dir.GetFiles();
                        name = "";
                        filePath = ".";
                        Etiqueta et = new Etiqueta();

                        //Check bytes

                        //Reset Basic Info
                        string title = "";
                        string artist = "";
                        string album = "";
                        string year = "";
                        string comment = "";

                        //Reset Extra Info
                        string num = "";
                        string comp = "";
                        string numcd = "";

                        //Add Title Info
                        for (int i = 3; i < 33; i++)
                            if (data[i] != 0)
                                title += Convert.ToChar(data[i]);

                        //Add Artist Info
                        for (int i = 33; i < 63; i++)
                            if (data[i] != 0)
                                artist += Convert.ToChar(data[i]);

                        //Add Album Info
                        for (int i = 63; i < 93; i++)
                            if (data[i] != 0)
                                album += Convert.ToChar(data[i]);

                        //Add Year Info
                        for (int i = 93; i < 97; i++)
                            if (data[i] != 0)
                                year += Convert.ToChar(data[i]);

                        //Add Comment Info
                        for (int i = 97; i < 127; i++)
                            if (data[i] != 0)
                                comment += Convert.ToChar(data[i]);

                        //TODO Add Track Info
                        //TODO Add Comp. Info
                        //TODO Add NumCd Info
                        //TODO Add Image Info

                        //Add Change of atributte if they are different

                        if (title != et.GetTitle())
                            title = et.GetTitle();
                        else if (artist != et.GetArtist())
                            artist = et.GetArtist();
                        else if (album != et.GetAlbum())
                            album = et.GetAlbum();
                        else if (year != et.GetYear())
                            year = et.GetYear();
                        else if (comment != et.GetComment())
                            comment = et.GetComment();
                        else if (num != et.GetNumber())
                            num = et.GetNumber();
                        else if (comp != et.GetComp())
                            comp = et.GetComp();
                        else if (numcd != et.GetNumcd())
                            numcd = et.GetNumcd();

                        if (vistalista.SelectedItems != null)
                        {
                            //TODO Add Save File

                            //Global Count
                            int countglobal = 0;

                            //Title To Char...
                            int countTitle = title.Length;
                            char[] titchar = new char[title.Length];
                            foreach (char ctit in title)
                            {
                                titchar[countglobal] = ctit;
                                countglobal++;
                            }

                            countglobal = 0;

                            //Char to byte and write to file...
                            for (int i = 3; i < 33; i++)
                            {
                                if(countTitle < 33)
                                {
                                    data[i] = (byte)titchar[countglobal];
                                    countglobal++;
                                }
                            }

                            vistalista.Clear();
                            columns();
                            DetectFile(name, filePath, et);
                        }
                    }
                    r.Close();
                }
            }
            catch(Exception e_Save)
            {
                string message = "Error: " + e_Save.Message;
                string caption = "Error";
                DialogResult result = MessageBox.Show(message, caption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ayudabtn_Click(object sender, EventArgs e)
        {
            string message = "Abrir: Abre una canción para modificarla." +
                Environment.NewLine +
                Environment.NewLine +
                "Seleccionar: Selecciona una cancion " +
                "si has abierto varios archivos" +
                Environment.NewLine +
                Environment.NewLine +
                "Guardar: Guarda la cancion seleccionada con " +
                "los cambios correspondientes." +
                Environment.NewLine +
                Environment.NewLine
                + "Ayuda: Muestra este mensaje de ayuda.";
            string caption = "Ayuda";
            DialogResult result = MessageBox.Show(message, caption,
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void titulotext_TextChanged(object sender, EventArgs e)
        {
            Etiqueta eti = new Etiqueta();
            eti.SetTitle(titulotext.Text);
        }

        private void artistatext_TextChanged(object sender, EventArgs e)
        {
            Etiqueta eti = new Etiqueta();
            eti.SetArtist(artistatext.Text);
        }

        private void albumtext_TextChanged(object sender, EventArgs e)
        {
            Etiqueta eti = new Etiqueta();
            eti.SetAlbum(albumtext.Text);
        }

        private void anyotext_TextChanged(object sender, EventArgs e)
        {
            Etiqueta eti = new Etiqueta();
            eti.SetYear(anyotext.Text);
        }

        private void pistatext_TextChanged(object sender, EventArgs e)
        {
            Etiqueta eti = new Etiqueta();
            eti.SetNumber(pistatext.Text);
        }

        private void generotext_TextChanged(object sender, EventArgs e)
        {
            Etiqueta eti = new Etiqueta();
            eti.SetGenre(generotext.Text);
        }

        private void comtext_TextChanged(object sender, EventArgs e)
        {
            Etiqueta eti = new Etiqueta();
            eti.SetComment(comtext.Text);
        }

        private void comptext_TextChanged(object sender, EventArgs e)
        {
            Etiqueta eti = new Etiqueta();
            eti.SetComp(comptext.Text);
        }

        private void numtext_TextChanged(object sender, EventArgs e)
        {
            Etiqueta eti = new Etiqueta();
            eti.SetNumcd(numtext.Text);
        }

        private void vistalista_DobleClick(object sender, EventArgs e)
        {
            try
            {
                if (vistalista.SelectedItems.Count <= 1)
                {
                    string extPathTemplate = vistalista.FocusedItem.SubItems[4].Text;
                    string name = vistalista.FocusedItem.SubItems[0].Text;

                    string[] ext = name.Split('.');

                    if ((ext[ext.Length - 1] == "mp3") || (ext[ext.Length - 1] == "wav"))
                    {
                        Process process = new Process();

                        process.StartInfo.FileName = "wmplayer.exe";
                        process.StartInfo.Arguments = extPathTemplate;
                        process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                        process.Start();
                    }
                }
            }
            catch(Exception e_double)
            {
                string message3 = "Error: " + e_double.Message;
                string caption3 = "Error";
                DialogResult result = MessageBox.Show(message3, caption3,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vistalista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (vistalista.SelectedItems.Count <= 1)
                {
                    if(vistalista.SelectedItems.Count == 1)
                    {
                        menuItem1.Enabled = true;
                        menuItem2.Enabled = true;
                    }
                    else //If is zero Disabled
                    {
                        menuItem1.Enabled = false;
                        menuItem2.Enabled = false;
                    }


                    //Cleaning...

                    titulotext.Text = String.Empty;
                    artistatext.Text = String.Empty;
                    albumtext.Text = String.Empty;
                    pistatext.Text = String.Empty;
                    anyotext.Text = String.Empty;
                    comtext.Text = String.Empty;
                    generotext.Text = String.Empty;
                    comptext.Text = String.Empty;
                    numtext.Text = String.Empty;

                    string filePath = vistalista.FocusedItem.SubItems[4].Text;
                    string name = vistalista.FocusedItem.SubItems[0].Text;
                    
                    using (var r = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        byte first = (byte)r.ReadByte();
                        byte second = (byte)r.ReadByte();
                        byte third = (byte)r.ReadByte();

                        string[] ext = name.Split('.');

                        if (ext[ext.Length - 1] == "mp3")
                        {
                            r.Seek(-128, SeekOrigin.End);
                            byte[] data = new byte[128];
                            int read = r.Read(data, 0, 128);

                            if (data[0] == 'T' && data[1] == 'A'
                                && data[2] == 'G')
                            {
                                //Reset Basic Info
                                string title = "";
                                string artist = "";
                                string album = "";
                                string year = "";
                                string comment = "";
                                Etiqueta et = new Etiqueta();

                                //Add Title Info
                                for (int i = 3; i < 33; i++)
                                    if (data[i] != 0)
                                        title += Convert.ToChar(data[i]);
                                titulotext.Text = title;
                                et.SetTitle(title);

                                //Add Artist Info
                                for (int i = 33; i < 63; i++)
                                    if (data[i] != 0)
                                        artist += Convert.ToChar(data[i]);
                                artistatext.Text = artist;
                                et.SetArtist(artist);

                                //Add Album Info
                                for (int i = 63; i < 93; i++)
                                    if (data[i] != 0)
                                        album += Convert.ToChar(data[i]);
                                albumtext.Text = album;
                                et.SetAlbum(album);

                                //Add Year Info
                                for (int i = 93; i < 97; i++)
                                    if (data[i] != 0)
                                        year += Convert.ToChar(data[i]);
                                anyotext.Text = year;
                                et.SetYear(year);

                                //Add Comment Info
                                for (int i = 97; i < 127; i++)
                                    if (data[i] != 0)
                                        comment += Convert.ToChar(data[i]);
                                comtext.Text = comment;
                                et.SetComment(comment);
                            }
                        }
                    }
                }
                else
                {
                    //Multiple Slections Disabled for now

                    menuItem1.Enabled = false;
                    menuItem2.Enabled = false;

                    titulotext.Text = "<mantener>";
                    artistatext.Text = "<mantener>";
                    albumtext.Text = "<mantener>";
                    pistatext.Text = "<mantener>";
                    anyotext.Text = "<mantener>";
                    comtext.Text = "<mantener>";
                    generotext.Text = "<mantener>";
                    comptext.Text = "<mantener>";
                    numtext.Text = "<mantener>";
                }
            }
            catch (Exception e2)
            {
                string message2 = "Error: " + e2.Message;
                string caption2 = "Error";
                DialogResult result = MessageBox.Show(message2, caption2,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anyadir_Caratula(object sender, EventArgs e)
        {
            if (vistalista.SelectedItems.Count == 1)
            {
                var fileContent = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    vistalista.Clear();
                    columns();
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    openFileDialog.Filter = "All files (*.*)|*.*|PNG files (*.*)|*.png*|JPG files (*.jpg)|*.jpg";
                    openFileDialog.FilterIndex = 3; //Number Filter of Names and Extensions
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.Multiselect = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string[] filePath = openFileDialog.FileNames;
                        int pathLimit = filePath.Length - 1;
                        int pathCount = 0;

                        foreach (string fileName in openFileDialog.SafeFileNames)
                        {
                            if (pathLimit == -1)
                            {
                                //Get the path of specified file
                                string filePathOne = openFileDialog.FileName;
                                //Read the contents of the file into a stream
                                var fileStream = openFileDialog.OpenFile();

                                InfoMP(fileName, filePathOne);
                            }
                            else
                            {
                                if (pathCount <= pathLimit)
                                {
                                    var fileStream = openFileDialog.OpenFile();
                                    InfoMP(fileName, filePath[pathCount]);
                                    pathCount++;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void borrar_Caratula(object sender, EventArgs e)
        {
            //TODO
        }
    }

    public class Etiqueta
    {
        protected string title;
        protected string artist;
        protected string album;
        protected string year;
        protected string num;
        protected string comment;
        protected string genre;
        protected string comp;
        protected string numcd;

        public void SetTitle(string title) { this.title = title; }
        public void SetArtist(string artist) { this.artist = artist; }
        public void SetAlbum(string album) { this.album = album; }
        public void SetYear(string year) { this.year = year; }
        public void SetNumber(string num) { this.num = num; }
        public void SetComment(string comment) { this.comment = comment; }
        public void SetGenre(string genre) { this.genre = genre; }
        public void SetComp(string comp) { this.comp = comp; }
        public void SetNumcd(string numcd) { this.numcd = numcd; }

        public string GetTitle() { return title; }
        public string GetArtist() { return artist; }
        public string GetAlbum() { return album; }
        public string GetYear() { return year; }
        public string GetNumber() { return num; }
        public string GetComment() { return comment; }
        public string GetGenre() { return genre; }
        public string GetComp() { return comp; }
        public string GetNumcd() { return numcd; }
    }

    /*
    public class Archivo
    {
        protected string file;
        protected string path;
        
        public void SetFile(string file) { this.file = file; }
        public void SetPath(string path) { this.path = path; }

        public string GetFile() { return file; }
        public string GetPath() { return path; }
    }
    */
}
